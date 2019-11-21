Namespace Model

    Public Class Validation

        Shared Property HasErrors As Boolean

        Shared Sub CheckAll()
            CheckPresense()
            CheckValue()
            CheckCorrectness()
        End Sub

        ''' <summary>
        '''  проверить присутсвие параметра
        ''' </summary>
        Shared Sub CheckPresense()
            If Person.HeadersList Is Nothing Then Person.MakeHeaderList()

            Logging.WriteToFile("")
            Logging.WriteToFile($"{Logging.TimeStamp()} - {File.ShortFileName}")

            For Each row In Person.HeadersList
                If Not Xml.InputDataDic.Keys.Contains(row) Then
                    Logging.WriteToFile($"Отсутствует параметр: {row}")
                    HasErrors = True
                End If
            Next

        End Sub

        ''' <summary>
        ''' проверка наличие значения
        ''' </summary>
        Shared Sub CheckValue()

            Try
                Person.LastName = RTrim(Xml.InputDataDic(Person.HeadersList(0)))
            Catch
                Person.LastName = ""
                Logging.WriteToFile($"Отсутствует значение параметра: {Person.HeadersList(0)}")
                HasErrors = True
            End Try

            Try
                Person.FirstName = RTrim(Xml.InputDataDic(Person.HeadersList(1)))
            Catch
                Person.FirstName = ""
                Logging.WriteToFile($"Отсутствует значение параметра: {Person.HeadersList(1)}")
                HasErrors = True
            End Try

            Try
                Person.SecondName = RTrim(Xml.InputDataDic(Person.HeadersList(2)))
            Catch
                Person.SecondName = ""
                Logging.WriteToFile($"Отсутствует значение параметра: {Person.HeadersList(2)}")
                HasErrors = True
            End Try

            Try
                Person.BirthDate = RTrim(Xml.InputDataDic(Person.HeadersList(3)))
            Catch
                Person.BirthDate = ""
                Logging.WriteToFile($"Отсутствует значение параметра: {Person.HeadersList(3)}")
                HasErrors = True
            End Try

            Try
                Person.Snils = RTrim(Xml.InputDataDic(Person.HeadersList(4)))
            Catch
                Person.Snils = ""
                Logging.WriteToFile($"Отсутствует значение параметра: {Person.HeadersList(4)}")
                HasErrors = True
            End Try

            Try
                Person.PeriodStart = RTrim(Xml.InputDataDic(Person.HeadersList(5)))
            Catch
                Person.PeriodStart = ""
                Logging.WriteToFile($"Отсутствует значение параметра: {Person.HeadersList(5)}")
                HasErrors = True
            End Try

            Try
                Person.PeriodEnds = RTrim(Xml.InputDataDic(Person.HeadersList(6)))
            Catch
                Person.PeriodEnds = ""
                Logging.WriteToFile($"Отсутствует значение параметра: {Person.HeadersList(6)}")
                HasErrors = True
            End Try

        End Sub

        ''' <summary>
        '''  проверка правильности
        ''' </summary>
        Shared Sub CheckCorrectness()
            If Not String.IsNullOrWhiteSpace(Person.BirthDate) Then
                If Not Date.TryParse(Person.BirthDate, Nothing) Then
                    Logging.WriteToFile($"Ошибка в День рождения")
                    HasErrors = True
                End If
            End If

            If Not String.IsNullOrWhiteSpace(Person.PeriodStart) Then
                If Not Date.TryParse(Person.PeriodStart, Nothing) Then
                    Logging.WriteToFile($"Ошибка в начале периода")
                    HasErrors = True
                End If
            End If

            If Not String.IsNullOrWhiteSpace(Person.PeriodEnds) Then
                If Not Date.TryParse(Person.PeriodEnds, Nothing) Then
                    Logging.WriteToFile($"Ошибка в окончании периода")
                    HasErrors = True
                End If
            End If

            If Not String.IsNullOrWhiteSpace(Person.Snils) Then
                If Len(Person.Snils.Replace("-", "").Replace(" ", "")) <> 11 Then
                    Logging.WriteToFile($"Ошибка в длине СНИЛС")
                    HasErrors = True
                End If
                If Not Person.CheckSnils() Then
                    Logging.WriteToFile($"Ошибка при проверке СНИЛС")
                    HasErrors = True
                End If
            End If

        End Sub

    End Class

End Namespace