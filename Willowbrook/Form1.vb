Option Strict On

Public Class frmMain

    Dim hlthClbClc As New HealtClubCalculator()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Integer.TryParse(txtBasicFee.Text, hlthClbClc.BasicFee)



    End Sub
End Class
