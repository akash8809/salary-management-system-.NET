﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDUCATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESIGNATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPDETAILSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployDataSet = New WindowsApplication1.employDataSet()
        Me.EMPDETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpDataSet1 = New WindowsApplication1.empDataSet1()
        Me.EMP_DETAILSTableAdapter = New WindowsApplication1.empDataSet1TableAdapters.EMP_DETAILSTableAdapter()
        Me.EmpDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMP_DETAILSTableAdapter1 = New WindowsApplication1.employDataSetTableAdapters.EMP_DETAILSTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.etxt = New System.Windows.Forms.TextBox()
        Me.fntxt = New System.Windows.Forms.TextBox()
        Me.lntxt = New System.Windows.Forms.TextBox()
        Me.addtxt = New System.Windows.Forms.TextBox()
        Me.ctxt = New System.Windows.Forms.TextBox()
        Me.emtxt = New System.Windows.Forms.TextBox()
        Me.db = New System.Windows.Forms.DateTimePicker()
        Me.atxt = New System.Windows.Forms.TextBox()
        Me.edtxt = New System.Windows.Forms.TextBox()
        Me.detxt = New System.Windows.Forms.ComboBox()
        Me.gentxt = New System.Windows.Forms.ComboBox()
        Me.satxt = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPDETAILSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPDETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(668, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FIRST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(736, 205)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EMAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ADDRESS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(366, 298)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "EDUCATION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(366, 207)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CONTACT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(366, 344)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "GENDER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(736, 297)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DESIGNATION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(736, 253)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "AGE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(736, 127)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 22)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "LAST NAME"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(370, 397)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 39)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCyan
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(714, 397)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 39)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCyan
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(547, 397)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 39)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "EDIT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightCyan
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(887, 397)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 39)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "HOME"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(366, 80)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 22)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "EMP_ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(736, 344)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 22)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "SALARY"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPIDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.AGEDataGridViewTextBoxColumn, Me.EDUCATIONDataGridViewTextBoxColumn, Me.DESIGNATIONDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.SALARYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPDETAILSBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(184, 475)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(931, 114)
        Me.DataGridView1.TabIndex = 30
        '
        'EMPIDDataGridViewTextBoxColumn
        '
        Me.EMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMP_ID"
        Me.EMPIDDataGridViewTextBoxColumn.HeaderText = "EMP_ID"
        Me.EMPIDDataGridViewTextBoxColumn.Name = "EMPIDDataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'CONTACTDataGridViewTextBoxColumn
        '
        Me.CONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.Name = "CONTACTDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'AGEDataGridViewTextBoxColumn
        '
        Me.AGEDataGridViewTextBoxColumn.DataPropertyName = "AGE"
        Me.AGEDataGridViewTextBoxColumn.HeaderText = "AGE"
        Me.AGEDataGridViewTextBoxColumn.Name = "AGEDataGridViewTextBoxColumn"
        '
        'EDUCATIONDataGridViewTextBoxColumn
        '
        Me.EDUCATIONDataGridViewTextBoxColumn.DataPropertyName = "EDUCATION"
        Me.EDUCATIONDataGridViewTextBoxColumn.HeaderText = "EDUCATION"
        Me.EDUCATIONDataGridViewTextBoxColumn.Name = "EDUCATIONDataGridViewTextBoxColumn"
        '
        'DESIGNATIONDataGridViewTextBoxColumn
        '
        Me.DESIGNATIONDataGridViewTextBoxColumn.DataPropertyName = "DESIGNATION"
        Me.DESIGNATIONDataGridViewTextBoxColumn.HeaderText = "DESIGNATION"
        Me.DESIGNATIONDataGridViewTextBoxColumn.Name = "DESIGNATIONDataGridViewTextBoxColumn"
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        '
        'SALARYDataGridViewTextBoxColumn
        '
        Me.SALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.HeaderText = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.Name = "SALARYDataGridViewTextBoxColumn"
        '
        'EMPDETAILSBindingSource1
        '
        Me.EMPDETAILSBindingSource1.DataMember = "EMP_DETAILS"
        Me.EMPDETAILSBindingSource1.DataSource = Me.EmployDataSet
        '
        'EmployDataSet
        '
        Me.EmployDataSet.DataSetName = "employDataSet"
        Me.EmployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPDETAILSBindingSource
        '
        Me.EMPDETAILSBindingSource.DataMember = "EMP_DETAILS"
        Me.EMPDETAILSBindingSource.DataSource = Me.EmpDataSet1
        '
        'EmpDataSet1
        '
        Me.EmpDataSet1.DataSetName = "empDataSet1"
        Me.EmpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMP_DETAILSTableAdapter
        '
        Me.EMP_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'EmpDataSet1BindingSource
        '
        Me.EmpDataSet1BindingSource.DataSource = Me.EmpDataSet1
        Me.EmpDataSet1BindingSource.Position = 0
        '
        'EMP_DETAILSTableAdapter1
        '
        Me.EMP_DETAILSTableAdapter1.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCyan
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(631, 80)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 25)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1251, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'etxt
        '
        Me.etxt.Location = New System.Drawing.Point(502, 80)
        Me.etxt.Margin = New System.Windows.Forms.Padding(2)
        Me.etxt.Multiline = True
        Me.etxt.Name = "etxt"
        Me.etxt.Size = New System.Drawing.Size(125, 24)
        Me.etxt.TabIndex = 34
        '
        'fntxt
        '
        Me.fntxt.Location = New System.Drawing.Point(502, 123)
        Me.fntxt.Margin = New System.Windows.Forms.Padding(2)
        Me.fntxt.Name = "fntxt"
        Me.fntxt.Size = New System.Drawing.Size(125, 20)
        Me.fntxt.TabIndex = 35
        '
        'lntxt
        '
        Me.lntxt.Location = New System.Drawing.Point(906, 124)
        Me.lntxt.Margin = New System.Windows.Forms.Padding(2)
        Me.lntxt.Name = "lntxt"
        Me.lntxt.Size = New System.Drawing.Size(125, 20)
        Me.lntxt.TabIndex = 36
        '
        'addtxt
        '
        Me.addtxt.Location = New System.Drawing.Point(502, 165)
        Me.addtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.addtxt.Name = "addtxt"
        Me.addtxt.Size = New System.Drawing.Size(280, 20)
        Me.addtxt.TabIndex = 37
        '
        'ctxt
        '
        Me.ctxt.Location = New System.Drawing.Point(502, 204)
        Me.ctxt.Margin = New System.Windows.Forms.Padding(2)
        Me.ctxt.Name = "ctxt"
        Me.ctxt.Size = New System.Drawing.Size(125, 20)
        Me.ctxt.TabIndex = 38
        '
        'emtxt
        '
        Me.emtxt.Location = New System.Drawing.Point(906, 205)
        Me.emtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.emtxt.Name = "emtxt"
        Me.emtxt.Size = New System.Drawing.Size(125, 20)
        Me.emtxt.TabIndex = 40
        '
        'db
        '
        Me.db.Location = New System.Drawing.Point(502, 249)
        Me.db.MaxDate = New Date(2004, 12, 31, 0, 0, 0, 0)
        Me.db.Name = "db"
        Me.db.Size = New System.Drawing.Size(125, 20)
        Me.db.TabIndex = 41
        Me.db.Value = New Date(2004, 12, 31, 0, 0, 0, 0)
        '
        'atxt
        '
        Me.atxt.Location = New System.Drawing.Point(906, 254)
        Me.atxt.Margin = New System.Windows.Forms.Padding(2)
        Me.atxt.Name = "atxt"
        Me.atxt.Size = New System.Drawing.Size(125, 20)
        Me.atxt.TabIndex = 42
        '
        'edtxt
        '
        Me.edtxt.Location = New System.Drawing.Point(502, 295)
        Me.edtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.edtxt.Name = "edtxt"
        Me.edtxt.Size = New System.Drawing.Size(125, 20)
        Me.edtxt.TabIndex = 43
        '
        'detxt
        '
        Me.detxt.FormattingEnabled = True
        Me.detxt.Items.AddRange(New Object() {"MANAGER", "SUPERVISOR", "WORKER"})
        Me.detxt.Location = New System.Drawing.Point(906, 298)
        Me.detxt.Name = "detxt"
        Me.detxt.Size = New System.Drawing.Size(125, 21)
        Me.detxt.Sorted = True
        Me.detxt.TabIndex = 44
        '
        'gentxt
        '
        Me.gentxt.FormattingEnabled = True
        Me.gentxt.Items.AddRange(New Object() {"FEMALE", "MALE", "OTHERS"})
        Me.gentxt.Location = New System.Drawing.Point(502, 340)
        Me.gentxt.Name = "gentxt"
        Me.gentxt.Size = New System.Drawing.Size(125, 21)
        Me.gentxt.Sorted = True
        Me.gentxt.TabIndex = 45
        '
        'satxt
        '
        Me.satxt.Location = New System.Drawing.Point(906, 340)
        Me.satxt.Margin = New System.Windows.Forms.Padding(2)
        Me.satxt.Name = "satxt"
        Me.satxt.Size = New System.Drawing.Size(125, 20)
        Me.satxt.TabIndex = 46
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2023_04_10_at_18_50_54
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 640)
        Me.Controls.Add(Me.satxt)
        Me.Controls.Add(Me.gentxt)
        Me.Controls.Add(Me.detxt)
        Me.Controls.Add(Me.edtxt)
        Me.Controls.Add(Me.atxt)
        Me.Controls.Add(Me.db)
        Me.Controls.Add(Me.emtxt)
        Me.Controls.Add(Me.ctxt)
        Me.Controls.Add(Me.addtxt)
        Me.Controls.Add(Me.lntxt)
        Me.Controls.Add(Me.fntxt)
        Me.Controls.Add(Me.etxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPDETAILSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPDETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EmpDataSet1 As WindowsApplication1.empDataSet1
    Friend WithEvents EMPDETAILSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMP_DETAILSTableAdapter As WindowsApplication1.empDataSet1TableAdapters.EMP_DETAILSTableAdapter
    Friend WithEvents EmpDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployDataSet As WindowsApplication1.employDataSet
    Friend WithEvents EMPDETAILSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EMP_DETAILSTableAdapter1 As WindowsApplication1.employDataSetTableAdapters.EMP_DETAILSTableAdapter
    Friend WithEvents EMPIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AGEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EDUCATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESIGNATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALARYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents etxt As System.Windows.Forms.TextBox
    Friend WithEvents fntxt As System.Windows.Forms.TextBox
    Friend WithEvents lntxt As System.Windows.Forms.TextBox
    Friend WithEvents addtxt As System.Windows.Forms.TextBox
    Friend WithEvents ctxt As System.Windows.Forms.TextBox
    Friend WithEvents emtxt As System.Windows.Forms.TextBox
    Friend WithEvents db As System.Windows.Forms.DateTimePicker
    Friend WithEvents atxt As System.Windows.Forms.TextBox
    Friend WithEvents edtxt As System.Windows.Forms.TextBox
    Friend WithEvents detxt As System.Windows.Forms.ComboBox
    Friend WithEvents gentxt As System.Windows.Forms.ComboBox
    Friend WithEvents satxt As System.Windows.Forms.TextBox
End Class
