Imports Com.Aspose.Barcode.Api
Imports Com.Aspose.Barcode.Model


Namespace GeneratingSaving.WithoutCloudStorage

    Class GenerateBarcodeAndSaveImageToLocalDisk

        Public Shared Sub Run()

            'ExStart:1

            'Instantiate Aspose BarCode Cloud API SDK
            Dim barcodeApi As New BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH)

            'Set Filename of image
            Dim name As [String] = "sample-barcode"

            'Set Text to encode inside barcode
            Dim text As [String] = "Aspose.BarCode"

            'Set Barcode Symbology
            Dim type As [String] = "datamatrix"

            'Set Barcode Image Format
            Dim format As [String] = "PNG"

            'Set optional params (if any)
            Dim resolutionX As System.Nullable(Of Single) = 96.0F
            Dim resolutionY As System.Nullable(Of Single) = 96.0F
            Dim dimensionX As System.Nullable(Of Single) = 0.7F
            Dim dimensionY As System.Nullable(Of Single) = 2.0F

            'Set if checksum will be added to barcode image.
            Dim enableChecksum As [String] = "NO"

            Try

                'invoke Aspose.BarCode Cloud SDK API to create barcode and save image to a stream
                Dim apiResponse As ResponseMessage = barcodeApi.GetBarcodeGenerate(text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, enableChecksum)

                If apiResponse IsNot Nothing Then
                    'download generated barcode from api response storage
                    System.IO.File.WriteAllBytes(Common.OUTFOLDER + name + "." + format, apiResponse.ResponseStream)
                    Console.WriteLine("Generate a Barcode and Save Image to Local Disk, Done!")
                End If

            Catch ex As Exception

                Console.WriteLine("error:" + ex.Message + vbLf + ex.StackTrace)
            End Try
            'ExEnd:1
        End Sub
    End Class
End Namespace
