#import "ASPBarcodeApi.h"
#import "ASPQueryParamCollection.h"
#import "ASPBarcodeBuildersList.h"
#import "ASPBarcodeResponseList.h"
#import "ASPBaseResponse.h"
#import "ASPBarcodeReader.h"


@interface ASPBarcodeApi ()
    @property (readwrite, nonatomic, strong) NSMutableDictionary *defaultHeaders;
@end

@implementation ASPBarcodeApi

#pragma mark - Initialize methods

- (id) init {
    self = [super init];
    if (self) {
        ASPConfiguration *config = [ASPConfiguration sharedConfig];
        if (config.apiClient == nil) {
            config.apiClient = [[ASPApiClient alloc] init];
        }
        self.apiClient = config.apiClient;
        self.defaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

- (id) initWithApiClient:(ASPApiClient *)apiClient {
    self = [super init];
    if (self) {
        self.apiClient = apiClient;
        self.defaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

#pragma mark -

+(ASPBarcodeApi*) apiWithHeader:(NSString*)headerValue key:(NSString*)key {
    static ASPBarcodeApi* singletonAPI = nil;

    if (singletonAPI == nil) {
        singletonAPI = [[ASPBarcodeApi alloc] init];
        [singletonAPI addHeader:headerValue forKey:key];
    }
    return singletonAPI;
}

-(void) addHeader:(NSString*)value forKey:(NSString*)key {
    [self.defaultHeaders setValue:value forKey:key];
}

-(void) setHeaderValue:(NSString*) value
           forKey:(NSString*)key {
    [self.defaultHeaders setValue:value forKey:key];
}

-(unsigned long) requestQueueSize {
    return [ASPApiClient requestQueueSize];
}

#pragma mark - Api Methods

#pragma mark Barcode Generation

///
/// Generate barcode.
/// 
///  @param text The code text.
///
///  @param type Barcode type.
///
///  @param format Result format.
///
///  @param resolutionX Horizontal resolution.
///
///  @param resolutionY Vertical resolution.
///
///  @param dimensionX Smallest width of barcode unit (bar or space).
///
///  @param dimensionY Smallest height of barcode unit (for 2D barcodes).
///
///  @param enableChecksum Sets if checksum will be generated.
///
///  @returns NSURL*
///
-(NSNumber*) getBarcodeGenerateWithCompletionBlock: (NSString*) text
         type: (NSString*) type
         format: (NSString*) format
         resolutionX: (NSNumber*) resolutionX
         resolutionY: (NSNumber*) resolutionY
         dimensionX: (NSNumber*) dimensionX
         dimensionY: (NSNumber*) dimensionY
         enableChecksum: (NSString*) enableChecksum
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/barcode/generate"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(text != nil) {
        
        queryParams[@"text"] = text;
    }
    if(type != nil) {
        
        queryParams[@"type"] = type;
    }
    if(format != nil) {
        
        queryParams[@"format"] = format;
    }
    if(resolutionX != nil) {
        
        queryParams[@"resolutionX"] = resolutionX;
    }
    if(resolutionY != nil) {
        
        queryParams[@"resolutionY"] = resolutionY;
    }
    if(dimensionX != nil) {
        
        queryParams[@"dimensionX"] = dimensionX;
    }
    if(dimensionY != nil) {
        
        queryParams[@"dimensionY"] = dimensionY;
    }
    if(enableChecksum != nil) {
        
        queryParams[@"enableChecksum"] = enableChecksum;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Generate multiple barcodes and return in response stream
/// 
///  @param dto List of barcodes
///
///  @param format Format to return stream in
///
///  @returns NSURL*
///
-(NSNumber*) postGenerateMultipleWithCompletionBlock: (ASPBarcodeBuildersList*) dto
         format: (NSString*) format
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'dto' is set
    if (dto == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `dto` when calling `postGenerateMultiple`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/barcode/generateMultiple"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(format != nil) {
        
        queryParams[@"format"] = format;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json", @"text/json", @"application/xml", @"text/xml", @"text/javascript", @"application/x-www-form-urlencoded"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = dto;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Generate barcode and save on server.
///
///  @param name The image name.
///
///  @param text Barcode's text.
///
///  @param type The barcode type.
///
///  @param format The image format.
///
///  @param resolutionX Horizontal resolution.
///
///  @param resolutionY Vertical resolution.
///
///  @param dimensionX Smallest width of barcode unit (bar or space).
///
///  @param dimensionY Smallest height of barcode unit (for 2D barcodes).
///
///  @param codeLocation {CodeLocation} property of the barcode.
///
///  @param grUnit Measurement of barcode properties.
///
///  @param autoSize Sets if barcode size will be updated automatically.
///
///  @param barHeight Height of the bar.
///
///  @param imageHeight Height of the image.
///
///  @param imageWidth Width of the image.
///
///  @param imageQuality Detepmines {ImageQualityMode} of the barcode image.
///
///  @param rotAngle Angle of barcode orientation.
///
///  @param topMargin Top margin.
///
///  @param bottomMargin Bottom margin.
///
///  @param leftMargin Left margin.
///
///  @param rightMargin Right margin.
///
///  @param enableChecksum Sets if checksum will be generated.
///
///  @param storage Image's storage.
///
///  @param folder Image's folder.
///
///  @param file
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) putBarcodeGenerateFileWithCompletionBlock: (NSString*) name
                                                  text: (NSString*) text
                                                  type: (NSString*) type
                                                format: (NSString*) format
                                           resolutionX: (NSNumber*) resolutionX
                                           resolutionY: (NSNumber*) resolutionY
                                            dimensionX: (NSNumber*) dimensionX
                                            dimensionY: (NSNumber*) dimensionY
                                          codeLocation: (NSString*) codeLocation
                                                grUnit: (NSString*) grUnit
                                              autoSize: (NSString*) autoSize
                                             barHeight: (NSNumber*) barHeight
                                           imageHeight: (NSNumber*) imageHeight
                                            imageWidth: (NSNumber*) imageWidth
                                          imageQuality: (NSString*) imageQuality
                                              rotAngle: (NSNumber*) rotAngle
                                             topMargin: (NSNumber*) topMargin
                                          bottomMargin: (NSNumber*) bottomMargin
                                            leftMargin: (NSNumber*) leftMargin
                                           rightMargin: (NSNumber*) rightMargin
                                        enableChecksum: (NSString*) enableChecksum
                                               storage: (NSString*) storage
                                                folder: (NSString*) folder
                                                  file: (NSURL*) file

                                     completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock {
    
    
    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putBarcodeGenerateFile`"];
    }
    
    
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/barcode/{name}/generate"];
    
    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }
    
    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    
    
    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(text != nil) {
        
        queryParams[@"text"] = text;
    }
    if(type != nil) {
        
        queryParams[@"type"] = type;
    }
    if(format != nil) {
        
        queryParams[@"format"] = format;
    }
    if(resolutionX != nil) {
        
        queryParams[@"resolutionX"] = resolutionX;
    }
    if(resolutionY != nil) {
        
        queryParams[@"resolutionY"] = resolutionY;
    }
    if(dimensionX != nil) {
        
        queryParams[@"dimensionX"] = dimensionX;
    }
    if(dimensionY != nil) {
        
        queryParams[@"dimensionY"] = dimensionY;
    }
    if(codeLocation != nil) {
        
        queryParams[@"codeLocation"] = codeLocation;
    }
    if(grUnit != nil) {
        
        queryParams[@"grUnit"] = grUnit;
    }
    if(autoSize != nil) {
        
        queryParams[@"autoSize"] = autoSize;
    }
    if(barHeight != nil) {
        
        queryParams[@"barHeight"] = barHeight;
    }
    if(imageHeight != nil) {
        
        queryParams[@"imageHeight"] = imageHeight;
    }
    if(imageWidth != nil) {
        
        queryParams[@"imageWidth"] = imageWidth;
    }
    if(imageQuality != nil) {
        
        queryParams[@"imageQuality"] = imageQuality;
    }
    if(rotAngle != nil) {
        
        queryParams[@"rotAngle"] = rotAngle;
    }
    if(topMargin != nil) {
        
        queryParams[@"topMargin"] = topMargin;
    }
    if(bottomMargin != nil) {
        
        queryParams[@"bottomMargin"] = bottomMargin;
    }
    if(leftMargin != nil) {
        
        queryParams[@"leftMargin"] = leftMargin;
    }
    if(rightMargin != nil) {
        
        queryParams[@"rightMargin"] = rightMargin;
    }
    if(enableChecksum != nil) {
        
        queryParams[@"enableChecksum"] = enableChecksum;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];
    
    
    
    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }
    
    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }
    
    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[]];
    
    // Authentication setting
    NSArray *authSettings = @[];
    
    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    files[@"file"] = file;
    
    
    
    
    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                                          
                                          completionBlock((ASPBaseResponse*)data, error);
                                      }
            ];
}

///
/// Generate image with multiple barcodes and put new file on server
///
///  @param name New filename
///
///  @param dto List of barcodes
///
///  @param format Format of file
///
///  @param folder Folder to place file to
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) putGenerateMultipleWithCompletionBlock: (NSString*) name
                                                dto: (ASPBarcodeBuildersList*) dto
                                             format: (NSString*) format
                                             folder: (NSString*) folder

                                  completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock {
    
    
    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putGenerateMultiple`"];
    }
    
    // verify the required parameter 'dto' is set
    if (dto == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `dto` when calling `putGenerateMultiple`"];
    }
    
    
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/barcode/{name}/generateMultiple"];
    
    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }
    
    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    
    
    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(format != nil) {
        
        queryParams[@"format"] = format;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];
    
    
    
    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json", @"text/json", @"application/xml", @"text/xml", @"text/javascript"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }
    
    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }
    
    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json", @"text/json", @"application/xml", @"text/xml", @"text/javascript", @"application/x-www-form-urlencoded"]];
    
    // Authentication setting
    NSArray *authSettings = @[];
    
    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = dto;
    
    
    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                                          
                                          completionBlock((ASPBaseResponse*)data, error);
                                      }
            ];
}

