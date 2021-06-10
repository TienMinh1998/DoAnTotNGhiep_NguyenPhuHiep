Public Class View_thongsocot
    Private Sub btn_xong_Click(sender As Object, e As EventArgs) Handles btn_xong.Click
        Dim id As Integer
        Dim name As String
        Dim Dk, lopbaove, moment, lucdoc, chieudai As Double
        id = CInt(txt_ID.Text)
        name = txt_name.Text
        Dk = Convert.ToDouble(txt_duongkinhcot.Text)
        lopbaove = Convert.ToDouble(txt_lopbaove.Text)
        moment = Convert.ToDouble(txt_m.Text)
        lucdoc = Convert.ToDouble(txt_n.Text)
        chieudai = Convert.ToDouble(txt_chieudaitinhtoan.Text)
        ' khởi tạo cột
        Dim col As New cot_chuatinh(id, name, lucdoc, moment, Dk, chieudai, lopbaove)
        ' ném lên data
        innitcol(col)
    End Sub

    Public Sub innitcol(col As cot_chuatinh)
        'lưu lại

        Data.mycol = col
        Me.Close()

    End Sub
End Class