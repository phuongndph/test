<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSanpham
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtMaTl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNgayNhap = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtTitleSp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã TL"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(62, 211)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtMaTl
        '
        Me.txtMaTl.Location = New System.Drawing.Point(122, 53)
        Me.txtMaTl.Name = "txtMaTl"
        Me.txtMaTl.ReadOnly = True
        Me.txtMaTl.Size = New System.Drawing.Size(126, 20)
        Me.txtMaTl.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã SP:"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(122, 88)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(126, 20)
        Me.txtMaSP.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tên SP"
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(122, 114)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(126, 20)
        Me.txtTenSP.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số Lượng"
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(122, 140)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(126, 20)
        Me.txtSoluong.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ngày Nhập"
        '
        'txtNgayNhap
        '
        Me.txtNgayNhap.Location = New System.Drawing.Point(122, 166)
        Me.txtNgayNhap.Name = "txtNgayNhap"
        Me.txtNgayNhap.Size = New System.Drawing.Size(126, 20)
        Me.txtNgayNhap.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(158, 211)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtTitleSp
        '
        Me.txtTitleSp.AutoSize = True
        Me.txtTitleSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleSp.ForeColor = System.Drawing.Color.Red
        Me.txtTitleSp.Location = New System.Drawing.Point(83, 21)
        Me.txtTitleSp.Name = "txtTitleSp"
        Me.txtTitleSp.Size = New System.Drawing.Size(40, 17)
        Me.txtTitleSp.TabIndex = 0
        Me.txtTitleSp.Text = "Title"
        '
        'frmAddSanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 282)
        Me.Controls.Add(Me.txtNgayNhap)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaTl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtTitleSp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddSanpham"
        Me.Text = "San Pham"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtMaTl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNgayNhap As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtTitleSp As System.Windows.Forms.Label
End Class
