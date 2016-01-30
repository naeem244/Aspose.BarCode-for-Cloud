require 'aspose_storage_cloud'

# Common files
require_relative 'aspose_barcode_cloud/api_client'
require_relative 'aspose_barcode_cloud/api_error'
require_relative 'aspose_barcode_cloud/version'
require_relative 'aspose_barcode_cloud/configuration'

# Models
require_relative 'aspose_barcode_cloud/models/base_object'
require_relative 'aspose_barcode_cloud/models/base_response'
require_relative 'aspose_barcode_cloud/models/barcode_response_list'
require_relative 'aspose_barcode_cloud/models/barcode_response'
require_relative 'aspose_barcode_cloud/models/barcode_reader'
require_relative 'aspose_barcode_cloud/models/barcode_builders_list'
require_relative 'aspose_barcode_cloud/models/barcode_builder'
require_relative 'aspose_barcode_cloud/models/resolution'
require_relative 'aspose_barcode_cloud/models/margins'

# APIs
require_relative 'aspose_barcode_cloud/api/barcode_api'

module AsposeBarcodeCloud
  class << self
    # Configure sdk using block.
    # AsposeBarcodeCloud.configure do |config|
    #   config.username = "xxx"
    #   config.password = "xxx"
    # end
    # If no block given, return the configuration singleton instance.
    def configure
      if block_given?
        yield Configuration.instance
      else
        Configuration.instance
      end
    end
  end
end
