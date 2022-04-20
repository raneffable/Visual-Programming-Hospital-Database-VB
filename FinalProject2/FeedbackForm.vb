Public Class FeedbackForm
    Private Sub checklistboxFeedback_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles checklistboxFeedback.ItemCheck
        Dim feedback As String = checklistboxFeedback.SelectedItem

        If e.NewValue = CheckState.Checked Then
            listboxFeedback.Items.Add(feedback)

        Else
            listboxFeedback.Items.Remove(feedback)


        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Thankyou for your Feedback!")


    End Sub
End Class