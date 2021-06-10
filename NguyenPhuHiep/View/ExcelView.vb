Imports Bunifu.UI.WinForms.BunifuDataGridView
Imports Microsoft.Office.Interop
Imports System.Threading

Public Class ExcelView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btn_laydulieu_Click(sender As Object, e As EventArgs)


    End Sub





    Private Sub addToTableExcel()
        Dim dem As Integer = dgv_excel.Rows.Count - 1
        Dim story, column, outputcase As String
        Dim station, p, V2, V3, T, M2, M3 As Double

        For i = 0 To dem
            story = dgv_excel.Rows(i).Cells(0).Value.ToString
            column = dgv_excel.Rows(i).Cells(1).Value.ToString
            outputcase = dgv_excel.Rows(i).Cells(2).Value.ToString
            station = Convert.ToDouble(dgv_excel.Rows(i).Cells(3).Value)
            p = Convert.ToDouble(dgv_excel.Rows(i).Cells(4).Value)
            V2 = Convert.ToDouble(dgv_excel.Rows(i).Cells(5).Value)
            V3 = Convert.ToDouble(dgv_excel.Rows(i).Cells(6).Value)
            T = Convert.ToDouble(dgv_excel.Rows(i).Cells(7).Value)
            M2 = Convert.ToDouble(dgv_excel.Rows(i).Cells(8).Value)
            M3 = Convert.ToDouble(dgv_excel.Rows(i).Cells(9).Value)
            Data.Add(story, column, outputcase, station, p, V2, V3, T, M2, M3)
        Next

    End Sub
    Private Sub GetFileExcel()
        dgv_excel.Rows.Clear()
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PROCESS.Visible = True
            Dim th As New Thread(AddressOf hello)
            th.Start()
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(OpenFileDialog1.FileName)
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
            'Dem so hang
            Dim sh As Integer
            For i As Integer = 2 To 100
                If xlWorkSheet.Cells(i, 1).value <> Nothing Then
                    sh = i - 1
                Else
                    Exit For
                End If
            Next
            Me.dgv_excel.Rows.Clear()


            For i As Integer = 2 To sh + 1
                dgv_excel.Rows.Add(xlWorkSheet.Cells(i, 1).value, xlWorkSheet.Cells(i, 2).value, xlWorkSheet.Cells(i, 3).value, xlWorkSheet.Cells(i, 4).value, xlWorkSheet.Cells(i, 5).value, xlWorkSheet.Cells(i, 6).value, xlWorkSheet.Cells(i, 7).value, xlWorkSheet.Cells(i, 8).value, xlWorkSheet.Cells(i, 9).value, xlWorkSheet.Cells(i, 10).value, xlWorkSheet.Cells(i, 11).value, xlWorkSheet.Cells(i, 12).value, xlWorkSheet.Cells(i, 13).value, xlWorkSheet.Cells(i, 14).value)

            Next
            xlWorkBook.Close()
            xlApp.Quit()
        End If
    End Sub
    Private Sub GetFillerName(tang As String, cot As String, station As Double)
        dgv_excel.Rows.Clear()

        Dim dem As Integer = Data.BangNoiLuc.Count - 1
        For i = 0 To dem - 1
            Dim item As cls_noiluc = Data.BangNoiLuc(i)
            If tang = item.Story Then
                If cot = item.column Then
                    If station = item.station Then
                        AddtoDataGriview(item)
                    End If

                End If
            End If
        Next
    End Sub

    Private Sub AddtoDataGriview(item As cls_noiluc)
        dgv_excel.Rows.Add(item.Story, item.column, item.outputcase, item.station, item.p, item.V2, item.V3, item.T, item.M2, item.M3, item.M)
    End Sub
    Private Sub btn_getexcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_getexcel.ItemClick
        GetFileExcel()
        addToTableExcel()
    End Sub


    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim a As PresetThemes

        dgv_excel.Theme = a.Maroon
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim a As New PresetThemes

        dgv_excel.Theme = a.MediumSeaGreen
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim a As New PresetThemes

        dgv_excel.Theme = a.LimeGreen
    End Sub
    Private Function isnull(cbb As ComboBox) As Boolean
        If cbb.SelectedIndex = -1 Then
            Return False
        End If
        Return True
    End Function

    Private Sub btn_locdulieu_MouseHover(sender As Object, e As EventArgs)
        lb_thongbao.Visible = True
        lb_thongbao.Text = "Click để lọc dữ liệu theo yêu cầu!!!"
    End Sub

    Private Sub btn_locdulieu_MouseLeave(sender As Object, e As EventArgs)
        lb_thongbao.Visible = False

    End Sub

    Private Sub dgv_excel_MouseMove(sender As Object, e As MouseEventArgs)
        lb_thongbao.Visible = True
        lb_thongbao.Text = "Chứa bảng nội lực mà bạn load vào!!!"
    End Sub

    Private Sub dgv_excel_MouseLeave(sender As Object, e As EventArgs)
        showintro("", False)
    End Sub

    Private Sub showintro(thongbao As String, isvisibal As Boolean)
        If isvisibal = True Then
            lb_thongbao.Visible = True
            lb_thongbao.Text = thongbao
        Else
            lb_thongbao.Visible = False
        End If
    End Sub

    Private Sub cbbTang_MouseMove(sender As Object, e As MouseEventArgs) Handles cbbTang.MouseMove
        showintro("Chọn Tầng để lọc", True)
    End Sub

    Private Sub cbbcot_MouseMove(sender As Object, e As MouseEventArgs) Handles cbbcot.MouseMove
        ' Lấy data để tổ hợp : 

        showintro("Chọn cột để lọc", True)
    End Sub
    Private Sub THCB1()
        Dim mxmax, mytu, ntu As Double ' cho thằng M3
        Dim mymax, mxtu, nxtu As Double ' cho thằng m2
        Dim Nmax, mxntu, myntu As Double ' cho thằng P 
        dgvnl.Rows.Clear()

        Dim tencot As String = Data.elementt.Tencot
        Dim vitri As Double = Data.elementt.location

        Dim m3 As cls_noiluc2 = Data.elementt.Garena(0) '
        Dim m2 As cls_noiluc2 = Data.elementt.Garena(1) '
        Dim p As cls_noiluc2 = Data.elementt.Garena(2) '

        Dim a(5), b(5), c(5) As Double
        a(0) = m3.HT
        a(1) = m3.GXP
        a(2) = m3.GXT
        a(3) = m3.GYp
        a(4) = m3.GYT

        b(0) = m2.HT
        b(1) = m2.GXP
        b(2) = m2.GXT
        b(3) = m2.GYp
        b(4) = m2.GYT

        c(0) = p.HT
        c(1) = p.GXP
        c(2) = p.GXT
        c(3) = p.GYp
        c(4) = p.GYT

        ' Tính cho MX max
        If m3.TT > 0 Then
            Dim max As New maxandvt
            max = isMax(a)
            mxmax = m3.TT + max.max
            mytu = m2.TT + truyenvitri(m2, max.vt)
            ntu = p.TT + truyenvitri(p, max.vt)
        End If
        If m3.TT < 0 Then
            Dim max As New maxandvt
            max = isMIn(a)
            mxmax = m3.TT + max.max
            mytu = m2.TT + truyenvitri(m2, max.vt) ' vị trí của thằng 3 truyền vào
            ntu = p.TT + truyenvitri(m2, max.vt)
        End If
        ' Tính CHO My max 
        If m2.TT > 0 Then
            Dim max As New maxandvt
            max = isMax(b)
            mymax = m2.TT + max.max
            mxtu = m3.TT + truyenvitri(m3, max.vt)
            nxtu = p.TT + truyenvitri(p, max.vt)
        End If
        If m2.TT < 0 Then
            Dim min As New maxandvt
            min = isMIn(b)
            mymax = m2.TT + min.max
            mxtu = m3.TT + truyenvitri(m3, min.vt) ' vị trí của thawgnf 2 tryueyenf vào
            nxtu = p.TT + truyenvitri(p, min.vt)
        End If

        ' Tính cho N max 
        If p.TT > 0 Then
            Dim max As New maxandvt
            max = isMax(c)
            Nmax = p.TT + max.max
            mxntu = m3.TT + truyenvitri(m3, max.vt)
            myntu = m2.TT + truyenvitri(m2, max.vt)
        End If
        If p.TT < 0 Then
            Dim min As New maxandvt
            min = isMIn(c)
            Nmax = p.TT + min.max
            mxntu = m3.TT + truyenvitri(m3, min.vt) ' vị trí của thawgnf 2 tryueyenf vào
            myntu = m2.TT + truyenvitri(m2, min.vt)
        End If

        dgvnl.Rows.Add(tencot, vitri, m3.Name, m3.TT, m3.HT, m3.GXP, m3.GXT, m3.GYp, m3.GYT)
        dgvnl.Rows.Add(tencot, vitri, m2.Name, m2.TT, m2.HT, m2.GXP, m2.GXT, m2.GYp, m2.GYT)
        dgvnl.Rows.Add(tencot, vitri, p.Name, p.TT, p.HT, p.GXP, p.GXT, p.GYp, p.GYT)

        ' Thêm vào bảng Kết quả : 
        dgv_kq.Rows.Clear()

        dgv_kq.Rows.Add(mxmax, mxtu, mxntu)
        dgv_kq.Rows.Add(mytu, mymax, myntu)
        dgv_kq.Rows.Add(nxtu, Nmax, Nmax)
    End Sub
    Private Sub THCB2()
        Dim mxmax, mytu, ntu As Double ' cho thằng M3
        Dim mymax, mxtu, nxtu As Double ' cho thằng m2
        Dim Nmax, mxntu, myntu As Double ' cho thằng P 
        ' dgvnl.Rows.Clear()

        Dim tencot As String = Data.elementt.Tencot
        Dim vitri As Double = Data.elementt.location

        Dim m3 As cls_noiluc2 = Data.elementt.Garena(0) '
        Dim m2 As cls_noiluc2 = Data.elementt.Garena(1) '
        Dim p As cls_noiluc2 = Data.elementt.Garena(2) '

        Dim a(4), b(4), c(4) As Double

        a(0) = m3.GXP
        a(1) = m3.GXT
        a(2) = m3.GYp
        a(3) = m3.GYT


        b(0) = m2.GXP
        b(1) = m2.GXT
        b(2) = m2.GYp
        b(3) = m2.GYT


        c(0) = p.GXP
        c(1) = p.GXT
        c(2) = p.GYp
        c(3) = p.GYT

        ' Tính cho MX max
        If m3.TT > 0 Then
            Dim max As New maxandvt
            max = isMax(a)

            mxmax = m3.TT + 0.9 * m3.HT + max.max
            mytu = m2.TT + 0.9 * m2.HT + truyenvitri2(m2, max.vt)
            ntu = p.TT + 0.9 * p.HT + truyenvitri2(p, max.vt)

        End If
        If m3.TT < 0 Then
            Dim min As New maxandvt
            min = isMIn(a)

            mxmax = m3.TT + 0.9 * m3.HT + min.max
            mytu = m2.TT + 0.9 * m2.HT + truyenvitri2(m2, min.vt) ' vị trí của thằng 3 truyền vào
            ntu = p.TT + 0.9 * p.HT + truyenvitri2(p, min.vt)

        End If

        ' Tính CHO My max 
        If m2.TT > 0 Then
            Dim max As New maxandvt
            max = isMax(b)
            mymax = m2.TT + 0.9 * m2.HT + max.max
            mxtu = m3.TT + 0.9 * m3.HT + truyenvitri2(m3, max.vt)
            nxtu = p.TT + 0.9 * p.HT + truyenvitri2(p, max.vt)
        End If
        If m2.TT < 0 Then
            Dim min As New maxandvt
            min = isMIn(b)
            mymax = m2.TT + 0.9 * m2.HT + min.max
            mxtu = m3.TT + 0.9 * m3.HT + truyenvitri2(m3, min.vt) ' vị trí của thawgnf 2 tryueyenf vào
            nxtu = p.TT + 0.9 * p.HT + truyenvitri2(p, min.vt)
        End If

        ' Tính cho N max 
        If p.TT > 0 Then
            Dim max As New maxandvt
            max = isMax(c)
            Nmax = p.TT + 0.9 * p.HT + max.max
            mxntu = m3.TT + 0.9 * m3.HT + truyenvitri2(m3, max.vt)
            myntu = m2.TT + 0.9 * m2.HT + truyenvitri2(m2, max.vt)
        End If
        If p.TT < 0 Then
            Dim min As New maxandvt
            min = isMIn(c)
            Nmax = p.TT + 0.9 * p.HT + min.max
            mxntu = m3.TT + 0.9 * m3.HT + truyenvitri2(m3, min.vt) ' vị trí của thawgnf 2 tryueyenf vào
            myntu = m2.TT + 0.9 * m2.HT + truyenvitri2(m2, min.vt)
        End If

        ' Thêm vào bảng Kết quả : 
        dgv_thcb2.Rows.Clear()
        dgv_thcb2.Rows.Add(mxmax, mxtu, mxntu)
        dgv_thcb2.Rows.Add(mytu, mymax, myntu)
        dgv_thcb2.Rows.Add(nxtu, Nmax, Nmax)
    End Sub

    Private Function truyenvitri(el As cls_noiluc2, vt As Integer) As Double
        Select Case vt
            Case 0
                Return el.HT
            Case 1
                Return el.GXP
            Case 2
                Return el.GXT
            Case 3
                Return el.GYp
            Case 4
                Return el.GYT
            Case Else
                Return 0
        End Select
    End Function

    Private Function truyenvitri2(el As cls_noiluc2, vt As Integer) As Double
        Select Case vt
            Case 0
                Return el.GXP
            Case 1
                Return el.GXT
            Case 2
                Return el.GYp
            Case 3
                Return el.GYT
            Case Else
                Return 0
        End Select
    End Function
    Private Function isMIn(a() As Double) As maxandvt
        Dim max As Double
        Dim m As New maxandvt
        max = a(0)
        For i = 0 To a.Length - 1
            If max > a(i) Then
                max = a(i)
                m.vt = i
            End If
        Next
        m.max = max
        Return m
    End Function
    Public Class maxandvt
        Public max As Double
        Public vt As Integer



    End Class
    Private Function isMax(a() As Double) As maxandvt
        Dim max As Double
        Dim m As New maxandvt
        max = a(0)
        For i = 0 To a.Length - 1
            If max < a(i) Then
                max = a(i)
                m.vt = i
            End If
        Next
        m.max = max
        Return m
    End Function
    Private Function isMaxTHCB2(a() As Double) As maxandvt
        Dim max As Double
        Dim m As New maxandvt
        max = a(0)
        For i = 0 To a.Length - 1
            If max < a(i) Then
                max = a(i)
                m.vt = i
            End If
        Next
        m.max = max
        Return m
    End Function

    Private Function TheSameValue(ByVal column As Integer, ByVal row As Integer) As Boolean
        Dim cell1 As DataGridViewCell = Me.dgvnl(column, row)
        Dim cell2 As DataGridViewCell = Me.dgvnl(column, row - 1)

        If cell1.Value Is Nothing OrElse cell2.Value Is Nothing Then
            Return False
        End If

        Return Equals(cell1.Value.ToString(), cell2.Value.ToString())
    End Function

    Sub hello()
        Thread.Sleep(1000)
        PROCESS.Visible = False
        Process2.Visible = False
    End Sub

    Private Sub ExcelView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.dgvnl.AutoGenerateColumns = False
    End Sub

    Private Sub dgvnl_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvnl.CellPainting
        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None

        If e.RowIndex < 1 OrElse e.ColumnIndex < 0 Then
            Return
        End If

        If TheSameValue(e.ColumnIndex, e.RowIndex) Then
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        Else
            e.AdvancedBorderStyle.Top = Me.dgvnl.AdvancedCellBorderStyle.Top
        End If
    End Sub

    Private Sub dgvnl_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvnl.CellFormatting
        If e.RowIndex = 0 Then
            Return
        End If

        If TheSameValue(e.ColumnIndex, e.RowIndex) Then
            e.Value = ""
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        PROCESS.Visible = True
        Process2.Visible = True
        Dim th As New Thread(AddressOf hello)
        th.Start()
        GetFillerName(cbbTang.SelectedItem.ToString, cbbcot.SelectedItem.ToString, Val(cbbstation.SelectedItem))




    End Sub

    Private Sub btn_tohop_Click(sender As Object, e As EventArgs) Handles btn_tohop.Click, BunifuButton2.Click
        Dim th As New Thread(AddressOf hello)
        PROCESS.Visible = True
        th.Start()

        ' chèn thêm 1 tiến trình vào

        Dim elmt As New Element
        Dim M3, M2, P As New cls_noiluc2
        elmt.location = 0
        M3.Name = "M3"
        M3.TT = dgv_excel.Rows(0).Cells(9).Value
        M3.HT = dgv_excel.Rows(1).Cells(9).Value
        M3.GXT = dgv_excel.Rows(2).Cells(9).Value
        M3.GXP = dgv_excel.Rows(3).Cells(9).Value
        M3.GYT = dgv_excel.Rows(4).Cells(9).Value
        M3.GYp = dgv_excel.Rows(5).Cells(9).Value


        M2.Name = "M2"
        M2.TT = dgv_excel.Rows(0).Cells(8).Value
        M2.HT = dgv_excel.Rows(1).Cells(8).Value
        M2.GXT = dgv_excel.Rows(2).Cells(8).Value
        M2.GXP = dgv_excel.Rows(3).Cells(8).Value
        M2.GYT = dgv_excel.Rows(4).Cells(8).Value
        M2.GYp = dgv_excel.Rows(5).Cells(8).Value

        P.Name = "P"
        P.TT = dgv_excel.Rows(0).Cells(4).Value
        P.HT = dgv_excel.Rows(1).Cells(4).Value
        P.GXT = dgv_excel.Rows(2).Cells(4).Value
        P.GXP = dgv_excel.Rows(3).Cells(4).Value
        P.GYT = dgv_excel.Rows(4).Cells(4).Value
        P.GYp = dgv_excel.Rows(5).Cells(4).Value
        elmt.Garena.Add(M3)
        elmt.Garena.Add(M2)
        elmt.Garena.Add(P)
        elmt.Tencot = cbbcot.Text
        elmt.location = 0
        ' trả ra cho thằng data
        Data.elementt = elmt
        THCB1()
        THCB2()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub




    Private Sub dgv_kq_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_kq.CellMouseClick
        gb_coban2.Visible = False
        gb_coban1.Visible = True



    End Sub

    Private Sub dgv_thcb2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_thcb2.CellMouseClick
        ' khi click vao thcb2

        gb_coban2.Visible = True
        gb_coban1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_chonnoiluc_Click(sender As Object, e As EventArgs) Handles btn_chonnoiluc.Click
        Select Case cb_noilucchon.SelectedIndex
            Case 0 ' đang là cột 1
                ' lưu thành mx, my, ntu ra beenn ngoài 
                Data.mx = dgv_kq.Rows(0).Cells(0).Value.ToString()
                Data.my = dgv_kq.Rows(1).Cells(0).Value.ToString()
                Data.ntu = dgv_kq.Rows(2).Cells(0).Value.ToString()
                MessageBox.Show("giá trị mx la : " + Data.mx + " , giá trị my là " + Data.my + " Giá trị N là : " + Data.ntu)
            Case 1
                ' lưu thành mx, my, ntu ra beenn ngoài 
                Data.mx = dgv_kq.Rows(0).Cells(1).Value.ToString()
                Data.my = dgv_kq.Rows(1).Cells(1).Value.ToString()
                Data.ntu = dgv_kq.Rows(2).Cells(1).Value.ToString()
                MessageBox.Show("giá trị mx la : " + Data.mx + " , giá trị my là " + Data.my + " Giá trị N là : " + Data.ntu)
            Case 2
                ' lưu thành mx, my, ntu ra beenn ngoài 
                Data.mx = dgv_kq.Rows(0).Cells(2).Value.ToString()
                Data.my = dgv_kq.Rows(1).Cells(2).Value.ToString()
                Data.ntu = dgv_kq.Rows(2).Cells(2).Value.ToString()
                MessageBox.Show("giá trị mx la : " + Data.mx + " , giá trị my là " + Data.my + " Giá trị N là : " + Data.ntu)
            Case Else

        End Select
    End Sub

    Private Sub btn_chonthcb2_Click(sender As Object, e As EventArgs) Handles btn_chonthcb2.Click
        Select Case ComboBox2.SelectedIndex
            Case 0 ' đang là cột 1
                ' lưu thành mx, my, ntu ra beenn ngoài 
                Data.mx = dgv_thcb2.Rows(0).Cells(0).Value.ToString()
                Data.my = dgv_thcb2.Rows(1).Cells(0).Value.ToString()
                Data.ntu = dgv_thcb2.Rows(2).Cells(0).Value.ToString()
                MessageBox.Show("giá trị mx la : " + Data.mx + " , giá trị my là " + Data.my + " Giá trị N là : " + Data.ntu)
            Case 1
                ' lưu thành mx, my, ntu ra beenn ngoài 
                Data.mx = dgv_thcb2.Rows(0).Cells(1).Value.ToString()
                Data.my = dgv_thcb2.Rows(1).Cells(1).Value.ToString()
                Data.ntu = dgv_thcb2.Rows(2).Cells(1).Value.ToString()
                MessageBox.Show("giá trị mx la : " + Data.mx + " , giá trị my là " + Data.my + " Giá trị N là : " + Data.ntu)
            Case 2
                ' lưu thành mx, my, ntu ra beenn ngoài 
                Data.mx = dgv_thcb2.Rows(0).Cells(2).Value.ToString()
                Data.my = dgv_thcb2.Rows(1).Cells(2).Value.ToString()
                Data.ntu = dgv_thcb2.Rows(2).Cells(2).Value.ToString()
                MessageBox.Show("giá trị mx la : " + Data.mx + " , giá trị my là " + Data.my + " Giá trị N là : " + Data.ntu)
            Case Else

        End Select
    End Sub
End Class