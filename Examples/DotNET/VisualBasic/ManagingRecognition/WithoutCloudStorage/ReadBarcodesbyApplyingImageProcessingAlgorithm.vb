Imports Com.Aspose.Storage.Api
Imports Com.Aspose.Barcode.Api
Imports Com.Aspose.Barcode.Model


Namespace ManagingRecognition.WithoutCloudStorage

    Class ReadBarcodesbyApplyingImageProcessingAlgorithm

        Public Shared Sub Run()

            'ExStart:1

            'Instantiate Aspose Storage Cloud API SDK
            Dim storageApi As New StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH)

            'Instantiate Aspose BarCode Cloud API SDK
            Dim barcodeApi As New BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH)

            'Set input file name
            Dim name As [String] = "sample-barcode.jpeg"

            'The barcode type.
            'If this parameter is empty, autodetection of all supported types is used.
            Dim type As [String] = ""

            'Set folder location at cloud storage
            Dim folder As [String] = ""

            Dim body As New BarcodeReader()

            'Set if FNC symbol stripping should be performed.
            body.StripFNC = True

            'Set mode for checksum validation during recognition
            body.ChecksumValidation = "OFF"

            'Set special mode of barcode binarization
            body.BinarizationHints = BinarizationHints.ComplexBackground

            Try

                'Upload files to aspose cloud storage
                storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir + name))

                'invoke Aspose.BarCode Cloud SDK API to recognition of a barcode by apply various available image processing algorithms
                Dim apiResponse As BarcodeResponseList = barcodeApi.PutBarcodeRecognizeFromBody(name, type, folder, body)

                If apiResponse IsNot Nothing Then

                    For Each barcode As Barcode In apiResponse.Barcodes
                        Console.WriteLine("Codetext: " + barcode.BarcodeValue + vbLf & "Type: " + barcode.BarcodeType)
                    Next
                    Console.WriteLine("Read Barcodes by Applying Image Processing Algorithm, Done!")
                End If

            Catch ex As Exception

                Console.WriteLine("error:" + ex.Message + vbLf + ex.StackTrace)
            End Try
            'ExEnd:1
        End Sub
    End Class
End Namespace
