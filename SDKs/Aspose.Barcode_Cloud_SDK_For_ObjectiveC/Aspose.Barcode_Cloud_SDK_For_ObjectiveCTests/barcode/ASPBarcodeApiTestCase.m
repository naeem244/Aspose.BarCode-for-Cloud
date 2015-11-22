//
//  ASPBarcodeApiTestCase.m
//  Aspose.Barcode_Cloud_SDK_For_ObjectiveC
//
//  Created by Muhammad Sohail Ismail on 03/11/2015.
//  Copyright © 2015 Aspose. All rights reserved.
//

#import <XCTest/XCTest.h>
#import "ASPBarcodeApi.h"
#import "ASPStorageApi.h"

@interface ASPBarcodeApiTestCase : XCTestCase
@property(nonatomic, strong) ASPBarcodeApi *barcodeApi;
@end

@implementation ASPBarcodeApiTestCase

- (void)setUp {
    [super setUp];
    // Put setup code here. This method is called before the invocation of each test method in the class.
    self.barcodeApi = [[ASPBarcodeApi alloc] init];
}

- (void)tearDown {
    // Put teardown code here. This method is called after the invocation of each test method in the class.
    [super tearDown];
}

- (void)uploadFile:(NSString *) fileName {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPStorageApi *storageApi = [[ASPStorageApi alloc] init];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:[fileName stringByDeletingPathExtension] withExtension:[fileName pathExtension]];
    [storageApi putCreateWithCompletionBlock:fileName
                                        file:pathToFile
                                   versionId:nil
                                     storage:nil
                           completionHandler:^(ASPBaseResponse *output, NSError *error) {
                               XCTAssertNotNil(output, @"Failed to upload a specific file.");
                               [expectation fulfill];
                           }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetBarcodeGenerate {
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.barcodeApi getBarcodeGenerateWithCompletionBlock:@"Dairy Products"
                                                      type:@"qr"
                                                    format:@"png"
                                               resolutionX:nil
                                               resolutionY:nil
                                                dimensionX:nil
                                                dimensionY:nil
                                            enableChecksum:nil
                                         completionHandler:^(NSURL *output, NSError *error) {
                                             XCTAssertNotNil(output, @"Failed to generate barcode");
                                             [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutBarcodeGenerateFile {
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.barcodeApi putBarcodeGenerateFileWithCompletionBlock:@"NewBarcode.png"
                                                          text:@"Aspose.Barcode for Cloud"
                                                          type:@"qr"
                                                        format:nil
                                                   resolutionX:nil
                                                   resolutionY:nil
                                                    dimensionX:nil
                                                    dimensionY:nil
                                                  codeLocation:nil
                                                        grUnit:nil
                                                      autoSize:nil
                                                     barHeight:nil
                                                   imageHeight:nil
                                                    imageWidth:nil
                                                  imageQuality:nil
                                                      rotAngle:nil
                                                     topMargin:nil
                                                  bottomMargin:nil
                                                    leftMargin:nil
                                                   rightMargin:nil
                                                enableChecksum:nil
                                                       storage:nil
                                                        folder:nil
                                                        file:nil
                                             completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                                 XCTAssertNotNil(output, @"Failed to generate barcode and save on server.");
                                                 XCTAssertEqualObjects(output.status, @"OK");
                                                 [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutGenerateMultiple {
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPBarcodeBuildersList *barcodeBuildersList = [[ASPBarcodeBuildersList alloc] init];
    barcodeBuildersList.xStep = [NSNumber numberWithInt:1];
    barcodeBuildersList.yStep = [NSNumber numberWithInt:2];
    
    ASPBarcodeBuilder *barcodeBuilder1 = [[ASPBarcodeBuilder alloc] init];
    barcodeBuilder1.typeOfBarcode = @"qr";
    barcodeBuilder1.text = @"Aspose Your File Format APIs";
    
    ASPBarcodeBuilder *barcodeBuilder2 = [[ASPBarcodeBuilder alloc] init];
    barcodeBuilder2.typeOfBarcode = @"qr";
    barcodeBuilder2.text = @"Aspose.Barcode for Cloud";
    
    barcodeBuildersList.barcodeBuilders = (NSArray<ASPBarcodeBuilder>*)@[barcodeBuilder1, barcodeBuilder2];
    
    [self.barcodeApi putGenerateMultipleWithCompletionBlock:@"AsposeBarcode.png"
                                                        dto:barcodeBuildersList
                                                     format:nil
                                                     folder:nil
                                          completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to generate image with multiple barcodes and put new file on server");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostGenerateMultiple {
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPBarcodeBuildersList *barcodeBuildersList = [[ASPBarcodeBuildersList alloc] init];
    barcodeBuildersList.xStep = [NSNumber numberWithInt:1];
    barcodeBuildersList.yStep = [NSNumber numberWithInt:2];
    
    ASPBarcodeBuilder *barcodeBuilder1 = [[ASPBarcodeBuilder alloc] init];
    barcodeBuilder1.typeOfBarcode = @"qr";
    barcodeBuilder1.text = @"Aspose Your File Format APIs";
    
    ASPBarcodeBuilder *barcodeBuilder2 = [[ASPBarcodeBuilder alloc] init];
    barcodeBuilder2.typeOfBarcode = @"qr";
    barcodeBuilder2.text = @"Aspose.Barcode for Cloud";
    
    barcodeBuildersList.barcodeBuilders = (NSArray<ASPBarcodeBuilder>*)@[barcodeBuilder1, barcodeBuilder2];
    
    [self.barcodeApi postGenerateMultipleWithCompletionBlock:barcodeBuildersList
                                                      format:@"png"
                                           completionHandler:^(NSURL *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to generate multiple barcodes and return in response stream");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostBarcodeRecognizeFromUrlorContent {
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.barcodeApi postBarcodeRecognizeFromUrlorContentWithCompletionBlock:@"Code39Standard"
                                                          checksumValidation:nil
                                                                    stripFnc:nil
                                                               rotationAngle:nil
                                                                         url:@"http://www.barcoding.com/images/Barcodes/code93.gif"
                                                                        file:nil
                                                           completionHandler:^(ASPBarcodeResponseList *output, NSError *error) {
                                                               XCTAssertNotNil(output, @"Failed to recognize barcode from an url.");
                                                               XCTAssertEqualObjects(output.status, @"OK");
                                                               [expectation fulfill];
                                                           }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetBarcodeRecognize {
    
    NSString *fileName = @"barcode.png";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.barcodeApi getBarcodeRecognizeWithCompletionBlock:fileName
                                                       type:@"Code39Standard"
                                         checksumValidation:nil
                                                   stripFnc:nil
                                              rotationAngle:nil
                                              barcodesCount:nil
                                                      rectX:nil
                                                      rectY:nil
                                                  rectWidth:nil
                                                 rectHeight:nil
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPBarcodeResponseList *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to recognize barcode from a file on server.");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
     }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutBarcodeRecognizeFromBody {
    
    NSString *fileName = @"sample-barcode.jpeg";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPBarcodeReader *barcodeReader = [[ASPBarcodeReader alloc] init];
    barcodeReader.stripFNC = [NSNumber numberWithBool:YES];
    barcodeReader.checksumValidation = @"Off";
    
    [self.barcodeApi putBarcodeRecognizeFromBodyWithCompletionBlock:fileName
                                                      barcodeReader:barcodeReader
                                                               type:@"Code39Standard"
                                                             folder:nil
                                                  completionHandler:^(ASPBarcodeResponseList *output, NSError *error) {
                                                      XCTAssertNotNil(output, @"Failed to recognize barcode from file on server with parameters in body.");
                                                      XCTAssertEqualObjects(output.status, @"OK");
                                                      [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

@end
