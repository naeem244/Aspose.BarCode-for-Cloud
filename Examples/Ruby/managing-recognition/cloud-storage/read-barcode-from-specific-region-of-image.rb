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

#Set mode for checksum validation during recognition
checksum_validation = 'On'

#Set if FNC symbol stripping should be performed.
strip_fnc = true

#Set recognition of barcode inside specified Rectangle region
rect_x = 10
rect_y = 10
rect_width = 200
rect_height = 200

opts = {checksum_validation: checksum_validation, strip_fnc: strip_fnc, rect_x: rect_x,rect_y: rect_y, rect_width: rect_width, rect_height: rect_height }

#Upload file to aspose cloud storage 
response = @storageApi.put_create(name, File.open(data_path + "/" << name,"rb"){ |io| io.read } )

#Invoke Aspose.BarCode Cloud SDK API to read barcode from Aspose Cloud Storage                           
response =  @barcodeApi.get_barcode_recognize(name, opts)

#print response
response.barcodes.each { |barcode| puts  barcode }
#ExEnd:1