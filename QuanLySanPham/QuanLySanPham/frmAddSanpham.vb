Public Class frmAddSanpham
    'Khai bao bien truy xuat DB tu lop DBAccess
    Private _DBAccess As New DataBaseAccess
    ' khai bao bien trang thai edit hay insert
    Private _isEdit As Boolean = False

    Public Sub New(isEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = isEdit
    End Sub

    ' Ham them ban ghi san pham vao database
    Private Function InsertSanPham() As Boolean
        Dim sqlQuery As String = "Insert into San_Pham (MaSP,TenSP,Soluong ,NgayNhap,MaTL)"
        sqlQuery += String.Format("values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", _
                                  txtMaSP.Text, txtTenSP.Text, txtSoluong.Text, txtNgayNhap.Text, txtMaTl.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    ' Ham update
    Private Function UpdateSanpham() As Boolean
        Dim sqlQuerry As String = String.Format("UPDATE San_Pham SET TenSP ='{0}', Soluong ='{1}',  NgayNhap = '{2}' WHERE MaSP = '{3}'", _
        Me.txtTenSP.Text, Me.txtSoluong.Text, Me.txtNgayNhap.Text, Me.txtMaSP.Text)

        Return _DBAccess.ExecuteNoneQuery(sqlQuerry)
    End Function
    ' Ham kiem tra gia tri truoc khi insert du lieu
    Private Function isEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMaSP.Text) OrElse String.IsNullOrEmpty(txtTenSP.Text) OrElse _
            String.IsNullOrEmpty(txtSoluong.Text) OrElse String.IsNullOrEmpty(txtNgayNhap.Text) OrElse _
            String.IsNullOrEmpty(txtMaTl.Text))
    End Function


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If isEmpty() Then ' kiem tra truong du lieu truoc khi thuc hien them sua
            MessageBox.Show("Vui long nhap gia tri truoc khi luu", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then 'neu la edit thi goi ham update
                If UpdateSanpham() Then 'neu update thanh cong thi thong bao 
                    MessageBox.Show("Update du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else   ' neu co loi khi sua thi thong bao loi
                    MessageBox.Show("loi sua du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else   ' neu khong phai thi goi ham insert
                If InsertSanPham() Then ' neu Insert thanh cong thi thong bao
                    MessageBox.Show("Them du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi them du lieu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If

            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class