namespace InventMS
{
    partial class productWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productWindow));
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.prodPartsList = new System.Windows.Forms.DataGridView();
            this.availablePartsList = new System.Windows.Forms.DataGridView();
            this.avPartsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodPartsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePartsList)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelProdButton
            // 
            this.cancelProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelProdButton.Location = new System.Drawing.Point(965, 613);
            this.cancelProdButton.Name = "cancelProdButton";
            this.cancelProdButton.Size = new System.Drawing.Size(82, 35);
            this.cancelProdButton.TabIndex = 33;
            this.cancelProdButton.Text = "Cancel";
            this.cancelProdButton.UseVisualStyleBackColor = true;
            this.cancelProdButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveProdButton
            // 
            this.saveProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveProdButton.Location = new System.Drawing.Point(858, 613);
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
            this.minText.Location = new System.Drawing.Point(356, 423);
            this.minText.Margin = new System.Windows.Forms.Padding(4);
            this.minText.MinimumSize = new System.Drawing.Size(4, 20);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(66, 29);
            this.minText.TabIndex = 29;
            // 
            // maxText
            // 
            this.maxText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxText.Location = new System.Drawing.Point(180, 423);
            this.maxText.Margin = new System.Windows.Forms.Padding(4);
            this.maxText.MinimumSize = new System.Drawing.Size(4, 20);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(77, 29);
            this.maxText.TabIndex = 28;
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(180, 353);
            this.priceText.Margin = new System.Windows.Forms.Padding(4);
            this.priceText.MinimumSize = new System.Drawing.Size(4, 20);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(242, 29);
            this.priceText.TabIndex = 27;
            // 
            // invText
            // 
            this.invText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invText.Location = new System.Drawing.Point(180, 283);
            this.invText.Margin = new System.Windows.Forms.Padding(4);
            this.invText.MinimumSize = new System.Drawing.Size(4, 20);
            this.invText.Name = "invText";
            this.invText.Size = new System.Drawing.Size(242, 29);
            this.invText.TabIndex = 26;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(180, 213);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(242, 29);
            this.nameText.TabIndex = 25;
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.White;
            this.idText.Enabled = false;
            this.idText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idText.Location = new System.Drawing.Point(180, 153);
            this.idText.Margin = new System.Windows.Forms.Padding(4);
            this.idText.MaximumSize = new System.Drawing.Size(242, 40);
            this.idText.MinimumSize = new System.Drawing.Size(100, 25);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(242, 29);
            this.idText.TabIndex = 31;
            this.idText.Tag = "";
            this.idText.Text = "Auto Gen -Disabled";
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
            this.minLabel.Location = new System.Drawing.Point(288, 427);
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
            this.productLabel.Size = new System.Drawing.Size(156, 29);
            this.productLabel.TabIndex = 15;
            this.productLabel.Text = "Add Product";
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.partsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.partsGroupBox.Controls.Add(this.label2);
            this.partsGroupBox.Controls.Add(this.avPartsLabel);
            this.partsGroupBox.Controls.Add(this.searchBox);
            this.partsGroupBox.Controls.Add(this.searchPartButton);
            this.partsGroupBox.Controls.Add(this.deletePartButton);
            this.partsGroupBox.Controls.Add(this.addPartButton);
            this.partsGroupBox.Controls.Add(this.prodPartsList);
            this.partsGroupBox.Controls.Add(this.availablePartsList);
            this.partsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.partsGroupBox.Location = new System.Drawing.Point(472, 53);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Radious = 15;
            this.partsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.partsGroupBox.Size = new System.Drawing.Size(575, 500);
            this.partsGroupBox.TabIndex = 35;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Parts";
            this.partsGroupBox.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.partsGroupBox.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.partsGroupBox.TitleForeColor = System.Drawing.Color.White;
            this.partsGroupBox.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
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
            this.searchPartButton.Click += new System.EventHandler(this.searchPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePartButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deletePartButton.Location = new System.Drawing.Point(466, 458);
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
            // prodPartsList
            // 
            this.prodPartsList.AllowUserToAddRows = false;
            this.prodPartsList.AllowUserToDeleteRows = false;
            this.prodPartsList.AllowUserToResizeColumns = false;
            this.prodPartsList.AllowUserToResizeRows = false;
            this.prodPartsList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodPartsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prodPartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodPartsList.Location = new System.Drawing.Point(15, 290);
            this.prodPartsList.Name = "prodPartsList";
            this.prodPartsList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodPartsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodPartsList.RowHeadersVisible = false;
            this.prodPartsList.Size = new System.Drawing.Size(545, 162);
            this.prodPartsList.TabIndex = 0;
            // 
            // availablePartsList
            // 
            this.availablePartsList.AllowUserToAddRows = false;
            this.availablePartsList.AllowUserToDeleteRows = false;
            this.availablePartsList.AllowUserToResizeColumns = false;
            this.availablePartsList.AllowUserToResizeRows = false;
            this.availablePartsList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availablePartsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.availablePartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availablePartsList.Location = new System.Drawing.Point(15, 74);
            this.availablePartsList.Name = "availablePartsList";
            this.availablePartsList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availablePartsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.availablePartsList.RowHeadersVisible = false;
            this.availablePartsList.Size = new System.Drawing.Size(545, 172);
            this.availablePartsList.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parts Associated with this Product:";
            // 
            // productWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 708);
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
            this.Name = "productWindow";
            this.Text = "ProductWindow";
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodPartsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePartsList)).EndInit();
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
        private System.Windows.Forms.DataGridView prodPartsList;
        private System.Windows.Forms.DataGridView availablePartsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label avPartsLabel;
    }
}