Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Module Koneksi
    Dim strkoneksi As String = "server=localhost;user=root;password=;Persist Security Info=true;database=restoran;Allow User Variables=true"
    Dim dataread As MySqlDataReader
    Dim command As MySqlCommand

    'Koneksi ke database MySql
    Public Function config() As MySqlConnection
        Return New MySqlConnection(strkoneksi)
    End Function

    'Crud

    Public Function NoReturnValue(ByVal strCom As MySqlCommand)
        Using koneksi As MySqlConnection = config()
            koneksi.Open()
            Try
                command = strCom
                command.Connection = koneksi
                command.ExecuteNonQuery()
                MessageBox.Show("Operation Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error, unable to connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MsgBox(ex.ToString())
            End Try
            koneksi.Close()
        End Using
    End Function
    Public Function Read(ByVal strCom As String) As DataTable
        Using koneksi As MySqlConnection = config()
            koneksi.Open()
            Try
                command = New MySqlCommand(strCom, koneksi)
                dataread = command.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            Dim datable As New DataTable
            datable.Load(dataread)
            dataread.Close()
            koneksi.Close()
            Return datable
        End Using
    End Function

    'SHA512 Hashing

    Public Function sha512enc(input As String) As String
        ' Convert the input string to a byte array
        Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)

        ' Create an instance of the SHA512Managed class
        Dim sha512 As New SHA512Managed()

        ' Compute the hash value from the input byte array
        Dim hashBytes As Byte() = sha512.ComputeHash(inputBytes)

        ' Convert the hash byte array to a hexadecimal string
        Dim hashString As New StringBuilder()
        For Each b As Byte In hashBytes
            hashString.Append(b.ToString("x2"))
        Next

        ' Return the hexadecimal string
        Return hashString.ToString()
    End Function

    'Binding

    Public Function Bind(query As String, bindVariables As Array, bindValues As Array)
        Dim queryNow As New MySqlCommand()
        queryNow.CommandText = query
        Dim nilai As Int64 = 0
        For Each key In bindVariables
            queryNow.Parameters.AddWithValue(bindVariables(nilai), bindValues(nilai))
            nilai = nilai + 1
        Next
        Return queryNow
    End Function

    Public Function NoBind(query As String)
        Dim queryNow As New MySqlCommand()
        queryNow.CommandText = query
        Return queryNow
    End Function


End Module
