namespace MDtohtml
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.updated = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.a_version = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonundo = new System.Windows.Forms.Button();
            this.textBoxheader = new System.Windows.Forms.TextBox();
            this.textBoxfooter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxhf = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonb = new System.Windows.Forms.RadioButton();
            this.radioButtonstrong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonsjis = new System.Windows.Forms.RadioButton();
            this.radioButtonUTF8 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonu = new System.Windows.Forms.RadioButton();
            this.radioButtonem = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxnotcopy = new System.Windows.Forms.CheckBox();
            this.radioButtonhtm = new System.Windows.Forms.RadioButton();
            this.radioButtonhtml = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.updated);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.linkLabel2);
            this.tabPage3.Controls.Add(this.linkLabel5);
            this.tabPage3.Controls.Add(this.linkLabel4);
            this.tabPage3.Controls.Add(this.a_version);
            this.tabPage3.Controls.Add(this.copyright);
            this.tabPage3.Controls.Add(this.product);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(425, 280);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "概要";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // updated
            // 
            this.updated.AutoSize = true;
            this.updated.Location = new System.Drawing.Point(46, 54);
            this.updated.Name = "updated";
            this.updated.Size = new System.Drawing.Size(45, 12);
            this.updated.TabIndex = 11;
            this.updated.Text = "updated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "公式サイト：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Released under the MIT license";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(277, 249);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "index";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(48, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(321, 127);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.linkLabel2.Location = new System.Drawing.Point(315, 249);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 12);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ソフト説明";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(304, 78);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(65, 12);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "（日本語訳）";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(234, 78);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(64, 12);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "MIT license";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // a_version
            // 
            this.a_version.AutoSize = true;
            this.a_version.Location = new System.Drawing.Point(46, 42);
            this.a_version.Name = "a_version";
            this.a_version.Size = new System.Drawing.Size(52, 12);
            this.a_version.TabIndex = 6;
            this.a_version.Text = "a_version";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(46, 66);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(162, 12);
            this.copyright.TabIndex = 5;
            this.copyright.Text = "Copyright ©  2020 grurqApps  ";
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.product.Location = new System.Drawing.Point(44, 17);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(80, 20);
            this.product.TabIndex = 4;
            this.product.Text = "product";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonsave);
            this.tabPage2.Controls.Add(this.buttonundo);
            this.tabPage2.Controls.Add(this.textBoxheader);
            this.tabPage2.Controls.Add(this.textBoxfooter);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.checkBoxhf);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "定型句";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonsave
            // 
            this.buttonsave.Enabled = false;
            this.buttonsave.Location = new System.Drawing.Point(362, 41);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(48, 21);
            this.buttonsave.TabIndex = 7;
            this.buttonsave.Text = "保存";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttonundo
            // 
            this.buttonundo.Enabled = false;
            this.buttonundo.Location = new System.Drawing.Point(293, 41);
            this.buttonundo.Name = "buttonundo";
            this.buttonundo.Size = new System.Drawing.Size(63, 21);
            this.buttonundo.TabIndex = 6;
            this.buttonundo.Text = "元に戻す";
            this.buttonundo.UseVisualStyleBackColor = true;
            this.buttonundo.Click += new System.EventHandler(this.buttonundo_Click);
            // 
            // textBoxheader
            // 
            this.textBoxheader.AcceptsReturn = true;
            this.textBoxheader.Location = new System.Drawing.Point(22, 84);
            this.textBoxheader.Multiline = true;
            this.textBoxheader.Name = "textBoxheader";
            this.textBoxheader.ReadOnly = true;
            this.textBoxheader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxheader.Size = new System.Drawing.Size(388, 86);
            this.textBoxheader.TabIndex = 2;
            // 
            // textBoxfooter
            // 
            this.textBoxfooter.AcceptsReturn = true;
            this.textBoxfooter.Location = new System.Drawing.Point(22, 188);
            this.textBoxfooter.Multiline = true;
            this.textBoxfooter.Name = "textBoxfooter";
            this.textBoxfooter.ReadOnly = true;
            this.textBoxfooter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxfooter.Size = new System.Drawing.Size(388, 86);
            this.textBoxfooter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "本文後";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "本文前";
            // 
            // checkBoxhf
            // 
            this.checkBoxhf.AutoSize = true;
            this.checkBoxhf.Location = new System.Drawing.Point(22, 15);
            this.checkBoxhf.Name = "checkBoxhf";
            this.checkBoxhf.Size = new System.Drawing.Size(124, 16);
            this.checkBoxhf.TabIndex = 1;
            this.checkBoxhf.Text = "前後に定型文を挟む";
            this.checkBoxhf.UseVisualStyleBackColor = true;
            this.checkBoxhf.CheckedChanged += new System.EventHandler(this.checkBoxhf_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "保存と変換";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonb);
            this.groupBox4.Controls.Add(this.radioButtonstrong);
            this.groupBox4.Location = new System.Drawing.Point(19, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 45);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "**～**/__～__の変換タグ";
            // 
            // radioButtonb
            // 
            this.radioButtonb.AutoSize = true;
            this.radioButtonb.Location = new System.Drawing.Point(208, 19);
            this.radioButtonb.Name = "radioButtonb";
            this.radioButtonb.Size = new System.Drawing.Size(41, 16);
            this.radioButtonb.TabIndex = 1;
            this.radioButtonb.Text = "<b>";
            this.radioButtonb.UseVisualStyleBackColor = true;
            // 
            // radioButtonstrong
            // 
            this.radioButtonstrong.AutoSize = true;
            this.radioButtonstrong.Checked = true;
            this.radioButtonstrong.Location = new System.Drawing.Point(19, 19);
            this.radioButtonstrong.Name = "radioButtonstrong";
            this.radioButtonstrong.Size = new System.Drawing.Size(67, 16);
            this.radioButtonstrong.TabIndex = 0;
            this.radioButtonstrong.TabStop = true;
            this.radioButtonstrong.Text = "<strong>";
            this.radioButtonstrong.UseVisualStyleBackColor = true;
            this.radioButtonstrong.CheckedChanged += new System.EventHandler(this.radioButtonstrong_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonsjis);
            this.groupBox2.Controls.Add(this.radioButtonUTF8);
            this.groupBox2.Location = new System.Drawing.Point(19, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 45);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "エンコード";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButtonsjis
            // 
            this.radioButtonsjis.AutoSize = true;
            this.radioButtonsjis.Location = new System.Drawing.Point(208, 18);
            this.radioButtonsjis.Name = "radioButtonsjis";
            this.radioButtonsjis.Size = new System.Drawing.Size(70, 16);
            this.radioButtonsjis.TabIndex = 1;
            this.radioButtonsjis.Text = "Shift-JIS";
            this.radioButtonsjis.UseVisualStyleBackColor = true;
            this.radioButtonsjis.CheckedChanged += new System.EventHandler(this.radioButtonsjis_CheckedChanged);
            // 
            // radioButtonUTF8
            // 
            this.radioButtonUTF8.AutoSize = true;
            this.radioButtonUTF8.Checked = true;
            this.radioButtonUTF8.Location = new System.Drawing.Point(19, 19);
            this.radioButtonUTF8.Name = "radioButtonUTF8";
            this.radioButtonUTF8.Size = new System.Drawing.Size(57, 16);
            this.radioButtonUTF8.TabIndex = 0;
            this.radioButtonUTF8.TabStop = true;
            this.radioButtonUTF8.Text = "UTF-8";
            this.radioButtonUTF8.UseVisualStyleBackColor = true;
            this.radioButtonUTF8.CheckedChanged += new System.EventHandler(this.radioButtonUTF8_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonu);
            this.groupBox3.Controls.Add(this.radioButtonem);
            this.groupBox3.Location = new System.Drawing.Point(19, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 45);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "*～*/_～_の変換タグ";
            // 
            // radioButtonu
            // 
            this.radioButtonu.AutoSize = true;
            this.radioButtonu.Location = new System.Drawing.Point(208, 19);
            this.radioButtonu.Name = "radioButtonu";
            this.radioButtonu.Size = new System.Drawing.Size(41, 16);
            this.radioButtonu.TabIndex = 1;
            this.radioButtonu.Text = "<u>";
            this.radioButtonu.UseVisualStyleBackColor = true;
            // 
            // radioButtonem
            // 
            this.radioButtonem.AutoSize = true;
            this.radioButtonem.Checked = true;
            this.radioButtonem.Location = new System.Drawing.Point(19, 19);
            this.radioButtonem.Name = "radioButtonem";
            this.radioButtonem.Size = new System.Drawing.Size(50, 16);
            this.radioButtonem.TabIndex = 0;
            this.radioButtonem.TabStop = true;
            this.radioButtonem.Text = "<em>";
            this.radioButtonem.UseVisualStyleBackColor = true;
            this.radioButtonem.CheckedChanged += new System.EventHandler(this.radioButtonem_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxnotcopy);
            this.groupBox1.Controls.Add(this.radioButtonhtm);
            this.groupBox1.Controls.Add(this.radioButtonhtml);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 45);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "htmlファイルの修飾子";
            // 
            // checkBoxnotcopy
            // 
            this.checkBoxnotcopy.AutoSize = true;
            this.checkBoxnotcopy.Location = new System.Drawing.Point(208, 18);
            this.checkBoxnotcopy.Name = "checkBoxnotcopy";
            this.checkBoxnotcopy.Size = new System.Drawing.Size(135, 16);
            this.checkBoxnotcopy.TabIndex = 6;
            this.checkBoxnotcopy.Text = "変換元のファイルを消す";
            this.checkBoxnotcopy.UseVisualStyleBackColor = true;
            this.checkBoxnotcopy.CheckedChanged += new System.EventHandler(this.checkBoxnotcopy_CheckedChanged);
            // 
            // radioButtonhtm
            // 
            this.radioButtonhtm.AutoSize = true;
            this.radioButtonhtm.Location = new System.Drawing.Point(114, 18);
            this.radioButtonhtm.Name = "radioButtonhtm";
            this.radioButtonhtm.Size = new System.Drawing.Size(42, 16);
            this.radioButtonhtm.TabIndex = 1;
            this.radioButtonhtm.Text = "htm";
            this.radioButtonhtm.UseVisualStyleBackColor = true;
            this.radioButtonhtm.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonhtml
            // 
            this.radioButtonhtml.AutoSize = true;
            this.radioButtonhtml.Checked = true;
            this.radioButtonhtml.Location = new System.Drawing.Point(19, 18);
            this.radioButtonhtml.Name = "radioButtonhtml";
            this.radioButtonhtml.Size = new System.Drawing.Size(45, 16);
            this.radioButtonhtml.TabIndex = 0;
            this.radioButtonhtml.TabStop = true;
            this.radioButtonhtml.Text = "html";
            this.radioButtonhtml.UseVisualStyleBackColor = true;
            this.radioButtonhtml.CheckedChanged += new System.EventHandler(this.radioButtonhtml_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 306);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 304);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "grurqMDtohtml の設定";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonundo;
        private System.Windows.Forms.TextBox textBoxheader;
        private System.Windows.Forms.TextBox textBoxfooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxhf;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonb;
        private System.Windows.Forms.RadioButton radioButtonstrong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonsjis;
        private System.Windows.Forms.RadioButton radioButtonUTF8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonu;
        private System.Windows.Forms.RadioButton radioButtonem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxnotcopy;
        private System.Windows.Forms.RadioButton radioButtonhtm;
        private System.Windows.Forms.RadioButton radioButtonhtml;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label a_version;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label updated;
    }
}

