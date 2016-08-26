Imports Com.Aspose.Storage.Api
Imports Com.Aspose.Barcode.Api
Imports Com.Aspose.Barcode.Model


Namespace ManagingRecognition.CloudStorage

    Class ReadBarcodeFromAsposeCloudStorage

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

            'Set mode for checksum validation during recognition
            Dim checksumValidation As [String] = ""

            'Set if FNC symbol stripping should be performed. 
            Dim stripFnc As Boolean = True

            'Set recognition of rotated barcode
            Dim rotationAngle As System.Nullable(Of Integer) = Nothing

            'Sets exact number of barcodes to recognize 
            Dim barcodesCount As System.Nullable(Of Integer) = Nothing

            'Set recognition of barcode inside specified Rectangle region
            Dim rectX As System.Nullable(Of Integer) = Nothing
            Dim rectY As System.Nullable(Of Integer) = Nothing
            Dim rectWidth As System.Nullable(Of Integer) = Nothing
            Dim rectHeight As System.Nullable(Of Integer) = Nothing

            'Set 3rd party cloud storage server (if any)
            Dim storage As [String] = ""

            'Set folder location at cloud storage
            Dim folder As [String] = ""

            Try

                'Upload files to aspose cloud storage
                storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir + name))

                'invoke Aspose.BarCode Cloud SDK API to read barcode from Aspose Cloud Storage
                Dim apiResponse As BarcodeResponseList = barcodeApi.GetBarcodeRecognize(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, _
                 rectX, rectY, rectWidth, rectHeight, storage, folder)

                If apiResponse IsNot Nothing Then

                    For Each barcode As Barcode In apiResponse.Barcodes
                        Console.WriteLine("Codetext: " + barcode.BarcodeValue + vbLf & "Type: " + barcode.BarcodeType)
                    Next
                    Console.WriteLine("Read Barcode from Aspose Cloud Storage, Done!")
                End If

            Catch ex As Exception

                Console.WriteLine("error:" + ex.Message + vbLf + ex.StackTrace)
            End Try
            'ExEnd:1
        End Sub
    End Class
End Namespace
