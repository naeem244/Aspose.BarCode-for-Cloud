module AsposeBarcodeCloud
  # 
  class BarcodeReader < BaseObject
    attr_accessor :checksum_validation, :strip_fnc, :barcodes_count, :rotation_angle, :binarization_hints
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'checksum_validation' => :'ChecksumValidation',
        
        # 
        :'strip_fnc' => :'StripFNC',
        
        # 
        :'barcodes_count' => :'BarcodesCount',
        
        # 
        :'rotation_angle' => :'RotationAngle',
        
        # 
        :'binarization_hints' => :'BinarizationHints'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'checksum_validation' => :'String',
        :'strip_fnc' => :'BOOLEAN',
        :'barcodes_count' => :'Integer',
        :'rotation_angle' => :'Integer',
        :'binarization_hints' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'ChecksumValidation']
        self.checksum_validation = attributes[:'ChecksumValidation']
      end
      
      if attributes[:'StripFNC']
        self.strip_fnc = attributes[:'StripFNC']
      end
      
      if attributes[:'BarcodesCount']
        self.barcodes_count = attributes[:'BarcodesCount']
      end
      
      if attributes[:'RotationAngle']
        self.rotation_angle = attributes[:'RotationAngle']
      end
      
      if attributes[:'BinarizationHints']
        self.binarization_hints = attributes[:'BinarizationHints']
      end
      
    end

  end
end
