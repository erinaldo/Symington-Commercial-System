
Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class FormTreesPricingNew
    Inherits DevExpress.XtraEditors.XtraForm


    Public filterkeydir As String
    Public filterkeypais As String
    Public filterkeyclifact As String
    Public filterkeyclidest As String
    Public filterkeycomp As String
    Public filterkeytipo As String
    Public filterkeypricelist As String
    Public filterkeyPCDATI As String
    Public filterkeyPCDATF As String
    Public filterkeyCurrency As String
    ''FUS�O   Public filterkeyPricing As String = "933"
    Public filterkeyPricing As String = "943"
    Dim Forcefilterkeydir As String ' Permiss�o


    Public filtergrid As Boolean


    Public filterkeynomecliente As String

    Public varTabela As String
    Public varDatabase As String
    Public flagWork As Boolean
    Public click1 As Boolean
    Public click2 As Boolean
    Public click3 As Boolean
    Public click4 As Boolean
    Public click5 As Boolean
    Public click6 As Boolean
    Public click7 As Boolean
    Public click8 As Boolean
    Public click9 As Boolean
    Public click10 As Boolean




    Dim tabela As New DataTable
    'Dim dv As DataView
    Dim ds As DataSet, dsHelper As DataSetHelper.DataSetHelper
    Friend WithEvents TreeView4 As DevExpress.XtraTreeList.TreeList '()System.Windows.Forms.TreeView
    Friend WithEvents SapPricingDataset11 As SapCSDataSet
    Friend WithEvents SapTipoListaPrecosTableAdapter As SapCSDataSetTableAdapters.SapTipoListaPrecosTableAdapter
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TreeView1 As DevExpress.XtraTreeList.TreeList ' System.Windows.Forms.TreeView
    Friend WithEvents TreeView2 As DevExpress.XtraTreeList.TreeList ' System.Windows.Forms.TreeView
    Friend WithEvents TreeView3 As DevExpress.XtraTreeList.TreeList ' System.Windows.Forms.TreeView
    Friend WithEvents Command3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTreesPricingNew))
        Me.TreeView1 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView2 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView3 = New DevExpress.XtraTreeList.TreeList()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TreeView4 = New DevExpress.XtraTreeList.TreeList()
        Me.SapPricingDataset11 = New SAP_Pricing.SapCSDataSet()
        Me.SapTipoListaPrecosTableAdapter = New SAP_Pricing.SapCSDataSetTableAdapters.SapTipoListaPrecosTableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapPricingDataset11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(12, 123)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.OptionsBehavior.Editable = False
        Me.TreeView1.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView1.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView1.OptionsMenu.EnableColumnMenu = False
        Me.TreeView1.OptionsMenu.EnableFooterMenu = False
        Me.TreeView1.OptionsMenu.ShowAutoFilterRowItem = False
        Me.TreeView1.OptionsSelection.InvertSelection = True
        Me.TreeView1.OptionsView.ShowButtons = False
        Me.TreeView1.OptionsView.ShowColumns = False
        Me.TreeView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never
        Me.TreeView1.OptionsView.ShowIndicator = False
        Me.TreeView1.Size = New System.Drawing.Size(116, 271)
        Me.TreeView1.TabIndex = 0
        '
        'TreeView2
        '
        Me.TreeView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView2.Location = New System.Drawing.Point(134, 123)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.OptionsBehavior.Editable = False
        Me.TreeView2.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView2.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView2.OptionsMenu.EnableColumnMenu = False
        Me.TreeView2.OptionsMenu.EnableFooterMenu = False
        Me.TreeView2.OptionsMenu.ShowAutoFilterRowItem = False
        Me.TreeView2.OptionsSelection.InvertSelection = True
        Me.TreeView2.OptionsView.ShowColumns = False
        Me.TreeView2.OptionsView.ShowIndicator = False
        Me.TreeView2.Size = New System.Drawing.Size(166, 271)
        Me.TreeView2.TabIndex = 1
        '
        'TreeView3
        '
        Me.TreeView3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView3.Location = New System.Drawing.Point(306, 123)
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.OptionsBehavior.Editable = False
        Me.TreeView3.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView3.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView3.OptionsMenu.EnableColumnMenu = False
        Me.TreeView3.OptionsMenu.EnableFooterMenu = False
        Me.TreeView3.OptionsMenu.ShowAutoFilterRowItem = False
        Me.TreeView3.OptionsSelection.InvertSelection = True
        Me.TreeView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never
        Me.TreeView3.OptionsView.ShowIndicator = False
        Me.TreeView3.Size = New System.Drawing.Size(247, 271)
        Me.TreeView3.TabIndex = 2
        '
        'Command3
        '
        Me.Command3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command3.BackColor = System.Drawing.Color.Transparent
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Command3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Command3.ForeColor = System.Drawing.Color.White
        Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
        Me.Command3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command3.Location = New System.Drawing.Point(745, 0)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(72, 69)
        Me.Command3.TabIndex = 5
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox8.Location = New System.Drawing.Point(0, 426)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(818, 124)
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'TreeView4
        '
        Me.TreeView4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView4.Location = New System.Drawing.Point(559, 123)
        Me.TreeView4.Name = "TreeView4"
        Me.TreeView4.OptionsBehavior.Editable = False
        Me.TreeView4.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView4.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView4.OptionsMenu.EnableColumnMenu = False
        Me.TreeView4.OptionsMenu.EnableFooterMenu = False
        Me.TreeView4.OptionsMenu.ShowAutoFilterRowItem = False
        Me.TreeView4.OptionsSelection.InvertSelection = True
        Me.TreeView4.OptionsView.ShowIndicator = False
        Me.TreeView4.Size = New System.Drawing.Size(247, 271)
        Me.TreeView4.TabIndex = 3
        '
        'SapPricingDataset11
        '
        Me.SapPricingDataset11.DataSetName = "SapPricingDataset1"
        Me.SapPricingDataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SapTipoListaPrecosTableAdapter
        '
        Me.SapTipoListaPrecosTableAdapter.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.SAP_Pricing.My.Resources.Resources.SFE_Logo_Principal
        Me.PictureBox2.Location = New System.Drawing.Point(210, 9)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(358, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(645, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 56)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "OK"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SAP_Pricing.My.Resources.Resources.hana_icon
        Me.PictureBox1.Location = New System.Drawing.Point(280, 445)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 93)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.SAP_Pricing.My.Resources.Resources.PricingCommercialsystembarra
        Me.PictureBox3.Location = New System.Drawing.Point(514, 445)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(292, 93)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 74
        Me.PictureBox3.TabStop = False
        '
        'FormTreesPricingNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.Command3
        Me.ClientSize = New System.Drawing.Size(818, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TreeView4)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.TreeView3)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.PictureBox8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormTreesPricingNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Criteria"
        CType(Me.TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapPricingDataset11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FormTreesPricing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Instantiate the License class
        'Pass only the name of the license file embedded in the assembly
        ' license.SetLicense("Aspose.Cells.lic")

        'Me.Top = 0
        'Me.Left = 0
        'Me.Width = Me.MdiParent.ClientSize.Width - 4
        'Me.Height = Me.MdiParent.ClientSize.Height - 4
        click1 = False
        filterkeydir = "%"
        filterkeypais = "%"
        filterkeyclifact = "%"
        filterkeyclidest = "%"
        filterkeycomp = "%"
        filterkeytipo = "%"
        filterkeypricelist = "%"
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        Forcefilterkeydir = "SalesMan like '%'"
        '''''''''''''''''
        Dim utilizador As String
        utilizador = UCase(GetSetting("SalesReports", "User", "login"))
        Select Case utilizador
            Case "SYMINGTON\HS", "SYMINGTON\EMM", "SYMINGTON\JMA", "SYMINGTON\MMC", "SYMINGTON\DMS", "SYMINGTON\JADS", "SYMINGTON\RADS", "SYMINGTON\RDTS", "SYMINGTON\PDS", "SYMINGTON\AMF", "SYMINGTON\CAC"
                Exit Select

            Case "SYMINGTON\HS", "SYMINGTON\EMM", "SYMINGTON\JMA", "SYMINGTON\MMC", "SYMINGTON\PV", "SYMINGTON\AMF", "SYMINGTON\PFL", "SYMINGTON\CLC", "SYMINGTON\JMV",
                  "SYMINGTON\JVN", "SYMINGTON\GAB", "SYMINGTON\GRD", "SYMINGTON\ACR", "SYMINGTON\RJR", "SYMINGTON\ABM", "SYMINGTON\MFF", "SYMINGTON\IPM", "SYMINGTON\EDR",
                   "COMERC_JVN\JORGE", "SYMINGTON\PAM", "DESKTOP-7RA9PT2\SOFIAZHANG", "SYMINGTON\IF", "SYMINGTON\TC", "SYMINGTON\MAM", "SYMINGTON\FCL", "SYMINGTON\ARSC", "SYMINGTON\ABB", "SYMINGTON\EAC",
                   "SYMINGTON\MLL", "SYMINGTON\MTB", "SYMINGTON\RVB", "SYMINGTON\RAP"
                Exit Select

            Case "SYMINGTON\PV"

            Case "SYMINGTON\GAB"
                Forcefilterkeydir = "SalesMan like '02'"
            Case "SYMINGTON\GRD"
                Forcefilterkeydir = "SalesMan like '08'"
            Case "SYMINGTON\PFL"
                Forcefilterkeydir = "SalesMan like '04'"
            Case "SYMINGTON\RJR"
                Forcefilterkeydir = "SalesMan like '09'"
            Case "SYMINGTON\MFF"
                Forcefilterkeydir = "SalesMan like '09'"
            Case "SYMINGTON\JVN"
                Forcefilterkeydir = "SalesMan like '07'"
            Case "COMERC_JVN\JORGE"
                Forcefilterkeydir = "SalesMan like '07'"
            Case "SYMINGTON\IPM"
                Forcefilterkeydir = "SalesMan like '07'"
            Case "SYMINGTON\EDR"
                Forcefilterkeydir = "SalesMan like '07'"
            Case "SYMINGTON\JMV"
                Forcefilterkeydir = "SalesMan like '05'"
            Case "SYMINGTON\HJS"
                Forcefilterkeydir = "SalesMan like '06'"
            Case "SYMINGTON\ACR"
                Forcefilterkeydir = "SalesMan like '03'"
            Case "SYMINGTON\LS"
                Forcefilterkeydir = "Director like 'JAR' and SalesMan like '99'"
            Case Forcefilterkeydir = "Director like 'JAR' and SalesMan like '99'"
                Forcefilterkeydir = "Director like 'JAR' and SalesMan like '99'"
            Case "SYMINGTON\MLL"
                Forcefilterkeydir = "Director like 'LMM' and SalesMan like '99'"

            Case "SYMINGTON\CLC"
                Forcefilterkeydir = "(SalesMan like '01') or (Director like 'RADS' and SalesMan like '99')"

            Case "SYMINGTON\ABM"
                Forcefilterkeydir = "(CliDest = '3337')"




            Case "SYMINGTON\JAR"
                Forcefilterkeydir = "Director like 'JAR'"
            Case "SYMINGTON\LMM"
                Forcefilterkeydir = "Director like 'LMM'"
            Case "SYMINGTON\DMS"
                Forcefilterkeydir = "Director like 'DMS'"



            Case "SYMINGTON\MAC"
                Forcefilterkeydir = "ComercAssist = 1"


            Case "SYMINGTON\TC"
                Forcefilterkeydir = "ComercAssist = 8"
            Case "SYMINGTON\ABB"
                Forcefilterkeydir = "ComercAssist = 12"
            Case "SYMINGTON\EAC"
                Forcefilterkeydir = "ComercAssist = 10"
            Case "SYMINGTON\JD"
                Forcefilterkeydir = "ComercAssist = 4"

            Case "SYMINGTON\RV"
                Forcefilterkeydir = "ComercAssist = 17"
            Case "SYMINGTON\IF"
                Forcefilterkeydir = "ComercAssist = 6"
            Case "SYMINGTON\MAM"
                Forcefilterkeydir = "ComercAssist = 21"

            Case "SYMINGTON\FCL"
                Forcefilterkeydir = "ComercAssist = 21"
            Case Else
                filterkeydir = "director like 'NAO TEM ACESSO'"
                Forcefilterkeydir = "director like 'NAO TEM ACESSO'"
                MsgBox("Sem acesso definido!!" & vbCrLf & "No access granted!!", MsgBoxStyle.Exclamation, "Erro")

        End Select


        Dim strsql As String

        Dim reader As SqliteDataReader

        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)


        strsql = "SELECT SapClients_1.NAME1 AS director, SapClients.LANDX50 AS Pais, SapClients.NAME1 AS CliDest, SapClients.NAME1 AS CliFact FROM SapClients LEFT OUTER JOIN SapClients SapClients_1 ON SapClients.MARKETDIRECTOR = SapClients_1.KUNNR "

        'altera��o MR
        strsql = "SELECT SapClients_1.NAME1 AS director, SapClients.LANDX50 AS Pais, SapClients.NAME1 AS CliDest, SapClients.NAME1 AS CliFact FROM SapClients LEFT OUTER JOIN SapClients SapClients_1 ON SapClients.MARKETMANAGER = SapClients_1.KUNNR "


        ' strsql = "SELECT SapClients_1.NAME1 AS director, SapClients.LANDX50 AS Pais, SapClients.KUNNR AS CliDest, SapClients.KUNNR  AS CliFact FROM SapClients LEFT OUTER JOIN SapClients SapClients_1 ON SapClients.MARKETDIRECTOR = SapClients_1.KUNNR "

        '''''excep��o
        'If utilizador = "SYMINGTON\PAM" Then
        '    Exit Sub
        'End If



        Dim sqlcommand1 As New SqliteCommand
        Dim SqlConnection1 As New SqliteConnection
        SqlConnection1.ConnectionString = My.Settings.PricingConnectionString
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable
        tabela.Columns.Add("director", Type.GetType("System.String"))
        tabela.Columns.Add("pais", Type.GetType("System.String"))
        tabela.Columns.Add("clidest", Type.GetType("System.String"))
        tabela.Columns.Add("clifact", Type.GetType("System.String"))

        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader


        While reader.Read
            myRow = tabela.NewRow()
            myRow("director") = reader.Item(0)
            myRow("pais") = reader.Item(1)
            myRow("clidest") = reader.Item(2)
            myRow("clifact") = reader.Item(2)
            tabela.Rows.Add(myRow)

        End While

        ds.Tables.Add(tabela)
        reader.Close()





        SqlConnection1.Close()

        treefill(-1)

    End Sub
    Private Sub treefill(ByVal Index As Integer)
        flagWork = True
        TreeView1.BeginUpdate()
        TreeView2.BeginUpdate()
        TreeView3.BeginUpdate()
        TreeView4.BeginUpdate()


        filtergrid = False
        Cursor.Current = Cursors.WaitCursor
        ''    Dim x As Integer
        If Index < 0 Then TreeView1.Nodes.Clear()
        If Index < 1 Then TreeView2.Nodes.Clear()
        If Index < 2 Then TreeView3.Nodes.Clear()


        If Index = -1 Then

            dsHelper.SelectDistinct("Distinctdirector", ds.Tables(0), "director")
            AddNodes(ds.Tables("Distinctdirector"), "Market Manager", 0)
            ds.Tables.Remove("Distinctdirector")


            dsHelper.SelectDistinct("Distinctpais", ds.Tables(0), "pais")
            AddNodes(ds.Tables("Distinctpais"), "Final Market", 1)
            ds.Tables.Remove("Distinctpais")

            dsHelper.SelectDistinct("Distinctcliente", ds.Tables(0), "clidest")
            AddNodes(ds.Tables("Distinctcliente"), "Final Customer", 2)
            ds.Tables.Remove("Distinctcliente")

            dsHelper.SelectDistinct("Distinctclientefact", ds.Tables(0), "clifact")
            AddNodes(ds.Tables("Distinctclientefact"), "Invoicing Customer", 3)
            ds.Tables.Remove("Distinctclientefact")



        Else

            Dim directorDR As DataRow() = ds.Tables(0).Select("(director like '" & filterkeydir _
            & "') and (pais like '" & filterkeypais & "') and (clidest like '" & SQ(filterkeyclidest) _
            & "')")

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            tabeladir.Columns.Add("director", Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("clidest", Type.GetType("System.String"))






            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("director") = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("clidest") = r.Item(2)


                tabeladir.Rows.Add(myrow2)
            Next r

            If Index = 0 Then
                dsHelper.SelectDistinct("Distinctpais", tabeladir, "pais")
                AddNodes(ds.Tables("Distinctpais"), "Final Market", 1)
                ds.Tables.Remove("Distinctpais")
            End If

            If Index < 2 Then
                dsHelper.SelectDistinct("Distinctcliente", tabeladir, "clidest")
                AddNodes(ds.Tables("Distinctcliente"), "Final Customer", 2)
                ds.Tables.Remove("Distinctcliente")
            End If







            tabeladir = Nothing
        End If

        ' Cleanup
        TreeView1.Nodes(0).Expanded = True
        TreeView2.Nodes(0).Expanded = True
        TreeView3.Nodes(0).Expanded = True
        TreeView4.Nodes(0).Expanded = True



        If Index = -1 Then
            If TreeView1.Nodes(0).Nodes.Count > 1 Then TreeView1.Selection.Set(TreeView1.Nodes(0))
            If TreeView2.Nodes(0).Nodes.Count > 1 Then TreeView2.Selection.Set(TreeView2.Nodes(0))
            If TreeView3.Nodes(0).Nodes.Count > 1 Then TreeView3.Selection.Set(TreeView3.Nodes(0))
            '    If TreeView4.Nodes(0).Nodes.Count > 1 Then TreeView4.Selection.Set(TreeView4.Nodes(0))

        End If
        If Index = 0 Then
            If TreeView2.Nodes(0).Nodes.Count > 1 Then TreeView2.Selection.Set(TreeView2.Nodes(0))
            If TreeView3.Nodes(0).Nodes.Count > 1 Then TreeView3.Selection.Set(TreeView3.Nodes(0))
            '   If TreeView4.Nodes(0).Nodes.Count > 1 Then TreeView4.Selection.Set(TreeView4.Nodes(0))

        End If

        If Index = 1 Then
            If TreeView3.Nodes(0).Nodes.Count > 1 Then TreeView3.Selection.Set(TreeView3.Nodes(0))
            '   If TreeView4.Nodes(0).Nodes.Count > 1 Then TreeView4.Selection.Set(TreeView4.Nodes(0))

        End If




        TreeView1.EndUpdate()
        TreeView2.EndUpdate()
        TreeView3.EndUpdate()
        TreeView4.EndUpdate()

        Me.Cursor = Cursors.Default
        flagWork = False

    End Sub
    Private Sub AddNodes(ByRef rs As DataTable, ByVal nome As String, ByVal t As Integer)

        Dim s As String
        Dim nodxA As TreeNode
        Dim nodx As TreeNode
        Dim ret As String

        Select Case t
            Case 0

                With TreeView1
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    If .Nodes(0).Nodes.Count = 1 Then .FocusedNode = .Nodes(0).Nodes(0) : filterkeydir = .Nodes(0).Nodes(0).GetDisplayText(0)




                    'nodxA = .Add(nome)
                    'nodxA.Tag = nome
                    'nodxA.EnsureVisible()
                    's = vbNullString
                    'Dim x As Integer
                    'For x = 0 To rs.Rows.Count - 1
                    '    On Error Resume Next
                    '    If rs.Rows(x).Item(0) <> s Then
                    '        nodx = TreeView1.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                    '    End If
                    'Next
                    'If TreeView1.Nodes(nodxA.Index).Nodes.Count = 1 Then TreeView1.SelectedNode = TreeView1.Nodes(nodxA.Index).Nodes(0) : filterkeydir = TreeView1.Nodes(nodxA.Index).Nodes(0).Text

                End With
            Case 1
                With TreeView2


                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending



                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then

                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)

                    If .Nodes(0).Nodes.Count = 1 Then .FocusedNode = .Nodes(0).Nodes(0) : filterkeypais = .Nodes(0).Nodes(0).GetDisplayText(0)





                    'nodxA = .Nodes.Add(nome)
                    'nodxA.Tag = nome
                    'nodxA.EnsureVisible()

                    's = vbNullString
                    'Dim x As Integer
                    'For x = 0 To rs.Rows.Count - 1
                    '    On Error Resume Next
                    '    If rs.Rows(x).Item(0) <> s Then
                    '        nodx = TreeView2.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                    '    End If
                    'Next
                    'If TreeView2.Nodes(nodxA.Index).Nodes.Count = 1 Then TreeView2.SelectedNode = TreeView2.Nodes(nodxA.Index).Nodes(0) : filterkeypais = TreeView2.Nodes(nodxA.Index).Nodes(0).Text

                End With

            Case 2
                With TreeView3
                    Dim myConnectionPricing As New SqliteConnection
                    myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
                    myConnectionPricing.Open()
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).Caption = "Final Customer"
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .Columns.Add()
                    .Columns(1).VisibleIndex = 1
                    .Columns(1).Caption = "N�"
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            Dim SelectQuerycliFact As String
                            SelectQuerycliFact = "SELECT kunnr FROM sapclients where name1='" & SQ(rs.Rows(x).Item(0)) & "'"
                            Dim myCommandcliente As New SqliteCommand(SelectQuerycliFact, myConnectionPricing)
                            ret = myCommandcliente.ExecuteScalar
                            .AppendNode(New Object() {rs.Rows(x).Item(0), ret}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    .Columns(1).Width = 150
                    myConnectionPricing.Close()
                    If .Nodes(0).Nodes.Count = 1 Then
                        .FocusedNode = .Nodes(0).Nodes(0)
                        filterkeyclidest = .Nodes(0).Nodes(0).GetDisplayText(1)
                    End If




                    'Dim myConnectionPricing As New SQLiteConnection
                    'myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString

                    'myConnectionPricing.Open()

                    'nodxA = .Nodes.Add(nome)
                    'nodxA.Tag = nome
                    'nodxA.EnsureVisible()
                    ''    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL", "ALL")
                    's = vbNullString
                    'Dim x As Integer
                    'For x = 0 To rs.Rows.Count - 1
                    '    On Error Resume Next
                    '    If rs.Rows(x).Item(0) <> s Then

                    '        nodx = .Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))

                    '        'Dim SelectQuerycliFact As String
                    '        'SelectQuerycliFact = "SELECT  clnome FROM erclief where clncli=" & rs.Rows(x).Item(0)
                    '        'Dim myCommandcliente As New SQLiteCommand(SelectQuerycliFact, myConnectionPricing)
                    '        'ret = myCommandcliente.ExecuteScalar
                    '        'nodx = TreeView3.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0), ret & " - " & rs.Rows(x).Item(0))
                    '        'nodx = TreeView3.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0), rs.Rows(x).Item(0) & " - " & ret)


                    '    End If
                    'Next
                    '.Sort()
                    'If TreeView3.Nodes(nodxA.Index).Nodes.Count = 1 Then TreeView3.SelectedNode = TreeView3.Nodes(nodxA.Index).Nodes(0) : filterkeyclidest = TreeView3.Nodes(nodxA.Index).Nodes(0).Name
                    'myConnectionPricing.Close()
                End With

            Case 3
                With TreeView4
                    Dim myConnectionPricing As New SqliteConnection
                    myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
                    myConnectionPricing.Open()
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).Caption = "Invoicing Customer"
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .Columns.Add()
                    .Columns(1).VisibleIndex = 1
                    .Columns(1).Caption = "N�"
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            Dim SelectQuerycliFact As String
                            SelectQuerycliFact = "SELECT  kunnr FROM sapclients where name1='" & SQ(rs.Rows(x).Item(0)) & "'"
                            Dim myCommandcliente As New SqliteCommand(SelectQuerycliFact, myConnectionPricing)
                            ret = myCommandcliente.ExecuteScalar
                            .AppendNode(New Object() {rs.Rows(x).Item(0), ret}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    .Columns(1).Width = 150
                    myConnectionPricing.Close()
                    If .Nodes(0).Nodes.Count = 1 Then .FocusedNode = .Nodes(0).Nodes(0) : filterkeyclifact = .Nodes(0).Nodes(0).GetDisplayText(0)



                End With






        End Select
    End Sub



    Private Sub TreeView1_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView1.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String


        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name

        filterkeydir = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Director", "%", varstr)
        filterkeypais = "%"
        filterkeyclidest = "%"
        filterkeyclifact = "%"


        treefill(0)
        click1 = False
    End Sub

    Private Sub TreeView2_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView2.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String


        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name

        filterkeypais = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Final Market", "%", varstr)
        filterkeyclidest = "%"
        filterkeyclifact = "%"

        treefill(1)

        click2 = False
    End Sub

    Private Sub TreeView3_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView3.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String


        varstr = vbNullString
        varstr = e.Node.GetDisplayText(1) ' e.Node.Name

        filterkeyclidest = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Final Customer", "%", varstr)
        filterkeyclifact = "%"


        treefill(2)

        click3 = False
    End Sub


    Private Sub TreeView4_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView4.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String


        varstr = vbNullString
        varstr = e.Node.GetDisplayText(1) ' e.Node.Name

        filterkeyclifact = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Invoicing Customer", "%", varstr)


        treefill(3)

        click4 = False
    End Sub



    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function

    Public Function getSymcompany(ByVal num As String) As String

        Select Case num
            Case "01"
                Return "Warre"
            Case "02"
                Return "Dow�s"
            Case "03"
                Return "Quarles Harris"
            Case "04"
                Return "Graham�s"
            Case "05"
                Return "SFE"
            Case "06"
                Return "Prats & Symington"
            Case "07"
                Return "Ves�vio"
            Case "08"
                Return "Symington Vinhos, S.A."
            Case "10"
                Return "Roriz"
            Case "16"
                Return "Martinez"
            Case "51"
                Return "Gould Campbell"
            Case "52"
                Return "Smith Woodhouse"
            Case "53"
                Return "Cockburn�s Smithes"
            Case "55"
                Return "SFE - Prats & Symington"

            Case Else
                Return "??"
        End Select


    End Function

    Public Function getSymPriceListType(ByVal cod As String) As String
        cod = UCase(cod)
        'Select Case cod
        '    Case "A"
        '        Return "Standard"
        '    Case "B"
        '        Return "Promocional"
        '    Case "C"
        '        Return "Travel Retail"
        '    Case "D"
        '        Return "Specific Customer"
        '    Case "E"
        '        Return "A"
        '    Case "F"
        '        Return "B"
        '    Case "G"
        '        Return "C"
        '    Case "H"
        '        Return "D"
        ''    Case Else
        'Return "??"
        'End Select

        Me.SapTipoListaPrecosTableAdapter.Fill(Me.SapPricingDataset11.SapTipoListaPrecos)

        Dim drarray() As DataRow
        drarray = Me.SapPricingDataset11.SapTipoListaPrecos.Select("PLTYP = '" & cod & "'")
        Return drarray(0)("PTEXT").ToString()

    End Function


    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.TreeView1.Appearance.Empty.BackColor = Color.Wheat
        Me.TreeView1.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView2.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView2.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView3.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView3.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView4.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView4.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Dim flagfalta As Boolean = False
        If TreeView1.FocusedNode.Level = 0 Then
            Me.TreeView1.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView1.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView2.FocusedNode.Level = 0 Then
            Me.TreeView2.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView2.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView3.FocusedNode.Level = 0 Then
            Me.TreeView3.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView3.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If

        If TreeView4.FocusedNode.Level = 0 Then
            Me.TreeView4.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView4.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If




        If flagfalta = True Then MsgBox("Seleccione as op��es em falta...") : Exit Sub




        With DirectCast(Me.ParentForm, Pricing)

            '.worksheet.Range("C5").Value = ""
            '    .worksheet.Range("C6").Value = ""
            '    .worksheet.Range("C7").Value = ""
            '    .worksheet.Range("C8").Value = ""
            '    .worksheet.Range("C9").Value = ""
            '    .worksheet.Range("C10").Value = ""
            '    .worksheet.Range("C11").Value = ""
            '    .worksheet.Range("D11").Value = ""

            '    .worksheet.Range("C12").Value = ""
            '    .worksheet.Range("D12").Value = filterkeyclifact
            '    .worksheet.Range("C12").Value = ""
            '    .worksheet.Range("D4").Value = filterkeyclidest
            '    .worksheet.Range("C4").Value = ""

            .filterkeydir = filterkeydir
            .filterkeypais = filterkeypais
            .filterkeyclifact = filterkeyclifact
            .filterkeyclidest = filterkeyclidest




            CreatePricing2(filterkeydir, filterkeypais, filterkeyclidest, filterkeyclifact)
        End With

        Me.Close()

    End Sub


    Public Sub CreatePricing2(ByVal director As String, ByVal pais As String, ByVal cliente As String, ByVal clientefact As String)

        '    Dim clientEst As Integer
        Dim MD As String
        Dim mng As String
        Dim ass As String

        Dim ultimalinha As Integer = 24
        'Dim clientEst As Integer

        With DirectCast(Me.ParentForm, Pricing)

            '.spreadsheetControl.BeginUpdate()
            '.workbook.BeginUpdate()
            .worksheet.Unprotect("password2")



            Dim bottlecustlist As New ArrayList
            bottlecustlist.Clear()


            '   Dim mySelectQuery As String

            Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
            myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
            myConnectionPricing.Open()

            '''''INICIO Invoice Customer Information
            '''''INICIO Invoice Customer Information
            '''''INICIO Invoice Customer Information
            'nome cliente
            .worksheet.Cells("D4").Value = cliente
            'Globals.Sheet1.Range("D11").Value2 = cliente


            'dados cliente
            Dim mySelectQuerycliente As String

            mySelectQuerycliente = "SELECT  name1, contactname, contacttelephone, contactemail, landx50, clientstat, marketdirector, marketmanager, marketassistant, KATR3, BRSCH  FROM sapclients where kunnr ='" & SQ(cliente) & "'"
            Dim myCommandcliente As New SQLiteCommand(mySelectQuerycliente, myConnectionPricing)
            Dim myReadercliente As SQLiteDataReader
            myReadercliente = myCommandcliente.ExecuteReader


            Dim clistat As String
            While myReadercliente.Read()
                .worksheet.Cells("C4").Value = (myReadercliente(0)).ToString
                .worksheet.Cells("C8").Value = (myReadercliente(1)).ToString
                .worksheet.Cells("C9").Value = (myReadercliente(2)).ToString
                .worksheet.Cells("C10").Value = (myReadercliente(3)).ToString
                .worksheet.Cells("C5").Value = (myReadercliente(4)).ToString

                .worksheet.Cells("D11").Value = (myReadercliente(5)).ToString
                .worksheet.Cells("C18").Value = myReadercliente(9).ToString 'Mainstream/Emerging
                .worksheet.Cells("C19").Value = myReadercliente(10).ToString '  ' Distributer Type

                MD = myReadercliente(6)
                mng = myReadercliente(7)
                ass = myReadercliente(8)

                clistat = (myReadercliente(5))
            End While
            myReadercliente.Close()

            Dim mySelectQueryclienteDestManager As String
            mySelectQueryclienteDestManager = "SELECT  name1 FROM sapclients where kunnr ='" & mng & "'"
            Dim myCommandclienteDestManager As New SQLiteCommand(mySelectQueryclienteDestManager, myConnectionPricing)
            .worksheet.Cells("C15").Value = myCommandclienteDestManager.ExecuteScalar.ToString  ' Manager


            Dim mySelectQueryclienteDestDirector As String
            mySelectQueryclienteDestDirector = "SELECT  name1 FROM sapclients where kunnr ='" & MD & "'"
            Dim myCommandclienteDestDirector As New SQLiteCommand(mySelectQueryclienteDestDirector, myConnectionPricing)
            .worksheet.Cells("C16").Value = myCommandclienteDestDirector.ExecuteScalar().ToString ' Market Representative



            Dim mySelectQueryclienteDestAssistant As String
            mySelectQueryclienteDestAssistant = "SELECT  name1 FROM sapclients where kunnr ='" & ass & "'"
            Dim myCommandclienteDestAssistant As New SQLiteCommand(mySelectQueryclienteDestAssistant, myConnectionPricing)
            .worksheet.Cells("C17").Value = myCommandclienteDestAssistant.ExecuteScalar().ToString ' Assistant

            Dim mySelectQueryclienteStat As String
            mySelectQueryclienteStat = "SELECT  name1 FROM sapclients where kunnr ='" & clistat & "'"
            Dim myCommandclientestat As New SQLiteCommand(mySelectQueryclienteStat, myConnectionPricing)
            .worksheet.Cells("c11").Value = myCommandclientestat.ExecuteScalar.ToString
            .worksheet.Cells("D11").Value = clistat

            .worksheet.Cells("D12").Value = clientefact



            Dim mySelectQueryclienteFact As String
            mySelectQueryclienteFact = "SELECT  NAME1 FROM sapclients where KUNNR ='" & SQ(clientefact) & "'"
            Dim myCommandclienteEst As New SQLiteCommand(mySelectQueryclienteFact, myConnectionPricing)
            Dim Kunnrclientfact = (myCommandclienteEst.ExecuteScalar)
            .worksheet.Cells("C12").Value = Kunnrclientfact.ToString



            '''''INICIO Terms & Condition
            '''''INICIO Terms & Condition
            '''''INICIO Terms & Condition

            Dim mySelectQueryCREDIT As String = "SELECT KLIMK, zzdiastoler, ztermtext, zincoterms, advertencia, katr4  FROM SAPCLIENTS where kunnr = '" & clientefact & "'"
            Dim myCommandCREDIT As New SQLiteCommand(mySelectQueryCREDIT, myConnectionPricing)
            Dim myReadercredit As SQLiteDataReader
            myReadercredit = myCommandCREDIT.ExecuteReader()
            While myReadercredit.Read
                .worksheet.Cells("G7").Value = myReadercredit(0).ToString 'CreditLimit Value
                .worksheet.Cells("I7").Value = myReadercredit(1).ToString ' credit limit DAYS
                .worksheet.Cells("G8").Value = myReadercredit(2).ToString 'Payment Terms
                .worksheet.Cells("G9").Value = myReadercredit(3).ToString 'Delivery Terms
                .worksheet.Cells("I8").Value = myReadercredit(4).ToString 'Tolerance
                'Globals.Sheet1.Range("G10").Value2 = myReadercredit(5) 'Tamanho da Palete
            End While
            myReadercredit.Close()

            Dim mySelectQueryCREDIT2 As String = "SELECT katr4  FROM SAPCLIENTS where kunnr = '" & cliente & "'"
            Dim myCommandCREDIT2 As New SQLiteCommand(mySelectQueryCREDIT2, myConnectionPricing)
            Dim myReadercredit2 As SQLiteDataReader
            myReadercredit2 = myCommandCREDIT2.ExecuteReader()
            While myReadercredit2.Read
                .worksheet.Cells("G10").Value = myReadercredit2(0).ToString 'Tamanho da Palete
            End While
            myReadercredit2.Close()



            '''''FIM Terms & Condition
            '''''FIM Terms & Condition
            '''''FIM Terms & Condition


            '''''FIM Invoice Customer Information
            '''''FIM Invoice Customer Information
            '''''FIM Invoice Customer Information
            .worksheet.Protect("password2", DevExpress.Spreadsheet.WorksheetProtectionPermissions.FormatColumns)



            myConnectionPricing.Close()

        End With

    End Sub





End Class
