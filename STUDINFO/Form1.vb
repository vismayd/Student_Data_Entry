Imports System.Data.OleDb
Public Class Form1
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub STUDENT_INFOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENT_INFOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.STUDENT_INFOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.STUDENT_INFODataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STUDENT_INFODataSet.STUDENT_INFO' table. You can move, or remove it, as needed.
        Me.STUDENT_INFOTableAdapter.Fill(Me.STUDENT_INFODataSet.STUDENT_INFO)
        ComboBox1.Visible = True
        TextBox1.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD.Click
        BindingNavigatorAddNewItem.PerformClick()
        ComboBox1.Visible = False
        TextBox1.Visible = True
    End Sub

    Private Sub SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVE.Click
        Try
            STUDENT_INFOBindingNavigatorSaveItem.PerformClick()
            MsgBox("DATA SAVED")
            ComboBox1.Visible = True
            TextBox1.Visible = False
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        Try
            BindingNavigatorDeleteItem.PerformClick()
            MsgBox("DATA DELETED..!")
            ComboBox1.Visible = True
            TextBox1.Visible = False
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

    End Sub

    Private Sub CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEAR.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Visible = False
        TextBox1.Visible = True
    End Sub

    Private Sub CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCEL.Click
        Me.Close()
    End Sub


    Private Sub UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATE.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
        datafile = "D:\Vismay\Docx\STUDENT_INFO.accdb"
        connString = provider & datafile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "update [STUDENT_INFO] set [ROLL_NO]='" & TextBox2.Text & "',[CLASS]='" & TextBox3.Text & "',[DIVISION]='" & TextBox4.Text & "' Where [NAME]='" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ComboBox1.Visible = False
        TextBox1.Visible = True
    End Sub


End Class