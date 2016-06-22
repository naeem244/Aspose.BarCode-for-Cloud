<?php

use Aspose\Barcode\BarcodeApi;
use Aspose\Storage\StorageApi;

class BarcodeApiTest extends PHPUnit_Framework_TestCase {

    protected $barcode;
    protected $storageApi;

    protected function setUp()
    {        
        $this->barcode = new BarcodeApi();
	$this->storageApi = new StorageApi();
    }
    
    public function testGetBarcodeGenerate()
    {
        $text = "BarcodeTextHere";
        $type = "1";
        $format = "jpeg";
        $resolutionX = 0.0;
        $resolutionY = 0.0;
        $dimensionX = 0.0;
        $dimensionY = 0.0;		
        $enableChecksum = "";
	
        $result = $this->barcode->GetBarcodeGenerate($text, $type, $format, $resolutionX, $resolutionY, $dimensionX, $dimensionY, $enableChecksum);
	$this->assertInternalType('string',$result );
    }
             
    public function testGetBarcodeRecognize()
    {  
        $name = 'barcode.png';
        $type = 'Code39Standard';
	$result = $this->storageApi->PutCreate($name, "", $storage="", getcwd() . '\\Data\\Input\\' . $name);
        $result = $this->barcode->GetBarcodeRecognize($name, $type, $checksumValidation = null, $stripFnc = null, $rotationAngle = null, $barcodesCount = null, $rectX = null, $rectY = null, $rectWidth = null, $rectHeight = null, $storage = null, $folder = null);
	print_r($result);
        $this->assertInternalType('array', $result->Barcode);
	$this->assertInstanceOf('\Aspose\Barcode\Models\BarcodeResponseList', $result);
    }
    
    public function testPostBarcodeRecognizeFromUrlorContent()
    {  
        $file = 'barcode-swagger.png';
        $url = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Code_3_of_9.svg/262px-Code_3_of_9.svg.png";
        $result = $this->barcode->PostBarcodeRecognizeFromUrlorContent($type = 'Code39Standard', $checksumValidation = null, $stripFnc = null, $rotationAngle = null, $url, $file);
	$this->assertInstanceOf('\Aspose\Barcode\Models\BarcodeResponseList', $result);
        $this->assertInternalType('array', $result->Barcode);
    }
    
    public function testPutBarcodeGenerateFile()
    {
        $name = 'barcode-generate.png';
        $text = 'BarcodeText';
        $type = '1';
        $format = 'png';
        $resolutionX = 0.0;
        $resolutionY = 0.0;
        $dimensionX = 0.0;
        $dimensionY = 0.0;
        $codeLocation = "";
        $grUnit = "";
        $autoSize = "";
        $barHeight = 0.0;
        $imageHeight = 0.0;
        $imageWidth = 0.0;
        $imageQuality = "";
        $rotAngle = 0.0;
        $topMargin = 0.0;
        $bottomMargin = 0.0;
        $leftMargin = 0.0;
        $rightMargin = 0.0;
        $enableChecksum = "";
        $storage = "";
        $folder = "";        
        $file = "";
        $result = $this->barcode->PutBarcodeGenerateFile($name, $text, $type, $format, 
                                    $resolutionX, $resolutionY, $dimensionX, $dimensionY, 
                                    $codeLocation, $grUnit, $autoSize, $barHeight, 
                                    $imageHeight, $imageWidth, $imageQuality, $rotAngle, 
                                    $topMargin, $bottomMargin, $leftMargin, $rightMargin, 
                                    $enableChecksum, $storage, $folder, $file);
	$this->assertInstanceOf('\Aspose\Barcode\Models\SaaSposeResponse', $result);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutBarcodeRecognizeFromBody()
    {
        $name = "barcode.png";
        $type = "1";
        $folder = "";
        $body = '{
                    "ChecksumValidation": "Default",
                    "StripFNC": true
                  }';
	
	$result = $this->storageApi->PutCreate($name, "", $storage="", getcwd() . '\\Data\\Input\\' . $name);
        $result = $this->barcode->PutBarcodeRecognizeFromBody($name, $type, $folder, $body);
	$this->assertInstanceOf('\Aspose\Barcode\Models\BarcodeResponseList', $result);
        $this->assertEquals(200, $result->Code);
    }
    
    //PostGenerateMultiple
    public function testPostGenerateMultiple()
    {
        $format = "png";
        $body =  '{"XStep":1,"YStep":2,"BarcodeBuilders":[{"TypeOfBarcode":"qr","Text":"The new qr","AutoSize":true}]}';
    	//$result = $this->barcode->PostGenerateMultiple($format, $body);
        //$this->assertEquals(200, $result->Code);
    }
    
    //PutGenerateMultiple
    public function testPutGenerateMultiple()
    {
        $name = "newfile.jpg";
        $format = "";
        $folder = "";
        $file =  getcwd() . '\\Data\\Input\\sample.txt';
	
	$result = $this->barcode->PutGenerateMultiple($name, $format, $folder, $file);
	$this->assertInstanceOf('\Aspose\Barcode\Models\SaaSposeResponse', $result);
	$this->assertEquals(200, $result->Code);
    } 
        
}    