Namespace Настройки

    Public Class HeadersSettings

        Private Sub Cancel_Button_Click(sender As System.Object, e As EventArgs) Handles Cancel_Button.Click
            '  Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Close()
        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
            My.Settings.LastName = TextBox1.Text
            My.Settings.FirstName = TextBox2.Text
            My.Settings.SecondName = TextBox3.Text
            My.Settings.BirthDate = TextBox4.Text
            My.Settings.Snils = TextBox5.Text
            My.Settings.PeriodStart = TextBox6.Text
            My.Settings.PeriodEnds = TextBox7.Text

            Try
                My.Settings.Save()
                MessageBox.Show($"Параметры сохранены")
                Catch
                    MessageBox.Show($"Ошибка сохранения параметров")
                Return
            End Try
            
            Model.Person.MakeHeaderList()
            
 
        End Sub

    End Class

End Namespace