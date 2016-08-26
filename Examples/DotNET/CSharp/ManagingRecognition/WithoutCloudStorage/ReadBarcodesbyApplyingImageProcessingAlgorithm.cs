using System;
using Com.Aspose.Barcode.Api;
using Com.Aspose.Barcode.Model;
using Com.Aspose.Storage.Api;

namespace CSharp.ManagingRecognition.WithoutCloudStorage
{
    class ReadBarcodesbyApplyingImageProcessingAlgorithm
    {
        public static void Run()
        {
            // ExStart:1

            // Instantiate Aspose Storage Cloud API SDK
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Instantiate Aspose BarCode Cloud API SDK
            BarcodeApi barcodeApi = new BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // set input file name
            String name = "sample-barcode.jpeg";

            //The barcode type.
            //If this parameter is empty, autodetection of all supported types is used.
            String type = "";

            // Set folder location at cloud storage
            String folder = "";
            
            BarcodeReader body = new BarcodeReader();

            // Set if FNC symbol stripping should be performed.
            body.StripFNC = true;

            // Set mode for checksum validation during recognition
            body.ChecksumValidation = "ON";

            // Set special mode of barcode binarization
            body.BinarizationHints = BinarizationHints.ComplexBackground;

            try
            {
                //upload source file to aspose cloud storage
                 BarcodeResponseList apiResponse = barcodeApi.PutBarcodeRecognizeFromBody(name, type, folder, body);

                // invoke Aspose.BarCode Cloud SDK API to recognition of a barcode by apply various available image processing algorithms
                 apiResponse = barcodeApi.PutBarcodeRecognizeFromBody(name, type, folder, body);

                if (apiResponse != null)
                {
                    foreach (Barcode barcode in apiResponse.Barcodes)
                    {
                        Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
                    }
                    Console.WriteLine("Read Barcodes by Applying Image Processing Algorithm, Done!");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

            }
            // ExEnd:1
        }
    }
}
