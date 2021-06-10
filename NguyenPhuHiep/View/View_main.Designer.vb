Partial Public Class View_main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_main))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_thongsocot = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_chonvatlieu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_huongdan = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_thongtin = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAccess = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_tinhthep = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_kiemtra = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_banve = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_xuatbanve = New DevExpress.XtraBars.BarButtonItem()
        Me.btnhuongdan = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_noiLuc = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Pn_Display = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.btn_thongsocot, Me.BarButtonItem5, Me.btn_chonvatlieu, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.btn_huongdan, Me.btn_thongtin, Me.BarButtonItem6, Me.btnAccess, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem4, Me.BarButtonItem14, Me.btn_tinhthep, Me.btn_kiemtra, Me.btn_banve, Me.BarButtonItem15, Me.btn_xuatbanve, Me.btnhuongdan, Me.BarButtonItem16, Me.btn_noiLuc, Me.btnExcel, Me.BarButtonItem18})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 29
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.RibbonPage3, Me.RibbonPage2})
        Me.ribbonControl1.Size = New System.Drawing.Size(1024, 143)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "New Data"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "New"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Thông Số Cột"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btn_thongsocot
        '
        Me.btn_thongsocot.Caption = "Nhập Nội Lực Cột"
        Me.btn_thongsocot.Id = 4
        Me.btn_thongsocot.ImageOptions.Image = CType(resources.GetObject("btn_thongsocot.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_thongsocot.ImageOptions.LargeImage = CType(resources.GetObject("btn_thongsocot.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_thongsocot.Name = "btn_thongsocot"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Nội Lực"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        Me.BarButtonItem5.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btn_chonvatlieu
        '
        Me.btn_chonvatlieu.Caption = "New Vật Liệu"
        Me.btn_chonvatlieu.Id = 6
        Me.btn_chonvatlieu.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.icons8_mind_map_481
        Me.btn_chonvatlieu.Name = "btn_chonvatlieu"
        Me.btn_chonvatlieu.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.ActAsDropDown = True
        Me.BarButtonItem7.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItem7.Caption = "Bản Vẽ"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.ImageOptions.Image = CType(resources.GetObject("BarButtonItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        Me.BarButtonItem7.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Xuất Bản Vẽ"
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.ImageOptions.Image = CType(resources.GetObject("BarButtonItem8.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        Me.BarButtonItem8.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Thuyết Minh"
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.ImageOptions.Image = CType(resources.GetObject("BarButtonItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem9.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem9.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Xuất Thuyết Minh"
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.ImageOptions.Image = CType(resources.GetObject("BarButtonItem10.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem10.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem10.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'btn_huongdan
        '
        Me.btn_huongdan.Caption = "Hướng Dẫn"
        Me.btn_huongdan.Id = 11
        Me.btn_huongdan.ImageOptions.Image = CType(resources.GetObject("btn_huongdan.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_huongdan.ImageOptions.LargeImage = CType(resources.GetObject("btn_huongdan.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_huongdan.Name = "btn_huongdan"
        '
        'btn_thongtin
        '
        Me.btn_thongtin.Caption = "Software Infomation"
        Me.btn_thongtin.Id = 12
        Me.btn_thongtin.ImageOptions.SvgImage = CType(resources.GetObject("btn_thongtin.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_thongtin.Name = "btn_thongtin"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Biểu Đồ ko thứ nguyên"
        Me.BarButtonItem6.Id = 13
        Me.BarButtonItem6.ImageOptions.Image = CType(resources.GetObject("BarButtonItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAccess
        '
        Me.btnAccess.Caption = "Get Data From Access"
        Me.btnAccess.Id = 14
        Me.btnAccess.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.access_icon
        Me.btnAccess.Name = "btnAccess"
        Me.btnAccess.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Kiểm Tra"
        Me.BarButtonItem12.Id = 15
        Me.BarButtonItem12.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem12.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Tính Toán"
        Me.BarButtonItem13.Id = 16
        Me.BarButtonItem13.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem13.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Tính Thép Cột"
        Me.BarButtonItem4.Id = 17
        Me.BarButtonItem4.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.icon_steel
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "GEt Size"
        Me.BarButtonItem14.Id = 18
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'btn_tinhthep
        '
        Me.btn_tinhthep.Caption = "Chọn Lại Thép"
        Me.btn_tinhthep.Id = 19
        Me.btn_tinhthep.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.cd
        Me.btn_tinhthep.Name = "btn_tinhthep"
        Me.btn_tinhthep.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_kiemtra
        '
        Me.btn_kiemtra.Caption = "Kiểm Tra Cột"
        Me.btn_kiemtra.Id = 20
        Me.btn_kiemtra.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.icons8_25__641
        Me.btn_kiemtra.Name = "btn_kiemtra"
        Me.btn_kiemtra.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_banve
        '
        Me.btn_banve.Caption = "Kết Quả Bố Trí"
        Me.btn_banve.Id = 21
        Me.btn_banve.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.dwg_icon_150x150
        Me.btn_banve.Name = "btn_banve"
        Me.btn_banve.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Get Infomation SoftWare"
        Me.BarButtonItem15.Id = 22
        Me.BarButtonItem15.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.icons8_show_property_64
        Me.BarButtonItem15.Name = "BarButtonItem15"
        Me.BarButtonItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_xuatbanve
        '
        Me.btn_xuatbanve.Caption = "Xuất Bản Vẽ"
        Me.btn_xuatbanve.Id = 23
        Me.btn_xuatbanve.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.icons8_blockchain_technology_64
        Me.btn_xuatbanve.Name = "btn_xuatbanve"
        Me.btn_xuatbanve.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnhuongdan
        '
        Me.btnhuongdan.Caption = "Hướng Dẫn Sử Dụng"
        Me.btnhuongdan.Id = 24
        Me.btnhuongdan.ImageOptions.Image = CType(resources.GetObject("btnhuongdan.ImageOptions.Image"), System.Drawing.Image)
        Me.btnhuongdan.ImageOptions.LargeImage = CType(resources.GetObject("btnhuongdan.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnhuongdan.Name = "btnhuongdan"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Chọn Cột Để Tính"
        Me.BarButtonItem16.Id = 25
        Me.BarButtonItem16.ImageOptions.Image = CType(resources.GetObject("BarButtonItem16.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem16.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem16.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'btn_noiLuc
        '
        Me.btn_noiLuc.Caption = "Nhập Nội Lực Cột New"
        Me.btn_noiLuc.Id = 26
        Me.btn_noiLuc.ImageOptions.SvgImage = CType(resources.GetObject("btn_noiLuc.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_noiLuc.Name = "btn_noiLuc"
        '
        'btnExcel
        '
        Me.btnExcel.Caption = "New Data Excel"
        Me.btnExcel.Id = 27
        Me.btnExcel.ImageOptions.Image = CType(resources.GetObject("btnExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExcel.ImageOptions.LargeImage = CType(resources.GetObject("btnExcel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Show DataBase"
        Me.BarButtonItem18.Id = 28
        Me.BarButtonItem18.ImageOptions.Image = Global.NguyenPhuHiep.My.Resources.Resources.Database_Active_icon
        Me.BarButtonItem18.Name = "BarButtonItem18"
        Me.BarButtonItem18.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup4, Me.RibbonPageGroup7})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Main"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnExcel)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem18)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btn_thongsocot)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Nhập Liệu Các thông số tính toán"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btn_chonvatlieu)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Thông Tin Của Phần Mềm"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btn_noiLuc)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem15)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnhuongdan)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "HƯớng Dẫn Sử dụng"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup9, Me.RibbonPageGroup2, Me.RibbonPageGroup5})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Phương Pháp Tính Toán"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.Text = "Tính Thép Cột"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_banve)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Kết quả bố trí thép"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btn_tinhthep)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "RibbonPageGroup5"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup6})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Phương Pháp Kiểm Tra"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_kiemtra)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_xuatbanve)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "RibbonPageGroup6"
        '
        'Pn_Display
        '
        Me.Pn_Display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Display.Location = New System.Drawing.Point(0, 143)
        Me.Pn_Display.Name = "Pn_Display"
        Me.Pn_Display.Size = New System.Drawing.Size(1024, 505)
        Me.Pn_Display.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'View_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 648)
        Me.Controls.Add(Me.Pn_Display)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "View_main"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tính Toán Cột Tròn-Nguyễn Phú Hiệp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_thongsocot As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_chonvatlieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_huongdan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_thongtin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Pn_Display As Panel
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAccess As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_tinhthep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_kiemtra As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_banve As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_xuatbanve As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnhuongdan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_noiLuc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
