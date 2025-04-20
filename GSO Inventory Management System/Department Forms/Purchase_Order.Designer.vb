<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_Order
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
        Me.dod = New System.Windows.Forms.DateTimePicker()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.dt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.pod = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.tintxt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.addresstxt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.suppliertxt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.fundtxt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.mode_procure = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.po_date = New System.Windows.Forms.DateTimePicker()
        Me.po_no = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.persontxt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.SuspendLayout()
        '
        'dod
        '
        Me.dod.CustomFormat = "yyyy-MM-dd"
        Me.dod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dod.Location = New System.Drawing.Point(414, 189)
        Me.dod.Name = "dod"
        Me.dod.Size = New System.Drawing.Size(223, 26)
        Me.dod.TabIndex = 48
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(205, 451)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(135, 45)
        Me.closebtn.TabIndex = 47
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(52, 451)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(135, 45)
        Me.savebtn.TabIndex = 46
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(410, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Payment Term"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(410, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 20)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Delivery Term"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(410, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 20)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Date of Delivery"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(410, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 20)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Place of Delivery"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(410, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "TIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Fund"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Mode of Procurement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "P.O. No."
        '
        'pt
        '
        Me.pt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt.Location = New System.Drawing.Point(414, 322)
        Me.pt.Multiline = True
        Me.pt.Name = "pt"
        Me.pt.NewText = ""
        Me.pt.OriText = ""
        Me.pt.Size = New System.Drawing.Size(316, 30)
        Me.pt.TabIndex = 34
        Me.pt.Texthaschanged = False
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(414, 258)
        Me.dt.Multiline = True
        Me.dt.Name = "dt"
        Me.dt.NewText = ""
        Me.dt.OriText = ""
        Me.dt.Size = New System.Drawing.Size(316, 30)
        Me.dt.TabIndex = 33
        Me.dt.Texthaschanged = False
        '
        'pod
        '
        Me.pod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pod.Location = New System.Drawing.Point(414, 128)
        Me.pod.Multiline = True
        Me.pod.Name = "pod"
        Me.pod.NewText = ""
        Me.pod.OriText = ""
        Me.pod.Size = New System.Drawing.Size(316, 30)
        Me.pod.TabIndex = 32
        Me.pod.Texthaschanged = False
        '
        'tintxt
        '
        Me.tintxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tintxt.Location = New System.Drawing.Point(414, 64)
        Me.tintxt.Multiline = True
        Me.tintxt.Name = "tintxt"
        Me.tintxt.NewText = ""
        Me.tintxt.OriText = ""
        Me.tintxt.Size = New System.Drawing.Size(316, 30)
        Me.tintxt.TabIndex = 31
        Me.tintxt.Texthaschanged = False
        '
        'addresstxt
        '
        Me.addresstxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresstxt.Location = New System.Drawing.Point(52, 388)
        Me.addresstxt.Multiline = True
        Me.addresstxt.Name = "addresstxt"
        Me.addresstxt.NewText = ""
        Me.addresstxt.OriText = ""
        Me.addresstxt.Size = New System.Drawing.Size(316, 30)
        Me.addresstxt.TabIndex = 30
        Me.addresstxt.Texthaschanged = False
        '
        'suppliertxt
        '
        Me.suppliertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppliertxt.Location = New System.Drawing.Point(52, 322)
        Me.suppliertxt.Multiline = True
        Me.suppliertxt.Name = "suppliertxt"
        Me.suppliertxt.NewText = ""
        Me.suppliertxt.OriText = ""
        Me.suppliertxt.Size = New System.Drawing.Size(316, 30)
        Me.suppliertxt.TabIndex = 29
        Me.suppliertxt.Texthaschanged = False
        '
        'fundtxt
        '
        Me.fundtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fundtxt.Location = New System.Drawing.Point(52, 258)
        Me.fundtxt.Multiline = True
        Me.fundtxt.Name = "fundtxt"
        Me.fundtxt.NewText = ""
        Me.fundtxt.OriText = ""
        Me.fundtxt.Size = New System.Drawing.Size(316, 30)
        Me.fundtxt.TabIndex = 28
        Me.fundtxt.Texthaschanged = False
        '
        'mode_procure
        '
        Me.mode_procure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode_procure.Location = New System.Drawing.Point(52, 189)
        Me.mode_procure.Multiline = True
        Me.mode_procure.Name = "mode_procure"
        Me.mode_procure.NewText = ""
        Me.mode_procure.OriText = ""
        Me.mode_procure.Size = New System.Drawing.Size(316, 30)
        Me.mode_procure.TabIndex = 27
        Me.mode_procure.Texthaschanged = False
        '
        'po_date
        '
        Me.po_date.CustomFormat = "yyyy-MM-dd"
        Me.po_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.po_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.po_date.Location = New System.Drawing.Point(52, 128)
        Me.po_date.Name = "po_date"
        Me.po_date.Size = New System.Drawing.Size(223, 26)
        Me.po_date.TabIndex = 26
        '
        'po_no
        '
        Me.po_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.po_no.Location = New System.Drawing.Point(52, 64)
        Me.po_no.Multiline = True
        Me.po_no.Name = "po_no"
        Me.po_no.NewText = ""
        Me.po_no.OriText = ""
        Me.po_no.Size = New System.Drawing.Size(316, 30)
        Me.po_no.TabIndex = 25
        Me.po_no.Texthaschanged = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(410, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 20)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Authorized Person"
        '
        'persontxt
        '
        Me.persontxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.persontxt.Location = New System.Drawing.Point(414, 388)
        Me.persontxt.Multiline = True
        Me.persontxt.Name = "persontxt"
        Me.persontxt.NewText = ""
        Me.persontxt.OriText = ""
        Me.persontxt.Size = New System.Drawing.Size(316, 30)
        Me.persontxt.TabIndex = 49
        Me.persontxt.Texthaschanged = False
        '
        'Purchase_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 537)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.persontxt)
        Me.Controls.Add(Me.dod)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pt)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.pod)
        Me.Controls.Add(Me.tintxt)
        Me.Controls.Add(Me.addresstxt)
        Me.Controls.Add(Me.suppliertxt)
        Me.Controls.Add(Me.fundtxt)
        Me.Controls.Add(Me.mode_procure)
        Me.Controls.Add(Me.po_date)
        Me.Controls.Add(Me.po_no)
        Me.Name = "Purchase_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase_Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dod As System.Windows.Forms.DateTimePicker
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pt As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents dt As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents pod As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents tintxt As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents addresstxt As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents suppliertxt As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents fundtxt As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents mode_procure As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents po_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents po_no As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents persontxt As GSO_Inventory_Management_System.RoundedCornerTextbox
End Class
