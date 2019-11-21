Imports System.IO

Namespace Model

    Public Class File
        Public Shared Property InputFile As String
        Public Shared Property ShortFileName As String
        Public Shared Property OutputFile As String
        Public Shared Property VeryShortFileName As String
        Public Shared Property LogFilePath As String

        Public Shared Sub FillModel(fileName As String)
            InputFile = fileName
            ShortFileName = Path.GetFileName(fileName)
            VeryShortFileName = Path.GetFileNameWithoutExtension(fileName)
            OutputFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString & ".xml")
        End Sub

        Public Shared Sub CheckAndCreateFolders()
            If (Not Directory.Exists(My.Settings.FolderIn)) Then Directory.CreateDirectory(My.Settings.FolderIn)
            If (Not Directory.Exists(My.Settings.FolderOut)) Then Directory.CreateDirectory(My.Settings.FolderOut)
            If (Not Directory.Exists(My.Settings.FolderArc)) Then Directory.CreateDirectory(My.Settings.FolderArc)
            If (Not Directory.Exists(My.Settings.FolderLog)) Then Directory.CreateDirectory(My.Settings.FolderLog)
        End Sub

    End Class

End Namespace