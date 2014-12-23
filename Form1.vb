Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        axWebBrowser1.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        axWebBrowser1.GoForward()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        axWebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs)
        axWebBrowser1.ShowPropertiesDialog()
    End Sub

    Private Sub ToolStripButton4_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub
End Class

