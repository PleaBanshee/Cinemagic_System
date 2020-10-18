namespace RandomProj
{
    partial class Main_Snacks
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
            this.groupSnacks = new System.Windows.Forms.GroupBox();
            this.dbGridSnacks = new System.Windows.Forms.DataGridView();
            this.groupMaintain_Snacks = new System.Windows.Forms.GroupBox();
            this.btnDelete_Snack = new System.Windows.Forms.Button();
            this.lblFill_Snack = new System.Windows.Forms.Label();
            this.spinFill_SnackID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeleteSnack = new System.Windows.Forms.Label();
            this.spinID = new System.Windows.Forms.NumericUpDown();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btnUpdate_Snacks = new System.Windows.Forms.Button();
            this.btnFill_Snacks = new System.Windows.Forms.Button();
            this.btnAdd_Snacks = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtUnit_Cost = new System.Windows.Forms.TextBox();
            this.lblUnit_Cost = new System.Windows.Forms.Label();
            this.spinQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.groupTransact_Detail = new System.Windows.Forms.GroupBox();
            this.dbTransaction_Details = new System.Windows.Forms.DataGridView();
            this.groupTransact_Details = new System.Windows.Forms.GroupBox();
            this.spinSnack_ID = new System.Windows.Forms.NumericUpDown();
            this.btnDelete_Transaction = new System.Windows.Forms.Button();
            this.lblFill_Transact = new System.Windows.Forms.Label();
            this.spinFill_SnackSaleID = new System.Windows.Forms.NumericUpDown();
            this.lblFill_SnackSaleID = new System.Windows.Forms.Label();
            this.lblDelete_Transact = new System.Windows.Forms.Label();
            this.spinDelete_TransactID = new System.Windows.Forms.NumericUpDown();
            this.lblDelete_TransactID = new System.Windows.Forms.Label();
            this.btnUpdate_Transact = new System.Windows.Forms.Button();
            this.btnFill_Transact = new System.Windows.Forms.Button();
            this.btnAdd_Transact = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.spinQuantity_Ordered = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity_Ordered = new System.Windows.Forms.Label();
            this.lblSnack_ID = new System.Windows.Forms.Label();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.dbGridTransact_Dates = new System.Windows.Forms.DataGridView();
            this.groupDeleteTransacts = new System.Windows.Forms.GroupBox();
            this.btnDelete_All = new System.Windows.Forms.Button();
            this.lblDeleteAllTransactions = new System.Windows.Forms.Label();
            this.spinDeleteAll = new System.Windows.Forms.NumericUpDown();
            this.lblDeleteAll = new System.Windows.Forms.Label();
            this.groupSnacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridSnacks)).BeginInit();
            this.groupMaintain_Snacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinFill_SnackID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity)).BeginInit();
            this.groupTransact_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbTransaction_Details)).BeginInit();
            this.groupTransact_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSnack_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinFill_SnackSaleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDelete_TransactID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity_Ordered)).BeginInit();
            this.groupDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridTransact_Dates)).BeginInit();
            this.groupDeleteTransacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeleteAll)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSnacks
            // 
            this.groupSnacks.Controls.Add(this.dbGridSnacks);
            this.groupSnacks.Controls.Add(this.groupMaintain_Snacks);
            this.groupSnacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSnacks.Location = new System.Drawing.Point(16, 15);
            this.groupSnacks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSnacks.Name = "groupSnacks";
            this.groupSnacks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSnacks.Size = new System.Drawing.Size(628, 929);
            this.groupSnacks.TabIndex = 0;
            this.groupSnacks.TabStop = false;
            this.groupSnacks.Text = "SNACKS";
            // 
            // dbGridSnacks
            // 
            this.dbGridSnacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridSnacks.Location = new System.Drawing.Point(40, 49);
            this.dbGridSnacks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbGridSnacks.Name = "dbGridSnacks";
            this.dbGridSnacks.RowTemplate.Height = 24;
            this.dbGridSnacks.Size = new System.Drawing.Size(537, 249);
            this.dbGridSnacks.TabIndex = 0;
            // 
            // groupMaintain_Snacks
            // 
            this.groupMaintain_Snacks.Controls.Add(this.btnDelete_Snack);
            this.groupMaintain_Snacks.Controls.Add(this.lblFill_Snack);
            this.groupMaintain_Snacks.Controls.Add(this.spinFill_SnackID);
            this.groupMaintain_Snacks.Controls.Add(this.label2);
            this.groupMaintain_Snacks.Controls.Add(this.lblDeleteSnack);
            this.groupMaintain_Snacks.Controls.Add(this.spinID);
            this.groupMaintain_Snacks.Controls.Add(this.lbl_ID);
            this.groupMaintain_Snacks.Controls.Add(this.btnUpdate_Snacks);
            this.groupMaintain_Snacks.Controls.Add(this.btnFill_Snacks);
            this.groupMaintain_Snacks.Controls.Add(this.btnAdd_Snacks);
            this.groupMaintain_Snacks.Controls.Add(this.txtPrice);
            this.groupMaintain_Snacks.Controls.Add(this.lblPrice);
            this.groupMaintain_Snacks.Controls.Add(this.txtUnit_Cost);
            this.groupMaintain_Snacks.Controls.Add(this.lblUnit_Cost);
            this.groupMaintain_Snacks.Controls.Add(this.spinQuantity);
            this.groupMaintain_Snacks.Controls.Add(this.lblQuantity);
            this.groupMaintain_Snacks.Controls.Add(this.txtDescription);
            this.groupMaintain_Snacks.Controls.Add(this.lblDescription);
            this.groupMaintain_Snacks.Controls.Add(this.txtItem);
            this.groupMaintain_Snacks.Controls.Add(this.lblItem);
            this.groupMaintain_Snacks.Location = new System.Drawing.Point(40, 319);
            this.groupMaintain_Snacks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupMaintain_Snacks.Name = "groupMaintain_Snacks";
            this.groupMaintain_Snacks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupMaintain_Snacks.Size = new System.Drawing.Size(537, 583);
            this.groupMaintain_Snacks.TabIndex = 1;
            this.groupMaintain_Snacks.TabStop = false;
            this.groupMaintain_Snacks.Text = "MAINTAIN SNACKS";
            // 
            // btnDelete_Snack
            // 
            this.btnDelete_Snack.Location = new System.Drawing.Point(315, 511);
            this.btnDelete_Snack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete_Snack.Name = "btnDelete_Snack";
            this.btnDelete_Snack.Size = new System.Drawing.Size(123, 28);
            this.btnDelete_Snack.TabIndex = 19;
            this.btnDelete_Snack.Text = "DELETE";
            this.btnDelete_Snack.UseVisualStyleBackColor = true;
            this.btnDelete_Snack.Click += new System.EventHandler(this.btnDelete_Snack_Click);
            // 
            // lblFill_Snack
            // 
            this.lblFill_Snack.AutoSize = true;
            this.lblFill_Snack.Location = new System.Drawing.Point(37, 321);
            this.lblFill_Snack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFill_Snack.Name = "lblFill_Snack";
            this.lblFill_Snack.Size = new System.Drawing.Size(270, 17);
            this.lblFill_Snack.TabIndex = 18;
            this.lblFill_Snack.Text = "FILL INPUT CONTROLS WITH DATA";
            // 
            // spinFill_SnackID
            // 
            this.spinFill_SnackID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinFill_SnackID.Location = new System.Drawing.Point(145, 362);
            this.spinFill_SnackID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinFill_SnackID.Name = "spinFill_SnackID";
            this.spinFill_SnackID.Size = new System.Drawing.Size(133, 22);
            this.spinFill_SnackID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Snack_ID:";
            // 
            // lblDeleteSnack
            // 
            this.lblDeleteSnack.AutoSize = true;
            this.lblDeleteSnack.Location = new System.Drawing.Point(37, 471);
            this.lblDeleteSnack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteSnack.Name = "lblDeleteSnack";
            this.lblDeleteSnack.Size = new System.Drawing.Size(139, 17);
            this.lblDeleteSnack.TabIndex = 15;
            this.lblDeleteSnack.Text = "DELETE A SNACK";
            // 
            // spinID
            // 
            this.spinID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinID.Location = new System.Drawing.Point(145, 512);
            this.spinID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinID.Name = "spinID";
            this.spinID.Size = new System.Drawing.Size(133, 22);
            this.spinID.TabIndex = 14;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(67, 517);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(72, 17);
            this.lbl_ID.TabIndex = 13;
            this.lbl_ID.Text = "Snack_ID:";
            // 
            // btnUpdate_Snacks
            // 
            this.btnUpdate_Snacks.Location = new System.Drawing.Point(41, 410);
            this.btnUpdate_Snacks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate_Snacks.Name = "btnUpdate_Snacks";
            this.btnUpdate_Snacks.Size = new System.Drawing.Size(373, 28);
            this.btnUpdate_Snacks.TabIndex = 12;
            this.btnUpdate_Snacks.Text = "UPDATE SNACKS";
            this.btnUpdate_Snacks.UseVisualStyleBackColor = true;
            this.btnUpdate_Snacks.Click += new System.EventHandler(this.btnUpdate_Snacks_Click);
            // 
            // btnFill_Snacks
            // 
            this.btnFill_Snacks.Location = new System.Drawing.Point(315, 361);
            this.btnFill_Snacks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFill_Snacks.Name = "btnFill_Snacks";
            this.btnFill_Snacks.Size = new System.Drawing.Size(100, 28);
            this.btnFill_Snacks.TabIndex = 11;
            this.btnFill_Snacks.Text = "FILL";
            this.btnFill_Snacks.UseVisualStyleBackColor = true;
            this.btnFill_Snacks.Click += new System.EventHandler(this.btnFill_Snacks_Click);
            // 
            // btnAdd_Snacks
            // 
            this.btnAdd_Snacks.Location = new System.Drawing.Point(375, 52);
            this.btnAdd_Snacks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd_Snacks.Name = "btnAdd_Snacks";
            this.btnAdd_Snacks.Size = new System.Drawing.Size(100, 28);
            this.btnAdd_Snacks.TabIndex = 10;
            this.btnAdd_Snacks.Text = "ADD";
            this.btnAdd_Snacks.UseVisualStyleBackColor = true;
            this.btnAdd_Snacks.Click += new System.EventHandler(this.btnAdd_Snacks_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(151, 249);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 22);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(79, 256);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price (R):";
            // 
            // txtUnit_Cost
            // 
            this.txtUnit_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit_Cost.Location = new System.Drawing.Point(151, 198);
            this.txtUnit_Cost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnit_Cost.Name = "txtUnit_Cost";
            this.txtUnit_Cost.Size = new System.Drawing.Size(132, 22);
            this.txtUnit_Cost.TabIndex = 7;
            this.txtUnit_Cost.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnit_Cost_Validating);
            // 
            // lblUnit_Cost
            // 
            this.lblUnit_Cost.AutoSize = true;
            this.lblUnit_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit_Cost.Location = new System.Drawing.Point(73, 206);
            this.lblUnit_Cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit_Cost.Name = "lblUnit_Cost";
            this.lblUnit_Cost.Size = new System.Drawing.Size(69, 17);
            this.lblUnit_Cost.TabIndex = 6;
            this.lblUnit_Cost.Text = "Unit Cost:";
            // 
            // spinQuantity
            // 
            this.spinQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinQuantity.Location = new System.Drawing.Point(151, 150);
            this.spinQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinQuantity.Name = "spinQuantity";
            this.spinQuantity.Size = new System.Drawing.Size(133, 22);
            this.spinQuantity.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(79, 156);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 17);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(151, 102);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(132, 22);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(60, 110);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(151, 52);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(132, 22);
            this.txtItem.TabIndex = 1;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(107, 55);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 17);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item:";
            // 
            // groupTransact_Detail
            // 
            this.groupTransact_Detail.Controls.Add(this.dbTransaction_Details);
            this.groupTransact_Detail.Controls.Add(this.groupTransact_Details);
            this.groupTransact_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTransact_Detail.Location = new System.Drawing.Point(668, 18);
            this.groupTransact_Detail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTransact_Detail.Name = "groupTransact_Detail";
            this.groupTransact_Detail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTransact_Detail.Size = new System.Drawing.Size(689, 869);
            this.groupTransact_Detail.TabIndex = 1;
            this.groupTransact_Detail.TabStop = false;
            this.groupTransact_Detail.Text = "TRANSACTION DETAILS";
            // 
            // dbTransaction_Details
            // 
            this.dbTransaction_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTransaction_Details.Location = new System.Drawing.Point(36, 46);
            this.dbTransaction_Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbTransaction_Details.Name = "dbTransaction_Details";
            this.dbTransaction_Details.RowTemplate.Height = 24;
            this.dbTransaction_Details.Size = new System.Drawing.Size(587, 249);
            this.dbTransaction_Details.TabIndex = 2;
            // 
            // groupTransact_Details
            // 
            this.groupTransact_Details.Controls.Add(this.spinSnack_ID);
            this.groupTransact_Details.Controls.Add(this.btnDelete_Transaction);
            this.groupTransact_Details.Controls.Add(this.lblFill_Transact);
            this.groupTransact_Details.Controls.Add(this.spinFill_SnackSaleID);
            this.groupTransact_Details.Controls.Add(this.lblFill_SnackSaleID);
            this.groupTransact_Details.Controls.Add(this.lblDelete_Transact);
            this.groupTransact_Details.Controls.Add(this.spinDelete_TransactID);
            this.groupTransact_Details.Controls.Add(this.lblDelete_TransactID);
            this.groupTransact_Details.Controls.Add(this.btnUpdate_Transact);
            this.groupTransact_Details.Controls.Add(this.btnFill_Transact);
            this.groupTransact_Details.Controls.Add(this.btnAdd_Transact);
            this.groupTransact_Details.Controls.Add(this.txtTotal);
            this.groupTransact_Details.Controls.Add(this.lblTotal);
            this.groupTransact_Details.Controls.Add(this.spinQuantity_Ordered);
            this.groupTransact_Details.Controls.Add(this.lblQuantity_Ordered);
            this.groupTransact_Details.Controls.Add(this.lblSnack_ID);
            this.groupTransact_Details.Location = new System.Drawing.Point(36, 315);
            this.groupTransact_Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTransact_Details.Name = "groupTransact_Details";
            this.groupTransact_Details.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTransact_Details.Size = new System.Drawing.Size(587, 513);
            this.groupTransact_Details.TabIndex = 3;
            this.groupTransact_Details.TabStop = false;
            this.groupTransact_Details.Text = "MAINTAIN TRANSACTION DETAILS";
            // 
            // spinSnack_ID
            // 
            this.spinSnack_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinSnack_ID.Location = new System.Drawing.Point(209, 55);
            this.spinSnack_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinSnack_ID.Name = "spinSnack_ID";
            this.spinSnack_ID.Size = new System.Drawing.Size(133, 22);
            this.spinSnack_ID.TabIndex = 20;
            // 
            // btnDelete_Transaction
            // 
            this.btnDelete_Transaction.Location = new System.Drawing.Point(371, 434);
            this.btnDelete_Transaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete_Transaction.Name = "btnDelete_Transaction";
            this.btnDelete_Transaction.Size = new System.Drawing.Size(136, 28);
            this.btnDelete_Transaction.TabIndex = 19;
            this.btnDelete_Transaction.Text = "DELETE";
            this.btnDelete_Transaction.UseVisualStyleBackColor = true;
            this.btnDelete_Transaction.Click += new System.EventHandler(this.btnDelete_Transaction_Click);
            // 
            // lblFill_Transact
            // 
            this.lblFill_Transact.AutoSize = true;
            this.lblFill_Transact.Location = new System.Drawing.Point(93, 220);
            this.lblFill_Transact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFill_Transact.Name = "lblFill_Transact";
            this.lblFill_Transact.Size = new System.Drawing.Size(270, 17);
            this.lblFill_Transact.TabIndex = 18;
            this.lblFill_Transact.Text = "FILL INPUT CONTROLS WITH DATA";
            // 
            // spinFill_SnackSaleID
            // 
            this.spinFill_SnackSaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinFill_SnackSaleID.Location = new System.Drawing.Point(201, 261);
            this.spinFill_SnackSaleID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinFill_SnackSaleID.Name = "spinFill_SnackSaleID";
            this.spinFill_SnackSaleID.Size = new System.Drawing.Size(133, 22);
            this.spinFill_SnackSaleID.TabIndex = 17;
            // 
            // lblFill_SnackSaleID
            // 
            this.lblFill_SnackSaleID.AutoSize = true;
            this.lblFill_SnackSaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFill_SnackSaleID.Location = new System.Drawing.Point(88, 268);
            this.lblFill_SnackSaleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFill_SnackSaleID.Name = "lblFill_SnackSaleID";
            this.lblFill_SnackSaleID.Size = new System.Drawing.Size(108, 17);
            this.lblFill_SnackSaleID.TabIndex = 16;
            this.lblFill_SnackSaleID.Text = "Snack_Sale_ID:";
            // 
            // lblDelete_Transact
            // 
            this.lblDelete_Transact.AutoSize = true;
            this.lblDelete_Transact.Location = new System.Drawing.Point(93, 395);
            this.lblDelete_Transact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelete_Transact.Name = "lblDelete_Transact";
            this.lblDelete_Transact.Size = new System.Drawing.Size(197, 17);
            this.lblDelete_Transact.TabIndex = 15;
            this.lblDelete_Transact.Text = "DELETE A TRANSACTION";
            // 
            // spinDelete_TransactID
            // 
            this.spinDelete_TransactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinDelete_TransactID.Location = new System.Drawing.Point(201, 436);
            this.spinDelete_TransactID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinDelete_TransactID.Name = "spinDelete_TransactID";
            this.spinDelete_TransactID.Size = new System.Drawing.Size(133, 22);
            this.spinDelete_TransactID.TabIndex = 14;
            // 
            // lblDelete_TransactID
            // 
            this.lblDelete_TransactID.AutoSize = true;
            this.lblDelete_TransactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete_TransactID.Location = new System.Drawing.Point(88, 443);
            this.lblDelete_TransactID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelete_TransactID.Name = "lblDelete_TransactID";
            this.lblDelete_TransactID.Size = new System.Drawing.Size(108, 17);
            this.lblDelete_TransactID.TabIndex = 13;
            this.lblDelete_TransactID.Text = "Snack_Sale_ID:";
            // 
            // btnUpdate_Transact
            // 
            this.btnUpdate_Transact.Location = new System.Drawing.Point(53, 314);
            this.btnUpdate_Transact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate_Transact.Name = "btnUpdate_Transact";
            this.btnUpdate_Transact.Size = new System.Drawing.Size(417, 28);
            this.btnUpdate_Transact.TabIndex = 12;
            this.btnUpdate_Transact.Text = "UPDATE TRANSACTION";
            this.btnUpdate_Transact.UseVisualStyleBackColor = true;
            this.btnUpdate_Transact.Click += new System.EventHandler(this.btnUpdate_Transact_Click);
            // 
            // btnFill_Transact
            // 
            this.btnFill_Transact.Location = new System.Drawing.Point(371, 260);
            this.btnFill_Transact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFill_Transact.Name = "btnFill_Transact";
            this.btnFill_Transact.Size = new System.Drawing.Size(100, 28);
            this.btnFill_Transact.TabIndex = 11;
            this.btnFill_Transact.Text = "FILL";
            this.btnFill_Transact.UseVisualStyleBackColor = true;
            this.btnFill_Transact.Click += new System.EventHandler(this.btnFill_Transact_Click);
            // 
            // btnAdd_Transact
            // 
            this.btnAdd_Transact.Location = new System.Drawing.Point(437, 50);
            this.btnAdd_Transact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd_Transact.Name = "btnAdd_Transact";
            this.btnAdd_Transact.Size = new System.Drawing.Size(100, 28);
            this.btnAdd_Transact.TabIndex = 10;
            this.btnAdd_Transact.Text = "ADD";
            this.btnAdd_Transact.UseVisualStyleBackColor = true;
            this.btnAdd_Transact.Click += new System.EventHandler(this.btnAdd_Transact_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(209, 156);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotal_Validating);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(163, 164);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // spinQuantity_Ordered
            // 
            this.spinQuantity_Ordered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinQuantity_Ordered.Location = new System.Drawing.Point(209, 107);
            this.spinQuantity_Ordered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinQuantity_Ordered.Name = "spinQuantity_Ordered";
            this.spinQuantity_Ordered.Size = new System.Drawing.Size(133, 22);
            this.spinQuantity_Ordered.TabIndex = 5;
            // 
            // lblQuantity_Ordered
            // 
            this.lblQuantity_Ordered.AutoSize = true;
            this.lblQuantity_Ordered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity_Ordered.Location = new System.Drawing.Point(88, 114);
            this.lblQuantity_Ordered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity_Ordered.Name = "lblQuantity_Ordered";
            this.lblQuantity_Ordered.Size = new System.Drawing.Size(122, 17);
            this.lblQuantity_Ordered.TabIndex = 4;
            this.lblQuantity_Ordered.Text = "Quantity Ordered:";
            // 
            // lblSnack_ID
            // 
            this.lblSnack_ID.AutoSize = true;
            this.lblSnack_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnack_ID.Location = new System.Drawing.Point(131, 60);
            this.lblSnack_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnack_ID.Name = "lblSnack_ID";
            this.lblSnack_ID.Size = new System.Drawing.Size(72, 17);
            this.lblSnack_ID.TabIndex = 2;
            this.lblSnack_ID.Text = "Snack_ID:";
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.dbGridTransact_Dates);
            this.groupDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDate.Location = new System.Drawing.Point(1388, 28);
            this.groupDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDate.Name = "groupDate";
            this.groupDate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDate.Size = new System.Drawing.Size(564, 382);
            this.groupDate.TabIndex = 1;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "TRANSACTION DATE";
            // 
            // dbGridTransact_Dates
            // 
            this.dbGridTransact_Dates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridTransact_Dates.Location = new System.Drawing.Point(40, 36);
            this.dbGridTransact_Dates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbGridTransact_Dates.Name = "dbGridTransact_Dates";
            this.dbGridTransact_Dates.RowTemplate.Height = 24;
            this.dbGridTransact_Dates.Size = new System.Drawing.Size(479, 249);
            this.dbGridTransact_Dates.TabIndex = 3;
            // 
            // groupDeleteTransacts
            // 
            this.groupDeleteTransacts.Controls.Add(this.btnDelete_All);
            this.groupDeleteTransacts.Controls.Add(this.lblDeleteAllTransactions);
            this.groupDeleteTransacts.Controls.Add(this.spinDeleteAll);
            this.groupDeleteTransacts.Controls.Add(this.lblDeleteAll);
            this.groupDeleteTransacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDeleteTransacts.Location = new System.Drawing.Point(1388, 464);
            this.groupDeleteTransacts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDeleteTransacts.Name = "groupDeleteTransacts";
            this.groupDeleteTransacts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDeleteTransacts.Size = new System.Drawing.Size(529, 222);
            this.groupDeleteTransacts.TabIndex = 21;
            this.groupDeleteTransacts.TabStop = false;
            this.groupDeleteTransacts.Text = "DELETE ALL TRANSACTIONS";
            // 
            // btnDelete_All
            // 
            this.btnDelete_All.Location = new System.Drawing.Point(45, 154);
            this.btnDelete_All.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete_All.Name = "btnDelete_All";
            this.btnDelete_All.Size = new System.Drawing.Size(136, 28);
            this.btnDelete_All.TabIndex = 23;
            this.btnDelete_All.Text = "DELETE";
            this.btnDelete_All.UseVisualStyleBackColor = true;
            this.btnDelete_All.Click += new System.EventHandler(this.btnDelete_All_Click);
            // 
            // lblDeleteAllTransactions
            // 
            this.lblDeleteAllTransactions.AutoSize = true;
            this.lblDeleteAllTransactions.Location = new System.Drawing.Point(41, 68);
            this.lblDeleteAllTransactions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteAllTransactions.Name = "lblDeleteAllTransactions";
            this.lblDeleteAllTransactions.Size = new System.Drawing.Size(354, 17);
            this.lblDeleteAllTransactions.TabIndex = 22;
            this.lblDeleteAllTransactions.Text = "DELETE ALL TRANSACTIONS WITH SNACK_ID:";
            // 
            // spinDeleteAll
            // 
            this.spinDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinDeleteAll.Location = new System.Drawing.Point(156, 98);
            this.spinDeleteAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinDeleteAll.Name = "spinDeleteAll";
            this.spinDeleteAll.Size = new System.Drawing.Size(133, 22);
            this.spinDeleteAll.TabIndex = 21;
            // 
            // lblDeleteAll
            // 
            this.lblDeleteAll.AutoSize = true;
            this.lblDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAll.Location = new System.Drawing.Point(71, 106);
            this.lblDeleteAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteAll.Name = "lblDeleteAll";
            this.lblDeleteAll.Size = new System.Drawing.Size(72, 17);
            this.lblDeleteAll.TabIndex = 20;
            this.lblDeleteAll.Text = "Snack_ID:";
            // 
            // Main_Snacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 959);
            this.Controls.Add(this.groupDeleteTransacts);
            this.Controls.Add(this.groupDate);
            this.Controls.Add(this.groupTransact_Detail);
            this.Controls.Add(this.groupSnacks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Snacks";
            this.Text = "Main_Snacks";
            this.Load += new System.EventHandler(this.Main_Snacks_Load);
            this.groupSnacks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridSnacks)).EndInit();
            this.groupMaintain_Snacks.ResumeLayout(false);
            this.groupMaintain_Snacks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinFill_SnackID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity)).EndInit();
            this.groupTransact_Detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbTransaction_Details)).EndInit();
            this.groupTransact_Details.ResumeLayout(false);
            this.groupTransact_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSnack_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinFill_SnackSaleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDelete_TransactID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity_Ordered)).EndInit();
            this.groupDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridTransact_Dates)).EndInit();
            this.groupDeleteTransacts.ResumeLayout(false);
            this.groupDeleteTransacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeleteAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSnacks;
        private System.Windows.Forms.GroupBox groupTransact_Detail;
        private System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.GroupBox groupMaintain_Snacks;
        private System.Windows.Forms.DataGridView dbGridSnacks;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtUnit_Cost;
        private System.Windows.Forms.Label lblUnit_Cost;
        private System.Windows.Forms.NumericUpDown spinQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnAdd_Snacks;
        private System.Windows.Forms.Button btnUpdate_Snacks;
        private System.Windows.Forms.Button btnFill_Snacks;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.NumericUpDown spinID;
        private System.Windows.Forms.Label lblDeleteSnack;
        private System.Windows.Forms.Button btnDelete_Snack;
        private System.Windows.Forms.Label lblFill_Snack;
        private System.Windows.Forms.NumericUpDown spinFill_SnackID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupTransact_Details;
        private System.Windows.Forms.Button btnDelete_Transaction;
        private System.Windows.Forms.Label lblFill_Transact;
        private System.Windows.Forms.NumericUpDown spinFill_SnackSaleID;
        private System.Windows.Forms.Label lblFill_SnackSaleID;
        private System.Windows.Forms.Label lblDelete_Transact;
        private System.Windows.Forms.NumericUpDown spinDelete_TransactID;
        private System.Windows.Forms.Label lblDelete_TransactID;
        private System.Windows.Forms.Button btnUpdate_Transact;
        private System.Windows.Forms.Button btnFill_Transact;
        private System.Windows.Forms.Button btnAdd_Transact;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown spinQuantity_Ordered;
        private System.Windows.Forms.Label lblQuantity_Ordered;
        private System.Windows.Forms.Label lblSnack_ID;
        private System.Windows.Forms.DataGridView dbTransaction_Details;
        private System.Windows.Forms.NumericUpDown spinSnack_ID;
        private System.Windows.Forms.DataGridView dbGridTransact_Dates;
        private System.Windows.Forms.GroupBox groupDeleteTransacts;
        private System.Windows.Forms.Button btnDelete_All;
        private System.Windows.Forms.Label lblDeleteAllTransactions;
        private System.Windows.Forms.NumericUpDown spinDeleteAll;
        private System.Windows.Forms.Label lblDeleteAll;
    }
}