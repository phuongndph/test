Public Class frmChiTietHoaDon

    Private _DBAccess As New DataBaseAccess

    ' khai bao bien trang thai edit hay insert
    Private _isEdit As Boolean = False

    Public Sub New(isEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = isEdit
    End Sub
    'Private Sub LoadDataOnTxtMasp()
    '    Dim sqlQuery As String = "select MaSP,TenSP from San_Pham"
    '    Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
    '    Me.txtMaSP.DataSource = dTable
    '    Me.txtMaSP.ValueMember = "MaSP"
    '    Me.txtMaSP.DisplayMember = "TenSP"

    'End Sub
    ' Ham them ban ghi CTHD vao database
    Private Function InsertCTHoadon() As Boolean
        Dim sqlQuery As String = "Insert ChiTiet_HoaDon (MaHD,MaSP,SoLuong ,GiaBan)"
        sqlQuery += String.Format("values ('{0}','{1}','{2}','{3}')", _
                                  txtMaHD.Text, txtMaSP.SelectedValue, txtSoLuong.Text, txtGiaBan.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    ' Ham update
    Private Function UpdateCTHoadon() As Boolean
        Dim sqlQuerry As String = String.Format("UPDATE ChiTiet_HoaDon SET SoLuong ='{0}',GiaBan = '{1}' WHERE MaHD = '{2}' AND MaSP = '{3}' ", _
       Me.txtSoLuong.Text, Me.txtGiaBan.Text, Me.txtMaHD.Text, Me.txtMaSP.Text)

        Return _DBAccess.ExecuteNoneQuery(sqlQuerry)
    End Function
    ' Ham kiem tra gia tri truoc khi insert du lieu
    Private Function isEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMaHD.Text) OrElse String.IsNullOrEmpty(txtMaSP.Text) OrElse _
            String.IsNullOrEmpty(txtSoLuong.Text) OrElse String.IsNullOrEmpty(txtGiaBan.Text))
    End Function






    Private Sub btnOKCTHD_Click(sender As Object, e As EventArgs) Handles btnOKCTHD.Click
        If isEmpty() Then ' kiem tra truong du lieu truoc khi thuc hien them sua
            MessageBox.Show("Vui long nhap gia tri truoc khi luu", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then 'neu la edit thi goi ham update
                If UpdateCTHoadon() Then 'neu update thanh cong thi thong bao 
                    MessageBox.Show("Update du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else   ' neu co loi khi sua thi thong bao loi
                    MessageBox.Show("loi sua du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else   ' neu khong phai thi goi ham insert
                If InsertCTHoadon() Then ' neu Insert thanh cong thi thong bao
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

    Private Sub btnCancelCTHD_Click(sender As Object, e As EventArgs) Handles btnCancelCTHD.Click
        Me.Close()
    End Sub

    'Private Sub frmChiTietHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    LoadDataOnTxtMasp()
    'End Sub
End Class