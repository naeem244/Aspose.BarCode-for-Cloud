package com.aspose.barcode.api;

import com.aspose.barcode.client.ApiException;
import com.aspose.barcode.client.ApiInvoker;
import com.aspose.barcode.client.ApiInvokerResponse;
import com.aspose.barcode.model.ResponseMessage;
import com.aspose.barcode.model.BarcodeResponseList;
import com.aspose.barcode.model.BarcodeReader;
import com.aspose.barcode.model.SaaSposeResponse;
import com.sun.jersey.multipart.FormDataMultiPart;

import javax.ws.rs.core.MediaType;

import java.io.File;
import java.util.*;

public class BarcodeApi {
  String basePath = "http://api.aspose.com/v1.1";
  ApiInvoker apiInvoker = ApiInvoker.getInstance();
  ApiInvokerResponse response = null;

  public BarcodeApi(String basePath, String apiKey, String appSid) {
    this.basePath = basePath;
    apiInvoker.addDefaultHeader(apiInvoker.API_KEY, apiKey);
    apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
  }

  public BarcodeApi(String basePath, String apiKey, String appSid, boolean isDebug) {
          this.basePath = basePath;
          apiInvoker.addDefaultHeader(apiInvoker.API_KEY, apiKey);
          apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
          if(isDebug)
                  apiInvoker.enableDebug();
        }
  
  public BarcodeApi(String apiKey, String appSid) {
    apiInvoker.addDefaultHeader(apiInvoker.API_KEY, apiKey);
    apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
  }

  public BarcodeApi(String apiKey, String appSid, boolean isDebug) {
          apiInvoker.addDefaultHeader(apiInvoker.API_KEY, apiKey);
          apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
          if(isDebug)
                  apiInvoker.enableDebug();
        }
  
  public ApiInvoker getInvoker() {
    return apiInvoker;
  }
  
  public void setBasePath(String basePath) {
    this.basePath = basePath;
  }
  
  public String getBasePath() {
    return basePath;
  }

  /**
	* GetBarcodeGenerate
	* Generate barcode.
	* @param text	String	The code text.
	* @param type	String	Barcode type.
	* @param format	String	Result format.
	* @param resolutionX	Float	Horizontal resolution.
	* @param resolutionY	Float	Vertical resolution.
	* @param dimensionX	Float	Smallest width of barcode unit (bar or space).
	* @param dimensionY	Float	Smallest height of barcode unit (for 2D barcodes).
	* @param enableChecksum	String	Sets if checksum will be generated.
	* @return ResponseMessage
	*/

  public ResponseMessage GetBarcodeGenerate (String text, String type, String format, Float resolutionX, Float resolutionY, Float dimensionX, Float dimensionY, String enableChecksum) {
    Object postBody = null;
    // create path and map variables
    String resourcePath = "/barcode/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;enableChecksum={enableChecksum}";
	resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?").replace("toFormat={toFormat}", "format={format}");
    // query params
    Map<String, String> queryParams = new HashMap<String, String>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, String> formParams = new HashMap<String, String>();

    if(text!=null)
	  resourcePath = resourcePath.replace("{" + "text" + "}" , apiInvoker.toPathValue(text));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]text.*?(?=&|\\?|$)", "");
    if(type!=null)
	  resourcePath = resourcePath.replace("{" + "type" + "}" , apiInvoker.toPathValue(type));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]type.*?(?=&|\\?|$)", "");
    if(format!=null)
	  resourcePath = resourcePath.replace("{" + "format" + "}" , apiInvoker.toPathValue(format));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]format.*?(?=&|\\?|$)", "");
    if(resolutionX!=null)
	  resourcePath = resourcePath.replace("{" + "resolutionX" + "}" , apiInvoker.toPathValue(resolutionX));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]resolutionX.*?(?=&|\\?|$)", "");
    if(resolutionY!=null)
	  resourcePath = resourcePath.replace("{" + "resolutionY" + "}" , apiInvoker.toPathValue(resolutionY));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]resolutionY.*?(?=&|\\?|$)", "");
    if(dimensionX!=null)
	  resourcePath = resourcePath.replace("{" + "dimensionX" + "}" , apiInvoker.toPathValue(dimensionX));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]dimensionX.*?(?=&|\\?|$)", "");
    if(dimensionY!=null)
	  resourcePath = resourcePath.replace("{" + "dimensionY" + "}" , apiInvoker.toPathValue(dimensionY));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]dimensionY.*?(?=&|\\?|$)", "");
    if(enableChecksum!=null)
	  resourcePath = resourcePath.replace("{" + "enableChecksum" + "}" , apiInvoker.toPathValue(enableChecksum));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]enableChecksum.*?(?=&|\\?|$)", "");
    String[] contentTypes = {
      "application/json"};

    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

