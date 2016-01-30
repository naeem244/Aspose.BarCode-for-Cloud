# Aspose.BarCode Cloud SDK For Ruby
This SDK lets you use [Aspose Cloud Barcode APIs](http://www.aspose.com/cloud/barcode-api.aspx) in your Ruby web apps.

## Installing
You can simply install Aspose Barcode Cloud SDK with gem:

`gem install aspose_barcode_cloud`

## Usage
APIs of this SDK can be called as follows:

```ruby
require 'aspose_barcode_cloud'

class BarcodeUsage
  
  include AsposeBarcodeCloud
  include AsposeStorageCloud
	
  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("APP_KEY", "APP_SID")
    @barcode_api = BarcodeApi.new  
  end
  
  def get_barcode_generate
    #Generate barcode.
    opts = {text: "Dairy Products", type: "qr", format: "png"}
    response = @barcode_api.get_barcode_generate(opts)
  end
  
end
```
## Unit Tests
Aspose Barcode SDK includes a suite of unit tests within the [test](https://github.com/asposebarcode/Aspose_BarCode_Cloud/blob/master/SDKs/Aspose.BarCode_Cloud_SDK_for_Ruby/test/barcode_tests.rb) subdirectory. These Unit Tests also serves as examples of how to use the Aspose Barcode SDK.

## Contact
Your feedback is very important to us. Please email us all your queries and feedback at marketplace@aspose.com.

## License
Aspose Barcode SDK is available under the MIT license. See the [LICENSE](https://github.com/asposebarcode/Aspose_BarCode_Cloud/blob/master/SDKs/Aspose.BarCode_Cloud_SDK_for_Ruby/LICENSE) file for more info.
