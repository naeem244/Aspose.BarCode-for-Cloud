# -*- encoding: utf-8 -*-
$:.push File.expand_path("../lib", __FILE__)
require "aspose_barcode_cloud/version"

Gem::Specification.new do |s|
  s.name        = "aspose_barcode_cloud"
  s.version     = AsposeBarcodeCloud::VERSION
  s.platform    = Gem::Platform::RUBY
  s.authors     = ["M. Sohail Ismail"]
  s.email       = ["muhammad.sohail@aspose.com"]
  s.homepage    = "http://www.aspose.com/cloud/barcode-api.aspx"
  s.summary     = %q{Aspose.Barcode for Cloud}
  s.description = %q{Aspose.Barcode for Cloud is a REST API for barcode generation and recognition. It helps you generate barcode images from scratch in linear (1D), two dimensional (2D), and postal formats. Generate barcode images in a variety of image formats: JPEG, PNG, GIF, BMP, TIFF and many others. Recognize barcodes from different image types. Aspose.Barcode for Cloud allows you to control all aspects of the image and barcode when generating barcode images. Specify image width, height, border style, output image format and more. You can also set barcode attributes like font style, font color, background color, barcode type and the barcode text location.}
  s.license     = "MIT"

  s.add_runtime_dependency 'typhoeus', '~> 0.8'
  s.add_runtime_dependency 'json', '~> 1.7'
  s.add_runtime_dependency 'aspose_storage_cloud', '~> 1.0', '>= 1.0.0'

  s.add_development_dependency 'minitest', '~> 5.8'

  s.files         = `git ls-files`.split("\n")
  s.test_files    = `git ls-files -- test/*`.split("\n")
  s.executables   = []
  s.require_paths = ["lib"]
end
