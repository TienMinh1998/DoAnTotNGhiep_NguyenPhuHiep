Public Class tohopView
    Private Sub tohopView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        dgvnl.Rows.Add(tencot, vitri, m3.Name, m3.TT, m3.HT, m3.GXP, m3.GXT, m3.GYp, m3.GYT, mxmax, mxtu, mxntu)
        dgvnl.Rows.Add(tencot, vitri, m2.Name, m2.TT, m2.HT, m2.GXP, m2.GXT, m2.GYp, m2.GYT, mytu, mymax, myntu)
        dgvnl.Rows.Add(tencot, vitri, p.Name, p.TT, p.HT, p.GXP, p.GXT, p.GYp, p.GYT, ntu, nxtu, Nmax, Nmax)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub dgv_excel_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvnl.CellPainting


        Dim y As Integer

        For y = 0 To dgvnl.Rows.Count - 1

            If (e.ColumnIndex = 0 And e.RowIndex = y) Then

                If Not IsNumeric(dgvnl(0, y).Value) Then   ' for instance i wanted to make something like band end merged with the next cell(s.t.h. like header band )

                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single

                End If

                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single

            End If


            If (e.ColumnIndex = 1 And e.RowIndex = y) Then

                If y > 0 Then

                    If dgvnl(1, y).Value = dgvnl(1, y - 1).Value Then
                    Else

                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single

                    End If
                End If

            End If


        Next
    End Sub

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
End Class