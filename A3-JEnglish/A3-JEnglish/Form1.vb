'James English
'IT 505 Project 3
'10/19/12
Option Strict On

Public Class JamesEnglish

    Private bookmark As Integer = 0
    Private addflag As Boolean = False
    Private editFlag As Boolean = False


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_books_Fall2012_A3DataSet.Publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me._books_Fall2012_A3DataSet.Publishers)
        Me.TitlesTableAdapter1.Fill(Me._books_Fall2012_A3DataSet.Titles)
        setTitle(bookmark)
        setPub(_books_Fall2012_A3DataSet.Titles(bookmark).PubID) ' sets the publisher correctly from the begining 
        buttonChange() ' sets the buttons correctly 
        tsslCount.Text = "Book #: " & bookmark + 1 & " of " & _books_Fall2012_A3DataSet.Titles.Count ' sets the counter 

    End Sub

    '------------------------------------------first button click ---------------------------------------------
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        bookmark = 0 ' back to the first book

        buttonChange()

        setPub(_books_Fall2012_A3DataSet.Titles(bookmark).PubID)
        setTitle(bookmark)
        tsslCount.Text = "Book #: " & bookmark + 1 & " of " & _books_Fall2012_A3DataSet.Titles.Count
    End Sub
    '----------------------------------------setting the title ---------------------------------------------
    Private Sub setTitle(ByVal id As Integer)
        Dim dr As _books_Fall2012_A3DataSet.TitlesRow

        dr = _books_Fall2012_A3DataSet.Titles(id)

        txtISBN.Text = dr.ISBN

        If dr.IsTitleNull Then
            txtTitle.Text = ""
        Else
            txtTitle.Text = dr.Title
        End If

        If dr.IsDescriptionNull Then
            txtDescription.Text = ""
        Else
            txtDescription.Text = dr.Description
        End If

        If dr.IsPagesNull Then
            txtPages.Text = ""
        Else
            txtPages.Text = CStr(dr.Pages)
        End If

        If dr.IsPriceNull Then
            txtPrice.Text = ""
        Else
            txtPrice.Text = CStr(dr.Price)
        End If

        If dr.IsSubjectNull Then
            txtSubject.Text = ""
        Else
            txtSubject.Text = dr.Subject

        End If

        If dr.IsYear_PublishedNull Then
            txtYearPub.Text = ""
        Else
            txtYearPub.Text = CStr(dr.Year_Published)
        End If



    End Sub
    '---------------------------------------------------------setPub---------------------------------------------------------------
    Private Sub setPub(ByVal id As Integer) ' sets the publisher 

        Dim pub As _books_Fall2012_A3DataSet.PublishersRow


        pub = _books_Fall2012_A3DataSet.Publishers.FindByPubID(id)


        If pub Is Nothing Then ' needed this to fix a crashing error, exits the program is there was no row to grab 
            Exit Sub
        End If



        If pub.IsAddressNull Then
            txtAddress.Text = ""
        Else
            txtAddress.Text = pub.Address

        End If

        If pub.IsCityNull Then
            txtCity.Text = ""
        Else
            txtCity.Text = pub.City
        End If

        If pub.IsStateNull Then
            txtState.Text = ""
        Else
            txtState.Text = pub.State

        End If
        If pub.IsZipNull Then
            txtZip.Text = ""
        Else
            txtZip.Text = pub.Zip

        End If
        If pub.IsCompany_NameNull Then
            txtPublisher.Text = ""
        Else
            txtPublisher.Text = pub.Name
        End If
        cboPublisher.Text = pub.Name

    End Sub
    '---------------------------------------------------------buttonNextClick---------------------------------------------------------------

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bookmark = bookmark + 1


        setTitle(bookmark)
        setPub(_books_Fall2012_A3DataSet.Titles(bookmark).PubID)
        buttonChange()
        tsslCount.Text = "Book #: " & bookmark + 1 & " of " & _books_Fall2012_A3DataSet.Titles.Count
    End Sub
    '---------------------------------------------------------buttonPreviousClick---------------------------------------------------------------
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        bookmark = bookmark - 1


        buttonChange()

        If bookmark >= 0 Then
            setTitle(bookmark)
        End If

        setPub(_books_Fall2012_A3DataSet.Titles(bookmark).PubID)
        tsslCount.Text = "Book #: " & bookmark + 1 & " of " & _books_Fall2012_A3DataSet.Titles.Count

    End Sub
    '---------------------------------------------------------buttonChange---------------------------------------------------------------

    Private Sub buttonChange() ' changes the buttons according to where the titles binding source is

        If bookmark = 0 Then 'First Books
            btnPrevious.Enabled = False
            btnFirst.Enabled = False
            btnNext.Enabled = True
            btnLast.Enabled = True
        End If

        If bookmark = _books_Fall2012_A3DataSet.Titles.Count - 1 Then
            btnPrevious.Enabled = True
            btnFirst.Enabled = True
            btnNext.Enabled = False
            btnLast.Enabled = False
        End If

        If Not editFlag Then
            If bookmark > 0 And bookmark < _books_Fall2012_A3DataSet.Titles.Count - 1 Then
                btnPrevious.Enabled = True
                btnFirst.Enabled = True
                btnNext.Enabled = True
                btnLast.Enabled = True
            End If
        End If




        If editFlag Then ' in edit mode they are all disabled 
            btnPrevious.Enabled = False
            btnFirst.Enabled = False
            btnNext.Enabled = False
            btnLast.Enabled = False
        End If


    End Sub
    '---------------------------------------------------------bottomButtonChange---------------------------------------------------------------


    Private Sub bottomButtonChange(ByVal boolx As Boolean)
        btnAdd.Enabled = boolx
        btnEditIt.Enabled = boolx
        btnDelete.Enabled = boolx
        btnExit.Enabled = boolx
        btnSaveIt.Enabled = Not boolx
        btnUndo.Enabled = Not boolx
        cboPublisher.Enabled = Not boolx
        lblPublisher.Visible = Not boolx
    End Sub
    '---------------------------------------------------------ValidationMethod---------------------------------------------------------------

    Private Function validateIt() As Boolean ' validation method for all data

        Try


            Dim dResult As DialogResult

            Dim boolYearFlag As Boolean = False


            If txtTitle.TextLength = 0 Then
                dResult = MessageBox.Show("Enter a Title", "Title Incorrect", MessageBoxButtons.OK) ' validates to make sure there is a title

                Return False
            End If



            If txtISBN.TextLength < 13 Then 'validates the length of the ISBN 
                dResult = MessageBox.Show("Enter a Valid ISBN", "ISBN Incorrect", MessageBoxButtons.OK)

                Return False
            End If

            If txtYearPub.Text = "" Then ' if its a blank year  its still allowed, sets the flags to true 
                boolYearFlag = True


            End If

            If Not boolYearFlag Then ' if its not a blank year published, then validate the year entered 
                If CInt(txtYearPub.Text) < 1900 Or CInt(txtYearPub.Text) > 2013 Then
                    dResult = MessageBox.Show("Year must be between 1900 and 2013", "Year published incorrect", MessageBoxButtons.OK)
                    Return False
                End If
            End If



            If cboPublisher.SelectedIndex = -1 Then ' makes sure the user selects a publisher 
                dResult = MessageBox.Show("Select Publisher", "Select Publisher", MessageBoxButtons.OK)
                Return False

            End If

            If txtPrice.Text = "" Then
                dResult = MessageBox.Show("Enter a Price!", "Price required", MessageBoxButtons.OK) 'price requried 
                Return False
            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return True

    End Function
    '---------------------------------------------------------EnableEdit---------------------------------------------------------------

    Private Sub enableEdit(ByVal boolx As Boolean) ' Changes the readonly properties of certain text boxes to allow user edits 


        txtDescription.ReadOnly = Not boolx
        txtISBN.ReadOnly = Not boolx
        txtPages.ReadOnly = Not boolx
        txtPrice.ReadOnly = Not boolx

        txtSubject.ReadOnly = Not boolx
        txtTitle.ReadOnly = Not boolx
        txtYearPub.ReadOnly = Not boolx

        cboPublisher.Enabled = boolx
        cboPublisher.Visible = boolx
        lblSelectPub.Visible = boolx




    End Sub
    '---------------------------------------------------------buttonLastClick---------------------------------------------------------------

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bookmark = _books_Fall2012_A3DataSet.Titles.Count - 1
        setTitle(bookmark)

        setPub(_books_Fall2012_A3DataSet.Titles(bookmark).PubID)

        buttonChange()
        tsslCount.Text = "Book #: " & bookmark + 1 & " of " & _books_Fall2012_A3DataSet.Titles.Count

    End Sub
    '---------------------------------------------------------exitClick---------------------------------------------------------------
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '---------------------------------------------------------AddClick---------------------------------------------------------------
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try
            addflag = True

            cboPublisher.SelectedIndex = -1 ' sets the index of the publisher combobox to -1 so the user must pick a publisher 
            txtAddress.Clear() ' clears the names of each box 
            txtPublisher.Clear()
            txtState.Clear()
            txtCity.Clear()
            txtZip.Clear()
            txtTitle.Clear()
            txtISBN.Clear()
            txtDescription.Clear()
            txtSubject.Clear()
            txtPages.Clear()
            txtPrice.Clear()
            txtYearPub.Clear()
            bottomButtonChange(False)
            enableEdit(True)
            stsRequired.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    '---------------------------------------------------------undoClick---------------------------------------------------------------

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        editFlag = False
        addflag = False

        setPub(_books_Fall2012_A3DataSet.Titles(bookmark).PubID) 'sets the publisher back to what it should be 

        setTitle(bookmark) ' sets the title back to what it should be 


        bottomButtonChange(True)
        buttonChange()
        enableEdit(False)
        stsRequired.Visible = False
    End Sub
    '---------------------------------------------------------indexChange of Publisher---------------------------------------------------------------
    Private Sub cboPublisher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPublisher.SelectedIndexChanged

        Dim pubInt As Integer = CInt(cboPublisher.SelectedValue) ' sets the correct publishers information based on the selected value of the publisher
        setPub(pubInt)

    End Sub
    '---------------------------------------------------------subjectTextEnter---------------------------------------------------------------

    Private Sub txtSubject_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubject.Enter
        If editFlag Then
            tsbText.Text = "Subject field not required"
        End If
    End Sub
    '---------------------------------------------------------Price Key pressed---------------------------------------------------------------

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        Select Case e.KeyChar 'only allows numbers or a . symbol for the price 
            Case "0"c To "9"c

            Case "."c
                If txtPrice.Text.IndexOf("."c) <> -1 And txtPrice.SelectionLength _
                        = 0 Then e.Handled = True
            Case ControlChars.Back

            Case Else
                e.Handled = True

        End Select

    End Sub
    '---------------------------------------------------------txtISBNEnter---------------------------------------------------------------
    Private Sub txtISBN_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtISBN.Enter
        If editFlag Then
            tsbText.Text = "ISBN format must be  0-1234567-8-9 or 0-1234567-8-X" ' lets the user know what valid ISBN to enter 
        End If
    End Sub
    '---------------------------------------------------------TxtISBNKeyPress ---------------------------------------------------------------
    Private Sub txtISBN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtISBN.KeyPress
        Select Case e.KeyChar
            Case "0"c To "9"c ' only allows valid ISBNs to be entered based off position either a number, x or - is allowed 
                Dim length As Integer = txtISBN.TextLength
                If length = 1 Or length = 9 Or length = 11 Then
                    e.Handled = True
                End If
            Case "-"c
                Dim length As Integer = txtISBN.TextLength
                If length = 1 Or length = 9 Or length = 11 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

            Case "X"c
                Dim length As Integer = txtISBN.TextLength
                If length <> 12 Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If


            Case ControlChars.Back
            Case Else
                e.Handled = True



        End Select
    End Sub
    '---------------------------------------------------------delete---------------------------------------------------------------
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are You Sure", "Are You Sure", MessageBoxButtons.YesNo)

        Try
            If result = Windows.Forms.DialogResult.Yes Then ' if user clicks yes then 
                Dim didx As _books_Fall2012_A3DataSet.TitlesRow
                didx = _books_Fall2012_A3DataSet.Titles(bookmark)
                didx.Delete()
                TitlesTableAdapter1.Update(_books_Fall2012_A3DataSet) ' delete them and update it 
                If bookmark = _books_Fall2012_A3DataSet.Titles.Count Then ' if delete last book, go to the previous 
                    bookmark = bookmark - 1
                    setTitle(bookmark)
                    setPub(_books_Fall2012_A3DataSet.Titles(bookmark).PubID)
                Else ' otherwise go to the next book ahead of it 
                    bookmark = bookmark + 1
                    setTitle(bookmark)
                    setPub(_books_Fall2012_A3DataSet.Titles(bookmark).PubID)
                End If




            End If
           

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    '---------------------------------------------------------textPagesEnter---------------------------------------------------------------


    Private Sub txtPages_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPages.Enter
        If editFlag Then
            tsbText.Text = "Pages not required"
        End If
    End Sub
    '-----------------------------------------text pages keypressed------------------------------------------------------------
    Private Sub txtPages_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPages.KeyPress
        Select Case e.KeyChar
            Case "0"c To "9"c ' does not allow letters to be entered for pages 

            Case "."c
                If txtPrice.Text.IndexOf("."c) <> -1 And txtPrice.SelectionLength _
                        = 0 Then e.Handled = True
            Case ControlChars.Back

            Case Else
                e.Handled = True

        End Select
    End Sub

    '-------------------------------------------------Pages TextBox Leave---------------------------------------------------------------
    Private Sub txtPages_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        tsbText.Text = ""
    End Sub

    '----------------------------------------------------------Year Published TextBox Enter----------------------------------------------------------------
    Private Sub txtYearPub_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYearPub.Enter
        If editFlag Then
            tsbText.Text = "Enter a year between 1900 and 2012 or leave blank"
        End If
    End Sub
    '----------------------------------------------------------YearPulished TextBox Leave----------------------------------------------------------------

    Private Sub txtYearPub_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYearPub.Leave
        tsbText.Text = ""
    End Sub
    '----------------------------------------------------------Price Text Box Enter----------------------------------------------------------------
    Private Sub txtPrice_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.Enter
        If editflag Then
            tsbText.Text = "Price is requied"
        End If
    End Sub
    '----------------------------------------------------------Price TextBox Leave----------------------------------------------------------------
    Private Sub txtPrice_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.Leave
        tsbText.Text = "" ' sets the text to blank after user clicks away 
    End Sub

    Private Sub txtTitle_Enter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTitle.Enter
        If editFlag Then
            tsbText.Text = "Title Required" ' changes text to let the user know title is required 
        End If
    End Sub
    '---------------------------------------------------------txtTitleLeave---------------------------------------------------------------

    Private Sub txtTitle_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTitle.Leave
        tsbText.Text = ""
    End Sub
    '---------------------------------------------------------txtISBNLeave---------------------------------------------------------------

    Private Sub txtISBN_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtISBN.Leave
        tsbText.Text = ""
    End Sub
    '---------------------------------------------------------textPagesLeave---------------------------------------------------------------
    Private Sub txtPages_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPages.Leave
        tsbText.Text = ""
    End Sub
    '---------------------------------------------------------txtSubectLeave---------------------------------------------------------------
    Private Sub txtSubject_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubject.Leave
        tsbText.Text = ""
    End Sub
    '---------------------------------------------------------txtDescriptionEnter---------------------------------------------------------------
    Private Sub txtDescription_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.Enter
        If editFlag Then
            tsbText.Text = "Description not required" ' Tells user description is not required 
        End If
    End Sub
    '---------------------------------------------------------textDescription leave---------------------------------------------------------------
    Private Sub txtDescription_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.Leave
        tsbText.Text = ""
    End Sub
    '---------------------------------------------------------SaveClick---------------------------------------------------------------

    Private Sub btnSaveIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveIt.Click

        Try
            Dim validBool As Boolean
            Dim drow As _books_Fall2012_A3DataSet.TitlesRow

            Dim dpubInt As Integer
            validBool = validateIt() ' if validation is true then..
            If validBool = True And addflag = False Then ' case when editing an exisitng row and saving it 
                bottomButtonChange(True)
                editFlag = False
                buttonChange()
                enableEdit(False)
                drow = _books_Fall2012_A3DataSet.Titles(bookmark)
                dpubInt = drow.PubID

                drow.Title = txtTitle.Text
                If txtDescription.Text = "" Then ' checks to see if there is an empty string for certain boxes, and sets them to null acordingly 
                    drow.SetDescriptionNull()
                Else
                    drow.Description = txtDescription.Text
                End If

                drow.ISBN = txtISBN.Text

                If txtSubject.Text = "" Then
                    drow.SetSubjectNull()
                Else
                    drow.Subject = txtSubject.Text
                End If

                If txtYearPub.Text = "" Then
                    drow.SetYear_PublishedNull()
                Else
                    drow.Year_Published = CShort(txtYearPub.Text)
                End If

                drow.PubID = CInt(cboPublisher.SelectedValue)

                TitlesTableAdapter1.Update(_books_Fall2012_A3DataSet)


            ElseIf validBool = True And addflag = True Then ' case when adding a new row and saving it 
                bottomButtonChange(True)
                editFlag = False

                enableEdit(False) ' editing is not allowed after clicking save 

                Dim newRow As _books_Fall2012_A3DataSet.TitlesRow
                newRow = _books_Fall2012_A3DataSet.Titles.NewTitlesRow ' new title row for adding 

                newRow.Title = txtTitle.Text
                If txtDescription.Text = "" Then ' again checking to see if certain texts are empty and setting them to null for the dataset 
                    newRow.SetDescriptionNull()
                Else
                    newRow.Description = txtDescription.Text
                End If

                newRow.ISBN = txtISBN.Text

                If txtSubject.Text = "" Then
                    newRow.SetSubjectNull()
                Else
                    newRow.Subject = txtSubject.Text
                End If

                If txtYearPub.Text = "" Then
                    newRow.SetYear_PublishedNull()
                Else
                    newRow.Year_Published = CShort(txtYearPub.Text)
                End If

                newRow.PubID = CInt(cboPublisher.SelectedValue) ' sets the pub id of the new book 
                _books_Fall2012_A3DataSet.Titles.AddTitlesRow(newRow) ' adds the titles row 

                TitlesTableAdapter1.Update(_books_Fall2012_A3DataSet) ' updates teh dataset 
                addflag = False
                bookmark = _books_Fall2012_A3DataSet.Titles.Count - 1

                buttonChange() ' updating the buttons accordingly 
                tsslCount.Text = "Book #: " & bookmark + 1 & " of " & _books_Fall2012_A3DataSet.Titles.Count
            End If





            stsRequired.Visible = False ' nolonger visible 

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    '---------------------------------------------------------editClick---------------------------------------------------------------
    Private Sub btnEditIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditIt.Click
        editFlag = True ' flag is true 
        bottomButtonChange(False) ' sets the bottom buttons 
        buttonChange() ' sets the top buttons 
        enableEdit(True) ' allows the edits 
        stsRequired.Visible = True
    End Sub
End Class
