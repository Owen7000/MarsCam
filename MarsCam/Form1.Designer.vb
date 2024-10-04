<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rbCuriosity = New System.Windows.Forms.RadioButton()
        Me.rbOpportunity = New System.Windows.Forms.RadioButton()
        Me.rbInsight = New System.Windows.Forms.RadioButton()
        Me.gbRovers = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbCamera = New System.Windows.Forms.GroupBox()
        Me.rbMINITES = New System.Windows.Forms.RadioButton()
        Me.rbPANCAM = New System.Windows.Forms.RadioButton()
        Me.rbNAVCAM = New System.Windows.Forms.RadioButton()
        Me.rbMARDI = New System.Windows.Forms.RadioButton()
        Me.rbMAHLI = New System.Windows.Forms.RadioButton()
        Me.rbCHEMCAM = New System.Windows.Forms.RadioButton()
        Me.rbMAST = New System.Windows.Forms.RadioButton()
        Me.rbRHAZ = New System.Windows.Forms.RadioButton()
        Me.rbFHAZ = New System.Windows.Forms.RadioButton()
        Me.btnGrabImage = New System.Windows.Forms.Button()
        Me.gbSol = New System.Windows.Forms.GroupBox()
        Me.txtSol = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.slURL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbShowRequest = New System.Windows.Forms.CheckBox()
        Me.txtRequestData = New System.Windows.Forms.TextBox()
        Me.lblRequestView = New System.Windows.Forms.Label()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.btnSaveRequest = New System.Windows.Forms.Button()
        Me.btnClearImage = New System.Windows.Forms.Button()
        Me.sfdSaveImage = New System.Windows.Forms.SaveFileDialog()
        Me.cbShowInfo = New System.Windows.Forms.CheckBox()
        Me.lblImageNo = New System.Windows.Forms.Label()
        Me.btnImagePrev = New System.Windows.Forms.Button()
        Me.btnImageNext = New System.Windows.Forms.Button()
        Me.txtAdditional = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sfdSaveRequest = New System.Windows.Forms.SaveFileDialog()
        Me.tChangeImage = New System.Windows.Forms.Timer(Me.components)
        Me.cbLoopImages = New System.Windows.Forms.CheckBox()
        Me.gbRovers.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCamera.SuspendLayout()
        Me.gbSol.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbCuriosity
        '
        resources.ApplyResources(Me.rbCuriosity, "rbCuriosity")
        Me.rbCuriosity.Name = "rbCuriosity"
        Me.rbCuriosity.TabStop = True
        Me.rbCuriosity.UseVisualStyleBackColor = True
        '
        'rbOpportunity
        '
        resources.ApplyResources(Me.rbOpportunity, "rbOpportunity")
        Me.rbOpportunity.Name = "rbOpportunity"
        Me.rbOpportunity.TabStop = True
        Me.rbOpportunity.UseVisualStyleBackColor = True
        '
        'rbInsight
        '
        resources.ApplyResources(Me.rbInsight, "rbInsight")
        Me.rbInsight.Name = "rbInsight"
        Me.rbInsight.TabStop = True
        Me.rbInsight.UseVisualStyleBackColor = True
        '
        'gbRovers
        '
        Me.gbRovers.Controls.Add(Me.rbCuriosity)
        Me.gbRovers.Controls.Add(Me.rbInsight)
        Me.gbRovers.Controls.Add(Me.rbOpportunity)
        resources.ApplyResources(Me.gbRovers, "gbRovers")
        Me.gbRovers.Name = "gbRovers"
        Me.gbRovers.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'gbCamera
        '
        Me.gbCamera.Controls.Add(Me.rbMINITES)
        Me.gbCamera.Controls.Add(Me.rbPANCAM)
        Me.gbCamera.Controls.Add(Me.rbNAVCAM)
        Me.gbCamera.Controls.Add(Me.rbMARDI)
        Me.gbCamera.Controls.Add(Me.rbMAHLI)
        Me.gbCamera.Controls.Add(Me.rbCHEMCAM)
        Me.gbCamera.Controls.Add(Me.rbMAST)
        Me.gbCamera.Controls.Add(Me.rbRHAZ)
        Me.gbCamera.Controls.Add(Me.rbFHAZ)
        resources.ApplyResources(Me.gbCamera, "gbCamera")
        Me.gbCamera.Name = "gbCamera"
        Me.gbCamera.TabStop = False
        '
        'rbMINITES
        '
        resources.ApplyResources(Me.rbMINITES, "rbMINITES")
        Me.rbMINITES.Name = "rbMINITES"
        Me.rbMINITES.TabStop = True
        Me.rbMINITES.UseVisualStyleBackColor = True
        '
        'rbPANCAM
        '
        resources.ApplyResources(Me.rbPANCAM, "rbPANCAM")
        Me.rbPANCAM.Name = "rbPANCAM"
        Me.rbPANCAM.TabStop = True
        Me.rbPANCAM.UseVisualStyleBackColor = True
        '
        'rbNAVCAM
        '
        resources.ApplyResources(Me.rbNAVCAM, "rbNAVCAM")
        Me.rbNAVCAM.Name = "rbNAVCAM"
        Me.rbNAVCAM.TabStop = True
        Me.rbNAVCAM.UseVisualStyleBackColor = True
        '
        'rbMARDI
        '
        resources.ApplyResources(Me.rbMARDI, "rbMARDI")
        Me.rbMARDI.Name = "rbMARDI"
        Me.rbMARDI.TabStop = True
        Me.rbMARDI.UseVisualStyleBackColor = True
        '
        'rbMAHLI
        '
        resources.ApplyResources(Me.rbMAHLI, "rbMAHLI")
        Me.rbMAHLI.Name = "rbMAHLI"
        Me.rbMAHLI.TabStop = True
        Me.rbMAHLI.UseVisualStyleBackColor = True
        '
        'rbCHEMCAM
        '
        resources.ApplyResources(Me.rbCHEMCAM, "rbCHEMCAM")
        Me.rbCHEMCAM.Name = "rbCHEMCAM"
        Me.rbCHEMCAM.TabStop = True
        Me.rbCHEMCAM.UseVisualStyleBackColor = True
        '
        'rbMAST
        '
        resources.ApplyResources(Me.rbMAST, "rbMAST")
        Me.rbMAST.Name = "rbMAST"
        Me.rbMAST.TabStop = True
        Me.rbMAST.UseVisualStyleBackColor = True
        '
        'rbRHAZ
        '
        resources.ApplyResources(Me.rbRHAZ, "rbRHAZ")
        Me.rbRHAZ.Name = "rbRHAZ"
        Me.rbRHAZ.TabStop = True
        Me.rbRHAZ.UseVisualStyleBackColor = True
        '
        'rbFHAZ
        '
        resources.ApplyResources(Me.rbFHAZ, "rbFHAZ")
        Me.rbFHAZ.Name = "rbFHAZ"
        Me.rbFHAZ.TabStop = True
        Me.rbFHAZ.UseVisualStyleBackColor = True
        '
        'btnGrabImage
        '
        resources.ApplyResources(Me.btnGrabImage, "btnGrabImage")
        Me.btnGrabImage.Name = "btnGrabImage"
        Me.btnGrabImage.UseVisualStyleBackColor = True
        '
        'gbSol
        '
        Me.gbSol.Controls.Add(Me.txtSol)
        resources.ApplyResources(Me.gbSol, "gbSol")
        Me.gbSol.Name = "gbSol"
        Me.gbSol.TabStop = False
        '
        'txtSol
        '
        resources.ApplyResources(Me.txtSol, "txtSol")
        Me.txtSol.Name = "txtSol"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slURL})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'slURL
        '
        Me.slURL.Name = "slURL"
        resources.ApplyResources(Me.slURL, "slURL")
        '
        'cbShowRequest
        '
        resources.ApplyResources(Me.cbShowRequest, "cbShowRequest")
        Me.cbShowRequest.Name = "cbShowRequest"
        Me.cbShowRequest.UseVisualStyleBackColor = True
        '
        'txtRequestData
        '
        resources.ApplyResources(Me.txtRequestData, "txtRequestData")
        Me.txtRequestData.Name = "txtRequestData"
        Me.txtRequestData.ReadOnly = True
        '
        'lblRequestView
        '
        resources.ApplyResources(Me.lblRequestView, "lblRequestView")
        Me.lblRequestView.Name = "lblRequestView"
        '
        'btnSaveImage
        '
        resources.ApplyResources(Me.btnSaveImage, "btnSaveImage")
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.UseVisualStyleBackColor = True
        '
        'btnSaveRequest
        '
        resources.ApplyResources(Me.btnSaveRequest, "btnSaveRequest")
        Me.btnSaveRequest.Name = "btnSaveRequest"
        Me.btnSaveRequest.UseVisualStyleBackColor = True
        '
        'btnClearImage
        '
        resources.ApplyResources(Me.btnClearImage, "btnClearImage")
        Me.btnClearImage.Name = "btnClearImage"
        Me.btnClearImage.UseVisualStyleBackColor = True
        '
        'sfdSaveImage
        '
        Me.sfdSaveImage.DefaultExt = "jpg"
        resources.ApplyResources(Me.sfdSaveImage, "sfdSaveImage")
        '
        'cbShowInfo
        '
        resources.ApplyResources(Me.cbShowInfo, "cbShowInfo")
        Me.cbShowInfo.Name = "cbShowInfo"
        Me.cbShowInfo.UseVisualStyleBackColor = True
        '
        'lblImageNo
        '
        resources.ApplyResources(Me.lblImageNo, "lblImageNo")
        Me.lblImageNo.Name = "lblImageNo"
        '
        'btnImagePrev
        '
        resources.ApplyResources(Me.btnImagePrev, "btnImagePrev")
        Me.btnImagePrev.Name = "btnImagePrev"
        Me.btnImagePrev.UseVisualStyleBackColor = True
        '
        'btnImageNext
        '
        resources.ApplyResources(Me.btnImageNext, "btnImageNext")
        Me.btnImageNext.Name = "btnImageNext"
        Me.btnImageNext.UseVisualStyleBackColor = True
        '
        'txtAdditional
        '
        resources.ApplyResources(Me.txtAdditional, "txtAdditional")
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'sfdSaveRequest
        '
        Me.sfdSaveRequest.DefaultExt = "json"
        resources.ApplyResources(Me.sfdSaveRequest, "sfdSaveRequest")
        '
        'tChangeImage
        '
        '
        'cbLoopImages
        '
        resources.ApplyResources(Me.cbLoopImages, "cbLoopImages")
        Me.cbLoopImages.Name = "cbLoopImages"
        Me.cbLoopImages.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbLoopImages)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAdditional)
        Me.Controls.Add(Me.btnImageNext)
        Me.Controls.Add(Me.btnImagePrev)
        Me.Controls.Add(Me.lblImageNo)
        Me.Controls.Add(Me.cbShowInfo)
        Me.Controls.Add(Me.btnClearImage)
        Me.Controls.Add(Me.btnSaveRequest)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.lblRequestView)
        Me.Controls.Add(Me.txtRequestData)
        Me.Controls.Add(Me.cbShowRequest)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbSol)
        Me.Controls.Add(Me.btnGrabImage)
        Me.Controls.Add(Me.gbCamera)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gbRovers)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.gbRovers.ResumeLayout(False)
        Me.gbRovers.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCamera.ResumeLayout(False)
        Me.gbCamera.PerformLayout()
        Me.gbSol.ResumeLayout(False)
        Me.gbSol.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbCuriosity As RadioButton
    Friend WithEvents rbOpportunity As RadioButton
    Friend WithEvents rbInsight As RadioButton
    Friend WithEvents gbRovers As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gbCamera As GroupBox
    Friend WithEvents rbMINITES As RadioButton
    Friend WithEvents rbPANCAM As RadioButton
    Friend WithEvents rbNAVCAM As RadioButton
    Friend WithEvents rbMARDI As RadioButton
    Friend WithEvents rbMAHLI As RadioButton
    Friend WithEvents rbCHEMCAM As RadioButton
    Friend WithEvents rbMAST As RadioButton
    Friend WithEvents rbRHAZ As RadioButton
    Friend WithEvents rbFHAZ As RadioButton
    Friend WithEvents btnGrabImage As Button
    Friend WithEvents gbSol As GroupBox
    Friend WithEvents txtSol As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents slURL As ToolStripStatusLabel
    Friend WithEvents cbShowRequest As CheckBox
    Friend WithEvents txtRequestData As TextBox
    Friend WithEvents lblRequestView As Label
    Friend WithEvents btnSaveImage As Button
    Friend WithEvents btnSaveRequest As Button
    Friend WithEvents btnClearImage As Button
    Friend WithEvents sfdSaveImage As SaveFileDialog
    Friend WithEvents cbShowInfo As CheckBox
    Friend WithEvents lblImageNo As Label
    Friend WithEvents btnImagePrev As Button
    Friend WithEvents btnImageNext As Button
    Friend WithEvents txtAdditional As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sfdSaveRequest As SaveFileDialog
    Friend WithEvents tChangeImage As Timer
    Friend WithEvents cbLoopImages As CheckBox
End Class
