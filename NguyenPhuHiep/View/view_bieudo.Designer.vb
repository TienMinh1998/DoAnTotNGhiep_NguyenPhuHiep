<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_bieudo
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btn_ve = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_duongkinhcot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.gr_kq = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cbbdiameter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_sothanh = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lb_thepsaukhichon = New System.Windows.Forms.Label()
        Me.lb_steel = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_anphasau = New System.Windows.Forms.TextBox()
        Me.txt_d2o = New System.Windows.Forms.TextBox()
        Me.txt_ysau = New System.Windows.Forms.TextBox()
        Me.txt_xsau = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_d1o = New System.Windows.Forms.TextBox()
        Me.txt_anphadau = New System.Windows.Forms.TextBox()
        Me.txt_ydau = New System.Windows.Forms.TextBox()
        Me.txt_xdau = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rd_diemsau = New System.Windows.Forms.RadioButton()
        Me.rd_diemdau = New System.Windows.Forms.RadioButton()
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        Me.CartesianChart1 = New LiveCharts.Wpf.CartesianChart()
        Me.lb_yk = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lb_xk = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lb_ba = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kq_noisuy = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_hskeodai = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_chieudaitinhtoan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_step_anpha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_n = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_m = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_lopbaove = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.gr_kq.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Gainsboro
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(2, 20)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1421, 821)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'btn_ve
        '
        Me.btn_ve.BorderColor = System.Drawing.Color.Aqua
        Me.btn_ve.BorderRadius = 10
        Me.btn_ve.BorderThickness = 1
        Me.btn_ve.CheckedState.Parent = Me.btn_ve
        Me.btn_ve.CustomImages.Parent = Me.btn_ve
        Me.btn_ve.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ve.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_ve.ForeColor = System.Drawing.Color.White
        Me.btn_ve.HoverState.Parent = Me.btn_ve
        Me.btn_ve.Location = New System.Drawing.Point(349, 46)
        Me.btn_ve.Name = "btn_ve"
        Me.btn_ve.ShadowDecoration.Parent = Me.btn_ve
        Me.btn_ve.Size = New System.Drawing.Size(101, 31)
        Me.btn_ve.TabIndex = 1
        Me.btn_ve.Text = "Get Data"
        '
        'txt_duongkinhcot
        '
        Me.txt_duongkinhcot.BorderRadius = 5
        Me.txt_duongkinhcot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_duongkinhcot.DefaultText = "1200"
        Me.txt_duongkinhcot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_duongkinhcot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_duongkinhcot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_duongkinhcot.DisabledState.Parent = Me.txt_duongkinhcot
        Me.txt_duongkinhcot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_duongkinhcot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_duongkinhcot.FocusedState.Parent = Me.txt_duongkinhcot
        Me.txt_duongkinhcot.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_duongkinhcot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_duongkinhcot.HoverState.Parent = Me.txt_duongkinhcot
        Me.txt_duongkinhcot.Location = New System.Drawing.Point(200, 47)
        Me.txt_duongkinhcot.Name = "txt_duongkinhcot"
        Me.txt_duongkinhcot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_duongkinhcot.PlaceholderText = "Nhập Bán Kính"
        Me.txt_duongkinhcot.SelectedText = ""
        Me.txt_duongkinhcot.ShadowDecoration.Parent = Me.txt_duongkinhcot
        Me.txt_duongkinhcot.Size = New System.Drawing.Size(90, 20)
        Me.txt_duongkinhcot.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Chart1)
        Me.GroupControl1.Location = New System.Drawing.Point(475, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1425, 843)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "BIỂU ĐỒ TƯƠNG TÁC KHÔNG THỨ NGUYÊN"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.gr_kq)
        Me.GroupControl2.Controls.Add(Me.ElementHost1)
        Me.GroupControl2.Controls.Add(Me.btn_ve)
        Me.GroupControl2.Controls.Add(Me.lb_yk)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.lb_xk)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Controls.Add(Me.Label9)
        Me.GroupControl2.Controls.Add(Me.lb_ba)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.Label11)
        Me.GroupControl2.Controls.Add(Me.Label14)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label15)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Controls.Add(Me.Label16)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.txt_kq_noisuy)
        Me.GroupControl2.Controls.Add(Me.txt_hskeodai)
        Me.GroupControl2.Controls.Add(Me.txt_chieudaitinhtoan)
        Me.GroupControl2.Controls.Add(Me.txt_step_anpha)
        Me.GroupControl2.Controls.Add(Me.txt_n)
        Me.GroupControl2.Controls.Add(Me.txt_m)
        Me.GroupControl2.Controls.Add(Me.txt_lopbaove)
        Me.GroupControl2.Controls.Add(Me.txt_duongkinhcot)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(457, 841)
        Me.GroupControl2.TabIndex = 5
        Me.GroupControl2.Text = "  Nhập Liệu"
        '
        'gr_kq
        '
        Me.gr_kq.Controls.Add(Me.GroupBox1)
        Me.gr_kq.Controls.Add(Me.GroupBox4)
        Me.gr_kq.Controls.Add(Me.GroupBox3)
        Me.gr_kq.Controls.Add(Me.rd_diemsau)
        Me.gr_kq.Controls.Add(Me.rd_diemdau)
        Me.gr_kq.Location = New System.Drawing.Point(5, 392)
        Me.gr_kq.Name = "gr_kq"
        Me.gr_kq.Size = New System.Drawing.Size(434, 442)
        Me.gr_kq.TabIndex = 9
        Me.gr_kq.TabStop = False
        Me.gr_kq.Text = "Get Anpha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.cbbdiameter)
        Me.GroupBox1.Controls.Add(Me.txt_sothanh)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.lb_thepsaukhichon)
        Me.GroupBox1.Controls.Add(Me.lb_steel)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 213)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Get Cốt Thép"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.RadioButton2.Location = New System.Drawing.Point(264, 29)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(116, 20)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Chọn Tự Động"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.RadioButton1.Location = New System.Drawing.Point(42, 30)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(121, 20)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Chọn Thủ Công"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cbbdiameter
        '
        Me.cbbdiameter.BackColor = System.Drawing.Color.Transparent
        Me.cbbdiameter.BorderRadius = 10
        Me.cbbdiameter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbdiameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbdiameter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbdiameter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbdiameter.FocusedState.Parent = Me.cbbdiameter
        Me.cbbdiameter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbbdiameter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbbdiameter.HoverState.Parent = Me.cbbdiameter
        Me.cbbdiameter.ItemHeight = 30
        Me.cbbdiameter.Items.AddRange(New Object() {"6", "10", "12", "14", "16", "18", "20", "22", "25"})
        Me.cbbdiameter.ItemsAppearance.Parent = Me.cbbdiameter
        Me.cbbdiameter.Location = New System.Drawing.Point(180, 131)
        Me.cbbdiameter.Name = "cbbdiameter"
        Me.cbbdiameter.ShadowDecoration.Parent = Me.cbbdiameter
        Me.cbbdiameter.Size = New System.Drawing.Size(115, 36)
        Me.cbbdiameter.TabIndex = 3
        '
        'txt_sothanh
        '
        Me.txt_sothanh.BorderColor = System.Drawing.Color.White
        Me.txt_sothanh.BorderRadius = 10
        Me.txt_sothanh.BorderThickness = 0
        Me.txt_sothanh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sothanh.DefaultText = ""
        Me.txt_sothanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sothanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sothanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sothanh.DisabledState.Parent = Me.txt_sothanh
        Me.txt_sothanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sothanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sothanh.FocusedState.Parent = Me.txt_sothanh
        Me.txt_sothanh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_sothanh.ForeColor = System.Drawing.Color.Green
        Me.txt_sothanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sothanh.HoverState.Parent = Me.txt_sothanh
        Me.txt_sothanh.Location = New System.Drawing.Point(177, 103)
        Me.txt_sothanh.Name = "txt_sothanh"
        Me.txt_sothanh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sothanh.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_sothanh.PlaceholderText = "Chọn Số Thanh"
        Me.txt_sothanh.SelectedText = ""
        Me.txt_sothanh.ShadowDecoration.Parent = Me.txt_sothanh
        Me.txt_sothanh.Size = New System.Drawing.Size(121, 22)
        Me.txt_sothanh.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(55, 187)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(133, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Giá Trị Cốt Thép Chọn :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 147)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(106, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "chọn đường kính :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(55, 109)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(97, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Chọn Cốt Thép : "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(55, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(178, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Diện Tích Cốt Thép Tính Toán : "
        '
        'lb_thepsaukhichon
        '
        Me.lb_thepsaukhichon.AutoSize = True
        Me.lb_thepsaukhichon.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_thepsaukhichon.ForeColor = System.Drawing.Color.Green
        Me.lb_thepsaukhichon.Location = New System.Drawing.Point(236, 178)
        Me.lb_thepsaukhichon.Name = "lb_thepsaukhichon"
        Me.lb_thepsaukhichon.Size = New System.Drawing.Size(70, 25)
        Me.lb_thepsaukhichon.TabIndex = 1
        Me.lb_thepsaukhichon.Text = "Label5"
        '
        'lb_steel
        '
        Me.lb_steel.AutoSize = True
        Me.lb_steel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_steel.ForeColor = System.Drawing.Color.Green
        Me.lb_steel.Location = New System.Drawing.Point(239, 62)
        Me.lb_steel.Name = "lb_steel"
        Me.lb_steel.Size = New System.Drawing.Size(70, 25)
        Me.lb_steel.TabIndex = 1
        Me.lb_steel.Text = "Label5"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_anphasau)
        Me.GroupBox4.Controls.Add(Me.txt_d2o)
        Me.GroupBox4.Controls.Add(Me.txt_ysau)
        Me.GroupBox4.Controls.Add(Me.txt_xsau)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(223, 66)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(195, 139)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Điểm sau : "
        '
        'txt_anphasau
        '
        Me.txt_anphasau.Location = New System.Drawing.Point(119, 26)
        Me.txt_anphasau.Name = "txt_anphasau"
        Me.txt_anphasau.Size = New System.Drawing.Size(70, 21)
        Me.txt_anphasau.TabIndex = 7
        '
        'txt_d2o
        '
        Me.txt_d2o.Location = New System.Drawing.Point(120, 107)
        Me.txt_d2o.Name = "txt_d2o"
        Me.txt_d2o.Size = New System.Drawing.Size(69, 21)
        Me.txt_d2o.TabIndex = 1
        '
        'txt_ysau
        '
        Me.txt_ysau.Location = New System.Drawing.Point(120, 80)
        Me.txt_ysau.Name = "txt_ysau"
        Me.txt_ysau.Size = New System.Drawing.Size(69, 21)
        Me.txt_ysau.TabIndex = 1
        '
        'txt_xsau
        '
        Me.txt_xsau.Location = New System.Drawing.Point(120, 53)
        Me.txt_xsau.Name = "txt_xsau"
        Me.txt_xsau.Size = New System.Drawing.Size(69, 21)
        Me.txt_xsau.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(33, 113)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "KC->(0,0)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(36, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Y :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(36, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "anpha"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(36, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "X  : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_d1o)
        Me.GroupBox3.Controls.Add(Me.txt_anphadau)
        Me.GroupBox3.Controls.Add(Me.txt_ydau)
        Me.GroupBox3.Controls.Add(Me.txt_xdau)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 139)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Điểm Đầu"
        '
        'txt_d1o
        '
        Me.txt_d1o.Location = New System.Drawing.Point(111, 112)
        Me.txt_d1o.Name = "txt_d1o"
        Me.txt_d1o.Size = New System.Drawing.Size(69, 21)
        Me.txt_d1o.TabIndex = 1
        '
        'txt_anphadau
        '
        Me.txt_anphadau.Location = New System.Drawing.Point(112, 29)
        Me.txt_anphadau.Name = "txt_anphadau"
        Me.txt_anphadau.Size = New System.Drawing.Size(70, 21)
        Me.txt_anphadau.TabIndex = 7
        '
        'txt_ydau
        '
        Me.txt_ydau.Location = New System.Drawing.Point(111, 85)
        Me.txt_ydau.Name = "txt_ydau"
        Me.txt_ydau.Size = New System.Drawing.Size(69, 21)
        Me.txt_ydau.TabIndex = 1
        '
        'txt_xdau
        '
        Me.txt_xdau.Location = New System.Drawing.Point(112, 58)
        Me.txt_xdau.Name = "txt_xdau"
        Me.txt_xdau.Size = New System.Drawing.Size(69, 21)
        Me.txt_xdau.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(21, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "KC->(0,0)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Y :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "anpha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "X  : "
        '
        'rd_diemsau
        '
        Me.rd_diemsau.AutoSize = True
        Me.rd_diemsau.Location = New System.Drawing.Point(223, 34)
        Me.rd_diemsau.Name = "rd_diemsau"
        Me.rd_diemsau.Size = New System.Drawing.Size(70, 17)
        Me.rd_diemsau.TabIndex = 0
        Me.rd_diemsau.Text = "Điểm Sau"
        Me.rd_diemsau.UseVisualStyleBackColor = True
        '
        'rd_diemdau
        '
        Me.rd_diemdau.AutoSize = True
        Me.rd_diemdau.Checked = True
        Me.rd_diemdau.Location = New System.Drawing.Point(18, 34)
        Me.rd_diemdau.Name = "rd_diemdau"
        Me.rd_diemdau.Size = New System.Drawing.Size(72, 17)
        Me.rd_diemdau.TabIndex = 0
        Me.rd_diemdau.TabStop = True
        Me.rd_diemdau.Text = "Điểm Đầu"
        Me.rd_diemdau.UseVisualStyleBackColor = True
        '
        'ElementHost1
        '
        Me.ElementHost1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ElementHost1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ElementHost1.Location = New System.Drawing.Point(293, 238)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(158, 142)
        Me.ElementHost1.TabIndex = 6
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Me.CartesianChart1
        '
        'lb_yk
        '
        Me.lb_yk.AutoSize = True
        Me.lb_yk.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_yk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_yk.Location = New System.Drawing.Point(201, 324)
        Me.lb_yk.Name = "lb_yk"
        Me.lb_yk.Size = New System.Drawing.Size(57, 20)
        Me.lb_yk.TabIndex = 1
        Me.lb_yk.Text = "Label5"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(5, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Bước Nhảy của Anpha"
        '
        'lb_xk
        '
        Me.lb_xk.AutoSize = True
        Me.lb_xk.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_xk.ForeColor = System.Drawing.Color.Navy
        Me.lb_xk.Location = New System.Drawing.Point(201, 291)
        Me.lb_xk.Name = "lb_xk"
        Me.lb_xk.Size = New System.Drawing.Size(53, 20)
        Me.lb_xk.TabIndex = 1
        Me.lb_xk.Text = "Label5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(5, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Lực Dọc"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(5, 331)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tọa độ Y của điểm K : "
        '
        'lb_ba
        '
        Me.lb_ba.AutoSize = True
        Me.lb_ba.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lb_ba.Location = New System.Drawing.Point(197, 252)
        Me.lb_ba.Name = "lb_ba"
        Me.lb_ba.Size = New System.Drawing.Size(77, 30)
        Me.lb_ba.TabIndex = 1
        Me.lb_ba.Text = "Label5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(5, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tọa độ X của điểm K :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(5, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Moment"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(5, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Chỉnh Hệ Số Kéo Dài"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(5, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Giá Trị Ba : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(299, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "mm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(6, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Chiều Dài của cột"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(296, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "mm"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(296, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "mm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(5, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lớp Bảo vệ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(5, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Đường Kính của cột"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "KN/m"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Kn"
        '
        'txt_kq_noisuy
        '
        Me.txt_kq_noisuy.BorderRadius = 5
        Me.txt_kq_noisuy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_kq_noisuy.DefaultText = "0"
        Me.txt_kq_noisuy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_kq_noisuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_kq_noisuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kq_noisuy.DisabledState.Parent = Me.txt_kq_noisuy
        Me.txt_kq_noisuy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kq_noisuy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kq_noisuy.FocusedState.Parent = Me.txt_kq_noisuy
        Me.txt_kq_noisuy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_kq_noisuy.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kq_noisuy.HoverState.Parent = Me.txt_kq_noisuy
        Me.txt_kq_noisuy.Location = New System.Drawing.Point(192, 360)
        Me.txt_kq_noisuy.Name = "txt_kq_noisuy"
        Me.txt_kq_noisuy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_kq_noisuy.PlaceholderText = "Hệ Số Kéo Dài K"
        Me.txt_kq_noisuy.SelectedText = ""
        Me.txt_kq_noisuy.SelectionStart = 1
        Me.txt_kq_noisuy.ShadowDecoration.Parent = Me.txt_kq_noisuy
        Me.txt_kq_noisuy.Size = New System.Drawing.Size(90, 20)
        Me.txt_kq_noisuy.TabIndex = 3
        '
        'txt_hskeodai
        '
        Me.txt_hskeodai.BorderRadius = 5
        Me.txt_hskeodai.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_hskeodai.DefaultText = "1.5"
        Me.txt_hskeodai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_hskeodai.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_hskeodai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_hskeodai.DisabledState.Parent = Me.txt_hskeodai
        Me.txt_hskeodai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_hskeodai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_hskeodai.FocusedState.Parent = Me.txt_hskeodai
        Me.txt_hskeodai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_hskeodai.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_hskeodai.HoverState.Parent = Me.txt_hskeodai
        Me.txt_hskeodai.Location = New System.Drawing.Point(197, 225)
        Me.txt_hskeodai.Name = "txt_hskeodai"
        Me.txt_hskeodai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_hskeodai.PlaceholderText = "Hệ Số Kéo Dài K"
        Me.txt_hskeodai.SelectedText = ""
        Me.txt_hskeodai.SelectionStart = 3
        Me.txt_hskeodai.ShadowDecoration.Parent = Me.txt_hskeodai
        Me.txt_hskeodai.Size = New System.Drawing.Size(90, 20)
        Me.txt_hskeodai.TabIndex = 3
        '
        'txt_chieudaitinhtoan
        '
        Me.txt_chieudaitinhtoan.BorderRadius = 5
        Me.txt_chieudaitinhtoan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_chieudaitinhtoan.DefaultText = "3000"
        Me.txt_chieudaitinhtoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_chieudaitinhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_chieudaitinhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chieudaitinhtoan.DisabledState.Parent = Me.txt_chieudaitinhtoan
        Me.txt_chieudaitinhtoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chieudaitinhtoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chieudaitinhtoan.FocusedState.Parent = Me.txt_chieudaitinhtoan
        Me.txt_chieudaitinhtoan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_chieudaitinhtoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chieudaitinhtoan.HoverState.Parent = Me.txt_chieudaitinhtoan
        Me.txt_chieudaitinhtoan.Location = New System.Drawing.Point(200, 170)
        Me.txt_chieudaitinhtoan.Name = "txt_chieudaitinhtoan"
        Me.txt_chieudaitinhtoan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chieudaitinhtoan.PlaceholderText = "Lực Dọc"
        Me.txt_chieudaitinhtoan.SelectedText = ""
        Me.txt_chieudaitinhtoan.SelectionStart = 4
        Me.txt_chieudaitinhtoan.ShadowDecoration.Parent = Me.txt_chieudaitinhtoan
        Me.txt_chieudaitinhtoan.Size = New System.Drawing.Size(90, 20)
        Me.txt_chieudaitinhtoan.TabIndex = 3
        '
        'txt_step_anpha
        '
        Me.txt_step_anpha.BorderRadius = 5
        Me.txt_step_anpha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_step_anpha.DefaultText = "0.1"
        Me.txt_step_anpha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_step_anpha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_step_anpha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_step_anpha.DisabledState.Parent = Me.txt_step_anpha
        Me.txt_step_anpha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_step_anpha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_step_anpha.FocusedState.Parent = Me.txt_step_anpha
        Me.txt_step_anpha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_step_anpha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_step_anpha.HoverState.Parent = Me.txt_step_anpha
        Me.txt_step_anpha.Location = New System.Drawing.Point(200, 199)
        Me.txt_step_anpha.Name = "txt_step_anpha"
        Me.txt_step_anpha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_step_anpha.PlaceholderText = "Lực Dọc"
        Me.txt_step_anpha.SelectedText = ""
        Me.txt_step_anpha.SelectionStart = 3
        Me.txt_step_anpha.ShadowDecoration.Parent = Me.txt_step_anpha
        Me.txt_step_anpha.Size = New System.Drawing.Size(90, 20)
        Me.txt_step_anpha.TabIndex = 3
        '
        'txt_n
        '
        Me.txt_n.BorderRadius = 5
        Me.txt_n.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_n.DefaultText = "800"
        Me.txt_n.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_n.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_n.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_n.DisabledState.Parent = Me.txt_n
        Me.txt_n.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_n.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_n.FocusedState.Parent = Me.txt_n
        Me.txt_n.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_n.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_n.HoverState.Parent = Me.txt_n
        Me.txt_n.Location = New System.Drawing.Point(200, 137)
        Me.txt_n.Name = "txt_n"
        Me.txt_n.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_n.PlaceholderText = "Lực Dọc"
        Me.txt_n.SelectedText = ""
        Me.txt_n.SelectionStart = 3
        Me.txt_n.ShadowDecoration.Parent = Me.txt_n
        Me.txt_n.Size = New System.Drawing.Size(90, 20)
        Me.txt_n.TabIndex = 3
        '
        'txt_m
        '
        Me.txt_m.BorderRadius = 5
        Me.txt_m.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_m.DefaultText = "176"
        Me.txt_m.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_m.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_m.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_m.DisabledState.Parent = Me.txt_m
        Me.txt_m.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_m.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_m.FocusedState.Parent = Me.txt_m
        Me.txt_m.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_m.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_m.HoverState.Parent = Me.txt_m
        Me.txt_m.Location = New System.Drawing.Point(200, 107)
        Me.txt_m.Name = "txt_m"
        Me.txt_m.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_m.PlaceholderText = "Moment"
        Me.txt_m.SelectedText = ""
        Me.txt_m.SelectionStart = 3
        Me.txt_m.ShadowDecoration.Parent = Me.txt_m
        Me.txt_m.Size = New System.Drawing.Size(90, 20)
        Me.txt_m.TabIndex = 3
        '
        'txt_lopbaove
        '
        Me.txt_lopbaove.BorderRadius = 5
        Me.txt_lopbaove.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lopbaove.DefaultText = "40"
        Me.txt_lopbaove.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lopbaove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lopbaove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lopbaove.DisabledState.Parent = Me.txt_lopbaove
        Me.txt_lopbaove.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lopbaove.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lopbaove.FocusedState.Parent = Me.txt_lopbaove
        Me.txt_lopbaove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_lopbaove.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lopbaove.HoverState.Parent = Me.txt_lopbaove
        Me.txt_lopbaove.Location = New System.Drawing.Point(200, 77)
        Me.txt_lopbaove.Name = "txt_lopbaove"
        Me.txt_lopbaove.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lopbaove.PlaceholderText = "Lớp bảo vệ"
        Me.txt_lopbaove.SelectedText = ""
        Me.txt_lopbaove.SelectionStart = 2
        Me.txt_lopbaove.ShadowDecoration.Parent = Me.txt_lopbaove
        Me.txt_lopbaove.Size = New System.Drawing.Size(90, 20)
        Me.txt_lopbaove.TabIndex = 3
        '
        'view_bieudo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 858)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "view_bieudo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view_bieudo"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.gr_kq.ResumeLayout(False)
        Me.gr_kq.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btn_ve As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_duongkinhcot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_lopbaove As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_n As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_m As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_step_anpha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend CartesianChart1 As LiveCharts.Wpf.CartesianChart
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lb_yk As Label
    Friend WithEvents lb_xk As Label
    Friend WithEvents lb_ba As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_chieudaitinhtoan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_hskeodai As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gr_kq As GroupBox
    Friend WithEvents txt_xdau As TextBox
    Friend WithEvents rd_diemsau As RadioButton
    Friend WithEvents rd_diemdau As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txt_ydau As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_ysau As TextBox
    Friend WithEvents txt_xsau As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_anphasau As TextBox
    Friend WithEvents txt_d2o As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_d1o As TextBox
    Friend WithEvents txt_anphadau As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_kq_noisuy As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lb_steel As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cbbdiameter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_sothanh As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lb_thepsaukhichon As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
