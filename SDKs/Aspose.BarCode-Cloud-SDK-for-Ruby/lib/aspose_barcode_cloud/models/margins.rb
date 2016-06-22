module AsposeBarcodeCloud
  # 
  class Margins < BaseObject
    attr_accessor :left, :right, :top, :bottom
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'left' => :'Left',
        
        # 
        :'right' => :'Right',
        
        # 
        :'top' => :'Top',
        
        # 
        :'bottom' => :'Bottom'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'left' => :'Float',
        :'right' => :'Float',
        :'top' => :'Float',
        :'bottom' => :'Float'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Left']
        self.left = attributes[:'Left']
      end
      
      if attributes[:'Right']
        self.right = attributes[:'Right']
      end
      
      if attributes[:'Top']
        self.top = attributes[:'Top']
      end
      
      if attributes[:'Bottom']
        self.bottom = attributes[:'Bottom']
      end
      
    end

  end
end
