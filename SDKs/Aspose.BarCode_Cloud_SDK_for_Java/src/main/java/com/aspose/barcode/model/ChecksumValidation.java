package com.aspose.barcode.model;

public enum  ChecksumValidation {
    OFF("off"),ON("on");
    
    private final String checksumValidationValue;
    
    private ChecksumValidation(final String checksumValidationValue) {
        this.checksumValidationValue = checksumValidationValue;
    }
  
    /* (non-Javadoc)
     * @see java.lang.Enum#toString()
     */
    @Override
    public String toString() {
        return checksumValidationValue;
    }
}

