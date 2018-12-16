using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using System.Net;
using System.Diagnostics;
using System.Globalization;

namespace Ababu
{
    public partial class CtrlFeedItem : UserControl
    {
        SyndicationItem SyndicationItem { get; set; }

        public CtrlFeedItem(SyndicationItem syndication_item)
        {
            SyndicationItem = syndication_item;

            InitializeComponent();
        }

        private void CtrlFeedItem_Load(object sender, EventArgs e)
        {
            FillControl();
        }


        private void FillControl()
        {
            LblSubject.MaximumSize = new Size(335, 100);
            LblSubject.AutoSize = true;
            LblSubject.LinkBehavior = LinkBehavior.NeverUnderline;
            LblSubject.Text = SyndicationItem.Title.Text;

            TxtSummary.Text = WebUtility.HtmlDecode(SyndicationItem.Summary.Text);
            LblPublishDate.Text = SyndicationItem.PublishDate.ToString("D", CultureInfo.CurrentCulture);
        }

        private void LblSubject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(SyndicationItem.Links[0].Uri.ToString());
            Process.Start(sInfo);
        }
    }
}
