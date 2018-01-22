namespace Oracle_Scripter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkTrigger = new System.Windows.Forms.CheckBox();
            this.chkProcedure = new System.Windows.Forms.CheckBox();
            this.chkFunction = new System.Windows.Forms.CheckBox();
            this.chkDbObjectList = new System.Windows.Forms.CheckedListBox();
            this.lblSavingPath = new System.Windows.Forms.Label();
            this.txtSavingFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.lblConnStr = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.lblObjList = new System.Windows.Forms.Label();
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytSavingPath = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytCheckBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytConn = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetObjects = new System.Windows.Forms.Button();
            this.tblLytFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChosenTypes = new System.Windows.Forms.Label();
            this.lblChosenObjTypes = new System.Windows.Forms.Label();
            this.tblLytSelection = new System.Windows.Forms.TableLayoutPanel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.lblSelectedItemsValue = new System.Windows.Forms.Label();
            this.lblAllItems = new System.Windows.Forms.Label();
            this.lblAllItemsValue = new System.Windows.Forms.Label();
            this.tbCtrlMain = new System.Windows.Forms.TabControl();
            this.tbPgDb = new System.Windows.Forms.TabPage();
            this.tbPgErrorLog = new System.Windows.Forms.TabPage();
            this.txtErrorLog = new System.Windows.Forms.RichTextBox();
            this.tbPgLog = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.browserDestinationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tblLytMain.SuspendLayout();
            this.tblLytSavingPath.SuspendLayout();
            this.tblLytCheckBoxes.SuspendLayout();
            this.tblLytConn.SuspendLayout();
            this.tblLytFilter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLytSelection.SuspendLayout();
            this.tbCtrlMain.SuspendLayout();
            this.tbPgDb.SuspendLayout();
            this.tbPgErrorLog.SuspendLayout();
            this.tbPgLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkTrigger
            // 
            this.chkTrigger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkTrigger.AutoSize = true;
            this.chkTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkTrigger.Location = new System.Drawing.Point(10, 7);
            this.chkTrigger.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkTrigger.Name = "chkTrigger";
            this.chkTrigger.Size = new System.Drawing.Size(88, 20);
            this.chkTrigger.TabIndex = 0;
            this.chkTrigger.Tag = "TRIGGER";
            this.chkTrigger.Text = "TRIGGER";
            this.chkTrigger.UseVisualStyleBackColor = true;
            this.chkTrigger.CheckedChanged += new System.EventHandler(this.chkTypeChanged);
            // 
            // chkProcedure
            // 
            this.chkProcedure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkProcedure.AutoSize = true;
            this.chkProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkProcedure.Location = new System.Drawing.Point(272, 7);
            this.chkProcedure.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkProcedure.Name = "chkProcedure";
            this.chkProcedure.Size = new System.Drawing.Size(113, 20);
            this.chkProcedure.TabIndex = 1;
            this.chkProcedure.Tag = "PROCEDURE";
            this.chkProcedure.Text = "PROCEDURE";
            this.chkProcedure.UseVisualStyleBackColor = true;
            this.chkProcedure.CheckedChanged += new System.EventHandler(this.chkTypeChanged);
            // 
            // chkFunction
            // 
            this.chkFunction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkFunction.AutoSize = true;
            this.chkFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkFunction.Location = new System.Drawing.Point(534, 7);
            this.chkFunction.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkFunction.Name = "chkFunction";
            this.chkFunction.Size = new System.Drawing.Size(96, 20);
            this.chkFunction.TabIndex = 2;
            this.chkFunction.Tag = "FUNCTION";
            this.chkFunction.Text = "FUNCTION";
            this.chkFunction.UseVisualStyleBackColor = true;
            this.chkFunction.CheckedChanged += new System.EventHandler(this.chkTypeChanged);
            // 
            // chkDbObjectList
            // 
            this.chkDbObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDbObjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkDbObjectList.FormattingEnabled = true;
            this.chkDbObjectList.Location = new System.Drawing.Point(3, 203);
            this.chkDbObjectList.Name = "chkDbObjectList";
            this.chkDbObjectList.Size = new System.Drawing.Size(1049, 430);
            this.chkDbObjectList.TabIndex = 3;
            this.chkDbObjectList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkDbObjectList_ItemCheck);
            // 
            // lblSavingPath
            // 
            this.lblSavingPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSavingPath.AutoSize = true;
            this.lblSavingPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSavingPath.Location = new System.Drawing.Point(3, 16);
            this.lblSavingPath.Name = "lblSavingPath";
            this.lblSavingPath.Size = new System.Drawing.Size(86, 16);
            this.lblSavingPath.TabIndex = 5;
            this.lblSavingPath.Text = "Saving Path :";
            // 
            // txtSavingFolderPath
            // 
            this.txtSavingFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavingFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSavingFolderPath.Location = new System.Drawing.Point(101, 13);
            this.txtSavingFolderPath.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtSavingFolderPath.Name = "txtSavingFolderPath";
            this.txtSavingFolderPath.ReadOnly = true;
            this.txtSavingFolderPath.Size = new System.Drawing.Size(847, 22);
            this.txtSavingFolderPath.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBrowse.Location = new System.Drawing.Point(959, 7);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 34);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGenerate.Location = new System.Drawing.Point(483, 702);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(89, 32);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnTestConn
            // 
            this.btnTestConn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnTestConn.Location = new System.Drawing.Point(824, 4);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(89, 45);
            this.btnTestConn.TabIndex = 9;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // lblConnStr
            // 
            this.lblConnStr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConnStr.AutoSize = true;
            this.lblConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblConnStr.Location = new System.Drawing.Point(4, 19);
            this.lblConnStr.Name = "lblConnStr";
            this.lblConnStr.Size = new System.Drawing.Size(111, 16);
            this.lblConnStr.TabIndex = 10;
            this.lblConnStr.Text = "Conection String :";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtConnStr.Location = new System.Drawing.Point(121, 16);
            this.txtConnStr.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(687, 22);
            this.txtConnStr.TabIndex = 11;
            // 
            // lblObjList
            // 
            this.lblObjList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObjList.AutoSize = true;
            this.lblObjList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblObjList.Location = new System.Drawing.Point(3, 6);
            this.lblObjList.Name = "lblObjList";
            this.lblObjList.Size = new System.Drawing.Size(76, 16);
            this.lblObjList.TabIndex = 12;
            this.lblObjList.Text = "Object List :";
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.chkDbObjectList, 0, 5);
            this.tblLytMain.Controls.Add(this.btnGenerate, 0, 7);
            this.tblLytMain.Controls.Add(this.tblLytSavingPath, 0, 6);
            this.tblLytMain.Controls.Add(this.tblLytCheckBoxes, 0, 1);
            this.tblLytMain.Controls.Add(this.tblLytConn, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytFilter, 0, 2);
            this.tblLytMain.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tblLytMain.Controls.Add(this.tblLytSelection, 0, 4);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(3, 3);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 8;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytMain.Size = new System.Drawing.Size(1055, 746);
            this.tblLytMain.TabIndex = 13;
            // 
            // tblLytSavingPath
            // 
            this.tblLytSavingPath.ColumnCount = 3;
            this.tblLytSavingPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytSavingPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSavingPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytSavingPath.Controls.Add(this.txtSavingFolderPath, 1, 0);
            this.tblLytSavingPath.Controls.Add(this.btnBrowse, 2, 0);
            this.tblLytSavingPath.Controls.Add(this.lblSavingPath, 0, 0);
            this.tblLytSavingPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytSavingPath.Location = new System.Drawing.Point(3, 639);
            this.tblLytSavingPath.Name = "tblLytSavingPath";
            this.tblLytSavingPath.RowCount = 1;
            this.tblLytSavingPath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSavingPath.Size = new System.Drawing.Size(1049, 48);
            this.tblLytSavingPath.TabIndex = 13;
            // 
            // tblLytCheckBoxes
            // 
            this.tblLytCheckBoxes.ColumnCount = 4;
            this.tblLytCheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytCheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytCheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytCheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytCheckBoxes.Controls.Add(this.chkFunction, 2, 0);
            this.tblLytCheckBoxes.Controls.Add(this.chkProcedure, 1, 0);
            this.tblLytCheckBoxes.Controls.Add(this.chkTrigger, 0, 0);
            this.tblLytCheckBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytCheckBoxes.Location = new System.Drawing.Point(3, 63);
            this.tblLytCheckBoxes.Name = "tblLytCheckBoxes";
            this.tblLytCheckBoxes.RowCount = 1;
            this.tblLytCheckBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytCheckBoxes.Size = new System.Drawing.Size(1049, 34);
            this.tblLytCheckBoxes.TabIndex = 14;
            // 
            // tblLytConn
            // 
            this.tblLytConn.ColumnCount = 4;
            this.tblLytConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytConn.Controls.Add(this.lblConnStr, 0, 0);
            this.tblLytConn.Controls.Add(this.btnTestConn, 2, 0);
            this.tblLytConn.Controls.Add(this.txtConnStr, 1, 0);
            this.tblLytConn.Controls.Add(this.btnGetObjects, 3, 0);
            this.tblLytConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytConn.Location = new System.Drawing.Point(3, 3);
            this.tblLytConn.Name = "tblLytConn";
            this.tblLytConn.RowCount = 1;
            this.tblLytConn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConn.Size = new System.Drawing.Size(1049, 54);
            this.tblLytConn.TabIndex = 15;
            // 
            // btnGetObjects
            // 
            this.btnGetObjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetObjects.Location = new System.Drawing.Point(940, 4);
            this.btnGetObjects.Name = "btnGetObjects";
            this.btnGetObjects.Size = new System.Drawing.Size(97, 46);
            this.btnGetObjects.TabIndex = 12;
            this.btnGetObjects.Text = "Get Objects";
            this.btnGetObjects.UseVisualStyleBackColor = true;
            this.btnGetObjects.Click += new System.EventHandler(this.btnGetObjects_Click);
            // 
            // tblLytFilter
            // 
            this.tblLytFilter.ColumnCount = 3;
            this.tblLytFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytFilter.Controls.Add(this.lblFilter, 0, 0);
            this.tblLytFilter.Controls.Add(this.txtFilter, 1, 0);
            this.tblLytFilter.Controls.Add(this.btnClearFilter, 2, 0);
            this.tblLytFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytFilter.Location = new System.Drawing.Point(3, 103);
            this.tblLytFilter.Name = "tblLytFilter";
            this.tblLytFilter.RowCount = 1;
            this.tblLytFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytFilter.Size = new System.Drawing.Size(1049, 29);
            this.tblLytFilter.TabIndex = 16;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFilter.Location = new System.Drawing.Point(3, 6);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(43, 16);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter :";
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFilter.Location = new System.Drawing.Point(101, 3);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(847, 22);
            this.txtFilter.TabIndex = 1;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClearFilter.Location = new System.Drawing.Point(950, 1);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(98, 27);
            this.btnClearFilter.TabIndex = 2;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblObjList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChosenTypes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChosenObjTypes, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 29);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // lblChosenTypes
            // 
            this.lblChosenTypes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChosenTypes.AutoSize = true;
            this.lblChosenTypes.Location = new System.Drawing.Point(265, 6);
            this.lblChosenTypes.Name = "lblChosenTypes";
            this.lblChosenTypes.Size = new System.Drawing.Size(141, 16);
            this.lblChosenTypes.TabIndex = 13;
            this.lblChosenTypes.Text = "Chosen Object Types:";
            // 
            // lblChosenObjTypes
            // 
            this.lblChosenObjTypes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChosenObjTypes.AutoSize = true;
            this.lblChosenObjTypes.Location = new System.Drawing.Point(527, 6);
            this.lblChosenObjTypes.Name = "lblChosenObjTypes";
            this.lblChosenObjTypes.Size = new System.Drawing.Size(0, 16);
            this.lblChosenObjTypes.TabIndex = 14;
            // 
            // tblLytSelection
            // 
            this.tblLytSelection.ColumnCount = 5;
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.Controls.Add(this.chkSelectAll, 0, 0);
            this.tblLytSelection.Controls.Add(this.lblSelectedItems, 1, 0);
            this.tblLytSelection.Controls.Add(this.lblSelectedItemsValue, 2, 0);
            this.tblLytSelection.Controls.Add(this.lblAllItems, 3, 0);
            this.tblLytSelection.Controls.Add(this.lblAllItemsValue, 4, 0);
            this.tblLytSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytSelection.Location = new System.Drawing.Point(3, 173);
            this.tblLytSelection.Name = "tblLytSelection";
            this.tblLytSelection.RowCount = 1;
            this.tblLytSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSelection.Size = new System.Drawing.Size(1049, 24);
            this.tblLytSelection.TabIndex = 19;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(3, 3);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(83, 18);
            this.chkSelectAll.TabIndex = 17;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.Location = new System.Drawing.Point(312, 4);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(103, 16);
            this.lblSelectedItems.TabIndex = 18;
            this.lblSelectedItems.Text = "Selected Items :";
            // 
            // lblSelectedItemsValue
            // 
            this.lblSelectedItemsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectedItemsValue.AutoSize = true;
            this.lblSelectedItemsValue.Location = new System.Drawing.Point(421, 4);
            this.lblSelectedItemsValue.Name = "lblSelectedItemsValue";
            this.lblSelectedItemsValue.Size = new System.Drawing.Size(0, 16);
            this.lblSelectedItemsValue.TabIndex = 19;
            // 
            // lblAllItems
            // 
            this.lblAllItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAllItems.AutoSize = true;
            this.lblAllItems.Location = new System.Drawing.Point(769, 4);
            this.lblAllItems.Name = "lblAllItems";
            this.lblAllItems.Size = new System.Drawing.Size(64, 16);
            this.lblAllItems.TabIndex = 20;
            this.lblAllItems.Text = "All Items :";
            // 
            // lblAllItemsValue
            // 
            this.lblAllItemsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAllItemsValue.AutoSize = true;
            this.lblAllItemsValue.Location = new System.Drawing.Point(839, 4);
            this.lblAllItemsValue.Name = "lblAllItemsValue";
            this.lblAllItemsValue.Size = new System.Drawing.Size(0, 16);
            this.lblAllItemsValue.TabIndex = 21;
            // 
            // tbCtrlMain
            // 
            this.tbCtrlMain.Controls.Add(this.tbPgDb);
            this.tbCtrlMain.Controls.Add(this.tbPgErrorLog);
            this.tbCtrlMain.Controls.Add(this.tbPgLog);
            this.tbCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tbCtrlMain.Name = "tbCtrlMain";
            this.tbCtrlMain.SelectedIndex = 0;
            this.tbCtrlMain.Size = new System.Drawing.Size(1069, 781);
            this.tbCtrlMain.TabIndex = 14;
            // 
            // tbPgDb
            // 
            this.tbPgDb.Controls.Add(this.tblLytMain);
            this.tbPgDb.Location = new System.Drawing.Point(4, 25);
            this.tbPgDb.Name = "tbPgDb";
            this.tbPgDb.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDb.Size = new System.Drawing.Size(1061, 752);
            this.tbPgDb.TabIndex = 0;
            this.tbPgDb.Text = "Database";
            this.tbPgDb.UseVisualStyleBackColor = true;
            // 
            // tbPgErrorLog
            // 
            this.tbPgErrorLog.Controls.Add(this.txtErrorLog);
            this.tbPgErrorLog.Location = new System.Drawing.Point(4, 25);
            this.tbPgErrorLog.Name = "tbPgErrorLog";
            this.tbPgErrorLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgErrorLog.Size = new System.Drawing.Size(1061, 752);
            this.tbPgErrorLog.TabIndex = 1;
            this.tbPgErrorLog.Text = "ErrorLog";
            this.tbPgErrorLog.UseVisualStyleBackColor = true;
            // 
            // txtErrorLog
            // 
            this.txtErrorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErrorLog.Location = new System.Drawing.Point(3, 3);
            this.txtErrorLog.Name = "txtErrorLog";
            this.txtErrorLog.ReadOnly = true;
            this.txtErrorLog.Size = new System.Drawing.Size(1055, 746);
            this.txtErrorLog.TabIndex = 0;
            this.txtErrorLog.Text = "";
            // 
            // tbPgLog
            // 
            this.tbPgLog.Controls.Add(this.txtLog);
            this.tbPgLog.Location = new System.Drawing.Point(4, 25);
            this.tbPgLog.Name = "tbPgLog";
            this.tbPgLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgLog.Size = new System.Drawing.Size(1061, 752);
            this.tbPgLog.TabIndex = 2;
            this.tbPgLog.Text = "Log";
            this.tbPgLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1055, 746);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 781);
            this.Controls.Add(this.tbCtrlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tblLytMain.ResumeLayout(false);
            this.tblLytSavingPath.ResumeLayout(false);
            this.tblLytSavingPath.PerformLayout();
            this.tblLytCheckBoxes.ResumeLayout(false);
            this.tblLytCheckBoxes.PerformLayout();
            this.tblLytConn.ResumeLayout(false);
            this.tblLytConn.PerformLayout();
            this.tblLytFilter.ResumeLayout(false);
            this.tblLytFilter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblLytSelection.ResumeLayout(false);
            this.tblLytSelection.PerformLayout();
            this.tbCtrlMain.ResumeLayout(false);
            this.tbPgDb.ResumeLayout(false);
            this.tbPgErrorLog.ResumeLayout(false);
            this.tbPgLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTrigger;
        private System.Windows.Forms.CheckBox chkProcedure;
        private System.Windows.Forms.CheckBox chkFunction;
        private System.Windows.Forms.CheckedListBox chkDbObjectList;
        private System.Windows.Forms.Label lblSavingPath;
        private System.Windows.Forms.TextBox txtSavingFolderPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Label lblConnStr;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.Label lblObjList;
        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytSavingPath;
        private System.Windows.Forms.TableLayoutPanel tblLytCheckBoxes;
        private System.Windows.Forms.TableLayoutPanel tblLytConn;
        private System.Windows.Forms.TabControl tbCtrlMain;
        private System.Windows.Forms.TabPage tbPgDb;
        private System.Windows.Forms.TabPage tbPgErrorLog;
        private System.Windows.Forms.TableLayoutPanel tblLytFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.RichTextBox txtErrorLog;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.TabPage tbPgLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnGetObjects;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblChosenTypes;
        private System.Windows.Forms.Label lblChosenObjTypes;
        private System.Windows.Forms.TableLayoutPanel tblLytSelection;
        private System.Windows.Forms.Label lblSelectedItems;
        private System.Windows.Forms.Label lblSelectedItemsValue;
        private System.Windows.Forms.Label lblAllItems;
        private System.Windows.Forms.Label lblAllItemsValue;
        private System.Windows.Forms.FolderBrowserDialog browserDestinationDialog;
    }
}