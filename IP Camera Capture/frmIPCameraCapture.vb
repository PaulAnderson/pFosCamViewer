' pFosCamViewer
' Copyright (C) 2013 Paul Anderson
' 
'  This program is free software; you can redistribute it and/or
'  modify it under the terms of the GNU General Public License
'  as published by the Free Software Foundation; either version 2
'  of the License, or (at your option) any later version.
'  
'  This program is distributed in the hope that it will be useful,
'  but WITHOUT ANY WARRANTY; without even the implied warranty of
'  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'  GNU General Public License for more details.
'  
'  You should have received a copy of the GNU General Public License
'  along with this program; if not, write to the Free Software
'  Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

Public Class frmIPCameraCapture
    Private URL As String
    Private Sub StartButton_Click(sender As System.Object, e As System.EventArgs) Handles StartButton.Click
        SettingsGroupBox.Enabled = False
        StartButton.Enabled = False
        StopButton.Enabled = True
        URL = GetURLFromSettings()
        Timer2.Start()

        Dim cameraSettings As Dictionary(Of String, String) = GetCameraSettings()
        If cameraSettings.ContainsKey("id") Then txtFosCamID.Text = cameraSettings("id")
        If cameraSettings.ContainsKey("alias") Then txtAlias.Text = cameraSettings("alias")
        If cameraSettings.ContainsKey("sys_ver") Then txtSysVer.Text = cameraSettings("sys_ver")
        If cameraSettings.ContainsKey("app_ver") Then txtAppVer.Text = cameraSettings("app_ver")

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles IROnButton.Click
        SettingsGroupBox.Enabled = False
        StartButton.Enabled = False
        StopButton.Enabled = True
        URL = GetURLFromSettings()


        HistoryPictureBox7.LoadAsync(URL)
        HistoryPictureBox6.LoadAsync(URL)
        HistoryPictureBox5.LoadAsync(URL)
        HistoryPictureBox4.LoadAsync(URL)
        HistoryPictureBox3.LoadAsync(URL)
        HistoryPictureBox2.LoadAsync(URL)
        HistoryPictureBox1.LoadAsync(URL)
    End Sub

    Private Sub StopButton_Click(sender As System.Object, e As System.EventArgs) Handles StopButton.Click
        SettingsGroupBox.Enabled = True
        StartButton.Enabled = True
        StopButton.Enabled = False
        Timer2.Stop()

    End Sub

    Dim a As New Object
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Try
            System.Threading.Monitor.Enter(a)

            Dim singleRun As Boolean = True
            While singleRun OrElse FastAsPossibleCheckBox.Checked = True
                If FastAsPossibleCheckBox.Checked = True Then Timer2.Enabled = False
                singleRun = False
                'Dim oldImage As Image = MainPictureBox.Image

                MainPictureBox.Load(URL)

                'HistoryPictureBox7.Image = HistoryPictureBox6.Image
                'HistoryPictureBox6.Image = HistoryPictureBox5.Image
                'HistoryPictureBox5.Image = HistoryPictureBox4.Image
                'HistoryPictureBox4.Image = HistoryPictureBox3.Image
                'HistoryPictureBox3.Image = HistoryPictureBox2.Image
                'HistoryPictureBox2.Image = HistoryPictureBox1.Image
                'HistoryPictureBox1.Image = oldImage

                frameCount += 1
                FrameCountTextBox.Text = getFrameCount.ToString
                If FastAsPossibleCheckBox.Checked Then Application.DoEvents()
            End While
            If FastAsPossibleCheckBox.Checked = True Then Timer2.Enabled = True
        Catch ex As ArgumentException
        Finally
            System.Threading.Monitor.Exit(a)
        End Try
    End Sub
    Private frameCountprev As Integer
    Private frameCount As Integer
    Private Sub FrameResetTimer_Tick(sender As System.Object, e As System.EventArgs) Handles FrameResetTimer.Tick
        frameCountprev = frameCount
        frameCount = 0
    End Sub
    Private Function getFrameCount() As Integer
        If frameCount + frameCountprev = 0 Then Return 0 Else 
        Return ((frameCount + frameCountprev) / 2)
    End Function
    Private Function GetURLFromSettings() As String
        Return GetCgiURLFromSettings("snapshot")
    End Function
    Private Function GetCgiURLFromSettings(cgiFile As String) As String
        Select Case SelectedCameraType
            Case CameraType.FosCam
                Return "http://" + FosCamIPTextBox.Text + "/" + cgiFile + ".cgi?user=" + FosCamUserNameTextBox.Text + "&pwd=" + FoscamPasswordTextBox.Text
        End Select
    End Function
    Private Function GetCameraControlURLFromSettings() As String
        Return GetCgiURLFromSettings("camera_control")
    End Function
    Private Function GetDecoderControlURLFromSettings() As String
        Return GetCgiURLFromSettings("decoder_control")
    End Function
    Private Function GetCameraParamsURLFromSettings() As String
        Return GetCgiURLFromSettings("get_camera_params")
    End Function
    Private Function GetRebootURLFromSettings() As String
        Return GetCgiURLFromSettings("reboot")
    End Function
    Private Function GetStatusURLFromSettings() As String
        Return GetCgiURLFromSettings("get_status")
    End Function

    Private Sub CameraTypeFosCamRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CameraTypeFosCamRadioButton.CheckedChanged
        Select Case True
            Case CameraTypeFosCamRadioButton.Checked
                FosCamSettingsPanel.Visible = True
                GenericCameraSettingsPanel.Visible = False
                SelectedCameraType = CameraType.FosCam
            Case CameraTypeGenericRadioButton.Checked
                FosCamSettingsPanel.Visible = False
                GenericCameraSettingsPanel.Visible = True
                SelectedCameraType = CameraType.Generic
        End Select
    End Sub

    Private SelectedCameraType As CameraType

    Private Enum CameraType
        FosCam
        Generic
    End Enum

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer2.Interval = 1000 / 4
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer2.Interval = 1000 / 5
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Timer2.Interval = 1000 / 10
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Timer2.Interval = 1000 / 20
    End Sub
    Private Function GetCameraSettings() As Dictionary(Of String, String)
        Dim keyValues As New Dictionary(Of String, String)
        Dim url As String = GetStatusURLFromSettings()
        Dim webclient As New System.Net.WebClient
        Dim result As String = webclient.DownloadString(url)
        Dim resultLines() As String = result.Split(vbLf)
        For Each line As String In resultLines
            Dim keyStartIndex As Integer = line.IndexOf("var") + 4
            If line.Length - 1 > keyStartIndex Then
                line = line.Substring(keyStartIndex)
                Dim lineParts() As String = line.Split("="c)
                If lineParts.Length > 1 Then
                    Dim newKey As String = lineParts(0)
                    Dim value As String = lineParts(1)
                    If value.EndsWith(";"c) Then value = value.Substring(0, value.Length - 1) 'remove ;
                    If value.StartsWith("'"c) AndAlso value.EndsWith("'"c) Then value = value.Substring(1, value.Length - 2) 'remove single quotes
                    If Not keyValues.ContainsKey(newKey) Then keyValues.Add(newKey, value)
                End If
            End If
        Next
        Return keyValues
    End Function
    Private Sub RebootButton_Click(sender As System.Object, e As System.EventArgs) Handles RebootButton.Click
        Dim url As String = GetRebootURLFromSettings()
        Dim webclient As New System.Net.WebClient
        Dim result As String = webclient.DownloadString(url)
    End Sub
    Private Sub UpButton_Click(sender As System.Object, e As System.EventArgs) Handles UpButton.Click
        goUP()
    End Sub
    Private Sub DownButton_Click(sender As System.Object, e As System.EventArgs) Handles DownButton.Click
        goDown()
    End Sub
    Private Sub LeftButton_Click(sender As System.Object, e As System.EventArgs) Handles LeftButton.Click
        goLeft()
    End Sub
    Private Sub RightButton_Click(sender As System.Object, e As System.EventArgs) Handles RightButton.Click
        goRight()
    End Sub
    Private Sub goUp()
        ExecuteDecoderFunction(getDecoderParam(Direction.Up))
    End Sub
    Private Sub goDown()
        ExecuteDecoderFunction(getDecoderParam(Direction.Down))
    End Sub
    Private Sub goLeft()
        ExecuteDecoderFunction(getDecoderParam(Direction.Left))
    End Sub
    Private Sub goRight()
        ExecuteDecoderFunction(getDecoderParam(Direction.Right))
    End Sub
    Private Function ExecuteDecoderFunction(param As DecoderParam)
        If flipState = -1 Then GetFlipState()
        Dim url As String = GetDecoderControlURLFromSettings() + "&command=" + CInt(param).ToString + "&onestep=1"
        Dim webclient As New System.Net.WebClient
        Dim result As String = webclient.DownloadString(url)
    End Function
    Private Function getDecoderParam(dir As Direction) As DecoderParam
        Dim param As DecoderParam
        Select Case dir
            Case Direction.Up
                If flipState And Flip.verticalFlip Then
                    param = DecoderParam.down
                Else
                    param = DecoderParam.up
                End If
            Case Direction.Down
                If flipState And Flip.verticalFlip Then
                    param = DecoderParam.up
                Else
                    param = DecoderParam.down
                End If
            Case Direction.Left
                If flipState And Flip.HorizontalFlip Then
                    param = DecoderParam.right
                Else
                    param = DecoderParam.left
                End If
            Case Direction.Right
                If flipState And Flip.HorizontalFlip Then
                    param = DecoderParam.left
                Else
                    param = DecoderParam.right
                End If
        End Select
        Return param
    End Function
    Private Function GetFlipState() As Integer
        Dim params As String() = GetCameraParams.Split(vbCrLf)
        For Each param As String In params
            If param.Contains("flip") Then
                If param.Contains("0") Then flipState = 0
                If param.Contains("1") Then flipState = 1
                If param.Contains("2") Then flipState = 2
                If param.Contains("3") Then flipState = 3
            End If
        Next
        flipState = -1
        Return flipState
    End Function
    Dim flipState As Integer = -1
    Private Function GetCameraParams() As String
        Dim url As String = GetCameraParamsURLFromSettings()
        Dim webclient As New System.Net.WebClient
        Dim result As String = webclient.DownloadString(url)
        Return result
    End Function
    Private Enum Flip
        Normal = 0
        verticalFlip = 1
        HorizontalFlip = 2
    End Enum
    Private Enum Direction
        Up = 1
        Down = 2
        Left = 4
        Right = 8
    End Enum
    Private Enum DecoderParam
        up = 0
        down = 2
        left = 4
        right = 6
    End Enum

     
End Class
