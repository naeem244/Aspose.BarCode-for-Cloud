use lib 'lib';
use strict;
use warnings;
use utf8;
use File::Slurp; # From CPAN
use JSON;

use AsposeBarCodeCloud::BarcodeApi;
use AsposeBarCodeCloud::ApiClient;
use AsposeBarCodeCloud::Configuration;

my $configFile = '../../data/config.json';
my $configPropsText = read_file($configFile);
my $configProps = decode_json($configPropsText);

my $data_path = '../../data/';
my $out_path = $configProps->{'out_folder'};

#ExStart:1
$AsposeBarCodeCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeBarCodeCloud::Configuration::api_key = $configProps->{'api_key'};
$AsposeBarCodeCloud::Configuration::debug = 1;

#Instantiate Aspose.BarCode API SDK
my $barcodeApi = AsposeBarCodeCloud::BarcodeApi->new();

#Set input file name
my $name = 'sample-barcode.jpeg';

#Invoke Aspose.BarCode Cloud SDK API to recognition of a barcode from file on server with parameters in body                                   
my $response = $barcodeApi->PostBarcodeRecognizeFromUrlorContent(file => $data_path.$name);

if($response->{'Status'} eq 'OK'){

	foreach my $barcode (@{$response->{'Barcodes'}}){
    print "\n Type :: $barcode->{'BarcodeType'}";
    print "\n Codetext :: $barcode->{'BarcodeValue'}";
	}
}
#ExEnd:1