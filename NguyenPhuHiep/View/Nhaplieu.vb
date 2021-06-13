Imports NguyenPhuHiep
Public Class Nhaplieu
    Public issua As Integer = -1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        innitmodel()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public btmap As Bitmap
    Private _gr1 As Graphics
    Public Pn As Pen = New Pen(Brushes.Black, 2)
    Public netdim As Pen = New Pen(Brushes.Black, 1)
    Public pn_blue As Pen = New Pen(Brushes.Blue, 2)
    Public pn_magenta As Pen = New Pen(Brushes.Magenta, 1)
    Public Pn2 As Pen = New Pen(Brushes.Red, 1)
    Public Property Gr As Graphics
        Get
            Return _gr1
        End Get
        Set(value As Graphics)
            _gr1 = value
        End Set
    End Property
    Public Draws As Draw


    Public Sub innitmodel()
        Try
            Dim fn As Font = Draw.font(10)
            btmap = New Bitmap(1000, 1000)
            Gr = Graphics.FromImage(btmap)

            ' lấy giá trị đường kính của cột, điểm tầm của ảnh 
            Dim Scale As Double = 0.25 ' tỉ lệ trên ban ve
            Dim Diameter As Single = 1000 'Convert.ToSingle(txt_duongkinh.Text)
            Dim radius As Integer = Diameter / 2 ' bán kính thật
            Dim radius_model As Integer = radius * Scale
            Dim diameter2 As Single = Diameter - 200
            Dim radius_model2 As Integer = (diameter2 / 2) * Scale
            Dim PointCenter, Point_12h As Point

            PointCenter.X = Convert.ToInt32(PictureBox1.Width / 2) - 60
            PointCenter.Y = Convert.ToInt32(PictureBox1.Height / 2)
            '=========Thân của hàm vẽ=====================
            'Ve hinh tron o giuong
            Draw.Create_New_cicle(Gr, pn_blue, PointCenter, Diameter, Scale)
            ' Vẽ hinh tron ben trong
            Dim ht2 As RectangleF = Draw.Create_New_cicle(Gr, Pn, PointCenter, diameter2, Scale)
            Draw.Fill_ciccle(Gr, Brushes.Aquamarine, ht2)

            ' vẽ thép 
            Draw.Create_new_Steel(Gr, Pn, PointCenter.X + radius_model2, PointCenter.Y, 10, 1, Brushes.Magenta)
            Draw.Create_new_Steel(Gr, Pn, PointCenter.X - radius_model2, PointCenter.Y, 10, 1, Brushes.Magenta)
            Draw.Create_new_Steel(Gr, Pn, PointCenter.X, PointCenter.Y + radius_model2, 10, 1, Brushes.Magenta)
            Draw.Create_new_Steel(Gr, Pn, PointCenter.X, PointCenter.Y - radius_model2, 10, 1, Brushes.Magenta)
            Dim b As Double = 45 * Math.PI / 180
            Dim radius_5h As Integer = Convert.ToInt32(Math.Cos(b) * radius_model2)
            Draw.Create_new_Steel(Gr, Pn, PointCenter.X + radius_5h, PointCenter.Y + radius_5h, 10, 1, Brushes.Magenta)
            Draw.Create_new_Steel(Gr, Pn, PointCenter.X + radius_5h, PointCenter.Y - radius_5h, 10, 1, Brushes.Magenta)
            Draw.Create_new_Steel(Gr, Pn, PointCenter.X - radius_5h, PointCenter.Y - radius_5h, 10, 1, Brushes.Magenta)
            Draw.Create_new_Steel(Gr, Pn, PointCenter.X - radius_5h, PointCenter.Y + radius_5h, 10, 1, Brushes.Magenta)
            'Dim kich thuoc cua hinh tron nho 
            Dim p1, p2 As Point
            p1.X = PointCenter.X + radius_model + 20
            p1.Y = PointCenter.Y - radius_model2
            p2.X = PointCenter.X + radius_model + 20
            p2.Y = PointCenter.Y + radius_model2
            Dim giatri1 As Double = Convert.ToDouble(txt_duongkinh.Text) - 80 'giá trị của đường kính hình tròn bên trong
            Draw.Create_New_Dim(p1, p2, netdim, Gr, giatri1.ToString, fn)
            ' Tạo Dim cho Hình tròn to bên ngoài
            Dim p3, p4 As Point
            p3.X = PointCenter.X + radius_model + 80
            p3.Y = PointCenter.Y - radius_model
            p4.X = PointCenter.X + radius_model + 80
            p4.Y = PointCenter.Y + radius_model
            Draw.Create_New_Dim(p3, p4, netdim, Gr, txt_duongkinh.Text, fn)
            '=========Thân của hàm vẽ
            ' Chuyển hình vẽ lên ảnh
            PictureBox1.Image = btmap
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click, btn_new.Click
        txt_tencot.Text = ""
        txt_duongkinh.Text = ""
        txt_lucdoc.Text = ""
        txt_momenuon.Text = ""
        txt_chieudaitinhtoan.Text = ""
        txt_tencot.Focus()

    End Sub

    Private Sub txt_duongkinh_TextChanged(sender As Object, e As EventArgs) Handles txt_duongkinh.TextChanged
        Try
            innitmodel()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        Data.ntu = txt_lucdoc.Text
        Data.momen = txt_momenuon.Text
        Data.chieudaitinh = txt_chieudaitinhtoan.Text
        Data.duongkinhbandau = txt_duongkinh.Text
        Data.lopbaove = txt_lopbaove.Text

    End Sub
End Class