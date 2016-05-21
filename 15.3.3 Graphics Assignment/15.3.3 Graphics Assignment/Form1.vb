Public Class frmGraphics
    'Columbus Dong
    'Graphics Assignment
    '12/6/2013



    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        'Show Color Dialog
        Me.LineColor1.ShowDialog()
        Me.LineColor2.ShowDialog()

    End Sub

    Private Sub btnLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLine.Click

        Dim LineSurface As Graphics = Me.CreateGraphics 'Creates Surface

        Dim ThinPen As New Pen(LineColor1.Color, 5) 'Create new pen
        Dim ThickPen As New Pen(LineColor2.Color, 15) 'Create new pen

        'Draw the Lines
        LineSurface.DrawLine(ThinPen, 300, 300, 500, 300)
        LineSurface.DrawLine(ThickPen, 400, 400, 500, 400)
    End Sub

    Private Sub btnArc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArc.Click

        Dim LineSurface As Graphics = Me.CreateGraphics 'Creates Surface

        Dim ThinPen As New Pen(LineColor1.Color, 5) 'Create new pen
        Dim ThickPen As New Pen(LineColor2.Color, 15) 'Create new pen

        'Draw Arcs
        LineSurface.DrawArc(ThinPen, 250, 250, 50, 250, 45.0F, 180.0F)
        LineSurface.DrawArc(ThickPen, 150, 150, 50, 200, 45.0F, 180.0F)
    End Sub

    Private Sub btnRectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRectangle.Click

        Dim LineSurface As Graphics = Me.CreateGraphics 'Creates Surface

        Dim ThinPen As New Pen(LineColor1.Color, 5) 'Create new pen
        Dim ThickPen As New Pen(LineColor2.Color, 15) 'Create new pen

        'Draw Rectangles
        LineSurface.DrawRectangle(ThinPen, 250, 250, 100, 150)
        LineSurface.DrawRectangle(ThickPen, 350, 350, 100, 150)
    End Sub

    Private Sub btnEllipse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEllipse.Click

        Dim LineSurface As Graphics = Me.CreateGraphics 'Creates Surface

        Dim ThinPen As New Pen(LineColor1.Color, 5) 'Create new pen
        Dim ThickPen As New Pen(LineColor2.Color, 15) 'Create new pen

        'Draw Ellipse
        LineSurface.DrawEllipse(ThinPen, 250, 250, 100, 150)
        LineSurface.DrawEllipse(ThickPen, 350, 350, 100, 150)
    End Sub

    Private Sub btnOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOther.Click

        Dim LineSurface As Graphics = Me.CreateGraphics 'Creates Surface

        Dim ThinBrush As New SolidBrush(LineColor1.Color) 'Create new Brush
        Dim ThickPen As New SolidBrush(LineColor2.Color) 'Create new Brush

        'Draw Shapes, a Rectangle and Ellipse
        LineSurface.FillRectangle(ThinBrush, 150, 150, 50, 100)
        LineSurface.FillEllipse(ThickPen, 150, 50, 100, 50)
    End Sub
End Class
