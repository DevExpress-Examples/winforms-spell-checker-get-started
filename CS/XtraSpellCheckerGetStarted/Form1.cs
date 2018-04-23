using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtraSpellCheckerGetStarted
{
    public partial class Form1 : Form
    {
        string sText = "Hans had servd his master forseven years, so he said to to him, \"Master, my time is up; now I should be glad to go back home to my mother; give me me my wages.";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = sText;
            memoEdit1.Text = sText;
            textEdit1.Text = sText;
            richTextBox1.Text = sText;
            richEditControl1.Text = sText;
            
        }
        #region #simpleButton1_Click
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            spellChecker1.CheckContainer(this);
        }
        #endregion #simpleButton1_Click
        #region #Form1_Load
		private void Form1_Load(object sender, EventArgs e)
        {
            // Set spell checking options.
            spellChecker1.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType;
            spellChecker1.ParentContainer = this;
            spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            // Set focus to the RichTextBox control to show red wavy lines under misspelled words.
            richTextBox1.Select();
        }
		#endregion #Form1_Load
    }
}
