Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Module Koneksi
    Public koneksi As MySqlConnection
    Dim strkoneksi As String = "server=localhost;uid=root;pwd=;database=restoran"
    Dim dataread As MySqlDataReader
    Dim command As MySqlCommand
    Dim datable As New DataTable
    Sub config()
        koneksi = New MySqlConnection(strkoneksi)
        Try
            koneksi.Open()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Function SqlCommand(strCom As String) As DataTable
        Try
            command = New MySqlCommand(strCom, koneksi)
            dataread = command.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        datable.Load(dataread)
        dataread.Close()
        Return datable
    End Function

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
End Module
