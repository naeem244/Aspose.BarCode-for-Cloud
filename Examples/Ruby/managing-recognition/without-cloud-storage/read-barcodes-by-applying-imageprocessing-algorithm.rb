# Require asposecloudsdk

require 'aspose_barcode_cloud'

include AsposeStorageCloud
include AsposeBarcodeCloud

configFile = File.expand_path("../../../data/config.json", __FILE__);
configProps = JSON.parse( IO.read(configFile, encoding: 'utf-8') )
data_path = File.expand_path("../../../data/", __FILE__);
out_path = configProps['out_folder'];

#ExStart:1
AsposeApp.app_key_and_sid(configProps['api_key'], configProps['app_sid'])
AsposeStorageCloud::Configuration.debugging = false
AsposeBarcodeCloud::Configuration.debugging = false
AsposeBarcodeCloud::Configuration.temp_folder_path = out_path
AsposeStorageCloud::Configuration.temp_folder_path = out_path

#Instantiate Aspose.Storage API SDK
@storageApi = StorageApi.new

#Instantiate Aspose.BarCode API SDK
@barcodeApi = BarcodeApi.new

#Set input file name
name = 'sample-barcode.jpeg';

barcode_reader = BarcodeReader.new

#Set if FNC symbol stripping should be performed.
barcode_reader.strip_fnc = true

#Set special mode of barcode binarization
barcode_reader.binarization_hints = "ComplexBackground"

#Set mode for checksum validation during recognition
barcode_reader.checksum_validation = "Off"

opts = {}

#Upload file to aspose cloud storage
response = @storageApi.put_create(name, File.open(data_path + "/" << name,"rb"){ |io| io.read } )

#Invoke Aspose.BarCode Cloud SDK API to recognition of a barcode from file on server with parameters in body
response = @barcodeApi.put_barcode_recognize_from_body(name, barcode_reader, opts)

#print response
response.barcodes.each { |barcode| puts  barcode }

#ExEnd:1