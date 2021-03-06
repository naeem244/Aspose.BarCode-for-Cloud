package com.aspose.barcode.cloud.client.examples.managingRecognition.withoutCloudStorage;

import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.util.Properties;

import com.aspose.barcode.api.BarcodeApi;
import com.aspose.barcode.model.Barcode;
import com.aspose.barcode.model.BarcodeResponseList;

/**
 * This sample code allows you to read barcode from external image URL using
 * Aspose BarCode Cloud API.
 * 
 */
public class ReadBarcodeFromExternalImageURL {

	public static void main(String[] args) {

		Properties prop = new Properties();
		String propFileName = "config.properties";
		// App SID
		String appSID = "";
		// App Key
		String apiKey = "";
		// output folder
		String outFolder = "c:\\temp\\";

		InputStream inputStream = ReadBarcodeFromExternalImageURL.class
				.getClassLoader().getResourceAsStream(propFileName);
		try {
			if (inputStream != null) {
				prop.load(inputStream);
				appSID = prop.getProperty("app_sid");
				apiKey = prop.getProperty("api_key");
				outFolder = prop.getProperty("out_folder");

			} else {
				System.out.println("property file '" + propFileName
						+ "' not found in the classpath");
				System.exit(1);
			}
		} catch (IOException ioe) {
			System.out.println("property file '" + propFileName
					+ "' not found in the classpath");
			ioe.printStackTrace();
			System.exit(1);
		}

		// ExStart:1

		try {

			// Instantiate Aspose BarCode Cloud API SDK
			BarcodeApi barcodeApi = new BarcodeApi(apiKey, appSID, true);

			//The barcode type.
			//If this parameter is empty, autodetection of all supported types is used.
			String type = "";
			
			//Set mode for checksum validation during recognition
			String checksumValidation = "";

			//Sets if FNC symbol stripping should be performed
			Boolean stripFnc = false;
			
			//Sets recognition of rotated barcode
			Integer rotationAngle = 0;
			
			//Set the image file url 
			String url = "http://www.barcoding.com/images/Barcodes/code93.gif";
			
			File file = null;

			// invoke Aspose.BarCode Cloud SDK API to read barcode from external
			// image URL
			BarcodeResponseList apiResponse = barcodeApi
					.PostBarcodeRecognizeFromUrlorContent(type,
							checksumValidation, stripFnc, rotationAngle, url,
							file);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				for (Barcode barcode : apiResponse.getBarcodes()) {
					System.out.println("Codetext: " + barcode.getBarcodeValue()
							+ "\nType: " + barcode.getBarcodeType());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd:1
	}

}
