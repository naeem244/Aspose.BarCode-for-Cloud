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
use Aspose\Barcode\APIClient;

// ExStart:1

\Aspose\Barcode\AsposeApp::$apiKey = $apiKey;
\Aspose\Barcode\AsposeApp::$appSID = $appSid;
;

// Instantiate Aspose BarCode Cloud API SDK
$barcodeApi = new BarcodeApi ();

// Set the image file url
$url = "http://www.barcoding.com/images/Barcodes/code93.gif";

// The barcode type.
// If this parameter is empty, autodetection of all supported types is used.
$type = "";

// Set mode for checksum validation during recognition
$checksumValidation = "";

// Set if FNC symbol stripping should be performed.
$stripFnc = "False";

// Set recognition of rotated barcode
$rotationAngle = 0;

// Set exact number of barcodes to recognize
$barcodesCount = 0;

// Set recognition of barcode inside specified Rectangle region
$rectX = "";
$rectY = "";
$rectWidth = "";
$rectHeight = "";

// Set 3rd party cloud storage server (if any)
$storage = "";

// Set folder location at cloud storage
$folder = "";

// Set local file (if any)
$file = "empty.fle";

try {
	
	// invoke Aspose.BarCode Cloud SDK API to read barcode from external image URL
	$response = $barcodeApi->PostBarcodeRecognizeFromUrlorContent ( $type, $checksumValidation, $stripFnc, $rotationAngle, $url, $file );
	
	if ($response != null && $response->Status = "OK") {
		print_r ( $response );
	}
} catch ( \Aspose\Barcode\ApiException $exp ) {
	echo "Exception:" . $exp->getMessage ();
}
//ExEnd:1
