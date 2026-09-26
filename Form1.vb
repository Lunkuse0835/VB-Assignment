Imports System.Diagnostics.Tracing

Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalsales As Decimal = 0
        Dim amount As Decimal
        Dim discount As Decimal
        Dim finalAmount As Decimal

        For customer As Integer = 1 To 2

            amount = CDec(InputBox("Enter amount spent by Customer" & customer))

            If amount < 100 Then
                discount = 0
            ElseIf amount <= 500 Then
                discount = amount * 0.1

            Else
                discount = amount * 0.2
            End If
            finalAmount = amount - discount
            MessageBox.Show("Customer" & customer &
                             vbCrLf & "Amount: $" & amount &
                             vbCrLf & "discount $" & discount &
                             vbCrLf & "Final Amount: $" & finalAmount)
            totalsales += finalAmount

        Next
        MessageBox.Show("Total amount for 3 cutomers = $" & totalsales)
    End Sub
End Class
