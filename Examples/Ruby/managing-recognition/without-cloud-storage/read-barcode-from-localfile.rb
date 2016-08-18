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

#Instantiate Aspose.BarCode API SDK
@barcodeApi = BarcodeApi.new

#Set the image file url
name = 'sample-barcode.jpeg';

opts = { file: File.open(data_path + "/" << name,"rb"){ |io| io.read }}

#Invoke Aspose.BarCode Cloud SDK API to recognition of a barcode from file on server with parameters in body                                      
response = @barcodeApi.post_barcode_recognize_from_urlor_content(opts)

#print response
response.barcodes.each { |barcode| puts  barcode }

#ExEnd:1