using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MDtohtml
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


        private void Form1_Load(object sender, EventArgs e)
        {
            
            string rtntext;
            string writeextension="html";
            
            int i;

            if (Properties.Settings.Default.newfileadd == "") {
                Properties.Settings.Default.newfileadd = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                
                Properties.Settings.Default.Save();
            }
            else
            {

            }
            


            textBoxheader.Text = Properties.Settings.Default.headertext;
            textBoxfooter.Text = Properties.Settings.Default.footertext;

            if (Properties.Settings.Default.hdfton) {
                textBoxheader.ReadOnly = false;
                textBoxfooter.ReadOnly = false;

                checkBoxhf.Checked = true;
                textBoxfooter.ReadOnly = !(checkBoxhf.Checked);
                textBoxheader.ReadOnly = !(checkBoxhf.Checked);


            }
            if (Properties.Settings.Default.nocopy) { checkBoxnotcopy.Checked = true; }
            //if (Properties.Settings.Default.encchange) { checkBoxenc.Checked = true; }
            if (Properties.Settings.Default.htm) { radioButtonhtm.Checked = true; }
            if (Properties.Settings.Default.sjis) { radioButtonsjis.Checked = true; }
            if (Properties.Settings.Default.underline) { radioButtonu.Checked = true; }
            if (Properties.Settings.Default.bold) { radioButtonb.Checked = true; }

            //System.Environment.GetFolderPath(Environment.SpecialFolder.Personal
            //https://dobon.net/vb/dotnet/programing/dropfiletoexe.html
            //コマンドライン引数を配列で取得する
            
            string[] enc = { "shift_jis","utf-8"};
            int no = 0;

            if (radioButtonUTF8.Checked) no++;
            System.Text.Encoding renc = System.Text.Encoding.GetEncoding(enc[no]);
            System.Text.Encoding wenc = renc;


            string[] files = System.Environment.GetCommandLineArgs();
            if (files.Length > 1)
            {


                //配列の先頭には実行ファイルのパスが入っているので、
                //2番目以降がドロップされたファイルのパスになる
                //https://dobon.net/vb/dotnet/file/readfile.html
                for (i = 1; i < files.Length; i++)
                {

                                  
                    string vs= System.IO.File.ReadAllText(files[i], renc);
                    
                    if (Properties.Settings.Default.nocopy) File.Delete(files[i]);
                    if (Properties.Settings.Default.htm)writeextension = "htm";
                    
                    //http://dobon.net/vb/dotnet/file/changeextension.html
                    //http://dobon.net/vb/dotnet/file/pathclass.html
                    files[i] = System.IO.Path.ChangeExtension(files[i],writeextension);
                    tlanslate tl = new tlanslate();



                    rtntext = tl.tlanslation(vs, Properties.Settings.Default.underline, Properties.Settings.Default.bold);

                    if (Properties.Settings.Default.hdfton)rtntext = string.Concat(Properties.Settings.Default.headertext, "\r\n", rtntext, "\r\n", Properties.Settings.Default.footertext);
                    
                        File.WriteAllText(files[i], rtntext, wenc);
                    
                }
                this.Close();
            }
            else
            {
               
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonUTF8_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonUTF8.Checked) { Properties.Settings.Default.sjis = false; } else { Properties.Settings.Default.sjis = true; }
            Properties.Settings.Default.Save();
        }

        private void checkBoxhf_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.hdfton = checkBoxhf.Checked;
            buttonundo.Enabled = checkBoxhf.Checked;
            buttonsave.Enabled = checkBoxhf.Checked;

            textBoxfooter.ReadOnly = !(checkBoxhf.Checked);
            textBoxheader.ReadOnly = !(checkBoxhf.Checked);

            if (checkBoxhf.Checked) {
                Properties.Settings.Default.Save();
            } 
            else if(textBoxheader.Text != Properties.Settings.Default.headertext|| textBoxfooter.Text != Properties.Settings.Default.footertext)
                {
                    DialogResult dr=
                    MessageBox.Show("文が変更されています。\r\n保存しますか？", "確認",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    switch (dr)
                    {
                    case DialogResult.OK:
                        Properties.Settings.Default.headertext = textBoxheader.Text;
                        Properties.Settings.Default.footertext = textBoxfooter.Text;
                        Properties.Settings.Default.Save();
                        break;
                    default:
                        textBoxheader.Text = Properties.Settings.Default.headertext;
                        textBoxfooter.Text = Properties.Settings.Default.footertext;
                        break;
                    }    

                }
            
               
                
        }

        private void buttonundo_Click(object sender, EventArgs e)
        {
            textBoxheader.Text = Properties.Settings.Default.headertext;
            textBoxfooter.Text = Properties.Settings.Default.footertext;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.headertext= textBoxheader.Text ;
             Properties.Settings.Default.footertext= textBoxfooter.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxnotcopy_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.nocopy = checkBoxnotcopy.Checked;
            Properties.Settings.Default.Save();
        }
    


        private void radioButtonhtml_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonhtml.Checked) { Properties.Settings.Default.htm = false; } else { Properties.Settings.Default.htm = true; }
            Properties.Settings.Default.Save();
        }

        private void radioButtonsjis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonem.Checked) { Properties.Settings.Default.underline = false; } else { Properties.Settings.Default.underline = true; }
            Properties.Settings.Default.Save() ;
        }

        private void radioButtonstrong_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonstrong.Checked) { Properties.Settings.Default.bold = false; } else { Properties.Settings.Default.bold = true; }
            Properties.Settings.Default.Save();
        }

        private void checkBoxenc_CheckedChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.encchange= checkBoxenc.Checked;
            Properties.Settings.Default.Save();
        }


    }
}
