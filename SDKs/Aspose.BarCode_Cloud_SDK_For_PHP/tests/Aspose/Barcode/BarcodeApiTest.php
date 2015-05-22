<?php

use Aspose\Barcode\BarcodeApi;

class BarcodeApiTest extends PHPUnit_Framework_TestCase {
    
    protected $barcode;

    protected function setUp()
    {        
        $this->barcode = new BarcodeApi();
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
        $fh = fopen(getcwd(). '/Data/Output/barcode.jpg', 'w');
        fwrite($fh, $result);
        fclose($fh);
        $this->assertFileExists(getcwd(). '/Data/Output/barcode.jpg');
    }
             
    public function testGetBarcodeRecognize()
    {  
        $name = 'barcode.png';
        $type = 'Code39Standard';
        $result = $this->barcode->GetBarcodeRecognize($name, $type, $checksumValidation = null, $stripFnc = null, $rotationAngle = null, $barcodesCount = null, $rectX = null, $rectY = null, $rectWidth = null, $rectHeight = null, $storage = null, $folder = null);
        $this->assertInternalType('array', $result->Barcode);
    }
    
    public function testPostBarcodeRecognizeFromUrlorContent()
    {  
        $file = 'barcode-swagger.png';
        $url = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Code_3_of_9.svg/262px-Code_3_of_9.svg.png";
        $result = $this->barcode->PostBarcodeRecognizeFromUrlorContent($type = 'Code39Standard', $checksumValidation = null, $stripFnc = null, $rotationAngle = null, $url, $file);
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
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutBarcodeRecognizeFromBody()
    {
        $name = "generate-barcode.png";
        $type = "1";
        $folder = "";
        $body = '{
                    "ChecksumValidation": "Default",
                    "StripFNC": true
                  }';
        $result = $this->barcode->PutBarcodeRecognizeFromBody($name, $type, $folder, $body);
        $this->assertEquals(200, $result->Code);
    }
        
}    