module AsposeBarcodeCloud
  # 
  class BarcodeResponse < BaseObject
    attr_accessor :barcode_value, :barcode_type, :region, :checksum
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'barcode_value' => :'BarcodeValue',
        
        # 
        :'barcode_type' => :'BarcodeType',
        
        # 
        :'region' => :'Region',
        
        # 
        :'checksum' => :'Checksum'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'barcode_value' => :'String',
        :'barcode_type' => :'String',
        :'region' => :'Array<String>',
        :'checksum' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'BarcodeValue']
        self.barcode_value = attributes[:'BarcodeValue']
      end
      
      if attributes[:'BarcodeType']
        self.barcode_type = attributes[:'BarcodeType']
      end
      
      if attributes[:'Region']
        if (value = attributes[:'Region']).is_a?(Array)
          self.region = value
        end
      end
      
      if attributes[:'Checksum']
        self.checksum = attributes[:'Checksum']
      end
      
    end

  end
end
