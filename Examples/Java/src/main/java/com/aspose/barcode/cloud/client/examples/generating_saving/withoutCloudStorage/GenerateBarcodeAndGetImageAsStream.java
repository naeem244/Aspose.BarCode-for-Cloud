package com.aspose.barcode.cloud.client.examples.generating_saving.withoutCloudStorage;

import java.io.IOException;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;
import java.util.Properties;

import com.aspose.barcode.api.BarcodeApi;
import com.aspose.barcode.model.ResponseMessage;

/**
 * This sample code allows you to create barcode and save image to a stream
 * object using Aspose Cloud Storage. 
 *  
 */
public class GenerateBarcodeAndGetImageAsStream {

	public static void main(String[] args) {

		Properties prop = new Properties();
		String propFileName = "config.properties";
		// App SID
		String appSID = "";
		// App Key
		String apiKey = "";
		// output folder
		String outFolder = "c:\\temp\\";

		InputStream inputStream = GenerateBarcodeAndGetImageAsStream.class
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

			// Instantiate Aspose.BarCode Cloud API SDK
			BarcodeApi barcodeApi = new BarcodeApi(apiKey, appSID, true);

			// Set Filename of image
			String name = "sample-barcode"; 
			
			// Set Text to encode inside barcode
			String text = "Aspose.BarCode"; 
			
			// Set Barcode Symbology
			String type = "datamatrix"; 
			
			// Set Barcode Image Format
			String format = "PNG"; 

			// Sets if checksum will be added to barcode image.
			String enableChecksum = "No"; 

			//Set optional params (if any) 
			Float resolutionX = null;
			Float resolutionY = null;
			Float dimensionX = null;
			Float dimensionY = null;
			

			// invoke Aspose.BarCode Cloud SDK API to create barcode and save image to a stream
			ResponseMessage apiResponse = barcodeApi.GetBarcodeGenerate(text,
					type, format, resolutionX, resolutionY, dimensionX,
					dimensionY, enableChecksum);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				
				// download generated barcode from api response
				InputStream responseStream = apiResponse.getInputStream();
				final Path destination = Paths.get(outFolder + name + "."
						+ format);
				Files.copy(responseStream, destination,
						StandardCopyOption.REPLACE_EXISTING);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd:1
	}

}
