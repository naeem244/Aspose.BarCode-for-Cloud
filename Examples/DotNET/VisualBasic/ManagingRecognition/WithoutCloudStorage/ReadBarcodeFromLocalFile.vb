Imports Com.Aspose.Barcode.Api
Imports Com.Aspose.Barcode.Model


Namespace ManagingRecognition.WithoutCloudStorage

    Class ReadBarcodeFromLocalFile

        Public Shared Sub Run()

            'ExStart:1

            'Instantiate Aspose BarCode Cloud API SDK
            Dim barcodeApi As New BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH)

            'Set input file name
            Dim name As [String] = "sample-barcode.jpeg"

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
            Dim url As [String] = Nothing

            Dim file As Byte() = System.IO.File.ReadAllBytes(Common.GetDataDir + name)
            Try

                'invoke Aspose.BarCode Cloud SDK API to read barcode from local image
                Dim apiResponse As BarcodeResponseList = barcodeApi.PostBarcodeRecognizeFromUrlorContent(type, checksumValidation, stripFnc, rotationAngle, url, file)

                If apiResponse IsNot Nothing Then

                    For Each barcode As Barcode In apiResponse.Barcodes
                        Console.WriteLine("Codetext: " + barcode.BarcodeValue + vbLf & "Type: " + barcode.BarcodeType)
                    Next
                    Console.WriteLine("Read Barcode from Local Image, Done!")
                End If

            Catch ex As Exception

                Console.WriteLine("error:" + ex.Message + vbLf + ex.StackTrace)
            End Try
            'ExEnd:1
        End Sub
    End Class
End Namespace
