module AsposeBarcodeCloud
  # 
  class BarcodeBuildersList < BaseObject
    attr_accessor :barcode_builders, :x_step, :y_step
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'barcode_builders' => :'BarcodeBuilders',
        
        # 
        :'x_step' => :'XStep',
        
        # 
        :'y_step' => :'YStep'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'barcode_builders' => :'Array<BarcodeBuilder>',
        :'x_step' => :'Integer',
        :'y_step' => :'Integer'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'BarcodeBuilders']
        if (value = attributes[:'BarcodeBuilders']).is_a?(Array)
          self.barcode_builders = value
        end
      end
      
      if attributes[:'XStep']
        self.x_step = attributes[:'XStep']
      end
      
      if attributes[:'YStep']
        self.y_step = attributes[:'YStep']
      end
      
    end

  end
end
