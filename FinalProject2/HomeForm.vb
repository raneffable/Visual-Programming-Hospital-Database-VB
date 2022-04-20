Public Class HomeForm



    Private Sub menuQuit_Click(sender As Object, e As EventArgs) Handles menuQuit.Click
        Me.Close()

    End Sub

    Private Sub menuDoctor_Click(sender As Object, e As EventArgs) Handles menuDoctor.Click
        DoctorForm.MdiParent = Me
        DoctorForm.Show()
        PatientForm.Close()
        ItemTreeViewForm.Close()
        InfoItem.Close()
        PaymentForm.Close()
        FullItemListForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()


    End Sub

    Private Sub MenuPatient_Click(sender As Object, e As EventArgs) Handles menuPatient.Click
        PatientForm.MdiParent = Me
        PatientForm.Show()
        DoctorForm.Close()
        ItemTreeViewForm.Close()
        InfoItem.Close()
        PaymentForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()
        FullItemListForm.Close()

    End Sub

    Private Sub menuItem_Click(sender As Object, e As EventArgs) Handles menuItem.Click
        FullItemListForm.MdiParent = Me
        FullItemListForm.Show()
        DoctorForm.Close()
        PatientForm.Close()
        InfoItem.Close()
        PaymentForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()
        ItemTreeViewForm.Close()
    End Sub

    Private Sub menuInfoItem_Click(sender As Object, e As EventArgs) Handles menuInfoItem.Click
        InfoItem.MdiParent = Me
        InfoItem.Show()
        DoctorForm.Close()
        ItemTreeViewForm.Close()
        PatientForm.Close()
        PaymentForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()
        FullItemListForm.Close()
    End Sub

    Private Sub tsbtnDoctor_Click(sender As Object, e As EventArgs) Handles tsbtnDoctor.Click
        DoctorForm.MdiParent = Me
        DoctorForm.Show()
        PatientForm.Close()
        ItemTreeViewForm.Close()
        InfoItem.Close()
        PaymentForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()
        FullItemListForm.Close()
    End Sub

    Private Sub tsbtnPatient_Click(sender As Object, e As EventArgs) Handles tsbtnPatient.Click
        PatientForm.MdiParent = Me
        PatientForm.Show()
        DoctorForm.Close()
        ItemTreeViewForm.Close()
        InfoItem.Close()
        PaymentForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()
        FullItemListForm.Close()
    End Sub

    Private Sub tsbtnItem_Click(sender As Object, e As EventArgs) Handles tsbtnItem.Click
        FullItemListForm.MdiParent = Me
        FullItemListForm.Show()
        DoctorForm.Close()
        PatientForm.Close()
        InfoItem.Close()
        PaymentForm.Close()
        ItemTreeViewForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()

    End Sub

    Private Sub tsbtnPayment_Click(sender As Object, e As EventArgs) Handles tsbtnPayment.Click
        PaymentForm.MdiParent = Me
        PaymentForm.Show()
        DoctorForm.Close()
        PatientForm.Close()
        InfoItem.Close()
        ItemTreeViewForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()
        FullItemListForm.Close()
    End Sub

    Private Sub menuPayment_Click(sender As Object, e As EventArgs)
        PaymentForm.MdiParent = Me
        PaymentForm.Show()
        DoctorForm.Close()
        PatientForm.Close()
        InfoItem.Close()
        ItemTreeViewForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()
        FullItemListForm.Close()
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblcubo.Visible = False
    End Sub

    Private Sub FullItemListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuItemTree.Click
        ItemTreeViewForm.MdiParent = Me
        ItemTreeViewForm.Show()
        DoctorForm.Close()
        PatientForm.Close()
        InfoItem.Close()
        FullItemListForm.Close()
        PaymentForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()

    End Sub

    Private Sub HistoryStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuHistory.Click
        HistoryForm.MdiParent = Me
        HistoryForm.Show()
        DoctorForm.Close()
        PatientForm.Close()
        InfoItem.Close()
        ItemTreeViewForm.Close()
        PaymentForm.Close()
        FeedbackForm.Close()
        FullItemListForm.Close()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuPayment.Click
        PaymentForm.MdiParent = Me
        PaymentForm.Show()
        DoctorForm.Close()
        PatientForm.Close()
        InfoItem.Close()
        ItemTreeViewForm.Close()
        FeedbackForm.Close()
        HistoryForm.Close()
        FullItemListForm.Close()
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuFeedback.Click
        FeedbackForm.MdiParent = Me
        FeedbackForm.Show()
        DoctorForm.Close()
        PatientForm.Close()
        InfoItem.Close()
        ItemTreeViewForm.Close()
        PaymentForm.Close()
        HistoryForm.Close()
        FullItemListForm.Close()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class