var path = require('path');
var fs = require('fs');
var querystring = require('querystring');
var apiClient = require('./api-client');


function BarcodeApi(config) {
	var self = this;
	
	apiClient = new apiClient(config);
	this.config = apiClient.config;
}


/**
* GetBarcodeGenerate
* Generate barcode.
*
* @param  (String) text  -  The code text. (optional) 
* @param  (String) type  -  Barcode type. (optional) 
* @param  (String) format  -  Result format. (optional) 
* @param  (String) resolutionX  -  Horizontal resolution. (optional) 
* @param  (String) resolutionY  -  Vertical resolution. (optional) 
* @param  (String) dimensionX  -  Smallest width of barcode unit (bar or space). (optional) 
* @param  (String) dimensionY  -  Smallest height of barcode unit (for 2D barcodes). (optional) 
* @param  (String) enableChecksum  -  Sets if checksum will be generated. (optional) 
* @returns ResponseMessage (Map)
*/
BarcodeApi.prototype.GetBarcodeGenerate = function(text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, enableChecksum, callback) {

    var self = this;
	        	
		
	var resourcePath = '/barcode/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;enableChecksum={enableChecksum}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof text !== 'undefined' &&  text !== null && text!== ''){            
			resourcePath = resourcePath.replace("{" + "text" + "}" , querystring.escape(text));
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]text.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof type !== 'undefined' &&  type !== null && type!== ''){            
			resourcePath = resourcePath.replace("{" + "type" + "}" , type);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]type.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof format !== 'undefined' &&  format !== null && format!== ''){            
			resourcePath = resourcePath.replace("{" + "format" + "}" , format);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]format.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof resolutionX !== 'undefined' &&  resolutionX !== null && resolutionX!== ''){            
			resourcePath = resourcePath.replace("{" + "resolutionX" + "}" , resolutionX);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]resolutionX.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof resolutionY !== 'undefined' &&  resolutionY !== null && resolutionY!== ''){            
			resourcePath = resourcePath.replace("{" + "resolutionY" + "}" , resolutionY);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]resolutionY.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof dimensionX !== 'undefined' &&  dimensionX !== null && dimensionX!== ''){            
			resourcePath = resourcePath.replace("{" + "dimensionX" + "}" , dimensionX);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]dimensionX.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof dimensionY !== 'undefined' &&  dimensionY !== null && dimensionY!== ''){            
			resourcePath = resourcePath.replace("{" + "dimensionY" + "}" , dimensionY);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]dimensionY.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof enableChecksum !== 'undefined' &&  enableChecksum !== null && enableChecksum!== ''){            
			resourcePath = resourcePath.replace("{" + "enableChecksum" + "}" , enableChecksum);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]enableChecksum.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* PostGenerateMultiple
* Generate multiple barcodes and return in response stream
*
* @param  (String) format  -  Format to return stream in (optional) 
* @param  (Body) body  -   (required) 
* @returns ResponseMessage (Map)
*/
BarcodeApi.prototype.PostGenerateMultiple = function(format, body, callback) {

    var self = this;
	 	
	
	if( typeof body === 'undefined' || body === null && body === ''){
		throw new Error('missing required body.');
    }	
	var resourcePath = '/barcode/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof format !== 'undefined' &&  format !== null && format!== ''){            
			resourcePath = resourcePath.replace("{" + "format" + "}" , format);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]format.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'POST'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = JSON.stringify(body);
    
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* PostBarcodeRecognizeFromUrlorContent
* Recognize barcode from an url.
*
* @param  (String) type  -  Barcode type. (optional) 
* @param  (String) checksumValidation  -  Checksum validation parameter. (optional) 
* @param  (Boolean) stripFnc  -  Allows to strip FNC symbol in recognition results. (optional) 
* @param  (String) rotationAngle  -  Recognition of rotated barcode. Possible angles are 90, 180, 270, default is 0 (optional) 
* @param  (String) url  -  The image file url. (optional) 
* @param  (File) file  -   (required) 
* @returns BarcodeResponseList (Map)
*/
BarcodeApi.prototype.PostBarcodeRecognizeFromUrlorContent = function(type, checksumValidation, stripFnc, rotationAngle, url, file, callback) {

    var self = this;
	     	
	
	var resourcePath = '/barcode/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;url={url}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof type !== 'undefined' &&  type !== null && type!== ''){            
			resourcePath = resourcePath.replace("{" + "type" + "}" , type);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]type.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof checksumValidation !== 'undefined' &&  checksumValidation !== null && checksumValidation!== ''){            
			resourcePath = resourcePath.replace("{" + "checksumValidation" + "}" , checksumValidation);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]checksumValidation.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof stripFnc !== 'undefined' &&  stripFnc !== null && stripFnc!== ''){            
			resourcePath = resourcePath.replace("{" + "stripFnc" + "}" , stripFnc);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]stripFnc.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof rotationAngle !== 'undefined' &&  rotationAngle !== null && rotationAngle!== ''){            
			resourcePath = resourcePath.replace("{" + "rotationAngle" + "}" , rotationAngle);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]rotationAngle.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof url !== 'undefined' &&  url !== null && url!== ''){            
			resourcePath = resourcePath.replace("{" + "url" + "}" , url);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]url.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'POST'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	if(file !== 'undefined' && file !== null && file !== ''){
		postData = fs.readFileSync(file)
	}
	
	headerParams['Accept'] = 'application/xml,application/json'
    headerParams['Content-Type'] = 'multipart/form-data'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* PutBarcodeGenerateFile
