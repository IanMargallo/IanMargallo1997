﻿Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'IDMAR1997
        If My.Settings.SerialKey = TextBox1.Text Then
            My.Settings.AppStat = "Full Version"
            My.Settings.Save()
            Close()
        Else
            MsgBox("Invalid Serial Key")

        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class