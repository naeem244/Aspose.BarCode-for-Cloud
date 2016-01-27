# Aspose.BarCode Cloud SDK for Node.js

This repository contains Aspose.BarCode Cloud SDK for Node.js source code. This SDK allows you to work with Aspose.BarCode Cloud REST APIs in your Node.js applications quickly and easily. 

## How to use the SDK?

The complete source code is available in this repository folder. For more details, please visit our [documentation website](http://www.aspose.com/docs/display/barcodecloud/How+to+Setup+Aspose.BarCode+Cloud+SDK+for+Node.js).

## Quick SDK Tutorial
```javascript
var fs = require('fs');
var assert = require('assert');
var BarcodeApi = require('asposebarcodecloud');

var AppSID = 'XXX'; //sepcify App SID
var AppKey = 'XXX'; //sepcify App Key
var config = {'appSid':AppSID,'apiKey':AppKey};
var data_path = '../data/';

try {
//Instantiate Aspose.BarCode API SDK
var barcodeApi = new BarcodeApi(config);

//set input file name
var text= "Aspose.BarCode for Cloud";
var type= "qr";
var format= "png";

//invoke Aspose.BarCode Cloud SDK API to create barcode and save image to a stream  
barcodeApi.GetBarcodeGenerate(text, type, format, null, null, null, null, null, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			//download generated barcode from api response
			var outfilename = name + "." + format;
			var writeStream = fs.createWriteStream('c:/temp/' + outfilename);
			writeStream.write(responseMessage.body);
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
```