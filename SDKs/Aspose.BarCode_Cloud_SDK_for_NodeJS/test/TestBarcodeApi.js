var fs = require('fs');
var StorageApi = require('asposestoragecloud');
var BarcodeApi = require('../lib/BarcodeApi');
var assert = require('assert');

var AppSID = 'XXX'; //sepcify App SID
var AppKey = 'XXX'; //sepcify App Key
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};
var data_path = './data/';

var storageApi = new StorageApi(config); 
var barcodeApi = new BarcodeApi(config);
var nodeunit = require('nodeunit');

exports.testGetBarcodeGenerate = function(test){
	
	test.expect(1);
	
	var text= "Aspose for Cloud";
	var type= "qr";
	var format= "png";
			
	barcodeApi.GetBarcodeGenerate(text, type, format, null, null, null, null, null, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			test.equal(responseMessage.status, 'OK', '');
			test.done();
		});
	
};

exports.testPostGenerateMultiple = function(test){
	
	test.expect(1);
	var format = "png";
	var body ={
			'BarcodeBuilders': [
			                    {
			                      'TypeOfBarcode' : 'qr',
			                      'Text': 'NewBarCode'
			                     },
			                     {
			                      'TypeOfBarcode' : 'qr',
			                      'Text': 'Aspose'
			                     }   
			                  ],
			                   'XStep' : 10,
			                   'YStep' : 10
			       };
	
	
	barcodeApi.PostGenerateMultiple(format, body, function(responseMessage) {
				if(config.debug){console.log('status:', responseMessage.status);}				
				test.equal(responseMessage.status, 'OK', '');
				test.done();
			});
	
};


exports.testPostBarcodeRecognizeFromUrlorContent = function(test){
	
	test.expect(2);	
	var url = "http://www.barcoding.com/images/Barcodes/code93.gif";
	
	barcodeApi.PostBarcodeRecognizeFromUrlorContent(null, null, null, null, url, null, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			if(config.debug){console.log('body:', responseMessage.body);}
			test.equal(responseMessage.status, 'OK', '');
			test.ok(responseMessage.body !== null && typeof responseMessage.body.Barcodes !== 'undefined', "response body assertion should pass");
			test.done();
		});
		
};


exports.testPutBarcodeGenerateFile = function(test){
	
	test.expect(1);	
	var name="testbar.png";
	var type="qr";
	var text="Aspose.Barcode for Cloud";
		
	barcodeApi.PutBarcodeGenerateFile(name, text, type, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,  function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			test.equal(responseMessage.status, 'OK', '');
			test.done();
		});
	
};


exports.testPutGenerateMultiple = function(test){
	
	test.expect(1);	
	var name = "newfile.png";
    var file = "sample.txt";
    
	 		
	barcodeApi.PutGenerateMultiple(name, null, null, data_path + file, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			test.equal(responseMessage.status, 'OK', '');
			test.done();
		});
};


exports.testGetBarcodeRecognize = function(test){
	
	test.expect(3);	
	var name = "sample-barcode.jpeg";
	    
	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {	
		test.equal(responseMessage.status, 'OK', '');
		
		barcodeApi.GetBarcodeRecognize(name, null, null, null, null, null, null, null, null, null, null, null, function(responseMessage) {
				if(config.debug){console.log('status:', responseMessage.status);}
				if(config.debug){console.log('body:', responseMessage.body);}
				test.equal(responseMessage.status, 'OK', '');
				test.ok(responseMessage.body !== null && typeof responseMessage.body.Barcodes !== 'undefined', "response body assertion should pass");
				test.done();
			});
	});
};


exports.testPutBarcodeRecognizeFromBody = function(test){
	
	test.expect(3);
    var name = "sample-barcode.jpeg";
    var barcodeReaderBody = {
    		'StripFNC' : true,
    		'ChecksumValidation' : 'OFF'
    };
	
	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
	
		test.equal(responseMessage.status, 'OK', '');		
		barcodeApi.PutBarcodeRecognizeFromBody(name, null, null, barcodeReaderBody, function(responseMessage) {
				if(config.debug){console.log('status:', responseMessage.status);}
				if(config.debug){console.log('body:', responseMessage.body);}
				test.equal(responseMessage.status, 'OK', '');
				test.ok(responseMessage.body !== null && typeof responseMessage.body.Barcodes !== 'undefined', "response body assertion should pass");
				test.done();
			});
		});
};