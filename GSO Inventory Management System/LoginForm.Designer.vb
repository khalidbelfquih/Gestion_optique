<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Signbtn = New System.Windows.Forms.Button()
        Me.signupbtn = New System.Windows.Forms.Button()
        Me.login_panel = New System.Windows.Forms.Panel()
        Me.timetxt = New System.Windows.Forms.Label()
        Me.txt_pw = New System.Windows.Forms.TextBox()
        Me.txt_un = New System.Windows.Forms.TextBox()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.logbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datetxt = New System.Windows.Forms.Label()
        Me.register_panel = New System.Windows.Forms.Panel()
        Me.regbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.confirmtxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pwtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.untxt = New System.Windows.Forms.TextBox()
        Me.selectiontxt = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.login_panel.SuspendLayout()
        Me.register_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Signbtn)
        Me.Panel1.Controls.Add(Me.signupbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 622)
        Me.Panel1.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(30, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 18)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Version: 2.0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label15.Location = New System.Drawing.Point(20, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(331, 91)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "INVSYS"
        '
        'Signbtn
        '
        Me.Signbtn.Location = New System.Drawing.Point(35, 463)
        Me.Signbtn.Name = "Signbtn"
        Me.Signbtn.Size = New System.Drawing.Size(223, 32)
        Me.Signbtn.TabIndex = 14
        Me.Signbtn.Text = "Sign in"
        Me.Signbtn.UseVisualStyleBackColor = True
        Me.Signbtn.Visible = False
        '
        'signupbtn
        '
        Me.signupbtn.Location = New System.Drawing.Point(35, 463)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(223, 32)
        Me.signupbtn.TabIndex = 13
        Me.signupbtn.Text = "Register"
        Me.signupbtn.UseVisualStyleBackColor = True
        '
        'login_panel
        '
        Me.login_panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.login_panel.Controls.Add(Me.timetxt)
        Me.login_panel.Controls.Add(Me.txt_pw)
        Me.login_panel.Controls.Add(Me.txt_un)
        Me.login_panel.Controls.Add(Me.closebtn)
        Me.login_panel.Controls.Add(Me.logbtn)
        Me.login_panel.Controls.Add(Me.Label2)
        Me.login_panel.Controls.Add(Me.Label1)
        Me.login_panel.Controls.Add(Me.datetxt)
        Me.login_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.login_panel.Location = New System.Drawing.Point(321, 0)
        Me.login_panel.Name = "login_panel"
        Me.login_panel.Size = New System.Drawing.Size(372, 622)
        Me.login_panel.TabIndex = 1
        '
        'timetxt
        '
        Me.timetxt.AutoSize = True
        Me.timetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.timetxt.Location = New System.Drawing.Point(92, 558)
        Me.timetxt.Name = "timetxt"
        Me.timetxt.Size = New System.Drawing.Size(203, 55)
        Me.timetxt.TabIndex = 8
        Me.timetxt.Text = "Label21"
        '
        'txt_pw
        '
        Me.txt_pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pw.Location = New System.Drawing.Point(15, 293)
        Me.txt_pw.Name = "txt_pw"
        Me.txt_pw.Size = New System.Drawing.Size(342, 24)
        Me.txt_pw.TabIndex = 7
        Me.txt_pw.Text = "admin"
        Me.txt_pw.UseSystemPasswordChar = True
        '
        'txt_un
        '
        Me.txt_un.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_un.Location = New System.Drawing.Point(15, 225)
        Me.txt_un.Name = "txt_un"
        Me.txt_un.Size = New System.Drawing.Size(342, 24)
        Me.txt_un.TabIndex = 6
        Me.txt_un.Text = "admin"
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(142, 342)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(112, 33)
        Me.closebtn.TabIndex = 5
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'logbtn
        '
        Me.logbtn.Location = New System.Drawing.Point(12, 342)
        Me.logbtn.Name = "logbtn"
        Me.logbtn.Size = New System.Drawing.Size(112, 33)
        Me.logbtn.TabIndex = 4
        Me.logbtn.Text = "Login"
        Me.logbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'datetxt
        '
        Me.datetxt.AutoSize = True
        Me.datetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.datetxt.Location = New System.Drawing.Point(90, 511)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(203, 55)
        Me.datetxt.TabIndex = 9
        Me.datetxt.Text = "Label21"
        '
        'register_panel
        '
        Me.register_panel.Controls.Add(Me.regbtn)
        Me.register_panel.Controls.Add(Me.Label8)
        Me.register_panel.Controls.Add(Me.Label7)
        Me.register_panel.Controls.Add(Me.confirmtxt)
        Me.register_panel.Controls.Add(Me.Label6)
        Me.register_panel.Controls.Add(Me.pwtxt)
        Me.register_panel.Controls.Add(Me.Label5)
        Me.register_panel.Controls.Add(Me.untxt)
        Me.register_panel.Controls.Add(Me.selectiontxt)
        Me.register_panel.Controls.Add(Me.Label4)
        Me.register_panel.Controls.Add(Me.Label3)
        Me.register_panel.Controls.Add(Me.fname)
        Me.register_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.register_panel.Location = New System.Drawing.Point(321, 0)
        Me.register_panel.Name = "register_panel"
        Me.register_panel.Size = New System.Drawing.Size(372, 622)
        Me.register_panel.TabIndex = 8
        '
        'regbtn
        '
        Me.regbtn.Location = New System.Drawing.Point(21, 441)
        Me.regbtn.Name = "regbtn"
        Me.regbtn.Size = New System.Drawing.Size(126, 32)
        Me.regbtn.TabIndex = 12
        Me.regbtn.Text = "Signup"
        Me.regbtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(99, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 24)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Registration Form"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Confirm Password"
        '
        'confirmtxt
        '
        Me.confirmtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmtxt.Location = New System.Drawing.Point(18, 387)
        Me.confirmtxt.Name = "confirmtxt"
        Me.confirmtxt.Size = New System.Drawing.Size(330, 24)
        Me.confirmtxt.TabIndex = 9
        Me.confirmtxt.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password"
        '
        'pwtxt
        '
        Me.pwtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwtxt.Location = New System.Drawing.Point(18, 319)
        Me.pwtxt.Name = "pwtxt"
        Me.pwtxt.Size = New System.Drawing.Size(330, 24)
        Me.pwtxt.TabIndex = 7
        Me.pwtxt.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username"
        '
        'untxt
        '
        Me.untxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.untxt.Location = New System.Drawing.Point(18, 252)
        Me.untxt.Name = "untxt"
        Me.untxt.Size = New System.Drawing.Size(330, 24)
        Me.untxt.TabIndex = 5
        '
        'selectiontxt
        '
        Me.selectiontxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectiontxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectiontxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectiontxt.FormattingEnabled = True
        Me.selectiontxt.Location = New System.Drawing.Point(18, 185)
        Me.selectiontxt.Name = "selectiontxt"
        Me.selectiontxt.Size = New System.Drawing.Size(294, 26)
        Me.selectiontxt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fullname"
        '
        'fname
        '
        Me.fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.Location = New System.Drawing.Point(18, 127)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(330, 24)
        Me.fname.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 622)
        Me.Controls.Add(Me.login_panel)
        Me.Controls.Add(Me.register_panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.login_panel.ResumeLayout(False)
        Me.login_panel.PerformLayout()
        Me.register_panel.ResumeLayout(False)
        Me.register_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents login_panel As System.Windows.Forms.Panel
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents logbtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_un As System.Windows.Forms.TextBox
    Friend WithEvents txt_pw As System.Windows.Forms.TextBox
    Friend WithEvents register_panel As System.Windows.Forms.Panel
    Friend WithEvents regbtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents confirmtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pwtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents untxt As System.Windows.Forms.TextBox
    Friend WithEvents selectiontxt As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents signupbtn As System.Windows.Forms.Button
    Friend WithEvents Signbtn As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents timetxt As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents datetxt As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
