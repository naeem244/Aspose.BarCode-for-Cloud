use lib 'lib';
use strict;
use warnings;
use utf8;
use File::Slurp; # From CPAN
use JSON;

use AsposeStorageCloud::StorageApi;
use AsposeStorageCloud::ApiClient;
use AsposeStorageCloud::Configuration;

use AsposeBarCodeCloud::BarcodeApi;
use AsposeBarCodeCloud::ApiClient;
use AsposeBarCodeCloud::Configuration;


my $configFile = '../../data/config.json';
my $configPropsText = read_file($configFile);

my $configProps = decode_json($configPropsText);

my $data_path = '../../data/';
my $out_path = $configProps->{'out_folder'};;

#ExStart:1
$AsposeBarCodeCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeBarCodeCloud::Configuration::api_key = $configProps->{'api_key'};
$AsposeBarCodeCloud::Configuration::debug = 1;
$AsposeStorageCloud::Configuration::app_sid = $AsposeBarCodeCloud::Configuration::app_sid;
$AsposeStorageCloud::Configuration::api_key = $AsposeBarCodeCloud::Configuration::api_key;

#Instantiate Aspose.Storage API SDK 
my $storageApi = AsposeStorageCloud::StorageApi->new();

#Instantiate Aspose.BarCode API SDK
my $barcodeApi = AsposeBarCodeCloud::BarcodeApi->new();

#Set input file name
my $name = 'sample-barcode.jpeg';

#Set mode for checksum validation during recognition
my $checksumValidation = "On";

#Set if FNC symbol stripping should be performed.
my $stripFnc = 'True';

#Set recognition of barcode inside specified Rectangle region
my $rectX = 10;
my $rectY = 10;
my $rectWidth = 200;
my $rectHeight = 200;


#upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);

#invoke Aspose.BarCode Cloud SDK API to read barcode with specific region of image                                   
$response = $barcodeApi->GetBarcodeRecognize(name => $name, checksumValidation => $checksumValidation, 
				stripFnc => $stripFnc, rectX => $rectX, rectY => $rectY, rectWidth => $rectWidth, rectHeight => $rectHeight);

if($response->{'Status'} eq 'OK'){

	foreach my $barcode (@{$response->{'Barcodes'}}){
    print "\n Type :: $barcode->{'BarcodeType'}";
    print "\n Codetext :: $barcode->{'BarcodeValue'}";
	}
}
#ExEnd:1