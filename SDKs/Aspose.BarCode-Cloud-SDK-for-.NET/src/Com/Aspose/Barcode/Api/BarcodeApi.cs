  using System;
  using System.Collections.Generic;
  using System.Text.RegularExpressions;
  using Com.Aspose.Barcode;
  using Com.Aspose.Barcode.Model;
  namespace Com.Aspose.Barcode.Api {
    public class BarcodeApi {
      string basePath;
      private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

      public BarcodeApi(String apiKey, String appSid, String basePath)
      {
	apiInvoker.apiKey = apiKey;
        apiInvoker.appSid = appSid;
        this.basePath = basePath;
      }

      public ApiInvoker getInvoker() {
        return apiInvoker;
      }

      // Sets the endpoint base url for the services being accessed
      public void setBasePath(string basePath) {
        this.basePath = basePath;
      }

      // Gets the endpoint base url for the services being accessed
      public String getBasePath() {
        return basePath;
      }

      /// <summary>
      /// Generate barcode. Generate barcode.
      /// </summary>
      /// <param name="text"></param>
      /// <param name="type"></param>
      /// <param name="format"></param>
      /// <param name="resolutionX"></param>
      /// <param name="resolutionY"></param>
      /// <param name="dimensionX"></param>
      /// <param name="dimensionY"></param>
      /// <param name="enableChecksum"></param>
      /// <returns></returns>
      public ResponseMessage GetBarcodeGenerate (string text, string type, string format, float? resolutionX, float? resolutionY, float? dimensionX, float? dimensionY, string enableChecksum) {
        // create path and map variables
        var ResourcePath = "/barcode/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;enableChecksum={enableChecksum}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (text == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])text=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "text" + "}", apiInvoker.ToPathValue(text)); 
		}
        if (type == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])type=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "type" + "}", apiInvoker.ToPathValue(type)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (resolutionX == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])resolutionX=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "resolutionX" + "}", apiInvoker.ToPathValue(resolutionX)); 
		}
        if (resolutionY == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])resolutionY=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "resolutionY" + "}", apiInvoker.ToPathValue(resolutionY)); 
		}
        if (dimensionX == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dimensionX=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dimensionX" + "}", apiInvoker.ToPathValue(dimensionX)); 
		}
        if (dimensionY == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dimensionY=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dimensionY" + "}", apiInvoker.ToPathValue(dimensionY)); 
		}
        if (enableChecksum == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])enableChecksum=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "enableChecksum" + "}", apiInvoker.ToPathValue(enableChecksum)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Recognize barcode from a file on server. Recognize barcode from a file on server.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="type"></param>
      /// <param name="checksumValidation"></param>
      /// <param name="stripFnc"></param>
      /// <param name="rotationAngle"></param>
      /// <param name="barcodesCount"></param>
      /// <param name="rectX"></param>
      /// <param name="rectY"></param>
      /// <param name="rectWidth"></param>
      /// <param name="rectHeight"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public BarcodeResponseList GetBarcodeRecognize (string name, string type, string checksumValidation, bool? stripFnc, int? rotationAngle, int? barcodesCount, int? rectX, int? rectY, int? rectWidth, int? rectHeight, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;barcodesCount={barcodesCount}&amp;rectX={rectX}&amp;rectY={rectY}&amp;rectWidth={rectWidth}&amp;rectHeight={rectHeight}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (type == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])type=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "type" + "}", apiInvoker.ToPathValue(type)); 
		}
        if (checksumValidation == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])checksumValidation=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "checksumValidation" + "}", apiInvoker.ToPathValue(checksumValidation)); 
		}
        if (stripFnc == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])stripFnc=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "stripFnc" + "}", apiInvoker.ToPathValue(stripFnc)); 
		}
        if (rotationAngle == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rotationAngle=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rotationAngle" + "}", apiInvoker.ToPathValue(rotationAngle)); 
		}
        if (barcodesCount == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])barcodesCount=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "barcodesCount" + "}", apiInvoker.ToPathValue(barcodesCount)); 
		}
        if (rectX == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rectX=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rectX" + "}", apiInvoker.ToPathValue(rectX)); 
		}
        if (rectY == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rectY=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rectY" + "}", apiInvoker.ToPathValue(rectY)); 
		}
        if (rectWidth == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rectWidth=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rectWidth" + "}", apiInvoker.ToPathValue(rectWidth)); 
		}
        if (rectHeight == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rectHeight=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rectHeight" + "}", apiInvoker.ToPathValue(rectHeight)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(BarcodeResponseList) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (BarcodeResponseList) ApiInvoker.deserialize(response, typeof(BarcodeResponseList));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (BarcodeResponseList) ApiInvoker.deserialize(response, typeof(BarcodeResponseList));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Recognize barcode from an url. Recognize barcode from an url.
      /// </summary>
      /// <param name="type"></param>
      /// <param name="checksumValidation"></param>
      /// <param name="stripFnc"></param>
      /// <param name="rotationAngle"></param>
      /// <param name="url"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public BarcodeResponseList PostBarcodeRecognizeFromUrlorContent (string type, string checksumValidation, bool? stripFnc, int? rotationAngle, string url, byte[] file) {
        // create path and map variables
        var ResourcePath = "/barcode/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;url={url}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        //if (file == null ) {
        //   throw new ApiException(400, "missing required params");
        //}
        if (type == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])type=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "type" + "}", apiInvoker.ToPathValue(type)); 
		}
        if (checksumValidation == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])checksumValidation=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "checksumValidation" + "}", apiInvoker.ToPathValue(checksumValidation)); 
		}
        if (stripFnc == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])stripFnc=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "stripFnc" + "}", apiInvoker.ToPathValue(stripFnc)); 
		}
        if (rotationAngle == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rotationAngle=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rotationAngle" + "}", apiInvoker.ToPathValue(rotationAngle)); 
		}
        if (url == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])url=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "url" + "}", apiInvoker.ToPathValue(url)); 
		}
        if (file != null){
         if(file is byte[]) {
		 
			 var docFile = new FileInfo();
             docFile.file = file;
             docFile.MimeType = "application/octet-stream";
             formParams.Add("file", docFile);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(BarcodeResponseList) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (BarcodeResponseList) ApiInvoker.deserialize(response, typeof(BarcodeResponseList));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (BarcodeResponseList) ApiInvoker.deserialize(response, typeof(BarcodeResponseList));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Generate multiple barcodes and return in response stream Generate multiple barcodes and return in response stream
      /// </summary>
      /// <param name="format"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public ResponseMessage PostGenerateMultiple(string format, BarcodeBuilders body)
      {
        // create path and map variables
        var ResourcePath = "/barcode/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        //if (file != null){
        // if(file is byte[]) {
		 
        //     var docFile = new FileInfo();
        //     docFile.file = file;
        //     docFile.MimeType = "application/octet-stream";
        //     formParams.Add("file", docFile);
        // } else {
        //   //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
        //    string paramStr = Convert.ToString(file);
        //   formParams.Add("file", paramStr);
        // }
        //}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
              var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Generate barcode and save on server. Generate barcode and save on server.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="text"></param>
      /// <param name="type"></param>
      /// <param name="format"></param>
      /// <param name="resolutionX"></param>
      /// <param name="resolutionY"></param>
      /// <param name="dimensionX"></param>
      /// <param name="dimensionY"></param>
      /// <param name="codeLocation"></param>
      /// <param name="grUnit"></param>
      /// <param name="autoSize"></param>
      /// <param name="barHeight"></param>
      /// <param name="imageHeight"></param>
      /// <param name="imageWidth"></param>
      /// <param name="imageQuality"></param>
      /// <param name="rotAngle"></param>
      /// <param name="topMargin"></param>
      /// <param name="bottomMargin"></param>
      /// <param name="leftMargin"></param>
      /// <param name="rightMargin"></param>
      /// <param name="enableChecksum"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public SaaSposeResponse PutBarcodeGenerateFile (string name, string text, string type, string format, float? resolutionX, float? resolutionY, float? dimensionX, float? dimensionY, string codeLocation, string grUnit, string autoSize, float? barHeight, float? imageHeight, float? imageWidth, string imageQuality, float? rotAngle, float? topMargin, float? bottomMargin, float? leftMargin, float? rightMargin, string enableChecksum, string storage, string folder, byte[] file) {
        // create path and map variables
        var ResourcePath = "/barcode/{name}/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;codeLocation={codeLocation}&amp;grUnit={grUnit}&amp;autoSize={autoSize}&amp;barHeight={barHeight}&amp;imageHeight={imageHeight}&amp;imageWidth={imageWidth}&amp;imageQuality={imageQuality}&amp;rotAngle={rotAngle}&amp;topMargin={topMargin}&amp;bottomMargin={bottomMargin}&amp;leftMargin={leftMargin}&amp;rightMargin={rightMargin}&amp;enableChecksum={enableChecksum}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (text == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])text=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "text" + "}", apiInvoker.ToPathValue(text)); 
		}
        if (type == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])type=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "type" + "}", apiInvoker.ToPathValue(type)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (resolutionX == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])resolutionX=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "resolutionX" + "}", apiInvoker.ToPathValue(resolutionX)); 
		}
        if (resolutionY == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])resolutionY=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "resolutionY" + "}", apiInvoker.ToPathValue(resolutionY)); 
		}
        if (dimensionX == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dimensionX=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dimensionX" + "}", apiInvoker.ToPathValue(dimensionX)); 
		}
        if (dimensionY == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dimensionY=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dimensionY" + "}", apiInvoker.ToPathValue(dimensionY)); 
		}
        if (codeLocation == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])codeLocation=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "codeLocation" + "}", apiInvoker.ToPathValue(codeLocation)); 
		}
        if (grUnit == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])grUnit=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "grUnit" + "}", apiInvoker.ToPathValue(grUnit)); 
		}
        if (autoSize == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])autoSize=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "autoSize" + "}", apiInvoker.ToPathValue(autoSize)); 
		}
        if (barHeight == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])barHeight=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "barHeight" + "}", apiInvoker.ToPathValue(barHeight)); 
		}
        if (imageHeight == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageHeight=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageHeight" + "}", apiInvoker.ToPathValue(imageHeight)); 
		}
        if (imageWidth == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageWidth=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageWidth" + "}", apiInvoker.ToPathValue(imageWidth)); 
		}
        if (imageQuality == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageQuality=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageQuality" + "}", apiInvoker.ToPathValue(imageQuality)); 
		}
        if (rotAngle == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rotAngle=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rotAngle" + "}", apiInvoker.ToPathValue(rotAngle)); 
		}
        if (topMargin == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])topMargin=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "topMargin" + "}", apiInvoker.ToPathValue(topMargin)); 
		}
        if (bottomMargin == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])bottomMargin=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "bottomMargin" + "}", apiInvoker.ToPathValue(bottomMargin)); 
		}
        if (leftMargin == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])leftMargin=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "leftMargin" + "}", apiInvoker.ToPathValue(leftMargin)); 
		}
        if (rightMargin == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rightMargin=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rightMargin" + "}", apiInvoker.ToPathValue(rightMargin)); 
		}
        if (enableChecksum == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])enableChecksum=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "enableChecksum" + "}", apiInvoker.ToPathValue(enableChecksum)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (file != null){
         if(file is byte[]) {
		 
			 var docFile = new FileInfo();
             docFile.file = file;
             docFile.MimeType = "application/octet-stream";
             formParams.Add("file", docFile);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Recognition of a barcode from file on server with parameters in body. Recognition of a barcode from file on server with parameters in body.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="type"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public BarcodeResponseList PutBarcodeRecognizeFromBody (string name, string type, string folder, BarcodeReader body) {
        // create path and map variables
        var ResourcePath = "/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (type == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])type=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "type" + "}", apiInvoker.ToPathValue(type)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(BarcodeResponseList) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (BarcodeResponseList) ApiInvoker.deserialize(response, typeof(BarcodeResponseList));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (BarcodeResponseList) ApiInvoker.deserialize(response, typeof(BarcodeResponseList));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Generate image with multiple barcodes and put new file on server Generate image with multiple barcodes and put new file on server
      /// </summary>
      /// <param name="name"></param>
      /// <param name="format"></param>
      /// <param name="folder"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public SaaSposeResponse PutGenerateMultiple (string name, string format, string folder, BarcodeBuilders body) {
        // create path and map variables
        var ResourcePath = "/barcode/{name}/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        //if (file != null){
        // if(file is byte[]) {
		 
        //     var docFile = new FileInfo();
        //     docFile.file = file;
        //     docFile.MimeType = "application/octet-stream";
        //     formParams.Add("file", docFile);
        // } else {
        //   //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
        //    string paramStr = Convert.ToString(file);
        //   formParams.Add("file", paramStr);
        // }
        //}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }
