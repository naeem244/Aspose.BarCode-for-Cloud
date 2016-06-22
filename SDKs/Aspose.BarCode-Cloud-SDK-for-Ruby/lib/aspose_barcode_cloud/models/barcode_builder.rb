module AsposeBarcodeCloud
  # 
  class BarcodeBuilder < BaseObject
    attr_accessor :type_of_barcode, :text, :resolution, :dimension_x, :dimension_y, :code_location, :graphics_unit, :auto_size, :bar_height, :image_height, :image_width, :image_quality, :rotation_angle, :margins, :back_color, :fore_color, :code_text_color, :border_color, :border_visible, :enable_checksum
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'type_of_barcode' => :'TypeOfBarcode',
        
        # 
        :'text' => :'Text',
        
        # 
        :'resolution' => :'Resolution',
        
        # 
        :'dimension_x' => :'DimensionX',
        
        # 
        :'dimension_y' => :'DimensionY',
        
        # 
        :'code_location' => :'CodeLocation',
        
        # 
        :'graphics_unit' => :'GraphicsUnit',
        
        # 
        :'auto_size' => :'AutoSize',
        
        # 
        :'bar_height' => :'BarHeight',
        
        # 
        :'image_height' => :'ImageHeight',
        
        # 
        :'image_width' => :'ImageWidth',
        
        # 
        :'image_quality' => :'ImageQuality',
        
        # 
        :'rotation_angle' => :'RotationAngle',
        
        # 
        :'margins' => :'Margins',
        
        # 
        :'back_color' => :'BackColor',
        
        # 
        :'fore_color' => :'ForeColor',
        
        # 
        :'code_text_color' => :'CodeTextColor',
        
        # 
        :'border_color' => :'BorderColor',
        
        # 
        :'border_visible' => :'BorderVisible',
        
        # 
        :'enable_checksum' => :'EnableChecksum'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'type_of_barcode' => :'String',
        :'text' => :'String',
        :'resolution' => :'Resolution',
        :'dimension_x' => :'Float',
        :'dimension_y' => :'Float',
        :'code_location' => :'String',
        :'graphics_unit' => :'String',
        :'auto_size' => :'BOOLEAN',
        :'bar_height' => :'Float',
        :'image_height' => :'Float',
        :'image_width' => :'Float',
        :'image_quality' => :'String',
        :'rotation_angle' => :'Float',
        :'margins' => :'Margins',
        :'back_color' => :'String',
        :'fore_color' => :'String',
        :'code_text_color' => :'String',
        :'border_color' => :'String',
        :'border_visible' => :'BOOLEAN',
        :'enable_checksum' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'TypeOfBarcode']
        self.type_of_barcode = attributes[:'TypeOfBarcode']
      end
      
      if attributes[:'Text']
        self.text = attributes[:'Text']
      end
      
      if attributes[:'Resolution']
        self.resolution = attributes[:'Resolution']
      end
      
      if attributes[:'DimensionX']
        self.dimension_x = attributes[:'DimensionX']
      end
      
      if attributes[:'DimensionY']
        self.dimension_y = attributes[:'DimensionY']
      end
      
      if attributes[:'CodeLocation']
        self.code_location = attributes[:'CodeLocation']
      end
      
      if attributes[:'GraphicsUnit']
        self.graphics_unit = attributes[:'GraphicsUnit']
      end
      
      if attributes[:'AutoSize']
        self.auto_size = attributes[:'AutoSize']
      end
      
      if attributes[:'BarHeight']
        self.bar_height = attributes[:'BarHeight']
      end
      
      if attributes[:'ImageHeight']
        self.image_height = attributes[:'ImageHeight']
      end
      
      if attributes[:'ImageWidth']
        self.image_width = attributes[:'ImageWidth']
      end
      
      if attributes[:'ImageQuality']
        self.image_quality = attributes[:'ImageQuality']
      end
      
      if attributes[:'RotationAngle']
        self.rotation_angle = attributes[:'RotationAngle']
      end
      
      if attributes[:'Margins']
        self.margins = attributes[:'Margins']
      end
      
      if attributes[:'BackColor']
        self.back_color = attributes[:'BackColor']
      end
      
      if attributes[:'ForeColor']
        self.fore_color = attributes[:'ForeColor']
      end
      
      if attributes[:'CodeTextColor']
        self.code_text_color = attributes[:'CodeTextColor']
      end
      
      if attributes[:'BorderColor']
        self.border_color = attributes[:'BorderColor']
      end
      
      if attributes[:'BorderVisible']
        self.border_visible = attributes[:'BorderVisible']
      end
      
      if attributes[:'EnableChecksum']
        self.enable_checksum = attributes[:'EnableChecksum']
      end
      
    end

  end
end
