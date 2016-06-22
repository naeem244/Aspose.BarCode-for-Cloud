exports.models = {
  "HttpStatusCode": {
  "id" : "HttpStatusCode"
},"TextEffect": {
  "id" : "TextEffect"
},"PageBorderAppliesTo": {
  "id" : "PageBorderAppliesTo"
},"BarcodeBuildersList": {
  "id" : "BarcodeBuildersList"
},"Orientation": {
  "id" : "Orientation"
},"PageVerticalAlignment": {
  "id" : "PageVerticalAlignment"
},"NumberStyle": {
  "id" : "NumberStyle"
},"StyleIdentifier": {
  "id" : "StyleIdentifier"
},"PageBorderDistanceFrom": {
  "id" : "PageBorderDistanceFrom"
},"BarcodeReader": {
  "properties" : {
    "ChecksumValidation" : {
      "$ref" : "ChecksumValidation"
    },
    "StripFNC" : {
      "type" : "boolean"
    },
    "BarcodesCount" : {
      "$ref" : "int"
    },
    "RotationAngle" : {
      "$ref" : "int"
    },
    "BinarizationHints" : {
      "$ref" : "BinarizationHints"
    }
  },
  "id" : "BarcodeReader"
},"ResponseMessage": {
  "properties" : {
    "Code" : {
      "$ref" : "int"
    },
    "Message" : {
      "type" : "string"
    }
  },
  "id" : "ResponseMessage"
},"LineNumberRestartMode": {
  "id" : "LineNumberRestartMode"
},"PaperSize": {
  "id" : "PaperSize"
},"ChecksumValidation": {
  "id" : "ChecksumValidation"
},"BarcodeResponseList": {
  "properties" : {
    "Code" : {
      "type" : "string"
    },
    "Status" : {
      "type" : "string"
    }
  },
  "id" : "BarcodeResponseList"
},"BinarizationHints": {
  "id" : "BinarizationHints"
},"ReportType": {
  "id" : "ReportType"
},"Underline": {
  "id" : "Underline"
},"SectionStart": {
  "id" : "SectionStart"
},"HttpResponseMessage": {
  "properties" : {
    "Content" : {
      "type" : "string"
    },
    "Headers" : {
      "type" : "string"
    },
    "IsSuccessStatusCode" : {
      "$ref" : "bool"
    },
    "ReasonPhrase" : {
      "type" : "string"
    },
    "RequestMessage" : {
      "type" : "string"
    },
    "StatusCode" : {
      "type" : "string"
    },
    "Version" : {
      "type" : "string"
    }
  },
  "id" : "HttpResponseMessage"
},"SaaSposeResponse": {
  "properties" : {
    "Code" : {
      "type" : "string"
    },
    "Status" : {
      "type" : "string"
    }
  },
  "id" : "SaaSposeResponse"
}
}