Imports System.Drawing
Public Class Form1
    Dim radius As Integer
    Dim x, y, b, fx, fy As Integer
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

    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click
        Call MidPoint_Circle()
    End Sub


    Private Sub circlePoints()
        'We initially used small elipses to repesent a pixel..Until we learned how to actually set pixels'
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center + y, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + y, y_center + x, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - y, y_center + x, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - x, y_center + y, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - x, y_center - y, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - y, y_center - x, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + y, y_center - x, 10, 10))
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center - y, 10, 10))
        gfx.DrawImage(bm, x_center + x, y_center + y, 10, 10)
        gfx.DrawImage(bm, x_center + y, y_center + x, 10, 10)
        gfx.DrawImage(bm, x_center - y, y_center + x, 10, 10)
        gfx.DrawImage(bm, x_center - x, y_center + y, 10, 10)
        gfx.DrawImage(bm, x_center - x, y_center - y, 10, 10)
        gfx.DrawImage(bm, x_center - y, y_center - x, 10, 10)
        gfx.DrawImage(bm, x_center + y, y_center - x, 10, 10)
        gfx.DrawImage(bm, x_center + x, y_center - y, 10, 10)

    End Sub

    Public Sub MidPoint_Circle(x_center, y_center, radius)
        gfx = pbDrawing.CreateGraphics
        bm.SetPixel(0, 0, Color.Red)
        radius = 100
        x = 0
        y = radius
        x_center = 190
        y_center = 200
        d = (5 / 4) - radius

        Do While y > x
            Call circlePoints()
            If d < 0 Then
                d = d + (2 * x) + 1
            Else
                d = d + (2 * (x - y)) + 1
                y = y - 1
            End If
            x += 1
        Loop

    End Sub

    Public Sub Midpoint_Elipse()
        rx = 20
        ry = 30
        x = 0
        y = ry
        rx_sqr = rx * rx
        ry_sqr = ry * ry
        x_center = pbDrawing.Width / 2
        y_center = pbDrawing.Height / 2
        fx = ry_sqr * (2 * y - 1)
        fy = 2 * rx_sqr * (x + 1)
        d = 4 * ry_sqr - 4 * rx_sqr * ry + rx_sqr
        'this part is for region 1'
        Do While (2 * rx_sqr * (x + 1)) < (ry_sqr * (2 * y - 1))
            gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center + y, 10, 10))
            gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - x, y_center - y, 10, 10))
            gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center - y, 10, 10))
            gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - x, y_center + y, 10, 10))
            'putpixel(xc + x, yc - y, WHITE);
            'putpixel(xc - x, yc + y, WHITE);
            'putpixel(xc + x, yc + y, WHITE);
            'putpixel(xc - x, yc - y, WHITE);
            If d > 0 Then
                y -= 1
                d += ry_sqr * (8 * x + 12) + rx_sqr * (8 - 8 * y)
            Else
                d += ry_sqr * (8 * x + 12)
            End If
            x += 1
        Loop

        'this part is for region 2'
        d = ry_sqr * ((2 * x + 1) * (2 * x + 1)) + 4 * rx_sqr * ((y - 1) * (y - 1)) - 4 * rx_sqr * ry_sqr
        Do While y > 0

            If d < 0 Then
                x += 1
                d = d + ry_sqr * (8 * x + 8) + rx_sqr * (12 - 8 * y)
            Else
                d = d + rx_sqr * (12 - 8 * y)
            End If
            y -= 1
            gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center + y, 10, 10))
            gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - x, y_center - y, 10, 10))
            gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center - y, 10, 10))
            gfx.DrawEllipse(Pens.Red, New Rectangle(x_center - x, y_center + y, 10, 10))
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
