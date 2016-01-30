require "minitest/autorun"
require "minitest/unit"

require_relative '../lib/aspose_barcode_cloud'

class BarcodeTests < Minitest::Test
	include MiniTest::Assertions
	include AsposeBarcodeCloud
	include AsposeStorageCloud
	
	def setup
            #Get App key and App SID from https://cloud.aspose.com
            AsposeApp.app_key_and_sid("", "")
	    @barcode_api = BarcodeApi.new
	end

	def teardown
	end

	def upload_file(file_name)
            @storage_api = StorageApi.new
	    response = @storage_api.put_create(file_name, File.open("data/" << file_name,"r") { |io| io.read } )
	    assert(response, message="Failed to upload {file_name} file.")
	end

	def test_get_barcode_generate
            opts = {text: "Dairy Products", type: "qr", format: "png"}

            response = @barcode_api.get_barcode_generate(opts)
	    assert(response, message="Failed to generate barcode")
	end

	def test_post_generate_multiple
            barcode_builders_list = BarcodeBuildersList.new
    	    barcode_builders_list.x_step = 1
    	    barcode_builders_list.y_step = 2
    	    barcode_builder_1 = BarcodeBuilder.new
    	    barcode_builder_1.type_of_barcode = "qr"
    	    barcode_builder_1.text = "Aspose Your File Format APIs"
    	    barcode_builder_2 = BarcodeBuilder.new
    	    barcode_builder_2.type_of_barcode = "qr"
    	    barcode_builder_2.text = "Aspose.Barcode for Cloud"
    	    barcode_builders_list.barcode_builders = [barcode_builder_1, barcode_builder_2]
    	    opts = {format: "png"}

            response = @barcode_api.post_generate_multiple(barcode_builders_list, opts)
	    assert(response, message="Failed to generate multiple barcodes and return in response stream")
	end
	
	def test_post_barcode_recognize_from_urlor_content
            opts = {type: "Code39Standard", url: "http://www.barcoding.com/images/Barcodes/code93.gif"}

            response = @barcode_api.post_barcode_recognize_from_urlor_content(opts)
	    assert(response, message="Failed to recognize barcode from an url.")
	end

	def test_put_barcode_generate_file
	    name = "NewBarcode.png"
            opts = {text: "Aspose.Barcode for Cloud", type: "qr"}

            response = @barcode_api.put_barcode_generate_file(name, opts)
	    assert(response, message="Failed to generate barcode and save on server.")
	end

	def test_put_generate_multiple
	    name = "AsposeBarcode.png"
            barcode_builders_list = BarcodeBuildersList.new
    	    barcode_builders_list.x_step = 1
    	    barcode_builders_list.y_step = 2
    	    barcode_builder_1 = BarcodeBuilder.new
    	    barcode_builder_1.type_of_barcode = "qr"
    	    barcode_builder_1.text = "Aspose Your File Format APIs"
    	    barcode_builder_2 = BarcodeBuilder.new
    	    barcode_builder_2.type_of_barcode = "qr"
    	    barcode_builder_2.text = "Aspose.Barcode for Cloud"
    	    barcode_builders_list.barcode_builders = [barcode_builder_1, barcode_builder_2]

            response = @barcode_api.put_generate_multiple(name, barcode_builders_list)
	    assert(response, message="Failed to generate image with multiple barcodes and put new file on server")
	end

	def test_get_barcode_recognize
            file_name = "barcode.png"
            upload_file(file_name)
            opts = {type: "Code39Standard"}

            response = @barcode_api.get_barcode_recognize(file_name, opts)
	    assert(response, message="Failed to recognize barcode from a file on server.")
	end

	def test_put_barcode_recognize_from_body
            file_name = "sample-barcode.jpeg"
            upload_file(file_name)
            barcode_reader = BarcodeReader.new
    	    barcode_reader.strip_fnc = true
    	    barcode_reader.checksum_validation = "Off"
    	    opts = {type: "Code39Standard"}

            response = @barcode_api.put_barcode_recognize_from_body(file_name, barcode_reader, opts)
	    assert(response, message="Failed to recognize barcode from file on server with parameters in body.")
	end
    
end
