Public Class frmQLSP
    'Khai bao bien de truy xuat DB tu DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai bao bien kiem tra du lieu trang thai dang load
    Private _isLoading As Boolean = False

    'Load du lieu tu bang the loai vao combobox'
    Private Sub LoadDataOnComBobox()
        If RadioButton1.Checked Then
            Dim sqlQuery As String = "select MaTL,TenTL from The_Loai"
            Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
            Me.cmbSanpham.DataSource = dTable
            Me.cmbSanpham.ValueMember = "MaTL"
            Me.cmbSanpham.DisplayMember = "TenTL"
        End If
        If RadioButtonHoadon.Checked Then
            Dim sqlQuery1 As String = "select MaKH,TenKH from Khach_Hang"
            Dim dTable1 As DataTable = _DBAccess.GetDataTable(sqlQuery1)
            Me.cmbSanpham.DataSource = dTable1
            Me.cmbSanpham.ValueMember = "MaKH"
            Me.cmbSanpham.DisplayMember = "TenKH"
        End If
        If RadioButonChiTietHD.Checked Then
            Dim sqlQuery1 As String = "select TenKH , MaHD from Khach_Hang,Hoa_Don where Khach_Hang.MaKH = Hoa_Don.MaKH"
            Dim dTable1 As DataTable = _DBAccess.GetDataTable(sqlQuery1)
            Me.cmbSanpham.DataSource = dTable1
            Me.cmbSanpham.ValueMember = "MaHD"
            Me.cmbSanpham.DisplayMember = "TenKH"

        End If
    End Sub

    ' Load du lieu tu bang the loai vao Gridview
    Private Sub LoaddataTheLoaiOnGridView()
        Dim sqlQuery As String = "select MaTL,TenTL,Mota from The_Loai"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable
    End Sub

    'Load du lieu tu bang San Pham theo tung the loai vao gridview
    Private Sub LoadDataOnGridView(MaTL As String)
        Dim sqlQuery As String = String.Format("select MaSP,TenSP,Soluong ,NgayNhap from San_Pham where MaTL ='{0}'", MaTL)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable
        With Me.dgvSanpham
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "TenSP"
            .Columns(2).HeaderText = "Soluong"
            .Columns(3).HeaderText = "NgayNhap"
        End With
    End Sub

    'load du lieu tu bang khach hang vao gridview
    Private Sub LoadDataKhachHangOnGridView()

        Dim sqlQuery As String = "select MaKH,TenKH,DiaChi,SoDT from Khach_Hang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable
        With Me.dgvSanpham
        End With

    End Sub

    'Load du lieu tu bang Hoa Don theo tung Khach hang vao gridview
    Private Sub LoadDataHoaDonOnGridView(MaKH As String)
        Dim sqlQuery As String = String.Format("select MaHD, NgayLapHD, DonGia from Hoa_Don where MaKH ='{0}'", MaKH)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable
        With Me.dgvSanpham
            .Columns(0).HeaderText = "MaHD"
            .Columns(1).HeaderText = "NgayLapHD"
            .Columns(2).HeaderText = "DonGia"
        End With
    End Sub

    'Load du lieu tu bang Chi tiet Hoa don theo Khach Hang vao Gridview

    Private Sub LoadDaTaCTHDOnGridView(MaHD As String)
        Dim sqlQuery As String = String.Format("select MaHD,MaSP,SoLuong,GiaBan from ChiTiet_HoaDon where MaHD ='{0}'", MaHD)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable

    End Sub

    Private Sub frmQLSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '_isLoading = True
        'LoadDataOnComBobox()
        'LoadDataOnGridView(Me.cmbSanpham.SelectedValue)
        '_isLoading = False
    End Sub

    Private Sub cmbSanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSanpham.SelectedIndexChanged
        If RadioButton1.Checked Then
            If Not _isLoading Then
                LoadDataOnGridView(Me.cmbSanpham.SelectedValue)
            End If
        End If
        If RadioButtonHoadon.Checked Then
            If Not _isLoading Then
                LoadDataHoaDonOnGridView(Me.cmbSanpham.SelectedValue)
            End If
        End If
        If RadioButonChiTietHD.Checked Then
            If Not _isLoading Then
                LoadDaTaCTHDOnGridView(Me.cmbSanpham.SelectedValue)
            End If
        End If
    End Sub

    'Hien thi ket qua search san pham theo phuong phap tuong tu
    Private Sub SearchSanpham(MaTL As String, value As String)
        Dim sqlQuery As String = String.Format("select MaSP,TenSP,Soluong ,NgayNhap from San_Pham where MaTL ='{0}'", MaTL)
        If Me.cmbSearch.SelectedIndex = 0 Then ' tim theo MaSP
            sqlQuery += String.Format("AND MaSP LIKE '{0}%'", value)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then ' tim theo TenSP
            sqlQuery += String.Format("AND TenSP LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable
        With Me.dgvSanpham
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "TenSP"
            .Columns(2).HeaderText = "Soluong"
            .Columns(3).HeaderText = "NgayNhap"
        End With
    End Sub

    'Hien thi ket qua search Khách hàng theo phuong phap tuong tu
    Private Sub SearchKhachHang(value As String)
        Dim sqlQuery As String = "select MaKH,TenKH,DiaChi,SoDT from Khach_Hang "
        If Me.cmbSearch.SelectedIndex = 0 Then ' tim theo MaSP
            sqlQuery += String.Format("Where MaKH LIKE '{0}%'", value)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then ' tim theo TenSP
            sqlQuery += String.Format("Where TenKH LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable
        With Me.dgvSanpham
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "DiaChi"
            .Columns(3).HeaderText = "SoDT"
        End With
    End Sub

    ' Hien thi ket qua search Hoa don theo PHuong phap tuong tu
    Private Sub SearchHoaDon(MaKH As String, value As String)
        Dim sqlQuerry As String = String.Format("Select MaHD,MaKH,NgayLapHD,DonGia from Hoa_Don Where MaKH = '{0}'", MaKH)
        If Me.cmbSearch.SelectedIndex = 0 Then
            sqlQuerry += String.Format("And MaHD LIKE '{0}%' ", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuerry)
        Me.dgvSanpham.DataSource = dTable
    End Sub

    ' Tim kiem Chi tiet hoa don theo ma hoa don
    Private Sub SearchCTHD(MaHD As String)
        Dim sqlQuery As String = "Select MaHD,MaSp,SoLuong,GiaBan from ChiTiet_HoaDon "
        If Me.cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format("Where MaHD LIKE '{0}%'", MaHD)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable
    End Sub

    ' Hien thi ket qua search The loai theo phuong phap tuong tu
    Private Sub SearchTheLoai(value As String)
        Dim sqlQuery As String = "select MaTL,TenTL,Mota from The_Loai "
        If Me.cmbSearch.SelectedIndex = 0 Then ' tim theo MaSP
            sqlQuery += String.Format("Where MaTL LIKE '{0}%'", value)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then ' tim theo TenSP
            sqlQuery += String.Format("Where TenTL LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanpham.DataSource = dTable
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If RadioButton1.Checked Then
            SearchSanpham(Me.cmbSanpham.SelectedValue, Me.txtSearch.Text)
        End If
        If RadioButton2.Checked Then
            SearchKhachHang(Me.txtSearch.Text)
        End If
        If RadioButtonHoadon.Checked Then
            SearchHoaDon(Me.cmbSanpham.SelectedValue, Me.txtSearch.Text)
        End If
        If RadioButonChiTietHD.Checked Then
            SearchCTHD(Me.cmbSanpham.SelectedValue)
        End If
        If RadiobuttonTheLoai.Checked Then
            SearchTheLoai(Me.txtSearch.Text)
        End If
    End Sub

    'Add
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If RadioButton1.Checked Then
            Dim frm As New frmAddSanpham(False)
            frm.txtTitleSp.Text = "Thêm Sản Phẩm"
            frm.txtMaTl.Text = Me.cmbSanpham.SelectedValue
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                'load du lieu
                LoadDataOnGridView(Me.cmbSanpham.SelectedValue)
            End If
        End If
        If RadioButton2.Checked Then

            Dim frm As New frmAddKhachhang(False)
            frm.txtTitle.Text = "Thêm Khách Hàng"
            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadDataKhachHangOnGridView()
            End If
        End If
        If RadioButtonHoadon.Checked Then
            Dim frm1 As New frmHoaDon(False)
            frm1.txttitle.Text = "Thêm Hóa Đơn"
            frm1.txtMaKH.ReadOnly = True
            frm1.txtMaKH.Text = Me.cmbSanpham.SelectedValue
            frm1.ShowDialog()
            If frm1.DialogResult = Windows.Forms.DialogResult.OK Then
                'load du lieu
                LoadDataHoaDonOnGridView(Me.cmbSanpham.SelectedValue)
            End If
        End If
        If RadioButonChiTietHD.Checked Then
            Dim frm2 As New frmChiTietHoaDon(False)
            Dim sqlQuery As String = "select MaSP,TenSP from San_Pham"
            Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
            frm2.txtMaSP.DataSource = dTable
            frm2.txtMaSP.ValueMember = "MaSP"
            frm2.txtMaSP.DisplayMember = "TenSP"
            frm2.txtMaHD.Text = Me.cmbSanpham.SelectedValue
            frm2.ShowDialog()
            If frm2.DialogResult = Windows.Forms.DialogResult.OK Then
                'load du lieu
                LoadDaTaCTHDOnGridView(Me.cmbSanpham.SelectedValue)
            End If

        End If
        If RadiobuttonTheLoai.Checked Then
            Dim frm3 As New frmTheLoai(False)
            frm3.txtTitle.Text = "Thêm Thể Loại"
            frm3.ShowDialog()
            If frm3.DialogResult = Windows.Forms.DialogResult.OK Then
                LoaddataTheLoaiOnGridView()
            End If
        End If
    End Sub
    'Edit
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If RadioButton1.Checked Then
            Dim frm As New frmAddSanpham(True)
            frm.txtMaTl.Text = Me.cmbSanpham.SelectedValue
            frm.txtTitleSp.Text = "Sửa Sản Phẩm"
            frm.txtMaSP.ReadOnly = True
            With Me.dgvSanPham
                frm.txtMaSP.Text = .Rows(.CurrentCell.RowIndex).Cells("MaSP").Value
                frm.txtTenSP.Text = .Rows(.CurrentCell.RowIndex).Cells("TenSP").Value
                frm.txtSoluong.Text = .Rows(.CurrentCell.RowIndex).Cells("Soluong").Value
                frm.txtNgayNhap.Text = .Rows(.CurrentCell.RowIndex).Cells("NgayNhap").Value
            End With
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then ' sua  du lieu thanh cong thi load lai fiu lieu vao gridView
                LoadDataOnGridView(Me.cmbSanpham.SelectedValue)
            End If
        End If
        If RadioButton2.Checked Then
            Dim frm As New frmAddKhachhang(True)
            frm.txtTitle.Text = "Sửa Khách Hàng"
            frm.txtMaKH.ReadOnly = True
            With Me.dgvSanPham
                frm.txtMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
                frm.txtTenKH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
                frm.txtDiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
                frm.txtSoDt.Text = .Rows(.CurrentCell.RowIndex).Cells("SoDT").Value
            End With
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then ' sua  du lieu thanh cong thi load lai fiu lieu vao gridView
                LoadDataKhachHangOnGridView()
            End If
        End If
        If RadioButtonHoadon.Checked Then
            Dim frm2 As New frmHoaDon(True)
            frm2.txttitle.Text = "Sửa Hóa Đơn"
            frm2.txtMaKH.Text = Me.cmbSanpham.SelectedValue
            frm2.txtMaKH.ReadOnly = True
            frm2.txtMaHD.ReadOnly = True
            With Me.dgvSanPham
                frm2.txtMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHD").Value
                frm2.txtNgayLapHD.Text = .Rows(.CurrentCell.RowIndex).Cells("NgayLapHD").Value
                frm2.txtDonGia.Text = .Rows(.CurrentCell.RowIndex).Cells("DonGia").Value
            End With
            frm2.ShowDialog()
            If frm2.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadDataHoaDonOnGridView(Me.cmbSanpham.SelectedValue)
            End If
        End If
        If RadioButonChiTietHD.Checked Then
            Dim frm3 As New frmChiTietHoaDon(True)

            With Me.dgvSanPham
                frm3.txtMaSP.Text = .Rows(.CurrentCell.RowIndex).Cells("MaSP").Value
                frm3.txtMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHD").Value
                frm3.txtSoLuong.Text = .Rows(.CurrentCell.RowIndex).Cells("SoLuong").Value
                frm3.txtGiaBan.Text = .Rows(.CurrentCell.RowIndex).Cells("GiaBan").Value
            End With
            frm3.ShowDialog()
            If frm3.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadDaTaCTHDOnGridView(Me.cmbSanpham.SelectedValue)
            End If
        End If
        If RadiobuttonTheLoai.Checked Then
            Dim frm4 As New frmTheLoai(True)
            frm4.txtTitle.Text = "Sửa Thể Loại"
            frm4.txtMaTL.ReadOnly = True
            With Me.dgvSanPham
                frm4.txtMaTL.Text = .Rows(.CurrentCell.RowIndex).Cells("MaTL").Value
                frm4.txttenTL.Text = .Rows(.CurrentCell.RowIndex).Cells("TenTL").Value
                frm4.txtMota.Text = .Rows(.CurrentCell.RowIndex).Cells("Mota").Value

            End With
            frm4.ShowDialog()
            If frm4.DialogResult = Windows.Forms.DialogResult.OK Then
                LoaddataTheLoaiOnGridView()
            End If
        End If
    End Sub

    'Xoa
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If RadioButton1.Checked Then
            ' Khai bao bien lay san pham dang chon tu datagridview
            Dim MaSP As String = Me.dgvSanPham.Rows(Me.dgvSanPham.CurrentCell.RowIndex).Cells("MaSP").Value
            ' Khai bao Querry de xoa
            Dim sqlQuery As String = String.Format("DELETE San_Pham WHERE MaSP ='{0}'", MaSP)
            'thuc hien xoa
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then ' xoa thanh cong ghi thong bao
                MessageBox.Show("Da xoa du lieu thanh cong!")
                'Load lai tren gridview
                LoadDataOnGridView(Me.cmbSanpham.SelectedValue)
            Else
                MessageBox.Show("Loi xoa du lieu")
            End If
        End If
        If RadioButton2.Checked Then

            Dim MaKH As String = Me.dgvSanPham.Rows(Me.dgvSanPham.CurrentCell.RowIndex).Cells("MaKH").Value
            ' Khai bao Querry de xoa
            Dim sqlQuery As String = String.Format("DELETE Khach_Hang WHERE MaKH ='{0}'", MaKH)
            'thuc hien xoa
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then ' xoa thanh cong ghi thong bao
                MessageBox.Show("Da xoa du lieu thanh cong!")
                'Load lai tren gridview
                LoadDataKhachHangOnGridView()
            Else
                MessageBox.Show("Loi xoa du lieu")
            End If

        End If
        If RadioButtonHoadon.Checked Then

            Dim MaHD As String = Me.dgvSanPham.Rows(Me.dgvSanPham.CurrentCell.RowIndex).Cells("MaHD").Value

            Dim sqlQuery As String = String.Format("Delete Hoa_Don where MaHD ='{0}'", MaHD)

            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Da xoa du lieu thanh cong!")
                LoadDataHoaDonOnGridView(Me.cmbSanpham.SelectedValue)
            Else
                MessageBox.Show("Loi xoa du lieu!")
            End If

        End If
        If RadioButonChiTietHD.Checked Then
            Dim MaHD1 As String = Me.dgvSanPham.Rows(Me.dgvSanPham.CurrentCell.RowIndex).Cells("MaHD").Value
            Dim MaSP1 As String = Me.dgvSanPham.Rows(Me.dgvSanPham.CurrentCell.RowIndex).Cells("MaSP").Value
            Dim sqlQuery As String = String.Format("Delete ChiTiet_HoaDon where MaHD = '{0}' AND MaSP ='{1}'", MaHD1, MaSP1)
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Da xoa du lieu thang cong!")
                LoadDaTaCTHDOnGridView(Me.cmbSanpham.SelectedValue)
            Else
                MessageBox.Show("Loi xoa du lieu!")
            End If
        End If
        If RadiobuttonTheLoai.Checked Then
            Dim MaHD As String = Me.dgvSanPham.Rows(Me.dgvSanPham.CurrentCell.RowIndex).Cells("MaTL").Value
            Dim sqlQuery As String = String.Format("Delete The_Loai where MaTL ='{0}'", MaHD)
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Da xoa du lieu thanh cong!")
                LoaddataTheLoaiOnGridView()
            Else
                MessageBox.Show("loi xoa du lieu!")
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            btnAdd.Text = "Thêm sản phẩm"
            btnEdit.Text = "Sửa sản phẩm"
            btnDelete.Text = "Xóa sản phẩm"
            _isLoading = True
            lblFilter.Text = "Sản Phẩm"
            cmbSanpham.Enabled = True
            LoadDataOnComBobox()
            LoadDataOnGridView(Me.cmbSanpham.SelectedValue)
            _isLoading = False
        End If
    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            btnAdd.Text = "Thêm khách hàng"
            btnEdit.Text = "Sửa khách hàng"
            btnDelete.Text = "Xóa Khách hàng"
            cmbSanpham.Text = ""
            _isLoading = True
            lblFilter.Text = ""
            LoadDataKhachHangOnGridView()
            cmbSanpham.Enabled = False
            _isLoading = False
        End If
    End Sub

    Private Sub RadioButtonHoadon_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonHoadon.CheckedChanged
        If RadioButtonHoadon.Checked Then
            Me.cmbSearch.SelectedIndex = 0

            _isLoading = True
            btnAdd.Text = "Thêm Hóa Đơn"
            btnEdit.Text = "Sửa Hóa Đơn"
            btnDelete.Text = "Xóa Hóa Đơn"
            lblFilter.Text = "Hóa Đơn"
            LoadDataOnComBobox()
            LoadDataHoaDonOnGridView(Me.cmbSanpham.SelectedValue)
            cmbSanpham.Enabled = True
            _isLoading = False
        End If
    End Sub

    Private Sub RadioButonChiTietHD_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButonChiTietHD.CheckedChanged
        If RadioButonChiTietHD.Checked Then
            _isLoading = True
            btnAdd.Text = "Thêm CT_HĐ"
            btnEdit.Text = "Sửa CT_HĐ"
            btnDelete.Text = "Xóa CT_HĐ"
            cmbSanpham.Enabled = True
            LoadDataOnComBobox()
            LoadDaTaCTHDOnGridView(Me.cmbSanpham.SelectedValue)
            _isLoading = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadiobuttonTheLoai.CheckedChanged
        If RadiobuttonTheLoai.Checked Then
            btnAdd.Text = "Thêm Thể Loại"
            btnEdit.Text = "Sửa Thể Loại"
            btnDelete.Text = "Xóa Thể Loại"
            _isLoading = True
            cmbSanpham.Enabled = False
            cmbSanpham.Text = ""
            LoaddataTheLoaiOnGridView()
            _isLoading = False
        End If
    End Sub

  
End Class
