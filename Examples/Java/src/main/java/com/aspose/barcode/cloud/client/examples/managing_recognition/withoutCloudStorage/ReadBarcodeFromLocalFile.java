package com.aspose.barcode.cloud.client.examples.managing_recognition.withoutCloudStorage;

import java.io.IOException;
import java.io.InputStream;
import java.util.Properties;

import com.aspose.barcode.api.BarcodeApi;
import com.aspose.barcode.model.Barcode;
import com.aspose.barcode.model.BarcodeReader;
import com.aspose.barcode.model.BarcodeResponseList;
import com.aspose.barcode.model.ChecksumValidation;

/**
 * This sample code allows you to read barcode from local image using Aspose BarCode Cloud API.
 * 

 */
public class ReadBarcodeFromLocalFile {

	public static void main(String[] args) {

		Properties prop = new Properties();
		String propFileName = "config.properties";
		// App SID
		String appSID = "";
		// App Key
		String apiKey = "";
		// output folder
		String outFolder = "c:\\temp\\";

		InputStream inputStream = ReadBarcodeFromLocalFile.class
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

			// set input file name
			String name = "sample-barcode.jpeg";

			// The barcode type.
			// If this parameter is empty, autodetection of all supported types
			// is used.
			String type = "";

			String folder = "";

			BarcodeReader body = new BarcodeReader();

			// Sets if FNC symbol stripping should be performed
			body.setStripFNC(true);

			// Set mode for checksum validation during recognition
			body.setChecksumValidation(ChecksumValidation.OFF);

			// invoke Aspose.BarCode Cloud SDK API to recognition of a barcode
			// from file on server with parameters in body
			BarcodeResponseList apiResponse = barcodeApi
					.PutBarcodeRecognizeFromBody(name, type, folder, body);

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
