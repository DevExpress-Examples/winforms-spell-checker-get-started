namespace XtraSpellCheckerGetStarted
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling6 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling7 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling8 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling3 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling4 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(750, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.textBox1, optionsSpelling6);
            this.textBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 96);
            this.spellChecker1.SetSpellCheckerOptions(this.richTextBox1, optionsSpelling7);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(22, 47);
            this.textEdit1.Name = "textEdit1";
            this.spellChecker1.SetShowSpellCheckMenu(this.textEdit1, true);
            this.textEdit1.Size = new System.Drawing.Size(750, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.textEdit1, optionsSpelling8);
            this.textEdit1.TabIndex = 1;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(22, 82);
            this.memoEdit1.Name = "memoEdit1";
            this.spellChecker1.SetShowSpellCheckMenu(this.memoEdit1, true);
            this.memoEdit1.Size = new System.Drawing.Size(750, 96);
            this.spellChecker1.SetSpellCheckerOptions(this.memoEdit1, optionsSpelling3);
            this.memoEdit1.TabIndex = 2;
            // 
            // richEditControl1
            // 
            this.richEditControl1.Location = new System.Drawing.Point(22, 304);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(750, 200);
            this.richEditControl1.SpellChecker = this.spellChecker1;
            this.spellChecker1.SetSpellCheckerOptions(this.richEditControl1, optionsSpelling4);
            this.richEditControl1.TabIndex = 4;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(22, 526);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(89, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Check Spelling";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en-US");
            this.spellChecker1.ParentContainer = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "XtraSpellChecker Getting Started";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
    }
}

