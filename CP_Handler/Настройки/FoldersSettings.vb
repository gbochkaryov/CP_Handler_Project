Namespace Настройки

    Public Class FoldersDialog

        Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
            My.Settings.FolderIn = Label2.Text
            My.Settings.FolderOut = Label4.Text
            My.Settings.FolderArc = Label6.Text
            My.Settings.FolderLog = Label7.Text
            My.Settings.Save()
            Close()
        End Sub

        Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
            Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            FolderBrowserDialog1.SelectedPath = My.Settings.FolderIn
            FolderBrowserDialog1.ShowDialog()
            Label2.Text = FolderBrowserDialog1.SelectedPath
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            FolderBrowserDialog1.SelectedPath = My.Settings.FolderOut
            FolderBrowserDialog1.ShowDialog()
            Label4.Text = FolderBrowserDialog1.SelectedPath
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            FolderBrowserDialog1.SelectedPath = My.Settings.FolderArc
            FolderBrowserDialog1.ShowDialog()
            Label6.Text = FolderBrowserDialog1.SelectedPath
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            FolderBrowserDialog1.SelectedPath = My.Settings.FolderLog
            FolderBrowserDialog1.ShowDialog()
            Label7.Text = FolderBrowserDialog1.SelectedPath
        End Sub

    End Class

End Namespace