
Imports System

' The Scanning class provides static methods to allow reuse of the same 
' Reader and ReaderData objects on multiple forms.
Public Class Scanning

    Private Shared _MyReader As Symbol.Barcode.Reader = Nothing
    Private Shared _MyReaderData As Symbol.Barcode.ReaderData = Nothing
    Private Shared _MyEventHandler As System.EventHandler = Nothing

    ' MyReaderData property provides access to the ReaderData 
    Public Shared ReadOnly Property MyReaderData() As Symbol.Barcode.ReaderData

        Get
            Return _MyReader.GetNextReaderData()
        End Get

    End Property

    ' Upon completion of a scan a ReadNotify event will be fired. 
    ' _MyEventHandler specifies the delegate that will handle this notification
    ' and MyEventHandler property provides access to _MyEventHandler.
    ' Each form that uses the Scanning class will have it's own delegate.
    ' The form will be responsible for setting this Event Handler to it's delegate.
    Public Shared Property MyEventHandler() As System.EventHandler

        Get
            Return _MyEventHandler
        End Get

        Set(ByVal Value As System.EventHandler)
            _MyEventHandler = Value
        End Set

    End Property

    ' Initialize the reader.
    Public Shared Function InitReader() As Boolean

        ' If reader is already present then fail initialize
        If Not Scanning._MyReader Is Nothing Then

            Return False

        End If

        Try

            ' Create new reader, first available reader will be used.
            Scanning._MyReader = New Symbol.Barcode.Reader

            ' Create reader data
            Scanning._MyReaderData = New Symbol.Barcode.ReaderData( _
                                               Symbol.Barcode.ReaderDataTypes.Text, _
                                               Symbol.Barcode.ReaderDataLengths.MaximumLabel)

            ' Enable reader, with wait cursor
            Scanning._MyReader.Actions.Enable()

            Scanning._MyReader.Parameters.Feedback.Success.BeepTime = 400

        Catch ex As Symbol.Exceptions.OperationFailureException

            Dim res As Symbol.Results = ex.Result
            MessageBox.Show("InitRead" + vbCrLf + "Operation Failure" + vbCrLf + ex.Message() + vbCrLf + "Result = " + res.ToString())

        Catch ex As Symbol.Exceptions.InvalidRequestException
            MessageBox.Show("InitRead" + vbCrLf + "Invalid Request" + vbCrLf + ex.Message)

        Catch ex As Symbol.Exceptions.InvalidIndexerException
            MessageBox.Show("InitRead" + vbCrLf + "Invalid Indexer" + vbCrLf + ex.Message())

        End Try
        Return True

    End Function

    ' Stop reading and disable/close reader
    Public Shared Sub TermReader()

        ' If we have a reader
        If Not (Scanning._MyReader Is Nothing) Then

            Try
                ' Disable the reader
                Scanning._MyReader.Actions.Disable()

                ' Free it up
                Scanning._MyReader.Dispose()

                ' Indicate we no longer have one
                Scanning._MyReader = Nothing

            Catch ex As Symbol.Exceptions.OperationFailureException

                Dim res As Symbol.Results = ex.Result
                MessageBox.Show("TermReader" + vbCrLf + "Operation Failure" + vbCrLf + ex.Message() + vbCrLf + "Result = " + res.ToString())

            Catch ex As Symbol.Exceptions.InvalidRequestException
                MessageBox.Show("TermReader" + vbCrLf + "Invalid Request" + vbCrLf + ex.Message)

            Catch ex As Symbol.Exceptions.InvalidIndexerException
                MessageBox.Show("TermReader" + vbCrLf + "Invalid Indexer" + vbCrLf + ex.Message())

            End Try

        End If

        ' If we have a reader data
        If Not (Scanning._MyReaderData Is Nothing) Then

            Try
                ' Free it up
                Scanning._MyReaderData.Dispose()

                ' Indicate we no longer have one
                Scanning._MyReaderData = Nothing

            Catch ex As Symbol.Exceptions.OperationFailureException

                Dim res As Symbol.Results = ex.Result
                MessageBox.Show("TermReader" + vbCrLf + "Operation Failure" + vbCrLf + ex.Message() + vbCrLf + "Result = " + res.ToString())

            Catch ex As Symbol.Exceptions.InvalidRequestException
                MessageBox.Show("TermReader" + vbCrLf + "Invalid Request" + vbCrLf + ex.Message)

            Catch ex As Symbol.Exceptions.InvalidIndexerException
                MessageBox.Show("TermReader" + vbCrLf + "Invalid Indexer" + vbCrLf + ex.Message())

            End Try

        End If

    End Sub

    ' Start a read on the reader
    Public Shared Sub StartRead()

        'If we have both a reader and a reader data
        If Not ((Scanning._MyReader Is Nothing) And (Scanning._MyReaderData Is Nothing)) Then

            Try
                'Submit a read
                AddHandler Scanning._MyReader.ReadNotify, Scanning._MyEventHandler

                ' Prevent duplicate reads
                If Not (_MyReaderData.IsPending) Then

                    Scanning._MyReader.Actions.Read(Scanning._MyReaderData)

                End If
            Catch ex As Symbol.Exceptions.OperationFailureException

                Dim res As Symbol.Results = ex.Result
                MessageBox.Show("StartRead" + vbCrLf + "Operation Failure" + vbCrLf + ex.Message() + vbCrLf + "Result = " + res.ToString())

                Dim result As Symbol.Results = ex.Result
                If (result = Symbol.Results.E_SCN_READINCOMPATIBLE) Then
                    'If the failure is E_SCN_READINCOMPATIBLE, exit the application.
                    MessageBox.Show("The application will now exit.")
                    Application.Exit()
                    Return
                End If

            Catch ex As Symbol.Exceptions.InvalidRequestException
                MessageBox.Show("StartRead" + vbCrLf + "Invalid Request" + vbCrLf + ex.Message)

            Catch ex As Symbol.Exceptions.InvalidIndexerException
                MessageBox.Show("StartRead" + vbCrLf + "Invalid Indexer" + vbCrLf + ex.Message())

            End Try

        End If

    End Sub

    ' Generates/Toggles a scanner trigger.
    Public Shared Sub ToggleTriger()

        If (Scanning._MyReader Is Nothing) Then

            Return

        End If

        Scanning._MyReader.Actions.ToggleSoftTrigger()

    End Sub

    ' Stop all reads on the reader
    Public Shared Sub StopRead()

        'If we have a reader
        If Not (Scanning._MyReader Is Nothing) Then

            Try
                'Flush (Cancel all pending reads)
                RemoveHandler Scanning._MyReader.ReadNotify, Scanning._MyEventHandler

                Scanning._MyReader.Actions.Flush()
            Catch ex As Symbol.Exceptions.OperationFailureException

                Dim res As Symbol.Results = ex.Result
                MessageBox.Show("StopRead" + vbCrLf + "Operation Failure" + vbCrLf + ex.Message() + vbCrLf + "Result = " + res.ToString())

            Catch ex As Symbol.Exceptions.InvalidRequestException
                MessageBox.Show("StopRead" + vbCrLf + "Invalid Request" + vbCrLf + ex.Message)

            Catch ex As Symbol.Exceptions.InvalidIndexerException
                MessageBox.Show("StopRead" + vbCrLf + "Invalid Indexer" + vbCrLf + ex.Message())

            End Try

        End If

    End Sub

End Class