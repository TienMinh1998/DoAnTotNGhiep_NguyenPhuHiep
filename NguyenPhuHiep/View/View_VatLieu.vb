Public Class View_VatLieu
    Private _code_1 As Byte
    Private _code_2 As Byte

    Public Property Code_1 As Byte
        Get
            Return _code_1
        End Get
        Set(value As Byte)
            _code_1 = value
        End Set
    End Property
    Public Property Code_2 As Byte
        Get
            Return _code_2
        End Get
        Set(value As Byte)
            _code_2 = value
        End Set
    End Property

    Private Sub cbb_betong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_betong.SelectedIndexChanged
        Code_1 = Convert.ToByte(cbb_betong.SelectedIndex)
        Dim vlbt As New Material(Code_1)
        ' Hiện Bê tông lên
        txtRb.Text = vlbt.Rb.ToString
        txtRbt.Text = vlbt.Rbt.ToString
        txtEb.Text = vlbt.Eb.ToString
    End Sub

    Private Sub cbb_thep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_thep.SelectedIndexChanged
        Code_2 = Convert.ToByte(cbb_thep.SelectedIndex)
        Dim vlt As New Material(Code_2, True)
        ' HIện các chỉ số của thép lên
        txtRs.Text = vlt.Rs.ToString
        txtRsc.Text = vlt.Rsc.ToString
        txtEs.Text = vlt.Es.ToString
    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub View_VatLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Data.vatlieu_cot = New Material(Code_1, Code_2)
        Me.Close()
    End Sub
End Class