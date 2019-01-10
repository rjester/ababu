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

                // xml layout parsing
                string layout_xml = Layout.Render();


                // create the page and print it based on XML structure
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(layout_xml);
                XmlNode LayoutNode = xml.SelectSingleNode("layout");




                foreach (XmlNode layoutchildNode in LayoutNode.ChildNodes)
                {
                    if (layoutchildNode.Name == "object")
                    {
                        string Type = getSafeXMLStringAttribute(layoutchildNode, "type", "");

                        // string Type = Utility.IfNull(layoutchildNode.Attributes["type"], "");


                        float X = float.Parse(getSafeXMLDoubleAttribute(layoutchildNode, "x", 0).ToString(), CultureInfo.InvariantCulture.NumberFormat); // * UnitCovert
                        float Y = float.Parse(getSafeXMLDoubleAttribute(layoutchildNode, "y", 0).ToString(), CultureInfo.InvariantCulture.NumberFormat); // * UnitCovert
                        Int32 Width = Convert.ToInt32(getSafeXMLDoubleAttribute(layoutchildNode, "width", 100)); // * UnitCovert
                        Int32 Height = Convert.ToInt32(getSafeXMLDoubleAttribute(layoutchildNode, "height", 100)); // * UnitCovert
                        string fontName = getSafeXMLStringAttribute(layoutchildNode, "fontname", "Arial");
                        Int32 FontSize = Convert.ToInt32(getSafeXMLDoubleAttribute(layoutchildNode, "fontsize", 12));
                        string align = getSafeXMLStringAttribute(layoutchildNode, "align", "left");
                        string Color = getSafeXMLStringAttribute(layoutchildNode, "color", "FFFFFF");
                        string src = getSafeXMLStringAttribute(layoutchildNode, "src", "");
                        string datetimeformat = getSafeXMLStringAttribute(layoutchildNode, "datetimeformat", "");

                        // @todo: controllare che venga davvero utilizzato
                        string SlineSpace = getSafeXMLStringAttribute(layoutchildNode, "linespace", "");

                        FontStyle fs = getFontStyle(layoutchildNode);
                        // @todo: delete me ... (not used ???)
                        // string[] printableOptions = Person.options.ToString().Split(';');

                        // @todo: 
                        // bool isPrintable = getOptionAttribute(layoutchildNode, printableOptions);
                        bool isVisible = getVisibility(layoutchildNode);
                        // bool isPrintable = true;
                        switch (Type)
                        {
                            case "datetime":
                                {
                                    if (isVisible)
                                    {
                                        Font printFont = new Font(fontName, FontSize, fs);
                                        StringFormat stringFormat = new StringFormat();
                                        if (align == "center")
                                        {
                                            stringFormat.Alignment = StringAlignment.Center;
                                        }
                                        src = DateTime.Now.ToString(datetimeformat);
                                        e.Graphics.DrawString(src, printFont, Brushes.Black, X, Y, stringFormat);
                                    }

                                    break;
                                }


                            case "text":
                                {
                                    if (isVisible)
                                    {
                                        Font printFont = new Font(fontName, FontSize, fs);
                                        StringFormat stringFormat = new StringFormat();
                                        if (align == "center")
                                        {
                                            stringFormat.Alignment = StringAlignment.Center;
                                        }
                                        string LetterCase = getSafeXMLStringAttribute(layoutchildNode, "lettercase", "");
                                        switch (LetterCase.ToUpper())
                                        {
                                            case "UPPER":
                                                {
                                                    e.Graphics.DrawString(src.ToUpper(), printFont, Brushes.Black, X, Y, stringFormat);
                                                    break;
                                                }

                                            case "LOWER":
                                                {
                                                    e.Graphics.DrawString(src.ToLower(), printFont, Brushes.Black, X, Y, stringFormat);
                                                    break;
                                                }

                                            default:
                                                {
                                                    e.Graphics.DrawString(src, printFont, Brushes.Black, X, Y, stringFormat);
                                                    break;
                                                }
                                        }
                                    }

                                    break;
                                }


                            case "multiline":
                                if (isVisible)
                                {
                                    // crea un oggetto Font da utilizzare per la stampa
                                    Font printFont = new Font(fontName, FontSize, fs);

                                    // @todo: eliminare.recupera l'interlinea (non usata qui...)
                                    float linespace = printFont.GetHeight(e.Graphics);
                                    try
                                    {
                                        if (SlineSpace == "" || SlineSpace == null)
                                        {
                                            linespace = printFont.GetHeight(e.Graphics);
                                        }
                                        else
                                        {
                                            linespace = Convert.ToSingle(SlineSpace);
                                        }
                                    }
                                    catch
                                    {
                                        linespace = printFont.GetHeight(e.Graphics);
                                    }

                                    // allineo il testo al centro orizzontalmente
                                    StringFormat stringFormat = new StringFormat();
                                    if (align == "center")
                                    {
                                        stringFormat.Alignment = StringAlignment.Center;
                                    }

                                    // creo un rettangolo delle dimensioni del testo
                                    RectangleF rectangle = new RectangleF();
                                    rectangle.Location = new Point(Convert.ToInt32(X), Convert.ToInt32(Y));
                                    // rectangle.Size = new Size(Convert.ToInt32(LayOutWidth), ((int)ev.Graphics.MeasureString(src, printFont, Convert.ToInt32(LayOutWidth), StringFormat.GenericTypographic).Height));
                                    rectangle.Size = new Size(Width, Height);
                                    // scrivo il testo (...dentro il rettangolo)
                                    e.Graphics.DrawString(src, printFont, Brushes.Black, rectangle, stringFormat);
                                }
                                break;



                            case "image":
                                {
                                    if (isVisible)
                                    {
                                        Image img = loadLayoutImage(src);
                                        if (img != null)
                                            e.Graphics.DrawImage(img, Convert.ToInt32(X), Convert.ToInt32(Y), Width, Height);
                                    }

                                    break;
                                }

                            case "shape":
                                {
                                    if (isVisible)
                                    {
                                        // TODO mettere shape
                                        Console.WriteLine(5);
                                    }
                                    break;
                                }

                            case "barcode":
                                {
                                    if (isVisible)
                                    {
                                        BarcodeLib.Barcode BarCodeGenerator = new BarcodeLib.Barcode();
                                        Image bci = BarCodeGenerator.Encode(BarcodeLib.TYPE.CODE39, "*" + src + "*", System.Drawing.Color.Black, System.Drawing.Color.White, Width * 100, Height * 100);
                                        e.Graphics.DrawImage(bci, Convert.ToInt32(X), Convert.ToInt32(Y), Width, Height);
                                    }

                                    break;
                                }

                            case "qrcode":
                                {
                                    if (isVisible)
                                    {
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
                                    }

                                    break;
                                }
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



        public static FontStyle getFontStyle(XmlNode myXML)
        {
            FontStyle fs = FontStyle.Regular;

            if (getSafeXMLStringAttribute(myXML, "italic", "false") == "true")
                fs = fs | FontStyle.Italic;

            if (getSafeXMLStringAttribute(myXML, "bold", "false") == "true")
                fs = fs | FontStyle.Bold;

            return fs;
        }




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
