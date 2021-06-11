Public Class Hamve

    Public Shared links As String = "\\mauchuan1.dxf" ' Bản vẽ mẫu mình truyền vào



    Public Shared Function vehinhtron(bv As VDProLib5.vdEntities, center As Point, radius As Double) As Point
        Dim Entity As VDProLib5.vdCircle
        With bv
            Entity = .AddCircle(New Object() {center.X, center.Y}, radius)
            Entity.LayerName = "3"
            Entity.Invalidate()
        End With
        Return center
    End Function
    Public Shared Function vehinhtron(bv As VDProLib5.vdEntities, center As Point, radius As Double, layer As String) As Point
        Dim Entity As VDProLib5.vdCircle
        With bv
            Entity = .AddCircle(New Object() {center.X, center.Y}, radius)
            Entity.LayerName = layer
            Entity.Invalidate()
        End With
        Return center
    End Function
    ''' <summary>
    ''' Đây là hàm vẽ số thanht thep con ở bên trong
    ''' </summary>
    ''' <param name="bv"></param>
    ''' <param name="center"></param>
    ''' <param name="radius"></param>
    ''' <param name="layer"></param>
    ''' <returns></returns>
    Public Shared Function vethep(bv As VDProLib5.vdEntities, center As Point, radius As Double, layer As String) As Point
        Dim Entity As VDProLib5.vdCircle
        With bv
            Entity = .AddCircle(New Object() {center.X, center.Y}, radius)
            Entity.LayerName = layer
            Entity.FillMode = VDProLib5.VdConstFill.VdFillModeUnknown
            Entity.hatchBlock = "SOLID"
            Entity.FillColor.ColorIndex = 1
            Entity.Invalidate()
        End With
        Return center ' trả ra điểm chèn của cái chấm tròn đó
    End Function
    Public Shared Sub zoom()
        View_BanVe.vdr.CommandAction.Zoom("E", 200, 20)
    End Sub

    Public Shared Sub veduongthang(bv As VDProLib5.vdEntities, diem1 As Point, diem2 As Point)

        Dim line As VDProLib5.vdLine

        Dim p1 As Object = New Object() {diem1.X, diem1.Y}
        Dim p2 As Object = New Object() {diem2.X, diem2.Y}
        With bv
            line = .AddLine(p1, p2)
            line.LayerName = "Truc"
            line.LineTypeScale = 200

        End With
    End Sub

    Public Shared Sub CreateNewLine(bv As VDProLib5.vdEntities, diem1 As Point, diem2 As Point, ler As String)

        Dim line As VDProLib5.vdLine

        Dim p1 As Object = New Object() {diem1.X, diem1.Y}
        Dim p2 As Object = New Object() {diem2.X, diem2.Y}
        With bv
            line = .AddLine(p1, p2)
            line.LayerName = ler
            line.LineTypeScale = 200

        End With
    End Sub
    Public Shared Sub CreateNewText(bv As VDProLib5.vdEntities, str As String, diemchen As Point, height As Double)
        Dim myTxt As VDProLib5.vdText
        With bv
            ' vẽ đường trục cho tường

            myTxt = View_BanVe.vdr.ActiveDocument.Entities.AddText(str, New Object() {diemchen.X, diemchen.Y}, height)
            myTxt.LayerName = "2"
        End With
    End Sub

    Public Shared Sub CreateVewDim(bv As VDProLib5.vdEntities, st As Point, ed As Point, centerpoint As Point)
        Dim DimKT As VDProLib5.vdDimension
        With bv
            ' vẽ đường trục cho tường

            DimKT = .AddDimAligned(New Object() {st.X, st.Y}, New Object() {ed.X, ed.Y}, New Object() {centerpoint.X, centerpoint.Y})
            DimKT.Scale(1, 1)
        End With
    End Sub

    Public Shared Sub CreateNewReatangule(bv As VDProLib5.vdEntities, chieudai As Double, chieurong As Double, Center As Point)
        Dim hcn As VDProLib5.vdRect
        Dim x As Integer = Center.X - CInt(chieurong / 2.0#)
        Dim y As Integer = Center.Y - CInt(chieudai / 2.0#)
        Dim diemchien As New Point()
        diemchien.X = x
        diemchien.Y = y

        With bv
            ' vẽ đường trục cho tường
            hcn = .AddRect(New Object() {diemchien.X, diemchien.Y}, chieurong, chieudai)
            hcn.LayerName = "3"
            hcn.Invalidate()


        End With
    End Sub
    Public Shared Function thep_doc_cot(bv As VDProLib5.vdEntities, p As Point, giatri As String) As Point
        Dim block As VDProLib5.vdInsert
        With bv
            block = .InsertBlock(New Object() {p.X, p.Y}, "thep_doc_cot", 1, 1, Nothing)
            block.SetAttribValue("D25", giatri)

        End With
        Return p ' Trả ra điểm tâm để chèn Block
    End Function
    Public Shared Sub CreateNewPoline(bv As VDProLib5.vdEntities, lst As List(Of Point))
        Dim pl As VDProLib5.vdLine
        With bv
            pl = .AddLine(New Object() {lst(0).X, lst(0).Y}, New Object() {lst(2).X, lst(2).Y})
            pl.LayerName = "1"




            pl = .AddLine(New Object() {lst(3).X, lst(3).Y}, New Object() {lst(5).X, lst(5).Y})
            pl.LayerName = "1"
            pl = .AddLine(New Object() {lst(4).X, lst(4).Y}, New Object() {lst(6).X, lst(6).Y})
            pl.LayerName = "1"
            pl = .AddLine(New Object() {lst(7).X, lst(7).Y}, New Object() {lst(1).X, lst(1).Y})
            pl.LayerName = "1"
        End With

    End Sub
End Class