* Generate barcode and save on server.
*
* @param  (String) name  -  The image name. (required) 
* @param  (String) text  -  Barcode&#39;s text. (optional) 
* @param  (String) type  -  The barcode type. (optional) 
* @param  (String) format  -  The image format. (optional) 
* @param  (String) resolutionX  -  Horizontal resolution. (optional) 
* @param  (String) resolutionY  -  Vertical resolution. (optional) 
* @param  (String) dimensionX  -  Smallest width of barcode unit (bar or space). (optional) 
* @param  (String) dimensionY  -  Smallest height of barcode unit (for 2D barcodes). (optional) 
* @param  (String) codeLocation  -  property of the barcode. (optional) 
* @param  (String) grUnit  -  Measurement of barcode properties. (optional) 
* @param  (String) autoSize  -  Sets if barcode size will be updated automatically. (optional) 
* @param  (String) barHeight  -  Height of the bar. (optional) 
* @param  (String) imageHeight  -  Height of the image. (optional) 
* @param  (String) imageWidth  -  Width of the image. (optional) 
* @param  (String) imageQuality  -  Detepmines  of the barcode image. (optional) 
* @param  (String) rotAngle  -  Angle of barcode orientation. (optional) 
* @param  (String) topMargin  -  Top margin. (optional) 
* @param  (String) bottomMargin  -  Bottom margin. (optional) 
* @param  (String) leftMargin  -  Left margin. (optional) 
* @param  (String) rightMargin  -  Right margin. (optional) 
* @param  (String) enableChecksum  -  Sets if checksum will be generated. (optional) 
* @param  (String) storage  -  Image&#39;s storage. (optional) 
* @param  (String) folder  -  Image&#39;s folder. (optional) 
* @param  (File) file  -   (required) 
* @returns SaaSposeResponse (Map)
*/
BarcodeApi.prototype.PutBarcodeGenerateFile = function(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, file, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    }                       	
	
	var resourcePath = '/barcode/{name}/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;codeLocation={codeLocation}&amp;grUnit={grUnit}&amp;autoSize={autoSize}&amp;barHeight={barHeight}&amp;imageHeight={imageHeight}&amp;imageWidth={imageWidth}&amp;imageQuality={imageQuality}&amp;rotAngle={rotAngle}&amp;topMargin={topMargin}&amp;bottomMargin={bottomMargin}&amp;leftMargin={leftMargin}&amp;rightMargin={rightMargin}&amp;enableChecksum={enableChecksum}&amp;storage={storage}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof text !== 'undefined' &&  text !== null && text!== ''){            
			resourcePath = resourcePath.replace("{" + "text" + "}" , querystring.escape(text));
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]text.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof type !== 'undefined' &&  type !== null && type!== ''){            
			resourcePath = resourcePath.replace("{" + "type" + "}" , type);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]type.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof format !== 'undefined' &&  format !== null && format!== ''){            
			resourcePath = resourcePath.replace("{" + "format" + "}" , format);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]format.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof resolutionX !== 'undefined' &&  resolutionX !== null && resolutionX!== ''){            
			resourcePath = resourcePath.replace("{" + "resolutionX" + "}" , resolutionX);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]resolutionX.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof resolutionY !== 'undefined' &&  resolutionY !== null && resolutionY!== ''){            
			resourcePath = resourcePath.replace("{" + "resolutionY" + "}" , resolutionY);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]resolutionY.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof dimensionX !== 'undefined' &&  dimensionX !== null && dimensionX!== ''){            
			resourcePath = resourcePath.replace("{" + "dimensionX" + "}" , dimensionX);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]dimensionX.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof dimensionY !== 'undefined' &&  dimensionY !== null && dimensionY!== ''){            
			resourcePath = resourcePath.replace("{" + "dimensionY" + "}" , dimensionY);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]dimensionY.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof codeLocation !== 'undefined' &&  codeLocation !== null && codeLocation!== ''){            
			resourcePath = resourcePath.replace("{" + "codeLocation" + "}" , codeLocation);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]codeLocation.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof grUnit !== 'undefined' &&  grUnit !== null && grUnit!== ''){            
			resourcePath = resourcePath.replace("{" + "grUnit" + "}" , grUnit);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]grUnit.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof autoSize !== 'undefined' &&  autoSize !== null && autoSize!== ''){            
			resourcePath = resourcePath.replace("{" + "autoSize" + "}" , autoSize);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]autoSize.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof barHeight !== 'undefined' &&  barHeight !== null && barHeight!== ''){            
			resourcePath = resourcePath.replace("{" + "barHeight" + "}" , barHeight);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]barHeight.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof imageHeight !== 'undefined' &&  imageHeight !== null && imageHeight!== ''){            
			resourcePath = resourcePath.replace("{" + "imageHeight" + "}" , imageHeight);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]imageHeight.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof imageWidth !== 'undefined' &&  imageWidth !== null && imageWidth!== ''){            
			resourcePath = resourcePath.replace("{" + "imageWidth" + "}" , imageWidth);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]imageWidth.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof imageQuality !== 'undefined' &&  imageQuality !== null && imageQuality!== ''){            
			resourcePath = resourcePath.replace("{" + "imageQuality" + "}" , imageQuality);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]imageQuality.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof rotAngle !== 'undefined' &&  rotAngle !== null && rotAngle!== ''){            
			resourcePath = resourcePath.replace("{" + "rotAngle" + "}" , rotAngle);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]rotAngle.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof topMargin !== 'undefined' &&  topMargin !== null && topMargin!== ''){            
			resourcePath = resourcePath.replace("{" + "topMargin" + "}" , topMargin);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]topMargin.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof bottomMargin !== 'undefined' &&  bottomMargin !== null && bottomMargin!== ''){            
			resourcePath = resourcePath.replace("{" + "bottomMargin" + "}" , bottomMargin);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]bottomMargin.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof leftMargin !== 'undefined' &&  leftMargin !== null && leftMargin!== ''){            
			resourcePath = resourcePath.replace("{" + "leftMargin" + "}" , leftMargin);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]leftMargin.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof rightMargin !== 'undefined' &&  rightMargin !== null && rightMargin!== ''){            
			resourcePath = resourcePath.replace("{" + "rightMargin" + "}" , rightMargin);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]rightMargin.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof enableChecksum !== 'undefined' &&  enableChecksum !== null && enableChecksum!== ''){            
			resourcePath = resourcePath.replace("{" + "enableChecksum" + "}" , enableChecksum);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]enableChecksum.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'PUT'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	if(file !== 'undefined' && file !== null && file !== ''){
		postData = fs.readFileSync(file)
	}
	
	headerParams['Accept'] = 'application/xml,application/json'
    headerParams['Content-Type'] = 'multipart/form-data'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* PutGenerateMultiple
