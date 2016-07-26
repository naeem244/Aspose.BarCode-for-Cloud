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

#Set the image name
name = "sample-barcode.jpeg"

try:
            
    #upload file to aspose cloud storage
    storageApi.PutCreate(Path=name, file=data_folder + name)

    #invoke Aspose.BarCode Cloud SDK API to read barcode from Aspose Cloud Storage
    response = barcodeApi.GetBarcodeRecognize(name)
    
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