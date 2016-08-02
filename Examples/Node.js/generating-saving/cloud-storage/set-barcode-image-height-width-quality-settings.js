var fs = require('fs');
var assert = require('assert');
var BarcodeApi = require('asposebarcodecloud');
var StorageApi = require('asposestoragecloud');

var configProps = require('../../data/config.json');
var data_path = '../../data/';

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var outFolder = configProps.out_folder;

// ExStart:1
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};

//Instantiate Aspose.Storage API SDK
var storageApi = new StorageApi(config);

//Instantiate Aspose.BarCode API SDK
var barcodeApi = new BarcodeApi(config);

//Set the barcode file name created on server
var name = "sample-barcode";

//Set Text to encode inside barcode
var text = "Aspose.BarCode";

//Set Barcode Symbology
var type = "Code128";

//Set Generated Barcode Image Format
var format = "PNG";

//Set height, Width and quality of the image
imageHeight = 1.0;
imageWidth = 1.0;
imageQuality = "default";

try {
	//invoke Aspose.BarCode Cloud SDK API to generate image with specific height, width, and quality along with auto size option        
	barcodeApi.PutBarcodeGenerateFile(name, text, type, format, null, null, null, null, null, null, null, null, imageHeight, imageWidth, imageQuality, null, null, null, null, null, null, null, null, null, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			//download generated barcode from storage server
			storageApi.GetDownload(name, null, null, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				var outfilename = name + "." + format;
				var writeStream = fs.createWriteStream(outFolder + outfilename);
				writeStream.write(responseMessage.body);
				});      
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}

//ExEnd:1
