<?php

namespace Aspose\Barcode;

use Aspose\Barcode\ApiException as Exception;
use Aspose\Barcode\ApiClient;

class BarcodeApi {

    function __construct() {
        $this->apiClient = new ApiClient();
    }

    /**
     * GetBarcodeGenerate
     * Generate barcode.
     * text, string: The code text. (optional)

     * type, string: Barcode type. (optional)

     * format, string: Result format. (optional)

     * resolutionX, float: Horizontal resolution. (optional)

     * resolutionY, float: Vertical resolution. (optional)

     * dimensionX, float: Smallest width of barcode unit (bar or space). (optional)

     * dimensionY, float: Smallest height of barcode unit (for 2D barcodes). (optional)

     * enableChecksum, string: Sets if checksum will be generated. (optional)

     * @return ResponseMessage
     */
    public function GetBarcodeGenerate($text = null, $type = null, $format = null, $resolutionX = null, $resolutionY = null, $dimensionX = null, $dimensionY = null, $enableChecksum = null) {
        //parse inputs
        $resourcePath = "/barcode/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;enableChecksum={enableChecksum}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($text != null) {
            $resourcePath = str_replace("{" . "text" . "}", $this->apiClient->toQueryValue($text), $resourcePath);
        } else {
            $resourcePath = str_replace("&text={" . "text" . "}", "", $resourcePath);
        }
        if ($type != null) {
            $resourcePath = str_replace("{" . "type" . "}", $this->apiClient->toQueryValue($type), $resourcePath);
        } else {
            $resourcePath = str_replace("&type={" . "type" . "}", "", $resourcePath);
        }
        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        if ($resolutionX != null) {
            $resourcePath = str_replace("{" . "resolutionX" . "}", $this->apiClient->toQueryValue($resolutionX), $resourcePath);
        } else {
            $resourcePath = str_replace("&resolutionX={" . "resolutionX" . "}", "", $resourcePath);
        }
        if ($resolutionY != null) {
            $resourcePath = str_replace("{" . "resolutionY" . "}", $this->apiClient->toQueryValue($resolutionY), $resourcePath);
        } else {
            $resourcePath = str_replace("&resolutionY={" . "resolutionY" . "}", "", $resourcePath);
        }
        if ($dimensionX != null) {
            $resourcePath = str_replace("{" . "dimensionX" . "}", $this->apiClient->toQueryValue($dimensionX), $resourcePath);
        } else {
            $resourcePath = str_replace("&dimensionX={" . "dimensionX" . "}", "", $resourcePath);
        }
        if ($dimensionY != null) {
            $resourcePath = str_replace("{" . "dimensionY" . "}", $this->apiClient->toQueryValue($dimensionY), $resourcePath);
        } else {
            $resourcePath = str_replace("&dimensionY={" . "dimensionY" . "}", "", $resourcePath);
        }
        if ($enableChecksum != null) {
            $resourcePath = str_replace("{" . "enableChecksum" . "}", $this->apiClient->toQueryValue($enableChecksum), $resourcePath);
        } else {
            $resourcePath = str_replace("&enableChecksum={" . "enableChecksum" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);
        
        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetBarcodeRecognize
     * Recognize barcode from a file on server.
     * name, string: The image name. (required)

     * type, string: The barcode type. (optional)

     * checksumValidation, string: Checksum validation parameter. (optional)

     * stripFnc, bool: Allows to strip FNC symbol in recognition results. (optional)

     * rotationAngle, int: Allows to correct angle of barcode. (optional)

     * barcodesCount, int: Count of barcodes to recognize. (optional)

     * rectX, int: Top left point X coordinate of  to recognize barcode inside. (optional)

     * rectY, int: Top left point Y coordinate of  to recognize barcode inside. (optional)

     * rectWidth, int: Width of  to recognize barcode inside. (optional)

     * rectHeight, int: Height of  to recognize barcode inside. (optional)

     * storage, string: The image storage. (optional)

     * folder, string: The image folder. (optional)

     * @return BarcodeResponseList
     */
    public function GetBarcodeRecognize($name, $type = null, $checksumValidation = null, $stripFnc = null, $rotationAngle = null, $barcodesCount = null, $rectX = null, $rectY = null, $rectWidth = null, $rectHeight = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;barcodesCount={barcodesCount}&amp;rectX={rectX}&amp;rectY={rectY}&amp;rectWidth={rectWidth}&amp;rectHeight={rectHeight}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($type != null) {
            $resourcePath = str_replace("{" . "type" . "}", $this->apiClient->toQueryValue($type), $resourcePath);
        } else {
            $resourcePath = str_replace("&type={" . "type" . "}", "", $resourcePath);
        }
        if ($checksumValidation != null) {
            $resourcePath = str_replace("{" . "checksumValidation" . "}", $this->apiClient->toQueryValue($checksumValidation), $resourcePath);
        } else {
            $resourcePath = str_replace("&checksumValidation={" . "checksumValidation" . "}", "", $resourcePath);
        }
        if ($stripFnc != null) {
            $resourcePath = str_replace("{" . "stripFnc" . "}", $this->apiClient->toQueryValue($stripFnc), $resourcePath);
        } else {
            $resourcePath = str_replace("&stripFnc={" . "stripFnc" . "}", "", $resourcePath);
        }
        if ($rotationAngle != null) {
            $resourcePath = str_replace("{" . "rotationAngle" . "}", $this->apiClient->toQueryValue($rotationAngle), $resourcePath);
        } else {
            $resourcePath = str_replace("&rotationAngle={" . "rotationAngle" . "}", "", $resourcePath);
        }
        if ($barcodesCount != null) {
            $resourcePath = str_replace("{" . "barcodesCount" . "}", $this->apiClient->toQueryValue($barcodesCount), $resourcePath);
        } else {
            $resourcePath = str_replace("&barcodesCount={" . "barcodesCount" . "}", "", $resourcePath);
        }
        if ($rectX != null) {
            $resourcePath = str_replace("{" . "rectX" . "}", $this->apiClient->toQueryValue($rectX), $resourcePath);
        } else {
            $resourcePath = str_replace("&rectX={" . "rectX" . "}", "", $resourcePath);
        }
        if ($rectY != null) {
            $resourcePath = str_replace("{" . "rectY" . "}", $this->apiClient->toQueryValue($rectY), $resourcePath);
        } else {
            $resourcePath = str_replace("&rectY={" . "rectY" . "}", "", $resourcePath);
        }
        if ($rectWidth != null) {
            $resourcePath = str_replace("{" . "rectWidth" . "}", $this->apiClient->toQueryValue($rectWidth), $resourcePath);
        } else {
            $resourcePath = str_replace("&rectWidth={" . "rectWidth" . "}", "", $resourcePath);
        }
        if ($rectHeight != null) {
            $resourcePath = str_replace("{" . "rectHeight" . "}", $this->apiClient->toQueryValue($rectHeight), $resourcePath);
        } else {
            $resourcePath = str_replace("&rectHeight={" . "rectHeight" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'BarcodeResponseList');
        return $responseObject;
    }

    /**
     * PostBarcodeRecognizeFromUrlorContent
     * Recognize barcode from an url.
     * type, string: Barcode type. (optional)

     * checksumValidation, string: Checksum validation parameter. (optional)

     * stripFnc, bool: Allows to strip FNC symbol in recognition results. (optional)

     * rotationAngle, int: Recognition of rotated barcode. Possible angles are 90, 180, 270, default is 0 (optional)

     * url, string: The image file url. (optional)

     * file, File:  (required)

     * @return BarcodeResponseList
     */
    public function PostBarcodeRecognizeFromUrlorContent($type = null, $checksumValidation = null, $stripFnc = null, $rotationAngle = null, $url = null, $file) {
        // verify required params are set
        if ($file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/barcode/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;url={url}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($type != null) {
            $resourcePath = str_replace("{" . "type" . "}", $this->apiClient->toQueryValue($type), $resourcePath);
        } else {
            $resourcePath = str_replace("&type={" . "type" . "}", "", $resourcePath);
        }
        if ($checksumValidation != null) {
            $resourcePath = str_replace("{" . "checksumValidation" . "}", $this->apiClient->toQueryValue($checksumValidation), $resourcePath);
        } else {
            $resourcePath = str_replace("&checksumValidation={" . "checksumValidation" . "}", "", $resourcePath);
        }
        if ($stripFnc != null) {
            $resourcePath = str_replace("{" . "stripFnc" . "}", $this->apiClient->toQueryValue($stripFnc), $resourcePath);
        } else {
            $resourcePath = str_replace("&stripFnc={" . "stripFnc" . "}", "", $resourcePath);
        }
        if ($rotationAngle != null) {
            $resourcePath = str_replace("{" . "rotationAngle" . "}", $this->apiClient->toQueryValue($rotationAngle), $resourcePath);
        } else {
            $resourcePath = str_replace("&rotationAngle={" . "rotationAngle" . "}", "", $resourcePath);
        }
        if ($url != null) {
            $resourcePath = str_replace("{" . "url" . "}", $this->apiClient->toQueryValue($url), $resourcePath);
        } else {
            $resourcePath = str_replace("&url={" . "url" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'BarcodeResponseList');
        return $responseObject;
    }

    /**
     * PostGenerateMultiple
     * Generate multiple barcodes and return in response stream
     * format, string: Format to return stream in (optional)

     * file, File:  (required)

     * @return ResponseMessage
     */
    public function PostGenerateMultiple($format = null, $file) {
        // verify required params are set
        if ($file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/barcode/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * PutBarcodeGenerateFile
     * Generate barcode and save on server.
     * name, string: The image name. (required)

     * text, string: Barcode's text. (optional)

     * type, string: The barcode type. (optional)

     * format, string: The image format. (optional)

     * resolutionX, float: Horizontal resolution. (optional)

     * resolutionY, float: Vertical resolution. (optional)

     * dimensionX, float: Smallest width of barcode unit (bar or space). (optional)

     * dimensionY, float: Smallest height of barcode unit (for 2D barcodes). (optional)

     * codeLocation, string: property of the barcode. (optional)

     * grUnit, string: Measurement of barcode properties. (optional)

     * autoSize, string: Sets if barcode size will be updated automatically. (optional)

     * barHeight, float: Height of the bar. (optional)

     * imageHeight, float: Height of the image. (optional)

     * imageWidth, float: Width of the image. (optional)

     * imageQuality, string: Detepmines  of the barcode image. (optional)

     * rotAngle, float: Angle of barcode orientation. (optional)

     * topMargin, float: Top margin. (optional)

     * bottomMargin, float: Bottom margin. (optional)

     * leftMargin, float: Left margin. (optional)

     * rightMargin, float: Right margin. (optional)

     * enableChecksum, string: Sets if checksum will be generated. (optional)

     * storage, string: Image's storage. (optional)

     * folder, string: Image's folder. (optional)

     * file, File:  (requird)

     * @return SaaSposeResponse
     */
    public function PutBarcodeGenerateFile($name, $text = null, $type = null, $format = null, $resolutionX = null, $resolutionY = null, $dimensionX = null, $dimensionY = null, $codeLocation = null, $grUnit = null, $autoSize = null, $barHeight = null, $imageHeight = null, $imageWidth = null, $imageQuality = null, $rotAngle = null, $topMargin = null, $bottomMargin = null, $leftMargin = null, $rightMargin = null, $enableChecksum = null, $storage = null, $folder = null, $file) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/barcode/{name}/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;codeLocation={codeLocation}&amp;grUnit={grUnit}&amp;autoSize={autoSize}&amp;barHeight={barHeight}&amp;imageHeight={imageHeight}&amp;imageWidth={imageWidth}&amp;imageQuality={imageQuality}&amp;rotAngle={rotAngle}&amp;topMargin={topMargin}&amp;bottomMargin={bottomMargin}&amp;leftMargin={leftMargin}&amp;rightMargin={rightMargin}&amp;enableChecksum={enableChecksum}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($text != null) {
            $resourcePath = str_replace("{" . "text" . "}", $this->apiClient->toQueryValue($text), $resourcePath);
        } else {
            $resourcePath = str_replace("&text={" . "text" . "}", "", $resourcePath);
        }
        if ($type != null) {
            $resourcePath = str_replace("{" . "type" . "}", $this->apiClient->toQueryValue($type), $resourcePath);
        } else {
            $resourcePath = str_replace("&type={" . "type" . "}", "", $resourcePath);
        }
        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        if ($resolutionX != null) {
            $resourcePath = str_replace("{" . "resolutionX" . "}", $this->apiClient->toQueryValue($resolutionX), $resourcePath);
        } else {
            $resourcePath = str_replace("&resolutionX={" . "resolutionX" . "}", "", $resourcePath);
        }
        if ($resolutionY != null) {
            $resourcePath = str_replace("{" . "resolutionY" . "}", $this->apiClient->toQueryValue($resolutionY), $resourcePath);
        } else {
            $resourcePath = str_replace("&resolutionY={" . "resolutionY" . "}", "", $resourcePath);
        }
        if ($dimensionX != null) {
            $resourcePath = str_replace("{" . "dimensionX" . "}", $this->apiClient->toQueryValue($dimensionX), $resourcePath);
        } else {
            $resourcePath = str_replace("&dimensionX={" . "dimensionX" . "}", "", $resourcePath);
        }
        if ($dimensionY != null) {
            $resourcePath = str_replace("{" . "dimensionY" . "}", $this->apiClient->toQueryValue($dimensionY), $resourcePath);
        } else {
            $resourcePath = str_replace("&dimensionY={" . "dimensionY" . "}", "", $resourcePath);
        }
        if ($codeLocation != null) {
            $resourcePath = str_replace("{" . "codeLocation" . "}", $this->apiClient->toQueryValue($codeLocation), $resourcePath);
        } else {
            $resourcePath = str_replace("&codeLocation={" . "codeLocation" . "}", "", $resourcePath);
        }
        if ($grUnit != null) {
            $resourcePath = str_replace("{" . "grUnit" . "}", $this->apiClient->toQueryValue($grUnit), $resourcePath);
        } else {
            $resourcePath = str_replace("&grUnit={" . "grUnit" . "}", "", $resourcePath);
        }
        if ($autoSize != null) {
            $resourcePath = str_replace("{" . "autoSize" . "}", $this->apiClient->toQueryValue($autoSize), $resourcePath);
        } else {
            $resourcePath = str_replace("&autoSize={" . "autoSize" . "}", "", $resourcePath);
        }
        if ($barHeight != null) {
            $resourcePath = str_replace("{" . "barHeight" . "}", $this->apiClient->toQueryValue($barHeight), $resourcePath);
        } else {
            $resourcePath = str_replace("&barHeight={" . "barHeight" . "}", "", $resourcePath);
        }
        if ($imageHeight != null) {
            $resourcePath = str_replace("{" . "imageHeight" . "}", $this->apiClient->toQueryValue($imageHeight), $resourcePath);
        } else {
            $resourcePath = str_replace("&imageHeight={" . "imageHeight" . "}", "", $resourcePath);
        }
        if ($imageWidth != null) {
            $resourcePath = str_replace("{" . "imageWidth" . "}", $this->apiClient->toQueryValue($imageWidth), $resourcePath);
        } else {
            $resourcePath = str_replace("&imageWidth={" . "imageWidth" . "}", "", $resourcePath);
        }
        if ($imageQuality != null) {
            $resourcePath = str_replace("{" . "imageQuality" . "}", $this->apiClient->toQueryValue($imageQuality), $resourcePath);
        } else {
            $resourcePath = str_replace("&imageQuality={" . "imageQuality" . "}", "", $resourcePath);
        }
        if ($rotAngle != null) {
            $resourcePath = str_replace("{" . "rotAngle" . "}", $this->apiClient->toQueryValue($rotAngle), $resourcePath);
        } else {
            $resourcePath = str_replace("&rotAngle={" . "rotAngle" . "}", "", $resourcePath);
        }
        if ($topMargin != null) {
            $resourcePath = str_replace("{" . "topMargin" . "}", $this->apiClient->toQueryValue($topMargin), $resourcePath);
        } else {
            $resourcePath = str_replace("&topMargin={" . "topMargin" . "}", "", $resourcePath);
        }
        if ($bottomMargin != null) {
            $resourcePath = str_replace("{" . "bottomMargin" . "}", $this->apiClient->toQueryValue($bottomMargin), $resourcePath);
        } else {
            $resourcePath = str_replace("&bottomMargin={" . "bottomMargin" . "}", "", $resourcePath);
        }
        if ($leftMargin != null) {
            $resourcePath = str_replace("{" . "leftMargin" . "}", $this->apiClient->toQueryValue($leftMargin), $resourcePath);
        } else {
            $resourcePath = str_replace("&leftMargin={" . "leftMargin" . "}", "", $resourcePath);
        }
        if ($rightMargin != null) {
            $resourcePath = str_replace("{" . "rightMargin" . "}", $this->apiClient->toQueryValue($rightMargin), $resourcePath);
        } else {
            $resourcePath = str_replace("&rightMargin={" . "rightMargin" . "}", "", $resourcePath);
        }
        if ($enableChecksum != null) {
            $resourcePath = str_replace("{" . "enableChecksum" . "}", $this->apiClient->toQueryValue($enableChecksum), $resourcePath);
        } else {
            $resourcePath = str_replace("&enableChecksum={" . "enableChecksum" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * PutBarcodeRecognizeFromBody
     * Recognition of a barcode from file on server with parameters in body.
     * name, string: The image name. (required)

     * type, string: The barcode type. (optional)

     * folder, string: The image folder. (optional)

     * body, BarcodeReader: BarcodeReader object with parameters. (required)

     * @return BarcodeResponseList
     */
    public function PutBarcodeRecognizeFromBody($name, $type = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($type != null) {
            $resourcePath = str_replace("{" . "type" . "}", $this->apiClient->toQueryValue($type), $resourcePath);
        } else {
            $resourcePath = str_replace("&type={" . "type" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'BarcodeResponseList');
        return $responseObject;
    }

    /**
     * PutGenerateMultiple
     * Generate image with multiple barcodes and put new file on server
     * name, string: New filename (required)

     * format, string: Format of file (optional)

     * folder, string: Folder to place file to (optional)

     * file, File:  (required)

     * @return SaaSposeResponse
     */
    public function PutGenerateMultiple($name, $format = null, $folder = null, $file) {
        // verify required params are set
        if ($name == '' || $file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/barcode/{name}/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

}
