Namespace Model

    Public Class Person

        ''' <summary>
        ''' Фамилия
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property LastName As String

        ''' <summary>
        ''' Имя
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property FirstName As String

        ''' <summary>
        '''  Отчество
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property SecondName As String

        ''' <summary>
        ''' ДатаРождения
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property BirthDate As String

        Public Shared Property Snils As String

        Public Shared Property PeriodStart As String

        Public Shared Property PeriodEnds As String

        Public Shared Property HeadersList As List(Of String)

        Shared Sub MakeHeaderList()
            HeadersList = New List(Of String) From {
            My.Settings.LastName,
            My.Settings.FirstName,
            My.Settings.SecondName,
            My.Settings.BirthDate,
            My.Settings.Snils,
            My.Settings.PeriodStart,
            My.Settings.PeriodEnds
            }
        End Sub

        Shared Function CheckSnils() As Boolean
            Dim n = Snils
            n = Replace(n, "-", "")
            n = Replace(n, " ", "")

            Dim p1, p2, p3, p4, p5, p6, p7, p8, p9, total, counted, given As Integer

            p1 = Convert.ToInt32(Mid(n, 1, 1)) * 9
            p2 = Convert.ToInt32(Mid(n, 2, 1)) * 8
            p3 = Convert.ToInt32(Mid(n, 3, 1)) * 7
            p4 = Convert.ToInt32(Mid(n, 4, 1)) * 6
            p5 = Convert.ToInt32(Mid(n, 5, 1)) * 5
            p6 = Convert.ToInt32(Mid(n, 6, 1)) * 4
            p7 = Convert.ToInt32(Mid(n, 7, 1)) * 3
            p8 = Convert.ToInt32(Mid(n, 8, 1)) * 2
            p9 = Convert.ToInt32(Mid(n, 9, 1)) * 1

            given = Convert.ToInt32(Mid(n, 10, 2))

            total = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9

            If total = 100 OrElse total = 101 Then
                counted = 0
                Return counted = given
            End If
2:
            If total < 100 Then
                counted = total
                Return counted = given
            End If

            If total > 101 Then
                total = total - 101
                GoTo 2
            End If

            Return counted = given

        End Function

    End Class

End Namespace