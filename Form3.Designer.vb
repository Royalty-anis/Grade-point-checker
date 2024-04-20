<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Button1 = New Button()
        Button2 = New Button()
        dspbtn = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(174, 306)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 75)
        Button1.TabIndex = 0
        Button1.Text = "CHECK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Location = New Point(418, 306)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 75)
        Button2.TabIndex = 1
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' dspbtn
        ' 
        dspbtn.Location = New Point(257, 213)
        dspbtn.Name = "dspbtn"
        dspbtn.Size = New Size(249, 70)
        dspbtn.TabIndex = 2
        dspbtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(276, 151)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "INPUT GP/CGPA"
        TextBox1.Size = New Size(214, 27)
        TextBox1.TabIndex = 3
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(227, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(318, 120)
        Label2.TabIndex = 4
        Label2.Text = "WELCOME TO LAGOS STATE UNIVERSITY STATUS CHECKER(LASU STC)"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlDarkDark
        Button3.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(618, 384)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 48)
        Button3.TabIndex = 5
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = My.Resources.Resources.images
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(dspbtn)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dspbtn As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
End Class
