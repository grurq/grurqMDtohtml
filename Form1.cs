using System;
using System.IO;

using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Reflection;


namespace RenametoDate
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             
        }
        private void Ending(object sender, EventArgs e)
        {
            /*
            Properties.Settings.Default.Save();
            Application.ApplicationExit -= new EventHandler(Ending);
             */

            //MessageBox.Show("filename");

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += new EventHandler(this.Ending);
            var asb = Assembly.GetExecutingAssembly();
            if (Properties.Settings.Default.make) { radioButton1.Checked = true; }
                                              else{ radioButton2.Checked = true; }
            if (Properties.Settings.Default.front) { radioButton3.Checked = true; }
                                             else { radioButton4.Checked = true; }
            if (Properties.Settings.Default.label != "") textBox2.Text = Properties.Settings.Default.label;



            AssemblyName nm = asb.GetName();
            product.Text = nm.Name.ToString();
            updated.Text = "Last updated:   " + File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            a_version.Text ="ver:   "+ nm.Version.ToString();
            
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://grurq.github.io/");
            linkLabel2.Links.Add(0, linkLabel2.Text.Length, "https://grurq.github.io/grurqMDtohtml.html");
            linkLabel3.Links.Add(0, linkLabel3.Text.Length, "https://grurq.github.io/grurqMDtohtml-history.html");
            linkLabel4.Links.Add(0, linkLabel4.Text.Length, "https://opensource.org/licenses/mit-license.php");
            linkLabel5.Links.Add(0, linkLabel5.Text.Length, "https://ja.osdn.net/projects/opensource/wiki/licenses%2FMIT_license");

            //System.Environment.GetCommandLineArgs();
            /*
             同じファイルをディレクトリ検索によって調べて、
             一致してしたら_を足す。
             前置の場合
             ラベルYYYYMMDDTTMMSSSS_NNNNNNN
             後置
             YYYYMMDDTTMMSSSSラベル_NNNNNNN
             */
            rnfiles rn = new rnfiles(Properties.Settings.Default.label, Properties.Settings.Default.front, Properties.Settings.Default.make);

            //ここで「オブジェクト参照がオブジェクト インスタンスに設定されていません。」というエラーになる
            if (rn.setdata(System.Environment.GetCommandLineArgs())) {
                //rn.getnewnames();
                rn.rename();
                this.Close(); }
            

        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Links[0].LinkData.ToString());
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel3.Links[0].LinkData.ToString());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel2.Links[0].LinkData.ToString());
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel4.Links[0].LinkData.ToString());
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel5.Links[0].LinkData.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.label = Regex.IsMatch(textBox2.Text, @"\S") ? textBox2.Text:"" ;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.make = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.make = radioButton1.Checked;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save(); 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.front = radioButton3.Checked;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.front = radioButton3.Checked;
        }
    }
}
