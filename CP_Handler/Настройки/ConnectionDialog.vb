Namespace Настройки

    Public Class ConnectionDialog

        Private Sub OK_Button_Click(sender As System.Object, e As EventArgs) Handles OK_Button.Click
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            My.Settings.DbLocation = TextBox1.Text
            My.Settings.DbName = TextBox2.Text
            My.Settings.Save()

            If Model.DbConnection.CheckConnection() Then
                Label3.Text = $"Успех"
                Label3.ForeColor = Color.Green
            Else
                Label3.Text = $"Ошибка подключения к базе"
                Label3.ForeColor = Color.Red
            End If
        End Sub

    End Class

End Namespace