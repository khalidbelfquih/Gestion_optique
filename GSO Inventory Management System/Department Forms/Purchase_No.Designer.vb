<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_No
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
        Me.closebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.date_issue = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pr_txt = New GSO_Inventory_Management_System.RoundedCornerTextbox()
        Me.SuspendLayout()
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(264, 181)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(136, 42)
        Me.closebtn.TabIndex = 18
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(107, 181)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(136, 42)
        Me.savebtn.TabIndex = 17
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'date_issue
        '
        Me.date_issue.CustomFormat = "yyyy-MM-dd"
        Me.date_issue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_issue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_issue.Location = New System.Drawing.Point(107, 119)
        Me.date_issue.Name = "date_issue"
        Me.date_issue.Size = New System.Drawing.Size(376, 32)
        Me.date_issue.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PR No."
        '
        'pr_txt
        '
        Me.pr_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr_txt.Location = New System.Drawing.Point(107, 43)
        Me.pr_txt.Multiline = True
        Me.pr_txt.Name = "pr_txt"
        Me.pr_txt.NewText = ""
        Me.pr_txt.OriText = ""
        Me.pr_txt.Size = New System.Drawing.Size(379, 34)
        Me.pr_txt.TabIndex = 13
        Me.pr_txt.Texthaschanged = False
        '
        'Purchase_No
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 238)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.date_issue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pr_txt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Purchase_No"
        Me.ShowIcon = False
        Me.Text = "Purchase_No"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents date_issue As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pr_txt As GSO_Inventory_Management_System.RoundedCornerTextbox
End Class
