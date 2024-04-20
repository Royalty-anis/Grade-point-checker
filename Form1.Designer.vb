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
        Dim ComboBox1 As ComboBox
        Dim ComboBox2 As ComboBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        Button2 = New Button()
        Label5 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"HAMMATHAN", "RAIN"})
        ComboBox1.Location = New Point(397, 174)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(267, 28)
        ComboBox1.TabIndex = 8
        ComboBox1.Text = "                       NONE"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.CausesValidation = False
        ComboBox2.Items.AddRange(New Object() {"100", "200", "300", "400"})
        ComboBox2.Location = New Point(397, 130)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(267, 28)
        ComboBox2.TabIndex = 11
        ComboBox2.Text = "                       NONE"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(397, 31)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "@ANIFOWOSE OLAMIDE"
        TextBox1.Size = New Size(267, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Silver
        Label1.Font = New Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(177, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 26)
        Label1.TabIndex = 1
        Label1.Text = "FULL NAME:"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(397, 64)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "@220591312"
        TextBox2.Size = New Size(267, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(397, 97)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "@computer science"
        TextBox3.Size = New Size(267, 27)
        TextBox3.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(177, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 32)
        Label2.TabIndex = 5
        Label2.Text = "MATRIC NUMBER:"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Silver
        Label3.Font = New Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(175, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(203, 32)
        Label3.TabIndex = 6
        Label3.Text = "DEPARTMENT:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Location = New Point(192, 343)
        Button1.Name = "Button1"
        Button1.Size = New Size(214, 50)
        Button1.TabIndex = 9
        Button1.Text = "CHECK GP"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Silver
        Label4.Font = New Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(175, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(203, 32)
        Label4.TabIndex = 7
        Label4.Text = "LEVEL:"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(604, 343)
        Button2.Name = "Button2"
        Button2.Size = New Size(201, 47)
        Button2.TabIndex = 10
        Button2.Text = "CHECK STATUS"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Silver
        Label5.Font = New Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(175, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(203, 32)
        Label5.TabIndex = 12
        Label5.Text = "SEASON:"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(659, 456)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 65)
        Button3.TabIndex = 13
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(192, 456)
        Button4.Name = "Button4"
        Button4.Size = New Size(157, 61)
        Button4.TabIndex = 14
        Button4.Text = "CREDIT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Black
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(880, 7)
        Button5.Name = "Button5"
        Button5.Size = New Size(72, 51)
        Button5.TabIndex = 15
        Button5.Text = "DARK MODE"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.LASU_Senate_Building_Right_Section_1
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1000, 533)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(ComboBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        TransparencyKey = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class
