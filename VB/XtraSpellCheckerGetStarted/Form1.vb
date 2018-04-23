Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace XtraSpellCheckerGetStarted
    Partial Public Class Form1
        Inherits Form

        Private sText As String = "Hans had servd his master forseven years, so he said to to him, ""Master, my time is up; now I should be glad to go back home to my mother; give me me my wages."
        Public Sub New()
            InitializeComponent()
            textBox1.Text = sText
            memoEdit1.Text = sText
            textEdit1.Text = sText
            richTextBox1.Text = sText
            richEditControl1.Text = sText

        End Sub
        #Region "#simpleButton1_Click"
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            spellChecker1.CheckContainer(Me)
        End Sub
        #End Region ' #simpleButton1_Click
        #Region "#Form1_Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' Set spell checking options.
            spellChecker1.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
            spellChecker1.ParentContainer = Me
            spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
            ' Set focus to the RichTextBox control to show red wavy lines under misspelled words.
            richTextBox1.Select()
        End Sub
        #End Region ' #Form1_Load
    End Class
End Namespace
