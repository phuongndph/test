<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSanPham = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSanpham = New System.Windows.Forms.ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHoadon = New System.Windows.Forms.RadioButton()
        Me.RadioButonChiTietHD = New System.Windows.Forms.RadioButton()
        Me.RadiobuttonTheLoai = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'dgvSanPham
        '
        Me.dgvSanPham.AllowUserToAddRows = False
        Me.dgvSanPham.AllowUserToDeleteRows = False
        Me.dgvSanPham.BackgroundColor = System.Drawing.Color.White
        Me.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanPham.Location = New System.Drawing.Point(41, 131)
        Me.dgvSanPham.MultiSelect = False
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.ReadOnly = True
        Me.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSanPham.Size = New System.Drawing.Size(440, 248)
        Me.dgvSanPham.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(209, 80)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(182, 20)
        Me.txtSearch.TabIndex = 3
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Tìm kiếm mã", "Tìm kiếm tên"})
        Me.cmbSearch.Location = New System.Drawing.Point(92, 79)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(111, 21)
        Me.cmbSearch.TabIndex = 4
        Me.cmbSearch.Text = "Lựa chọn tìm kiếm"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(523, 159)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(162, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Thêm sản phâm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(523, 188)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(162, 23)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Sửa Sản Phẩm"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(523, 217)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(162, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Xoa sản phẩm"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSanpham)
        Me.GroupBox1.Controls.Add(Me.lblFilter)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(523, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 120)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'cmbSanpham
        '
        Me.cmbSanpham.FormattingEnabled = True
        Me.cmbSanpham.Location = New System.Drawing.Point(22, 56)
        Me.cmbSanpham.Name = "cmbSanpham"
        Me.cmbSanpham.Size = New System.Drawing.Size(121, 24)
        Me.cmbSanpham.TabIndex = 4
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.ForeColor = System.Drawing.Color.Green
        Me.lblFilter.Location = New System.Drawing.Point(19, 28)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(51, 17)
        Me.lblFilter.TabIndex = 0
        Me.lblFilter.Text = "Label1"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(523, 80)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "Sản Phẩm"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(523, 103)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Khách Hàng"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButtonHoadon
        '
        Me.RadioButtonHoadon.AutoSize = True
        Me.RadioButtonHoadon.Location = New System.Drawing.Point(617, 80)
        Me.RadioButtonHoadon.Name = "RadioButtonHoadon"
        Me.RadioButtonHoadon.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonHoadon.TabIndex = 8
        Me.RadioButtonHoadon.TabStop = True
        Me.RadioButtonHoadon.Text = "Hóa Đơn"
        Me.RadioButtonHoadon.UseVisualStyleBackColor = True
        '
        'RadioButonChiTietHD
        '
        Me.RadioButonChiTietHD.AutoSize = True
        Me.RadioButonChiTietHD.Location = New System.Drawing.Point(617, 107)
        Me.RadioButonChiTietHD.Name = "RadioButonChiTietHD"
        Me.RadioButonChiTietHD.Size = New System.Drawing.Size(80, 17)
        Me.RadioButonChiTietHD.TabIndex = 9
        Me.RadioButonChiTietHD.TabStop = True
        Me.RadioButonChiTietHD.Text = "Chi Tiết HĐ"
        Me.RadioButonChiTietHD.UseVisualStyleBackColor = True
        '
        'RadiobuttonTheLoai
        '
        Me.RadiobuttonTheLoai.AutoSize = True
        Me.RadiobuttonTheLoai.Location = New System.Drawing.Point(523, 131)
        Me.RadiobuttonTheLoai.Name = "RadiobuttonTheLoai"
        Me.RadiobuttonTheLoai.Size = New System.Drawing.Size(67, 17)
        Me.RadiobuttonTheLoai.TabIndex = 10
        Me.RadiobuttonTheLoai.TabStop = True
        Me.RadiobuttonTheLoai.Text = "Thể Loại"
        Me.RadiobuttonTheLoai.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(214, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "QUẢN LÝ SẢN PHẨM"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(406, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(566, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Trieuttph02831"
        '
        'frmQLSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 413)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadiobuttonTheLoai)
        Me.Controls.Add(Me.RadioButonChiTietHD)
        Me.Controls.Add(Me.RadioButtonHoadon)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvSanPham)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLSP"
        Me.Text = "QUẢN LÝ SẢN PHẨM"
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvSanPham As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSanpham As System.Windows.Forms.ComboBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonHoadon As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButonChiTietHD As System.Windows.Forms.RadioButton
    Friend WithEvents RadiobuttonTheLoai As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
