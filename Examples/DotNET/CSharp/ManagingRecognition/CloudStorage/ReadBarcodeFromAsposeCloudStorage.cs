using System;
using Com.Aspose.Barcode.Api;
using Com.Aspose.Barcode.Model;
using Com.Aspose.Storage.Api;

namespace CSharp.ManagingRecognition.CloudStorage
{
    class ReadBarcodeFromAsposeCloudStorage
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

            //Sets mode for checksum validation during recognition
            String checksumValidation = "";

            //Sets if FNC symbol stripping should be performed. 
            bool stripFnc = true;

            //Sets recognition of rotated barcode
            int? rotationAngle = null;

            //Sets exact number of barcodes to recognize 
            int? barcodesCount = null;

            //Set recognition of barcode inside specified Rectangle region
            int? rectX = null;
            int? rectY = null;
            int? rectWidth = null;
            int? rectHeight = null;
            
            //Set 3rd party cloud storage server (if any)
            String storage = "";

            // Set folder location at cloud storage
            String folder = "";

            try
            {
                //upload source file to aspose cloud storage
                storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

                // invoke Aspose.BarCode Cloud SDK API to read barcode from Aspose Cloud Storage
                BarcodeResponseList apiResponse = barcodeApi.GetBarcodeRecognize(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, rectX, rectY, rectWidth, rectHeight, storage, folder);


                if (apiResponse != null)
                {
                    foreach (Barcode barcode in apiResponse.Barcodes)
                    {
                        Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
                    }
                    Console.WriteLine("Read Barcode from Aspose Cloud Storage, Done!");
                    
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
