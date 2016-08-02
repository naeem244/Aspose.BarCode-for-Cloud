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

//Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);

//Instantiate Aspose.BarCode API SDK
var barcodeApi = new BarcodeApi(config);

//Set the barcode file name
var name = "sample-barcode.jpeg";

//Set BarcodeReader object with mode for checksum validation during recognition
var barcodeReaderBody = {
		'StripFNC' : true,
		'BinarizationHints' : 'ComplexBackground',
		'checksumValidation' : 'On'
};

try {
	//upload file to aspose cloud storage
	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {	
		assert.equal(responseMessage.status, 'OK');
		
		//invoke Aspose.BarCode Cloud SDK API to recognition of a barcode from file on server with parameters in body        
		barcodeApi.PutBarcodeRecognizeFromBody(name, null, null, barcodeReaderBody, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			responseMessage.body.Barcodes.forEach(function(barcode) {
				console.log("Type :: " + barcode.BarcodeType);
				console.log("Codetext :: " + barcode.BarcodeValue);
			});
		});		
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1