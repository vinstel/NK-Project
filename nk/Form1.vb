Public Class Form1
    Private Sub ButtonBrowseSource_Click(sender As Object, e As EventArgs) Handles ButtonBrowseSource.Click
        OpenFileDialogSource.Filter = " mp4 | *.mp4| mkv| *.mkv|All Files| *.*"
        If OpenFileDialogSource.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowseSource.Text = OpenFileDialogSource.FileName
        End If
    End Sub

    Private Sub ButtonBrowseFolder_Click(sender As Object, e As EventArgs) Handles ButtonBrowseFolder.Click
        If FolderBrowserDialogFolderOutput.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBoxFolderOutput.Text = FolderBrowserDialogFolderOutput.SelectedPath
            Dim root As Environment.SpecialFolder = FolderBrowserDialogFolderOutput.RootFolder
        End If
    End Sub

    Private Sub ButtonBrowseHandbrakeCLI_Click(sender As Object, e As EventArgs) Handles ButtonBrowseHandbrakeCLI.Click
        OpenFileDialogHanbrakeCLI.Filter = "HandbrakeCli.exe|*.exe"
        If OpenFileDialogHanbrakeCLI.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowseHandbrakeCLI.Text = OpenFileDialogHanbrakeCLI.FileName
        End If
    End Sub

    Private Sub ButtonBrowseKredit_Click(sender As Object, e As EventArgs) Handles ButtonBrowseKredit.Click
        OpenFileDialogKredit.Filter = "ASS|*.ass|SRT|*.srt"
        If OpenFileDialogKredit.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxKreditAss.Text = OpenFileDialogKredit.FileName
        End If
    End Sub

    Private Sub ButtonBrowse4KMP4json_Click(sender As Object, e As EventArgs) Handles ButtonBrowse4KMP4json.Click
        OpenFileDialog4KMP4PrestsJson.Filter = "Json|*.Json"
        If OpenFileDialog4KMP4PrestsJson.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowse4KMP4PresetsJson.Text = OpenFileDialog4KMP4PrestsJson.FileName
        End If
    End Sub

    Private Sub ButtonBrowse1080pMP4json_Click(sender As Object, e As EventArgs) Handles ButtonBrowse1080pMP4json.Click
        OpenFileDialog1080pMP4PresetsJson.Filter = "Json|*.Json"
        If OpenFileDialog1080pMP4PresetsJson.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowse1080pMP4PresetsJson.Text = OpenFileDialog1080pMP4PresetsJson.FileName
        End If
    End Sub

    Private Sub ButtonBrowse720pMP4json_Click(sender As Object, e As EventArgs) Handles ButtonBrowse720pMP4json.Click
        OpenFileDialog720pMP4PresetsJson.Filter = "Json|*.Json"
        If OpenFileDialog720pMP4PresetsJson.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowse720pMP4PresetsJson.Text = OpenFileDialog720pMP4PresetsJson.FileName
        End If
    End Sub

    Private Sub ButtonBrowse1080pMKVjson_Click(sender As Object, e As EventArgs) Handles ButtonBrowse1080pMKVjson.Click
        OpenFileDialog1080pMKVPrestsJson.Filter = "Json|*.Json"
        If OpenFileDialog1080pMKVPrestsJson.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowse1080pMKVPresetsJson.Text = OpenFileDialog1080pMKVPrestsJson.FileName
        End If
    End Sub

    Private Sub ButtonBrowse720pMKVjson_Click(sender As Object, e As EventArgs) Handles ButtonBrowse720pMKVjson.Click
        OpenFileDialog720pMKVPrestsJson.Filter = "Json|*.Json"
        If OpenFileDialog720pMKVPrestsJson.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowse720pMKVPresetsJson.Text = OpenFileDialog720pMKVPrestsJson.FileName
        End If
    End Sub

    Private Sub ButtonBrowse576pMKVjson_Click(sender As Object, e As EventArgs) Handles ButtonBrowse576pMKVjson.Click
        OpenFileDialog576pMKVPrestsJson.Filter = "Json|*.Json"
        If OpenFileDialog576pMKVPrestsJson.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowse576pMKVPresetsJson.Text = OpenFileDialog576pMKVPrestsJson.FileName
        End If
    End Sub

    Private Sub ButtonBrowse480pMKVjson_Click(sender As Object, e As EventArgs) Handles ButtonBrowse480pMKVjson.Click
        OpenFileDialog480pMKVPrestsJson.Filter = "Json|*.Json"
        If OpenFileDialog480pMKVPrestsJson.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxBrowse480pMKVPrestsJson.Text = OpenFileDialog480pMKVPrestsJson.FileName
        End If
    End Sub
End Class
