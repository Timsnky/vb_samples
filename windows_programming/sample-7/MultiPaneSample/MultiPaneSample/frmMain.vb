Imports System.IO

Public Class frmMain

    Private strFileName As String
    Private WithEvents Welcome As subfrmWelcome
    Private WithEvents Customer As subfrmCust
    Private WithEvents Order As subfrmOrder

    Private arrSubForms As ArrayList

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        arrSubForms = New ArrayList
        Welcome = New subfrmWelcome
        Customer = New subfrmCust
        Order = New subfrmOrder

        'Add all subforms to the arraylist
        arrSubForms.Add(Welcome)
        arrSubForms.Add(Customer)
        arrSubForms.Add(Order)

        'Add each subform to the workarea groupbox (hidden by default)
        grpWorkArea.Controls.Add(Welcome)
        grpWorkArea.Controls.Add(Customer)
        grpWorkArea.Controls.Add(Order)

        Welcome.Location = CalcLocation(grpWorkArea, Welcome)
        Customer.Location = CalcLocation(grpWorkArea, Customer)
        Order.Location = CalcLocation(grpWorkArea, Order)
        Welcome.Visible = True
    End Sub

    Private Sub HideAllSubForms()
        For Each obj As UserControl In arrSubForms
            obj.Visible = False
        Next
    End Sub

    Private Function CalcLocation(grpBox As GroupBox, subForm As UserControl) As Point
        Return New Point((grpBox.Width - subForm.Width) / 2, (grpBox.Height - subForm.Height) / 2)
    End Function

    Private Sub OpenFile(strType As String)
        Dim intResult As Integer
        ofdData.InitialDirectory = Application.StartupPath
        ofdData.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"
        ofdData.FilterIndex = 2

        Select Case strType
            Case "CustomerData"
                ofdData.Title = "Select Customer Data File"
            Case "OrderData"
                ofdData.Title = "Select Order Data File"
            Case Else
                MessageBox.Show("Unexpected data type in OpenFile", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        intResult = ofdData.ShowDialog

        If intResult = DialogResult.Cancel Then
            Exit Sub
        End If

        strFileName = ofdData.FileName

        Try
            ReadInputFile(strFileName, strType)
        Catch ex As Exception
            'Put error handling code here
            MessageBox.Show("Error occured while reading input file", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ReadInputFile(strFileIn As String, strType As String)
        Dim fileIn As StreamReader
        Dim strLineIn As String
        Dim strFields() As String 'String array to hold the fields in a record from the file
        Dim i As Integer

        fileIn = New StreamReader(strFileIn)
        fileIn.ReadLine()   'Throw away the first record in the file

        Select Case strType
            Case "CustomerData"
                tvwCust.Nodes.Clear()

                'Build letter top nodes
                For i = 65 To 90 'ASCII codes for uppercse A-Z
                    tvwCust.Nodes.Add(Chr(i), Chr(i)) 'Add node with key value and text value
                Next

                Try
                    While Not fileIn.EndOfStream
                        strLineIn = fileIn.ReadLine
                        strFields = strLineIn.Split(","c)
                        'Dim newNode As New TreeNode
                        'newNode.Text = strFields(1) & ", " & strFields(2)
                        'newNode.Tag = strFields(0) 'Hide the ID lookup value
                        'tvwCust.Nodes.Add(newNode)

                        Dim parentNode() As TreeNode
                        parentNode = tvwCust.Nodes.Find(strFields(1).Substring(0, 1), True) 'Find the correct parent node
                        parentNode(0).Nodes.Add(strFields(0), strFields(1) & ", " & strFields(2))
                    End While

                    tvwCust.ExpandAll()
                    tvwCust.Refresh()

                Catch ex As Exception
                    Throw ex
                End Try
            Case "OrderData"
                tvwOrders.Nodes.Clear()

                Try
                    While Not fileIn.EndOfStream
                        strLineIn = fileIn.ReadLine
                        strFields = strLineIn.Split(Chr(9)) 'Chr(9) is the ASCII code for the tab
                        tvwOrders.Nodes.Add(strFields(1), strFields(0)) 'Add custID as the key for the node to facilitate customer lookup
                    End While

                    tvwOrders.ExpandAll()
                    tvwOrders.Refresh()
                Catch ex As Exception
                    Throw ex
                End Try
            Case Else
                MessageBox.Show("Unexpected data type in ReadInputFile", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        OpenFile("CustomerData")
        OpenFile("OrderData")
    End Sub

    Private Sub tvwCust_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvwCust.NodeMouseClick
        'This event occurs when user clicks on a node in the treeview
        Dim theNode As TreeNode = DirectCast(e.Node, TreeNode)
        HideAllSubForms()
        Customer.txtId.Text = theNode.Name 'Name property is the key value
        Customer.txtName.Text = theNode.Text
        Customer.Visible = True
    End Sub

    Private Sub tvwOrders_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvwOrders.NodeMouseClick
        Dim theNode As TreeNode = DirectCast(e.Node, TreeNode)
        HideAllSubForms()
        Order.txtOderID.Text = theNode.Text
        Order.txtCustID.Text = theNode.Name 'Key value

        'Now find the customer information in the customer tree view
        Dim custNode() As TreeNode 'Arra of tree nodes
        custNode = tvwCust.Nodes.Find(theNode.Name, True)
        Order.txtCustName.Text = custNode(0).Text

        Order.Visible = True
    End Sub

    Private Sub AddNewCust() Handles Customer.SaveCustomer
        Dim parentNode() As TreeNode
        parentNode = tvwCust.Nodes.Find(Customer.txtName.Text.Substring(0, 1), True) 'Find the correct parent node
        parentNode(0).Nodes.Add(Customer.txtId.Text, Customer.txtName.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
