#!/usr/bin/env python

import sys
import os
import urllib

from models import *


class BarcodeApi(object):

    def __init__(self, apiClient):
      self.apiClient = apiClient

    

    def GetBarcodeGenerate(self, **kwargs):
        """Generate barcode.
        Args:
            text (str): The code text. (optional)

            type (str): Barcode type. (optional)

            format (str): Result format. (optional)

            resolutionX (float): Horizontal resolution. (optional)

            resolutionY (float): Vertical resolution. (optional)

            dimensionX (float): Smallest width of barcode unit (bar or space). (optional)

            dimensionY (float): Smallest height of barcode unit (for 2D barcodes). (optional)

            enableChecksum (str): Sets if checksum will be generated. (optional)

            

        Returns: ResponseMessage
        """

        allParams = ['text', 'type', 'format', 'resolutionX', 'resolutionY', 'dimensionX', 'dimensionY', 'enableChecksum']

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetBarcodeGenerate" % key)
            params[key] = val
        del params['kwargs']
        del params['allParams']
        del params['self']
		
        resourcePath = '/barcode/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;enableChecksum={enableChecksum}'
        resourcePath = resourcePath[:resourcePath.find('?')-1]
        resourcePath = self.apiClient.build_uri(resourcePath,params)
		
        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        return self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        

        

    def GetBarcodeRecognize(self, name, **kwargs):
        """Recognize barcode from a file on server.
        Args:
            name (str): The image name. (required)

            type (str): The barcode type. (optional)

            checksumValidation (str): Checksum validation parameter. (optional)

            stripFnc (bool): Allows to strip FNC symbol in recognition results. (optional)

            rotationAngle (int): Allows to correct angle of barcode. (optional)

            barcodesCount (int): Count of barcodes to recognize. (optional)

            rectX (int): Top left point X coordinate of  to recognize barcode inside. (optional)

            rectY (int): Top left point Y coordinate of  to recognize barcode inside. (optional)

            rectWidth (int): Width of  to recognize barcode inside. (optional)

            rectHeight (int): Height of  to recognize barcode inside. (optional)

            storage (str): The image storage. (optional)

            folder (str): The image folder. (optional)

            

        Returns: BarcodeResponseList
        """

        allParams = ['name', 'type', 'checksumValidation', 'stripFnc', 'rotationAngle', 'barcodesCount', 'rectX', 'rectY', 'rectWidth', 'rectHeight', 'storage', 'folder']

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetBarcodeRecognize" % key)
            params[key] = val
        del params['kwargs']
        del params['allParams']
        del params['self']
        print params
		
        resourcePath = '/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;barcodesCount={barcodesCount}&amp;rectX={rectX}&amp;rectY={rectY}&amp;rectWidth={rectWidth}&amp;rectHeight={rectHeight}&amp;storage={storage}&amp;folder={folder}'
        resourcePath = resourcePath[:resourcePath.find('?')-1]
        resourcePath = self.apiClient.build_uri(resourcePath,params)
		
        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        return self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        

        

    def PostBarcodeRecognizeFromUrlorContent(self, file, **kwargs):
        """Recognize barcode from an url.
        Args:
            type (str): Barcode type. (optional)

            checksumValidation (str): Checksum validation parameter. (optional)

            stripFnc (bool): Allows to strip FNC symbol in recognition results. (optional)

            rotationAngle (int): Recognition of rotated barcode. Possible angles are 90, 180, 270, default is 0 (optional)

            url (str): The image file url. (optional)

            file (File):  (required)

            

        Returns: BarcodeResponseList
        """

        allParams = ['type', 'checksumValidation', 'stripFnc', 'rotationAngle', 'url', 'file']

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostBarcodeRecognizeFromUrlorContent" % key)
            params[key] = val
        del params['kwargs']
        del params['allParams']
        del params['self']
		
        resourcePath = '/barcode/recognize/?appSid={appSid}&amp;type={type}&amp;checksumValidation={checksumValidation}&amp;stripFnc={stripFnc}&amp;rotationAngle={rotationAngle}&amp;url={url}'
        resourcePath = resourcePath[:resourcePath.find('?')-1]
        resourcePath = self.apiClient.build_uri(resourcePath,params)
		
        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        return self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        

        

    def PostGenerateMultiple(self, file, **kwargs):
        """Generate multiple barcodes and return in response stream
        Args:
            format (str): Format to return stream in (optional)

            file (File):  (required)

            

        Returns: ResponseMessage
        """

        allParams = ['format', 'file']

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostGenerateMultiple" % key)
            params[key] = val
        del params['kwargs']
        del params['allParams']
        del params['self']
		
        resourcePath = '/barcode/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}'
        resourcePath = resourcePath[:resourcePath.find('?')-1]
        resourcePath = self.apiClient.build_uri(resourcePath,params)
		
        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        return self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        

        

    def PutBarcodeGenerateFile(self, name, file, **kwargs):
        """Generate barcode and save on server.
        Args:
            name (str): The image name. (required)

            text (str): Barcode's text. (optional)

            type (str): The barcode type. (optional)

            format (str): The image format. (optional)

            resolutionX (float): Horizontal resolution. (optional)

            resolutionY (float): Vertical resolution. (optional)

            dimensionX (float): Smallest width of barcode unit (bar or space). (optional)

            dimensionY (float): Smallest height of barcode unit (for 2D barcodes). (optional)

            codeLocation (str): property of the barcode. (optional)

            grUnit (str): Measurement of barcode properties. (optional)

            autoSize (str): Sets if barcode size will be updated automatically. (optional)

            barHeight (float): Height of the bar. (optional)

            imageHeight (float): Height of the image. (optional)

            imageWidth (float): Width of the image. (optional)

            imageQuality (str): Detepmines  of the barcode image. (optional)

            rotAngle (float): Angle of barcode orientation. (optional)

            topMargin (float): Top margin. (optional)

            bottomMargin (float): Bottom margin. (optional)

            leftMargin (float): Left margin. (optional)

            rightMargin (float): Right margin. (optional)

            enableChecksum (str): Sets if checksum will be generated. (optional)

            storage (str): Image's storage. (optional)

            folder (str): Image's folder. (optional)

            file (File):  (required)

            

        Returns: SaaSposeResponse
        """

        allParams = ['name', 'text', 'type', 'format', 'resolutionX', 'resolutionY', 'dimensionX', 'dimensionY', 'codeLocation', 'grUnit', 'autoSize', 'barHeight', 'imageHeight', 'imageWidth', 'imageQuality', 'rotAngle', 'topMargin', 'bottomMargin', 'leftMargin', 'rightMargin', 'enableChecksum', 'storage', 'folder', 'file']

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutBarcodeGenerateFile" % key)
            params[key] = val
        del params['kwargs']
        del params['allParams']
        del params['self']
		
        resourcePath = '/barcode/{name}/generate/?appSid={appSid}&amp;text={text}&amp;type={type}&amp;toFormat={toFormat}&amp;resolutionX={resolutionX}&amp;resolutionY={resolutionY}&amp;dimensionX={dimensionX}&amp;dimensionY={dimensionY}&amp;codeLocation={codeLocation}&amp;grUnit={grUnit}&amp;autoSize={autoSize}&amp;barHeight={barHeight}&amp;imageHeight={imageHeight}&amp;imageWidth={imageWidth}&amp;imageQuality={imageQuality}&amp;rotAngle={rotAngle}&amp;topMargin={topMargin}&amp;bottomMargin={bottomMargin}&amp;leftMargin={leftMargin}&amp;rightMargin={rightMargin}&amp;enableChecksum={enableChecksum}&amp;storage={storage}&amp;folder={folder}'
        resourcePath = resourcePath[:resourcePath.find('?')-1]
        resourcePath = self.apiClient.build_uri(resourcePath,params)
		
        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        return self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        

        

    def PutBarcodeRecognizeFromBody(self, name, body, **kwargs):
        """Recognition of a barcode from file on server with parameters in body.
        Args:
            name (str): The image name. (required)

            type (str): The barcode type. (optional)

            folder (str): The image folder. (optional)

            body (BarcodeReader): BarcodeReader object with parameters. (required)

            

        Returns: BarcodeResponseList
        """

        allParams = ['name', 'type', 'folder', 'body']

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutBarcodeRecognizeFromBody" % key)
            params[key] = val
        del params['kwargs']
        del params['allParams']
        del params['self']
		
        resourcePath = '/barcode/{name}/recognize/?appSid={appSid}&amp;type={type}&amp;folder={folder}'
        resourcePath = resourcePath[:resourcePath.find('?')-1]
        resourcePath = self.apiClient.build_uri(resourcePath,params)
		
        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        return self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        

        

    def PutGenerateMultiple(self, name, file, **kwargs):
        """Generate image with multiple barcodes and put new file on server
        Args:
            name (str): New filename (required)

            format (str): Format of file (optional)

            folder (str): Folder to place file to (optional)

            file (File):  (required)

            

        Returns: SaaSposeResponse
        """

        allParams = ['name', 'format', 'folder', 'file']

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutGenerateMultiple" % key)
            params[key] = val
        del params['kwargs']
        del params['allParams']
        del params['self']
		
        resourcePath = '/barcode/{name}/generateMultiple/?appSid={appSid}&amp;toFormat={toFormat}&amp;folder={folder}'
        resourcePath = resourcePath[:resourcePath.find('?')-1]
        resourcePath = self.apiClient.build_uri(resourcePath,params)
		
        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        return self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        

        

    




