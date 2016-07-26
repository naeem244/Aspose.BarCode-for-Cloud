import asposebarcodecloud
from asposebarcodecloud.BarcodeApi import BarcodeApi
from asposebarcodecloud.BarcodeApi import ApiException

import asposestoragecloud 
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.StorageApi import ResponseMessage

import ConfigParser

config = ConfigParser.ConfigParser()
config.readfp(open(r'../../data/config.properties'))
apiKey = config.get('AppConfig', 'api_key') 
appSid = config.get('AppConfig', 'app_sid') 
out_folder = config.get('AppConfig', 'out_folder')
data_folder = "../../data/" #resouece data folder

#ExStart:1
#Instantiate Aspose Storage API SDK
storage_apiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, True)
storageApi = StorageApi(storage_apiClient)
#Instantiate Aspose Barcode API SDK
api_client = asposebarcodecloud.ApiClient.ApiClient(apiKey, appSid, True)
barcodeApi = BarcodeApi(api_client);

#Set the barcode file name created on server
name = "sample-barcode"

#Set Text to encode inside barcode.
text = "Aspose.BarCode"

#Set Barcode Symbology
type = "Code128"

#Set Generated Barcode Image Format
format = "PNG"

#Set height, Width and quality of the image
imageHeight = 1.0;
imageWidth = 1.0;
imageQuality = "default";


try:
            
    #invoke Aspose.BarCode Cloud SDK API to generate image with specific height, width, and quality along with auto size option
    response = barcodeApi.PutBarcodeGenerateFile(name, file= None, text=text, type=type, format=format, imageHeight=imageHeight, imageWidth=imageWidth, imageQuality=imageQuality)
    
    if response.Status == "OK":
        #download generated barcode from cloud storage
        response = storageApi.GetDownload(Path=name)
        outfilename = out_folder + name + "." + format
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)        
                        
except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message    
#ExEnd:1