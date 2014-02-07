namespace ScholarSearch
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.終了ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detailCheck = new System.Windows.Forms.CheckBox();
            this.detailInputAnd = new System.Windows.Forms.TextBox();
            this.detailInputPhrase = new System.Windows.Forms.TextBox();
            this.detailInputOr = new System.Windows.Forms.TextBox();
            this.detailInputAuthor = new System.Windows.Forms.TextBox();
            this.detailInputPublication = new System.Windows.Forms.TextBox();
            this.detailInputDayFrom = new System.Windows.Forms.TextBox();
            this.detailInputDayTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.detailInputRegion = new System.Windows.Forms.ComboBox();
            this.langCheck = new System.Windows.Forms.CheckBox();
            this.detailInputNot = new System.Windows.Forms.Label();
            this.detailInputNo = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // mainInput
            // 
            this.mainInput.Location = new System.Drawing.Point(12, 29);
            this.mainInput.Name = "mainInput";
            this.mainInput.Size = new System.Drawing.Size(176, 19);
            this.mainInput.TabIndex = 1;
            this.mainInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainInput_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ScholarSearch";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 終了ToolStripMenuItem1
            // 
            this.終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1";
            this.終了ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.終了ToolStripMenuItem1.Text = "終了";
            this.終了ToolStripMenuItem1.Click += new System.EventHandler(this.終了ToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "すべてを含む";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "フレーズを含む";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "いずれかを含む";
            // 
            // detailCheck
            // 
            this.detailCheck.AutoSize = true;
            this.detailCheck.Location = new System.Drawing.Point(12, 54);
            this.detailCheck.Name = "detailCheck";
            this.detailCheck.Size = new System.Drawing.Size(48, 16);
            this.detailCheck.TabIndex = 7;
            this.detailCheck.Text = "詳細";
            this.detailCheck.UseVisualStyleBackColor = true;
            this.detailCheck.CheckedChanged += new System.EventHandler(this.detailCheck_CheckedChanged);
            // 
            // detailInputAnd
            // 
            this.detailInputAnd.Location = new System.Drawing.Point(104, 73);
            this.detailInputAnd.Name = "detailInputAnd";
            this.detailInputAnd.Size = new System.Drawing.Size(151, 19);
            this.detailInputAnd.TabIndex = 8;
            // 
            // detailInputPhrase
            // 
            this.detailInputPhrase.Location = new System.Drawing.Point(104, 94);
            this.detailInputPhrase.Name = "detailInputPhrase";
            this.detailInputPhrase.Size = new System.Drawing.Size(151, 19);
            this.detailInputPhrase.TabIndex = 9;
            // 
            // detailInputOr
            // 
            this.detailInputOr.Location = new System.Drawing.Point(104, 116);
            this.detailInputOr.Name = "detailInputOr";
            this.detailInputOr.Size = new System.Drawing.Size(151, 19);
            this.detailInputOr.TabIndex = 10;
            // 
            // detailInputAuthor
            // 
            this.detailInputAuthor.Location = new System.Drawing.Point(104, 183);
            this.detailInputAuthor.Name = "detailInputAuthor";
            this.detailInputAuthor.Size = new System.Drawing.Size(151, 19);
            this.detailInputAuthor.TabIndex = 11;
            // 
            // detailInputPublication
            // 
            this.detailInputPublication.Location = new System.Drawing.Point(104, 208);
            this.detailInputPublication.Name = "detailInputPublication";
            this.detailInputPublication.Size = new System.Drawing.Size(151, 19);
            this.detailInputPublication.TabIndex = 12;
            // 
            // detailInputDayFrom
            // 
            this.detailInputDayFrom.Location = new System.Drawing.Point(101, 235);
            this.detailInputDayFrom.Name = "detailInputDayFrom";
            this.detailInputDayFrom.Size = new System.Drawing.Size(49, 19);
            this.detailInputDayFrom.TabIndex = 13;
            // 
            // detailInputDayTo
            // 
            this.detailInputDayTo.Location = new System.Drawing.Point(156, 235);
            this.detailInputDayTo.Name = "detailInputDayTo";
            this.detailInputDayTo.Size = new System.Drawing.Size(46, 19);
            this.detailInputDayTo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "検索する箇所";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "著者";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "出典";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "日付";
            // 
            // detailInputRegion
            // 
            this.detailInputRegion.FormattingEnabled = true;
            this.detailInputRegion.Items.AddRange(new object[] {
            "記事全体",
            "記事のタイトル"});
            this.detailInputRegion.Location = new System.Drawing.Point(104, 160);
            this.detailInputRegion.Name = "detailInputRegion";
            this.detailInputRegion.Size = new System.Drawing.Size(100, 20);
            this.detailInputRegion.TabIndex = 19;
            this.detailInputRegion.Text = "記事全体";
            this.detailInputRegion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // langCheck
            // 
            this.langCheck.AutoSize = true;
            this.langCheck.Location = new System.Drawing.Point(69, 54);
            this.langCheck.Name = "langCheck";
            this.langCheck.Size = new System.Drawing.Size(81, 16);
            this.langCheck.TabIndex = 20;
            this.langCheck.Text = "日本語のみ";
            this.langCheck.UseVisualStyleBackColor = true;
            // 
            // detailInputNot
            // 
            this.detailInputNot.AutoSize = true;
            this.detailInputNot.Location = new System.Drawing.Point(19, 141);
            this.detailInputNot.Name = "detailInputNot";
            this.detailInputNot.Size = new System.Drawing.Size(46, 12);
            this.detailInputNot.TabIndex = 21;
            this.detailInputNot.Text = "含まない";
            // 
            // detailInputNo
            // 
            this.detailInputNo.Location = new System.Drawing.Point(104, 138);
            this.detailInputNo.Name = "detailInputNo";
            this.detailInputNo.Size = new System.Drawing.Size(151, 19);
            this.detailInputNo.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.detailInputNo);
            this.Controls.Add(this.detailInputNot);
            this.Controls.Add(this.langCheck);
            this.Controls.Add(this.detailInputRegion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detailInputDayTo);
            this.Controls.Add(this.detailInputDayFrom);
            this.Controls.Add(this.detailInputPublication);
            this.Controls.Add(this.detailInputAuthor);
            this.Controls.Add(this.detailInputOr);
            this.Controls.Add(this.detailInputPhrase);
            this.Controls.Add(this.detailInputAnd);
            this.Controls.Add(this.detailCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainInput);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 110);
            this.Name = "Form1";
            this.Text = "ScholarSearch";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.TextBox mainInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox detailCheck;
        private System.Windows.Forms.TextBox detailInputAnd;
        private System.Windows.Forms.TextBox detailInputPhrase;
        private System.Windows.Forms.TextBox detailInputOr;
        private System.Windows.Forms.TextBox detailInputAuthor;
        private System.Windows.Forms.TextBox detailInputPublication;
        private System.Windows.Forms.TextBox detailInputDayFrom;
        private System.Windows.Forms.TextBox detailInputDayTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox detailInputRegion;
        private System.Windows.Forms.CheckBox langCheck;
        private System.Windows.Forms.Label detailInputNot;
        private System.Windows.Forms.TextBox detailInputNo;
    }
}

