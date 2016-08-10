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
;

// Instantiate Aspose Storage Cloud API SDK
$storageApi = new StorageApi ();

// Instantiate Aspose BarCode Cloud API SDK
$barcodeApi = new BarcodeApi ();

// Set input file name
$name = "sample-barcode.jpeg";

// The barcode type.
// If this parameter is empty, autodetection of all supported types is used.
$type = "";

// Set mode for checksum validation during recognition
$checksumValidation = "On";

// Set if FNC symbol stripping should be performed.
$stripFnc = "True";

// Set recognition of rotated barcode
$rotationAngle = "";

// Set exact number of barcodes to recognize
$barcodesCount = "1";

// Set recognition of barcode inside specified Rectangle region
$rectX = 0;
$rectY = 0;
$rectWidth = 0;
$rectHeight = 0;

// Set 3rd party cloud storage server (if any)
$storage = "";

// Set folder location at cloud storage
$folder = "";

// Set local file (if any)
$file = null;

try {
	
	// upload file to aspose cloud storage
	$result = $storageApi->PutCreate ( $name, "", $storage, $data_folder . $name );
	
	// invoke Aspose.BarCode Cloud SDK API to read barcode
	$response = $barcodeApi->GetBarcodeRecognize ( $name, $type, $checksumValidation, $stripFnc, $rotationAngle, $barcodesCount, $rectX, $rectY, $rectWidth, $rectHeight, $storage, $folder );
	
	if ($response != null && $response->Status = "OK") {
		print_r ( $response->Barcode );
	}
} catch ( \Aspose\Barcode\ApiException $exp ) {
	echo "Exception:" . $exp->getMessage ();
}
//ExEnd:1
