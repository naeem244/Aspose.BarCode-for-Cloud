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

#Set the image file url
my $url = 'http://www.barcoding.com/images/Barcodes/code93.gif';

#Invoke Aspose.BarCode Cloud SDK API to read barcode from external image URL                                   
my $response = $barcodeApi->PostBarcodeRecognizeFromUrlorContent(url => $url);

if($response->{'Status'} eq 'OK'){
	foreach my $barcode (@{$response->{'Barcodes'}}){
    print "\n Type :: $barcode->{'BarcodeType'}";
    print "\n Codetext :: $barcode->{'BarcodeValue'}";
	}
}
#ExEnd:1