'Program: Mobile Phone Purchase
'Devloper: Mohammed Habiby
'Date: April 7, 2014
'Purpose: the business class for mobile phone purchase
'        calculates the cost of the phone when the user select internet shoping
'        it is also cause the cost phone file to be written


Option Strict On
Public Class InternetShopping
    Inherits inStoreShopping

    Dim objPhoneCostFile As PhoneCostsFile

    Sub New(ByVal LastName As String, ByVal StreetAddress As String, ByVal PhoneChoice As Integer, _
             ByVal ZipCode As String, ByVal ChargerStyle As Integer)

        'this subprocedure is a constractor for the InternetShopping Class. It is called when
        'instantiated with arguments

        MyBase.New(LastName, StreetAddress, PhoneChoice, ZipCode, ChargerStyle)

    End Sub


    Public Overrides Function ComputeTotal() As Decimal

        'this frunction computes the the phone cost for users who selected internet shoping, writes a record 
        'in the phone  costs file, and returns the phone costs

        _decTotal = decPhonePrices(_intPhoneChoice) + decChargerPrices(_intChargerStyle)

        _decFinalTotal += _decTotal + 28


        'write a phone cost record
        objPhoneCostFile = New PhoneCostsFile(_strLastname, _
                                                    _strStreetAdress, _intChargerStyle, _
                                                    _strZipCode, _intChargerStyle, _decFinalTotal)
        objPhoneCostFile.WriteRecord()


        Return _decFinalTotal

        'Returns the calculated cost
    End Function

    

End Class
