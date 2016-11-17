<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JamesEnglish
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblPages = New System.Windows.Forms.Label()
        Me.txtPages = New System.Windows.Forms.TextBox()
        Me.lblPubYear = New System.Windows.Forms.Label()
        Me.txtYearPub = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSelectPub = New System.Windows.Forms.Label()
        Me.stsCount = New System.Windows.Forms.StatusStrip()
        Me.tsslCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cboPublisher = New System.Windows.Forms.ComboBox()
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksFall2012A3DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._books_Fall2012_A3DataSet = New A3_JEnglish._books_Fall2012_A3DataSet()
        Me.PublishersTableAdapter = New A3_JEnglish._books_Fall2012_A3DataSetTableAdapters.PublishersTableAdapter()
        Me.TitlesTableAdapter1 = New A3_JEnglish._books_Fall2012_A3DataSetTableAdapters.TitlesTableAdapter()
        Me.stsRequired = New System.Windows.Forms.StatusStrip()
        Me.tsbText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSaveIt = New System.Windows.Forms.Button()
        Me.btnEditIt = New System.Windows.Forms.Button()
        Me.stsCount.SuspendLayout()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksFall2012A3DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._books_Fall2012_A3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsRequired.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(12, 38)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(408, 20)
        Me.txtTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(9, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Title"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(12, 77)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(32, 13)
        Me.lblISBN.TabIndex = 2
        Me.lblISBN.Text = "ISBN"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(15, 104)
        Me.txtISBN.MaxLength = 13
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.ReadOnly = True
        Me.txtISBN.Size = New System.Drawing.Size(100, 20)
        Me.txtISBN.TabIndex = 3
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(197, 77)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(200, 104)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 5
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(12, 151)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(43, 13)
        Me.lblSubject.TabIndex = 6
        Me.lblSubject.Text = "Subject"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(12, 167)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(100, 20)
        Me.txtSubject.TabIndex = 7
        '
        'lblPages
        '
        Me.lblPages.AutoSize = True
        Me.lblPages.Location = New System.Drawing.Point(197, 151)
        Me.lblPages.Name = "lblPages"
        Me.lblPages.Size = New System.Drawing.Size(47, 13)
        Me.lblPages.TabIndex = 8
        Me.lblPages.Text = "# Pages"
        '
        'txtPages
        '
        Me.txtPages.Location = New System.Drawing.Point(200, 167)
        Me.txtPages.Name = "txtPages"
        Me.txtPages.ReadOnly = True
        Me.txtPages.Size = New System.Drawing.Size(100, 20)
        Me.txtPages.TabIndex = 9
        '
        'lblPubYear
        '
        Me.lblPubYear.AutoSize = True
        Me.lblPubYear.Location = New System.Drawing.Point(342, 151)
        Me.lblPubYear.Name = "lblPubYear"
        Me.lblPubYear.Size = New System.Drawing.Size(78, 13)
        Me.lblPubYear.TabIndex = 10
        Me.lblPubYear.Text = "Year Published"
        '
        'txtYearPub
        '
        Me.txtYearPub.Location = New System.Drawing.Point(345, 168)
        Me.txtYearPub.Name = "txtYearPub"
        Me.txtYearPub.ReadOnly = True
        Me.txtYearPub.Size = New System.Drawing.Size(100, 20)
        Me.txtYearPub.TabIndex = 11
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(494, 151)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(497, 167)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 13
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(12, 238)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(50, 13)
        Me.lblPublisher.TabIndex = 14
        Me.lblPublisher.Text = "Publisher"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(12, 255)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.ReadOnly = True
        Me.txtPublisher.Size = New System.Drawing.Size(100, 20)
        Me.txtPublisher.TabIndex = 15
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(192, 238)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 16
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(187, 254)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 17
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(12, 293)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 18
        Me.lblCity.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(12, 319)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 19
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(135, 293)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 20
        Me.lblState.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(138, 319)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(58, 20)
        Me.txtState.TabIndex = 21
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(221, 319)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 22
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(218, 293)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(50, 13)
        Me.lblZip.TabIndex = 23
        Me.lblZip.Text = "Zip Code"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(20, 363)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(50, 50)
        Me.btnFirst.TabIndex = 24
        Me.btnFirst.Text = "|<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(76, 363)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(50, 50)
        Me.btnPrevious.TabIndex = 25
        Me.btnPrevious.Text = "<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(132, 363)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(50, 50)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(188, 363)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(49, 50)
        Me.btnLast.TabIndex = 27
        Me.btnLast.Text = ">>|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(20, 419)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 44)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Enabled = False
        Me.btnUndo.Location = New System.Drawing.Point(188, 419)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(49, 44)
        Me.btnUndo.TabIndex = 31
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(243, 419)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(50, 44)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(299, 419)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(47, 44)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSelectPub
        '
        Me.lblSelectPub.AutoSize = True
        Me.lblSelectPub.Location = New System.Drawing.Point(442, 293)
        Me.lblSelectPub.Name = "lblSelectPub"
        Me.lblSelectPub.Size = New System.Drawing.Size(83, 13)
        Me.lblSelectPub.TabIndex = 34
        Me.lblSelectPub.Text = "Select Publisher"
        Me.lblSelectPub.Visible = False
        '
        'stsCount
        '
        Me.stsCount.Dock = System.Windows.Forms.DockStyle.None
        Me.stsCount.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslCount})
        Me.stsCount.Location = New System.Drawing.Point(0, 492)
        Me.stsCount.Name = "stsCount"
        Me.stsCount.Size = New System.Drawing.Size(34, 22)
        Me.stsCount.TabIndex = 36
        Me.stsCount.Text = "StatusStrip1"
        '
        'tsslCount
        '
        Me.tsslCount.Name = "tsslCount"
        Me.tsslCount.Size = New System.Drawing.Size(17, 17)
        Me.tsslCount.Text = """"""
        '
        'cboPublisher
        '
        Me.cboPublisher.DataSource = Me.PublishersBindingSource
        Me.cboPublisher.DisplayMember = "Name"
        Me.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPublisher.FormattingEnabled = True
        Me.cboPublisher.Location = New System.Drawing.Point(445, 319)
        Me.cboPublisher.Name = "cboPublisher"
        Me.cboPublisher.Size = New System.Drawing.Size(121, 21)
        Me.cboPublisher.TabIndex = 37
        Me.cboPublisher.ValueMember = "PubID"
        Me.cboPublisher.Visible = False
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "Publishers"
        Me.PublishersBindingSource.DataSource = Me.BooksFall2012A3DataSetBindingSource
        '
        'BooksFall2012A3DataSetBindingSource
        '
        Me.BooksFall2012A3DataSetBindingSource.DataSource = Me._books_Fall2012_A3DataSet
        Me.BooksFall2012A3DataSetBindingSource.Position = 0
        '
        '_books_Fall2012_A3DataSet
        '
        Me._books_Fall2012_A3DataSet.DataSetName = "_books_Fall2012_A3DataSet"
        Me._books_Fall2012_A3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PublishersTableAdapter
        '
        Me.PublishersTableAdapter.ClearBeforeFill = True
        '
        'TitlesTableAdapter1
        '
        Me.TitlesTableAdapter1.ClearBeforeFill = True
        '
        'stsRequired
        '
        Me.stsRequired.Dock = System.Windows.Forms.DockStyle.None
        Me.stsRequired.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbText})
        Me.stsRequired.Location = New System.Drawing.Point(299, 492)
        Me.stsRequired.Name = "stsRequired"
        Me.stsRequired.Size = New System.Drawing.Size(34, 22)
        Me.stsRequired.TabIndex = 38
        Me.stsRequired.Text = "stsRequired"
        Me.stsRequired.Visible = False
        '
        'tsbText
        '
        Me.tsbText.Name = "tsbText"
        Me.tsbText.Size = New System.Drawing.Size(17, 17)
        Me.tsbText.Text = """"""
        '
        'btnSaveIt
        '
        Me.btnSaveIt.Enabled = False
        Me.btnSaveIt.Location = New System.Drawing.Point(129, 419)
        Me.btnSaveIt.Name = "btnSaveIt"
        Me.btnSaveIt.Size = New System.Drawing.Size(50, 44)
        Me.btnSaveIt.TabIndex = 39
        Me.btnSaveIt.Text = "SaveIt"
        Me.btnSaveIt.UseVisualStyleBackColor = True
        '
        'btnEditIt
        '
        Me.btnEditIt.Location = New System.Drawing.Point(76, 419)
        Me.btnEditIt.Name = "btnEditIt"
        Me.btnEditIt.Size = New System.Drawing.Size(47, 44)
        Me.btnEditIt.TabIndex = 40
        Me.btnEditIt.Text = "EditIt"
        Me.btnEditIt.UseVisualStyleBackColor = True
        '
        'JamesEnglish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 514)
        Me.Controls.Add(Me.btnEditIt)
        Me.Controls.Add(Me.btnSaveIt)
        Me.Controls.Add(Me.stsRequired)
        Me.Controls.Add(Me.cboPublisher)
        Me.Controls.Add(Me.stsCount)
        Me.Controls.Add(Me.lblSelectPub)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtYearPub)
        Me.Controls.Add(Me.lblPubYear)
        Me.Controls.Add(Me.txtPages)
        Me.Controls.Add(Me.lblPages)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Name = "JamesEnglish"
        Me.Text = "SaveIt"
        Me.stsCount.ResumeLayout(False)
        Me.stsCount.PerformLayout()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksFall2012A3DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._books_Fall2012_A3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsRequired.ResumeLayout(False)
        Me.stsRequired.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblISBN As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblPages As System.Windows.Forms.Label
    Friend WithEvents txtPages As System.Windows.Forms.TextBox
    Friend WithEvents lblPubYear As System.Windows.Forms.Label
    Friend WithEvents txtYearPub As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSelectPub As System.Windows.Forms.Label
    Friend WithEvents stsCount As System.Windows.Forms.StatusStrip
    Friend WithEvents cboPublisher As System.Windows.Forms.ComboBox
    Friend WithEvents BooksFall2012A3DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _books_Fall2012_A3DataSet As A3_JEnglish._books_Fall2012_A3DataSet
    Friend WithEvents PublishersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PublishersTableAdapter As A3_JEnglish._books_Fall2012_A3DataSetTableAdapters.PublishersTableAdapter
    Friend WithEvents TitlesTableAdapter1 As A3_JEnglish._books_Fall2012_A3DataSetTableAdapters.TitlesTableAdapter
    Friend WithEvents tsslCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsRequired As System.Windows.Forms.StatusStrip
    Friend WithEvents tsbText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSaveIt As System.Windows.Forms.Button
    Friend WithEvents btnEditIt As System.Windows.Forms.Button

End Class
