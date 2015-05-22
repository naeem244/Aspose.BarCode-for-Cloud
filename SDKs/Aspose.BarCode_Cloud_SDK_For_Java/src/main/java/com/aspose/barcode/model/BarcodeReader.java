package com.aspose.barcode.model;

import com.aspose.barcode.model.ChecksumValidation;
import com.aspose.barcode.model.BinarizationHints;

public class BarcodeReader {
  private ChecksumValidation ChecksumValidation = null;
  private Boolean StripFNC = null;
  private Integer BarcodesCount = null;
  private Integer RotationAngle = null;
  private BinarizationHints BinarizationHints = null;
  /**
	 * getChecksumValidation
	 * Gets ChecksumValidation
	 * @return ChecksumValidation
	 */
  public ChecksumValidation getChecksumValidation() {
    return ChecksumValidation;
  }

	/**
	 * setChecksumValidation
	 * Sets ChecksumValidation
	 * @param ChecksumValidation ChecksumValidation
	 */
  public void setChecksumValidation(ChecksumValidation ChecksumValidation) {
    this.ChecksumValidation = ChecksumValidation;
  }

  /**
	 * getStripFNC
	 * Gets Boolean
	 * @return StripFNC
	 */
  public Boolean getStripFNC() {
    return StripFNC;
  }

	/**
	 * setStripFNC
	 * Sets Boolean
	 * @param StripFNC Boolean
	 */
  public void setStripFNC(Boolean StripFNC) {
    this.StripFNC = StripFNC;
  }

  /**
	 * getBarcodesCount
	 * Gets Integer
	 * @return BarcodesCount
	 */
  public Integer getBarcodesCount() {
    return BarcodesCount;
  }

	/**
	 * setBarcodesCount
	 * Sets Integer
	 * @param BarcodesCount Integer
	 */
  public void setBarcodesCount(Integer BarcodesCount) {
    this.BarcodesCount = BarcodesCount;
  }

  /**
	 * getRotationAngle
	 * Gets Integer
	 * @return RotationAngle
	 */
  public Integer getRotationAngle() {
    return RotationAngle;
  }

	/**
	 * setRotationAngle
	 * Sets Integer
	 * @param RotationAngle Integer
	 */
  public void setRotationAngle(Integer RotationAngle) {
    this.RotationAngle = RotationAngle;
  }

  /**
	 * getBinarizationHints
	 * Gets BinarizationHints
	 * @return BinarizationHints
	 */
  public BinarizationHints getBinarizationHints() {
    return BinarizationHints;
  }

	/**
	 * setBinarizationHints
	 * Sets BinarizationHints
	 * @param BinarizationHints BinarizationHints
	 */
  public void setBinarizationHints(BinarizationHints BinarizationHints) {
    this.BinarizationHints = BinarizationHints;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class BarcodeReader {\n");
    sb.append("  ChecksumValidation: ").append(ChecksumValidation).append("\n");
    sb.append("  StripFNC: ").append(StripFNC).append("\n");
    sb.append("  BarcodesCount: ").append(BarcodesCount).append("\n");
    sb.append("  RotationAngle: ").append(RotationAngle).append("\n");
    sb.append("  BinarizationHints: ").append(BinarizationHints).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

