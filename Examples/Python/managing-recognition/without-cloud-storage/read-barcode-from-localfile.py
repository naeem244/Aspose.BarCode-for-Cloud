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

#set input file name
name = "sample-barcode.jpeg"
            
try:
            
    #invoke Aspose.BarCode Cloud SDK API to recognition of a barcode from file on server with parameters in body
    response = barcodeApi.PostBarcodeRecognizeFromUrlorContent(file = data_folder + name)
    
    if response.Status == "OK":
        barcodes = response.Barcodes
        for barcode in barcodes:
            print "Type :: " + barcode.BarcodeType
            print "Codetext :: " + barcode.BarcodeValue 
                        
except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message    
#ExEnd:1   