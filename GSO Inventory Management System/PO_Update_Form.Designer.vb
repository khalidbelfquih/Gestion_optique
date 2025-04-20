<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PO_Update_Form
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
        Me.status_txt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updateData = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.product_no = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.tags_txt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.SuspendLayout()
        '
        'status_txt
        '
        Me.status_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.status_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_txt.FormattingEnabled = True
        Me.status_txt.Items.AddRange(New Object() {"Approved", "Pending"})
        Me.status_txt.Location = New System.Drawing.Point(52, 186)
        Me.status_txt.Name = "status_txt"
        Me.status_txt.Size = New System.Drawing.Size(345, 33)
        Me.status_txt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No. of Lack Items"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Status"
        '
        'updateData
        '
        Me.updateData.Location = New System.Drawing.Point(51, 247)
        Me.updateData.Name = "updateData"
        Me.updateData.Size = New System.Drawing.Size(172, 34)
        Me.updateData.TabIndex = 8
        Me.updateData.Text = "Save"
        Me.updateData.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(243, 247)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(172, 34)
        Me.closebtn.TabIndex = 9
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Product No."
        '
        'product_no
        '
        Me.product_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_no.Location = New System.Drawing.Point(52, 40)
        Me.product_no.Multiline = True
        Me.product_no.Name = "product_no"
        Me.product_no.NewText = ""
        Me.product_no.OriText = ""
        Me.product_no.ReadOnly = True
        Me.product_no.Size = New System.Drawing.Size(345, 34)
        Me.product_no.TabIndex = 10
        Me.product_no.Texthaschanged = False
        '
        'tags_txt
        '
        Me.tags_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tags_txt.Location = New System.Drawing.Point(52, 113)
        Me.tags_txt.Multiline = True
        Me.tags_txt.Name = "tags_txt"
        Me.tags_txt.NewText = ""
        Me.tags_txt.OriText = ""
        Me.tags_txt.Size = New System.Drawing.Size(345, 34)
        Me.tags_txt.TabIndex = 0
        Me.tags_txt.Texthaschanged = False
        '
        'PO_Update_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 296)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.product_no)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.updateData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.status_txt)
        Me.Controls.Add(Me.tags_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PO_Update_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PO_Update_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tags_txt As GSO_Inventory_Management_System.RoundedCornerTextbox
    Friend WithEvents status_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents updateData As System.Windows.Forms.Button
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents product_no As GSO_Inventory_Management_System.RoundedCornerTextbox
End Class
