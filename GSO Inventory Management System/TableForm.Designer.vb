<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableForm
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.addbtn_D = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.name_d = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.bindtext = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.tail_txt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.sub_depart = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.bind2 = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.tail2 = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.dep2 = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MHO", "MERTS", "PORT", "GSO", "HRMO", "BUDGET", "APP"})
        Me.ComboBox1.Location = New System.Drawing.Point(97, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(263, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Create Table"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Insert data"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"MHO", "MERTS", "PORT", "GSO", "HRMO", "BUDGET", "APP"})
        Me.ComboBox2.Location = New System.Drawing.Point(97, 28)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(263, 21)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.Visible = False
        '
        'addbtn_D
        '
        Me.addbtn_D.Location = New System.Drawing.Point(368, 67)
        Me.addbtn_D.Name = "addbtn_D"
        Me.addbtn_D.Size = New System.Drawing.Size(127, 41)
        Me.addbtn_D.TabIndex = 6
        Me.addbtn_D.Text = "Add"
        Me.addbtn_D.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(54, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 18)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Department"
        '
        'name_d
        '
        Me.name_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_d.Location = New System.Drawing.Point(55, 74)
        Me.name_d.Multiline = True
        Me.name_d.Name = "name_d"
        Me.name_d.NewText = ""
        Me.name_d.OriText = ""
        Me.name_d.Size = New System.Drawing.Size(283, 29)
        Me.name_d.TabIndex = 4
        Me.name_d.Texthaschanged = False
        '
        'bindtext
        '
        Me.bindtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bindtext.Location = New System.Drawing.Point(324, 150)
        Me.bindtext.Multiline = True
        Me.bindtext.Name = "bindtext"
        Me.bindtext.NewText = ""
        Me.bindtext.OriText = ""
        Me.bindtext.Size = New System.Drawing.Size(123, 29)
        Me.bindtext.TabIndex = 14
        Me.bindtext.Texthaschanged = False
        '
        'tail_txt
        '
        Me.tail_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tail_txt.Location = New System.Drawing.Point(189, 151)
        Me.tail_txt.Multiline = True
        Me.tail_txt.Name = "tail_txt"
        Me.tail_txt.NewText = ""
        Me.tail_txt.OriText = ""
        Me.tail_txt.Size = New System.Drawing.Size(123, 29)
        Me.tail_txt.TabIndex = 13
        Me.tail_txt.Text = "1"
        Me.tail_txt.Texthaschanged = False
        '
        'sub_depart
        '
        Me.sub_depart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub_depart.Location = New System.Drawing.Point(53, 151)
        Me.sub_depart.Multiline = True
        Me.sub_depart.Name = "sub_depart"
        Me.sub_depart.NewText = ""
        Me.sub_depart.OriText = ""
        Me.sub_depart.Size = New System.Drawing.Size(123, 29)
        Me.sub_depart.TabIndex = 12
        Me.sub_depart.Texthaschanged = False
        '
        'bind2
        '
        Me.bind2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bind2.Location = New System.Drawing.Point(324, 203)
        Me.bind2.Multiline = True
        Me.bind2.Name = "bind2"
        Me.bind2.NewText = ""
        Me.bind2.OriText = ""
        Me.bind2.Size = New System.Drawing.Size(123, 29)
        Me.bind2.TabIndex = 17
        Me.bind2.Texthaschanged = False
        '
        'tail2
        '
        Me.tail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tail2.Location = New System.Drawing.Point(189, 204)
        Me.tail2.Multiline = True
        Me.tail2.Name = "tail2"
        Me.tail2.NewText = ""
        Me.tail2.OriText = ""
        Me.tail2.Size = New System.Drawing.Size(123, 29)
        Me.tail2.TabIndex = 16
        Me.tail2.Text = "2"
        Me.tail2.Texthaschanged = False
        '
        'dep2
        '
        Me.dep2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dep2.Location = New System.Drawing.Point(53, 204)
        Me.dep2.Multiline = True
        Me.dep2.Name = "dep2"
        Me.dep2.NewText = ""
        Me.dep2.OriText = ""
        Me.dep2.Size = New System.Drawing.Size(123, 29)
        Me.dep2.TabIndex = 15
        Me.dep2.Texthaschanged = False
        '
        'TableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 141)
        Me.Controls.Add(Me.bind2)
        Me.Controls.Add(Me.tail2)
        Me.Controls.Add(Me.dep2)
        Me.Controls.Add(Me.bindtext)
        Me.Controls.Add(Me.tail_txt)
        Me.Controls.Add(Me.sub_depart)
        Me.Controls.Add(Me.addbtn_D)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.name_d)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TableForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents addbtn_D As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents name_d As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents bindtext As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents tail_txt As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents sub_depart As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents bind2 As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents tail2 As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents dep2 As GSO_Inventory_Management_System.RoundedCornerTextbox
End Class
