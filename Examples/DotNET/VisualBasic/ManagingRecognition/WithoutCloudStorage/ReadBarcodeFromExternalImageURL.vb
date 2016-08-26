Imports Com.Aspose.Barcode.Api
Imports Com.Aspose.Barcode.Model


Namespace ManagingRecognition.WithoutCloudStorage

    Class ReadBarcodeFromExternalImageURL

        Public Shared Sub Run()

            'ExStart:1

            'Instantiate Aspose BarCode Cloud API SDK
            Dim barcodeApi As New BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH)

            'The barcode type.
            'If this parameter is empty, autodetection of all supported types is used.
            Dim type As [String] = ""

            'Set mode for checksum validation during recognition
            Dim checksumValidation As [String] = ""

            'Set if FNC symbol stripping should be performed. 
            Dim stripFnc As Boolean = True

            'Set recognition of rotated barcode
            Dim rotationAngle As System.Nullable(Of Integer) = Nothing

            'Set the image file url 
            Dim url As [String] = "http://www.barcoding.com/images/Barcodes/code93.gif"

            Dim file As Byte() = Nothing

            Try

                'invoke Aspose.BarCode Cloud SDK API to read barcode from external image URL
                Dim apiResponse As BarcodeResponseList = barcodeApi.PostBarcodeRecognizeFromUrlorContent(type, checksumValidation, stripFnc, rotationAngle, url, file)

                If apiResponse IsNot Nothing Then

                    For Each barcode As Barcode In apiResponse.Barcodes
                        Console.WriteLine("Codetext: " + barcode.BarcodeValue + vbLf & "Type: " + barcode.BarcodeType)
                    Next
                    Console.WriteLine("Read Barcode from External Image URL, Done!")
                End If

            Catch ex As Exception

                Console.WriteLine("error:" + ex.Message + vbLf + ex.StackTrace)
            End Try
            'ExEnd:1
        End Sub
    End Class
End Namespace
