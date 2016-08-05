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
use AsposeBarCodeCloud::Object::BarcodeReader;

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

#Set BarcodeReader object with special mode of barcode binarization
my @barcodeReaderBody = AsposeBarCodeCloud::Object::BarcodeReader->new('StripFNC' => 'TRUE', 'ChecksumValidation' => 'OFF');

#Upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);

#Invoke Aspose.BarCode Cloud SDK API to recognition of a barcode from file on server with parameters in body                                           
$response = $barcodeApi->PutBarcodeRecognizeFromBody(name => $name, body =>@barcodeReaderBody);

if($response->{'Status'} eq 'OK'){

	foreach my $barcode (@{$response->{'Barcodes'}}){
    print "\n Type :: $barcode->{'BarcodeType'}";
    print "\n Codetext :: $barcode->{'BarcodeValue'}";
	}
}
#ExEnd:1