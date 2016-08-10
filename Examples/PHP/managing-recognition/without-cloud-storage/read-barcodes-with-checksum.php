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

// Set input file name
$name = "sample-barcode.jpeg";

// The barcode type.
// If this parameter is empty, autodetection of all supported types is used.
$type = "";

// Set BarcodeReader object with mode for checksum validation during recognition
$body = array (
		"StripFNC" => "true",
		"ChecksumValidation" => "OFF",
		"BinarizationHints" => "ComplexBackground" 
);

// Set folder location at cloud storage
$folder = "";

try {
	
	// invoke Aspose.BarCode Cloud SDK API to recognition of a barcode from file on server with parameters in body
	$response = $barcodeApi->PutBarcodeRecognizeFromBody ( $name, $type, $folder, $body );
	
	if ($response != null && $response->Status = "OK") {
		print_r ( $response );
	}
} catch ( \Aspose\Barcode\ApiException $exp ) {
	echo "Exception:" . $exp->getMessage ();
}
//ExEnd:1
