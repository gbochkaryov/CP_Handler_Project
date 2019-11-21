Imports System.Data.OleDb

Namespace Model

    Public Class DbConnection
        Shared _conn = New OleDbConnection

        ''' <summary>
        '''  Формирование строки подключения
        ''' </summary>
        Shared Sub CreateConn()
            _conn = New OleDbConnection($"Provider=IBMDADB2.DB2COPY1;Data Source={My.Settings.DbName};Password=db2admin;User ID=db2admin;Location={My.Settings.DbLocation}")
        End Sub

        ''' <summary>
        '''  Проверка подключения к БД
        ''' </summary>
        ''' <returns></returns>
        Shared Function CheckConnection() As Boolean
            CreateConn()
            Dim res = ExecScript("
            SELECT     1  AS VAL
            FROM         PF.MAN
            FETCH FIRST 1 ROWS ONLY
            ")

            If res = "1" Then Return True
            Return False
        End Function

        Shared Function ExecScript(sql As String) As String
            Dim cmd = New OleDbCommand(sql, _conn)

            Try
                _conn.Open()
            Catch
                Return "Ошибка подключения к базе"
            End Try

            Dim data = cmd.ExecuteScalar()
            Dim result = ""
            If Not data Is Nothing Then
                Try
                    result = data
                Catch
                End Try
            End If

            _conn.Close()

            Return result

        End Function

    End Class

End Namespace