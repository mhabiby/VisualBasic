'Program: Mobile Phone Purchase
'Devloper: Mohammed Habiby
'Date: April 7, 2014
'Purpose: this class represents the phone costs file. The written record
'procedure writes a comma-deliminated phone costs file that
'contains the Last Name, Street Adress, Zipe Code and phone Cost.


Option Strict On
Public Class PhoneCostsFile

    'class varables 
    Private _strLastName As String
    Private _strStreetAdress As String
    Private _intPhoneChoice As Integer
    Private _strZipCode As String
    Private _intChargerStyle As Integer
    Private _decPhoneCost As Decimal


    Sub New(ByVal LastName As String, ByVal StreetAdress As String, _
            ByVal PhoneChoice As Integer, ByVal ZipCode As String, _
            ByVal chargerStyle As Integer, ByVal Costs As Decimal)
        'this sub procedure is the constructor for the PhoneCostFile class

        'the following code assigns the arguments to class variables

        _strLastName = LastName
        _strStreetAdress = StreetAdress
        _intPhoneChoice = PhoneChoice
        _strZipCode = ZipCode
        _intChargerStyle = chargerStyle
        _decPhoneCost = Costs
    End Sub

    Sub WriteRecord()

        'this subprocedure opens the PhoneCost output text file and then
        'writes a record in the comma-delimited file

        Dim strNameandLocationOfFile As String = "E:\phonecosts.txt"
        Try
            Dim ObjWriter As IO.StreamWriter = _
            IO.File.AppendText(strNameandLocationOfFile)

            ObjWriter.Write(_strLastName & " ,")
            ObjWriter.Write(_strStreetAdress & " ,")
            ObjWriter.Write(Convert.ToString(_intPhoneChoice) & " ,")
            ObjWriter.Write(_strZipCode & " ,")
            ObjWriter.Write(Convert.ToString(_intChargerStyle) & " ,")
            ObjWriter.WriteLine(_decPhoneCost)
            ObjWriter.Close()

        Catch ex As Exception
            MsgBox("No device available - program aborted ", , "Error")
            Application.Exit()
        End Try
    End Sub


End Class
