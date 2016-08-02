var fs = require('fs');
var assert = require('assert');
var BarcodeApi = require('asposebarcodecloud');

var configProps = require('../../data/config.json');
var data_path = './data/';

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var outFolder = configProps.out_folder;

// ExStart:1
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};

//Instantiate Aspose.BarCode API SDK
var barcodeApi = new BarcodeApi(config);

// Set Filename of image
var name = "sample-barcode";

// Set Text to encode inside barcode
var text = "Aspose.BarCode for Cloud";

// Set Barcode Symbology
var type = "datamatrix";

// Set Barcode Image Format
var format = "PNG";

try {
	//invoke Aspose.BarCode Cloud SDK API to create barcode and save image to a stream        
	barcodeApi.GetBarcodeGenerate(text, type, format, null, null, null, null, null, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			//download generated barcode from api response
			var outfilename = name + "." + format;
			var writeStream = fs.createWriteStream(outFolder + outfilename);
			writeStream.write(responseMessage.body);
				
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1