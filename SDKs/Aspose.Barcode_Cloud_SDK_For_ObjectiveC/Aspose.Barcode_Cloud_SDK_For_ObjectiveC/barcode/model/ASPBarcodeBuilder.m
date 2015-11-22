#import "ASPBarcodeBuilder.h"

@implementation ASPBarcodeBuilder

/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper
{
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"TypeOfBarcode": @"typeOfBarcode", @"Text": @"text", @"Resolution": @"resolution", @"DimensionX": @"dimensionX", @"DimensionY": @"dimensionY", @"CodeLocation": @"codeLocation", @"GraphicsUnit": @"graphicsUnit", @"AutoSize": @"autoSize", @"BarHeight": @"barHeight", @"ImageHeight": @"imageHeight", @"ImageWidth": @"imageWidth", @"ImageQuality": @"imageQuality", @"RotationAngle": @"rotationAngle", @"Margins": @"margins", @"BackColor": @"backColor", @"ForeColor": @"foreColor", @"CodeTextColor": @"codeTextColor", @"BorderColor": @"borderColor", @"BorderVisible": @"borderVisible", @"EnableChecksum": @"enableChecksum" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName
{
  NSArray *optionalProperties = @[@"typeOfBarcode", @"text", @"resolution", @"dimensionX", @"dimensionY", @"codeLocation", @"graphicsUnit", @"autoSize", @"barHeight", @"imageHeight", @"imageWidth", @"imageQuality", @"rotationAngle", @"margins", @"backColor", @"foreColor", @"codeTextColor", @"borderColor", @"borderVisible", @"enableChecksum"];

  if ([optionalProperties containsObject:propertyName]) {
    return YES;
  }
  else {
    return NO;
  }
}

/**
 * Gets the string presentation of the object.
 * This method will be called when logging model object using `NSLog`.
 */
- (NSString *)description {
    return [[self toDictionary] description];
}

@end
