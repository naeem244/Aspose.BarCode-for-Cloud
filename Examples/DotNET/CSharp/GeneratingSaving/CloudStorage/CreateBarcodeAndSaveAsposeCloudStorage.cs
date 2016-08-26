using System;
using Com.Aspose.Barcode.Api;
using Com.Aspose.Barcode.Model;
using Com.Aspose.Storage.Api;

namespace CSharp.GeneratingSaving.CloudStorage
{
    class CreateBarcodeAndSaveAsposeCloudStorage
    {
        public static void Run()
        {

            // ExStart:1
            // Instantiate Aspose Storage Cloud API SDK
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Instantiate Aspose BarCode Cloud API SDK
            BarcodeApi barcodeApi = new BarcodeApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Set the barcode file name created on server.
            String name = "sample-barcode";

            // Set Text to encode inside barcode.
            String text = "AsposeBarCode";

            // Set Barcode Symbology
            String type = "Code128";
            
            // Set Generated Barcode Image Format
            String format = "jpeg";

            // Set Resolution along X and Y in dpi.
            float? resolutionX = null;
            float? resolutionY = null;

            //Set Width and Height of barcode unit
            float? dimensionX = null;
            float? dimensionY = null;

            //Set Location, Measurement  of the code
            String codeLocation = "Below";            
            String grUnit = "mm";

            // Sets if barcode's size will be updated automatically
            String autoSize = "true";

            // Height of the bar.
            float? barHeight = null;

            //Set height, Width and quality of the image.
            float? imageHeight = null;
            float? imageWidth = null;            
            String imageQuality = "default";

            // Set Angle of barcode orientation
            float? rotAngle = null;

            // Set Margin of image border
            float? topMargin = null;
            float? bottomMargin = null;
            float? leftMargin = null;
            float? rightMargin = null;

            // Sets if checksum will be added to barcode image.
            String enableChecksum = "Yes";

            //Set 3rd party cloud storage server (if any)
            String storage = "";
            String folder = "";

            // Set local file (if any)
            byte[] file = null;
            
            try
            {
                // invoke Aspose.BarCode Cloud SDK API to create barcode and put in cloud storage
                SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);
                if (apiResponse != null)
                {
                    // download generated barcode from cloud storage
                    Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name, null, null);

                    //Save response stream to a file 
                    System.IO.File.WriteAllBytes(Common.OUTFOLDER + name + "." + format, storageRes.ResponseStream);
                    Console.WriteLine("Generate a Barcode on Aspose Cloud Storage, Done!");
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