try {
		response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams, formParams, contentType);
		return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
    } catch (ApiException ex) {
      if(ex.getCode() == 404) {
      	throw new ApiException(404, "");
      }
      else {
        throw ex;
      }
    }
  }
  /**
	* GetBarcodeRecognize
	* Recognize barcode from a file on server.
	* @param name	String	The image name.
	* @param type	String	The barcode type.
	* @param checksumValidation	String	Checksum validation parameter.
	* @param stripFnc	Boolean	Allows to strip FNC symbol in recognition results.
	* @param rotationAngle	Integer	Allows to correct angle of barcode.
	* @param barcodesCount	Integer	Count of barcodes to recognize.
	* @param rectX	Integer	Top left point X coordinate of  to recognize barcode inside.
	* @param rectY	Integer	Top left point Y coordinate of  to recognize barcode inside.
	* @param rectWidth	Integer	Width of  to recognize barcode inside.
	* @param rectHeight	Integer	Height of  to recognize barcode inside.
	* @param storage	String	The image storage.
	* @param folder	String	The image folder.
	* @return BarcodeResponseList
	*/

  public BarcodeResponseList GetBarcodeRecognize (String name, String type, String checksumValidation, Boolean stripFnc, Integer rotationAngle, Integer barcodesCount, Integer rectX, Integer rectY, Integer rectWidth, Integer rectHeight, String storage, String folder) {
    Object postBody = null;
    // verify required params are set
    if(name == null ) {
       throw new ApiException(400, "missing required params");
    }
    // create path and map variables
    String resourcePath = "/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;barcodesCount={barcodesCount}&amp;rectX={rectX}&amp;rectY={rectY}&amp;rectWidth={rectWidth}&amp;rectHeight={rectHeight}&amp;storage={storage}&amp;folder={folder}";
	resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?").replace("toFormat={toFormat}", "format={format}");
    // query params
    Map<String, String> queryParams = new HashMap<String, String>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, String> formParams = new HashMap<String, String>();

    if(name!=null)
	  resourcePath = resourcePath.replace("{" + "name" + "}" , apiInvoker.toPathValue(name));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
    if(type!=null)
	  resourcePath = resourcePath.replace("{" + "type" + "}" , apiInvoker.toPathValue(type));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]type.*?(?=&|\\?|$)", "");
    if(checksumValidation!=null)
	  resourcePath = resourcePath.replace("{" + "checksumValidation" + "}" , apiInvoker.toPathValue(checksumValidation));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]checksumValidation.*?(?=&|\\?|$)", "");
    if(stripFnc!=null)
	  resourcePath = resourcePath.replace("{" + "stripFnc" + "}" , apiInvoker.toPathValue(stripFnc));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]stripFnc.*?(?=&|\\?|$)", "");
    if(rotationAngle!=null)
	  resourcePath = resourcePath.replace("{" + "rotationAngle" + "}" , apiInvoker.toPathValue(rotationAngle));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]rotationAngle.*?(?=&|\\?|$)", "");
    if(barcodesCount!=null)
	  resourcePath = resourcePath.replace("{" + "barcodesCount" + "}" , apiInvoker.toPathValue(barcodesCount));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]barcodesCount.*?(?=&|\\?|$)", "");
    if(rectX!=null)
	  resourcePath = resourcePath.replace("{" + "rectX" + "}" , apiInvoker.toPathValue(rectX));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]rectX.*?(?=&|\\?|$)", "");
    if(rectY!=null)
	  resourcePath = resourcePath.replace("{" + "rectY" + "}" , apiInvoker.toPathValue(rectY));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]rectY.*?(?=&|\\?|$)", "");
    if(rectWidth!=null)
	  resourcePath = resourcePath.replace("{" + "rectWidth" + "}" , apiInvoker.toPathValue(rectWidth));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]rectWidth.*?(?=&|\\?|$)", "");
    if(rectHeight!=null)
	  resourcePath = resourcePath.replace("{" + "rectHeight" + "}" , apiInvoker.toPathValue(rectHeight));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]rectHeight.*?(?=&|\\?|$)", "");
    if(storage!=null)
	  resourcePath = resourcePath.replace("{" + "storage" + "}" , apiInvoker.toPathValue(storage));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
    if(folder!=null)
	  resourcePath = resourcePath.replace("{" + "folder" + "}" , apiInvoker.toPathValue(folder));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
    String[] contentTypes = {
      "application/json"};

    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

