' Frm Main
' Ngày Viết : 09/04/2021
'Người Viết : Nguyễn Phú Hiệp
' Sửa đổi : Chưa
' Nội Dung : Viết code chức năng cho giao diện chính của phần mềm


Imports System.ComponentModel
Imports System.Text
Imports Microsoft.Office.Interop

Partial Public Class View_main
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub




    Private Sub View_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisPlay(FRM_gioithieu)
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick

    End Sub

    Private Sub btn_thongtin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_thongtin.ItemClick
        ' Hiển thị Form thông tin
        View_About.ShowDialog()
    End Sub

    Private Sub btn_chonvatlieu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_chonvatlieu.ItemClick
        ' Hiển Thị Form Vật liệu
        View_VatLieu.ShowDialog()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        view_bieudo.ShowDialog()

    End Sub

    Private Sub btn_thongsocot_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_thongsocot.ItemClick
        ' HIỆN form nhập liệu : 
        Nhaplieu.ShowDialog()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Try
            DisplayFRM(view_bieudo)
        Catch ex As Exception
            MessageBox.Show("Bạn Chưa chọn vật liệu")
        End Try

    End Sub



    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        MessageBox.Show(Pn_Display.Width.ToString + "  " + Pn_Display.Height.ToString)
    End Sub

    Private Sub Pn_Display_Paint(sender As Object, e As PaintEventArgs) Handles Pn_Display.Paint

    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick

    End Sub

    Private Sub btn_banve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_banve.ItemClick
        'Try
        Dim a As New BanVeControler()
        Dim chieudai As Double = Convert.ToDouble(Data.chieudaitinhtoancot)
        a.vecot(New Point(0, 0), Data.sothanhthep, chieudai) ' vẽ cột 16 điểm Thép
        DisplayFRM(View_BanVe)
        'Catch ex As Exception
        '    MessageBox.Show("Chưa có đủ dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try



    End Sub
    ' Các hàm dùng trong chuwowgn trình
    Private Sub DisplayFRM(childForm As Form)
        'Dim activeForm As Form
        'If activeForm IsNot Nothing Then activeForm.Close()
        'activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.Pn_Display.Controls.Add(childForm)
        Me.Pn_Display.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click

    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        DisplayFRM(FRM_gioithieu)
    End Sub

    Private Sub btnhuongdan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnhuongdan.ItemClick
        View_About.ShowDialog()

    End Sub

    Private Sub btn_kiemtra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_kiemtra.ItemClick
        kiemtra_view.ShowDialog()

    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick


    End Sub

    Private Sub btn_noiLuc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_noiLuc.ItemClick
        View_thongsocot.ShowDialog()
    End Sub

    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick
        DisplayFRM(ExcelView)


    End Sub

    Private Sub btnAccess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAccess.ItemClick

    End Sub

    Private Sub btn_xuatbanve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_xuatbanve.ItemClick
        ' Xuất bản vẽ 
        Dim Save As New SaveFileDialog
        Save.Filter = "dxf|*.dxf"
        If (Save.ShowDialog = DialogResult.OK) Then
            View_BanVe.vdr.ActiveDocument.SaveAs(Save.FileName, 7)
        End If
    End Sub
End Class
