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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new Model.RoundPanel();
            this.DeleteProdButton = new System.Windows.Forms.Button();
            this.ProdDataView = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModifyProdButton = new System.Windows.Forms.Button();
            this.AddProdButton = new System.Windows.Forms.Button();
            this.groupBox1 = new Model.RoundPanel();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.PartsDataView = new System.Windows.Forms.DataGridView();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory MS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.DeleteProdButton);
            this.groupBox2.Controls.Add(this.ProdDataView);
            this.groupBox2.Controls.Add(this.ModifyProdButton);
            this.groupBox2.Controls.Add(this.AddProdButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(608, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Radious = 15;
            this.groupBox2.Size = new System.Drawing.Size(575, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            this.groupBox2.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.TitleForeColor = System.Drawing.Color.White;
            this.groupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.DarkVertical;
            // 
            // DeleteProdButton
            // 
            this.DeleteProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteProdButton.Location = new System.Drawing.Point(471, 307);
            this.DeleteProdButton.Name = "DeleteProdButton";
            this.DeleteProdButton.Size = new System.Drawing.Size(80, 32);
            this.DeleteProdButton.TabIndex = 2;
            this.DeleteProdButton.Text = "Delete";
            this.DeleteProdButton.UseVisualStyleBackColor = true;
            // 
            // ProdDataView
            // 
            this.ProdDataView.AllowUserToAddRows = false;
            this.ProdDataView.AllowUserToDeleteRows = false;
            this.ProdDataView.AllowUserToResizeColumns = false;
            this.ProdDataView.AllowUserToResizeRows = false;
            this.ProdDataView.AutoGenerateColumns = false;
            this.ProdDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.ProdDataView.DataSource = this.productBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProdDataView.Location = new System.Drawing.Point(6, 38);
            this.ProdDataView.MultiSelect = false;
            this.ProdDataView.Name = "ProdDataView";
            this.ProdDataView.RowHeadersVisible = false;
            this.ProdDataView.Size = new System.Drawing.Size(564, 249);
            this.ProdDataView.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 140;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 141;
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "Inventory Level";
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            this.inStockDataGridViewTextBoxColumn1.Width = 140;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price/Cost per Unit";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 140;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Model.Product);
            // 
            // ModifyProdButton
            // 
            this.ModifyProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModifyProdButton.Location = new System.Drawing.Point(378, 307);
            this.ModifyProdButton.Name = "ModifyProdButton";
            this.ModifyProdButton.Size = new System.Drawing.Size(87, 32);
            this.ModifyProdButton.TabIndex = 2;
            this.ModifyProdButton.Text = "Modify";
            this.ModifyProdButton.UseVisualStyleBackColor = true;
            this.ModifyProdButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // AddProdButton
            // 
            this.AddProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddProdButton.Location = new System.Drawing.Point(296, 307);
            this.AddProdButton.Name = "AddProdButton";
            this.AddProdButton.Size = new System.Drawing.Size(75, 32);
            this.AddProdButton.TabIndex = 2;
            this.AddProdButton.Text = "Add";
            this.AddProdButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DeletePartButton);
            this.groupBox1.Controls.Add(this.ModifyPartButton);
            this.groupBox1.Controls.Add(this.AddPartButton);
            this.groupBox1.Controls.Add(this.PartsDataView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(10, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Radious = 15;
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(575, 363);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts";
            this.groupBox1.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.TitleForeColor = System.Drawing.Color.White;
            this.groupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.DarkVertical;
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeletePartButton.Location = new System.Drawing.Point(474, 307);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(80, 32);
            this.DeletePartButton.TabIndex = 2;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModifyPartButton.Location = new System.Drawing.Point(381, 307);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(87, 32);
            this.ModifyPartButton.TabIndex = 2;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddPartButton.Location = new System.Drawing.Point(300, 307);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 32);
            this.AddPartButton.TabIndex = 2;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PartsDataView
            // 
            this.PartsDataView.AllowUserToAddRows = false;
            this.PartsDataView.AllowUserToDeleteRows = false;
            this.PartsDataView.AllowUserToResizeColumns = false;
            this.PartsDataView.AllowUserToResizeRows = false;
            this.PartsDataView.AutoGenerateColumns = false;
            this.PartsDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PartsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PartsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.PartsDataView.DataSource = this.partBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PartsDataView.DefaultCellStyle = dataGridViewCellStyle4;
            this.PartsDataView.Location = new System.Drawing.Point(6, 38);
            this.PartsDataView.Name = "PartsDataView";
            this.PartsDataView.RowHeadersVisible = false;
            this.PartsDataView.Size = new System.Drawing.Size(564, 249);
            this.PartsDataView.TabIndex = 0;
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "Part ID";
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            this.partIdDataGridViewTextBoxColumn.Width = 140;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "Part Name";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.partNameDataGridViewTextBoxColumn.Width = 141;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "Inventory Level";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.Width = 140;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price/Cost per Unit";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 140;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Model.Part);
            this.partBindingSource.CurrentChanged += new System.EventHandler(this.partBindingSource_CurrentChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 57F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximumSize = new System.Drawing.Size(1211, 678);
            this.MinimumSize = new System.Drawing.Size(1211, 678);
            this.Name = "MainWindow";
            this.Text = "Inventory Management System";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RoundPanel groupBox1;
        private RoundPanel groupBox2;
        private System.Windows.Forms.DataGridView ProdDataView;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.DataGridView PartsDataView;
        private System.Windows.Forms.Button DeleteProdButton;
        private System.Windows.Forms.Button ModifyProdButton;
        private System.Windows.Forms.Button AddProdButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}

