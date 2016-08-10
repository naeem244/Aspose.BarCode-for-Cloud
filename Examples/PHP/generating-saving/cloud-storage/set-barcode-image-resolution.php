<?php

/**
 * Include the SDK by using the autoloader from Composer.
 */
require __DIR__ . '/../../vendor/autoload.php';

/**
 * Include the configuration values.
 *
 * Ensure that you have edited the configuration.php file
 * to include your application keys.
 */
$config = require __DIR__ . '/../../configuration.php';

$apiKey = $config ['apiKey'];
$appSid = $config ['appSid'];
$out_folder = $config ['outFolder'];
$data_folder = '../../data/'; // resouece data folder

/**
 * The namespaces provided by the SDK.
 */
use Aspose\Barcode\BarcodeApi;
use Aspose\Storage\StorageApi;

// ExStart:1

\Aspose\Storage\AsposeApp::$apiKey = $apiKey;
\Aspose\Storage\AsposeApp::$appSID = $appSid;
\Aspose\Barcode\AsposeApp::$apiKey = $apiKey;
\Aspose\Barcode\AsposeApp::$appSID = $appSid;

// Instantiate Aspose Storage Cloud API SDK
$storageApi = new StorageApi ();

// Instantiate Aspose BarCode Cloud API SDK
$barcodeApi = new BarcodeApi ();

// Set the barcode file name created on server.
$name = "sample-barcode";

// Set Text to encode inside barcode
$text = "Aspose.BarCode";

// Set Barcode Symbology
$type = "Code128";

// Set Generated Barcode Image Format
$format = "PNG";

// Set Resolution along X and Y in dpi
$resolutionX = "200.0";
$resolutionY = "200.0";

// Set Width and Height of barcode unit
$dimensionX = "0.0";
$dimensionY = "0.0";

// Set Location, Measurement of the code
$codeLocation = "Above";
$grUnit = "mm";

// Set if barcode's size will be updated automatically
$autoSize = "true";

// Height of the bar.
$barHeight = "0.0";

// Set height, Width and quality of the image.
$imageHeight = "0.0";
$imageWidth = "0.0";
$imageQuality = "default";

// Set Angle of barcode orientation
$rotAngle = "0.0";

// Set Margin of image border
$topMargin = "0.0";
$bottomMargin = "0.0";
$leftMargin = "0.0";
$rightMargin = "0.0";

// Sets if checksum will be added to barcode image.
$enableChecksum = "Yes";

// Set 3rd party cloud storage server (if any)
$storage = "";

// Set folder location at cloud storage
$folder = "";

// Set local file (if any)
$file = null;

try {
	
	// invoke Aspose.BarCode Cloud SDK API to generate image with specific image resolution
	$response = $barcodeApi->PutBarcodeGenerateFile ( $name, $text, $type, $format, $resolutionX, $resolutionY, $dimensionX, $dimensionY, $codeLocation, $grUnit, $autoSize, $barHeight, $imageHeight, $imageWidth, $imageQuality, $rotAngle, $topMargin, $bottomMargin, $leftMargin, $rightMargin, $enableChecksum, $storage, $folder, $file );
	print_r ( $response );
	
	if ($response != null && $response->Status = "OK") {
		
		// download generated barcode from cloud storage
		$result = $storageApi->GetDownload ( $name );
		
		// Save response stream to a file
		$fileName = $out_folder . $name . "." . $format;
		$fh = fopen ( $fileName, 'w' ) or die ( 'cant open file' );
		fwrite ( $fh, $result );
		fclose ( $fh );
		
		echo "Barcode has been generated.";
	}
} catch ( \Aspose\Barcode\ApiException $exp ) {
	echo "Exception:" . $exp->getMessage ();
}
//ExEnd:1
