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

// ExStart:1

\Aspose\Barcode\AsposeApp::$apiKey = $apiKey;
\Aspose\Barcode\AsposeApp::$appSID = $appSid;

// Instantiate Aspose BarCode Cloud API SDK
$barcodeApi = new BarcodeApi ();

// Set Filename of image
$name = "sample-barcode";

// Set Text to encode inside barcode
$text = "Aspose.BarCode";

// Set Barcode Symbology
$type = "QR";

// Set Barcode Image Format
$format = "PNG";

// Sets if checksum will be added to barcode image.
$enableChecksum = null;

// Set optional params (if any)
$resolutionX = 96.0;
$resolutionY = 96.0;
$dimensionX = 0.7;
$dimensionY = 2.0;

try {
	
	// invoke Aspose.BarCode Cloud SDK API to create barcode and get barcode image as a stream
	$response = $barcodeApi->GetBarcodeGenerate ( $name, $type, $format, $resolutionX, $resolutionY, $dimensionX, $dimensionY, $enableChecksum );
	
	if ($response != null) {
		
		// Save response stream to a file
		$fileName = $out_folder . $name . "." . $format;
		$fh = fopen ( $fileName, 'w' ) or die ( 'cant open file' );
		fwrite ( $fh, $response );
		fclose ( $fh );
		
		echo "Done.";
	}
} catch ( \Aspose\Barcode\ApiException $exp ) {
	echo "Exception:" . $exp->getMessage ();
}
//ExEnd:1
