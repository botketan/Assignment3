﻿Public Class admin_template
    Private Sub admin_template_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create an instance of the form to embed
        Dim adminDashboardForm As New admin_dashboard()

        ' Set properties to ensure proper embedding
        adminDashboardForm.TopLevel = False
        adminDashboardForm.FormBorderStyle = FormBorderStyle.None
        adminDashboardForm.Dock = DockStyle.Fill ' Optional: Fill the panel with the form

        ' Add the embedded form to the panel
        SplitContainer1.Panel2.Controls.Add(adminDashboardForm)

        ' Show the embedded form
        adminDashboardForm.Show()
    End Sub

    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Me.Close()
        Admin_Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create an instance of Chat form
        Dim chatForm As New Chat()

        ' Set the form's AutoSize property to true
        chatForm.AutoSize = True

        ' Set the form's TopLevel property to false
        chatForm.TopLevel = False

        ' Add the form to Panel2
        SplitContainer1.Panel2.Controls.Add(chatForm)


        ' Set the form's Dock property to fill Panel2
        chatForm.Dock = DockStyle.Fill

        ' Display the form
        chatForm.Show()
    End Sub





End Class