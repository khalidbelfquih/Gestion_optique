<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterForm))
        Me.Label32 = New System.Windows.Forms.Label()
        Me.category_txt = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.selected_cmb = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.select_cmb_2 = New System.Windows.Forms.ComboBox()
        Me.remarks_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gen_all_1 = New System.Windows.Forms.Button()
        Me.filter_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gen_all_2 = New System.Windows.Forms.Button()
        Me.categorytxt_002 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filterBTN = New System.Windows.Forms.Button()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.generate_po = New System.Windows.Forms.Button()
        Me.category_po = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filter_po = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label32.Location = New System.Drawing.Point(262, 27)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(76, 18)
        Me.Label32.TabIndex = 16
        Me.Label32.Text = "Category"
        '
        'category_txt
        '
        Me.category_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.category_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.category_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_txt.FormattingEnabled = True
        Me.category_txt.Location = New System.Drawing.Point(265, 51)
        Me.category_txt.Name = "category_txt"
        Me.category_txt.Size = New System.Drawing.Size(283, 26)
        Me.category_txt.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(29, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "APP and PPMP"
        '
        'selected_cmb
        '
        Me.selected_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selected_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selected_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selected_cmb.FormattingEnabled = True
        Me.selected_cmb.Items.AddRange(New Object() {"APP", "PPMP"})
        Me.selected_cmb.Location = New System.Drawing.Point(27, 51)
        Me.selected_cmb.Name = "selected_cmb"
        Me.selected_cmb.Size = New System.Drawing.Size(203, 26)
        Me.selected_cmb.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(17, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(151, 18)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Purchase Request:"
        '
        'select_cmb_2
        '
        Me.select_cmb_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.select_cmb_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.select_cmb_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_cmb_2.FormattingEnabled = True
        Me.select_cmb_2.Items.AddRange(New Object() {"1ST AND 2ND QUARTER", "3RD AND 4TH QUARTER ", "1ST QUARTER", "2ND QUARTER", "3RD QUARTER ", "4TH QUARTER ", "1ST AND 4TH QUARTER "})
        Me.select_cmb_2.Location = New System.Drawing.Point(20, 34)
        Me.select_cmb_2.Name = "select_cmb_2"
        Me.select_cmb_2.Size = New System.Drawing.Size(303, 26)
        Me.select_cmb_2.TabIndex = 17
        '
        'remarks_btn
        '
        Me.remarks_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remarks_btn.FlatAppearance.BorderSize = 0
        Me.remarks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.remarks_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarks_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.remarks_btn.Image = CType(resources.GetObject("remarks_btn.Image"), System.Drawing.Image)
        Me.remarks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.remarks_btn.Location = New System.Drawing.Point(21, 79)
        Me.remarks_btn.Name = "remarks_btn"
        Me.remarks_btn.Size = New System.Drawing.Size(122, 30)
        Me.remarks_btn.TabIndex = 19
        Me.remarks_btn.Text = "         Remarks"
        Me.remarks_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.gen_all_1)
        Me.Panel1.Controls.Add(Me.filter_btn)
        Me.Panel1.Controls.Add(Me.selected_cmb)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.category_txt)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Location = New System.Drawing.Point(22, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 150)
        Me.Panel1.TabIndex = 20
        '
        'gen_all_1
        '
        Me.gen_all_1.Location = New System.Drawing.Point(573, 89)
        Me.gen_all_1.Name = "gen_all_1"
        Me.gen_all_1.Size = New System.Drawing.Size(125, 42)
        Me.gen_all_1.TabIndex = 18
        Me.gen_all_1.Text = "Generate All"
        Me.gen_all_1.UseVisualStyleBackColor = True
        '
        'filter_btn
        '
        Me.filter_btn.Location = New System.Drawing.Point(573, 41)
        Me.filter_btn.Name = "filter_btn"
        Me.filter_btn.Size = New System.Drawing.Size(125, 42)
        Me.filter_btn.TabIndex = 17
        Me.filter_btn.Text = "Filter"
        Me.filter_btn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.gen_all_2)
        Me.Panel2.Controls.Add(Me.categorytxt_002)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.filterBTN)
        Me.Panel2.Controls.Add(Me.select_cmb_2)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.remarks_btn)
        Me.Panel2.Controls.Add(Me.T3)
        Me.Panel2.Controls.Add(Me.T2)
        Me.Panel2.Controls.Add(Me.T1)
        Me.Panel2.Location = New System.Drawing.Point(22, 212)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 150)
        Me.Panel2.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(192, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 30)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "         Issue P.R No."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gen_all_2
        '
        Me.gen_all_2.Location = New System.Drawing.Point(573, 80)
        Me.gen_all_2.Name = "gen_all_2"
        Me.gen_all_2.Size = New System.Drawing.Size(125, 42)
        Me.gen_all_2.TabIndex = 19
        Me.gen_all_2.Text = "Generate All"
        Me.gen_all_2.UseVisualStyleBackColor = True
        '
        'categorytxt_002
        '
        Me.categorytxt_002.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categorytxt_002.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.categorytxt_002.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorytxt_002.FormattingEnabled = True
        Me.categorytxt_002.Location = New System.Drawing.Point(347, 34)
        Me.categorytxt_002.Name = "categorytxt_002"
        Me.categorytxt_002.Size = New System.Drawing.Size(201, 26)
        Me.categorytxt_002.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(344, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Category"
        '
        'filterBTN
        '
        Me.filterBTN.Location = New System.Drawing.Point(573, 32)
        Me.filterBTN.Name = "filterBTN"
        Me.filterBTN.Size = New System.Drawing.Size(125, 42)
        Me.filterBTN.TabIndex = 18
        Me.filterBTN.Text = "Filter"
        Me.filterBTN.UseVisualStyleBackColor = True
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(445, 149)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(268, 20)
        Me.T3.TabIndex = 22
        Me.T3.Visible = False
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(286, 149)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(160, 20)
        Me.T2.TabIndex = 21
        Me.T2.Visible = False
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(114, 149)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(173, 20)
        Me.T1.TabIndex = 20
        Me.T1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.generate_po)
        Me.Panel3.Controls.Add(Me.category_po)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.filter_po)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Location = New System.Drawing.Point(22, 388)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(715, 150)
        Me.Panel3.TabIndex = 23
        '
        'generate_po
        '
        Me.generate_po.Location = New System.Drawing.Point(573, 80)
        Me.generate_po.Name = "generate_po"
        Me.generate_po.Size = New System.Drawing.Size(125, 42)
        Me.generate_po.TabIndex = 19
        Me.generate_po.Text = "Generate All"
        Me.generate_po.UseVisualStyleBackColor = True
        '
        'category_po
        '
        Me.category_po.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.category_po.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.category_po.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_po.FormattingEnabled = True
        Me.category_po.Location = New System.Drawing.Point(188, 40)
        Me.category_po.Name = "category_po"
        Me.category_po.Size = New System.Drawing.Size(350, 26)
        Me.category_po.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(185, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Category"
        '
        'filter_po
        '
        Me.filter_po.Location = New System.Drawing.Point(573, 32)
        Me.filter_po.Name = "filter_po"
        Me.filter_po.Size = New System.Drawing.Size(125, 42)
        Me.filter_po.TabIndex = 18
        Me.filter_po.Text = "Filter"
        Me.filter_po.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(17, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Purchase Order:"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(189, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 30)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "         Issue P.O No."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(445, 149)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(286, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(160, 20)
        Me.TextBox2.TabIndex = 21
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(173, 20)
        Me.TextBox3.TabIndex = 20
        Me.TextBox3.Visible = False
        '
        'FilterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 560)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FilterForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FilterForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents category_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents selected_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents select_cmb_2 As System.Windows.Forms.ComboBox
    Friend WithEvents remarks_btn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents filter_btn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents categorytxt_002 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents filterBTN As System.Windows.Forms.Button
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents gen_all_1 As System.Windows.Forms.Button
    Friend WithEvents gen_all_2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents generate_po As System.Windows.Forms.Button
    Friend WithEvents category_po As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents filter_po As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
