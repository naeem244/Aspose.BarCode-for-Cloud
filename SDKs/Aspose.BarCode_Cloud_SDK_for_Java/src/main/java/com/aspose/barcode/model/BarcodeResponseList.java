package com.aspose.barcode.model;

import java.util.ArrayList;
import java.util.List;

public class BarcodeResponseList {

  private  List<Barcode> Barcodes = new ArrayList<Barcode>();
  private String Code = null;
  private String Status = null;
  /**
         * getCode
         * Gets String
         * @return Code
         */
  public String getCode() {
    return Code;
  }

        /**
         * setCode
         * Sets String
         * @param Code String
         */
  public void setCode(String Code) {
    this.Code = Code;
  }

  /**
         * getStatus
         * Gets String
         * @return Status
         */
  public String getStatus() {
    return Status;
  }

        /**
         * setStatus
         * Sets String
         * @param Status String
         */
  public void setStatus(String Status) {
    this.Status = Status;
  }


public List<Barcode> getBarcodes() {
         return Barcodes;
      }

      public void setBarcodes(List<Barcode> barcodes) {
         Barcodes = barcodes;
      }

@Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class BarcodeResponseList {\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

