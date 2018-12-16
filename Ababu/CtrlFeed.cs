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
using OldAuntie;

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
            FlpFeed.Controls.Clear();
            if (BackgroundWorker.IsBusy == false)
            {
                BackgroundWorker.RunWorkerAsync();
            }
        }


        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (XmlReader reader = XmlReader.Create(Globals.FEED_URL))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                BeginInvoke(new Action(delegate ()
                {
                    if (feed.Items.Count() > 0)
                    {
                        TsFeed.Visible = false;
                        foreach (SyndicationItem item in feed.Items)
                        {
                            CtrlFeedItem ctrlFeedItem = new CtrlFeedItem(item);
                            FlpFeed.Controls.Add(ctrlFeedItem);
                        }
                    }
                }));
            }
        }


        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage.ToString());
        }



        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // MessageBox.Show("work completed");
        }

        
        private void TsbRetry_Click(object sender, EventArgs e)
        {
            FillControl();
        }
    }
}
