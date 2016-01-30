Pod::Spec.new do |s|
  s.name         = "AsposeBarCodeCloud"
  s.version      = "1.0.0"
  s.summary      = "Aspose.BarCode for Cloud"
  s.description  = <<-DESC
                   Aspose.Barcode for Cloud is a REST API for barcode generation and recognition. It helps you generate barcode images from scratch in linear (1D), two dimensional (2D), and postal formats. Generate barcode images in a variety of image formats: JPEG, PNG, GIF, BMP, TIFF and many others. Recognize barcodes from different image types. Aspose.Barcode for Cloud allows you to control all aspects of the image and barcode when generating barcode images. Specify image width, height, border style, output image format and more. You can also set barcode attributes like font style, font color, background color, barcode type and the barcode text location. 
                   DESC

  s.homepage     = "http://www.aspose.com/cloud/barcode-api.aspx"
  s.license = { :type => 'MIT', :file => 'LICENSE'}
  s.author = { "M. Sohail Ismail" => "muhammad.sohail@aspose.com" }
  s.social_media_url = "https://www.facebook.com/asposeplugins/"
  s.platform = :ios, "7.0"
  s.source       = { :git => "https://github.com/asposebarcode/Aspose_BarCode_Cloud.git", :tag => "1.0.0" }
  
  s.subspec 'model' do |ss|
      ss.source_files = 'SDKs/Aspose.Barcode_Cloud_SDK_For_ObjectiveC/Aspose.Barcode_Cloud_SDK_For_ObjectiveC/barcode/model/*.{h,m}'
  end
  s.subspec 'api' do |ss|
      ss.dependency 'AsposeBarCodeCloud/model'
      ss.source_files = 'SDKs/Aspose.Barcode_Cloud_SDK_For_ObjectiveC/Aspose.Barcode_Cloud_SDK_For_ObjectiveC/barcode/api/*.{h,m}'
  end
  
  s.dependency "AFNetworking", "~> 2.0"
  s.dependency "JSONModel", "~> 1.1"
  s.dependency "ISO8601", "~> 0.3"
  s.dependency "AsposeStorageCloud"

  s.requires_arc = true

end