using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Aspose.Barcode.Model {
    public class BarcodeBuilder
    {
        public float Left { get; set; }

        public string TypeOfBarcode { get; set; }
        public string Text { get; set; }

        public Resolution Resolution { get; set; }
        public float DimensionX { get; set; }

        public float DimensionY { get; set; }
        public string CodeLocation { get; set; }
        public string GraphicsUnit { get; set; }
        public bool AutoSize { get; set; }

        public float BarHeight { get; set; }
        public float ImageHeight { get; set; }

        public float ImageWidth { get; set; }
        public string ImageQuality { get; set; }

        public int RotationAngle { get; set; }
        public Margins Margins { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
        public string CodeTextColor { get; set; }
        public string BorderColor { get; set; }
        public bool BorderVisible { get; set; }
        public string EnableChecksum { get; set; }
    }
}
