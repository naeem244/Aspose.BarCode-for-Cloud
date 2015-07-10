package com.aspose.barcode.model;

public enum  BinarizationHints {
   None("None"),
   Grayscale("Grayscale"),
   MedianSmoothing("MedianSmoothing"),
   InvertImage("InvertImage"),
   ComplexBackground("ComplexBackground");
      
      private final String binarizationHintsValue;
      
      private BinarizationHints(final String binarizationHintsValue) {
          this.binarizationHintsValue = binarizationHintsValue;
      }
    
      /* (non-Javadoc)
       * @see java.lang.Enum#toString()
       */
      @Override
      public String toString() {
          return binarizationHintsValue;
      }
   
   
}

