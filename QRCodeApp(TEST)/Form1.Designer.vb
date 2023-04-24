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
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(703, 661)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 29)
        Button1.TabIndex = 0
        Button1.Text = "Generate QR Code"
        Button1.UseVisualStyleBackColor = True
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
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(60, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 600)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(105, 626)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(755, 29)
        TextBox1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 753)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
