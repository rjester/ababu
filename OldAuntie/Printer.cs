using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Printing;
using System.Xml;
using System.Globalization;
using System.IO;

namespace OldAuntie
{
    public class Printer: IDisposable
    {
        private PrintDocument PrintDocument;


        private Layout Layout { get; set; }
        
        // event used at the end of the printing
        public event EventHandler<PrintEventArgs> PrintEventEndPrint;
        public event EventHandler<PrintEventArgs> PrintEventDispose;

        private bool disposed = false;


        public Printer(string printer_name = "")
        {
            PrintDocument = new PrintDocument();
            if(printer_name != "")
            {
                SetPrinter(printer_name);
            }
        }



        public void Print(Layout layout)
        {
            try
            {
                Layout = layout;

                // eseguo la spampa vera e propria
                PrintDocument.PrintPage += PrintDocument_PrintPage;
                PrintDocument.EndPrint += PrintDocument_EndPrint;
                PrintDocument.Print();
            }
            catch(Exception ex)
            {
                Globals.Log.Write(ex.ToString());
                throw ex;
            }
        }



        public void SetPrinter(string printer_name)
        {
            PrintDocument.PrinterSettings.PrinterName = printer_name;
        }





        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.PageUnit = GraphicsUnit.Millimeter;

                // xml layout parsing. Replace fields with values inside xml layout
                string layout_xml = Layout.Render();


                // create the page and print it based on XML structure
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(layout_xml);
                XmlNode layout_node = xml.SelectSingleNode("layout");

