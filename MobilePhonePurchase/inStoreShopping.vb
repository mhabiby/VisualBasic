
'Program: Mobile Phone Purchase
'Devloper: Mohammed Habiby
'Date: April 7, 2014
'Purpose: the business class for mobile phone purchase
'        calculates the cost of the phone when the user select in store
'        it is also cause the cost phone file to be written

Option Strict On
Public Class inStoreShopping


    'class variables
    Protected _strLastname As String
    Protected _strStreetAdress As String
    Protected _strZipCode As String
    Protected _intChargerStyle As Integer
    Protected _decTotal As Decimal
    Protected _decFinalTotal As Decimal
    Protected _intPhoneChoice As Integer

    Dim objInStoreShopping As inStoreShopping
    Dim objPhoneCostFile As PhoneCostsFile

    'these arrays will be hold the names and the prices of the phones
    'the values of these arrays will be used by this class and by the InternetShopping class

    Protected decPhonePrices() As Decimal = {CDec(279.81), CDec(193.71), CDec(328.44), CDec(253.72), CDec(479.36)}
    Protected strPhoneChoice() As String = {"Blasstur 451", "Elecque 9801", "Gainlet 3", "Nomadic 2900", "Querta 332"}

    Protected decChargerPrices() As Decimal = {CDec(63.92), CDec(42.66), CDec(27.31)}
    Protected strChargerStyle() As String = {"Auto", "Mobile", "Desktop"}


    Sub New(ByVal LastName As String, ByVal StreetAddress As String, ByVal PhoneChoice As Integer, _
            ByVal ZipCode As String, ByVal ChargerStyle As Integer)

        'this subprocedure is a constarcutor for the InStoreSopping class
        'It is called when the object is intantianted with argumment
        'the follwing code assigns the arguments to class variables

        _strLastname = LastName
        _strStreetAdress = StreetAddress
        _intPhoneChoice = PhoneChoice
        _strZipCode = ZipCode
        _intChargerStyle = ChargerStyle

    End Sub



    Overridable Function ComputeTotal() As Decimal

        'this function computes the in store phone costs, writes a record
        'in the phone cost file, and returns the in store phone  costs

        _decTotal = decPhonePrices(_intPhoneChoice) + decChargerPrices(_intChargerStyle)

        _decFinalTotal = CDec(_decTotal + (_decTotal * 0.0775))

        'write the phone cost and customer infromation record

        objPhoneCostFile = New PhoneCostsFile(_strLastname, _
                                                    _strStreetAdress, _intPhoneChoice, _
                                                    _strZipCode, _intChargerStyle, _decFinalTotal)
        objPhoneCostFile.WriteRecord()


        Return _decFinalTotal

        'Returns the calculated cost
    End Function

End Class


