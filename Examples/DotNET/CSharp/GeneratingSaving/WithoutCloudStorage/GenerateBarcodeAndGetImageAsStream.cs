using System;
using Com.Aspose.Barcode.Api;
using Com.Aspose.Barcode.Model;

namespace CSharp.GeneratingSaving.CloudStorage
{
    class GenerateBarcodeAndGetImageAsStream
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
            String type = "datamatrix";
            
            // Set Barcode Image Format
            String format = "PNG";

            // Sets if checksum will be added to barcode image.
            String enableChecksum = null;

            //Set optional params (if any) 
            float? resolutionX = null;
            float? resolutionY = null;
            float? dimensionX = null;
            float? dimensionY = null;
            
            try
            {
                //invoke Aspose.BarCode Cloud SDK API to create barcode and save image to a stream
                ResponseMessage apiResponse = barcodeApi.GetBarcodeGenerate(text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, enableChecksum);

                if (apiResponse != null)
                {
                    //download generated barcode from api response
                    System.IO.File.WriteAllBytes(Common.OUTFOLDER + name + "." + format, apiResponse.ResponseStream);
                    Console.WriteLine("Generate a Barcode and Get as a Image Stream, Done!");
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
