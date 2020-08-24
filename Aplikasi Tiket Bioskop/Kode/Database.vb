Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
Module Database
    Public con As OleDbConnection
    Public cmd As OleDbCommand
    Public dtr As OleDbDataReader
    Dim mydatatable As DataTable
    Dim adapter As OleDbDataAdapter
    Private bindingSource1 As New BindingSource()
    Public Function _TesDB(ByVal src As String) As Boolean
        con = New OleDbConnection

        con.ConnectionString = "Data Source=|DataDirectory|\Bioskop.accdb;"
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
            Return False
        Finally
            con.Close()
        End Try

    End Function

    Public Function OpenDB() As Boolean
        con = New OleDbConnection

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Bioskop.accdb"
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub _ComboData(ByVal sql As String, ByVal obj As Object)
        OpenDB()
        cmd = New OleDbCommand(sql, con)

        Try
            obj.Items.Clear()
            dtr = cmd.ExecuteReader
            While dtr.Read()
                obj.Items.Add(dtr.Item(0).ToString)
            End While

        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            con.Close()
            con = Nothing
        End Try


    End Sub

    Public Sub _TableData(ByVal sql As String, ByVal obj As Object)
        OpenDB()
        cmd = New OleDbCommand(sql, con)

        Try
            'obj.DataSource = Nothing
            dtr = cmd.ExecuteReader
            obj = New DataTable
            obj.Load(dtr)

        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            dtr.Close()
            con.Close()
        End Try

    End Sub

    Public Function _DataToValue(ByVal sql As String) As String

        OpenDB()
        cmd = New OleDbCommand
        Try
            Dim p As String
            p = ""
            cmd.Connection = con
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = sql
            dtr = cmd.ExecuteReader
            If dtr.HasRows Then
                dtr.Read()
                p = (dtr.Item(0))
            End If
            Return p.ToString
        Catch ex As Exception
            Return ex.Message
        Finally
            'dtr.Close()
            con.Close()
        End Try

    End Function

    Public Sub _RunSQL(ByVal sql As String)
        OpenDB()
        cmd = New OleDbCommand(sql, con)
        Try

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub _BindingView(ByVal sql As String, ByVal obj As DataGridView)
        OpenDB()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim str1 As String = sql
        da.SelectCommand = New OleDbCommand(sql, con)
        da.Fill(ds)
        con.Close()
        obj.DataSource = ds.Tables(0)
    End Sub
    Function _isBOF(ByVal table As String, ByVal field As String, ByVal whereValue As String) As Boolean
        Dim p As Integer
        p = _DataToValue("Select count(" & field & ") from " & table & " Where " & field & "='" & whereValue & "'")
        If p < 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function _isBOF2(ByVal sql As String) As Boolean
        Dim p As Integer
        p = _DataToValue(sql)
        If p < 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function _CreateNumber(ByVal fieldname As String, ByVal tablename As String, ByVal UniqeFirstChar As String) As String
        OpenDB()
        cmd = New OleDbCommand
        Dim Hitung As String
        Dim p As String
        p = ""
        Try

            cmd.Connection = con
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "Select " & fieldname & " from " & tablename
            dtr = cmd.ExecuteReader
            If dtr.HasRows Then
                dtr.Read()

                Hitung = Right(dtr.Item(fieldname), 5) + 1
                p = UniqeFirstChar & "-" & Right("0000" & Hitung, 5)
            Else
                p = UniqeFirstChar & "-" & "00001"
            End If
            Return p.ToString
        Catch ex As Exception
            Return ex.Message
        Finally
            'dtr.Close()
            con.Close()
        End Try
        Return p
    End Function
    Public Sub _TxtNull(ByVal frm As Object)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
End Module
