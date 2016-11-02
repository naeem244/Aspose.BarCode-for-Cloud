using Com.Aspose.Barcode.Api;
using Com.Aspose.Barcode.Model;
using Com.Aspose.Storage.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BarcodeTest
{
    
    
    /// <summary>
    ///This is a test class for TestBarcodeApi and is intended
    ///to contain all TestBarcodeApi Unit Tests
    ///</summary>
    [TestClass()]
    public class TestBarcodeApi
    {
        protected string APIKEY = "xxxx";
        protected string APPSID = "xxxx";
        protected string BASEPATH = "http://api.aspose.com/v1.1";

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetBarcodeGenerate
        ///</summary>
        [TestMethod()]
        public void TestGetBarcodeGenerate()
        {
            BarcodeApi target = new BarcodeApi(APIKEY, APPSID, BASEPATH);
            
            string text = "TestGetBarcodeGenerate";
            string type = "1";
            string format = "jpeg";
            float? resolutionX = null;
            float? resolutionY = null;
            float? dimensionX = null;
            float? dimensionY = null;
            string enableChecksum = "";
            
            ResponseMessage actual;
            actual = target.GetBarcodeGenerate(text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, enableChecksum);

            Assert.AreEqual(200, actual.Code);
            Assert.IsInstanceOfType(new ResponseMessage(), actual.GetType()); 
        }

        /// <summary>
        ///A test for GetBarcodeRecognize
        ///</summary>
        [TestMethod()]
        public void TestGetBarcodeRecognize()
        {
            BarcodeApi target = new BarcodeApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);


            string name = "Signature.png";
            string type = "";
            string checksumValidation = "";
            bool? stripFnc = null;
            int? rotationAngle = null;
            int? barcodesCount = null;
            int? rectX = null;
            int? rectY = null;
            int? rectWidth = null;
            int? rectHeight = null;
            string storage = "";
            string folder = "";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\barcode\\resources\\" + name)); 
            
            BarcodeResponseList actual;
            actual = target.GetBarcodeRecognize(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, rectX, rectY, rectWidth, rectHeight, storage, folder);

            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new BarcodeResponseList(), actual.GetType()); 
        }
        
        /// <summary>
        ///A test for PostGenerateMultiple
        ///</summary>
        [TestMethod()]
        public void TestPostGenerateMultiple()
        {
            BarcodeApi target = new BarcodeApi(APIKEY, APPSID, BASEPATH);
                        
            string format = "png";
            BarcodeBuilders body = new BarcodeBuilders();

            BarcodeBuilder barcodeBuilder1 = new BarcodeBuilder();
            barcodeBuilder1.TypeOfBarcode = "qr";
            barcodeBuilder1.Text = "The Latest barcode";

            BarcodeBuilder barcodeBuilder2 = new BarcodeBuilder();
            barcodeBuilder2.TypeOfBarcode = "qr";
            barcodeBuilder2.Text = "The Latest barcode";

            body.BarcodeBuilderList = new System.Collections.Generic.List<BarcodeBuilder> { barcodeBuilder1, barcodeBuilder2 };

                        
            ResponseMessage actual;
            actual = target.PostGenerateMultiple(format, body);
            Assert.AreEqual(200, actual.Code);
            Assert.IsInstanceOfType(new ResponseMessage(), actual.GetType()); 
        }

        /// <summary>
        ///A test for PutBarcodeGenerateFile
        ///</summary>
        [TestMethod()]
        public void TestPutBarcodeGenerateFile()
        {
            BarcodeApi target = new BarcodeApi(APIKEY, APPSID, BASEPATH);
            

            string name = "testbar.png";
            string text = "Aspose.Barcode for Cloud";
            string type = "qr";
            string format = "";
            float? resolutionX = null;
            float? resolutionY = null;
            float? dimensionX = null;
            float? dimensionY = null;
            string codeLocation = "";
            string grUnit = "";
            string autoSize = "";
            float? barHeight = null;
            float? imageHeight = null;
            float? imageWidth = null;
            string imageQuality = "";
            float? rotAngle = null;
            float? topMargin = null;
            float? bottomMargin = null;
            float? leftMargin = null;
            float? rightMargin = null;
            string enableChecksum = "";
            string storage = "";
            string folder = "";
            byte[] file = null;
            
            SaaSposeResponse actual;
            actual = target.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file);
            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        }

        /// <summary>
        ///A test for PutBarcodeRecognizeFromBody
        ///</summary>
        [TestMethod()]
        public void TestPutBarcodeRecognizeFromBody()
        {
            BarcodeApi target = new BarcodeApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);


            string name = "Signature.png";
            string type = "";
            string folder = "";
            BarcodeReader body = new BarcodeReader();
            body.StripFNC = true;
            body.ChecksumValidation = "OFF";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\barcode\\resources\\" + name)); 
            
            BarcodeResponseList actual;
            actual = target.PutBarcodeRecognizeFromBody(name, type, folder, body);
            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new BarcodeResponseList(), actual.GetType()); 
        }

        /// <summary>
        ///A test for PutGenerateMultiple
        ///</summary>
        [TestMethod()]
        public void TestPutGenerateMultiple()
        {
            BarcodeApi target = new BarcodeApi(APIKEY, APPSID, BASEPATH);


            string name = "Signature.png";
            string format = "";
            string folder = "";
            BarcodeBuilders body = new BarcodeBuilders();

            BarcodeBuilder barcodeBuilder1 = new BarcodeBuilder();
            barcodeBuilder1.TypeOfBarcode = "qr";
            barcodeBuilder1.Text = "The Latest barcode";

            BarcodeBuilder barcodeBuilder2 = new BarcodeBuilder();
            barcodeBuilder2.TypeOfBarcode = "qr";
            barcodeBuilder2.Text = "The Latest barcode";

            body.BarcodeBuilderList = new System.Collections.Generic.List<BarcodeBuilder> { barcodeBuilder1, barcodeBuilder2 };
            
            SaaSposeResponse actual;
            actual = target.PutGenerateMultiple(name, format, folder, body);
            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        }

        /// <summary>
        ///A test for PostBarcodeRecognizeFromUrlorContent
        ///</summary>
        [TestMethod()]
        public void TestPostBarcodeRecognizeFromUrlorContent()
        {
            BarcodeApi target = new BarcodeApi(APIKEY, APPSID, BASEPATH);

            string type = "gif";
            string checksumValidation = "";
            bool? stripFnc = false;
            int? rotationAngle = null;
            // Please set valid path, otherwise you will face bad request error.
            string url = "http://www.barcoding.com/images/Barcodes/code93.gif";
            byte[] file = null;

            BarcodeResponseList actual;
            actual = target.PostBarcodeRecognizeFromUrlorContent(type, checksumValidation, stripFnc, rotationAngle, url, file);
            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new BarcodeResponseList(), actual.GetType());
        }
    }
}
