'Program: Smart Car Rental 
'Author: Waqas Khan
'Date: 04/22/2017
'Purpose: This application calculates and displays the total cost of rental of a Smart Car.
Option Strict On

Public Class frmSmartCar
    Const _cdecPricePerDay As Decimal = 29.99D
    Const _cdecPricePerMile As Decimal = 0.39D

    Private Sub displayFare_Click(sender As Object, e As EventArgs) Handles displayFare.Click

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        'Dim strtotalOfDays As String
        'Dim inttotalOfDays As Integer

        Dim strNumberOfMiles As String
        Dim intNumberOfMiles As Integer

        Dim decTotalOfNumberOfDays As Decimal
        Dim decTotalOfNumberOfMiles As Decimal
        Dim decdisplayFare As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalOfNumberOfDays = intNumberOfDays * _cdecPricePerDay

        strNumberOfMiles = txtNumberOfMiles.Text
        intNumberOfMiles = Convert.ToInt32(strNumberOfMiles)
        decTotalOfNumberOfMiles = intNumberOfMiles * _cdecPricePerMile

        decdisplayFare = decTotalOfNumberOfDays + decTotalOfNumberOfMiles
        lblTotalCost.Text = decdisplayFare.ToString("C")



    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        txtNumberOfDays.Clear()
        txtNumberOfMiles.Clear()
        lblTotalCost.Text = " "
        txtNumberOfDays.Focus()
        txtNumberOfMiles.Focus()

    End Sub

End Class
