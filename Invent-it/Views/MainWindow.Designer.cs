using System.ComponentModel;
using Model;

namespace InventMS
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.prodGroupBox = new Model.RoundPanel();
            this.searchProdText = new System.Windows.Forms.TextBox();
            this.searchProdButton = new System.Windows.Forms.Button();
            this.deleteProdButton = new System.Windows.Forms.Button();
            this.prodDataView = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modifyProdButton = new System.Windows.Forms.Button();
            this.addProdButton = new System.Windows.Forms.Button();
            this.partGroupBox = new Model.RoundPanel();
            this.searchPartText = new System.Windows.Forms.TextBox();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partsDataView = new System.Windows.Forms.DataGridView();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.partGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.mainLabel.Location = new System.Drawing.Point(28, 38);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(186, 31);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Inventory MS";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitButton.Location = new System.Drawing.Point(1079, 538);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // prodGroupBox
            // 
            this.prodGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.prodGroupBox.Controls.Add(this.searchProdText);
            this.prodGroupBox.Controls.Add(this.searchProdButton);
            this.prodGroupBox.Controls.Add(this.deleteProdButton);
            this.prodGroupBox.Controls.Add(this.prodDataView);
            this.prodGroupBox.Controls.Add(this.modifyProdButton);
            this.prodGroupBox.Controls.Add(this.addProdButton);
            this.prodGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodGroupBox.Location = new System.Drawing.Point(605, 105);
            this.prodGroupBox.Name = "prodGroupBox";
            this.prodGroupBox.Radious = 15;
            this.prodGroupBox.Size = new System.Drawing.Size(580, 363);
            this.prodGroupBox.TabIndex = 1;
            this.prodGroupBox.TabStop = false;
            this.prodGroupBox.Text = "Products";
            this.prodGroupBox.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.prodGroupBox.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.prodGroupBox.TitleForeColor = System.Drawing.Color.White;
            this.prodGroupBox.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // searchProdText
            // 
            this.searchProdText.Location = new System.Drawing.Point(320, 38);
            this.searchProdText.Name = "searchProdText";
            this.searchProdText.Size = new System.Drawing.Size(148, 29);
            this.searchProdText.TabIndex = 4;
            // 
            // searchProdButton
            // 
            this.searchProdButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchProdButton.Location = new System.Drawing.Point(478, 40);
            this.searchProdButton.Name = "searchProdButton";
            this.searchProdButton.Size = new System.Drawing.Size(75, 26);
            this.searchProdButton.TabIndex = 3;
            this.searchProdButton.Text = "Search";
            this.searchProdButton.UseVisualStyleBackColor = true;
            this.searchProdButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // deleteProdButton
            // 
            this.deleteProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteProdButton.Location = new System.Drawing.Point(471, 307);
            this.deleteProdButton.Name = "deleteProdButton";
            this.deleteProdButton.Size = new System.Drawing.Size(80, 32);
            this.deleteProdButton.TabIndex = 2;
            this.deleteProdButton.Text = "Delete";
            this.deleteProdButton.UseVisualStyleBackColor = true;
            this.deleteProdButton.Click += new System.EventHandler(this.DeleteProdButton_Click);
            // 
            // prodDataView
            // 
            this.prodDataView.AllowUserToAddRows = false;
            this.prodDataView.AllowUserToDeleteRows = false;
            this.prodDataView.AllowUserToResizeColumns = false;
            this.prodDataView.AllowUserToResizeRows = false;
            this.prodDataView.AutoGenerateColumns = false;
            this.prodDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prodDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.prodDataView.DataSource = this.productBindingSource;
            this.prodDataView.Location = new System.Drawing.Point(6, 74);
            this.prodDataView.MultiSelect = false;
            this.prodDataView.Name = "prodDataView";
            this.prodDataView.ReadOnly = true;
            this.prodDataView.RowHeadersVisible = false;
            this.prodDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDataView.Size = new System.Drawing.Size(564, 213);
            this.prodDataView.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 147;
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "Inventory Level";
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            this.inStockDataGridViewTextBoxColumn1.ReadOnly = true;
            this.inStockDataGridViewTextBoxColumn1.Width = 144;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price/Cost per Unit";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Model.Product);
            // 
            // modifyProdButton
            // 
            this.modifyProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modifyProdButton.Location = new System.Drawing.Point(378, 307);
            this.modifyProdButton.Name = "modifyProdButton";
            this.modifyProdButton.Size = new System.Drawing.Size(87, 32);
            this.modifyProdButton.TabIndex = 2;
            this.modifyProdButton.Text = "Modify";
            this.modifyProdButton.UseVisualStyleBackColor = true;
            this.modifyProdButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // addProdButton
            // 
            this.addProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addProdButton.Location = new System.Drawing.Point(296, 307);
            this.addProdButton.Name = "addProdButton";
            this.addProdButton.Size = new System.Drawing.Size(75, 32);
            this.addProdButton.TabIndex = 2;
            this.addProdButton.Text = "Add";
            this.addProdButton.UseVisualStyleBackColor = true;
            this.addProdButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // partGroupBox
            // 
            this.partGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.partGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.partGroupBox.Controls.Add(this.searchPartText);
            this.partGroupBox.Controls.Add(this.searchPartButton);
            this.partGroupBox.Controls.Add(this.deletePartButton);
            this.partGroupBox.Controls.Add(this.modifyPartButton);
            this.partGroupBox.Controls.Add(this.addPartButton);
            this.partGroupBox.Controls.Add(this.partsDataView);
            this.partGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.partGroupBox.Location = new System.Drawing.Point(10, 105);
            this.partGroupBox.Name = "partGroupBox";
            this.partGroupBox.Radious = 15;
            this.partGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.partGroupBox.Size = new System.Drawing.Size(580, 363);
            this.partGroupBox.TabIndex = 1;
            this.partGroupBox.TabStop = false;
            this.partGroupBox.Text = "Parts";
            this.partGroupBox.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.partGroupBox.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.partGroupBox.TitleForeColor = System.Drawing.Color.White;
            this.partGroupBox.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // searchPartText
            // 
            this.searchPartText.Location = new System.Drawing.Point(320, 38);
            this.searchPartText.Name = "searchPartText";
            this.searchPartText.Size = new System.Drawing.Size(148, 29);
            this.searchPartText.TabIndex = 4;
            // 
            // searchPartButton
            // 
            this.searchPartButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchPartButton.Location = new System.Drawing.Point(478, 40);
            this.searchPartButton.Name = "searchPartButton";
            this.searchPartButton.Size = new System.Drawing.Size(75, 26);
            this.searchPartButton.TabIndex = 3;
            this.searchPartButton.Text = "Search";
            this.searchPartButton.UseVisualStyleBackColor = true;
            this.searchPartButton.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deletePartButton.Location = new System.Drawing.Point(474, 307);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(80, 32);
            this.deletePartButton.TabIndex = 2;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modifyPartButton.Location = new System.Drawing.Point(381, 307);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(87, 32);
            this.modifyPartButton.TabIndex = 2;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addPartButton.Location = new System.Drawing.Point(300, 307);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 32);
            this.addPartButton.TabIndex = 2;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // partsDataView
            // 
            this.partsDataView.AllowUserToAddRows = false;
            this.partsDataView.AllowUserToDeleteRows = false;
            this.partsDataView.AllowUserToResizeColumns = false;
            this.partsDataView.AllowUserToResizeRows = false;
            this.partsDataView.AutoGenerateColumns = false;
            this.partsDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.partsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.partsDataView.DataSource = this.partBindingSource;
            this.partsDataView.Location = new System.Drawing.Point(6, 74);
            this.partsDataView.Name = "partsDataView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.partsDataView.RowHeadersVisible = false;
            this.partsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataView.Size = new System.Drawing.Size(564, 213);
            this.partsDataView.TabIndex = 0;
            this.partsDataView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingCompleted);
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "Part ID";
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            this.partIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "Part Name";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.partNameDataGridViewTextBoxColumn.Width = 147;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "Inventory Level";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.Width = 144;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price/Cost per Unit";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Model.Part);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 639);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.prodGroupBox);
            this.Controls.Add(this.partGroupBox);
            this.Controls.Add(this.mainLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximumSize = new System.Drawing.Size(1210, 678);
            this.MinimumSize = new System.Drawing.Size(1210, 678);
            this.Name = "MainWindow";
            this.Text = "Inventory Management System";
            this.prodGroupBox.ResumeLayout(false);
            this.prodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.partGroupBox.ResumeLayout(false);
            this.partGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainLabel;
        private RoundPanel partGroupBox;
        private RoundPanel prodGroupBox;
        private System.Windows.Forms.DataGridView prodDataView;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.DataGridView partsDataView;
        private System.Windows.Forms.Button deleteProdButton;
        private System.Windows.Forms.Button modifyProdButton;
        private System.Windows.Forms.Button addProdButton;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchProdButton;
        private System.Windows.Forms.TextBox searchPartText;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.TextBox searchProdText;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

