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

//Instantiate Aspose.BarCode API SDK
var barcodeApi = new BarcodeApi(config);

//Set the barcode file name url
var url = "http://www.barcoding.com/images/Barcodes/code93.gif";

try {
		
	//invoke Aspose.BarCode Cloud SDK API to read barcode from external image URL        
	barcodeApi.PostBarcodeRecognizeFromUrlorContent(null, null, null, null, url, null, function(responseMessage) {		
		assert.equal(responseMessage.status, 'OK');
		responseMessage.body.Barcodes.forEach(function(barcode) {
			console.log("Type :: " + barcode.BarcodeType);
			console.log("Codetext :: " + barcode.BarcodeValue);
		});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1