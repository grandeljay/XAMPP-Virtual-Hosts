Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            My.Application.Log.DefaultFileLogWriter.CustomLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & System.Windows.Forms.Application.ProductName
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom

            My.Application.Log.WriteException(e.Exception, TraceEventType.Critical, "Application shut down at " & My.Computer.Clock.GmtTime.ToString & vbNewLine & e.Exception.StackTrace)

            MessageBox.Show(e.Exception.Message, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
    End Class
End Namespace
