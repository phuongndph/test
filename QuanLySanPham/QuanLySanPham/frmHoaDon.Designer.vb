<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Me.btnOKHoaDon = New System.Windows.Forms.Button()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.bntCancelHoadon = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNgayLapHD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txttitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã KH :"
        '
        'btnOKHoaDon
        '
        Me.btnOKHoaDon.Location = New System.Drawing.Point(52, 208)
        Me.btnOKHoaDon.Name = "btnOKHoaDon"
        Me.btnOKHoaDon.Size = New System.Drawing.Size(75, 23)
        Me.btnOKHoaDon.TabIndex = 1
        Me.btnOKHoaDon.Text = "&OK"
        Me.btnOKHoaDon.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(107, 49)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(131, 20)
        Me.txtMaKH.TabIndex = 2
        '
        'bntCancelHoadon
        '
        Me.bntCancelHoadon.Location = New System.Drawing.Point(152, 208)
        Me.bntCancelHoadon.Name = "bntCancelHoadon"
        Me.bntCancelHoadon.Size = New System.Drawing.Size(75, 23)
        Me.bntCancelHoadon.TabIndex = 1
        Me.bntCancelHoadon.Text = "&Cancel"
        Me.bntCancelHoadon.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã HD :"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(107, 84)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(131, 20)
        Me.txtMaHD.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày Lập HĐ :"
        '
        'txtNgayLapHD
        '
        Me.txtNgayLapHD.Location = New System.Drawing.Point(107, 119)
        Me.txtNgayLapHD.Name = "txtNgayLapHD"
        Me.txtNgayLapHD.Size = New System.Drawing.Size(131, 20)
        Me.txtNgayLapHD.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Đơn Giá :"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(107, 154)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(131, 20)
        Me.txtDonGia.TabIndex = 2
        '
        'txttitle
        '
        Me.txttitle.AutoSize = True
        Me.txttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitle.ForeColor = System.Drawing.Color.Red
        Me.txttitle.Location = New System.Drawing.Point(79, 20)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(57, 17)
        Me.txttitle.TabIndex = 0
        Me.txttitle.Text = "Label1"
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtNgayLapHD)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bntCancelHoadon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOKHoaDon)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHoaDon"
        Me.Text = "Hóa đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOKHoaDon As System.Windows.Forms.Button
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents bntCancelHoadon As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNgayLapHD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txttitle As System.Windows.Forms.Label
End Class