#pragma mark Barcode Recognition

///
/// Recognize barcode from an url.
/// 
///  @param type Barcode type.
///
///  @param checksumValidation Checksum validation parameter.
///
///  @param stripFnc Allows to strip FNC symbol in recognition results.
///
///  @param rotationAngle Recognition of rotated barcode. Possible angles are 90, 180, 270, default is 0
///
///  @param url The image file url.
///
///  @param file 
///
///  @returns ASPBarcodeResponseList*
///
-(NSNumber*) postBarcodeRecognizeFromUrlorContentWithCompletionBlock: (NSString*) type
         checksumValidation: (NSString*) checksumValidation
         stripFnc: (NSNumber*) stripFnc
         rotationAngle: (NSNumber*) rotationAngle
         url: (NSString*) url
         file: (NSURL*) file
        
        completionHandler: (void (^)(ASPBarcodeResponseList* output, NSError* error))completionBlock { 
        

    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/barcode/recognize"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(type != nil) {
        
        queryParams[@"type"] = type;
    }
    if(checksumValidation != nil) {
        
        queryParams[@"checksumValidation"] = checksumValidation;
    }
    if(stripFnc != nil) {
        
        queryParams[@"stripFnc"] = stripFnc;
    }
    if(rotationAngle != nil) {
        
        queryParams[@"rotationAngle"] = rotationAngle;
    }
    if(url != nil) {
        
        queryParams[@"url"] = url;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json", @"text/json", @"application/xml", @"text/xml", @"text/javascript"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    files[@"file"] = file;
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBarcodeResponseList*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBarcodeResponseList*)data, error);
              }
          ];
}


