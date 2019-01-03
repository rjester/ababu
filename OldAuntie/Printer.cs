using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Printing;
using System.Xml;

namespace OldAuntie
{
    class Printer: IDisposable
    {
        private PrintDocument PrintDocument;


        private Layout Layout { get; set; }
        
        // event used at the end of the printing
        public event EventHandler<PrintEventArgs> PrintEventEndPrint;
        public event EventHandler<PrintEventArgs> PrintEventDispose;

        private bool disposed = false;


        public Printer(Layout layout)
        {
            Layout = layout;
        }



        public void Print()
        {
            PrintDocument = new PrintDocument();
            // SetPrinter(print_type);

            // eseguo la spampa vera e propria
            PrintDocument.PrintPage += PrintDocument_PrintPage;
            PrintDocument.EndPrint += PrintDocument_EndPrint;
            PrintDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.PageUnit = GraphicsUnit.Millimeter;

                // xml layout parsing
                string layout_xml = Layout.Xml;
                // layout_xml = layout_xml.Replace("[eventname]", Evento.Name);



                // create the page and print it based on XML structure
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(layout_xml);
                XmlNode LayoutNode = doc.SelectSingleNode("layout");


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
