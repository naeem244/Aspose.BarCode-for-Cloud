using System;
using Com.Aspose.Barcode.Api;
using Com.Aspose.Barcode.Model;

namespace CSharp.GeneratingSaving.CloudStorage
{
    class GenerateBarcodeAndSaveImageToLocalDisk
    {
        public static void Run()
        {

            // ExStart:1
            // Instantiate Aspose BarCode Cloud API SDK
            BarcodeApi barcodeApi = new BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Set Filename of image
            String name = "sample-barcode";

            // Set Text to encode inside barcode
            String text = "Aspose.BarCode";

            // Set Barcode Symbology
            String type = "QR";
            
            // Set Barcode Image Format
            String format = "PNG";

            // Sets if checksum will be added to barcode image.
            String enableChecksum = "NO";

            //Set optional params (if any) 
            float? resolutionX = 96.0f;
            float? resolutionY = 96.0f;
            float? dimensionX = 0.7f;
            float? dimensionY = 2.0f;
            
            try
            {
                //invoke Aspose.BarCode Cloud SDK API to create barcode and save image to a stream
                ResponseMessage apiResponse = barcodeApi.GetBarcodeGenerate(text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, enableChecksum);

                if (apiResponse != null)
                {
                    //download generated barcode from api response
                    System.IO.File.WriteAllBytes(Common.OUTFOLDER + name + "." + format, apiResponse.ResponseStream);
                    Console.WriteLine("Generate a Barcode and Save Image to Local Disk, Done!");
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
