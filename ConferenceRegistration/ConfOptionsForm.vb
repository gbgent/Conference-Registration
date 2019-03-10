Public Class ConfOptionsForm
    Private Sub cb_Conference_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Conference.CheckedChanged

        'Check to see if Check box is checked
        If (cb_Conference.Checked = True) Then
            ChangeEnables(True)
        Else
            ChangeEnables(False)
        End If
    End Sub

    Private Sub ChangeEnables(ByVal state As Boolean)

        ' Change the enabled state for items dependent 
        ' on checking Conference Registration
        cb_Dinner.Enabled = state
        lbx_WorkShops.Enabled = state
        btn_Reset.Enabled = state
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click

        ' Calculate total Regristration fees
        intTotalRegistrationFee = CalcRegistrationCost(cb_Conference.Checked,
                                                        cb_Dinner.Checked,
                                                        lbx_WorkShops.SelectedIndex + 1)

        ' Close the current window
        Me.Close()

    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click

        ' Reset as if form was just opened

        ' Set List Box to nothing selected
        lbx_WorkShops.SelectedIndex = -1

        ' Uncheck the check boxes
        cb_Dinner.Checked = False
        cb_Conference.Checked = False  ' This will fire cb_Conference_CheckedChanged Subroutine

        cb_Conference.Focus()

    End Sub
End Class