Imports Microsoft.IdentityModel.Abstractions

Public Class IdentityLogger
    Implements IIdentityLogger

    Private _minLogLevel As EventLogLevel = EventLogLevel.LogAlways

    Public Sub New(Optional minLogLevel As EventLogLevel = EventLogLevel.LogAlways)
        _minLogLevel = minLogLevel
    End Sub

    Public Function IsEnabled(eventLogLevel As EventLogLevel) As Boolean Implements IIdentityLogger.IsEnabled
        Return eventLogLevel >= _minLogLevel
    End Function

    Public Sub Log(entry As LogEntry) Implements IIdentityLogger.Log
        Debug.WriteLine($"MSAL: EventLogLevel: {entry.EventLogLevel}, Message: {entry.Message} ")
    End Sub
End Class
