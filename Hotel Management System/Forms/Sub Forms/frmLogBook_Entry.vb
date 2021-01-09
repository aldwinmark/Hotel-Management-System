Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmLogBook_Entry

    Friend GenID As Integer

    Dim Others As Decimal
    Dim Rate As Decimal
    Dim NoOfNigths As Integer
    Dim TotalAccomodations As Decimal
    Dim Extras As Decimal
    Dim Discount As Decimal

    Dim AmountPaid As Decimal
    Dim AdvancePayment As Decimal

    Dim AmountDue As Decimal
    Dim AmountAdv As Decimal

    'system log
    Dim strAmountPaid As String
    Dim strAdvance As String
    Dim strLocalTax As String
    Dim strReservationIN As String
    Dim strReservationOUT As String
    Dim strOthers As String
    Dim strDiscount As String

#Region "User Functions"
    'get the real datetime of check-in
    Private Function GetCI() As String
        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblLogBook WHERE GenID=" & GenID & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()

        'While Reader.Read
        If Reader.HasRows = True Then
            GetCI = Reader("CI").ToString
        Else
            GetCI = ""
        End If
        'End While

        'close the reader
        Reader.Close()
        Return GetCI
    End Function
    'get the real datetime of check-in
    Private Function GetCO() As String
        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblLogBook WHERE GenID=" & GenID & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()

        'While Reader.Read
        If Reader.HasRows = True Then
            GetCO = Reader("CO").ToString
        Else
            GetCO = ""
        End If
        'End While

        'close the reader
        Reader.Close()
        Return GetCO
    End Function

    Private Function CheckIfReserved() As Boolean

        Dim count As Integer = 0
        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblLogBook WHERE RoomNo='" & Me.cmbxRoomNo.Text & "' AND ReservationStatus='Reserved' AND (Check_IN=#" & Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("In") & "# OR Check_OUT=#" & Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("Out") & "#)"
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()

        'While Reader.Read
        If Reader.HasRows = True Then
            CheckIfReserved = True
        Else
            CheckIfReserved = False
        End If
        'End While

        'close the reader
        Reader.Close()

        Return CheckIfReserved

    End Function

    Private Function CheckIfDateInBetweenDate() As Boolean
        'initialize to false
        CheckIfDateInBetweenDate = False

        Dim ds1 As DataSet = New DataSet
        Dim CheckIN As Date
        Dim CheckOut As Date

        CheckConnection(cn)
        ds1.Clear()
        oledbda.SelectCommand = New OleDbCommand("SELECT * FROM tblLogBook WHERE RoomNo='" & Me.cmbxRoomNo.Text & "' AND ReservationStatus<>'Paid'", cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds1)

        CheckIN = Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("In")
        CheckOut = Me.dtpCheckOut.Value.ToShortDateString & " " & GetCheckTime("Out")

        If ds1.Tables(0).Rows.Count > 0 Then
            For Each dr In ds1.Tables(0).Rows
                'check within the date reserved
                If (CheckIN >= dr("Check_IN") And CheckIN <= dr("Check_OUT")) Or (CheckOut >= dr("Check_IN") And CheckOut <= dr("Check_OUT")) Then
                    'MsgBox(dr("Check_IN") & "--" & dr("Check_OUT"))
                    CheckIfDateInBetweenDate = True
                    'return directly the value if true
                    Return CheckIfDateInBetweenDate
                    'check if reservation date has a reservation within it    
                ElseIf CheckIN <= dr("Check_IN") And dr("Check_OUT") <= CheckOut Then
                    'MsgBox(dr("Check_IN") & "--" & dr("Check_OUT"))
                    CheckIfDateInBetweenDate = True
                    'return directly the value if true
                    Return CheckIfDateInBetweenDate
                Else
                    CheckIfDateInBetweenDate = False
                End If
            Next
        End If
        cn.Close()

        Return CheckIfDateInBetweenDate

    End Function

    Private Function CheckIfRoomOccupied(ByVal RoomNo As String) As Boolean

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblRooms WHERE RoomNo='" & RoomNo & "'"
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            If Reader("RoomStatus") = 1 Then
                CheckIfRoomOccupied = True
            Else
                CheckIfRoomOccupied = False
            End If
        Else
            CheckIfRoomOccupied = False
        End If

        'close the reader
        Reader.Close()

        Return CheckIfRoomOccupied

    End Function

    Private Sub DelLogOthers(ByVal GenID As String)

        Dim StrSelect As String
        StrSelect = "DELETE FROM tblLogOthers " & _
                                  "WHERE GenID='" & GenID & "'"
        CheckConnection(cn)
        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub DelLogCustomer(ByVal GenID As String)

        Dim StrSelect As String
        StrSelect = "DELETE FROM tblLogCustomer " & _
                                  "WHERE GenID='" & GenID & "'"
        CheckConnection(cn)
        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub DelAdvances(ByVal GenID As String)

        Dim StrSelect As String
        StrSelect = "DELETE FROM tblAdvances " & _
                                  "WHERE GenID='" & GenID & "'"
        CheckConnection(cn)
        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Private Function CheckIfLogOthersExist(ByVal ID As String) As Boolean

        If Not ID = "" Then
            CheckConnection(cn)
            Dim StrSelect = "SELECT * FROM tblLogOthers WHERE Id=" & ID & ""
            Dim cmd As New OleDbCommand(StrSelect, cn)
            Dim Reader As OleDbDataReader = cmd.ExecuteReader
            Reader.Read()
            If Reader.HasRows = True Then
                CheckIfLogOthersExist = True
            Else
                CheckIfLogOthersExist = False
            End If

            'close the reader
            Reader.Close()

        Else
            CheckIfLogOthersExist = False
        End If

        Return CheckIfLogOthersExist

    End Function

    Private Function CheckIfLogCustExist(ByVal GenID As String, ByVal ID As String) As Boolean

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblLogCustomer WHERE GenID='" & GenID & "' AND CustomerID='" & ID & "'"
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            CheckIfLogCustExist = True
        Else
            CheckIfLogCustExist = False
        End If

        'close the reader
        Reader.Close()

        Return CheckIfLogCustExist

    End Function

    Private Function getCustomerData_Address(ByVal ID As Integer) As String

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblCustomer WHERE Id=" & ID & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            getCustomerData_Address = Reader("Address")
        Else
            getCustomerData_Address = ""
        End If

        'close the reader
        Reader.Close()

        Return getCustomerData_Address

    End Function

    Private Function getCustomerData_FullName(ByVal ID As Integer) As String

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblCustomer WHERE Id=" & ID & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            getCustomerData_FullName = Reader("FullName")
        Else
            getCustomerData_FullName = ""
        End If

        'close the reader
        Reader.Close()

        Return getCustomerData_FullName

    End Function

    Private Sub SaveLogCustomer()

        Dim x As Integer
        Dim strSelect As String

        For x = 0 To Me.lstvwCustomer.Items.Count - 1

            If CheckIfLogCustExist(GenID, Me.lstvwCustomer.Items(x).SubItems(0).Text) = False Then
                strSelect = "INSERT INTO tblLogCustomer" & _
                                                  "([GenID],[CustomerID])VALUES " & _
                                                  "('" & GenID & "','" & Me.lstvwCustomer.Items(x).SubItems(0).Text & "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(strSelect, cn)
                cmdSave.ExecuteNonQuery()
            End If

        Next

    End Sub

    Private Sub SaveAdvances()

        Dim x As Integer = 0
        Dim strSelect As String

        For x = 0 To Me.lstvwAdvances.Items.Count - 1

            strSelect = "INSERT INTO tblAdvances" & _
                                              "([GenID],[DatePaid],[RoomNo],[GuestName],[PType],[ReceivedBy],[AdvancePayment])VALUES " & _
                                              "('" & GenID & "','" & Me.lstvwAdvances.Items(x).SubItems(0).Text & "','" & Me.cmbxRoomNo.Text & "','" & Me.lstvwCustomer.Items(0).SubItems(1).Text & "','" & Me.lstvwAdvances.Items(x).SubItems(1).Text & "','" & Me.lstvwAdvances.Items(x).SubItems(2).Text & "','" & Me.lstvwAdvances.Items(x).SubItems(3).Text & "')"

            CheckConnection(cn)
            Dim cmdSave As New OleDbCommand(strSelect, cn)
            cmdSave.ExecuteNonQuery()

        Next

    End Sub

    Private Sub SaveLogOthers()

        Dim x As Integer
        Dim strSelect As String

        For x = 0 To Me.lstvwOthers.Items.Count - 1

            If CheckIfLogOthersExist(Me.lstvwOthers.Items(x).SubItems(0).Text) = False Then
                strSelect = "INSERT INTO tblLogOthers" & _
                                                  "([GenID],[Description],[Amount],[DateInputed],[ReferenceID])VALUES " & _
                                                  "('" & GenID & "','" & Me.lstvwOthers.Items(x).SubItems(3).Text & "'," & CDec(Me.lstvwOthers.Items(x).SubItems(4).Text) & ",'" & Me.lstvwOthers.Items(x).SubItems(1).Text & "','" & Me.lstvwOthers.Items(x).SubItems(2).Text & "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(strSelect, cn)
                cmdSave.ExecuteNonQuery()
            End If

        Next

    End Sub

    Friend Sub SetRoomStatus(ByVal Status As Integer, ByVal RoomNo As String, ByVal LogID As String)

        Dim strSelect As String

        strSelect = "UPDATE tblRooms SET" & _
                    "[RoomStatus]='" & Status & _
                    "',[GenID]=" & LogID & _
                    " WHERE RoomNo='" & RoomNo & "'"

        CheckConnection(cn)

        Dim cmd As New OleDbCommand(strSelect, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Friend Sub GetReservationData()

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblLogBook WHERE GenID=" & GenID & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.cmbxRoomNo.Text = Reader("RoomNo")
            Me.lblRate.Text = Reader("Rate")
            Me.lblFloor.Text = Reader("Floor")
            Me.lblRoomDescription.Text = Reader("Description")
            Me.lblRoomEquipments.Text = Reader("Equipments")
            Me.lblSB.Text = Reader("SB")
            Me.lblDB.Text = Reader("DB")
            Me.lblExtraB.Text = Reader("ExtraB")
            Me.dtpCheckIn.Value = Reader("Check_IN")
            Me.dtpCheckOut.Value = Reader("Check_OUT")
            Me.nudNights.Value = Reader("Nights")
            Me.txtAmountPaid.Text = FormatNumber(Reader("AmountPaid"))
            Me.txtAdvance.Text = FormatNumber(Reader("AdvancePayment"))
            Me.txtLocalTax.Text = FormatNumber(Reader("LocalTax"))
            Me.cmbxPaymentType.Text = Reader("PaymentType")
            Me.cmbxReservationStatus.Text = Reader("ReservationStatus")
            Me.txtDiscount.Text = Reader("Discount")
            Me.txtComment.Text = Reader("Comments")

            strAmountPaid = FormatNumber(Reader("AmountPaid"))
            strAdvance = FormatNumber(Reader("AdvancePayment"))
            strLocalTax = FormatNumber(Reader("LocalTax"))
            strReservationIN = Reader("Check_IN")
            strReservationOUT = Reader("Check_OUT")
            strOthers = Reader("Others")
            strDiscount = Reader("Discount")

            ComputeTotal()

        End If

        'close the reader
        Reader.Close()

    End Sub

    Friend Sub ComputeTotal()
        Dim x As Integer
        Dim y As Integer
        Others = 0
        Try
            Rate = CDec(Me.lblRate.Text)
            NoOfNigths = CInt(Me.lblNoOfNights.Text)
            TotalAccomodations = CDec(Me.lblTotalAccomodation.Text)
            Extras = CDec(Me.lblExtras.Text)
            Discount = CDec(Me.txtDiscount.Text)

            AmountPaid = CDec(Me.txtAmountPaid.Text)
            AmountAdv = CDec(Me.txtAdvance.Text)
            AmountDue = CDec(Me.lblAmountDue.Text)

            Me.lblTotalAccomodation.Text = FormatNumber(Rate * NoOfNigths)
            Me.lblGrandTotal.Text = FormatNumber((CDec(Me.lblTotalAccomodation.Text) + Extras) - Discount)

            'compute for amount due
            AmountDue = CDec(Me.lblGrandTotal.Text)

            For x = 0 To Me.lstvwOthers.Items.Count - 1
                AmountDue += CDec(Me.lstvwOthers.Items(x).SubItems(4).Text)
                Others += CDec(Me.lstvwOthers.Items(x).SubItems(4).Text)
            Next

            'compute for amount advance
            AmountAdv = 0 'CDec(Me.txtAdvance.Text)

            For y = 0 To Me.lstvwAdvances.Items.Count - 1
                AmountAdv += CDec(Me.lstvwAdvances.Items(y).SubItems(3).Text)
            Next

            Me.txtAdvance.Text = AmountAdv
            'Me.lblAmountDue.Text =  (AmountPaid + AmountAdv)
            Me.lblAmountDue.Text = AmountDue - AmountPaid
            Me.lblLocalTax.Text = CDec(Me.txtLocalTax.Text)
            Me.lblAmountDueWtTax.Text = CDec(Me.lblAmountDue.Text) + CDec(Me.lblLocalTax.Text)


        Catch ex As Exception
        End Try


    End Sub

    Private Sub ReservationDays()
        Me.dtpCheckOut.Value = (Me.dtpCheckIn.Value.AddDays(CInt(Me.nudNights.Value)))
        Me.lblNoOfNights.Text = Me.nudNights.Value
    End Sub

    Public Sub GetRoomInfo(ByVal RoomNo As String)

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblRooms WHERE RoomNo='" & RoomNo & "'"
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.lblFloor.Text = Reader("FloorNo")
            Me.lblRoomType.Text = Reader("RoomType")
            Me.lblSB.Text = Reader("SB")
            Me.lblDB.Text = Reader("DB")
            Me.lblExtraB.Text = Reader("ExtraBed")
            Me.lblRoomDescription.Text = Reader("RoomDescription")
            Me.lblRate.Text = Reader("Rate")
            Me.lblRoomEquipments.Text = Reader("Equipments")
        Else
            Me.lblFloor.Text = ""
            Me.lblRoomType.Text = ""
            Me.lblSB.Text = ""
            Me.lblDB.Text = ""
            Me.lblExtraB.Text = ""
            Me.lblRoomDescription.Text = ""
            Me.lblRate.Text = "0.00"
            Me.lblRoomEquipments.Text = ""
        End If

        'close the reader
        Reader.Close()

    End Sub

#End Region

#Region "Filling Functions"

    Private Sub FillAdvData(ByVal SqlString As String)
        Me.lstvwAdvances.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwAdvances.Items.Add(dr("DatePaid"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    If IsDBNull(dr("PType")) = True Then
                        .SubItems.Add("")
                    Else
                        .SubItems.Add(dr("PType"))
                    End If
                    If IsDBNull(dr("ReceivedBy")) = True Then
                        .SubItems.Add("")
                    Else
                        .SubItems.Add(dr("ReceivedBy"))
                    End If
                    .SubItems.Add(FormatNumber(dr("AdvancePayment"), 2))
                End With
            Next
        End If
        cn.Close()

    End Sub

    Private Sub FillOthersData(ByVal SqlString As String)
        Me.lstvwOthers.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwOthers.Items.Add(dr("Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("DateInputed"))
                    .SubItems.Add(dr("ReferenceID"))
                    .SubItems.Add(dr("Description"))
                    .SubItems.Add(FormatNumber(dr("Amount")))
                End With
            Next
        End If
        cn.Close()

    End Sub

    Private Sub FillCustomerData(ByVal SqlString As String)
        Me.lstvwCustomer.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwCustomer.Items.Add(dr("CustomerID"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(getCustomerData_FullName(dr("CustomerID")))
                    .SubItems.Add(getCustomerData_Address(dr("CustomerID")))
                End With
            Next
        End If
        cn.Close()

    End Sub

    Private Sub FillRooms(ByVal Sqlstring As String)
        Me.cmbxRoomNo.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        Me.cmbxRoomNo.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxRoomNo.Items.Add(dr("RoomNo"))
            Next
        End If
        Me.cmbxRoomNo.Text = "<select>"
    End Sub

    Private Sub FillPaymentType(ByVal Sqlstring As String)
        Me.cmbxPaymentType.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        Me.cmbxPaymentType.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxPaymentType.Items.Add(dr("Title"))
            Next
        End If
        Me.cmbxPaymentType.Text = "<select>"
    End Sub

#End Region

#Region "Loading Functions"

    Friend Sub LoadAdvances()
        FillAdvData("SELECT * FROM tblAdvances WHERE GenID='" & GenID & "'")
    End Sub

    Friend Sub LoadOthersList()
        FillOthersData("SELECT * FROM tblLogOthers WHERE GenID='" & GenID & "'")
    End Sub

    Friend Sub LoadCustomerList()
        FillCustomerData("SELECT * FROM tblLogCustomer WHERE GenID='" & GenID & "'")
    End Sub

    Public Sub LoadRooms()
        FillRooms("SELECT RoomNo FROM tblRooms")
    End Sub

    Public Sub LoadPaymentType()
        FillPaymentType("SELECT * FROM tblPaymentType")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmbxRoomNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxRoomNo.SelectedIndexChanged
        GetRoomInfo(Me.cmbxRoomNo.Text)
        ComputeTotal()
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudNights.ValueChanged
        ReservationDays()
        ComputeTotal()
    End Sub

    Private Sub dtpCheckIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckIn.ValueChanged

        If Me.dtpCheckIn.Value < Date.Now And Me.btnEnter.Text = "&Save" Then
            MsgBox("Invalid date")
            Me.dtpCheckIn.Value = Date.Now
        Else
            ReservationDays()
        End If

    End Sub

    Private Sub dtpCheckOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckOut.ValueChanged

        Dim tmp As TimeSpan

        If Me.dtpCheckOut.Value > Me.dtpCheckIn.Value Then
            tmp = Me.dtpCheckOut.Value.Date - Me.dtpCheckIn.Value.Date
            Me.nudNights.Value = tmp.Days
            Me.lblNoOfNights.Text = Me.nudNights.Value
        Else
            Me.dtpCheckIn.Value = (Me.dtpCheckOut.Value.AddDays(-(CInt(Me.nudNights.Value))))
        End If

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmCustomer_View
            .InsertToolStripMenuItem.Visible = True
            .ToolStripSeparator3.Visible = True
            .ShowDialog()
        End With
    End Sub

    Private Sub CMSCustomer_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSCustomer.Opening
        If Me.lstvwCustomer.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to remove customer " & Me.lstvwCustomer.SelectedItems(0).SubItems(1).Text & " from the list?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.lstvwCustomer.Items.RemoveAt(Me.lstvwCustomer.SelectedItems(0).Index)
        End If
    End Sub

    Private Sub lblRate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRate.TextChanged
        If IsNumeric(Me.lblRate.Text) = True Then
            Me.lblRate.Text = FormatNumber(Me.lblRate.Text)
        End If
    End Sub

    Private Sub txtDiscount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyUp
        ComputeTotal()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If Trim(Me.txtDiscount.Text).Length = 0 Then
            Me.txtDiscount.Text = "0.00"
        End If
    End Sub

    Private Sub txtAmountPaid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmountPaid.KeyUp
        ComputeTotal()
    End Sub

    Private Sub txtAmountPaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountPaid.TextChanged
        If Trim(Me.txtAmountPaid.Text).Length = 0 Then
            Me.txtAmountPaid.Text = "0.00"
        End If
    End Sub

    Private Sub txtAdvance_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ComputeTotal()
    End Sub

    Private Sub txtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Trim(Me.txtAdvance.Text).Length = 0 Then
            Me.txtAdvance.Text = "0.00"
        End If
    End Sub

    Private Sub txtLocalTax_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocalTax.KeyUp
        ComputeTotal()
    End Sub

    Private Sub txtLocalTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocalTax.TextChanged
        If Trim(Me.txtLocalTax.Text).Length = 0 Then
            Me.txtLocalTax.Text = "0.00"
        End If
    End Sub

    Private Sub txtAmountOthers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmountOthers.KeyDown
        If e.KeyValue = Keys.Enter = True Then
            If Trim(Me.txtReferenceID.Text).Length = 0 Then
                MsgBox("Please enter a valid reference ID for the item.", MsgBoxStyle.Exclamation, "Required")
                Me.txtReferenceID.Focus()
            ElseIf Trim(Me.txtOthersDescription.Text).Length = 0 Then
                MsgBox("Please enter a valid decription for the item.", MsgBoxStyle.Exclamation, "Required")
                Me.txtOthersDescription.Focus()
            Else
                Dim x As Integer

                Dim MyItem = Me.lstvwOthers.Items.Add("")
                MyItem.Tag = x
                x = x + 1
                With MyItem
                    .SubItems.Add(Me.dtpDateOthers.Value.ToShortDateString)
                    .SubItems.Add(Me.txtReferenceID.Text)
                    .SubItems.Add(Me.txtOthersDescription.Text)
                    .SubItems.Add(FormatNumber(Me.txtAmountOthers.Text))
                End With
            End If

            Me.txtReferenceID.Clear()
            Me.txtOthersDescription.Clear()
            Me.txtAmountOthers.Clear()

            ComputeTotal()
        End If
    End Sub

    Private Sub txtAmountOthers_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountOthers.TextChanged
        If Trim(Me.txtAmountOthers.Text).Length = 0 Then
            Me.txtAmountOthers.Text = "0.00"
        End If
    End Sub

    Private Sub DeleteOtherItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOtherItemToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to remove item " & Me.lstvwOthers.SelectedItems(0).SubItems(1).Text & " from the list?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.lstvwOthers.Items.RemoveAt(Me.lstvwOthers.SelectedItems(0).Index)
        End If
        ComputeTotal()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        Dim strSelect As String

        If Me.cmbxRoomNo.Text = "<select>" Then
            MsgBox("Please select a room for the reservation.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxRoomNo.Focus()
        ElseIf Me.cmbxReservationStatus.Text = "<select>" Then
            MsgBox("Please select a reservation status.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxReservationStatus.Focus()
        ElseIf Me.cmbxPaymentType.Text = "<select>" Then
            MsgBox("Please select a type of payment.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxPaymentType.Focus()
        ElseIf Me.lstvwCustomer.Items.Count = 0 Then
            MsgBox("Please enter a customer for the room reservation.", MsgBoxStyle.Exclamation, "Required")
            Me.lstvwCustomer.Focus()
        ElseIf Me.lblAmountDueWtTax.Text <> 0 And Me.btnEnter.Text = "&Check-Out" Then
            MsgBox("Amount due is still not settled, please verify payment.", MsgBoxStyle.Exclamation, "Required")
            Me.txtAmountPaid.Focus()
        Else
            If Me.btnEnter.Text = "&Save" Then

                If CheckIfDateInBetweenDate() = True Then
                    MsgBox("The " & Me.cmbxRoomNo.Text & " has already a reservation between this dates, invalid action", MsgBoxStyle.Exclamation, "Invalid")
                    Me.btnOccupy.Focus()
                    Exit Sub
                Else
                    GenID = GenerateID()
                    strSelect = "INSERT INTO tblLogBook" & _
                                        "([GenID],[RoomNo],[CustomerName],[Rate],[Floor],[Description],[Equipments],[SB],[DB],[ExtraB],[Check_IN],[Check_OUT],[Nights],[Comments],[AmountPaid],[AdvancePayment],[LocalTax],[PaymentType],[Discount],[Balance],[Others],CI,CO,[ReservationStatus])VALUES " & _
                                        "('" & GenID & "','" & _
                                        "" & Me.cmbxRoomNo.Text & "','" & _
                                        "" & CSQ(Me.lstvwCustomer.Items(0).SubItems(1).Text) & "','" & _
                                        "" & CDec(Me.lblRate.Text) & "','" & _
                                        "" & Me.lblFloor.Text & "','" & _
                                        "" & CSQ(Me.lblRoomDescription.Text) & "','" & _
                                        "" & CSQ(Me.lblRoomEquipments.Text) & "','" & _
                                        "" & Me.lblSB.Text & "','" & _
                                        "" & Me.lblDB.Text & "','" & _
                                        "" & Me.lblExtraB.Text & "','" & _
                                        "" & Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("In") & "','" & _
                                        "" & Me.dtpCheckOut.Value.ToShortDateString & " " & GetCheckTime("Out") & "','" & _
                                        "" & Me.nudNights.Value & "','" & _
                                        "" & CSQ(Me.txtComment.Text) & "','" & _
                                        "" & Me.txtAmountPaid.Text & "','" & _
                                        "" & Me.txtAdvance.Text & "','" & _
                                        "" & Me.txtLocalTax.Text & "','" & _
                                        "" & Me.cmbxPaymentType.Text & "','" & _
                                        "" & Me.txtDiscount.Text & "','" & _
                                        "" & FormatCurrency(Me.lblAmountDueWtTax.Text) & "','" & _
                                        "" & FormatCurrency(Others) & "','" & _
                                        "" & Me.dtpCheckIn.Value & "','" & _
                                        "" & Me.dtpCheckOut.Value & _
                                        "', '" + Me.cmbxReservationStatus.Text + "')"

                    CheckConnection(cn)
                    Dim cmdSave As New OleDbCommand(strSelect, cn)
                    cmdSave.ExecuteNonQuery()

                    MsgBox("Reservation has been successfully saved.", MsgBoxStyle.Information, "Saved")

                    'SystemLog
                    If Me.cmbxReservationStatus.Text = "Reserved" Then
                        SystemLog("Add", "Entry of room #" & Me.cmbxRoomNo.Text & " has been added.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Log-Book(Reservation) Module")
                    Else
                        SystemLog("Add", "Entry of room #" & Me.cmbxRoomNo.Text & " has been added.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Log-Book Module")
                    End If

                End If
            ElseIf Me.btnEnter.Text = "&Update" Then

                strSelect = "UPDATE tblLogBook SET" & _
                    "[RoomNo]='" & Me.cmbxRoomNo.Text & _
                    "',[Rate]='" & Me.lblRate.Text & _
                    "',[Floor]='" & Me.lblFloor.Text & _
                    "',[Description]='" & Me.lblRoomDescription.Text & _
                    "',[Equipments]='" & Me.lblRoomEquipments.Text & _
                    "',[SB]='" & Me.lblSB.Text & _
                    "',[DB]='" & Me.lblDB.Text & _
                    "',[ExtraB]='" & Me.lblExtraB.Text & _
                    "',[Check_IN]='" & Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("In") & _
                    "',[Check_OUT]='" & Me.dtpCheckOut.Value.ToShortDateString & " " & GetCheckTime("Out") & _
                    "',[Nights]='" & Me.nudNights.Value & _
                    "',[Comments]='" & Me.txtComment.Text & _
                    "',[AmountPaid]='" & Me.txtAmountPaid.Text & _
                    "',[AdvancePayment]='" & Me.txtAdvance.Text & _
                    "',[LocalTax]='" & Me.txtLocalTax.Text & _
                    "',[PaymentType]='" & Me.cmbxPaymentType.Text & _
                    "',[ReservationStatus]='" & Me.cmbxReservationStatus.Text & _
                    "',[Discount]='" & Me.txtDiscount.Text & _
                    "',[CustomerName]='" & Me.lstvwCustomer.Items(0).SubItems(1).Text & _
                    "',[Balance]='" & FormatCurrency(Me.lblAmountDueWtTax.Text) & _
                    "',[Others]='" & FormatCurrency(Others) & _
                    "'WHERE GenID=" & GenID & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(strSelect, cn)
                cmd.ExecuteNonQuery()

                'SystemLog
                Dim str As String = ""
                If strAmountPaid <> Me.txtAmountPaid.Text Then
                    str = str & "amount paid(" & strAmountPaid & ">" & Me.txtAmountPaid.Text & ")"
                End If
                If strAdvance <> Me.txtAdvance.Text Then
                    str = str & "Advance(" & strAdvance & ">" & Me.txtAdvance.Text & ")"
                End If
                If strLocalTax <> Me.txtLocalTax.Text Then
                    str = str & "Local Tax(" & strLocalTax & ">" & Me.txtLocalTax.Text & ")"
                End If
                If CDate(strReservationIN).ToShortDateString <> CDate(Me.dtpCheckIn.Text).ToShortDateString Then
                    str = str & "Check-IN(" & strReservationIN & ">" & Me.dtpCheckIn.Text & ")"
                End If
                If CDate(strReservationOUT).ToShortDateString <> CDate(Me.dtpCheckOut.Text).ToShortDateString Then
                    str = str & "Check-OUT(" & strReservationOUT & ">" & Me.dtpCheckOut.Text & ")"
                End If
                If strOthers <> Others Then
                    str = str & "Others(" & strOthers & ">" & Others & ")"
                End If
                If strDiscount <> Me.txtDiscount.Text Then
                    str = str & "Discount(" & strDiscount & ">" & Me.txtDiscount.Text & ")"
                End If

                If str <> "" Then
                    SystemLog("Edit", "Changes in " & str, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Log-Book Module")
                End If

                MsgBox("Entry has been successfully updated.", MsgBoxStyle.Information, "Updated")
            ElseIf Me.btnEnter.Text = "&Check-Out" Then

                strSelect = "UPDATE tblLogBook SET" & _
                "[Comments]='" & Me.txtComment.Text & _
                "',[AmountPaid]='" & Me.txtAmountPaid.Text & _
                "',[AdvancePayment]='" & Me.txtAdvance.Text & _
                "',[LocalTax]='" & Me.txtLocalTax.Text & _
                "',[PaymentType]='" & Me.cmbxPaymentType.Text & _
                "',[ReservationStatus]='" & "Paid" & _
                "',[Discount]='" & Me.txtDiscount.Text & _
                "',[DatePaid]='" & Date.Now & _
                "',[CO]='" & Date.Now & _
                "',[Others]='" & FormatCurrency(Others) & _
                "'WHERE GenID=" & GenID & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(strSelect, cn)
                cmd.ExecuteNonQuery()

                SetRoomStatus(0, Me.cmbxRoomNo.Text, "0")

                SystemLog("Check-Out", "Room #" & Me.cmbxRoomNo.Text & " has been check-out.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Log-Book Module")
                MsgBox(Me.cmbxRoomNo.Text & " has been successfully check-out.", MsgBoxStyle.Information, "Check-Out")

                With frmCleaningRemarks_Entry
                    .GenID = GenID
                    .LoadRooms()
                    .cmbxRoomNo.Text = Me.cmbxRoomNo.Text
                    .cmbxChangeBeddings.Text = "Yes"
                    .cmbxStatus.Text = "Needs Cleaning"
                    .cmbxRoomNo.Enabled = False
                    .cmbxChangeBeddings.Enabled = False
                    .cmbxStatus.Enabled = False
                    .btnCancel.Enabled = False
                    .ShowDialog()
                End With

            End If
            If cmbxReservationStatus.Text = "Vacant" And Me.btnEnter.Text <> "&Check-Out" Then
                SetRoomStatus(0, Me.cmbxRoomNo.Text, GenID)
            ElseIf cmbxReservationStatus.Text = "Occupied" And Me.btnEnter.Text <> "&Check-Out" Then
                SetRoomStatus(1, Me.cmbxRoomNo.Text, GenID)
            End If

            'delete first the saved logcustomer
            DelLogCustomer(GenID.ToString)
            'Save customer
            SaveLogCustomer()

            'delete first the saved logOthers
            DelLogOthers(GenID.ToString)
            'Save Others
            SaveLogOthers()

            'delete first the saved adv
            DelAdvances(GenID.ToString)
            'Save adv
            SaveAdvances()

            frmLogBook.LoadList()
            frmRoomMonitoring.LoadList()
            frmRoomMonitoring.LoadListReservation()
            frmRoomMonitoring.LoadListRoomCleaning()
            Me.btnCancel_Click(sender, e)

        End If

    End Sub

    Private Sub CMSOthers_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSOthers.Opening

        If Me.lstvwOthers.SelectedItems.Count > 0 Then
            Me.DeleteOtherItemToolStripMenuItem.Enabled = True
        Else
            Me.DeleteOtherItemToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub cmbxReservationStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxReservationStatus.SelectedIndexChanged
        If Me.cmbxReservationStatus.Text = "Reserved" Then
            Me.btnOccupy.Visible = True
        Else
            Me.btnOccupy.Visible = False
        End If
    End Sub

    Private Sub btnOccupy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOccupy.Click

        If CheckIfRoomOccupied(Me.cmbxRoomNo.Text) = True Then
            MsgBox("The " & Me.cmbxRoomNo.Text & " is currently occupied, invalid action", MsgBoxStyle.Exclamation, "Invalid")
            Me.btnOccupy.Focus()
        Else
            Dim strSelect As String
            strSelect = "UPDATE tblLogBook SET" & _
                       "[RoomNo]='" & Me.cmbxRoomNo.Text & _
                       "',[Rate]='" & Me.lblRate.Text & _
                       "',[Floor]='" & Me.lblFloor.Text & _
                       "',[Description]='" & Me.lblRoomDescription.Text & _
                       "',[Equipments]='" & Me.lblRoomEquipments.Text & _
                       "',[SB]='" & Me.lblSB.Text & _
                       "',[DB]='" & Me.lblDB.Text & _
                       "',[ExtraB]='" & Me.lblExtraB.Text & _
                       "',[Check_IN]='" & Me.dtpCheckIn.Value & _
                       "',[Check_OUT]='" & Me.dtpCheckOut.Value & _
                       "',[Nights]='" & Me.nudNights.Value & _
                       "',[Comments]='" & Me.txtComment.Text & _
                       "',[AmountPaid]='" & Me.txtAmountPaid.Text & _
                       "',[AdvancePayment]='" & Me.txtAdvance.Text & _
                       "',[LocalTax]='" & Me.txtLocalTax.Text & _
                       "',[PaymentType]='" & Me.cmbxPaymentType.Text & _
                       "',[ReservationStatus]='" & "Occupied" & _
                       "',[Discount]='" & Me.txtDiscount.Text & _
                       "'WHERE GenID=" & GenID & ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(strSelect, cn)
            cmd.ExecuteNonQuery()
            'system log
            SystemLog("Reserved to Occupied", "Room #" & Me.cmbxRoomNo.Text & " has been check-In.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Log-Book(Reservation) Module")

            MsgBox("Reservation has been successfully occupied.", MsgBoxStyle.Information, "Occupied")
            SetRoomStatus(1, Me.cmbxRoomNo.Text, GenID)
            frmLogBook.LoadList()
            frmRoomMonitoring.LoadList()
            frmRoomMonitoring.LoadListReservation()
            frmRoomMonitoring.LoadListRoomCleaning()
            Me.btnCancel_Click(sender, e)
        End If

    End Sub

    Private Sub btnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoice.Click

        If Me.lstvwCustomer.Items.Count = 0 Then
            MessageBox.Show("Please add a customer in the list.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.lstvwCustomer.Focus()
        Else
            Dim Header1 As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim Header2 As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim Header3 As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim Header4 As CrystalDecisions.CrystalReports.Engine.TextObject

            Dim CustomerName As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim Address As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim RoomNo As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim CheckIn As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim CheckOut As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim PrintedBy As CrystalDecisions.CrystalReports.Engine.TextObject

            Dim RoomRate As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim NoOfDays As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim TotalAccomodation As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim Discount As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim Deposit As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim LocalTax As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim GrandTotal As CrystalDecisions.CrystalReports.Engine.TextObject

            Dim TotalAmountDue As CrystalDecisions.CrystalReports.Engine.TextObject

            Dim crSections As Sections
            Dim crSection As Section
            Dim crReportObjects As ReportObjects

            Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
            Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

            Dim repDoc

            repDoc = New crptInvoice

            Header1 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader1")
            Header2 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader2")
            Header3 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader3")
            Header4 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader4")

            CustomerName = repDoc.ReportDefinition.ReportObjects.Item("txtCustomerName")
            Address = repDoc.ReportDefinition.ReportObjects.Item("txtAddress")
            RoomNo = repDoc.ReportDefinition.ReportObjects.Item("txtRoomNo")
            CheckIn = repDoc.ReportDefinition.ReportObjects.Item("txtCheckIn")
            CheckOut = repDoc.ReportDefinition.ReportObjects.Item("txtCheckOut")
            PrintedBy = repDoc.ReportDefinition.ReportObjects.Item("txtPrintedBy")

            RoomRate = repDoc.ReportDefinition.ReportObjects.Item("txtRoomRate")
            NoOfDays = repDoc.ReportDefinition.ReportObjects.Item("txtNoOfDays")
            TotalAccomodation = repDoc.ReportDefinition.ReportObjects.Item("txtTotalAccomodation")
            Discount = repDoc.ReportDefinition.ReportObjects.Item("txtDiscount")
            Deposit = repDoc.ReportDefinition.ReportObjects.Item("txtDeposit")
            LocalTax = repDoc.ReportDefinition.ReportObjects.Item("txtLocalTax")
            GrandTotal = repDoc.ReportDefinition.ReportObjects.Item("txtGTotal")

            TotalAmountDue = repDoc.ReportDefinition.ReportObjects.Item("txtAmountDue")

            Call GetHeaderInfo()

            Header1.Text = strHeader1
            Header2.Text = strHeader2
            Header3.Text = strHeader3
            Header4.Text = strHeader4

            CustomerName.Text = Me.lstvwCustomer.Items(0).SubItems(1).Text
            Address.Text = Me.lstvwCustomer.Items(0).SubItems(2).Text
            RoomNo.Text = Me.cmbxRoomNo.Text

            If frmRoomMonitoring.ToolStripStatuslblLevel.Text = "1" Then
                CheckIn.Text = GetCI()
                CheckOut.Text = GetCO()
            Else
                CheckIn.Text = Me.dtpCheckIn.Value.ToShortDateString
                CheckOut.Text = Me.dtpCheckOut.Value.ToShortDateString
            End If

            PrintedBy.Text = frmRoomMonitoring.ToolStripStatuslblUsername.Text

            RoomRate.Text = Me.lblRate.Text
            NoOfDays.Text = Me.lblNoOfNights.Text
            TotalAccomodation.Text = Me.lblTotalAccomodation.Text
            Discount.Text = Me.txtDiscount.Text
            Deposit.Text = "(" & Me.txtAdvance.Text & ")"
            LocalTax.Text = Me.lblLocalTax.Text
            GrandTotal.Text = Me.lblGrandTotal.Text

            TotalAmountDue.Text = FormatNumber(Me.lblAmountDueWtTax.Text)

            For Each myTable In repDoc.Database.Tables
                myLogin = myTable.LogOnInfo
                myLogin.ConnectionInfo.ServerName = GetcrptDBPath() & "\HMDB.accdb"
                'myLogin.ConnectionInfo.DatabaseName = GetcrptDBPath() & "\HMDB.accdb"
                myLogin.ConnectionInfo.UserID = UserID
                myLogin.ConnectionInfo.Password = Password
                myTable.ApplyLogOnInfo(myLogin)
            Next

            crSections = repDoc.ReportDefinition.Sections
            'loop through all the sections to find all the report objects
            For Each crSection In crSections
                crReportObjects = crSection.ReportObjects
            Next

            rptfrmInvoice.CrystalReportViewerInvoice.ReportSource = repDoc

            rptfrmInvoice.CrystalReportViewerInvoice.SelectionFormula = "{tblLogOthers.GenID}='" & GenID & "'"
            rptfrmInvoice.ShowDialog()
        End If

    End Sub

    Private Sub CMSAdvances_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSAdvances.Opening
        If Me.lstvwAdvances.SelectedItems.Count > 0 Then
            Me.ToolStripMenuItemDeleteAdv.Enabled = True
        Else
            Me.ToolStripMenuItemDeleteAdv.Enabled = False
        End If
    End Sub

    Private Sub ToolStripMenuItemAddAdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemAddAdv.Click
        frmAdvancePayment_Entry.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItemDeleteAdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemDeleteAdv.Click
        If MessageBox.Show("Are you sure you want to remove the advance payment", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.lstvwAdvances.SelectedItems.Item(0).Remove()
            ComputeTotal()
        End If
    End Sub

    Private Sub txtAdvance_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvance.TextChanged
        Me.txtAmountPaid.Text = FormatNumber(Me.txtAdvance.Text)
    End Sub

End Class