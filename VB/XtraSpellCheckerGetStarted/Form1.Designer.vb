Namespace XtraSpellCheckerGetStarted
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim optionsSpelling6 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim optionsSpelling7 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim optionsSpelling8 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim optionsSpelling3 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim optionsSpelling4 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(22, 12)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(750, 20)
            Me.spellChecker1.SetSpellCheckerOptions(Me.textBox1, optionsSpelling6)
            Me.textBox1.TabIndex = 0
            ' 
            ' richTextBox1
            ' 
            Me.richTextBox1.Location = New System.Drawing.Point(22, 193)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(750, 96)
            Me.spellChecker1.SetSpellCheckerOptions(Me.richTextBox1, optionsSpelling7)
            Me.richTextBox1.TabIndex = 3
            Me.richTextBox1.Text = ""
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(22, 47)
            Me.textEdit1.Name = "textEdit1"
            Me.spellChecker1.SetShowSpellCheckMenu(Me.textEdit1, True)
            Me.textEdit1.Size = New System.Drawing.Size(750, 20)
            Me.spellChecker1.SetSpellCheckerOptions(Me.textEdit1, optionsSpelling8)
            Me.textEdit1.TabIndex = 1
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Location = New System.Drawing.Point(22, 82)
            Me.memoEdit1.Name = "memoEdit1"
            Me.spellChecker1.SetShowSpellCheckMenu(Me.memoEdit1, True)
            Me.memoEdit1.Size = New System.Drawing.Size(750, 96)
            Me.spellChecker1.SetSpellCheckerOptions(Me.memoEdit1, optionsSpelling3)
            Me.memoEdit1.TabIndex = 2
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Location = New System.Drawing.Point(22, 304)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(750, 200)
            Me.richEditControl1.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.richEditControl1, optionsSpelling4)
            Me.richEditControl1.TabIndex = 4
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(22, 526)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(89, 23)
            Me.simpleButton1.TabIndex = 5
            Me.simpleButton1.Text = "Check Spelling"
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.memoEdit1)
            Me.Controls.Add(Me.textEdit1)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.textBox1)
            Me.Name = "Form1"
            Me.Text = "XtraSpellChecker Getting Started"
            CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private textBox1 As System.Windows.Forms.TextBox
        Private richTextBox1 As System.Windows.Forms.RichTextBox
        Private textEdit1 As DevExpress.XtraEditors.TextEdit
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
    End Class
End Namespace

