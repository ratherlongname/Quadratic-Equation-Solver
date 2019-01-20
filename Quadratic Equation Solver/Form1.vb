Public Class QuadraticEquationSolver

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            Dim a As Decimal = CDec(txtCoeffa.Text)
            Dim b As Decimal = CDec(txtCoeffb.Text)
            Dim c As Decimal = CDec(txtCoeffc.Text)

            Dim DiscriminantVal As Decimal = CalculateDiscriminant(a, b, c)
            txtDiscriminantVal.Text = CStr(DiscriminantVal)

            If DiscriminantVal < 0 Then
                txtDiscriminantPosOrNegValue.Text = "negative"
                txtNatureOfRoots.Text = "imaginary"
                HideRoots()
            ElseIf DiscriminantVal = 0 Then
                txtDiscriminantPosOrNegValue.Text = "equal to zero"
                txtNatureOfRoots.Text = "coincident"
                ShowRoots(a, b, c, DiscriminantVal)
            ElseIf DiscriminantVal > 0 Then
                txtDiscriminantPosOrNegValue.Text = "positive"
                txtNatureOfRoots.Text = "unique"
                ShowRoots(a, b, c, DiscriminantVal)
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
        txtRoot01.Text = String.Format("{0:0.00}", R01)
        txtRoot02.Text = String.Format("{0:0.00}", R02)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        For Each c In Me.Controls
            If c.GetType() Is GetType(TextBox) Then
                Dim txt As TextBox = CType(c, TextBox)
                txt.Text = ""
            End If
        Next

    End Sub
End Class
