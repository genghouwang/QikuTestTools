﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.start = False
        frmSplash.ShowDialog()
    End Sub
    Private Sub Usehelp_Click(sender As Object, e As EventArgs) Handles Usehelp.Click
        MessageBox.Show("即将前往360社区对应的帖子中。", "QikuTestTools使用说明", MessageBoxButtons.OK, MessageBoxIcon.Information)
        System.Diagnostics.Process.Start("https://bbs.360.cn/thread-15798096-1-1.html")
    End Sub
    Private Sub Checkupdate_Click(sender As Object, e As EventArgs) Handles Checkupdate.Click
        If System.IO.File.Exists(frmSplash.s & "/tmp/update.txt") Then
            System.IO.File.Delete(frmSplash.s & "/tmp/update.txt")
        End If
        Dim u As Boolean
        u = True
        Try
            My.Computer.Network.DownloadFile("http://39.105.165.68/11.txt", frmSplash.s & "/tmp/update.txt")
        Catch
            u = False
        End Try
        Dim a, b, c As String
        a = ""
        b = ""
        c = ""
        If u Then
            Dim file = New System.IO.StreamReader(frmSplash.s & "/tmp/update.txt")
            a = file.ReadLine()
            b = file.ReadLine()
            If Not file.EndOfStream Then
                c = file.ReadLine()
            End If
            file.Close()
            If Mid(a, 1, 1) = "V" And Mid(a, 3, 1) = "." And Mid(a, 5, 1) = "." Then
                If a > "V" & Application.ProductVersion Then
                    MessageBox.Show("检测到应用有新版本" & Chr（34） & a & Chr(34) & ",当前版本为" & Chr(34) & "V" & Application.ProductVersion & Chr(34) & "。请前往链接处更新已获得更优质的使用体验。" & Chr(10) & Chr(10) & "最近一次的更新日志为：" & Chr(34) & b & Chr(34), "QikuTestTools发现新版本", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Diagnostics.Process.Start("https://yunpan.360.cn/surl_yutDxRfVpKc")
                ElseIf a < "V" & Application.ProductVersion Then
                    MessageBox.Show("请注意：当前应用版本为" & Chr(34) & "V" & Application.ProductVersion & "测试版" & Chr(34) & "，正式版最新为" & Chr(34) & a & Chr(34) & "。仅供内部测试使用，请勿外传！", "QikuTestTools测试版提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf a = "V" & Application.ProductVersion Then
                    MessageBox.Show("当前版本" & Chr(34) & a & Chr(34) & "已经是最新版本。" & Chr(10) & Chr(10) & "当前版本的更新日志为：" & Chr(34) & b & Chr(34), "QikuTestTools更新服务", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("当前没有最新版本信息，只有公告信息，如需要更新应用请前往360社区帖子处自行进入下载地址查看。", "QikuTestTools公告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MsgBox(a, b, c)
            End If
        Else
            MessageBox.Show("当前无法从服务器上获取更新或公告信息，可能是没有网络连接或者服务器出现异常。", "QikuTestTools无法连接到服务器", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        frmAbout.Show()
    End Sub
    Private Sub Duty_Click(sender As Object, e As EventArgs) Handles Duty.Click
        MessageBox.Show("QikuTestTools由360OS先锋队制作、出品，与360本身无关，我们希望可以改进一些在360OS上的用户体验，希望对您有所帮助。我们不制作和宣传任何破解软件或系统的任何一部分，我们只是将部分泄露出对改进360OS用户体验有帮助的功能集成进来。" & Chr(10) & Chr(10) & "请注意：QikuTestTools永久免费，在360社区帖子中回复后即可看到下载地址，也不会开发和接受任何个人或团体的捐赠。QikuTestTools不携带任何木马病毒，开发语句都用意明晰，使用过程中杀毒软件大都不会报毒，可能会有一些报有风险行为，其实都是adb命令。请认准在360社区帖子中进行下载和更新，以避免使用盗版软件对您的电脑可能造成的危害！", "QikuTestTools免责声明", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Private Sub Opensource_Click(sender As Object, e As EventArgs) Handles Opensource.Click
        MessageBox.Show("即将前往" & Chr(34) & "QikuTestTools" & Chr(34) & "开源地址。", "QikuTestTools开源", MessageBoxButtons.OK, MessageBoxIcon.Information)
        System.Diagnostics.Process.Start("https://github.com/KRLHY/QikuTestTools")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text.Substring(Button1.Text.Length - 4) = "（禁用）" Then
            MessageBox.Show("QikuTestTools在检测手机连接时发现OS或安卓版本不符合要求，一些功能将受限制无法使用。", "QikuTestTools限制了一些功能", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form2.Timer1.Enabled = True
            Form2.ShowDialog()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text.Substring(Button2.Text.Length - 4) = "（禁用）" Then
            MessageBox.Show("QikuTestTools在检测手机连接时发现OS或安卓版本不符合要求，一些功能将受限制无法使用。", "QikuTestTools限制了一些功能", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form2.Timer2.Enabled = True
            Form2.ShowDialog()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text.Substring(Button3.Text.Length - 4) = "（禁用）" Then
            MessageBox.Show("QikuTestTools在检测手机连接时发现OS或安卓版本不符合要求，一些功能将受限制无法使用。", "QikuTestTools限制了一些功能", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form2.Timer3.Enabled = True
            Form2.ShowDialog()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Timer4.Enabled = True
        Form2.ShowDialog()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Timer5.Enabled = True
        Form2.ShowDialog()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Timer6.Enabled = True
        Form2.ShowDialog()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Timer7.Enabled = True
        Form2.ShowDialog()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text.Substring(Button8.Text.Length - 4) = "（禁用）" Then
            MessageBox.Show("QikuTestTools在检测手机连接时发现OS或安卓版本不符合要求，一些功能将受限制无法使用。", "QikuTestTools限制了一些功能", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form2.Timer8.Enabled = True
            Form2.ShowDialog()
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form2.Timer9.Enabled = True
        Form2.ShowDialog()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button10.Text.Substring(Button10.Text.Length - 4) = "（禁用）" Then
            MessageBox.Show("QikuTestTools在检测手机连接时发现OS或安卓版本不符合要求，一些功能将受限制无法使用。", "QikuTestTools限制了一些功能", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form2.Timer10.Enabled = True
            Form2.ShowDialog()
        End If
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button10.Text.Substring(Button11.Text.Length - 4) = "（禁用）" Then
            MessageBox.Show("QikuTestTools在检测手机连接时发现OS或安卓版本不符合要求，一些功能将受限制无法使用。", "QikuTestTools限制了一些功能", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form2.Timer11.Enabled = True
            Form2.ShowDialog()
        End If
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form2.Timer12.Enabled = True
        Form2.ShowDialog()
    End Sub
End Class
