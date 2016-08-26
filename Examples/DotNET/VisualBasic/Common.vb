Imports System.IO

Class Common
    Public Shared APP_SID As String = "XXXX"
    Public Shared APP_KEY As String = "XXXX"
    Public Shared FOLDER As String = ""
    Public Shared STORAGE As String = ""
    Public Shared BASEPATH As String = "http://api.aspose.com/v1.1"
    Public Shared OUTFOLDER As String = "C://temp/"


    Public Shared Function GetDataDir() As String
        Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
        Dim startDirectory As String = Nothing
        If parent IsNot Nothing Then
            Dim directoryInfo = parent.Parent
            If directoryInfo IsNot Nothing Then
                startDirectory = directoryInfo.FullName
            End If
        Else
            startDirectory = parent.FullName
        End If
        Return Path.Combine(startDirectory, "Data\")
    End Function
    
End Class

