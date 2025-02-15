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
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        TextBox3 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.descarga__4_
        PictureBox1.Location = New Point(211, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 190)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(64, 290)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 23)
        Label1.TabIndex = 1
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(64, 355)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 23)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.ForeColor = SystemColors.HotTrack
        TextBox1.Location = New Point(182, 290)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(345, 31)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.ForeColor = SystemColors.HotTrack
        TextBox2.Location = New Point(182, 352)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(345, 31)
        TextBox2.TabIndex = 4
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sitka Text", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Location = New Point(167, 654)
        Button1.Name = "Button1"
        Button1.Size = New Size(280, 59)
        Button1.TabIndex = 5
        Button1.Text = "Iniciar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.HotTrack
        PictureBox2.Location = New Point(182, 469)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(353, 100)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(64, 418)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 23)
        Label3.TabIndex = 7
        Label3.Text = "Captcha"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.actualizar
        PictureBox3.Location = New Point(293, 586)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(53, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ToolTip1.SetToolTip(PictureBox3, "Generar Captcha")
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.ForeColor = SystemColors.HotTrack
        TextBox3.Location = New Point(182, 410)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(345, 31)
        TextBox3.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(618, 832)
        Controls.Add(TextBox3)
        Controls.Add(PictureBox3)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN CON CAPTCHA"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox3 As TextBox

End Class
