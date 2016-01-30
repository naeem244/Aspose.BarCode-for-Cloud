require "uri"

module AsposeBarcodeCloud
  class BarcodeApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Generate barcode.
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :text The code text.
    # @option opts [String] :type Barcode type.
    # @option opts [String] :format Result format.
    # @option opts [Float] :resolution_x Horizontal resolution.
    # @option opts [Float] :resolution_y Vertical resolution.
    # @option opts [Float] :dimension_x Smallest width of barcode unit (bar or space).
    # @option opts [Float] :dimension_y Smallest height of barcode unit (for 2D barcodes).
    # @option opts [String] :enable_checksum Sets if checksum will be generated.
    # @return [File]
    def get_barcode_generate(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: BarcodeApi#get_barcode_generate ..."
      end
      
      # resource path
      path = "/barcode/generate".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'text'] = opts[:'text'] if opts[:'text']
      query_params[:'type'] = opts[:'type'] if opts[:'type']
      query_params[:'format'] = opts[:'format'] if opts[:'format']
      query_params[:'resolutionX'] = opts[:'resolution_x'] if opts[:'resolution_x']
      query_params[:'resolutionY'] = opts[:'resolution_y'] if opts[:'resolution_y']
      query_params[:'dimensionX'] = opts[:'dimension_x'] if opts[:'dimension_x']
      query_params[:'dimensionY'] = opts[:'dimension_y'] if opts[:'dimension_y']
      query_params[:'enableChecksum'] = opts[:'enable_checksum'] if opts[:'enable_checksum']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = []
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = []
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: BarcodeApi#get_barcode_generate. Result: #{result.inspect}"
      end
      return result
    end

    # Generate multiple barcodes and return in response stream
    # 
    # @param dto List of barcodes
    # @param [Hash] opts the optional parameters
    # @option opts [String] :format Format to return stream in
    # @return [File]
    def post_generate_multiple(dto, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: BarcodeApi#post_generate_multiple ..."
      end
      
      # verify the required parameter 'dto' is set
      fail "Missing the required parameter 'dto' when calling post_generate_multiple" if dto.nil?
      
      # resource path
      path = "/barcode/generateMultiple".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'format'] = opts[:'format'] if opts[:'format']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = []
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(dto)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: BarcodeApi#post_generate_multiple. Result: #{result.inspect}"
      end
      return result
    end

    # Recognize barcode from an url.
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :type Barcode type.
    # @option opts [String] :checksum_validation Checksum validation parameter.
    # @option opts [BOOLEAN] :strip_fnc Allows to strip FNC symbol in recognition results.
    # @option opts [Integer] :rotation_angle Recognition of rotated barcode. Possible angles are 90, 180, 270, default is 0
    # @option opts [String] :url The image file url.
    # @option opts [File] :file 
    # @return [BarcodeResponseList]
    def post_barcode_recognize_from_urlor_content(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: BarcodeApi#post_barcode_recognize_from_urlor_content ..."
      end
      
      # resource path
      path = "/barcode/recognize".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'type'] = opts[:'type'] if opts[:'type']
      query_params[:'checksumValidation'] = opts[:'checksum_validation'] if opts[:'checksum_validation']
      query_params[:'stripFnc'] = opts[:'strip_fnc'] if opts[:'strip_fnc']
      query_params[:'rotationAngle'] = opts[:'rotation_angle'] if opts[:'rotation_angle']
      query_params[:'url'] = opts[:'url'] if opts[:'url']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = []
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["file"] = opts[:'file'] if opts[:'file']

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BarcodeResponseList')
      if Configuration.debugging
        Configuration.logger.debug "API called: BarcodeApi#post_barcode_recognize_from_urlor_content. Result: #{result.inspect}"
      end
      return result
    end

    # Generate barcode and save on server.
    # 
    # @param name The image name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :text Barcode&#39;s text.
    # @option opts [String] :type The barcode type.
    # @option opts [String] :format The image format.
    # @option opts [Float] :resolution_x Horizontal resolution.
    # @option opts [Float] :resolution_y Vertical resolution.
    # @option opts [Float] :dimension_x Smallest width of barcode unit (bar or space).
    # @option opts [Float] :dimension_y Smallest height of barcode unit (for 2D barcodes).
    # @option opts [String] :code_location {CodeLocation} property of the barcode.
    # @option opts [String] :gr_unit Measurement of barcode properties.
    # @option opts [String] :auto_size Sets if barcode size will be updated automatically.
    # @option opts [Float] :bar_height Height of the bar.
    # @option opts [Float] :image_height Height of the image.
    # @option opts [Float] :image_width Width of the image.
    # @option opts [String] :image_quality Detepmines {ImageQualityMode} of the barcode image.
    # @option opts [Float] :rot_angle Angle of barcode orientation.
    # @option opts [Float] :top_margin Top margin.
    # @option opts [Float] :bottom_margin Bottom margin.
    # @option opts [Float] :left_margin Left margin.
    # @option opts [Float] :right_margin Right margin.
    # @option opts [String] :enable_checksum Sets if checksum will be generated.
    # @option opts [String] :storage Image&#39;s storage.
    # @option opts [String] :folder Image&#39;s folder.
    # @option opts [File] :file 
    # @return [BaseResponse]
    def put_barcode_generate_file(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: BarcodeApi#put_barcode_generate_file ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_barcode_generate_file" if name.nil?
      
      # resource path
      path = "/barcode/{name}/generate".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'text'] = opts[:'text'] if opts[:'text']
      query_params[:'type'] = opts[:'type'] if opts[:'type']
      query_params[:'format'] = opts[:'format'] if opts[:'format']
      query_params[:'resolutionX'] = opts[:'resolution_x'] if opts[:'resolution_x']
      query_params[:'resolutionY'] = opts[:'resolution_y'] if opts[:'resolution_y']
      query_params[:'dimensionX'] = opts[:'dimension_x'] if opts[:'dimension_x']
      query_params[:'dimensionY'] = opts[:'dimension_y'] if opts[:'dimension_y']
      query_params[:'codeLocation'] = opts[:'code_location'] if opts[:'code_location']
      query_params[:'grUnit'] = opts[:'gr_unit'] if opts[:'gr_unit']
      query_params[:'autoSize'] = opts[:'auto_size'] if opts[:'auto_size']
      query_params[:'barHeight'] = opts[:'bar_height'] if opts[:'bar_height']
      query_params[:'imageHeight'] = opts[:'image_height'] if opts[:'image_height']
      query_params[:'imageWidth'] = opts[:'image_width'] if opts[:'image_width']
      query_params[:'imageQuality'] = opts[:'image_quality'] if opts[:'image_quality']
      query_params[:'rotAngle'] = opts[:'rot_angle'] if opts[:'rot_angle']
      query_params[:'topMargin'] = opts[:'top_margin'] if opts[:'top_margin']
      query_params[:'bottomMargin'] = opts[:'bottom_margin'] if opts[:'bottom_margin']
      query_params[:'leftMargin'] = opts[:'left_margin'] if opts[:'left_margin']
      query_params[:'rightMargin'] = opts[:'right_margin'] if opts[:'right_margin']
      query_params[:'enableChecksum'] = opts[:'enable_checksum'] if opts[:'enable_checksum']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = []
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["file"] = opts[:'file'] if opts[:'file']

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: BarcodeApi#put_barcode_generate_file. Result: #{result.inspect}"
      end
      return result
    end

    # Generate image with multiple barcodes and put new file on server
    # 
    # @param name New filename
    # @param dto List of barcodes
    # @param [Hash] opts the optional parameters
    # @option opts [String] :format Format of file
    # @option opts [String] :folder Folder to place file to
    # @return [BaseResponse]
    def put_generate_multiple(name, dto, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: BarcodeApi#put_generate_multiple ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_generate_multiple" if name.nil?
      
      # verify the required parameter 'dto' is set
      fail "Missing the required parameter 'dto' when calling put_generate_multiple" if dto.nil?
      
      # resource path
      path = "/barcode/{name}/generateMultiple".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'format'] = opts[:'format'] if opts[:'format']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(dto)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: BarcodeApi#put_generate_multiple. Result: #{result.inspect}"
      end
      return result
    end

    # Recognize barcode from a file on server.
    # 
    # @param name The image name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :type The barcode type.
    # @option opts [String] :checksum_validation Checksum validation parameter.
    # @option opts [BOOLEAN] :strip_fnc Allows to strip FNC symbol in recognition results.
    # @option opts [Integer] :rotation_angle Allows to correct angle of barcode.
    # @option opts [Integer] :barcodes_count Count of barcodes to recognize.
    # @option opts [Integer] :rect_x Top left point X coordinate of {System.Drawing.Rectangle} to recognize barcode inside.
    # @option opts [Integer] :rect_y Top left point Y coordinate of {System.Drawing.Rectangle} to recognize barcode inside.
    # @option opts [Integer] :rect_width Width of {System.Drawing.Rectangle} to recognize barcode inside.
    # @option opts [Integer] :rect_height Height of {System.Drawing.Rectangle} to recognize barcode inside.
    # @option opts [String] :storage The image storage.
    # @option opts [String] :folder The image folder.
    # @return [BarcodeResponseList]
    def get_barcode_recognize(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: BarcodeApi#get_barcode_recognize ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_barcode_recognize" if name.nil?
      
      # resource path
      path = "/barcode/{name}/recognize".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'type'] = opts[:'type'] if opts[:'type']
      query_params[:'checksumValidation'] = opts[:'checksum_validation'] if opts[:'checksum_validation']
      query_params[:'stripFnc'] = opts[:'strip_fnc'] if opts[:'strip_fnc']
      query_params[:'rotationAngle'] = opts[:'rotation_angle'] if opts[:'rotation_angle']
      query_params[:'barcodesCount'] = opts[:'barcodes_count'] if opts[:'barcodes_count']
      query_params[:'rectX'] = opts[:'rect_x'] if opts[:'rect_x']
      query_params[:'rectY'] = opts[:'rect_y'] if opts[:'rect_y']
      query_params[:'rectWidth'] = opts[:'rect_width'] if opts[:'rect_width']
      query_params[:'rectHeight'] = opts[:'rect_height'] if opts[:'rect_height']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = []
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BarcodeResponseList')
      if Configuration.debugging
        Configuration.logger.debug "API called: BarcodeApi#get_barcode_recognize. Result: #{result.inspect}"
      end
      return result
    end

    # Recognition of a barcode from file on server with parameters in body.
    # 
    # @param name The image name.
    # @param barcode_reader BarcodeReader object with parameters.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :type The barcode type.
    # @option opts [String] :folder The image folder.
    # @return [BarcodeResponseList]
    def put_barcode_recognize_from_body(name, barcode_reader, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: BarcodeApi#put_barcode_recognize_from_body ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_barcode_recognize_from_body" if name.nil?
      
      # verify the required parameter 'barcode_reader' is set
      fail "Missing the required parameter 'barcode_reader' when calling put_barcode_recognize_from_body" if barcode_reader.nil?
      
      # resource path
      path = "/barcode/{name}/recognize".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'type'] = opts[:'type'] if opts[:'type']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(barcode_reader)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BarcodeResponseList')
      if Configuration.debugging
        Configuration.logger.debug "API called: BarcodeApi#put_barcode_recognize_from_body. Result: #{result.inspect}"
      end
      return result
    end
  end
end




