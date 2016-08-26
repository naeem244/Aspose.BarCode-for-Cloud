using System;
using Com.Aspose.Barcode.Api;
using Com.Aspose.Barcode.Model;

namespace CSharp.ManagingRecognition.WithoutCloudStorage
{
    class ReadBarcodeFromLocalFile
    {
        public static void Run()
        {
            // ExStart:1

            // Instantiate Aspose BarCode Cloud API SDK
            BarcodeApi barcodeApi = new BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // set input file name
            String name = "sample-barcode.jpeg";

            //The barcode type.
            //If this parameter is empty, autodetection of all supported types is used.
            String type = "";

            //Set mode for checksum validation during recognition
            String checksumValidation = "";

            //Set if FNC symbol stripping should be performed
            bool stripFnc = false;

            //Set recognition of rotated barcode
            int rotationAngle = 0;

            //Set the image file url 
            String url = null;

            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + name);

            try
            {
                //invoke Aspose.BarCode Cloud SDK API to read barcode from local file
                BarcodeResponseList apiResponse = barcodeApi.PostBarcodeRecognizeFromUrlorContent(type, checksumValidation, stripFnc, rotationAngle, url, file);

                if (apiResponse != null)
                {
                    foreach (Barcode barcode in apiResponse.Barcodes)
                    {
                        Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
                    }
                    Console.WriteLine("Read Barcode from Local File, Done!");

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
