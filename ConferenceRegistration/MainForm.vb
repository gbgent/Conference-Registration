Public Class MainForm
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click

        ' Close this form
        Me.Close()
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click

        ' Clear this Form of all data
        For Each c In gb_Registation.Controls

            'Check to see if control is a text box
            If TypeOf c Is TextBox Then

                'Clear the text 
                DirectCast(c, TextBox).Text = String.Empty

            End If
        Next

        'Clear Total TextBox
        tb_Total.Text = String.Empty

        ' Reset All Labels to Default ForeColor
        SetLabelTextToDefaultColor()

    End Sub

    Private Sub btn_SelectConference_Click(sender As Object, e As EventArgs) Handles btn_SelectConference.Click

        ' Create an Instance of the Conference Option Form
        Dim frmConfOptions As New ConfOptionsForm

        If Not CheckTextBoxes() Then

            ' Display Conference Option Form in modal 
            frmConfOptions.ShowDialog()

            ' Dispose of Conferene Form
            frmConfOptions.Dispose()

            ' Show Confernce Total on Main Form
            tb_Total.Text = intTotalRegistrationFee.ToString("c")

        End If


    End Sub

    ' Check for Empty TextBoxes and throw an Error Message 
    ' Returns false if no empty Text Boxes Found or True if empty TExt Boxes Found
    Private Function CheckTextBoxes() As Boolean

        ' Flag if an Empty Text Box is found
        Dim emptyTextBoxFound As Boolean = False

        ' Variable for label Name
        Dim labelName As String

        ' Reset all Labels to Default ForeColor
        SetLabelTextToDefaultColor()

        ' Check All Controls on 
        For Each c In gb_Registation.Controls

            ' Check to see if control is a Text Box
            If TypeOf c Is TextBox Then

                ' Check to see if Text Box is Null or WhiteSpaces
                If String.IsNullOrWhiteSpace(DirectCast(c, TextBox).Text) Then

                    ' Set Flag to True
                    emptyTextBoxFound = True

                    ' Retrieve the unique substring of Textbox Name ie tb_Unique 
                    ' retrieves the Unique and appends it to labelName
                    labelName = "lbl_" + DirectCast(c, TextBox).Name.Substring(3)

                    ' Find the Label for Empty Text Box
                    For Each l In gb_Registation.Controls

                        ' Check to see if control is a Label
                        If TypeOf l Is Label Then

                            ' Check to see if Label is for Text Box
                            If DirectCast(l, Label).Name = labelName Then

                                ' Change Text Color to Red
                                DirectCast(l, Label).ForeColor = Color.Red

                                ' Leave Label For Loop
                                Exit For

                            End If
                        End If
                    Next

                End If

            End If

        Next

        'Check to see if Flag is true
        If emptyTextBoxFound Then

            ' Display an Error Message
            MessageBox.Show("All Fields must be filled", "Entry Error")

            'Set Focus to First Field
            tb_Name.Focus()
        End If

        Return emptyTextBoxFound
    End Function

    Private Sub SetLabelTextToDefaultColor()

        ' Find All Label in Form
        For Each l In gb_Registation.Controls

            If TypeOf l Is Label Then

                ' Set Text Color to Default
                DirectCast(l, Label).ForeColor = Label.DefaultForeColor

            End If
        Next
    End Sub
End Class
