Imports System.Collections.Generic
Imports System.IO
Imports System.Configuration
Imports VisualBasic.GeneratingSaving.CloudStorage
Imports VisualBasic.GeneratingSaving.WithoutCloudStorage
Imports VisualBasic.ManagingRecognition.CloudStorage
Imports VisualBasic.ManagingRecognition.WithoutCloudStorage


Module RunExamples

    Sub Main()
        Console.WriteLine("Open RunExamples.cs. In Main() method, Un-comment the example that you want to run")
        Console.WriteLine("=====================================================")

        ' Un-comment the one you want to try out

        '' =====================================================
        '' =====================================================
        '' GeneratingSaving - CloudStorage
        '' =====================================================
        '' =====================================================

        'CreateBarcodeAndSaveAsposeCloudStorage.Run()
        'GenerateBarcodewithAppropriateCodeTextLocation.Run()
        'GenerateBarcodewithChecksumOption.Run()
        'RotateBarcodeImagewithSuitableAngle.Run()
        'SetBarcodeImageHeightWidthQualitySettings.Run()
        'SetBarcodeImageMargin.Run()
        'SetBarcodeImageResolution.Run()
        'SetBarsHeightInBarcodeImage.Run()
        'SetXAndYDimensionsOfBarcode.Run()
        'SpecifyBarcodeImageSaveFormat.Run()
        'SpecifyCodetextAndSymbologyForBarcode.Run()

        '' =====================================================
        '' =====================================================
        '' GeneratingSaving - WithoutCloudStorage
        '' =====================================================
        '' =====================================================

        'GenerateBarcodeAndGetImageAsStream.Run()
        'GenerateBarcodeAndSaveImageToLocalDisk.Run()

        '' =====================================================
        '' =====================================================
        '' ManagingRecognition - CloudStorage
        '' =====================================================
        '' =====================================================

        'ReadBarcodeFromAsposeCloudStorage.Run()
        'ReadBarcodeFromSpecificRegionOfImage.Run()
        'RecognizeSpecifiedcountOfBarcodes.Run()


        '' =====================================================
        '' =====================================================
        '' ManagingRecognition - WithoutCloudStorage
        '' =====================================================
        '' =====================================================

        'ReadBarcodeFromExternalImageURL.Run()
        'ReadBarcodeFromLocalFile.Run()
        'ReadBarcodesbyApplyingImageProcessingAlgorithm.Run()
        ReadBarcodesWithChecksum.Run()

        ' Stop before exiting
        Console.WriteLine(vbLf & vbLf & "Program Finished. Press any key to exit....")
        Console.ReadKey()
    End Sub

End Module

