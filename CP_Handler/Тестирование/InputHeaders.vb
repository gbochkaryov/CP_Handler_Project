Imports CpHandler.Model

Namespace Тестирование

    Public Class InputHeaders

        Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            With OpenFileDialog1
                .InitialDirectory() = My.Settings.FolderIn
                .CheckFileExists = True
                .CheckPathExists = True
                .ShowDialog()
            End With

            File.FillModel(OpenFileDialog1.FileName)

            If Not Xml.MakeInputDataDic() Then
                MessageBox.Show($"Ошибка обработки файла")
                Return
            End If

            For Each row In Xml.InputDataDic
                Label1.Text = Label1.Text & row.Key & vbCrLf
            Next

        End Sub

    End Class

End Namespace