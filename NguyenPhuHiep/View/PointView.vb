Public Class FRM_PointView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        dgv.Rows.Clear()
        dgv.Rows.Add(0, 0)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FRM_PointView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class