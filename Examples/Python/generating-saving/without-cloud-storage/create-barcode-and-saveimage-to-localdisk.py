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
#Instantiate Aspose Barcode API SDK
api_client = asposebarcodecloud.ApiClient.ApiClient(apiKey, appSid, True)
barcodeApi = BarcodeApi(api_client);

#Set Filename of image
name = "sample-barcode"

#Set Text to encode inside barcode
text = "Aspose.BarCode"

#Set Barcode Symbology
type = "QR"

#Set Barcode Image Format
format = "PNG"

#Set Resolution along X and Y in dpi
resolutionX = 96.0
resolutionY = 96.0

#Set Width and Height of barcode unit
dimensionX = 0.7
dimensionY = 2.0

#Sets if checksum will be added to barcode image.
enableChecksum = "NO"

try:
            
    #invoke Aspose.BarCode Cloud SDK API to create barcode and get barcode image as a stream
    response = barcodeApi.GetBarcodeGenerate(text=text, type=type, format=format, resolutionX=resolutionX, resolutionY=resolutionY, dimensionX=dimensionX, dimensionY=dimensionY, enableChecksum=enableChecksum)
    
    if response.Status == "OK":
        #download generated barcode image from api response
        outfilename = out_folder + name + "." + format
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)        
                        
except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message    
#ExEnd:1    