Imports Com.Aspose.Storage.Api
Imports Com.Aspose.Barcode.Api
Imports Com.Aspose.Barcode.Model


Namespace GeneratingSaving.CloudStorage

    Class GenerateBarcodewithAppropriateCodeTextLocation

        Public Shared Sub Run()

            'ExStart:1

            'Instantiate Aspose Storage Cloud API SDK
            Dim storageApi As New StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH)

            'Instantiate Aspose BarCode Cloud API SDK
            Dim barcodeApi As New BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH)

            'Set the barcode file name created on server
            Dim name As [String] = "sample-barcode"

            'Set Text to encode inside barcode
            Dim text As [String] = "AsposeBarCode"

            'Set Barcode Symbology
            Dim type As [String] = "Code128"

            'Set Generated Barcode Image Format
            Dim format As [String] = "png"

            'Set Resolution along X and Y in dpi
            Dim resolutionX As System.Nullable(Of Single) = Nothing
            Dim resolutionY As System.Nullable(Of Single) = Nothing

            'Set Width and Height of barcode unit
            Dim dimensionX As System.Nullable(Of Single) = Nothing
            Dim dimensionY As System.Nullable(Of Single) = Nothing

            'Set Location, Measurement  of the code
            Dim codeLocation As [String] = "Above"
            Dim grUnit As [String] = "mm"

            'Set if barcode's size will be updated automatically
            Dim autoSize As [String] = "true"

            'Height of the bar
            Dim barHeight As System.Nullable(Of Single) = Nothing

            'Set height, Width and quality of the image
            Dim imageHeight As System.Nullable(Of Single) = Nothing
            Dim imageWidth As System.Nullable(Of Single) = Nothing
            Dim imageQuality As [String] = "default"

            'Set Angle of barcode orientation
            Dim rotAngle As System.Nullable(Of Single) = Nothing

            'Set Margin of image border
            Dim topMargin As System.Nullable(Of Single) = Nothing
            Dim bottomMargin As System.Nullable(Of Single) = Nothing
            Dim leftMargin As System.Nullable(Of Single) = Nothing
            Dim rightMargin As System.Nullable(Of Single) = Nothing

            'Set if checksum will be added to barcode image
            Dim enableChecksum As [String] = ""

            'Set 3rd party cloud storage server (if any)
            Dim storage As [String] = ""

            'Set folder location at cloud storage
            Dim folder As [String] = ""

            'Set local file (if any)
            Dim file As Byte() = Nothing

            Try

                'invoke Aspose.BarCode Cloud SDK API to generate barcode with appropriate code text location and put in cloud storage
                Dim apiResponse As SaaSposeResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, _
                 dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, _
                 imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, _
                 leftMargin, rightMargin, enableChecksum, storage, folder, file)

                If apiResponse IsNot Nothing Then
                    'download generated barcode from cloud storage
                    Dim storageRes As Com.Aspose.Storage.Model.ResponseMessage = storageApi.GetDownload(name, Nothing, Nothing)
                    System.IO.File.WriteAllBytes(Common.OUTFOLDER + name + "." + format, storageRes.ResponseStream)
                    Console.WriteLine("Generate Barcode with Appropriate Code Text Location, Done!")
                End If

            Catch ex As Exception

                Console.WriteLine("error:" + ex.Message + vbLf + ex.StackTrace)
            End Try
            'ExEnd:1
        End Sub
    End Class
End Namespace