///
/// Recognize barcode from a file on server.
/// 
///  @param name The image name.
///
///  @param type The barcode type.
///
///  @param checksumValidation Checksum validation parameter.
///
///  @param stripFnc Allows to strip FNC symbol in recognition results.
///
///  @param rotationAngle Allows to correct angle of barcode.
///
///  @param barcodesCount Count of barcodes to recognize.
///
///  @param rectX Top left point X coordinate of {System.Drawing.Rectangle} to recognize barcode inside.
///
///  @param rectY Top left point Y coordinate of {System.Drawing.Rectangle} to recognize barcode inside.
///
///  @param rectWidth Width of {System.Drawing.Rectangle} to recognize barcode inside.
///
///  @param rectHeight Height of {System.Drawing.Rectangle} to recognize barcode inside.
///
///  @param storage The image storage.
///
///  @param folder The image folder.
///
///  @returns ASPBarcodeResponseList*
///
-(NSNumber*) getBarcodeRecognizeWithCompletionBlock: (NSString*) name
         type: (NSString*) type
         checksumValidation: (NSString*) checksumValidation
         stripFnc: (NSNumber*) stripFnc
         rotationAngle: (NSNumber*) rotationAngle
         barcodesCount: (NSNumber*) barcodesCount
         rectX: (NSNumber*) rectX
         rectY: (NSNumber*) rectY
         rectWidth: (NSNumber*) rectWidth
         rectHeight: (NSNumber*) rectHeight
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBarcodeResponseList* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getBarcodeRecognize`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/barcode/{name}/recognize"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(type != nil) {
        
        queryParams[@"type"] = type;
    }
    if(checksumValidation != nil) {
        
        queryParams[@"checksumValidation"] = checksumValidation;
    }
    if(stripFnc != nil) {
        
        queryParams[@"stripFnc"] = stripFnc;
    }
    if(rotationAngle != nil) {
        
        queryParams[@"rotationAngle"] = rotationAngle;
    }
    if(barcodesCount != nil) {
        
        queryParams[@"barcodesCount"] = barcodesCount;
    }
    if(rectX != nil) {
        
        queryParams[@"rectX"] = rectX;
    }
    if(rectY != nil) {
        
        queryParams[@"rectY"] = rectY;
    }
    if(rectWidth != nil) {
        
        queryParams[@"rectWidth"] = rectWidth;
    }
    if(rectHeight != nil) {
        
        queryParams[@"rectHeight"] = rectHeight;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBarcodeResponseList*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBarcodeResponseList*)data, error);
              }
          ];
}

///
/// Recognition of a barcode from file on server with parameters in body.
/// 
///  @param name The image name.
///
///  @param barcodeReader BarcodeReader object with parameters.
///
///  @param type The barcode type.
///
///  @param folder The image folder.
///
///  @returns ASPBarcodeResponseList*
///
-(NSNumber*) putBarcodeRecognizeFromBodyWithCompletionBlock: (NSString*) name
         barcodeReader: (ASPBarcodeReader*) barcodeReader
         type: (NSString*) type
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBarcodeResponseList* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putBarcodeRecognizeFromBody`"];
    }
    
    // verify the required parameter 'barcodeReader' is set
    if (barcodeReader == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `barcodeReader` when calling `putBarcodeRecognizeFromBody`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/barcode/{name}/recognize"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(type != nil) {
        
        queryParams[@"type"] = type;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json", @"text/json", @"application/xml", @"text/xml", @"text/javascript"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json", @"text/json", @"application/xml", @"text/xml", @"text/javascript", @"application/x-www-form-urlencoded"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = barcodeReader;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBarcodeResponseList*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBarcodeResponseList*)data, error);
              }
          ];
}

@end
