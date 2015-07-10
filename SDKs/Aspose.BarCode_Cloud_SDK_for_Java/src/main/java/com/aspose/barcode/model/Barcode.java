package com.aspose.barcode.model;

public class Barcode {

   private String Checksum = null;
   private String[] Region;
   private String BarcodeType = null;
   private String BarcodeValue = null;

   public String getChecksum() {
      return Checksum;
   }

   public void setChecksum(String checksum) {
      Checksum = checksum;
   }

   public String[] getRegion() {
      return Region;
   }

   public void setRegion(String[] region) {
      Region = region;
   }

   public String getBarcodeType() {
      return BarcodeType;
   }

   public void setBarcodeType(String barcodeType) {
      BarcodeType = barcodeType;
   }

   public String getBarcodeValue() {
      return BarcodeValue;
   }

   public void setBarcodeValue(String barcodeValue) {
      BarcodeValue = barcodeValue;
   }

}
