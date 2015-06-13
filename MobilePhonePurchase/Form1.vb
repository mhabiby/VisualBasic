
'Program: Mobile Phone Purchase
'Devloper: Mohammed Habiby
'Date: April 7, 2014
'Purpose: this program calculates the cost of the phone purchase by a user 
'        either in store or online shoping


Option Strict On

Imports System.Text.RegularExpressions

Public Class frmMobilePhoneStore

    Private Sub btnCalculateCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateCost.Click

        'this calculate Costs button click event handler edits the
        'frmMobilePhoneStore form to ensure it contains valid data.
        'then, after passing control to business class, it
        'displays the phone cost.


        Dim objInstoreShopping As inStoreShopping
        Dim objInternetShopping As InternetShopping
        Dim inputError As Boolean = False
        Dim Valid As Boolean = False
        'is customer last  name entered properly

        If txtLastName.TextLength < 1 Or _
            txtLastName.Text < "A" Then
            MsgBox("Enter your last name in the customer last name box box", , "Error")
            txtLastName.Clear()
            txtLastName.Focus()
            inputError = True
            'is street adress entered properly
        ElseIf txtStreetAdress.TextLength < 1 Then
            MsgBox("Enter your street adress  in the customer street adress box", , "Error")
            txtStreetAdress.Clear()
            txtStreetAdress.Focus()
            inputError = True
            'is a phone choice selected
        ElseIf cboPhoneChoice.SelectedIndex < 0 Then
            MsgBox("Please select a Phone  ", , "Error")
            cboPhoneChoice.Focus()
            inputError = True
            'is the Zipe Code entered properly
        ElseIf txtZipeCode.MaskFull = False Then
            MsgBox("Enter a valid zipe code in the zipe code box", , _
                   "Error")
            txtZipeCode.Clear()
            txtZipeCode.Focus()
            inputError = True
            'is charger style selected
        ElseIf cboChargerStyle.SelectedIndex < 0 Then

            MsgBox("Please select a charger style  ", , "Error")
            cboChargerStyle.Focus()
            inputError = True
            
        End If

        'is email address entered properly

        Try
            Valid = Regex.IsMatch(txtEmail.Text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)
        Catch ex As Exception
        End Try
        If Not Valid Then
            MsgBox("invalid Email Address")
            txtEmail.Clear()
        Else
            MsgBox("Valid email")
        End If



        'if no input error, process the the frmMobilePhoneStore
        If Not inputError Then


            If radInStore.Checked Then
                objInstoreShopping = New inStoreShopping(txtLastName.Text, _
                                                         txtStreetAdress.Text, (Convert.ToInt32(cboPhoneChoice.SelectedIndex)), _
                                                         CStr((Convert.ToInt32(txtZipeCode.Text))), (Convert.ToInt32(cboChargerStyle.SelectedIndex)))

                lblCots.Visible = True
                lblCots.Text = "The cost of the phone is:  " _
                    & (objInstoreShopping.ComputeTotal()).ToString("C2")


            ElseIf radInternet.Checked Then
                objInternetShopping = New InternetShopping(txtLastName.Text, _
                                                           txtStreetAdress.Text, (Convert.ToInt32(cboPhoneChoice.SelectedIndex)), _
                                                         CStr((Convert.ToInt32(txtZipeCode.Text))), (Convert.ToInt32(cboChargerStyle.SelectedIndex)))


                lblCots.Visible = True
                lblCots.Text = "The cost of the phone is:  " _
                    & (objInternetShopping.ComputeTotal()).ToString("C2")


            End If

        End If

    End Sub

    Private Sub btnClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click

        'this event is executed when user clicks the
        'clear form button. it resets all objects in the user interface

        txtLastName.Clear()
        txtStreetAdress.Clear()
        txtZipeCode.Clear()
        txtEmail.Clear()
        cboChargerStyle.SelectedIndex = -1
        cboPhoneChoice.SelectedIndex = -1
        cboPhoneChoice.Text = "Select a phone"
        cboChargerStyle.Text = "select a charger"
        radInStore.Checked = True
        radInternet.Checked = True
        grpTypeOfBuyer.Visible = True
        lblCots.Visible = False
        txtLastName.Focus()

    End Sub



    Private Sub cboPhoneChoice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPhoneChoice.SelectedIndexChanged
        Dim _intPhoneChoice As Integer
        _intPhoneChoice = Me.cboPhoneChoice.SelectedIndex
    End Sub
    Private Sub cboChargerStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChargerStyle.SelectedIndexChanged
        Dim _intChargerStyle As Integer
        _intChargerStyle = Me.cboChargerStyle.SelectedIndex
    End Sub
End Class
