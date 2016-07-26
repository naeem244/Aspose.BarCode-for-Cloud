import asposebarcodecloud
from asposebarcodecloud.BarcodeApi import BarcodeApi
from asposebarcodecloud.BarcodeApi import ApiException

import ConfigParser

config = ConfigParser.ConfigParser()
config.readfp(open(r'../../data/config.properties'))
apiKey = config.get('AppConfig', 'api_key') 
appSid = config.get('AppConfig', 'app_sid') 
out_folder = config.get('AppConfig', 'out_folder')
data_folder = "../../data/" #resouece data folder

#ExStart:1
#Instantiate Aspose.Barcode Cloud SDK
api_client = asposebarcodecloud.ApiClient.ApiClient(apiKey, appSid, True)
barcodeApi = BarcodeApi(api_client);

#Set the barcode file name created on server
name = "sample-barcode"

#Set Text to encode inside barcode
text = "Aspose.BarCode"

#Set Barcode Symbology
type = "datamatrix"

#Set Generated Barcode Image Format
format = "PNG"

try:
            
    #invoke Aspose.BarCode Cloud SDK API to create barcode and get image stream
    response = barcodeApi.GetBarcodeGenerate(text=text, type=type, format=format)
    
    if response.Status == "OK":
        #download generated barcode from api response
        outfilename = out_folder + name + "." + format
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)
                        
except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message    
#ExEnd:1