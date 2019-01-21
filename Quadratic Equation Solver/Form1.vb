Public Class QuadraticEquationSolver

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            Dim a As Decimal = CDec(txtCoeffa.Text)
            Dim b As Decimal = CDec(txtCoeffb.Text)
            Dim c As Decimal = CDec(txtCoeffc.Text)

            Dim D As Decimal = CalculateDiscriminant(a, b, c)
            txtDiscriminantVal.Text = CStr(D)

            If D < 0 Then
                txtDiscriminantPosOrNegValue.Text = "negative"
                txtNatureOfRoots.Text = "imaginary"
                HideRoots()
                MakeGraph(a, b, c, D)
            ElseIf D = 0 Then
                txtDiscriminantPosOrNegValue.Text = "equal to zero"
                txtNatureOfRoots.Text = "coincident"
                ShowRoots(a, b, c, D)
                MakeGraph(a, b, c, D)
            ElseIf D > 0 Then
                txtDiscriminantPosOrNegValue.Text = "positive"
                txtNatureOfRoots.Text = "unique"
                ShowRoots(a, b, c, D)
                MakeGraph(a, b, c, D)
            End If


        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers only",
                            "Error")

        Catch ex As Exception

            MessageBox.Show("An unknown error occured",
                            "Error")

        End Try

    End Sub

    Private Function CalculateDiscriminant(a As Decimal, b As Decimal, c As Decimal)
        Return Math.Pow(b, 2) - 4 * a * c
    End Function

    Private Function y(a As Decimal, b As Decimal, c As Decimal, x As Decimal)
        Return a * x * x + b * x + c
    End Function

    Private Sub HideRoots()
        lblRoots.Visible = False
        txtRoot01.Visible = False
        lblAnd.Visible = False
        txtRoot02.Visible = False
    End Sub

    Private Sub ShowRoots(a As Decimal, b As Decimal, c As Decimal, D As Decimal)
        lblRoots.Visible = True
        txtRoot01.Visible = True
        lblAnd.Visible = True
        txtRoot02.Visible = True

        Dim R01 As Decimal = (-b - Math.Sqrt(D)) / (2 * a)
        Dim R02 As Decimal = (-b + Math.Sqrt(D)) / (2 * a)

        R01 = Math.Round(R01, 2)
        R02 = Math.Round(R02, 2)

        txtRoot01.Text = CStr(R01)
        txtRoot02.Text = CStr(R02)
    End Sub

    Private Sub MakeGraph(a As Decimal, b As Decimal, c As Decimal, D As Decimal)
        Dim MID As Decimal = (-b / (2 * a))
        chrtGraphPlot.Series("seriesParabolaSeries").Points.Clear()

        If D > 0 Then
            Dim R01 As Decimal = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 2)
            Dim R02 As Decimal = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 2)
            Dim stepSize As Decimal = Math.Round((R02 - R01) / 100, 2)

            For x = R01 - (20 * stepSize) To R01 - (1 * stepSize) Step stepSize
                chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(x, y(a, b, c, x))
            Next

            chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(R01, 0)

            For x = R01 + (1 * stepSize) To R02 - (1 * stepSize) Step stepSize
                chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(x, y(a, b, c, x))
            Next

            chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(R02, 0)

            For x = R02 + (1 * stepSize) To R02 + (20 * stepSize) Step stepSize
                chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(x, y(a, b, c, x))
            Next

        Else
            For x = MID - 5 To MID + 5 Step 0.1
                chrtGraphPlot.Series("seriesParabolaSeries").Points.AddXY(x, y(a, b, c, x))
            Next

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        chrtGraphPlot.Series("seriesParabolaSeries").Points.Clear()

        For Each c In Me.Controls
            If c.GetType() Is GetType(TextBox) Then
                Dim txt As TextBox = CType(c, TextBox)
                txt.Text = ""
            End If
        Next
    End Sub

End Class
