using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMv2
{
    public partial class About : Form
    {
        string LatestVersionStr;
        public About()
        {
            InitializeComponent();
        }
        private void About_Load(object sender, EventArgs e)
        {
            lbNowVersion.Text = "Now Version : " + Application.ProductVersion;
            DownloadFile("https://raw.githubusercontent.com/CRThu/COMAnalysis/master/COMv2/COMv2/bin/Release/version", "version", null);
            StreamReader sr = new StreamReader("version", Encoding.Default);
            LatestVersionStr = sr.ReadLine();
            // version test
            //LatestVersionStr = "2.3.7.2";
            lbLatestVersion.Text = "Latest Version : " + LatestVersionStr;

            string[] NowVersion = Application.ProductVersion.Split('.');
            string[] LatestVersion = LatestVersionStr.Split('.');
            btnUpdate.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                if (Convert.ToInt16(LatestVersion[i]) > Convert.ToInt16(NowVersion[i]))
                {
                    btnUpdate.Enabled = true;
                    break;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DownloadFile("https://github.com/CRThu/COMAnalysis/raw/master/COMv2/COMv2/bin/Release/COMv"+ LatestVersionStr + ".exe", "COMv"+LatestVersionStr+".exe", progressBar1);
            MessageBox.Show("update success!");
        }
        public void DownloadFile(string URL, string filename, System.Windows.Forms.ProgressBar progressBar)
        {
            float percent = 0;
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (progressBar != null)
                {
                    progressBar.Maximum = (int)totalBytes;
                }
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (progressBar != null)
                    {
                        progressBar.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                    //label1.Text = "当前补丁下载进度" + percent.ToString() + "%";
                    System.Windows.Forms.Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }
                so.Close();
                st.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