try {
		response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams, formParams, contentType);
		return (BarcodeResponseList) ApiInvoker.deserialize(response, "", BarcodeResponseList.class);
    } catch (ApiException ex) {
      if(ex.getCode() == 404) {
      	throw new ApiException(404, "");
      }
      else {
        throw ex;
      }
    }
  }
  /**
	* PostBarcodeRecognizeFromUrlorContent
	* Recognize barcode from an url.
	* @param type	String	Barcode type.
	* @param checksumValidation	String	Checksum validation parameter.
	* @param stripFnc	Boolean	Allows to strip FNC symbol in recognition results.
	* @param rotationAngle	Integer	Recognition of rotated barcode. Possible angles are 90, 180, 270, default is 0
	* @param url	String	The image file url.
	* @param file	File	
	* @return BarcodeResponseList
	*/

  public BarcodeResponseList PostBarcodeRecognizeFromUrlorContent (String type, String checksumValidation, Boolean stripFnc, Integer rotationAngle, String url, File file) {
    Object postBody = null;
    // verify required params are set
    
    // create path and map variables
    String resourcePath = "/barcode/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;url={url}";
	resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?").replace("toFormat={toFormat}", "format={format}");
    // query params
    Map<String, String> queryParams = new HashMap<String, String>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, String> formParams = new HashMap<String, String>();

    if(type!=null)
	  resourcePath = resourcePath.replace("{" + "type" + "}" , apiInvoker.toPathValue(type));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]type.*?(?=&|\\?|$)", "");
    if(checksumValidation!=null)
	  resourcePath = resourcePath.replace("{" + "checksumValidation" + "}" , apiInvoker.toPathValue(checksumValidation));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]checksumValidation.*?(?=&|\\?|$)", "");
    if(stripFnc!=null)
	  resourcePath = resourcePath.replace("{" + "stripFnc" + "}" , apiInvoker.toPathValue(stripFnc));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]stripFnc.*?(?=&|\\?|$)", "");
    if(rotationAngle!=null)
	  resourcePath = resourcePath.replace("{" + "rotationAngle" + "}" , apiInvoker.toPathValue(rotationAngle));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]rotationAngle.*?(?=&|\\?|$)", "");
    if(url!=null)
	  resourcePath = resourcePath.replace("{" + "url" + "}" , apiInvoker.toPathValue(url));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]url.*?(?=&|\\?|$)", "");
    String[] contentTypes = {
      "multipart/form-data"};

    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if( file!=null){
       
       FormDataMultiPart mp = new FormDataMultiPart();
       mp.field("file", file, MediaType.MULTIPART_FORM_DATA_TYPE);
         postBody = mp;
         contentType = "multipart/form-data";
         
    }else{
       contentType = "application/json";
    }
try {
		response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams, formParams, contentType);
		return (BarcodeResponseList) ApiInvoker.deserialize(response, "", BarcodeResponseList.class);
    } catch (ApiException ex) {
      if(ex.getCode() == 404) {
      	throw new ApiException(404, "");
      }
      else {
        throw ex;
      }
    }
  }
  /**
	* PostGenerateMultiple
	* Generate multiple barcodes and return in response stream
	* @param format	String	Format to return stream in
	* @param file	File	
	* @return ResponseMessage
	*/

  public ResponseMessage PostGenerateMultiple (String format, File file) {
    Object postBody = null;
    // verify required params are set
    if(file == null ) {
       throw new ApiException(400, "missing required params");
    }
    // create path and map variables
    String resourcePath = "/barcode/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}";
	resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?").replace("toFormat={toFormat}", "format={format}");
    // query params
    Map<String, String> queryParams = new HashMap<String, String>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, String> formParams = new HashMap<String, String>();

    if(format!=null)
	  resourcePath = resourcePath.replace("{" + "format" + "}" , apiInvoker.toPathValue(format));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]format.*?(?=&|\\?|$)", "");
    String[] contentTypes = {
      "multipart/form-data"};

    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

