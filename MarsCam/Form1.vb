'Imports System.Net.Http
'Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web.Script.Serialization

Public Class Form1
    Dim imageUrls As New List(Of String)
    Dim showRequest As Boolean = False
    Dim imagePos As Integer = 0
    Dim additionalInfo As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = 812
        'PictureBox2.Load("https://mars.nasa.gov/msl-raw-images/proj/msl/redops/ods/surface/sol/01000/opgs/edr/rcam/RLB_486265291EDR_F0481570RHAZ00323M_.JPG")
    End Sub

    Private Sub btnGrabImage_Click(sender As Object, e As EventArgs) Handles btnGrabImage.Click
        Dim apiUrl As String = "https://api.nasa.gov/mars-photos/api/v1/rovers/"

        If rbCuriosity.Checked Then
            apiUrl += "curiosity"
        ElseIf rbOpportunity.Checked Then
            apiUrl += "opportunity"
        ElseIf rbInsight.Checked Then
            apiUrl += "spirit"
        Else
            MessageBox.Show("Please select a rover to continue.")
            Return
        End If

        apiUrl = apiUrl + "/photos?sol=" + txtSol.Text + "&camera="

        If rbFHAZ.Checked Then
            apiUrl += "fhaz"
        ElseIf rbRHAZ.Checked Then
            apiUrl += "rhaz"
        ElseIf rbMAST.Checked Then
            apiUrl += "mast"
        ElseIf rbCHEMCAM.Checked Then
            apiUrl += "chemcam"
        ElseIf rbMAHLI.Checked Then
            apiUrl += "mahli"
        ElseIf rbMARDI.Checked Then
            apiUrl += "madri"
        ElseIf rbNAVCAM.Checked Then
            apiUrl += "navcam"
        ElseIf rbPANCAM.Checked Then
            apiUrl += "pancam"
        ElseIf rbMINITES.Checked Then
            apiUrl += "minites"
        Else
            MessageBox.Show("Please select a camera to continue")
            Return
        End If

        Cursor = Cursors.WaitCursor

        apiUrl = apiUrl + "&" + "api_key=K3GPY8eUHOPXU1ezvOlbyT06snlEAXp5A5QPUGPM"
        slURL.Text = "Grabbing: " + apiUrl

        Try
            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(apiUrl)
            Dim imageUrl As String = "https://mars.nasa.gov/msl-raw-images/proj/msl/redops/ods/surface/sol/01000/opgs/edr/rcam/"

            Dim pattern As String = "http\:\/\/[^\""]+|https\:\/\/[^\""]+"
            Dim patternLaunchDate As String = "launch_date"":""[^\""]+"
            Dim patternLandDate As String = "landing_date"":""[^\""]+"
            Dim patternRoverName As String = "status"":""[^\""]+"

            Dim match = Regex.Match(result, pattern)
            Dim LaunchDate = Regex.Match(result, patternLaunchDate)
            Dim LandDate = Regex.Match(result, patternLandDate)
            Dim RoverName = Regex.Match(result, patternRoverName)

            additionalInfo = ""
            additionalInfo += $"Status: {RoverName.ToString().Replace("active"":""", "")}{vbCrLf}"
            additionalInfo += $"Launch Date: {LaunchDate.ToString().Replace("launch_date"":""", "")}{vbCrLf}"
            additionalInfo += $"Landing Date: {LandDate.ToString().Replace("landing_date"":""", "")}{vbCrLf}"

            txtAdditional.Text = additionalInfo


            If match.Success Then
                imageUrls.Clear()
                imagePos = 0
            End If

            Do While match.Success
                imageUrls.Add(match.ToString())
                match = match.NextMatch()
            Loop

            imageUrl = imageUrls.ElementAt(imagePos)
            lblImageNo.Text = $"{imagePos + 1} of {imageUrls.Count()}"

            If showRequest Then
                txtRequestData.Text = result
            End If

            Try
                Dim image As String = result.Substring(result.IndexOf("img_src") + 102, 36)

                'Dim imgurl As String = "https://mars.nasa.gov/msl-raw-images/proj/msl/redops/ods/surface/sol/01000/opgs/edr/rcam/" & image & ".JPG"

                PictureBox2.Load(imageUrl)
                slURL.Text = ""
            Catch ex As Exception
                slURL.Text = "Failed to grab image"
            End Try

            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
        End Try






    End Sub

    Private Sub cbShowRequest_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowRequest.CheckedChanged
        showRequest = cbShowRequest.Checked

        If showRequest Then
            Width = 1180
        Else
            Width = 812
        End If
    End Sub

    Private Sub rbCuriosity_CheckedChanged(sender As Object, e As EventArgs) Handles rbCuriosity.CheckedChanged
        rbFHAZ.Enabled = True
        rbRHAZ.Enabled = True
        rbMAST.Enabled = True
        rbCHEMCAM.Enabled = True
        rbMAHLI.Enabled = True
        rbMARDI.Enabled = True
        rbNAVCAM.Enabled = True
        rbPANCAM.Enabled = False
        rbMINITES.Enabled = False

        rbPANCAM.Checked = False
        rbMINITES.Checked = False
    End Sub

    Private Sub rbOpportunity_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpportunity.CheckedChanged
        rbFHAZ.Enabled = True
        rbRHAZ.Enabled = True
        rbMAST.Enabled = False
        rbCHEMCAM.Enabled = False
        rbMAHLI.Enabled = False
        rbMARDI.Enabled = False
        rbNAVCAM.Enabled = True
        rbPANCAM.Enabled = True
        rbMINITES.Enabled = True

        rbMAST.Checked = False
        rbCHEMCAM.Checked = False
        rbMAHLI.Checked = False
        rbMARDI.Checked = False
    End Sub

    Private Sub rbInsight_CheckedChanged(sender As Object, e As EventArgs) Handles rbInsight.CheckedChanged
        rbFHAZ.Enabled = True
        rbRHAZ.Enabled = True
        rbMAST.Enabled = False
        rbCHEMCAM.Enabled = False
        rbMAHLI.Enabled = False
        rbMARDI.Enabled = False
        rbNAVCAM.Enabled = True
        rbPANCAM.Enabled = True
        rbMINITES.Enabled = True

        rbMAST.Checked = False
        rbCHEMCAM.Checked = False
        rbMAHLI.Checked = False
        rbMARDI.Checked = False
    End Sub

    Private Sub btnClearImage_Click(sender As Object, e As EventArgs) Handles btnClearImage.Click
        txtRequestData.Text = ""
        PictureBox2.Image = Nothing
    End Sub

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        sfdSaveImage.ShowDialog()
    End Sub

    Private Sub btnSaveRequest_Click(sender As Object, e As EventArgs) Handles btnSaveRequest.Click
        sfdSaveRequest.ShowDialog()
    End Sub


    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sfdSaveImage.FileOk
        Dim FileToSaveAs As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, sfdSaveImage.FileName)
        PictureBox2.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub btnImagePrev_Click(sender As Object, e As EventArgs) Handles btnImagePrev.Click
        If imagePos - 1 < imageUrls.Count() Then
            imagePos -= 1
        Else
            imagePos = 0
        End If

        lblImageNo.Text = $"{imagePos + 1} of {imageUrls.Count()}"
        PictureBox2.Load(imageUrls.ElementAt(imagePos))
    End Sub

    Private Sub btnImageNext_Click(sender As Object, e As EventArgs) Handles btnImageNext.Click
        If imagePos + 1 < imageUrls.Count() Then
            imagePos += 1
        Else
            imagePos = 0
        End If

        lblImageNo.Text = $"{imagePos + 1} of {imageUrls.Count() }"
        PictureBox2.Load(imageUrls.ElementAt(imagePos))
    End Sub

    Private Sub cbShowInfo_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowInfo.CheckedChanged
        Width = 1548
    End Sub

    Private Sub sfdSaveRequest_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfdSaveRequest.FileOk
        Dim FileToSaveAs As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, sfdSaveImage.FileName)
        Dim file As System.IO.StreamWriter

        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(FileToSaveAs, True)
            file.WriteLine(txtRequestData.Text.ToString())
            file.Close()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub tChangeImage_Tick(sender As Object, e As EventArgs) Handles tChangeImage.Tick
        If imagePos + 1 < imageUrls.Count() Then
            imagePos += 1
        Else
            imagePos = 0
        End If

        lblImageNo.Text = $"{imagePos + 1} of {imageUrls.Count() }"
        PictureBox2.Load(imageUrls.ElementAt(imagePos))
    End Sub

    Private Sub cbLoopImages_CheckedChanged(sender As Object, e As EventArgs) Handles cbLoopImages.CheckedChanged
        If cbLoopImages.Checked Then
            tChangeImage.Start()
        Else
            tChangeImage.Stop()
        End If
    End Sub
End Class
