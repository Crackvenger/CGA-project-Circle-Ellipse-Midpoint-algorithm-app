Imports System.Drawing
Public Class Form1
    Dim radius As Integer
    Dim x, y, b, fx, fy, w, h As Integer
    Dim d As Long
    Dim rx_sqr, ry_sqr As Integer
    Dim rx, ry As Integer
    Dim midpoint As Integer
    Dim x_center As Integer
    Dim y_center As Integer


    Dim bm As New Bitmap(1, 1)
    Dim gfx As Graphics

    Private Sub pbDrawing_MouseClick(sender As Object, e As MouseEventArgs) Handles pbDrawing.MouseClick
        Dim MouseX As String = e.X
        Dim MouseY As String = e.Y

        tbX.Text = MouseX
        tbY.Text = MouseY
    End Sub

    Private Sub btnElipse_Click(sender As Object, e As EventArgs) Handles btnElipse.Click
        Call ellipse()
    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        Call MidPoint_Circle(Integer.Parse(tbX.Text), Integer.Parse(tbY.Text), Integer.Parse(tbRadius.Text))
    End Sub

    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click

    End Sub


    Private Sub circlePoints(x_center, y_center, width, height)
        'We initially used small elipses to repesent a pixel..Until we learned how to actually set pixels'
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center + y, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + y, y_center + x, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - y, y_center + x, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - x, y_center + y, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - x, y_center - y, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - y, y_center - x, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + y, y_center - x, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center - y, 10, 10))
        gfx.DrawImage(bm, x_center + x, y_center + y, width, height)
        gfx.DrawImage(bm, x_center + y, y_center + x, width, height)
        gfx.DrawImage(bm, x_center - y, y_center + x, width, height)
        gfx.DrawImage(bm, x_center - x, y_center + y, width, height)
        gfx.DrawImage(bm, x_center - x, y_center - y, width, height)
        gfx.DrawImage(bm, x_center - y, y_center - x, width, height)
        gfx.DrawImage(bm, x_center + y, y_center - x, width, height)
        gfx.DrawImage(bm, x_center + x, y_center - y, width, height)

    End Sub

    Public Sub MidPoint_Circle(x_center, y_center, radius)
        gfx = pbDrawing.CreateGraphics
        bm.SetPixel(0, 0, Color.Red)
        x = 0
        y = radius
        d = (5 / 4) - radius
        w = 10
        h = 10
        Do While y > x
            circlePoints(x_center, y_center, w, h)
            If d < 0 Then
                d = d + (2 * x) + 1
            Else
                d = d + (2 * (x - y)) + 1
                y = y - 1
            End If
            x += 1
        Loop

    End Sub


    'New Elipse code made made by Indhira'
    Public Sub ellipse()

        'Dim gEllipse As Graphics = pbDrawing.CreateGraphics
        gfx = pbDrawing.CreateGraphics
        'Dim imgEllipse As New Bitmap(1, 1)
        bm.SetPixel(0, 0, Color.Indigo)


        Dim xc As Integer = 100
        Dim yc As Integer = 100
        Dim a As Integer = 75
        Dim b As Integer = 25

        Dim d As Long

        Dim x = 0
        Dim y = b 'y=b

        Dim a_square = a * a
        Dim b_square = b * b

        d = 4 * b_square - 4 * a_square * b + a_square

        Do
            gfx.DrawImage(bm, x + xc, y + yc, 14, 14)
            gfx.DrawImage(bm, -x + xc, y + yc, 14, 14)
            gfx.DrawImage(bm, x + xc, -y + yc, 14, 14)
            gfx.DrawImage(bm, -x + xc, -y + yc, 14, 14)

            If d > 0 Then
                y = y - 1
                d = d + b_square * (8 * x + 12) + a_square * (8 - 8 * y)
            Else
                d = d + b_square * (8 * x + 12)
            End If

            x = x + 1


        Loop Until 2 * b_square * (x + 1) >= a_square * (2 * y - 1)

        'region 2
        d = b_square * ((2 * x + 1) * (2 * x + 1)) + 4 * a_square * ((y - 1) * (y - 1)) - 4 * a_square * b_square

        While y > 0


            If d < 0 Then
                x = x + 1
                d = d + b_square * (8 * x + 8) + a_square * (12 - 8 * y)
            Else
                d = d + a_square * (12 - 8 * y)
            End If
            y = y - 1

            gfx.DrawImage(bm, x + xc, y + yc, 14, 14)
            gfx.DrawImage(bm, -x + xc, y + yc, 14, 14)
            gfx.DrawImage(bm, x + xc, -y + yc, 14, 14)
            gfx.DrawImage(bm, -x + xc, -y + yc, 14, 14)


        End While
    End Sub

    Private Sub pbDrawing_MouseMove(sender As Object, e As MouseEventArgs) Handles pbDrawing.MouseMove
        Dim MouseX As String = e.X.ToString
        Dim MouseY As String = e.Y.ToString

        lblX.Text = "X - " + MouseX
        lblY.Text = "Y - " + MouseY


    End Sub


End Class