if(contentType.startsWith("multipart/form-data")) {      
      FormDataMultiPart mp = new FormDataMultiPart();
      mp.field("file", file, MediaType.MULTIPART_FORM_DATA_TYPE);
        postBody = mp;
    }
try {
		response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams, formParams, contentType);
		return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
    } catch (ApiException ex) {
      if(ex.getCode() == 404) {
      	throw new ApiException(404, "");
      }
      else {
        throw ex;
      }
    }
  }
  /**
	* PutBarcodeGenerateFile
	* Generate barcode and save on server.
	* @param name	String	The image name.
	* @param text	String	Barcode's text.
	* @param type	String	The barcode type.
	* @param format	String	The image format.
	* @param resolutionX	Float	Horizontal resolution.
	* @param resolutionY	Float	Vertical resolution.
	* @param dimensionX	Float	Smallest width of barcode unit (bar or space).
	* @param dimensionY	Float	Smallest height of barcode unit (for 2D barcodes).
	* @param codeLocation	String	property of the barcode.
	* @param grUnit	String	Measurement of barcode properties.
	* @param autoSize	String	Sets if barcode size will be updated automatically.
	* @param barHeight	Float	Height of the bar.
	* @param imageHeight	Float	Height of the image.
	* @param imageWidth	Float	Width of the image.
	* @param imageQuality	String	Detepmines  of the barcode image.
	* @param rotAngle	Float	Angle of barcode orientation.
	* @param topMargin	Float	Top margin.
	* @param bottomMargin	Float	Bottom margin.
	* @param leftMargin	Float	Left margin.
	* @param rightMargin	Float	Right margin.
	* @param enableChecksum	String	Sets if checksum will be generated.
	* @param storage	String	Image's storage.
	* @param folder	String	Image's folder.
	* @param file	File	
	* @return SaaSposeResponse
	*/

  public SaaSposeResponse PutBarcodeGenerateFile (String name, String text, String type, String format, Float resolutionX, Float resolutionY, Float dimensionX, Float dimensionY, String codeLocation, String grUnit, String autoSize, Float barHeight, Float imageHeight, Float imageWidth, String imageQuality, Float rotAngle, Float topMargin, Float bottomMargin, Float leftMargin, Float rightMargin, String enableChecksum, String storage, String folder, File file) {
    Object postBody = null;
    // verify required params are set
    if(name == null ) {
       throw new ApiException(400, "missing required params");
    }
    // create path and map variables
    String resourcePath = "/barcode/{name}/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;codeLocation={codeLocation}&amp;grUnit={grUnit}&amp;autoSize={autoSize}&amp;barHeight={barHeight}&amp;imageHeight={imageHeight}&amp;imageWidth={imageWidth}&amp;imageQuality={imageQuality}&amp;rotAngle={rotAngle}&amp;topMargin={topMargin}&amp;bottomMargin={bottomMargin}&amp;leftMargin={leftMargin}&amp;rightMargin={rightMargin}&amp;enableChecksum={enableChecksum}&amp;storage={storage}&amp;folder={folder}";
	resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?").replace("toFormat={toFormat}", "format={format}");
    // query params
    Map<String, String> queryParams = new HashMap<String, String>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, String> formParams = new HashMap<String, String>();

    if(name!=null)
	  resourcePath = resourcePath.replace("{" + "name" + "}" , apiInvoker.toPathValue(name));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
    if(text!=null)
	  resourcePath = resourcePath.replace("{" + "text" + "}" , apiInvoker.toPathValue(text));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]text.*?(?=&|\\?|$)", "");
    if(type!=null)
	  resourcePath = resourcePath.replace("{" + "type" + "}" , apiInvoker.toPathValue(type));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]type.*?(?=&|\\?|$)", "");
    if(format!=null)
	  resourcePath = resourcePath.replace("{" + "format" + "}" , apiInvoker.toPathValue(format));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]format.*?(?=&|\\?|$)", "");
    if(resolutionX!=null)
	  resourcePath = resourcePath.replace("{" + "resolutionX" + "}" , apiInvoker.toPathValue(resolutionX));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]resolutionX.*?(?=&|\\?|$)", "");
    if(resolutionY!=null)
	  resourcePath = resourcePath.replace("{" + "resolutionY" + "}" , apiInvoker.toPathValue(resolutionY));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]resolutionY.*?(?=&|\\?|$)", "");
    if(dimensionX!=null)
	  resourcePath = resourcePath.replace("{" + "dimensionX" + "}" , apiInvoker.toPathValue(dimensionX));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]dimensionX.*?(?=&|\\?|$)", "");
    if(dimensionY!=null)
	  resourcePath = resourcePath.replace("{" + "dimensionY" + "}" , apiInvoker.toPathValue(dimensionY));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]dimensionY.*?(?=&|\\?|$)", "");
    if(codeLocation!=null)
	  resourcePath = resourcePath.replace("{" + "codeLocation" + "}" , apiInvoker.toPathValue(codeLocation));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]codeLocation.*?(?=&|\\?|$)", "");
    if(grUnit!=null)
	  resourcePath = resourcePath.replace("{" + "grUnit" + "}" , apiInvoker.toPathValue(grUnit));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]grUnit.*?(?=&|\\?|$)", "");
    if(autoSize!=null)
	  resourcePath = resourcePath.replace("{" + "autoSize" + "}" , apiInvoker.toPathValue(autoSize));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]autoSize.*?(?=&|\\?|$)", "");
    if(barHeight!=null)
	  resourcePath = resourcePath.replace("{" + "barHeight" + "}" , apiInvoker.toPathValue(barHeight));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]barHeight.*?(?=&|\\?|$)", "");
    if(imageHeight!=null)
	  resourcePath = resourcePath.replace("{" + "imageHeight" + "}" , apiInvoker.toPathValue(imageHeight));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]imageHeight.*?(?=&|\\?|$)", "");
    if(imageWidth!=null)
	  resourcePath = resourcePath.replace("{" + "imageWidth" + "}" , apiInvoker.toPathValue(imageWidth));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]imageWidth.*?(?=&|\\?|$)", "");
    if(imageQuality!=null)
	  resourcePath = resourcePath.replace("{" + "imageQuality" + "}" , apiInvoker.toPathValue(imageQuality));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]imageQuality.*?(?=&|\\?|$)", "");
    if(rotAngle!=null)
	  resourcePath = resourcePath.replace("{" + "rotAngle" + "}" , apiInvoker.toPathValue(rotAngle));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]rotAngle.*?(?=&|\\?|$)", "");
    if(topMargin!=null)
	  resourcePath = resourcePath.replace("{" + "topMargin" + "}" , apiInvoker.toPathValue(topMargin));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]topMargin.*?(?=&|\\?|$)", "");
    if(bottomMargin!=null)
	  resourcePath = resourcePath.replace("{" + "bottomMargin" + "}" , apiInvoker.toPathValue(bottomMargin));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]bottomMargin.*?(?=&|\\?|$)", "");
    if(leftMargin!=null)
	  resourcePath = resourcePath.replace("{" + "leftMargin" + "}" , apiInvoker.toPathValue(leftMargin));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]leftMargin.*?(?=&|\\?|$)", "");
    if(rightMargin!=null)
	  resourcePath = resourcePath.replace("{" + "rightMargin" + "}" , apiInvoker.toPathValue(rightMargin));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]rightMargin.*?(?=&|\\?|$)", "");
    if(enableChecksum!=null)
	  resourcePath = resourcePath.replace("{" + "enableChecksum" + "}" , apiInvoker.toPathValue(enableChecksum));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]enableChecksum.*?(?=&|\\?|$)", "");
    if(storage!=null)
	  resourcePath = resourcePath.replace("{" + "storage" + "}" , apiInvoker.toPathValue(storage));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
    if(folder!=null)
	  resourcePath = resourcePath.replace("{" + "folder" + "}" , apiInvoker.toPathValue(folder));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
    String[] contentTypes = {
      "multipart/form-data"};

    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

                if (file != null) {
                        if (contentType.startsWith("multipart/form-data")) {
                                FormDataMultiPart mp = new FormDataMultiPart();
                                mp.field("file",
                                                file,
                                                MediaType.MULTIPART_FORM_DATA_TYPE);
                                postBody = mp;
                        }

                }
