using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetApplicationDevelopment;

namespace Minicrawler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (txtboxUrl.Text == string.Empty) return;
            else
            {
                string link = txtboxUrl.Text;
                populateListBox(lstboxFetched, link);
            }
        }

        private void populateListBox(ListBox listBox, string link)
        {
            if (HyperLink.VerifyHyperlink(link))
            {
                string[] links = Crawler.CrawlToGetHyperlinks(link);
                listBox.ClearSelected();
                txtboxUrl.Text = link;
                listBox.Items.Clear();
                foreach (string _link in links)
                    listBox.Items.Add(_link);
            }
        }

        void lstboxFetched_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstboxFetched.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches) return;
            else
            {
                string link = (string) lstboxFetched.Items[index];
                populateListBox(lstboxFetched, link);
            }
        }

    }
}
