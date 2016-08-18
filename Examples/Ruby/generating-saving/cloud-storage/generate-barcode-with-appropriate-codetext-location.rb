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
AsposeBarcodeCloud::Configuration.debugging = false
AsposeBarcodeCloud::Configuration.temp_folder_path = out_path
AsposeStorageCloud::Configuration.temp_folder_path = out_path

#Instantiate Aspose.Storage API SDK
@storageApi = StorageApi.new

#Instantiate Aspose.BarCode API SDK
@barcodeApi = BarcodeApi.new

#Set the barcode file name created on server
name = 'sample-barcode';

#Set Text to encode inside barcode
text = 'Aspose.BarCode for Cloud';

#Set Barcode Symbology
type = 'Code128';

#Set Generated Barcode Image Format
format = 'PNG';

#Set Location of the code
code_location = 'Above';

opts = {text: text, type: type, format: format, code_location: code_location}

#invoke Aspose.BarCode Cloud SDK API to generate barcode with appropriate code text location and put in cloud storage
response = @barcodeApi.put_barcode_generate_file(name, opts)

if response.status == "OK"
  #download barcode from cloud storage
  response = @storageApi.get_download(name)
  response.close
  File.rename response.path, out_path + name + '.' + format
  print "Requested Barcode has been generated at " + out_path + name + '.' + format  
end
#ExEnd:1