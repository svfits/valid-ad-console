Imports System
Imports System.Text
Imports System.DirectoryServices
Imports System.Configuration
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Management

Module Module1

    Sub Main()

        Dim r As New Random

        Dim random_timer As Integer = r.Next(300, 420)

        Dim username As String = Environment.UserName

        If username = "afanasievdv" Or username = "svfits" Then
            Exit Sub
        Else
            For index As Integer = 1 To random_timer Step 1
                Thread.Sleep(1000)
                Console.WriteLine("not valide" & "   " & index)

            Next
            ' Console.WriteLine("not valide")
            System.Diagnostics.Process.Start("shutdown", "-l")   'Завершение сеанса пользователя
        End If

    End Sub


    Public Enum eParam
        EWX_LOGOFF = 0 'Завершить сеанс пользователя. Отключает от сети. Аналог - войти в систему под другим именем. (Завершение сеанса [name])
        EWX_FORCE = 4    'Закрывает все программы без приглашения сохранить файлы
        EWX_FORCEIFHUNG = 10  'Заставляет приложения завершиться, если они не реагируют на сообщения WM_QUERYENDSESSION или WM_ENDSESSION
        EWX_POWEROFF = 8  'Завершает работу системы и, если есть возможность, выключает питание компьютера. вызывающий процесс должен иметь привилегию SE_SHUTDOWN_NAME
        EWX_REBOOT = 2    'Перезагружает компьютер. Вызывающий процесс должен иметь привилегию SE_SHUTDOWN_NAME
        EWX_SHUTDOWN = 1  'Завершает работу и выключает питание, записывает все файловые буферы на диск, останавливает все работающие системные процессы. Вызывающий процесс должен иметь привилегию SE_SHUTDOWN_NAME. Выводит сообщение, что можно выключить компьютер
    End Enum
End Module
