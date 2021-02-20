Imports System.Drawing
Imports System.IO
Public Class Form1
    Dim radius As Integer
    Dim x, y, a, b, fx, fy, Ssize As Integer
    Dim d As Long
    Dim rx_sqr, ry_sqr As Integer
    Dim rx, ry As Integer
    Dim midpoint As Integer
    Dim x_center As Integer
    Dim y_center As Integer
    Dim bm As New Bitmap(1, 1)
    Dim gfx As Graphics
    Dim writer As StreamWriter
    Dim reader As StreamReader


    Dim yc As Integer
    Dim xc As Integer
    Dim r As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ComboColor.Items.Add("Red")
        ComboColor.Items.Add("Green")
        ComboColor.Items.Add("Blue")
        ComboColor.Items.Add("Yellow")
        ComboColor.Items.Add("Purple")

        ComboSize.Items.Add("12")
        ComboSize.Items.Add("10")
        ComboSize.Items.Add("8")
        ComboSize.Items.Add("6")
        ComboSize.Items.Add("4")
        ComboSize.Items.Add("2")
    End Sub

    'Draw a Circle or Ellipse
    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        Dim Shape As String = ComboShape.Text
        Dim data As ListViewItem
        If Shape = "Circle" Then
            data = lvData.Items.Add(tbX.Text)
            data.SubItems.Add(tbY.Text)
            data.SubItems.Add(ComboShape.Text)
            data.SubItems.Add(tbRadius.Text)
            data.SubItems.Add(tbRadius.Text)
            data.SubItems.Add(tbRadius.Text)
            data.SubItems.Add(ComboColor.Text)
            data.SubItems.Add(ComboSize.Text)
            Call MidPoint_Circle(Integer.Parse(tbX.Text), Integer.Parse(tbY.Text), Integer.Parse(tbRadius.Text), Integer.Parse(ComboSize.Text), ComboColor.Text)
        ElseIf Shape = "Ellipse" Then
            data = lvData.Items.Add(tbX.Text)
            data.SubItems.Add(tbY.Text)
            data.SubItems.Add(ComboShape.Text)
            data.SubItems.Add(tbRadius.Text)
            data.SubItems.Add(tbRadiusX.Text)
            data.SubItems.Add(tbRadiusY.Text)
            data.SubItems.Add(ComboColor.Text)
            data.SubItems.Add(ComboSize.Text)
            Call ellipse(Integer.Parse(tbX.Text), Integer.Parse(tbY.Text), Integer.Parse(tbRadiusX.Text), Integer.Parse(tbRadiusY.Text), Integer.Parse(ComboSize.Text), ComboColor.Text)
        Else
            MsgBox("Choose the shape first", MsgBoxStyle.OkOnly, "More Info required")
        End If

        'Circle
        'Ellipse
    End Sub

    Private Sub btnClearScreen_Click(sender As Object, e As EventArgs) Handles btnClearScreen.Click
        pbDrawing.Invalidate()
    End Sub
    Private Sub SaveYourDataHereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveYourDataHereToolStripMenuItem.Click
        Save()
    End Sub



    Public Sub Save()
        Dim save As SaveFileDialog
        save = New SaveFileDialog()
        save.CreatePrompt = True
        save.FileName = "TestDoc"
        save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

        If save.ShowDialog() = DialogResult.OK Then
            writer = File.AppendText(save.FileName)
            For Each ndata As ListViewItem In lvData.Items
                writer.WriteLine(ndata.Text & "#" & ndata.SubItems(1).Text & "#" & ndata.SubItems(2).Text & "#" & ndata.SubItems(3).Text & "#" & ndata.SubItems(4).Text & "#" & ndata.SubItems(5).Text & "#" & ndata.SubItems(6).Text & "#" & ndata.SubItems(7).Text)
            Next
            writer.Flush()
        End If

    End Sub

    Private Sub LoadYourDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadYourDataToolStripMenuItem.Click
        LoadData()
    End Sub

    Public Sub LoadData()
        lvData.Items.Clear()
        pbDrawing.Invalidate()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        pbDrawing.Refresh()
        ayorefresh()
    End Sub

    Public Sub ayorefresh()
        If lvData.SelectedItems.Count < 0 Then
            For Each data As ListViewItem In lvData.Items
                Dim dataX = data.Text
                Dim dataY = data.SubItems(1).Text
                Dim shape = data.SubItems(2).Text
                Dim radius = data.SubItems(3).Text
                Dim radiusX = data.SubItems(4).Text
                Dim radiusY = data.SubItems(5).Text
                Dim colors = data.SubItems(6).Text
                Dim Tsize = data.SubItems(7).Text

                Select Case shape
                    Case "Circle"
                        Call MidPoint_Circle(Integer.Parse(tbX.Text), Integer.Parse(tbY.Text), Integer.Parse(tbRadius.Text), Integer.Parse(Tsize), colors)


                    Case "Ellipse"
                        gfx = pbDrawing.CreateGraphics

                        Select Case colors
                            Case "Red"
                                bm.SetPixel(0, 0, Color.Red)
                            Case "Green"
                                bm.SetPixel(0, 0, Color.Green)
                            Case "Blue"
                                bm.SetPixel(0, 0, Color.Blue)
                            Case "Yellow"
                                bm.SetPixel(0, 0, Color.Yellow)
                            Case "Purple"
                                bm.SetPixel(0, 0, Color.Purple)
                            Case "White"
                                bm.SetPixel(0, 0, Color.White)
                        End Select

                        Dim d As Long
                        Dim xc As Integer = dataX
                        Dim yc As Integer = dataY
                        Dim rx As Integer = radiusX
                        Dim ry As Integer = radiusY
                        'semua yang ada di dataX tapindah di xc , pada saat indhira pnge lgsg mo tpindah dp data

                        Dim x = 0
                        Dim y = ry

                        Dim a_square = rx * rx
                        Dim b_square = ry * ry

                        'region 1
                        d = 4 * b_square - 4 * a_square * ry + a_square

                        Do
                            Ssize = Integer.Parse(Tsize)
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
                End Select

            Next

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dataX = lvData.SelectedItems(0).SubItems(0).Text
        Dim dataY = lvData.SelectedItems(0).SubItems(1).Text
        Dim shape = lvData.SelectedItems(0).SubItems(2).Text
        Dim radius = lvData.SelectedItems(0).SubItems(3).Text
        Dim radiusX = lvData.SelectedItems(0).SubItems(4).Text
        Dim radiusY = lvData.SelectedItems(0).SubItems(5).Text
        Dim colors = lvData.SelectedItems(0).SubItems(6).Text
        Dim sizes = lvData.SelectedItems(0).SubItems(7).Text

        Select Case shape
            Case "Circle"
                Call MidPoint_Circle(Integer.Parse(dataX), Integer.Parse(dataY), Integer.Parse(radius), Integer.Parse(sizes) + 4, "White")

            Case "Ellipse"
                Call ellipse(Integer.Parse(dataX), Integer.Parse(dataY), Integer.Parse(radiusX), Integer.Parse(radiusY), Integer.Parse(sizes) + 4, "White")

        End Select


        Dim datas As ListViewItem
        datas = lvData.SelectedItems(0)
        datas.Remove()


    End Sub


    Private Sub circlePoints(x_center, y_center, Ssize)
        'We initially used small elipses to repesent a pixel..Until we learned how to actually set pixels'
        'gfx.DrawEllipse(Pens.Red, New Rectangle(x_center + x, y_center + y, 10, 10))
        gfx.DrawImage(bm, x_center + x, y_center + y, Ssize, Ssize)
        gfx.DrawImage(bm, x_center + y, y_center + x, Ssize, Ssize)
        gfx.DrawImage(bm, x_center - y, y_center + x, Ssize, Ssize)
        gfx.DrawImage(bm, x_center - x, y_center + y, Ssize, Ssize)
        gfx.DrawImage(bm, x_center - x, y_center - y, Ssize, Ssize)
        gfx.DrawImage(bm, x_center - y, y_center - x, Ssize, Ssize)
        gfx.DrawImage(bm, x_center + y, y_center - x, Ssize, Ssize)
        gfx.DrawImage(bm, x_center + x, y_center - y, Ssize, Ssize)



    End Sub

    Public Sub MidPoint_Circle(x_center, y_center, radius, Ssize, mycolor)
        gfx = pbDrawing.CreateGraphics
        Select Case mycolor
            Case "Red"
                bm.SetPixel(0, 0, Color.Red)
            Case "Green"
                bm.SetPixel(0, 0, Color.Green)
            Case "Blue"
                bm.SetPixel(0, 0, Color.Blue)
            Case "Yellow"
                bm.SetPixel(0, 0, Color.Yellow)
            Case "Purple"
                bm.SetPixel(0, 0, Color.Purple)
            Case "White"
                bm.SetPixel(0, 0, Color.White)
        End Select
        x = 0
        y = radius
        d = (5 / 4) - radius

        Do While y > x
            circlePoints(x_center, y_center, Ssize)
            If d < 0 Then
                d = d + (2 * x) + 1
            Else
                d = d + (2 * (x - y)) + 1
                y = y - 1
            End If
            x += 1
        Loop

    End Sub


    Public Sub ellipse(xc, yc, a, b, Ssize, colour)

        gfx = pbDrawing.CreateGraphics

        Select Case colour
            Case "Red"
                bm.SetPixel(0, 0, Color.Red)
            Case "Green"
                bm.SetPixel(0, 0, Color.Green)
            Case "Blue"
                bm.SetPixel(0, 0, Color.Blue)
            Case "Yellow"
                bm.SetPixel(0, 0, Color.Yellow)
            Case "Purple"
                bm.SetPixel(0, 0, Color.Purple)
            Case "White"
                bm.SetPixel(0, 0, Color.White)
        End Select


        Dim d As Long

        Dim x = 0
        Dim y = b

        Dim a_square = a * a
        Dim b_square = b * b

        'region 1
        d = 4 * b_square - 4 * a_square * b + a_square

        Do

            gfx.DrawImage(bm, x + xc, y + yc, Ssize, Ssize)
            gfx.DrawImage(bm, -x + xc, y + yc, Ssize, Ssize)
            gfx.DrawImage(bm, x + xc, -y + yc, Ssize, Ssize)
            gfx.DrawImage(bm, -x + xc, -y + yc, Ssize, Ssize)

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

            gfx.DrawImage(bm, x + xc, y + yc, Ssize, Ssize)
            gfx.DrawImage(bm, -x + xc, y + yc, Ssize, Ssize)
            gfx.DrawImage(bm, x + xc, -y + yc, Ssize, Ssize)
            gfx.DrawImage(bm, -x + xc, -y + yc, Ssize, Ssize)


        End While
    End Sub


    Private Sub pbDrawing_MouseClick(sender As Object, e As MouseEventArgs) Handles pbDrawing.MouseClick
        Cursor.Current = Cursors.Cross
        If e.Button = MouseButtons.Left Then
            tbX.Text = e.X
            tbY.Text = e.Y
        End If
    End Sub

    'To do delete
    Private Sub lvData_MouseClick(sender As Object, e As MouseEventArgs) Handles lvData.MouseClick
        Dim dataX = lvData.SelectedItems(0).SubItems(0).Text
        Dim dataY = lvData.SelectedItems(0).SubItems(1).Text
        Dim shape = lvData.SelectedItems(0).SubItems(2).Text
        Dim radius = lvData.SelectedItems(0).SubItems(3).Text
        Dim radiusX = lvData.SelectedItems(0).SubItems(4).Text
        Dim radiusY = lvData.SelectedItems(0).SubItems(5).Text
        Dim colors = lvData.SelectedItems(0).SubItems(6).Text
        Dim size = lvData.SelectedItems(0).SubItems(7).Text

        tbX.Text = dataX
        tbY.Text = dataY
        ComboShape.Text = shape
        tbRadius.Text = radius
        tbRadiusX.Text = radiusX
        tbRadiusY.Text = radiusY
        ComboColor.Text = colors
        ComboSize.Text = size

    End Sub
End Class
