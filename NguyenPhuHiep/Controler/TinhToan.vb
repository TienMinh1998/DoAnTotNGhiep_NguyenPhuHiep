Public Class TinhToan


    Private Function DolechtamTH(moment As Double, lucdoc As Double) As Double
        Return moment / lucdoc
    End Function
    Private Function Dolechtamngaunhien_ea(l As Double, h As Double) As Double
        Dim a, b As Double
        a = l / 600
        b = h / 30
        Return If((a > b), a, b)
    End Function
    Public Function TinhToanK(duongkinhcot As Double, bk As Double, lucdoc As Double, chieudaitinhtoan As Double, moment As Double) As Boolean
        Dim K_m As Double
        Dim K_n As Double
        Dim ee, ea, I, Nth, neta, eo As Double

        ' Tinh do lech tam tinh hoc : 
        ee = DolechtamTH(moment, lucdoc) * 1000 ' đổi ra đơn vị milimet
        ea = Dolechtamngaunhien_ea(chieudaitinhtoan, duongkinhcot)
        ' Tính độ lệch tâm ban đầu :
        eo = If((ee > ea), ee, ea)
        'Tính moment quan tính 
        I = (Math.PI * duongkinhcot ^ 4) / 64
        ' Lục doc tôi han 
        Nth = (Data.vatlieu_cot.Eb * 2.5 * I) / Math.Pow(chieudaitinhtoan, 2) / 1000
        neta = 1 / (1 - (lucdoc / Nth))
        ' Tinh toa do diem K :
        K_n = (lucdoc * 1000) / (Data.vatlieu_cot.Rb * Math.PI * bk ^ 2) ' 200 là bán kính.  
        K_m = K_n * neta * eo / bk
        ' gán điểm 
        K.X = Math.Round(K_m, 3)
        K.Y = Math.Round(K_n, 3)
        If K.X <> 0 And K.Y <> 0 Then
            Return True ' Nếu K khác rỗng thì trả ra giá trị K
        Else
            Return False ' Nếu không thí trả ra sai : 

        End If
    End Function

End Class
