Imports System.IO

Namespace Model

    Public Class Logging

        Shared Property ErrorsStr As String

        Shared Sub WriteToFile(txt As String)
            ErrorsStr = ErrorsStr & txt & vbCrLf
            Dim y = Now.ToString("yyyy")
            Dim m = Now.ToString("MM")
            Dim d = Now.ToString("dd")
            Dim h = Now.ToString("HH")
            Dim mi = Now.ToString("mm")

            Dim fileName = $"{h}-{mi}_{File.VeryShortFileName}.txt"

            Dim dirPath = Path.Combine(My.Settings.FolderLog, y, m, d)
            File.LogFilePath = Path.Combine(dirPath, fileName)

            If (Not Directory.Exists(dirPath)) Then
                Directory.CreateDirectory(dirPath)
            End If

            Dim sw As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(File.LogFilePath, True)
            With sw
                .WriteLine(txt)
                .Close()
            End With
        End Sub

        Shared Function TimeStamp() As String
            Return Now.ToString("dd.MM.yyyy HH.mm.ss")
        End Function

    End Class

End Namespace