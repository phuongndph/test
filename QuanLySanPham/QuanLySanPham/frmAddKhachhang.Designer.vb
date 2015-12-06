<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddKhachhang
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
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btnAddKHOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoDt = New System.Windows.Forms.TextBox()
        Me.btnAddKhcancel = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã KH:"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(108, 59)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(138, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'btnAddKHOK
        '
        Me.btnAddKHOK.Location = New System.Drawing.Point(59, 196)
        Me.btnAddKHOK.Name = "btnAddKHOK"
        Me.btnAddKHOK.Size = New System.Drawing.Size(75, 23)
        Me.btnAddKHOK.TabIndex = 2
        Me.btnAddKHOK.Text = "&OK"
        Me.btnAddKHOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên KH"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(108, 95)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(138, 20)
        Me.txtTenKH.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Đia chỉ:"
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(108, 121)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(138, 20)
        Me.txtDiachi.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số ĐT"
        '
        'txtSoDt
        '
        Me.txtSoDt.Location = New System.Drawing.Point(108, 147)
        Me.txtSoDt.Name = "txtSoDt"
        Me.txtSoDt.Size = New System.Drawing.Size(138, 20)
        Me.txtSoDt.TabIndex = 1
        '
        'btnAddKhcancel
        '
        Me.btnAddKhcancel.Location = New System.Drawing.Point(171, 196)
        Me.btnAddKhcancel.Name = "btnAddKhcancel"
        Me.btnAddKhcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnAddKhcancel.TabIndex = 2
        Me.btnAddKhcancel.Text = "&Cancel"
        Me.btnAddKhcancel.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.Red
        Me.txtTitle.Location = New System.Drawing.Point(85, 18)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(35, 17)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = "title"
        '
        'frmAddKhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnAddKhcancel)
        Me.Controls.Add(Me.btnAddKHOK)
        Me.Controls.Add(Me.txtSoDt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddKhachhang"
        Me.Text = "Khách Hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents btnAddKHOK As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSoDt As System.Windows.Forms.TextBox
    Friend WithEvents btnAddKhcancel As System.Windows.Forms.Button
    Friend WithEvents txtTitle As System.Windows.Forms.Label
End Class
