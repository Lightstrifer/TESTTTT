Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("PAYROLL")
        MsgBox("SYSTEM")
        MsgBox("Yung")
        MsgBox("NAKUHAAAAAAAAAAAAAAAAAAAAA")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim first_name As String
        Dim last_name As String
        Dim bili As String
        Dim age As Integer
        Dim Bday As Date

        first_name = tfirstname.Text
        last_name = tlastname.Text
        age = tage.Text
        bili = bibilhin.Text
        MsgBox("Hello! " & first_name & " " & last_name & " Ang pogi mo")
        MsgBox("Ikaw ay " & age)
        MsgBox("Bumili ka ng " & bili)

        If (bili = "Orayt") Then
            MsgBox("Chipi")
            MsgBox("tatoos")
            MsgBox("Bangus")
            MsgBox("Tilapia")
        End If
    End Sub

    Private Sub bibilhin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bibilhin.SelectedIndexChanged

    End Sub
End Class
