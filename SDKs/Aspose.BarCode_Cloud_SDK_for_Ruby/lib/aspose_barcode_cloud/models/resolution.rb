module AsposeBarcodeCloud
  # 
  class Resolution < BaseObject
    attr_accessor :resolution_x, :resolution_y
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'resolution_x' => :'ResolutionX',
        
        # 
        :'resolution_y' => :'ResolutionY'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'resolution_x' => :'Float',
        :'resolution_y' => :'Float'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'ResolutionX']
        self.resolution_x = attributes[:'ResolutionX']
      end
      
      if attributes[:'ResolutionY']
        self.resolution_y = attributes[:'ResolutionY']
      end
      
    end

  end
end
