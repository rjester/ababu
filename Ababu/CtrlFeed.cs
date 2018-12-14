using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Net;
using System.IO;

namespace Ababu
{
    public partial class CtrlFeed : UserControl
    {
        BackgroundWorker BackgroundWorker = new BackgroundWorker();

        public CtrlFeed()
        {
            InitializeComponent();
        }

        private void CtrlFeed_Load(object sender, EventArgs e)
        {
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            BackgroundWorker.WorkerReportsProgress = true;

            FillControl();
        }


        private void FillControl()
        {
            TspFeed.Value = 0;
            TxtFeed.Text = "";
            if (BackgroundWorker.IsBusy == false)
            {
                BackgroundWorker.RunWorkerAsync();
            }
        }


        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "http://www.oldauntie.org/feed";
            
            using (XmlReader reader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                string content = "";

                int i = 1;
                int count = feed.Items.Count();


                Rss20FeedFormatter rss = new Rss20FeedFormatter(feed);


                foreach (SyndicationItem item in feed.Items)
                {
                    i++;
                    int progress = (i / count) * 100;
                    BackgroundWorker.ReportProgress(progress);

                    string subject = item.Title.Text;
                    string summary = item.Summary.Text;
                    content += subject + Environment.NewLine + summary + Environment.NewLine + Environment.NewLine;
                }

                TxtFeed.BeginInvoke(new Action(delegate ()
                {
                    TxtFeed.Text = content;
                }));
            }
        }


        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage.ToString());

            this.Invoke(new Action(delegate ()
            {
                TspFeed.Value = e.ProgressPercentage;
            }));
        }



        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // MessageBox.Show("work completed");
            // BackgroundWorker.CancelAsync();
            // TspFeed.Value = 0;
        }



        private void TsbFeedReload_Click(object sender, EventArgs e)
        {
            FillControl();
        }
    }
}
