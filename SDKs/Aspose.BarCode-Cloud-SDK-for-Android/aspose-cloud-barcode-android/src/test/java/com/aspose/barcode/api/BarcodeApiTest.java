package com.aspose.barcode.api;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNull;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import org.apache.commons.io.IOUtils;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

import com.aspose.barcode.client.ApiException;
import com.aspose.barcode.model.BarcodeReader;
import com.aspose.barcode.model.BarcodeResponseList;
import com.aspose.barcode.model.ChecksumValidation;
import com.aspose.barcode.model.ResponseMessage;
import com.aspose.barcode.model.SaaSposeResponse;


public class BarcodeApiTest {
	
	BarcodeApi barcode;
	
	
	String appSID = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
	String apiKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

    
    public BarcodeApiTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
		barcode = new BarcodeApi("http://api.aspose.com/v1.1", apiKey, appSID);
    }
    
    @After
    public void tearDown() {
    }

    @Test 
    public void testGetBarcodeGenerate() {
        System.out.println("GetBarcodeGenerate");
        String text = "newbarcode";
        String type = "1";
        String format = "jpeg";
        Float resolutionX = 0.0f;
        Float resolutionY = 0.0f;
        Float dimensionX = 0.0f;
        Float dimensionY = 0.0f;		
        String enableChecksum = "";
		
		ResponseMessage expResult = new ResponseMessage();
		expResult.setStatus("OK");

		try{
			
		    ResponseMessage result = barcode.GetBarcodeGenerate(text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, enableChecksum);
			IOUtils.copy(result.getInputStream(), new FileOutputStream("F:/aspose/doc/sdk-review/test/test.jpeg"));
			assertEquals(expResult.getStatus(),result.getStatus());
			
		}catch(ApiException apiException){
			System.out.println("exp:"+apiException.getMessage());
            assertNull(apiException);
		} catch (FileNotFoundException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        } catch (IOException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }

    @Test
    public void testGetBarcodeRecognize() {
        System.out.println("GetBarcodeRecognize");
        String name = "barcode1.png";
        String type = "";
        String checksumValidation = "";
        Boolean stripFnc = Boolean.TRUE;
        Integer rotationAngle = Integer.MIN_VALUE;
        Integer barcodesCount = Integer.MIN_VALUE;
        Integer rectX = Integer.SIZE;
        Integer rectY = Integer.SIZE;
        Integer rectWidth = Integer.MIN_VALUE;
        Integer rectHeight = Integer.MIN_VALUE;
        String storage = "";
        String folder = "";
        
        BarcodeResponseList expResult = new BarcodeResponseList();
		expResult.setStatus("OK");
        try{
            BarcodeResponseList result = barcode.GetBarcodeRecognize(name, type, checksumValidation, stripFnc, rotationAngle, barcodesCount, rectX, rectY, rectWidth, rectHeight, storage, folder);
			assertEquals(expResult.getStatus(),result.getStatus());
        }catch(ApiException apiException){
			System.out.println("exp:"+apiException.getMessage());
            assertNull(apiException);
        }
        
    }

    @Test 
    public void testPostBarcodeRecognizeFromUrlorContent() {
        System.out.println("PostBarcodeRecognizeFromUrlorContent");
        String type = "gif";
        String checksumValidation = "";
        Boolean stripFnc = false;
        Integer rotationAngle = 0;
        String url = "http://www.barcoding.com/images/Barcodes/code93.gif";
        
		File file ;

		BarcodeResponseList expResult = new BarcodeResponseList();
		expResult.setStatus("OK");
		
        try{
			file = new File(getClass().getResource("/barcodePng.png").toURI());
            BarcodeResponseList result = barcode.PostBarcodeRecognizeFromUrlorContent(type, checksumValidation, stripFnc, rotationAngle, url, file);
			assertEquals(expResult.getStatus(),result.getStatus());
        }catch(java.net.URISyntaxException uriExp){
			System.out.println("URI exp:"+uriExp.getMessage());			
        }catch(ApiException apiException){
			System.out.println("exp:"+apiException.getMessage());
            assertNull(apiException);

		}
        
    }

    @Test
    public void testPutBarcodeGenerateFile() {
        System.out.println("PutBarcodeGenerateFile");
        String name = "barcode";
        String text = "newbarcode";
        String type = "1";
        String format = "jpeg";
        Float resolutionX = 0.0f;
        Float resolutionY = 0.0f;
        Float dimensionX = 0.0f;
        Float dimensionY = 0.0f;
        String codeLocation = "";
        String grUnit = "";
        String autoSize = "";
        Float barHeight = 0.0f;
        Float imageHeight = 0.0f;
        Float imageWidth = 0.0f;
        String imageQuality = "";
        Float rotAngle = 0.0f;
        Float topMargin = 0.0f;
        Float bottomMargin = 0.0f;
        Float leftMargin = 0.0f;
        Float rightMargin = 0.0f;
        String enableChecksum = "";
        String storage = "";
        String folder = "";             
        File file ;
                
        SaaSposeResponse expResult = new SaaSposeResponse();
                expResult.setStatus("OK");
                
        try{
                        file = new File(getClass().getResource("/barcodePng.png").toURI());
            SaaSposeResponse result = barcode.PutBarcodeGenerateFile(name, text, type, format, resolutionX, resolutionY, dimensionX, dimensionY, codeLocation, grUnit, autoSize, barHeight, imageHeight, imageWidth, imageQuality, rotAngle, topMargin, bottomMargin, leftMargin, rightMargin, enableChecksum, storage, folder, null);
                        assertEquals(expResult.getStatus(),result.getStatus());
        }catch(java.net.URISyntaxException uriExp){
                        System.out.println("URI exp:"+uriExp.getMessage());                     
        }catch(ApiException apiException){
                        System.out.println("exp:"+apiException.getMessage());
            assertNull(apiException);
                }
    }

    @Test
    public void testPutBarcodeRecognizeFromBody() {
        System.out.println("PutBarcodeRecognizeFromBody");
        String name = "barcode3.png";
        String type = "1";
        String folder = "";
        
        BarcodeReader body = new BarcodeReader();
        body.setStripFNC(true);
        body.setChecksumValidation(ChecksumValidation.OFF);
        
        BarcodeResponseList expResult = new BarcodeResponseList();
		expResult.setStatus("OK");
        try{
            BarcodeResponseList result = barcode.PutBarcodeRecognizeFromBody(name, type, folder, body);
			assertEquals(expResult.getStatus(),result.getStatus());
        }catch(ApiException apiException){
			System.out.println("exp:"+apiException.getMessage());
            assertNull(apiException);
        }
    }
    
}
