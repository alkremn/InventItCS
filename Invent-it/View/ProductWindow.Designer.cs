namespace InventMS
{
    partial class ProductWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductWindow));
            this.cancelProdButton = new System.Windows.Forms.Button();
            this.saveProdButton = new System.Windows.Forms.Button();
            this.minText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.invText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.invLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.partsGroupBox = new Model.RoundPanel();
            this.productPartList = new System.Windows.Forms.DataGridView();
            this.partIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availablePartsList = new System.Windows.Forms.DataGridView();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availablePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.avPartsLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.nameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.invToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.priceToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.maxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.minToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.partsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPartList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePartsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelProdButton
            // 
            this.cancelProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelProdButton.Location = new System.Drawing.Point(939, 608);
            this.cancelProdButton.Name = "cancelProdButton";
            this.cancelProdButton.Size = new System.Drawing.Size(82, 35);
            this.cancelProdButton.TabIndex = 0;
            this.cancelProdButton.Text = "Cancel";
            this.cancelProdButton.UseVisualStyleBackColor = true;
            this.cancelProdButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveProdButton
            // 
            this.saveProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveProdButton.Location = new System.Drawing.Point(832, 608);
            this.saveProdButton.Name = "saveProdButton";
            this.saveProdButton.Size = new System.Drawing.Size(82, 35);
            this.saveProdButton.TabIndex = 32;
            this.saveProdButton.Text = "Save";
            this.saveProdButton.UseVisualStyleBackColor = true;
            this.saveProdButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // minText
            // 
            this.minText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minText.Location = new System.Drawing.Point(324, 423);
            this.minText.Margin = new System.Windows.Forms.Padding(4);
            this.minText.MinimumSize = new System.Drawing.Size(4, 20);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(70, 29);
            this.minText.TabIndex = 5;
            this.minToolTip.SetToolTip(this.minText, "Min number is  required");
            this.minText.TextChanged += new System.EventHandler(this.MinText_Changed);
            this.minText.Enter += new System.EventHandler(this.MinText_Enter);
            this.minText.Leave += new System.EventHandler(this.MinText_Leave);
            // 
            // maxText
            // 
            this.maxText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxText.Location = new System.Drawing.Point(152, 423);
            this.maxText.Margin = new System.Windows.Forms.Padding(4);
            this.maxText.MinimumSize = new System.Drawing.Size(4, 20);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(70, 29);
            this.maxText.TabIndex = 4;
            this.maxToolTip.SetToolTip(this.maxText, "Max number is  required");
            this.maxText.TextChanged += new System.EventHandler(this.MaxText_Changed);
            this.maxText.Enter += new System.EventHandler(this.MaxText_Enter);
            this.maxText.Leave += new System.EventHandler(this.MaxText_Leave);
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(152, 353);
            this.priceText.Margin = new System.Windows.Forms.Padding(4);
            this.priceText.MinimumSize = new System.Drawing.Size(4, 20);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(242, 29);
            this.priceText.TabIndex = 3;
            this.priceToolTip.SetToolTip(this.priceText, "Price number is  required");
            this.priceText.TextChanged += new System.EventHandler(this.PriceText_Changed);
            this.priceText.Enter += new System.EventHandler(this.PriceText_Enter);
            this.priceText.Leave += new System.EventHandler(this.PriceText_Leave);
            // 
            // invText
            // 
            this.invText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invText.Location = new System.Drawing.Point(152, 283);
            this.invText.Margin = new System.Windows.Forms.Padding(4);
            this.invText.MinimumSize = new System.Drawing.Size(4, 20);
            this.invText.Name = "invText";
            this.invText.Size = new System.Drawing.Size(242, 29);
            this.invText.TabIndex = 2;
            this.invToolTip.SetToolTip(this.invText, "Inv number is  required");
            this.invText.TextChanged += new System.EventHandler(this.InvText_Changed);
            this.invText.Enter += new System.EventHandler(this.InvText_Enter);
            this.invText.Leave += new System.EventHandler(this.InvText_Leave);
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(152, 213);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(242, 29);
            this.nameText.TabIndex = 1;
            this.nameToolTip.SetToolTip(this.nameText, "Name is  required");
            this.nameText.Enter += new System.EventHandler(this.NameText_Enter);
            this.nameText.Leave += new System.EventHandler(this.NameText_Leave);
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.White;
            this.idText.Enabled = false;
            this.idText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idText.Location = new System.Drawing.Point(152, 153);
            this.idText.Margin = new System.Windows.Forms.Padding(4);
            this.idText.MaximumSize = new System.Drawing.Size(242, 40);
            this.idText.MinimumSize = new System.Drawing.Size(100, 25);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(242, 29);
            this.idText.TabIndex = 31;
            this.idText.Tag = "";
            this.idText.Text = "Auto Gen - Disabled";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.priceLabel.Location = new System.Drawing.Point(62, 357);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 20);
            this.priceLabel.TabIndex = 24;
            this.priceLabel.Text = "Price";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.DimGray;
            this.minLabel.Location = new System.Drawing.Point(250, 427);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(37, 20);
            this.minLabel.TabIndex = 22;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.DimGray;
            this.maxLabel.Location = new System.Drawing.Point(62, 427);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(41, 20);
            this.maxLabel.TabIndex = 21;
            this.maxLabel.Text = "Max";
            // 
            // invLabel
            // 
            this.invLabel.AutoSize = true;
            this.invLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invLabel.ForeColor = System.Drawing.Color.DimGray;
            this.invLabel.Location = new System.Drawing.Point(62, 297);
            this.invLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invLabel.Name = "invLabel";
            this.invLabel.Size = new System.Drawing.Size(33, 20);
            this.invLabel.TabIndex = 18;
            this.invLabel.Text = "Inv";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.DimGray;
            this.idLabel.Location = new System.Drawing.Point(62, 156);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 20);
            this.idLabel.TabIndex = 17;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.nameLabel.Location = new System.Drawing.Point(62, 217);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.productLabel.Location = new System.Drawing.Point(61, 53);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(187, 29);
            this.productLabel.TabIndex = 15;
            this.productLabel.Text = "Modify Product";
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.partsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.partsGroupBox.Controls.Add(this.productPartList);
            this.partsGroupBox.Controls.Add(this.availablePartsList);
            this.partsGroupBox.Controls.Add(this.label2);
            this.partsGroupBox.Controls.Add(this.avPartsLabel);
            this.partsGroupBox.Controls.Add(this.searchBox);
            this.partsGroupBox.Controls.Add(this.searchPartButton);
            this.partsGroupBox.Controls.Add(this.deletePartButton);
            this.partsGroupBox.Controls.Add(this.addPartButton);
            this.partsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.partsGroupBox.Location = new System.Drawing.Point(446, 65);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Radious = 15;
            this.partsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.partsGroupBox.Size = new System.Drawing.Size(575, 512);
            this.partsGroupBox.TabIndex = 35;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Parts";
            this.partsGroupBox.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.partsGroupBox.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.partsGroupBox.TitleForeColor = System.Drawing.Color.White;
            this.partsGroupBox.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // productPartList
            // 
            this.productPartList.AllowUserToAddRows = false;
            this.productPartList.AllowUserToDeleteRows = false;
            this.productPartList.AllowUserToResizeColumns = false;
            this.productPartList.AllowUserToResizeRows = false;
            this.productPartList.AutoGenerateColumns = false;
            this.productPartList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productPartList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productPartList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productPartList.ColumnHeadersHeight = 30;
            this.productPartList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn1,
            this.partNameDataGridViewTextBoxColumn1,
            this.inStockDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.productPartList.DataSource = this.productPartsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productPartList.DefaultCellStyle = dataGridViewCellStyle2;
            this.productPartList.Location = new System.Drawing.Point(15, 288);
            this.productPartList.Name = "productPartList";
            this.productPartList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productPartList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productPartList.RowHeadersVisible = false;
            this.productPartList.RowTemplate.Height = 30;
            this.productPartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productPartList.Size = new System.Drawing.Size(545, 170);
            this.productPartList.TabIndex = 6;
            this.productPartList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            // 
            // partIdDataGridViewTextBoxColumn1
            // 
            this.partIdDataGridViewTextBoxColumn1.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.partIdDataGridViewTextBoxColumn1.Name = "partIdDataGridViewTextBoxColumn1";
            this.partIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.partIdDataGridViewTextBoxColumn1.Width = 122;
            // 
            // partNameDataGridViewTextBoxColumn1
            // 
            this.partNameDataGridViewTextBoxColumn1.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn1.HeaderText = "Part Name";
            this.partNameDataGridViewTextBoxColumn1.Name = "partNameDataGridViewTextBoxColumn1";
            this.partNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.partNameDataGridViewTextBoxColumn1.Width = 145;
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "Inventory";
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            this.inStockDataGridViewTextBoxColumn1.ReadOnly = true;
            this.inStockDataGridViewTextBoxColumn1.Width = 140;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 135;
            // 
            // productPartsBindingSource
            // 
            this.productPartsBindingSource.DataSource = typeof(Model.Part);
            // 
            // availablePartsList
            // 
            this.availablePartsList.AllowUserToAddRows = false;
            this.availablePartsList.AllowUserToDeleteRows = false;
            this.availablePartsList.AllowUserToResizeColumns = false;
            this.availablePartsList.AllowUserToResizeRows = false;
            this.availablePartsList.AutoGenerateColumns = false;
            this.availablePartsList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.availablePartsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availablePartsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.availablePartsList.ColumnHeadersHeight = 30;
            this.availablePartsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.availablePartsList.DataSource = this.availablePartBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availablePartsList.DefaultCellStyle = dataGridViewCellStyle6;
            this.availablePartsList.Location = new System.Drawing.Point(15, 76);
            this.availablePartsList.Name = "availablePartsList";
            this.availablePartsList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availablePartsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.availablePartsList.RowHeadersVisible = false;
            this.availablePartsList.RowTemplate.Height = 30;
            this.availablePartsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availablePartsList.Size = new System.Drawing.Size(545, 170);
            this.availablePartsList.TabIndex = 10;
            this.availablePartsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "Part ID";
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            this.partIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partIdDataGridViewTextBoxColumn.Width = 122;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "Part Name";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.partNameDataGridViewTextBoxColumn.Width = 145;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.inStockDataGridViewTextBoxColumn.Width = 140;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 135;
            // 
            // availablePartBindingSource
            // 
            this.availablePartBindingSource.DataSource = typeof(Model.Part);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parts Associated with this Product:";
            // 
            // avPartsLabel
            // 
            this.avPartsLabel.AutoSize = true;
            this.avPartsLabel.Location = new System.Drawing.Point(11, 43);
            this.avPartsLabel.Name = "avPartsLabel";
            this.avPartsLabel.Size = new System.Drawing.Size(69, 21);
            this.avPartsLabel.TabIndex = 5;
            this.avPartsLabel.Text = "All Parts:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(299, 38);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(169, 29);
            this.searchBox.TabIndex = 4;
            // 
            // searchPartButton
            // 
            this.searchPartButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchPartButton.Location = new System.Drawing.Point(478, 40);
            this.searchPartButton.Name = "searchPartButton";
            this.searchPartButton.Size = new System.Drawing.Size(75, 28);
            this.searchPartButton.TabIndex = 3;
            this.searchPartButton.Text = "Search";
            this.searchPartButton.UseVisualStyleBackColor = true;
            this.searchPartButton.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deletePartButton.Location = new System.Drawing.Point(466, 464);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(80, 32);
            this.deletePartButton.TabIndex = 2;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addPartButton.Location = new System.Drawing.Point(466, 252);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(80, 32);
            this.addPartButton.TabIndex = 2;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // nameToolTip
            // 
            this.nameToolTip.AutomaticDelay = 100;
            this.nameToolTip.AutoPopDelay = 5000;
            this.nameToolTip.InitialDelay = 100;
            this.nameToolTip.ReshowDelay = 20;
            // 
            // invToolTip
            // 
            this.invToolTip.AutomaticDelay = 100;
            this.invToolTip.AutoPopDelay = 5000;
            this.invToolTip.InitialDelay = 100;
            this.invToolTip.ReshowDelay = 20;
            // 
            // priceToolTip
            // 
            this.priceToolTip.AutomaticDelay = 100;
            this.priceToolTip.AutoPopDelay = 5000;
            this.priceToolTip.InitialDelay = 100;
            this.priceToolTip.ReshowDelay = 20;
            // 
            // maxToolTip
            // 
            this.maxToolTip.AutomaticDelay = 100;
            this.maxToolTip.AutoPopDelay = 5000;
            this.maxToolTip.InitialDelay = 100;
            this.maxToolTip.ReshowDelay = 20;
            // 
            // minToolTip
            // 
            this.minToolTip.AutomaticDelay = 100;
            this.minToolTip.AutoPopDelay = 5000;
            this.minToolTip.InitialDelay = 100;
            this.minToolTip.ReshowDelay = 20;
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 688);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.cancelProdButton);
            this.Controls.Add(this.saveProdButton);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.invText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.invLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1097, 727);
            this.MinimumSize = new System.Drawing.Size(1097, 727);
            this.Name = "ProductWindow";
            this.Text = "ProductWindow";
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPartList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePartsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveProdButton;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox invText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label invLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label productLabel;
        private Model.RoundPanel partsGroupBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button cancelProdButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label avPartsLabel;
        private System.Windows.Forms.BindingSource availablePartBindingSource;
        private System.Windows.Forms.DataGridView availablePartsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView productPartList;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productPartsBindingSource;
        private System.Windows.Forms.ToolTip nameToolTip;
        private System.Windows.Forms.ToolTip invToolTip;
        private System.Windows.Forms.ToolTip priceToolTip;
        private System.Windows.Forms.ToolTip maxToolTip;
        private System.Windows.Forms.ToolTip minToolTip;
    }
}