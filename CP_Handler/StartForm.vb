Imports System.ComponentModel
Imports CpHandler.Model
Imports SautinSoft

Public Class StartForm

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk
        File.FillModel(OpenFileDialog1.FileName)
        '    Me.Close()

        Dim u As New UseOffice()
        Dim ret As Integer = u.InitWord()

        If ret = 1 Then
            MessageBox.Show($"Ошибка загрузки MS Word")
            Return
        End If

        u.ConvertFile(File.InputFile, File.OutputFile, UseOffice.eDirection.DOCX_to_XML)
        u.CloseWord()

        If Not Xml.Process() Then
            MessageBox.Show($"Ошибка обработки файла")
            Return
        End If

        'Label1.Text = Logging.ErrorsStr
        'Panel1.Visible = True

    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ВыбратьФайлToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыбратьФайлToolStripMenuItem.Click
        File.CheckAndCreateFolders()

        With OpenFileDialog1
            .InitialDirectory() = My.Settings.FolderIn
            .CheckFileExists = True
            .CheckPathExists = True
            .ShowDialog()
        End With

    End Sub

    Private Sub ПапкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПапкиToolStripMenuItem.Click
        Настройки.FoldersDialog.Label2.Text = My.Settings.FolderIn
        Настройки.FoldersDialog.Label4.Text = My.Settings.FolderOut
        Настройки.FoldersDialog.Label6.Text = My.Settings.FolderArc
        Настройки.FoldersDialog.Label7.Text = My.Settings.FolderLog

        Настройки.FoldersDialog.ShowDialog()
    End Sub

    Private Sub ВходныеЗаголовкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВходныеЗаголовкиToolStripMenuItem.Click
        Настройки.HeadersSettings.TextBox1.Text = My.Settings.LastName
        Настройки.HeadersSettings.TextBox2.Text = My.Settings.FirstName
        Настройки.HeadersSettings.TextBox3.Text = My.Settings.SecondName
        Настройки.HeadersSettings.TextBox4.Text = My.Settings.BirthDate
        Настройки.HeadersSettings.TextBox5.Text = My.Settings.Snils
        Настройки.HeadersSettings.TextBox6.Text = My.Settings.PeriodStart
        Настройки.HeadersSettings.TextBox7.Text = My.Settings.PeriodEnds

        Настройки.HeadersSettings.ShowDialog()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub ПодключениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПодключениеToolStripMenuItem.Click
        Настройки.ConnectionDialog.TextBox1.Text = My.Settings.DbLocation
        Настройки.ConnectionDialog.TextBox2.Text = My.Settings.DbName
        Настройки.ConnectionDialog.Label3.Text = ""

        Настройки.ConnectionDialog.ShowDialog()
    End Sub

    Private Sub ЗапросToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗапросToolStripMenuItem.Click
        Тестирование.InputHeaders.Label1.Text = ""
        Тестирование.InputHeaders.ShowDialog()

    End Sub

End Class