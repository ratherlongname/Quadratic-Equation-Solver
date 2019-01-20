Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            Dim Coeffa As Decimal = CDec(txtCoeffa.Text)
            Dim Coeffb As Decimal = CDec(txtCoeffb.Text)
            Dim Coeffc As Decimal = CDec(txtCoeffc.Text)

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers only",
                            "Error")

        Catch ex As Exception

            MessageBox.Show("An unknown error occured",
                            "Error")

        End Try

    End Sub
End Class
