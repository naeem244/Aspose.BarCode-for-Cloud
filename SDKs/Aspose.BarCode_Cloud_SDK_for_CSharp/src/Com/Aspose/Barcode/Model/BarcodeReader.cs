using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Barcode.Model {
  public class BarcodeReader {
    public string ChecksumValidation { get; set; }

    public bool? StripFNC { get; set; }

    public int? BarcodesCount { get; set; }

    public int? RotationAngle { get; set; }

    public BinarizationHints BinarizationHints { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BarcodeReader {\n");
      sb.Append("  ChecksumValidation: ").Append(ChecksumValidation).Append("\n");
      sb.Append("  StripFNC: ").Append(StripFNC).Append("\n");
      sb.Append("  BarcodesCount: ").Append(BarcodesCount).Append("\n");
      sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
      sb.Append("  BinarizationHints: ").Append(BinarizationHints).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
