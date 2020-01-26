Imports System.IO

Public Class Form1
    Dim rowcount As Long = 0
    Dim auditsSuccess As Long = 0
    Dim auditsFailed As Long = 0
    Dim auditsFailedCritical As Long = 0

    Dim dl_success As Long = 0
    Dim dl_failed As Long = 0

    Dim put_success As Long = 0
    Dim put_failed As Long = 0
    Dim put_rejected As Long = 0

    Dim get_repair_success As Long = 0
    Dim get_repair_failed As Long = 0

    Dim put_repair_success As Long = 0
    Dim put_repair_failed As Long = 0


    Dim DiskIOError As Long = 0
    Dim DBmalforemed As Long = 0

    Dim Reading = True
    Dim ReadEnd As Boolean = False

    Dim SleepTime As Integer = 0
    Private Sub MeExit() Handles Me.Closing
        ReadEnd = True
        Reading = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rowcount = 0

        Dim a As Threading.Thread = New Threading.Thread(AddressOf ReadLogs)
        a.Start(OpenFile())
        Dim b As Threading.Thread = New Threading.Thread(AddressOf UpdateRowcount)
        b.Start()
    End Sub
    Private Sub UpdateRowcount()
        Threading.Thread.Sleep(1000)
        PrintRowcount()
        If ReadEnd = False Then

            Dim b As Threading.Thread = New Threading.Thread(AddressOf UpdateRowcount)
            b.Start()
        End If
    End Sub
    Private Sub PrintRowcount()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PrintRowcount))
        Else
            TextBox1.Text = rowcount

        End If
    End Sub
    Private Sub PrintResults()
        Try


            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf PrintResults))
            Else
                RG.Rows.Add({"Audits", auditsSuccess, auditsFailed, auditsFailedCritical, auditsSuccess + auditsFailed + auditsFailedCritical, (auditsSuccess / (auditsSuccess + auditsFailed + auditsFailedCritical)) * 100})
                RG.Rows.Add({"Egress", dl_success, dl_failed, "", dl_success + dl_failed, (dl_success / (dl_success + dl_failed)) * 100})
                RG.Rows.Add({"Ingress", put_success, put_failed, put_rejected, put_success + put_failed + put_rejected, put_success / (put_success + put_failed + put_rejected) * 100})
                RG.Rows.Add({"Repair Egress", get_repair_success, get_repair_failed, "", get_repair_success + get_repair_failed, get_repair_success / (get_repair_success + get_repair_failed) * 100})
                RG.Rows.Add({"Repair Ingress", put_repair_success, put_repair_failed, "", put_repair_success + put_repair_failed, put_repair_success / (put_repair_success + put_repair_failed) * 100})
                RG.Rows.Add({"Disk I/O Error", "", "", DiskIOError, DiskIOError, ""})
                RG.Rows.Add({"DB malformed", "", "", DBmalforemed, DBmalforemed, ""})
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ReadLogs(filename As String)
        Dim file As String = filename
        If file IsNot Nothing Then

            Try
                ''IO.File.Copy(file, "file.txt", True)
                Dim len As Long = 0

                Dim rowlen As Integer = 0

                Using fs As FileStream = New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)


                    Dim reader As New StreamReader(fs, True) ''System.Text.Encoding.UTF8)
                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine
                        Dim a As Threading.Thread = New Threading.Thread(AddressOf ProcessRow)
                        a.Start(line)
                        ''Threading.Thread.Sleep(2)
                    End While
                    reader.Close()
                    fs.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If
        ReadEnd = True
        PrintResults()
    End Sub
    Private Sub ProcessRow(line As String)
        If line IsNot Nothing Then
            rowcount = rowcount + 1
            If line.Contains("GET_AUDIT") And line.Contains("downloaded") Then
                auditsSuccess += 1
            ElseIf line.Contains("GET_AUDIT") And line.Contains("failed") And line.Contains("open -NotMatch") Then
                auditsFailed += 1
            ElseIf line.Contains("GET_AUDIT") And line.Contains("failed") And line.Contains("open") Then
                auditsFailedCritical += 1
            ElseIf line.Contains("GET_REPAIR") And line.Contains("downloaded") Then
                get_repair_success += 1
            ElseIf line.Contains("GET_REPAIR") And line.Contains("failed") Then
                get_repair_failed += 1
            ElseIf line.Contains("PUT_REPAIR") And line.Contains("uploaded") Then
                put_repair_success += 1
            ElseIf line.Contains("PUT_REPAIR") And line.Contains("failed") Then
                put_repair_failed += 1
            ElseIf line.Contains("GET") And line.Contains("downloaded") Then
                dl_success += 1
            ElseIf line.Contains("GET") And line.Contains("failed") Then
                dl_failed += 1
            ElseIf line.Contains("PUT") And line.Contains("uploaded") Then
                put_success += 1
            ElseIf line.Contains("PUT") And line.Contains("rejected") Then
                put_rejected += 1
            ElseIf line.Contains("PUT") And line.Contains("failed") Then
                put_failed += 1
            ElseIf line.contains("disk I/O error") Then
                DiskIOError += 1
            ElseIf line.contains("malformed") Then
                DBmalforemed += 1
            End If
        End If
    End Sub
    Private Function OpenFile() As String
        'build and configure an OpenFileDialog
        Dim OFD As New OpenFileDialog
        With OFD
            .AddExtension = True
            .CheckFileExists = True
            .Filter = "Log files(.log)|*.log"
            .Multiselect = False
            .Title = "Select an Storagenode log to open"
        End With

        'show the ofd and if a file was selected return it, otherwise return nothing
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return OFD.FileName
        Else
            Return Nothing
        End If
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            SleepTime = CInt(TextBox2.Text)
        Catch ex As Exception
            MsgBox("Only full numbers can be entered recomended between 0-10 ")
        End Try

    End Sub
End Class
