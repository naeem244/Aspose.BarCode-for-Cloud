using System;
using Com.Aspose.Barcode.Api;
using Com.Aspose.Barcode.Model;

namespace CSharp.ManagingRecognition.WithoutCloudStorage
{
    class ReadBarcodeFromExternalImageURL
    {
        public static void Run()
        {
            // ExStart:1
            
            // Instantiate Aspose BarCode Cloud API SDK
            BarcodeApi barcodeApi = new BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

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
            String url = "http://www.barcoding.com/images/Barcodes/code93.gif";
            
            byte[] file = null;

            try
            {
                //invoke Aspose.BarCode Cloud SDK API to read barcode from external image URL
                BarcodeResponseList apiResponse = barcodeApi.PostBarcodeRecognizeFromUrlorContent(type, checksumValidation, stripFnc, rotationAngle, url, file);

                if (apiResponse != null)
                {
                    foreach (Barcode barcode in apiResponse.Barcodes)
                    {
                        Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
                    }
                    Console.WriteLine("Read Barcode from External Image URL, Done!");
                    
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
