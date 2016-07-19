package com.aspose.barcode.cloud.client.examples.generating_saving.cloudStorage;

import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;
import java.util.Properties;

import com.aspose.barcode.api.BarcodeApi;
import com.aspose.barcode.model.SaaSposeResponse;
import com.aspose.storage.api.StorageApi;

/**
 * This sample code allows you to generate barcode with appropriate code text
 * location using Aspose BarCode Cloud API.
 * 
 */
public class GenerateBarcodewithAppropriateCodeTextLocation {

	public static void main(String[] args) {

		Properties prop = new Properties();
		String propFileName = "config.properties";
		// App SID
		String appSID = "";
		// App Key
		String apiKey = "";
		// output folder
		String outFolder = "c:\\temp\\";

		InputStream inputStream = GenerateBarcodewithAppropriateCodeTextLocation.class
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

			// Instantiate Aspose.Storage Cloud API SDK
			StorageApi storageApi = new StorageApi(apiKey, appSID, true);

			// Instantiate Aspose.BarCode Cloud API SDK
			BarcodeApi barcodeApi = new BarcodeApi(apiKey, appSID, true);

			// Set the barcode file name created on server.
			String name = "sample-barcode";
			
			// Set Text to encode inside barcode.
			String text = "AsposeBarCode";
			
			// Set Barcode Symbology
			String type = "Code128";

			// Set Generated Barcode Image Format
			String format = "png";
			
			// Set Resolution along X and Y in dpi.
			Float resolutionX = 0.0f;
			Float resolutionY = 0.0f;

			//Set Width and Height of barcode unit
			Float dimensionX = 0.0f;
			Float dimensionY = 0.0f;
			
			//Set Location, Measurement  of the code
			String codeLocation = "Above";
			String grUnit = "mm";
			
			// Sets if barcode's size will be updated automatically
			String autoSize = "true";
			
			// Height of the bar.
			Float barHeight = 0.0f;
			
			//Set height, Width and quality of the image.
			Float imageHeight = 0.0f;
			Float imageWidth = 0.0f;
			String imageQuality = "default";

			// Set Angle of barcode orientation
			Float rotAngle = 0.0f;
			
			// Set Margin of image border
			Float topMargin = 0.0f;
			Float bottomMargin = 0.0f;
			Float leftMargin = 0.0f;
			Float rightMargin = 0.0f;
			
			// Sets if checksum will be added to barcode image.
			String enableChecksum = "";
			
			//Set 3rd party cloud storage server (if any)
			String storage = "";
			// Set folder location at cloud storage
			String folder = "";

			// Set local file (if any)
			File file = null;

			// invoke Aspose.BarCode Cloud SDK API to generate barcode with
			// appropriate code text location and put in cloud storage
			SaaSposeResponse apiResponse = barcodeApi.PutBarcodeGenerateFile(
					name, text, type, format, resolutionX, resolutionY,
					dimensionX, dimensionY, codeLocation, grUnit, autoSize,
					barHeight, imageHeight, imageWidth, imageQuality, rotAngle,
					topMargin, bottomMargin, leftMargin, rightMargin,
					enableChecksum, storage, folder, file);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				// download generated barcode from cloud storage
				com.aspose.storage.model.ResponseMessage storageRes = storageApi
						.GetDownload(name, null, null);
				InputStream responseStream = storageRes.getInputStream();
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
