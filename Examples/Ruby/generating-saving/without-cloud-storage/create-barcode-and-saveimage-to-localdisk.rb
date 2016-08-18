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

#Instantiate Aspose.BarCode API SDK
@barcodeApi = BarcodeApi.new

#Set Filename of image
name = 'sample-barcode';

#Set Text to encode inside barcode
text = 'Aspose.BarCode for Cloud';

#Set Barcode Symbology
type = 'datamatrix';

#Set Barcode Image Format
format = 'png';

#Set Resolution along X and Y in dpi
resolution_x = 96.0;
resolution_y = 96.0;

#Set Width and Height of barcode unit
dimension_x = 0.7;
dimension_y = 2.0;

#Sets if checksum will be added to barcode image
enable_checksum = 'NO';

opts = {text: text, type: type, format: format, resolution_x: resolution_x, resolution_y: resolution_y, dimension_x: dimension_x, dimension_y: dimension_y }

#invoke Aspose.BarCode Cloud SDK API to create barcode and save image to a stream
response = @barcodeApi.get_barcode_generate(opts)
response.close
File.rename response.path, out_path + name + '.' + format
print "Requested Barcode has been generated at " + out_path + name + '.' + format
#ExEnd:1
