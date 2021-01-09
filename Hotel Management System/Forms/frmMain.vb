Public Class frmMain

    Private Sub UserAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountsToolStripMenuItem.Click
        frmUserAccount_View.Show()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'frmLogin.ShowDialog()
        Me.ToolStripStatuslblDate.Text = Date.Now
    End Sub

    Private Sub tmNow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmNow.Tick
        Me.ToolStripStatuslblDate.Text = Date.Now
    End Sub

    Private Sub RoomTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        'Dim frm As New frmRooms_View
        'frm.MdiParent = Me
        'frm.Show()
        frmRooms_View.ShowDialog()
    End Sub

    Private Sub RoomTypeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomTypeToolStripMenuItem.Click
        'Dim frm As New frmRoomType_View
        'frm.MdiParent = Me
        'frm.Show()
        frmRoomType_View.ShowDialog()
    End Sub

    Private Sub LogBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogBookToolStripMenuItem.Click
        frmLogBook.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        frmCustomer_View.ShowDialog()
    End Sub

    Private Sub RoomMonitoringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomMonitoringToolStripMenuItem.Click
        'Dim frm As New frmRoomMonitoring
        'frm.MdiParent = Me
        'frm.Show()
        frmRoomMonitoring.ShowDialog()
    End Sub

    Private Sub PaymentTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentTypeToolStripMenuItem.Click
        frmPaymentType_View.ShowDialog()
    End Sub

    Private Sub ChangeCheckingTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeCheckingTimeToolStripMenuItem.Click
        frmCheckTime.ShowDialog()
    End Sub

    Private Sub ShowReservationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowReservationsToolStripMenuItem.Click
        frmShowReservations.ShowDialog()
    End Sub

End Class
