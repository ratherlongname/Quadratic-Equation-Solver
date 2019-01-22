Public Class QuadraticEquationSolver

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit button closes application.

        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculate button reads a, b, c and displays graph after calculating the roots.

        Try

            ' Read a, b, c and typecast as Decimals.
            Dim a As Decimal = CDec(txtCoeffa.Text)
            Dim b As Decimal = CDec(txtCoeffb.Text)
            Dim c As Decimal = CDec(txtCoeffc.Text)

            ' Calculate discriminant from a, b, c.
            Dim D As Decimal = CalculateDiscriminant(a, b, c)

            ' Display discriminant value.
            txtDiscriminantVal.Text = CStr(D)

            ' For rest of fields it matters whether roots are imaginary or not, so If-Else statements are used.
            ' For all cases - nature of discriminant, nature of roots, graph is displayed.
            If D < 0 Then

                txtDiscriminantPosOrNegValue.Text = "negative"
                txtNatureOfRoots.Text = "imaginary"

                ' Since roots are imaginary, textboxes to display the roots are hidden using subroutine HideRoots().
                HideRoots()

                MakeGraph(a, b, c, D)

            ElseIf D = 0 Then

                txtDiscriminantPosOrNegValue.Text = "equal to zero"
                txtNatureOfRoots.Text = "coincident"

                ' Since roots are coincident, textboxes to display the roots are shown using subroutine ShowRoots().
                ShowRoots(a, b, c, D)

                MakeGraph(a, b, c, D)

            ElseIf D > 0 Then

                txtDiscriminantPosOrNegValue.Text = "positive"
                txtNatureOfRoots.Text = "unique"

                ' Since roots are unique, textboxes to display the roots are shown using subroutine ShowRoots().
                ShowRoots(a, b, c, D)

                MakeGraph(a, b, c, D)

            End If


        Catch ex As System.InvalidCastException

            ' If values of a, b, c are not valid Decimals then error is shown.
            MessageBox.Show("Please enter numbers only",
                            "Error")

        Catch ex As Exception

            ' Any other exception results in this error message.
            MessageBox.Show("An unknown error occured",
                            "Error")

        End Try

    End Sub

    Private Function CalculateDiscriminant(a As Decimal, b As Decimal, c As Decimal)
        ' Function takes in a, b, c and returns discriminant.

        Return Math.Pow(b, 2) - 4 * a * c
    End Function

    Private Function y(a As Decimal, b As Decimal, c As Decimal, x As Decimal)
        ' Function takes in a, b, c, x and returns value of quadratic equation at x.

        Return a * x * x + b * x + c
    End Function

    Private Sub HideRoots()
        ' Subroutine to hide labels and textboxes used to display roots.

        lblRoots.Visible = False
        txtRoot01.Visible = False
        lblAnd.Visible = False
        txtRoot02.Visible = False
    End Sub

    Private Sub ShowRoots(a As Decimal, b As Decimal, c As Decimal, D As Decimal)
        ' Subroutine to show the labels and textboxes used to diaplay roots.
        ' Also displays roots inside the textboxes.

        ' Make labels, textboxes visible.
        lblRoots.Visible = True
        txtRoot01.Visible = True
        lblAnd.Visible = True
        txtRoot02.Visible = True

        ' Calculate the roots.
        Dim R01 As Decimal = (-b - Math.Sqrt(D)) / (2 * a)
        Dim R02 As Decimal = (-b + Math.Sqrt(D)) / (2 * a)

        ' Round-off the roots to 2 digits after the decimal.
        R01 = Math.Round(R01, 2)
        R02 = Math.Round(R02, 2)

        ' Display the roots in the textboxes.
        txtRoot01.Text = CStr(R01)
        txtRoot02.Text = CStr(R02)
    End Sub

    Private Sub MakeGraph(a As Decimal, b As Decimal, c As Decimal, D As Decimal)
        ' Subroutine to add points to graph and then display graph.

        ' Calculate x-coordinate of vertex of parabola, will be used in showing coincident roots parabola.
        Dim MID As Decimal = (-b / (2 * a))

        ' Clear any previously plotted points from graph.
        chrtGraphPlot.Series("seriesParabolaSeries").Points.Clear()

        ' Process of adding points to graph depends upon whether roots are unique or not, since if roots are unique we want them both to be in graph.
        If D > 0 Then

            ' Calculate roots.
            Dim R01 As Decimal = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 2)
            Dim R02 As Decimal = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 2)

            ' Calculate stepSize as 1/100 of the distance between the two roots.
            ' Rounded-off to 2 decimal places.
            Dim stepSize As Decimal = Math.Round((R02 - R01) / 100, 2)

            ' Add points lying left of leftmost root to graph.
            For x = R01 - (20 * stepSize) To R01 - (1 * stepSize) Step stepSize
                chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(x, y(a, b, c, x))
            Next

            ' Add left root to graph.
            chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(R01, 0)

            ' Add points lying between left and right roots to graph.
            For x = R01 + (1 * stepSize) To R02 - (1 * stepSize) Step stepSize
                chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(x, y(a, b, c, x))
            Next

            ' Add right root to graph.
            chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(R02, 0)

            ' Add points lying right of rightmost root to graph.
            For x = R02 + (1 * stepSize) To R02 + (20 * stepSize) Step stepSize
                chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(x, y(a, b, c, x))
            Next

        Else
            ' For parabola with coincident or imaginary roots, add points from 5 left to 5 right of parabola vertex.
            For x = MID - 5 To MID + 5 Step 0.1
                chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(x, y(a, b, c, x))
            Next

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset button clears all textboxes and the graph.

        ' Remove all points from graph.
        chrtGraphPlot.Series("seriesParabolaSeries").Points.Clear()

        ' Get all textboxes in application and set their text to empty string.
        For Each c In Me.Controls
            If c.GetType() Is GetType(TextBox) Then
                Dim txt As TextBox = CType(c, TextBox)
                txt.Text = ""
            End If
        Next

    End Sub

End Class
