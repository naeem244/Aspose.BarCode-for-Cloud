using System;
using System.Collections.Generic;
using System.Text;
using Com.Aspose.Barcode.Api;
using Com.Aspose.Storage.Api;
using Com.Aspose.Barcode.Model;
namespace AsposeBarcode
{
    class barcode
    {
        public static void Main(String[] args)
        {

string APIKEY = "xxxxxx";
string APPSID = "xxxxxx";
string BASEPATH = "http://api.aspose.com/v1.1";


///*
//*  Working with Barcode Generation    
//*  Create Barcode and Get Image as Stream 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "Aspose.BarCode";
//String type = "datamatrix";
//String format = "PNG";
//float? resolutionX = null;
//float? resolutionY = null;
//float? dimensionX = null;
//float? dimensionY = null;
//String enableChecksum = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    ResponseMessage apiResponse = barcodeApi.GetBarcodeGenerate(text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, enableChecksum);

//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, apiResponse.ResponseStream);
//        Console.WriteLine("Create Barcode and Get Image as Stream, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      


///*
//*  Working with Barcode Generation    
//*  Create Barcode on Aspose Cloud Storage 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = null;
//float? resolutionY = null;
//float? dimensionX = null;
//float? dimensionY = null;
//String codeLocation = "Below";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = null;
//float? imageHeight = null;
//float? imageWidth = null;
//String imageQuality = "default";
//float? rotAngle = null;
//float? topMargin = null;
//float? bottomMargin = null;
//float? leftMargin = null;
//float? rightMargin = null;
//String enableChecksum = "";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);



//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Create Barcode on Aspose Cloud Storage, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      



///*
//*  Working with Barcode Generation    
//*  Create Barcode and Save Image to Local Disk 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "Aspose.BarCode";
//String type = "QR";
//String format = "PNG";
//float? resolutionX = 96.0f;
//float? resolutionY = 96.0f;
//float? dimensionX = 0.7f;
//float? dimensionY = 2.0f;

//String enableChecksum = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    ResponseMessage apiResponse = barcodeApi.GetBarcodeGenerate(text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, enableChecksum);

//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, apiResponse.ResponseStream);
//        Console.WriteLine("Create Barcode and Save Image to Local Disk, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      



///*
//*  Working with Barcode Generation    
//*  Set Barcode Image Resolution 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 200.0f;
//float? resolutionY = 200.0f;
//float? dimensionX = 0.0f;
//float? dimensionY = 0.0f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 0.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 0.0f;
//float? topMargin = 0.0f;
//float? bottomMargin = 0.0f;
//float? leftMargin = 0.0f;
//float? rightMargin = 0.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Set Barcode Image Resolution, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      



///*
//*  Working with Barcode Generation    
//*  Set X and Y Dimensions of a Barcode 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 1.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 1.0f;
//float? dimensionY = 0.5f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 0.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 0.0f;
//float? topMargin = 0.0f;
//float? bottomMargin = 0.0f;
//float? leftMargin = 0.0f;
//float? rightMargin = 0.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Set X and Y Dimensions of a Barcode, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}        


///*
//*  Working with Barcode Generation    
//*  Specify Barcode Image Save Format 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 1.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 1.0f;
//float? dimensionY = 0.5f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 0.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 0.0f;
//float? topMargin = 0.0f;
//float? bottomMargin = 0.0f;
//float? leftMargin = 0.0f;
//float? rightMargin = 0.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Specify Barcode Image Save Format, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}


///*
//*  Working with Barcode Generation    
//*  Generate Barcode with Appropriate Code Text Location 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 0.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 0.0f;
//float? dimensionY = 0.0f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 0.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 0.0f;
//float? topMargin = 0.0f;
//float? bottomMargin = 0.0f;
//float? leftMargin = 0.0f;
//float? rightMargin = 0.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Generate Barcode with Appropriate Code Text Location, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}


///*
//*  Working with Barcode Generation    
//*  Generate Barcode with Checksum Option 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 0.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 0.0f;
//float? dimensionY = 0.0f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 0.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 0.0f;
//float? topMargin = 0.0f;
//float? bottomMargin = 0.0f;
//float? leftMargin = 0.0f;
//float? rightMargin = 0.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Generate Barcode with Checksum Option, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}

///*
//*  Working with Barcode Generation    
//*  Rotate Barcode Image with Suitable Angle 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 0.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 0.0f;
//float? dimensionY = 0.0f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 0.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 90.0f;
//float? topMargin = 0.0f;
//float? bottomMargin = 0.0f;
//float? leftMargin = 0.0f;
//float? rightMargin = 0.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Rotate Barcode Image with Suitable Angle, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}


///*
//*  Working with Barcode Generation    
//*  Set Barcode Image Height, Width and Quality along with Auto Size Option 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 0.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 0.0f;
//float? dimensionY = 0.0f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 0.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 90.0f;
//float? topMargin = 0.0f;
//float? bottomMargin = 0.0f;
//float? leftMargin = 0.0f;
//float? rightMargin = 0.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Set Barcode Image Height, Width and Quality along with Auto Size Option, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}  


///*
//*  Working with Barcode Generation    
//*  Set Height of the Bars in the Barcode Image 
//*/


//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 0.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 0.0f;
//float? dimensionY = 0.0f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 50.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 90.0f;
//float? topMargin = 0.0f;
//float? bottomMargin = 0.0f;
//float? leftMargin = 0.0f;
//float? rightMargin = 0.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Set Height of the Bars in the Barcode Image, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}


///*
//*  Working with Barcode Generation    
//*  Set Barcode Image Margin
//*/


//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode";
//String type = "Code128";
//String format = "jpeg";
//float? resolutionX = 0.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 0.0f;
//float? dimensionY = 0.0f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 50.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 90.0f;
//float? topMargin = 2.0f;
//float? bottomMargin = 2.0f;
//float? leftMargin = 2.0f;
//float? rightMargin = 2.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Set Barcode Image Margin, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}     




///*
//*  Working with Barcode Generation    
//*  Specify Codetext and Symbology for barcode
//*/


//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode";
//String text = "AsposeBarCode"; //CodeText
//String type = "Code128"; //symbology
//String format = "jpeg";
//float? resolutionX = 0.0f;
//float? resolutionY = 0.0f;
//float? dimensionX = 0.0f;
//float? dimensionY = 0.0f;
//String codeLocation = "Above";
//String grUnit = "mm";
//String autoSize = "true";
//float? barHeight = 50.0f;
//float? imageHeight = 0.0f;
//float? imageWidth = 0.0f;
//String imageQuality = "default";
//float? rotAngle = 90.0f;
//float? topMargin = 2.0f;
//float? bottomMargin = 2.0f;
//float? leftMargin = 2.0f;
//float? rightMargin = 2.0f;
//String enableChecksum = "Yes";
//String storage = "";
//String folder = "";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(name + "." + format, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + name + "." + format, storageRes.ResponseStream);
//        Console.WriteLine("Specify Codetext and Symbology for barcode, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}     


///*
//*  Working with Barcode Recognition     
//*  Read Barcode from External Image URL
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);

//String type = "";
//String checksumValidation = "";
//bool stripFnc = false;
//int rotationAngle = 0;
//String url = "http://www.barcoding.com/images/Barcodes/code93.gif";
//byte[] file = null;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    BarcodeResponseList apiResponse = barcodeApi.PostBarcodeRecognizeFromUrlorContent(type, checksumValidation, stripFnc, rotationAngle, url, file);


//    if (apiResponse != null)
//    {
//        foreach (Barcode barcode in apiResponse.Barcodes)
//        {
//            Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
//        }

//        Console.WriteLine("Create Barcode and Get Image as Stream, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      


///*
//*  Working with Barcode Recognition     
//*  Read Barcode from Local Image 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode.jpeg";
//String type = "";
//String folder = "";
//BarcodeReader body = new BarcodeReader();
//body.StripFNC = true;
//body.ChecksumValidation = "OFF";

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    BarcodeResponseList apiResponse = barcodeApi.PutBarcodeRecognizeFromBody(name, type, folder, body);

//    if (apiResponse != null)
//    {
//        foreach (Barcode barcode in apiResponse.Barcodes)
//        {
//            Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
//        }
//        Console.WriteLine("Read Barcode from Local Image, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      


///*
//*  Working with Barcode Recognition     
//*  Read Barcode from Aspose Cloud Storage 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "barcodePng.png";
//String type = "";
//String checksumValidation = "";
//bool stripFnc = true;
//int? rotationAngle = null;
//int? barcodesCount = null;
//int? rectX = null;
//int? rectY = null;
//int? rectWidth = null;
//int? rectHeight = null;
//String storage = "";
//String folder = "";

//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes("\\temp\\barcode\\resources\\" + name));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    BarcodeResponseList apiResponse = barcodeApi.GetBarcodeRecognize(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, rectX, rectY, rectWidth, rectHeight, storage, folder);


//    if (apiResponse != null)
//    {
//        foreach (Barcode barcode in apiResponse.Barcodes)
//        {
//            Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
//        }
//        Console.WriteLine("Read Barcode from Aspose Cloud Storage, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      


///*
//*  Working with Barcode Recognition     
//*  Read Barcode from Specific Region of Image 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "barcodePng.png";
//String type = "";
//String checksumValidation = "";
//bool stripFnc = true;
//int? rotationAngle = null;
//int? barcodesCount = null;
//int? rectX = 10;
//int? rectY = 10;
//int? rectWidth = 200;
//int? rectHeight = 200;
//String storage = "";
//String folder = "";

//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes("\\temp\\barcode\\resources\\" + name));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    BarcodeResponseList apiResponse = barcodeApi.GetBarcodeRecognize(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, rectX, rectY, rectWidth, rectHeight, storage, folder);

//    if (apiResponse != null)
//    {
//        foreach (Barcode barcode in apiResponse.Barcodes)
//        {
//            Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
//        }
//        Console.WriteLine("Read Barcode from Specific Region of Image, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      


///*
//*  Working with Barcode Recognition     
//*  Recognize Barcode with Checksum Option from Storage
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode.jpeg";
//String type = "";
//String folder = "";
//BarcodeReader body = new BarcodeReader();
//body.StripFNC = true;
//body.ChecksumValidation = "ON";
//body.BinarizationHints = BinarizationHints.ComplexBackground;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    BarcodeResponseList apiResponse = barcodeApi.PutBarcodeRecognizeFromBody(name, type, folder, body);

//    if (apiResponse != null)
//    {
//        foreach (Barcode barcode in apiResponse.Barcodes)
//        {
//            Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
//        }
//        Console.WriteLine("Recognize Barcode with Checksum Option from Storage, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}   


///*
//*  Working with Barcode Recognition     
//*  Recognize Specified count of Barcodes 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode.jpeg";
//String type = "";
//String checksumValidation = "ON";
//bool stripFnc = true;
//int? rotationAngle = null;
//int? barcodesCount = null;
//int? rectX = null;
//int? rectY = null;
//int? rectWidth = null;
//int? rectHeight = null;
//String storage = "";
//String folder = "";

//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes("\\temp\\barcode\\resources\\" + name));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    BarcodeResponseList apiResponse = barcodeApi.GetBarcodeRecognize(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, rectX, rectY, rectWidth, rectHeight, storage, folder);


//    if (apiResponse != null)
//    {

//        foreach (Barcode barcode in apiResponse.Barcodes)
//        {
//            Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
//        }
//        Console.WriteLine("Read Barcode from Aspose Cloud Storage, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}      



///*
//*  Working with Barcode Recognition     
//*  Recognize Specified count of Barcodes 
//*/

//BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "sample-barcode.jpeg";
//String type = "";
//String checksumValidation = "ON";
//bool stripFnc = true;
//int? rotationAngle = null;
//int? barcodesCount = null;
//int? rectX = null;
//int? rectY = null;
//int? rectWidth = null;
//int? rectHeight = null;
//String storage = "";
//String folder = "";

//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes("\\temp\\barcode\\resources\\" + name));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    BarcodeResponseList apiResponse = barcodeApi.GetBarcodeRecognize(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, rectX, rectY, rectWidth, rectHeight, storage, folder);


//    if (apiResponse != null)
//    {

//        foreach (Barcode barcode in apiResponse.Barcodes)
//        {
//            Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
//        }
//        Console.WriteLine("Recognize Specified count of Barcodes, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}    



/*
*  Working with Barcode Recognition     
*  Read Barcodes by Applying Image Processing Algorithm 
*/

BarcodeApi barcodeApi = new BarcodeApi(APIKEY, APPSID, BASEPATH);
StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

String name = "sample-barcode.jpeg";
String type = "";
String folder = "";
BarcodeReader body = new BarcodeReader();
body.StripFNC = true;
body.ChecksumValidation = "OFF";
body.BinarizationHints = BinarizationHints.ComplexBackground;

try
{
    //upload source file to aspose cloud storage
    storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes("\\temp\\barcode\\resources\\" + name));

    //invoke Aspose.PDF Cloud SDK API to append word document
    BarcodeResponseList apiResponse = barcodeApi.PutBarcodeRecognizeFromBody(name, type, folder, body);

    if (apiResponse != null)
    {
        foreach (Barcode barcode in apiResponse.Barcodes)
        {
            Console.WriteLine("Codetext: " + barcode.BarcodeValue + "\nType: " + barcode.BarcodeType);
        }
        Console.WriteLine("Read Barcodes by Applying Image Processing Algorithm, Done!");
        Console.ReadKey();
    }
}
catch (Exception ex)
{
    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

}      
            


/*
* End...
*/
        }
    }
}
