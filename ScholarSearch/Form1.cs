using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://scholar.google.co.jp/scholar?";

            if (langCheck.Checked)
            {
                url += "lr=lang_ja&";
            }
            if (!detailCheck.Checked)
            {
                url += "&q=" + mainInput.Text;
            }
            else
            {
                url += "as_q=" + detailInputAnd.Text;
                url += "&as_epq=" + detailInputPhrase.Text;
                url += "&as_oq=" + detailInputOr.Text;
                url += "&as_eq=" + detailInputNo.Text;
                url += "&as_occt=" + ((detailInputRegion.Text == "記事全体") ? "any" : "title");
                url += "&as_sauthors=" + detailInputAuthor.Text;
                url += "&as_publication=" + detailInputPublication.Text;
                url += "&as_ylo=" + detailInputDayFrom.Text;
                url += "&as_yhi=" + detailInputDayTo.Text;
                url += "&hl=ja&as_sdt=0%2C5";
            }
            MessageBox.Show(url);
            System.Diagnostics.Process.Start(url);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(300, 110);
            this.MaximumSize = new Size(300, 110);
        }

        private void detailCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (detailCheck.Checked)
            {
                this.MaximumSize = new Size(300, 300);
                this.Size = new Size(300, 300);
                mainInput.Enabled = false;
            }
            else
            {
                this.Size = new Size(300, 110);
                this.MaximumSize = new Size(300, 110);
                mainInput.Enabled = true;
            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                string url = "http://scholar.google.co.jp/scholar?";

                if (langCheck.Checked)
                {
                    url += "lr=lang_ja&";
                }
                url += "&q=" + mainInput.Text;
                System.Diagnostics.Process.Start(url);
            }
        }

        private void 終了ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                this.Visible = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            notifyIcon1.Visible = false;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
        }
    }
}
