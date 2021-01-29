Imports Guna.UI2.WinForms

Public Class MainForm

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim msg As DialogResult = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If msg = Windows.Forms.DialogResult.OK Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With AdditionForm
            .TopLevel = False
            MainPanel.Controls.Add(AdditionForm)
            .BringToFront()
            .Show()
            navLabel.Text = "Addition"
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With SubtractionForm
            .TopLevel = False
            MainPanel.Controls.Add(SubtractionForm)
            .BringToFront()
            .Show()
            navLabel.Text = "Subtraction"
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With MultiplicationForm
            .TopLevel = False
            MainPanel.Controls.Add(MultiplicationForm)
            .BringToFront()
            .Show()
            navLabel.Text = "Multiplication"
        End With
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        AboutForm.ShowDialog()
    End Sub
End Class