* Generate image with multiple barcodes and put new file on server
*
* @param  (String) name  -  New filename (required) 
* @param  (String) format  -  Format of file (optional) 
* @param  (String) folder  -  Folder to place file to (optional) 
* @param  (File) file  -   (required) 
* @returns SaaSposeResponse (Map)
*/
BarcodeApi.prototype.PutGenerateMultiple = function(name, format, folder, file, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    }   	
	
	if( typeof file === 'undefined' || file === null && file === ''){
		throw new Error('missing required file.');
    }	
	var resourcePath = '/barcode/{name}/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof format !== 'undefined' &&  format !== null && format!== ''){            
			resourcePath = resourcePath.replace("{" + "format" + "}" , format);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]format.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'PUT'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	if(file !== 'undefined' && file !== null && file !== ''){
		postData = fs.readFileSync(file)
	}
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* GetBarcodeRecognize
* Recognize barcode from a file on server.
*
* @param  (String) name  -  The image name. (required) 
* @param  (String) type  -  The barcode type. (optional) 
* @param  (String) checksumValidation  -  Checksum validation parameter. (optional) 
* @param  (Boolean) stripFnc  -  Allows to strip FNC symbol in recognition results. (optional) 
* @param  (String) rotationAngle  -  Allows to correct angle of barcode. (optional) 
* @param  (String) barcodesCount  -  Count of barcodes to recognize. (optional) 
* @param  (String) rectX  -  Top left point X coordinate of  to recognize barcode inside. (optional) 
* @param  (String) rectY  -  Top left point Y coordinate of  to recognize barcode inside. (optional) 
* @param  (String) rectWidth  -  Width of  to recognize barcode inside. (optional) 
* @param  (String) rectHeight  -  Height of  to recognize barcode inside. (optional) 
* @param  (String) storage  -  The image storage. (optional) 
* @param  (String) folder  -  The image folder. (optional) 
* @returns BarcodeResponseList (Map)
*/
BarcodeApi.prototype.GetBarcodeRecognize = function(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, rectX, rectY, rectWidth, rectHeight, storage, folder, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    }            	
		
	var resourcePath = '/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;barcodesCount={barcodesCount}&amp;rectX={rectX}&amp;rectY={rectY}&amp;rectWidth={rectWidth}&amp;rectHeight={rectHeight}&amp;storage={storage}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof type !== 'undefined' &&  type !== null && type!== ''){            
			resourcePath = resourcePath.replace("{" + "type" + "}" , type);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]type.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof checksumValidation !== 'undefined' &&  checksumValidation !== null && checksumValidation!== ''){            
			resourcePath = resourcePath.replace("{" + "checksumValidation" + "}" , checksumValidation);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]checksumValidation.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof stripFnc !== 'undefined' &&  stripFnc !== null && stripFnc!== ''){            
			resourcePath = resourcePath.replace("{" + "stripFnc" + "}" , stripFnc);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]stripFnc.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof rotationAngle !== 'undefined' &&  rotationAngle !== null && rotationAngle!== ''){            
			resourcePath = resourcePath.replace("{" + "rotationAngle" + "}" , rotationAngle);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]rotationAngle.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof barcodesCount !== 'undefined' &&  barcodesCount !== null && barcodesCount!== ''){            
			resourcePath = resourcePath.replace("{" + "barcodesCount" + "}" , barcodesCount);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]barcodesCount.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof rectX !== 'undefined' &&  rectX !== null && rectX!== ''){            
			resourcePath = resourcePath.replace("{" + "rectX" + "}" , rectX);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]rectX.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof rectY !== 'undefined' &&  rectY !== null && rectY!== ''){            
			resourcePath = resourcePath.replace("{" + "rectY" + "}" , rectY);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]rectY.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof rectWidth !== 'undefined' &&  rectWidth !== null && rectWidth!== ''){            
			resourcePath = resourcePath.replace("{" + "rectWidth" + "}" , rectWidth);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]rectWidth.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof rectHeight !== 'undefined' &&  rectHeight !== null && rectHeight!== ''){            
			resourcePath = resourcePath.replace("{" + "rectHeight" + "}" , rectHeight);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]rectHeight.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/json'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* PutBarcodeRecognizeFromBody
* Recognition of a barcode from file on server with parameters in body.
*
* @param  (String) name  -  The image name. (required) 
* @param  (String) type  -  The barcode type. (optional) 
* @param  (String) folder  -  The image folder. (optional) 
* @param  (BarcodeReader) body  -  BarcodeReader object with parameters. (required) 
* @returns BarcodeResponseList (Map)
*/
BarcodeApi.prototype.PutBarcodeRecognizeFromBody = function(name, type, folder, body, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    }   	
		
	var resourcePath = '/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof type !== 'undefined' &&  type !== null && type!== ''){            
			resourcePath = resourcePath.replace("{" + "type" + "}" , type);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]type.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'PUT'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = JSON.stringify(body);
    
	
	headerParams['Accept'] = 'application/xml,application/json'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    

module.exports = BarcodeApi


