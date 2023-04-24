<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        buttonGenerate = New Button()
        Label1 = New Label()
        pic = New PictureBox()
        txtInput = New TextBox()
        CType(pic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' buttonGenerate
        ' 
        buttonGenerate.Location = New Point(703, 661)
        buttonGenerate.Name = "buttonGenerate"
        buttonGenerate.Size = New Size(157, 29)
        buttonGenerate.TabIndex = 0
        buttonGenerate.Text = "Generate QR Code"
        buttonGenerate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 629)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 21)
        Label1.TabIndex = 1
        Label1.Text = "Name:"
        ' 
        ' pic
        ' 
        pic.BackColor = Color.White
        pic.Location = New Point(60, 12)
        pic.Name = "pic"
        pic.Size = New Size(800, 600)
        pic.SizeMode = PictureBoxSizeMode.CenterImage
        pic.TabIndex = 2
        pic.TabStop = False
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(105, 626)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(755, 29)
        txtInput.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 753)
        Controls.Add(txtInput)
        Controls.Add(pic)
        Controls.Add(Label1)
        Controls.Add(buttonGenerate)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TIP-QC Campus Access Generator"
        CType(pic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents buttonGenerate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pic As PictureBox
    Friend WithEvents txtInput As TextBox
End Class