                foreach (XmlNode xml_node in layout_node.ChildNodes)
                {
                    if (xml_node.Name == "object")
                    {
                        // object type definition
                        string Type = GetAttribute(xml_node, "type", "");

                        // position definition
                        float x = float.Parse(GetAttribute(xml_node, "x", "0.0F").ToString(), CultureInfo.InvariantCulture.NumberFormat);
                        float y = float.Parse(GetAttribute(xml_node, "y", "0.0F").ToString(), CultureInfo.InvariantCulture.NumberFormat);
                        Int32 width = Convert.ToInt32(GetAttribute(xml_node, "width", "123"));
                        Int32 height = Convert.ToInt32(GetAttribute(xml_node, "height", "123"));

                        // font definition
                        string fontname = GetAttribute(xml_node, "fontname", "Arial");
                        Int32 fontsize = Convert.ToInt32(GetAttribute(xml_node, "fontsize", "12"));
                        string align = GetAttribute(xml_node, "align", "left");

                        // set font color
                        string hex_color = GetAttribute(xml_node, "color", "#000000");
                        ColorConverter color_converter = new ColorConverter();
                        Color color = (Color)color_converter.ConvertFromString(hex_color);
                        SolidBrush brush = new SolidBrush(color);

                        string src = GetAttribute(xml_node, "src", "");
                        string datetimeformat = getSafeXMLStringAttribute(xml_node, "datetimeformat", "");

                        // @todo: controllare che venga davvero utilizzato
                        string SlineSpace = getSafeXMLStringAttribute(xml_node, "linespace", "");

                        // set font style
                        FontStyle fs = FontStyle.Regular;
                        if (GetAttribute(xml_node, "italic", "false") == "true")
                        {
                            fs = fs | FontStyle.Italic;
                        }

                        if (GetAttribute(xml_node, "bold", "false") == "true")
                        {
                            fs = fs | FontStyle.Bold;
                        }

                        
                        Font font = new Font(fontname, fontsize, fs);
                        StringFormat format = new StringFormat();
                        if (align == "center")
                        {
                            format.Alignment = StringAlignment.Center;
                        }

                        // print items based on object type (datetime, text, multiline ecc.)
                        switch (Type)
                        {
                            case "datetime":
                                src = DateTime.Now.ToString(datetimeformat);
                                e.Graphics.DrawString(src, font, brush, x, y, format);
                                break;


                            case "text":
                                string LetterCase = getSafeXMLStringAttribute(xml_node, "lettercase", "");
                                switch (LetterCase.ToUpper())
                                {
                                    case "UPPER":
                                        e.Graphics.DrawString(src.ToUpper(), font, brush, x, y, format);
                                        break;

                                    case "LOWER":
                                        e.Graphics.DrawString(src.ToLower(), font, brush, x, y, format);
                                        break;

                                    default:
                                        e.Graphics.DrawString(src, font, brush, x, y, format);
                                        break;
                                }

                                break;


                            case "multiline":
                                // @todo: eliminare.recupera l'interlinea (non usata qui...)
                                /*
                                float linespace = font.GetHeight(e.Graphics);
                                try
                                {
                                    if (SlineSpace == "" || SlineSpace == null)
                                    {
                                        linespace = font.GetHeight(e.Graphics);
                                    }
                                    else
                                    {
                                        linespace = Convert.ToSingle(SlineSpace);
                                    }
                                }
                                catch
                                {
                                    linespace = font.GetHeight(e.Graphics);
                                }
                                */
                                // allineo il testo al centro orizzontalmente
                                // stringFormat = new StringFormat();
                                
                                // create a rectangle of text dimensions
                                RectangleF rectangle = new RectangleF();
                                rectangle.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                                rectangle.Size = new Size(width, height);
                                // write text inside the rectangle
                                e.Graphics.DrawString(src, font, Brushes.Black, rectangle, format);
                                break;



                            case "image":
                                    Image img = loadLayoutImage(src);
                                    if (img != null)
                                    {
                                        e.Graphics.DrawImage(img, Convert.ToInt32(x), Convert.ToInt32(y), width, height);
                                    }

                                    break;

                            case "shape":
                                    // @todo: shape
                                    Console.WriteLine(5);
                                    break;

                            case "barcode":
                                    BarcodeLib.Barcode BarCodeGenerator = new BarcodeLib.Barcode();
                                    Image bci = BarCodeGenerator.Encode(BarcodeLib.TYPE.CODE39, "*" + src + "*", System.Drawing.Color.Black, System.Drawing.Color.White, width * 100, height * 100);
                                    e.Graphics.DrawImage(bci, Convert.ToInt32(x), Convert.ToInt32(y), width, height);
                                    break;

                            case "qrcode":
                                    try
                                    {
                                        /*
                                        QRCodeGenerator qrGenerator = new QRCodeGenerator();
                                        QRCodeGenerator.QRCode qrCode;
                                        qrCode = qrGenerator.CreateQrCode(src, QRCodeGenerator.ECCLevel.Q);
                                        Bitmap qrbitMap = qrCode.GetGraphic(20);
                                        using ((qrbitMap))
                                            e.Graphics.DrawImage(qrbitMap, Convert.ToInt32(X), Convert.ToInt32(Y), Width, Height);
                                        */
                                    }
                                    catch (Exception ex)
                                    {
                                    }

                                    break;
                        }
                    }
                }


            }
            catch (Exception ex)
            {

            }
        }

        private void PrintDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }


        public static string GetAttribute(XmlNode xml_node, string attribute, string default_value = null)
        {
            string result = String.Empty;
            try
            {
                if (xml_node.Attributes[attribute] == null)
                {
                    result = default_value;
                }
                else
                {
                    result = xml_node.Attributes[attribute].Value;
                }
            }
            catch
            {
                result = default_value;
            }

            return result;
        }


        // @todo @delete @swap with Utility.IfNull
        public static string getSafeXMLStringAttribute(XmlNode xmlObject, string attributeName, string defaultValue = null)
        {
            string result = String.Empty;
            try
            {
                if (xmlObject.Attributes[attributeName] == null)
                {
                    result = defaultValue;
                }
                else
                {
                    result = xmlObject.Attributes[attributeName].Value;
                }
            }
            catch (Exception ex)
            {
                result = defaultValue;
            }

            return result;
        }



        public static double getSafeXMLDoubleAttribute(XmlNode xmlObject, string attributeName, double defaultValue)
        {

            // Legge l'attributo attivuteName dal nodo xmlObject
            // Se esiste e riesce a parsare il valore su un double lo restituisce
            // se non ci riesce restituisce il default value
            // 14 Maggio 2016 Stefano Cupertino x StudioVisio
            double result = 0;
            try
            {
                string stringValue = "";
                if (xmlObject.Attributes[attributeName] == null)
                {
                    result = defaultValue;
                }
                else
                {
                    stringValue = xmlObject.Attributes[attributeName].Value.ToString().Replace(".", ",");
                    if (xmlObject.Attributes[attributeName] == null)
                    {
                        result = defaultValue;
                    }
                    else
                    {
                        double value;
                        if (double.TryParse(stringValue, out value))
                        {
                            // text is convertible to Double, and value contains the Double value now
                            result = value;
                        }
                        else
                        {
                            // Cannot convert text to Double
                            result = defaultValue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = defaultValue;
            }


            return result;
        }


        /*
        public static bool getVisibility(XmlNode myNode)
        {
            return true;

            try
            {
                if (string.IsNullOrEmpty(myNode.Attributes["visibility"].Value))
                {
                    return true;
                }
                else
                {
                    return (myNode.Attributes["visibility"].Value.ToLower() == "true");
                }
            }
            catch (Exception ex)
            {
                return true;
            }
        }
        */

        /*
        public static FontStyle getFontStyle(XmlNode myXML)
        {
            FontStyle fs = FontStyle.Regular;

            if (getSafeXMLStringAttribute(myXML, "italic", "false") == "true")
            {
                fs = fs | FontStyle.Italic;
            }

            if (getSafeXMLStringAttribute(myXML, "bold", "false") == "true")
            {
                fs = fs | FontStyle.Bold;
            }

            return fs;
        }
        */



        public Image loadLayoutImage(string fNAme)
        {
            try
            {
                if (fileExists(fNAme))
                    return Image.FromFile(fNAme);
                else
                    // writeLogFile(Me.GetType().Name & "|loadLayoutImage|Image not Found. FilerName= " & fNAme, 9)
                    return null/* TODO Change to default(_) if this is not a reference type */;
            }
            catch (Exception ex)
            {
                // writeLogFile(Me.GetType().Name & "|loadLayoutImage|" & ex.Message, 9)
                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }



        public static bool fileExists(string myPath)
        {
            // Verifica le myPath non sia nullo e che il file puntatio esista
            // Funzione fatta per controllare in un colpo solo la non nullità del valore
            // e l'esistenza del file
            bool fileExists = false;
            try
            {
                if (myPath != "")
                {
                    if (File.Exists(myPath))
                    {
                        fileExists = true;
                    }
                }
            }
            catch (Exception ex)
            {
                fileExists = false;
            }
            return fileExists;
        }





        public void Dispose()
        {
            // PrintEventDispose?.Invoke(this, new PrintEventArgs("done"));

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposed == false)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                // Free other state (managed objects).
                disposed = true;
            }
        }
    }



    // @todo: @deprecated probably to be reviewd or deleted
    public class PrintEventArgs : EventArgs
    {
        public PrintEventArgs(string _PrinterMessage)
        { PrinterMessage = _PrinterMessage; }

        public string PrinterMessage { get; set; }

    }

}
