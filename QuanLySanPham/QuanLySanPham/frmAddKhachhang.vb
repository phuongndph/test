Public Class frmAddKhachhang

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
    Private Function InsertKhachHang() As Boolean
        Dim sqlQuery As String = "Insert into Khach_Hang (MaKH,TenKH,DiaChi,SoDT)"
        sqlQuery += String.Format("values (N'{0}',N'{1}',N'{2}',N'{3}')", _
                                  txtMaKH.Text, txtTenKH.Text, txtDiachi.Text, txtSoDt.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    ' Ham update
    Private Function UpdateKhachhang() As Boolean
        Dim sqlQuerry As String = String.Format("UPDATE Khach_Hang SET TenKH ='{0}', DiaChi ='{1}',  SoDT = '{2}' WHERE MaKH = '{3}'", _
        Me.txtTenKH.Text, Me.txtDiachi.Text, Me.txtSoDt.Text, Me.txtMaKH.Text)

        Return _DBAccess.ExecuteNoneQuery(sqlQuerry)
    End Function

    '' Ham them ban ghi HoaDon vao database
    'Private Function InsertHoaDon() As Boolean
    '    Dim sqlQuery As String = "Insert into Hoa_Don (MaHD,MaKH,NgayLapHD ,DonGia)"
    '    sqlQuery += String.Format("values (N'{0}',N'{1}',N'{2}',N'{3}')", _
    '                              txtMaKH.Text, txtTenKH.Text, txtDiachi.Text, txtSoDt.Text)
    '    Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    'End Function
    ''Ham update Hoa don vao database
    'Private Function UpdateHoaDon() As Boolean
    '    Dim sqlQuerry As String = String.Format("UPDATE Hoa_Don SET NgayLapHD ='{0}', DonGia ='{1}'  WHERE MaHD = '{2}'", _
    '    Me.txtTenKH.Text, Me.txtDiachi.Text, Me.txtSoDt)

    '    Return _DBAccess.ExecuteNoneQuery(sqlQuerry)
    'End Function

    ' Ham kiem tra gia tri truoc khi insert du lieu
    Private Function isEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMaKH.Text) OrElse String.IsNullOrEmpty(txtTenKH.Text) OrElse _
            String.IsNullOrEmpty(txtDiachi.Text) OrElse String.IsNullOrEmpty(txtSoDt.Text))
    End Function


    Private Sub btnAddKHOK_Click(sender As Object, e As EventArgs) Handles btnAddKHOK.Click
        Dim frmQLSP As New frmQLSP
        If frmQLSP.RadioButton2.Checked Then ' Kiem tra neu la xem khach hang thi thuc hien thao tac cua khach hang
            If isEmpty() Then ' kiem tra truong du lieu truoc khi thuc hien them sua
                MessageBox.Show("Vui long nhap gia tri truoc khi luu", "Error", MessageBoxButtons.OK)
            Else
                If _isEdit Then 'neu la edit thi goi ham update
                    If UpdateKhachhang() Then 'neu update thanh cong thi thong bao 
                        MessageBox.Show("Update du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else   ' neu co loi khi sua thi thong bao loi
                        MessageBox.Show("loi sua du lieu", "Error", MessageBoxButtons.OK)
                        Me.DialogResult = Windows.Forms.DialogResult.No
                    End If
                Else   ' neu khong phai thi goi ham insert
                    If InsertKhachHang() Then ' neu Insert thanh cong thi thong bao
                        MessageBox.Show("Them du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("Loi them du lieu!", "Error", MessageBoxButtons.OK)
                        Me.DialogResult = Windows.Forms.DialogResult.No
                    End If
                End If

                Me.Close()
            End If
        End If

        'If frmQLSP.RadioButtonHoadon.Checked Then
        '    If isEmpty() Then ' kiem tra truong du lieu truoc khi thuc hien them sua
        '        MessageBox.Show("Vui long nhap gia tri truoc khi luu", "Error", MessageBoxButtons.OK)
        '    Else
        '        If _isEdit Then 'neu la edit thi goi ham update
        '            If UpdateHoaDon() Then 'neu update thanh cong thi thong bao 
        '                MessageBox.Show("Update du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
        '                Me.DialogResult = Windows.Forms.DialogResult.OK
        '            Else   ' neu co loi khi sua thi thong bao loi
        '                MessageBox.Show("loi sua du lieu", "Error", MessageBoxButtons.OK)
        '                Me.DialogResult = Windows.Forms.DialogResult.No
        '            End If
        '        Else   ' neu khong phai thi goi ham insert
        '            If InsertHoaDon() Then ' neu Insert thanh cong thi thong bao
        '                MessageBox.Show("Them du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
        '                Me.DialogResult = Windows.Forms.DialogResult.OK
        '            Else
        '                MessageBox.Show("Loi them du lieu!", "Error", MessageBoxButtons.OK)
        '                Me.DialogResult = Windows.Forms.DialogResult.No
        '            End If
        '        End If

        '        Me.Close()
        '    End If

        'End If
    End Sub

    Private Sub btnAddKhcancel_Click(sender As Object, e As EventArgs) Handles btnAddKhcancel.Click
        Me.Close()
    End Sub
End Class