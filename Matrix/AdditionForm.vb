Imports Guna.UI2.WinForms
Public Class AdditionForm

   
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        SubtractionForm.Hide()
        MultiplicationForm.Hide()
        Hide()
        MainForm.navLabel.Text = "Matrix"

    End Sub

    Sub hideTextbox(hide_textbox)
        If hide_textbox = "hide_a" Then
            'row 1
            a_row1_col1.Visible = False
            a_row1_col2.Visible = False
            a_row1_col3.Visible = False
            a_row1_col4.Visible = False

            'row 2
            a_row2_col1.Visible = False
            a_row2_col2.Visible = False
            a_row2_col3.Visible = False
            a_row2_col4.Visible = False

            'row 3
            a_row3_col1.Visible = False
            a_row3_col2.Visible = False
            a_row3_col3.Visible = False
            a_row3_col4.Visible = False

            'row 4
            a_row4_col1.Visible = False
            a_row4_col2.Visible = False
            a_row4_col3.Visible = False
            a_row4_col4.Visible = False

        ElseIf hide_textbox = "hide_b" Then
            'row 1
            b_row1_col1.Visible = False
            b_row1_col2.Visible = False
            b_row1_col3.Visible = False
            b_row1_col4.Visible = False

            'row 2
            b_row2_col1.Visible = False
            b_row2_col2.Visible = False
            b_row2_col3.Visible = False
            b_row2_col4.Visible = False

            'row 3
            b_row3_col1.Visible = False
            b_row3_col2.Visible = False
            b_row3_col3.Visible = False
            b_row3_col4.Visible = False

            'row 4
            b_row4_col1.Visible = False
            b_row4_col2.Visible = False
            b_row4_col3.Visible = False
            b_row4_col4.Visible = False
        End If
    End Sub


    Sub clearAnswerForm()
        'to hide answer form
        FormAnswer.ans_row1_col1.Visible = False
        FormAnswer.ans_row1_col2.Visible = False
        FormAnswer.ans_row1_col3.Visible = False
        FormAnswer.ans_row1_col4.Visible = False

        FormAnswer.ans_row2_col1.Visible = False
        FormAnswer.ans_row2_col2.Visible = False
        FormAnswer.ans_row2_col3.Visible = False
        FormAnswer.ans_row2_col4.Visible = False

        FormAnswer.ans_row3_col1.Visible = False
        FormAnswer.ans_row3_col2.Visible = False
        FormAnswer.ans_row3_col3.Visible = False
        FormAnswer.ans_row3_col4.Visible = False

        FormAnswer.ans_row4_col1.Visible = False
        FormAnswer.ans_row4_col2.Visible = False
        FormAnswer.ans_row4_col3.Visible = False
        FormAnswer.ans_row4_col4.Visible = False

        'clear answer form
        FormAnswer.ans_row1_col1.Text = ""
        FormAnswer.ans_row1_col2.Text = ""
        FormAnswer.ans_row1_col3.Text = ""
        FormAnswer.ans_row1_col4.Text = ""

        FormAnswer.ans_row2_col1.Text = ""
        FormAnswer.ans_row2_col2.Text = ""
        FormAnswer.ans_row2_col3.Text = ""
        FormAnswer.ans_row2_col4.Text = ""

        FormAnswer.ans_row3_col1.Text = ""
        FormAnswer.ans_row3_col2.Text = ""
        FormAnswer.ans_row3_col3.Text = ""
        FormAnswer.ans_row3_col4.Text = ""

        FormAnswer.ans_row4_col1.Text = ""
        FormAnswer.ans_row4_col2.Text = ""
        FormAnswer.ans_row4_col3.Text = ""
        FormAnswer.ans_row4_col4.Text = ""

    End Sub

    Private Sub SelectA_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles groupAComboBox.SelectedIndexChanged
        'to hide textbox
        hideTextbox("hide_a")
        'to clear textbox
        clearText("group_a")

        ''''''''''''' 2x2 ''''''''''''''''
        If groupAComboBox.SelectedItem = "2x2" Then

            a_row1_col1.Visible = True
            a_row1_col2.Visible = True
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True

            '''''''''''''''' 2x3 ''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "2x3" Then
            'row 1
            a_row1_col1.Visible = True
            a_row1_col2.Visible = True
            a_row1_col3.Visible = True
            'row 2
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True
            a_row2_col3.Visible = True

            '''''''''''' 2x4 ''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "2x4" Then
            'row 1
            a_row1_col1.Visible = True
            a_row1_col2.Visible = True
            a_row1_col3.Visible = True
            a_row1_col4.Visible = True
            'row 2
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True
            a_row2_col3.Visible = True
            a_row2_col4.Visible = True

            '''''''''''' 3x2 ''''''''''''
        ElseIf groupAComboBox.SelectedItem = "3x2" Then
            'row 1
            a_row1_col1.Visible = True
            a_row1_col2.Visible = True

            'row 2
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True

            'row 3
            a_row3_col1.Visible = True
            a_row3_col2.Visible = True

            '''''''''''' 3x3 ''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "3x3" Then
            'row 1
            a_row1_col1.Visible = True
            a_row1_col2.Visible = True
            a_row1_col3.Visible = True

            'row 2
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True
            a_row2_col3.Visible = True

            'row 3
            a_row3_col1.Visible = True
            a_row3_col2.Visible = True
            a_row3_col3.Visible = True

            '''''''''''''''3x4'''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "3x4" Then
            'row 1
            a_row1_col1.Visible = True
            a_row1_col2.Visible = True
            a_row1_col3.Visible = True
            a_row1_col4.Visible = True

            'row 2
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True
            a_row2_col3.Visible = True
            a_row2_col4.Visible = True

            'row 3
            a_row3_col1.Visible = True
            a_row3_col2.Visible = True
            a_row3_col3.Visible = True
            a_row3_col4.Visible = True

            '''''''''''''''' 4x2 '''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "4x2" Then
            'row 1
            a_row1_col1.Visible = True
            a_row1_col2.Visible = True

            'row 2
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True

            'row 3
            a_row3_col1.Visible = True
            a_row3_col2.Visible = True

            'row 4
            a_row4_col1.Visible = True
            a_row4_col2.Visible = True

            '''''''''''''''' 4x3 '''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "4x3" Then
            'row 1
            a_row1_col1.Visible = True
            a_row1_col2.Visible = True
            a_row1_col3.Visible = True

            'row 2
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True
            a_row2_col3.Visible = True

            'row 3
            a_row3_col1.Visible = True
            a_row3_col2.Visible = True
            a_row3_col3.Visible = True

            'row 4
            a_row4_col1.Visible = True
            a_row4_col2.Visible = True
            a_row4_col3.Visible = True

            '''''''''''''''' 4x4 '''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "4x4" Then
            'row 1
            a_row1_col1.Visible = True
            a_row1_col2.Visible = True
            a_row1_col3.Visible = True
            a_row1_col4.Visible = True

            'row 2
            a_row2_col1.Visible = True
            a_row2_col2.Visible = True
            a_row2_col3.Visible = True
            a_row2_col4.Visible = True

            'row 3
            a_row3_col1.Visible = True
            a_row3_col2.Visible = True
            a_row3_col3.Visible = True
            a_row3_col4.Visible = True

            'row 4
            a_row4_col1.Visible = True
            a_row4_col2.Visible = True
            a_row4_col3.Visible = True
            a_row4_col4.Visible = True

        End If
    End Sub

    Private Sub SelectB_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles groupBComboBox.SelectedIndexChanged
        'to hide textboxB 
        hideTextbox("hide_b")
        clearText("group_b")

        ''''''''''''' 2x2 ''''''''''''''''
        If groupBComboBox.SelectedItem = "2x2" Then

            b_row1_col1.Visible = True
            b_row1_col2.Visible = True
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True

            '''''''''''''''' 2x3 ''''''''''''''''
        ElseIf groupBComboBox.SelectedItem = "2x3" Then
            'row 1
            b_row1_col1.Visible = True
            b_row1_col2.Visible = True
            b_row1_col3.Visible = True
            'row 2
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True
            b_row2_col3.Visible = True

            '''''''''''' 2x4 ''''''''''''''
        ElseIf groupBComboBox.SelectedItem = "2x4" Then
            'row 1
            b_row1_col1.Visible = True
            b_row1_col2.Visible = True
            b_row1_col3.Visible = True
            b_row1_col4.Visible = True
            'row 2
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True
            b_row2_col3.Visible = True
            b_row2_col4.Visible = True

            '''''''''''' 3x2 ''''''''''''
        ElseIf groupBComboBox.SelectedItem = "3x2" Then
            'row 1
            b_row1_col1.Visible = True
            b_row1_col2.Visible = True

            'row 2
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True

            'row 3
            b_row3_col1.Visible = True
            b_row3_col2.Visible = True

            '''''''''''' 3x3 ''''''''''''''''
        ElseIf groupBComboBox.SelectedItem = "3x3" Then
            'row 1
            b_row1_col1.Visible = True
            b_row1_col2.Visible = True
            b_row1_col3.Visible = True

            'row 2
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True
            b_row2_col3.Visible = True

            'row 3
            b_row3_col1.Visible = True
            b_row3_col2.Visible = True
            b_row3_col3.Visible = True

            '''''''''''''''3x4'''''''''''''''
        ElseIf groupBComboBox.SelectedItem = "3x4" Then
            'row 1
            b_row1_col1.Visible = True
            b_row1_col2.Visible = True
            b_row1_col3.Visible = True
            b_row1_col4.Visible = True

            'row 2
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True
            b_row2_col3.Visible = True
            b_row2_col4.Visible = True

            'row 3
            b_row3_col1.Visible = True
            b_row3_col2.Visible = True
            b_row3_col3.Visible = True
            b_row3_col4.Visible = True

            '''''''''''''''' 4x2 '''''''''''''''''
        ElseIf groupBComboBox.SelectedItem = "4x2" Then
            'row 1
            b_row1_col1.Visible = True
            b_row1_col2.Visible = True

            'row 2
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True

            'row 3
            b_row3_col1.Visible = True
            b_row3_col2.Visible = True

            'row 4
            b_row4_col1.Visible = True
            b_row4_col2.Visible = True

            '''''''''''''''' 4x3 '''''''''''''''''
        ElseIf groupBComboBox.SelectedItem = "4x3" Then
            'row 1
            b_row1_col1.Visible = True
            b_row1_col2.Visible = True
            b_row1_col3.Visible = True

            'row 2
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True
            b_row2_col3.Visible = True

            'row 3
            b_row3_col1.Visible = True
            b_row3_col2.Visible = True
            b_row3_col3.Visible = True

            'row 4
            b_row4_col1.Visible = True
            b_row4_col2.Visible = True
            b_row4_col3.Visible = True

            '''''''''''''''' 4x4 '''''''''''''''''
        ElseIf groupBComboBox.SelectedItem = "4x4" Then
            'row 1
            b_row1_col1.Visible = True
            b_row1_col2.Visible = True
            b_row1_col3.Visible = True
            b_row1_col4.Visible = True

            'row 2
            b_row2_col1.Visible = True
            b_row2_col2.Visible = True
            b_row2_col3.Visible = True
            b_row2_col4.Visible = True

            'row 3
            b_row3_col1.Visible = True
            b_row3_col2.Visible = True
            b_row3_col3.Visible = True
            b_row3_col4.Visible = True

            'row 4
            b_row4_col1.Visible = True
            b_row4_col2.Visible = True
            b_row4_col3.Visible = True
            b_row4_col4.Visible = True

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ans_row1_col1, ans_row1_col2, ans_row1_col3, ans_row1_col4 As Double
        Dim ans_row2_col1, ans_row2_col2, ans_row2_col3, ans_row2_col4 As Double
        Dim ans_row3_col1, ans_row3_col2, ans_row3_col3, ans_row3_col4 As Double
        Dim ans_row4_col1, ans_row4_col2, ans_row4_col3, ans_row4_col4 As Double

        clearAnswerForm()
        '''''''''''''' 2by2 ''''''''''''''''
        If groupAComboBox.SelectedItem = "2x2" And groupBComboBox.SelectedItem = "2x2" Then
            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)

            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)

            'answer
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True

            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True

            FormAnswer.ShowDialog()

            '''''''''''' 2by3 '''''''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "2x3" And groupBComboBox.SelectedItem = "2x3" Then
            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)
            ans_row1_col3 = Val(a_row1_col3.Text) + Val(b_row1_col3.Text)
            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)
            ans_row2_col3 = Val(a_row2_col3.Text) + Val(b_row2_col3.Text)

            'answer
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            FormAnswer.ans_row1_col3.Text = ans_row1_col3
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True
            FormAnswer.ans_row1_col3.Visible = True

            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            FormAnswer.ans_row2_col3.Text = ans_row2_col3
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True
            FormAnswer.ans_row2_col3.Visible = True

            FormAnswer.ShowDialog()

            '''''''''''''''''' 2by4 ''''''''''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "2x4" And groupBComboBox.SelectedItem = "2x4" Then
            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)
            ans_row1_col3 = Val(a_row1_col3.Text) + Val(b_row1_col3.Text)
            ans_row1_col4 = Val(a_row1_col4.Text) + Val(b_row1_col4.Text)
            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)
            ans_row2_col3 = Val(a_row2_col3.Text) + Val(b_row2_col3.Text)
            ans_row2_col4 = Val(a_row2_col4.Text) + Val(b_row2_col4.Text)

            'answer
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            FormAnswer.ans_row1_col3.Text = ans_row1_col3
            FormAnswer.ans_row1_col4.Text = ans_row1_col4
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True
            FormAnswer.ans_row1_col3.Visible = True
            FormAnswer.ans_row1_col4.Visible = True

            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            FormAnswer.ans_row2_col3.Text = ans_row2_col3
            FormAnswer.ans_row2_col4.Text = ans_row2_col4
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True
            FormAnswer.ans_row2_col3.Visible = True
            FormAnswer.ans_row2_col4.Visible = True

            FormAnswer.ShowDialog()

            '''''''''''''''''' 3by2 ''''''''''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "3x2" And groupBComboBox.SelectedItem = "3x2" Then

            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)
            'ans_row1_col3 = Val(A_row1_col3.Text) + Val(B_row1_col3.Text)
            'ans_row1_col4 = Val(A_row1_col4.Text) + Val(B_row1_col4.Text)

            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)
            'ans_row2_col3 = Val(A_row2_col3.Text) + Val(B_row2_col3.Text)
            'ans_row2_col4 = Val(A_row2_col4.Text) + Val(B_row2_col4.Text)

            'row 3
            ans_row3_col1 = Val(a_row3_col1.Text) + Val(b_row3_col1.Text)
            ans_row3_col2 = Val(a_row3_col2.Text) + Val(b_row3_col2.Text)

            'answer
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            'FormAnswer.ans_row1_col3.Text = ans_row1_col3
            'FormAnswer.ans_row1_col4.Text = ans_row1_col4
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True
            'FormAnswer.ans_row1_col3.Visible = True
            'FormAnswer.ans_row1_col4.Visible = True

            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            'FormAnswer.ans_row2_col3.Text = ans_row2_col3
            'FormAnswer.ans_row2_col4.Text = ans_row2_col4
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True
            'FormAnswer.ans_row2_col3.Visible = True
            'FormAnswer.ans_row2_col4.Visible = True

            FormAnswer.ans_row3_col1.Text = ans_row3_col1
            FormAnswer.ans_row3_col2.Text = ans_row3_col2
            FormAnswer.ans_row3_col1.Visible = True
            FormAnswer.ans_row3_col2.Visible = True

            FormAnswer.ShowDialog()

            '''''''''''''''''' 3by3 ''''''''''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "3x3" And groupBComboBox.SelectedItem = "3x3" Then

            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)
            ans_row1_col3 = Val(a_row1_col3.Text) + Val(b_row1_col3.Text)
            'ans_row1_col4 = Val(A_row1_col4.Text) + Val(B_row1_col4.Text)

            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)
            ans_row2_col3 = Val(a_row2_col3.Text) + Val(b_row2_col3.Text)
            'ans_row2_col4 = Val(A_row2_col4.Text) + Val(B_row2_col4.Text)

            'row 3
            ans_row3_col1 = Val(a_row3_col1.Text) + Val(b_row3_col1.Text)
            ans_row3_col2 = Val(a_row3_col2.Text) + Val(b_row3_col2.Text)
            ans_row3_col3 = Val(a_row3_col3.Text) + Val(b_row3_col3.Text)

            'answer
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            FormAnswer.ans_row1_col3.Text = ans_row1_col3
            'FormAnswer.ans_row1_col4.Text = ans_row1_col4
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True
            FormAnswer.ans_row1_col3.Visible = True
            'FormAnswer.ans_row1_col4.Visible = True

            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            FormAnswer.ans_row2_col3.Text = ans_row2_col3
            'FormAnswer.ans_row2_col4.Text = ans_row2_col4
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True
            FormAnswer.ans_row2_col3.Visible = True
            'FormAnswer.ans_row2_col4.Visible = True

            FormAnswer.ans_row3_col1.Text = ans_row3_col1
            FormAnswer.ans_row3_col2.Text = ans_row3_col2
            FormAnswer.ans_row3_col3.Text = ans_row3_col3
            FormAnswer.ans_row3_col1.Visible = True
            FormAnswer.ans_row3_col2.Visible = True
            FormAnswer.ans_row3_col3.Visible = True

            FormAnswer.ShowDialog()

            '''''''''''''''''' 3by4 ''''''''''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "3x4" And groupBComboBox.SelectedItem = "3x4" Then

            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)
            ans_row1_col3 = Val(a_row1_col3.Text) + Val(b_row1_col3.Text)
            ans_row1_col4 = Val(a_row1_col4.Text) + Val(b_row1_col4.Text)

            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)
            ans_row2_col3 = Val(a_row2_col3.Text) + Val(b_row2_col3.Text)
            ans_row2_col4 = Val(a_row2_col4.Text) + Val(b_row2_col4.Text)

            'row 3
            ans_row3_col1 = Val(a_row3_col1.Text) + Val(b_row3_col1.Text)
            ans_row3_col2 = Val(a_row3_col2.Text) + Val(b_row3_col2.Text)
            ans_row3_col3 = Val(a_row3_col3.Text) + Val(b_row3_col3.Text)
            ans_row3_col4 = Val(a_row3_col4.Text) + Val(b_row3_col4.Text)


            'answer
            ' row 1
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            FormAnswer.ans_row1_col3.Text = ans_row1_col3
            FormAnswer.ans_row1_col4.Text = ans_row1_col4
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True
            FormAnswer.ans_row1_col3.Visible = True
            FormAnswer.ans_row1_col4.Visible = True

            'row 2
            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            FormAnswer.ans_row2_col3.Text = ans_row2_col3
            FormAnswer.ans_row2_col4.Text = ans_row2_col4
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True
            FormAnswer.ans_row2_col3.Visible = True
            FormAnswer.ans_row2_col4.Visible = True

            'row 3
            FormAnswer.ans_row3_col1.Text = ans_row3_col1
            FormAnswer.ans_row3_col2.Text = ans_row3_col2
            FormAnswer.ans_row3_col3.Text = ans_row3_col3
            FormAnswer.ans_row3_col4.Text = ans_row3_col4
            FormAnswer.ans_row3_col1.Visible = True
            FormAnswer.ans_row3_col2.Visible = True
            FormAnswer.ans_row3_col3.Visible = True
            FormAnswer.ans_row3_col4.Visible = True

            FormAnswer.ShowDialog()

            '''''''''''''''''' 4by2 ''''''''''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "4x2" And groupBComboBox.SelectedItem = "4x2" Then

            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)
            'ans_row1_col3 = Val(A_row1_col3.Text) + Val(B_row1_col3.Text)
            'ans_row1_col4 = Val(A_row1_col4.Text) + Val(B_row1_col4.Text)

            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)
            'ans_row2_col3 = Val(A_row2_col3.Text) + Val(B_row2_col3.Text)
            'ans_row2_col4 = Val(A_row2_col4.Text) + Val(B_row2_col4.Text)

            'row 3
            ans_row3_col1 = Val(a_row3_col1.Text) + Val(b_row3_col1.Text)
            ans_row3_col2 = Val(a_row3_col2.Text) + Val(b_row3_col2.Text)
            'ans_row3_col3 = Val(A_row3_col3.Text) + Val(B_row3_col3.Text)
            'ans_row3_col4 = Val(A_row3_col4.Text) + Val(B_row3_col4.Text)

            'row 4
            ans_row4_col1 = Val(a_row4_col1.Text) + Val(b_row4_col1.Text)
            ans_row4_col2 = Val(a_row4_col2.Text) + Val(b_row4_col2.Text)
            'ans_row4_col3 = Val(A_row4_col3.Text) + Val(B_row4_col3.Text)
            'ans_row4_col4 = Val(A_row4_col4.Text) + Val(B_row4_col4.Text)


            'answer
            ' row 1
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            FormAnswer.ans_row1_col3.Text = ans_row1_col3
            FormAnswer.ans_row1_col4.Text = ans_row1_col4
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True
            'FormAnswer.ans_row1_col3.Visible = True
            'FormAnswer.ans_row1_col4.Visible = True

            'row 2
            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            FormAnswer.ans_row2_col3.Text = ans_row2_col3
            FormAnswer.ans_row2_col4.Text = ans_row2_col4
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True
            'FormAnswer.ans_row2_col3.Visible = True
            'FormAnswer.ans_row2_col4.Visible = True

            'row 3
            FormAnswer.ans_row3_col1.Text = ans_row3_col1
            FormAnswer.ans_row3_col2.Text = ans_row3_col2
            FormAnswer.ans_row3_col3.Text = ans_row3_col3
            FormAnswer.ans_row3_col4.Text = ans_row3_col4
            FormAnswer.ans_row3_col1.Visible = True
            FormAnswer.ans_row3_col2.Visible = True
            'FormAnswer.ans_row3_col3.Visible = True
            'FormAnswer.ans_row3_col4.Visible = True

            'row 4
            FormAnswer.ans_row4_col1.Text = ans_row4_col1
            FormAnswer.ans_row4_col2.Text = ans_row4_col2
            'FormAnswer.ans_row4_col3.Text = ans_row4_col3
            'FormAnswer.ans_row4_col4.Text = ans_row4_col4
            FormAnswer.ans_row4_col1.Visible = True
            FormAnswer.ans_row4_col2.Visible = True
            'FormAnswer.ans_row4_col3.Visible = True
            'FormAnswer.ans_row4_col4.Visible = True

            FormAnswer.ShowDialog()

            '''''''''''''''''' 4by3 ''''''''''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "4x3" And groupBComboBox.SelectedItem = "4x3" Then

            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)
            ans_row1_col3 = Val(a_row1_col3.Text) + Val(b_row1_col3.Text)
            'ans_row1_col4 = Val(A_row1_col4.Text) + Val(B_row1_col4.Text)

            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)
            ans_row2_col3 = Val(a_row2_col3.Text) + Val(b_row2_col3.Text)
            'ans_row2_col4 = Val(A_row2_col4.Text) + Val(B_row2_col4.Text)

            'row 3
            ans_row3_col1 = Val(a_row3_col1.Text) + Val(b_row3_col1.Text)
            ans_row3_col2 = Val(a_row3_col2.Text) + Val(b_row3_col2.Text)
            ans_row3_col3 = Val(a_row3_col3.Text) + Val(b_row3_col3.Text)
            ' ans_row3_col4 = Val(A_row3_col4.Text) + Val(B_row3_col4.Text)

            'row 4
            ans_row4_col1 = Val(a_row4_col1.Text) + Val(b_row4_col1.Text)
            ans_row4_col2 = Val(a_row4_col2.Text) + Val(b_row4_col2.Text)
            ans_row4_col3 = Val(a_row4_col3.Text) + Val(b_row4_col3.Text)
            'ans_row4_col4 = Val(A_row4_col4.Text) + Val(B_row4_col4.Text)


            'answer
            ' row 1
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            FormAnswer.ans_row1_col3.Text = ans_row1_col3
            'FormAnswer.ans_row1_col4.Text = ans_row1_col4
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True
            FormAnswer.ans_row1_col3.Visible = True
            'FormAnswer.ans_row1_col4.Visible = True

            'row 2
            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            FormAnswer.ans_row2_col3.Text = ans_row2_col3
            'FormAnswer.ans_row2_col4.Text = ans_row2_col4
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True
            FormAnswer.ans_row2_col3.Visible = True
            'FormAnswer.ans_row2_col4.Visible = True

            'row 3
            FormAnswer.ans_row3_col1.Text = ans_row3_col1
            FormAnswer.ans_row3_col2.Text = ans_row3_col2
            FormAnswer.ans_row3_col3.Text = ans_row3_col3
            'FormAnswer.ans_row3_col4.Text = ans_row3_col4
            FormAnswer.ans_row3_col1.Visible = True
            FormAnswer.ans_row3_col2.Visible = True
            FormAnswer.ans_row3_col3.Visible = True
            'FormAnswer.ans_row3_col4.Visible = True

            'row 4
            FormAnswer.ans_row4_col1.Text = ans_row4_col1
            FormAnswer.ans_row4_col2.Text = ans_row4_col2
            FormAnswer.ans_row4_col3.Text = ans_row4_col3
            'FormAnswer.ans_row4_col4.Text = ans_row4_col4
            FormAnswer.ans_row4_col1.Visible = True
            FormAnswer.ans_row4_col2.Visible = True
            FormAnswer.ans_row4_col3.Visible = True
            'FormAnswer.ans_row4_col4.Visible = True

            FormAnswer.ShowDialog()

            '''''''''''''''''' 4by4 ''''''''''''''''''''''''
        ElseIf groupAComboBox.SelectedItem = "4x4" And groupBComboBox.SelectedItem = "4x4" Then

            'row 1
            ans_row1_col1 = Val(a_row1_col1.Text) + Val(b_row1_col1.Text)
            ans_row1_col2 = Val(a_row1_col2.Text) + Val(b_row1_col2.Text)
            ans_row1_col3 = Val(a_row1_col3.Text) + Val(b_row1_col3.Text)
            ans_row1_col4 = Val(a_row1_col4.Text) + Val(b_row1_col4.Text)

            'row 2
            ans_row2_col1 = Val(a_row2_col1.Text) + Val(b_row2_col1.Text)
            ans_row2_col2 = Val(a_row2_col2.Text) + Val(b_row2_col2.Text)
            ans_row2_col3 = Val(a_row2_col3.Text) + Val(b_row2_col3.Text)
            ans_row2_col4 = Val(a_row2_col4.Text) + Val(b_row2_col4.Text)

            'row 3
            ans_row3_col1 = Val(a_row3_col1.Text) + Val(b_row3_col1.Text)
            ans_row3_col2 = Val(a_row3_col2.Text) + Val(b_row3_col2.Text)
            ans_row3_col3 = Val(a_row3_col3.Text) + Val(b_row3_col3.Text)
            ans_row3_col4 = Val(a_row3_col4.Text) + Val(b_row3_col4.Text)

            'row 4
            ans_row4_col1 = Val(a_row4_col1.Text) + Val(b_row4_col1.Text)
            ans_row4_col2 = Val(a_row4_col2.Text) + Val(b_row4_col2.Text)
            ans_row4_col3 = Val(a_row4_col3.Text) + Val(b_row4_col3.Text)
            ans_row4_col4 = Val(a_row4_col4.Text) + Val(b_row4_col4.Text)


            'answer
            ' row 1
            FormAnswer.ans_row1_col1.Text = ans_row1_col1
            FormAnswer.ans_row1_col2.Text = ans_row1_col2
            FormAnswer.ans_row1_col3.Text = ans_row1_col3
            FormAnswer.ans_row1_col4.Text = ans_row1_col4
            FormAnswer.ans_row1_col1.Visible = True
            FormAnswer.ans_row1_col2.Visible = True
            FormAnswer.ans_row1_col3.Visible = True
            FormAnswer.ans_row1_col4.Visible = True

            'row 2
            FormAnswer.ans_row2_col1.Text = ans_row2_col1
            FormAnswer.ans_row2_col2.Text = ans_row2_col2
            FormAnswer.ans_row2_col3.Text = ans_row2_col3
            FormAnswer.ans_row2_col4.Text = ans_row2_col4
            FormAnswer.ans_row2_col1.Visible = True
            FormAnswer.ans_row2_col2.Visible = True
            FormAnswer.ans_row2_col3.Visible = True
            FormAnswer.ans_row2_col4.Visible = True

            'row 3
            FormAnswer.ans_row3_col1.Text = ans_row3_col1
            FormAnswer.ans_row3_col2.Text = ans_row3_col2
            FormAnswer.ans_row3_col3.Text = ans_row3_col3
            FormAnswer.ans_row3_col4.Text = ans_row3_col4
            FormAnswer.ans_row3_col1.Visible = True
            FormAnswer.ans_row3_col2.Visible = True
            FormAnswer.ans_row3_col3.Visible = True
            FormAnswer.ans_row3_col4.Visible = True

            'row 4
            FormAnswer.ans_row4_col1.Text = ans_row4_col1
            FormAnswer.ans_row4_col2.Text = ans_row4_col2
            FormAnswer.ans_row4_col3.Text = ans_row4_col3
            FormAnswer.ans_row4_col4.Text = ans_row4_col4
            FormAnswer.ans_row4_col1.Visible = True
            FormAnswer.ans_row4_col2.Visible = True
            FormAnswer.ans_row4_col3.Visible = True
            FormAnswer.ans_row4_col4.Visible = True

            FormAnswer.ShowDialog()

        ElseIf groupAComboBox.SelectedItem = Nothing And groupBComboBox.SelectedItem = Nothing Then
            MessageBox.Show("Please Select Row's and Column's", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'if dimension are not exact prompt a "Invalid"
            'if dimension are not exact prompt a "Invalid"
        Else
            MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub clearText(_select)
        If _select = "group_a" Then
            '''''''''''' group A '''''''''''''''
            a_row1_col1.Clear()
            a_row1_col2.Clear()
            a_row1_col3.Clear()
            a_row1_col4.Clear()

            a_row2_col1.Clear()
            a_row2_col2.Clear()
            a_row2_col3.Clear()
            a_row2_col4.Clear()

            a_row3_col1.Clear()
            a_row3_col2.Clear()
            a_row3_col3.Clear()
            a_row3_col4.Clear()

            a_row4_col1.Clear()
            a_row4_col2.Clear()
            a_row4_col3.Clear()
            a_row4_col4.Clear()
        ElseIf _select = "group_b" Then
            '''''''''''''''' group B ''''''''''''''''''
            b_row1_col1.Clear()
            b_row1_col2.Clear()
            b_row1_col3.Clear()
            b_row1_col4.Clear()

            b_row2_col1.Clear()
            b_row2_col2.Clear()
            b_row2_col3.Clear()
            b_row2_col4.Clear()

            b_row3_col1.Clear()
            b_row3_col2.Clear()
            b_row3_col3.Clear()
            b_row3_col4.Clear()

            b_row4_col1.Clear()
            b_row4_col2.Clear()
            b_row4_col3.Clear()
            b_row4_col4.Clear()
        End If
    End Sub
   
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearText("group_a")
        clearText("group_b")
    End Sub

   
End Class