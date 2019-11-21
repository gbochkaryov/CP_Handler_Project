Namespace Model

    Public Class Xml

        Public Shared Property InputDataDic As New Dictionary(Of String, String)

        Public Shared Function MakeInputDataDic() As Boolean
            Dim w As XNamespace = "http://schemas.microsoft.com/office/word/2003/wordml"
            Dim doc As New XDocument
            Dim tbl As XElement

            Try
                doc = XDocument.Load(File.OutputFile)
            Catch
                Return False
            End Try

            Try
                tbl = doc.Descendants(w + "tbl").FirstOrDefault()
            Catch
                Return False
            End Try

            InputDataDic.Clear()
            For Each row In tbl.Descendants(w + "tr")
                Dim col1 As XElement = row.Descendants(w + "t").FirstOrDefault()
                Dim col2 As XElement = row.Descendants(w + "t").LastOrDefault()
                Try
                    InputDataDic.Add(col1.Value, col2.Value)
                Catch
                    Return False
                End Try
            Next
            Return True
        End Function

        Public Shared Function Process() As Boolean
            If Not MakeInputDataDic() Then
                Return False
            End If

            Validation.HasErrors = False
            Validation.CheckAll()

            If Validation.HasErrors Then
                CorrectData.Label10.Text = File.ShortFileName
                CorrectData.Label12.Text = File.LogFilePath

                CorrectData.TextBox1.Text = Person.LastName
                CorrectData.TextBox2.Text = Person.FirstName
                CorrectData.TextBox3.Text = Person.SecondName
                CorrectData.TextBox4.Text = Person.BirthDate
                CorrectData.MaskedTextBox1.Text = Person.Snils
                CorrectData.TextBox5.Text = Person.PeriodStart
                CorrectData.TextBox6.Text = Person.PeriodEnds

                CorrectData.ShowDialog()
            End If

            Return True
        End Function

    End Class

End Namespace