try {
		response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams, formParams, contentType);
		return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
    } catch (ApiException ex) {
      if(ex.getCode() == 404) {
      	throw new ApiException(404, "");
      }
      else {
        throw ex;
      }
    }
  }
  /**
	* PutBarcodeRecognizeFromBody
	* Recognition of a barcode from file on server with parameters in body.
	* @param name	String	The image name.
	* @param type	String	The barcode type.
	* @param folder	String	The image folder.
	* @param body	BarcodeReader	BarcodeReader object with parameters.
	* @return BarcodeResponseList
	*/

  public BarcodeResponseList PutBarcodeRecognizeFromBody (String name, String type, String folder, BarcodeReader body) {
    Object postBody = body;
    // verify required params are set
    if(name == null || body == null ) {
       throw new ApiException(400, "missing required params");
    }
    // create path and map variables
    String resourcePath = "/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;folder={folder}";
	resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?").replace("toFormat={toFormat}", "format={format}");
    // query params
    Map<String, String> queryParams = new HashMap<String, String>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, String> formParams = new HashMap<String, String>();

    if(name!=null)
	  resourcePath = resourcePath.replace("{" + "name" + "}" , apiInvoker.toPathValue(name));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
    if(type!=null)
	  resourcePath = resourcePath.replace("{" + "type" + "}" , apiInvoker.toPathValue(type));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]type.*?(?=&|\\?|$)", "");
    if(folder!=null)
	  resourcePath = resourcePath.replace("{" + "folder" + "}" , apiInvoker.toPathValue(folder));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
    String[] contentTypes = {
      "application/json"};

    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

