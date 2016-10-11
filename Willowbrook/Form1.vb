'Joshua Pickenpaugh
'October 10th, 2016
'Willowbrook Health Club (monthly dues).

Option Strict On

Public Class frmMain

    Dim hlthClbClc As New HealtClubCalculator()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Integer.TryParse(txtBasicFee.Text, hlthClbClc.BasicFee)

        If chkGolf.Checked Then
            hlthClbClc.Golf = True
        Else
            hlthClbClc.Golf = False
        End If

        If chkTennis.Checked Then
            hlthClbClc.Tennis = True
        Else
            hlthClbClc.Tennis = False
        End If

        If chkRacquetball.Checked Then
            hlthClbClc.Racquetball = True
        Else
            hlthClbClc.Racquetball = False
        End If

        lblAdditionalFeesTotal.Text = hlthClbClc.GetAdditionalCharges().ToString()
        lblTotal.Text = hlthClbClc.GetMonthlyDues.ToString()
    End Sub
End Class
