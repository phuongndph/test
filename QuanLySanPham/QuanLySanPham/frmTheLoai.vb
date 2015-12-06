Public Class frmTheLoai
    'Khai bao truy xuat du lieu tu lop Database Access
    Private _DBAccess As New DataBaseAccess

    Private _isEdit As Boolean = False
    'Check du lieu trong
    Private Function isEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMaTL.Text) OrElse String.IsNullOrEmpty(txttenTL.Text))
    End Function
    'Khai bao bien trang thai sua hay xoa
    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub
    ' them ban ghi the loai vao database
    Private Function insertTheLoai() As Boolean
        Dim sqlQuerry As String = "Insert into The_Loai (MaTL,TenTL,Mota)"
        sqlQuerry += String.Format("values (N'{0}',N'{1}',N'{2}')", _
                                   txtMaTL.Text, txttenTL.Text, txtMota.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuerry)
    End Function
    ' edit ban ghi the loai va update vao database
    Private Function UpdateTheLoai() As Boolean
        Dim sqlQuery As String = String.Format("Update The_Loai set TenTL =N'{0}', Mota = N'{1}' where MaTL = N'{2}'", _
                                               Me.txttenTL.Text, Me.txtMota.Text, Me.txtMaTL.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Vui long nhap du lieu", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateTheLoai() Then
                    MessageBox.Show("Update du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("loi update du lieu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If insertTheLoai() Then
                    MessageBox.Show("Insert du lieu thanh cong", "infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                Else
                    MessageBox.Show("Insert du lieu That bai", "Eror", MessageBoxButtons.OK)
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