try {
		response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams, formParams, contentType);
		return (BarcodeResponseList) ApiInvoker.deserialize(response, "", BarcodeResponseList.class);
    } catch (ApiException ex) {
      if(ex.getCode() == 404) {
      	throw new ApiException(404, "");
      }
      else {
        throw ex;
      }
    }
  }
  /**
	* PutGenerateMultiple
	* Generate image with multiple barcodes and put new file on server
	* @param name	String	New filename
	* @param format	String	Format of file
	* @param folder	String	Folder to place file to
	* @param file	File	
	* @return SaaSposeResponse
	*/

  public SaaSposeResponse PutGenerateMultiple (String name, String format, String folder, File file) {
    Object postBody = null;
    // verify required params are set
    if(name == null || file == null ) {
       throw new ApiException(400, "missing required params");
    }
    // create path and map variables
    String resourcePath = "/barcode/{name}/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}&amp;folder={folder}";
	resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?").replace("toFormat={toFormat}", "format={format}");
    // query params
    Map<String, String> queryParams = new HashMap<String, String>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, String> formParams = new HashMap<String, String>();

    if(name!=null)
	  resourcePath = resourcePath.replace("{" + "name" + "}" , apiInvoker.toPathValue(name));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
    if(format!=null)
	  resourcePath = resourcePath.replace("{" + "format" + "}" , apiInvoker.toPathValue(format));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]format.*?(?=&|\\?|$)", "");
    if(folder!=null)
	  resourcePath = resourcePath.replace("{" + "folder" + "}" , apiInvoker.toPathValue(folder));
	  else
	  resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
    String[] contentTypes = {
      "multipart/form-data"};

    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

if(contentType.startsWith("multipart/form-data")) {      
      FormDataMultiPart mp = new FormDataMultiPart();
      mp.field("file", file, MediaType.MULTIPART_FORM_DATA_TYPE);
        postBody = mp;
    }
try {
		response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams, formParams, contentType);
		return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
    } catch (ApiException ex) {
      if(ex.getCode() == 404) {
      	throw new ApiException(404, "");
      }
      else {
        throw ex;
      }
    }
  }
  }

