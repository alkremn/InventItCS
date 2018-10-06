namespace InventMS
{
    partial class PartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartWindow));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addModifyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.invLabel = new System.Windows.Forms.Label();
            this.inHouse = new System.Windows.Forms.RadioButton();
            this.outsourced = new System.Windows.Forms.RadioButton();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.compIdLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.invText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.minText = new System.Windows.Forms.TextBox();
            this.compIdText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.radButtonsBox = new System.Windows.Forms.GroupBox();
            this.radButtonsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // addModifyLabel
            // 
            this.addModifyLabel.AutoSize = true;
            this.addModifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addModifyLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.addModifyLabel.Location = new System.Drawing.Point(24, 55);
            this.addModifyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addModifyLabel.Name = "addModifyLabel";
            this.addModifyLabel.Size = new System.Drawing.Size(144, 29);
            this.addModifyLabel.TabIndex = 5;
            this.addModifyLabel.Text = "Modify Part";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.nameLabel.Location = new System.Drawing.Point(44, 189);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.DimGray;
            this.idLabel.Location = new System.Drawing.Point(44, 128);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 20);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID";
            // 
            // invLabel
            // 
            this.invLabel.AutoSize = true;
            this.invLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invLabel.ForeColor = System.Drawing.Color.DimGray;
            this.invLabel.Location = new System.Drawing.Point(44, 269);
            this.invLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invLabel.Name = "invLabel";
            this.invLabel.Size = new System.Drawing.Size(33, 20);
            this.invLabel.TabIndex = 8;
            this.invLabel.Text = "Inv";
            // 
            // inHouse
            // 
            this.inHouse.AutoSize = true;
            this.inHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inHouse.ForeColor = System.Drawing.Color.DimGray;
            this.inHouse.Location = new System.Drawing.Point(7, 15);
            this.inHouse.Margin = new System.Windows.Forms.Padding(4);
            this.inHouse.Name = "inHouse";
            this.inHouse.Size = new System.Drawing.Size(88, 20);
            this.inHouse.TabIndex = 9;
            this.inHouse.TabStop = true;
            this.inHouse.Text = "In-House";
            this.inHouse.UseVisualStyleBackColor = true;
            this.inHouse.CheckedChanged += new System.EventHandler(this.RadButtonCheckedChanged);
            // 
            // outsourced
            // 
            this.outsourced.AutoSize = true;
            this.outsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourced.ForeColor = System.Drawing.Color.DimGray;
            this.outsourced.Location = new System.Drawing.Point(111, 15);
            this.outsourced.Margin = new System.Windows.Forms.Padding(4);
            this.outsourced.Name = "outsourced";
            this.outsourced.Size = new System.Drawing.Size(105, 20);
            this.outsourced.TabIndex = 10;
            this.outsourced.TabStop = true;
            this.outsourced.Text = "Outsourced";
            this.outsourced.UseVisualStyleBackColor = true;
            this.outsourced.CheckedChanged += new System.EventHandler(this.RadButtonCheckedChanged);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.DimGray;
            this.maxLabel.Location = new System.Drawing.Point(44, 399);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(41, 20);
            this.maxLabel.TabIndex = 11;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.priceLabel.Location = new System.Drawing.Point(44, 329);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 20);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Price";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.DimGray;
            this.minLabel.Location = new System.Drawing.Point(280, 399);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(37, 20);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Min";
            // 
            // compIdLabel
            // 
            this.compIdLabel.AutoSize = true;
            this.compIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compIdLabel.ForeColor = System.Drawing.Color.DimGray;
            this.compIdLabel.Location = new System.Drawing.Point(13, 469);
            this.compIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.compIdLabel.Name = "compIdLabel";
            this.compIdLabel.Size = new System.Drawing.Size(134, 20);
            this.compIdLabel.TabIndex = 11;
            this.compIdLabel.Text = "Company Name";
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.White;
            this.idText.Enabled = false;
            this.idText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.idText.Location = new System.Drawing.Point(162, 125);
            this.idText.Margin = new System.Windows.Forms.Padding(4);
            this.idText.MinimumSize = new System.Drawing.Size(100, 20);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(275, 29);
            this.idText.TabIndex = 13;
            this.idText.Tag = "";
            this.idText.Text = "Auto Gen -Disabled";
            // 
            // nameText
            // 
            this.nameText.AccessibleDescription = "";
            this.nameText.AccessibleName = "";
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameText.Location = new System.Drawing.Point(162, 185);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.MinimumSize = new System.Drawing.Size(4, 20);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(275, 29);
            this.nameText.TabIndex = 13;
            // 
            // invText
            // 
            this.invText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invText.Location = new System.Drawing.Point(162, 255);
            this.invText.Margin = new System.Windows.Forms.Padding(4);
            this.invText.MinimumSize = new System.Drawing.Size(4, 20);
            this.invText.Name = "invText";
            this.invText.Size = new System.Drawing.Size(275, 29);
            this.invText.TabIndex = 13;
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(162, 325);
            this.priceText.Margin = new System.Windows.Forms.Padding(4);
            this.priceText.MinimumSize = new System.Drawing.Size(4, 20);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(275, 29);
            this.priceText.TabIndex = 13;
            // 
            // maxText
            // 
            this.maxText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxText.Location = new System.Drawing.Point(162, 395);
            this.maxText.Margin = new System.Windows.Forms.Padding(4);
            this.maxText.MinimumSize = new System.Drawing.Size(4, 20);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(95, 29);
            this.maxText.TabIndex = 13;
            // 
            // minText
            // 
            this.minText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minText.Location = new System.Drawing.Point(342, 395);
            this.minText.Margin = new System.Windows.Forms.Padding(4);
            this.minText.MinimumSize = new System.Drawing.Size(4, 20);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(95, 29);
            this.minText.TabIndex = 13;
            // 
            // compIdText
            // 
            this.compIdText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compIdText.Location = new System.Drawing.Point(162, 465);
            this.compIdText.Margin = new System.Windows.Forms.Padding(4);
            this.compIdText.MinimumSize = new System.Drawing.Size(4, 20);
            this.compIdText.Name = "compIdText";
            this.compIdText.Size = new System.Drawing.Size(275, 29);
            this.compIdText.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveButton.Location = new System.Drawing.Point(242, 539);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 35);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.Location = new System.Drawing.Point(356, 539);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 35);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // radButtonsBox
            // 
            this.radButtonsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radButtonsBox.Controls.Add(this.inHouse);
            this.radButtonsBox.Controls.Add(this.outsourced);
            this.radButtonsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radButtonsBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.radButtonsBox.Location = new System.Drawing.Point(193, 55);
            this.radButtonsBox.Name = "radButtonsBox";
            this.radButtonsBox.Size = new System.Drawing.Size(228, 42);
            this.radButtonsBox.TabIndex = 15;
            this.radButtonsBox.TabStop = false;
            // 
            // PartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 637);
            this.Controls.Add(this.radButtonsBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.compIdText);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.invText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.compIdLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.invLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addModifyLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(16, 40);
            this.Name = "PartWindow";
            this.Text = "Add Part Window";
            this.radButtonsBox.ResumeLayout(false);
            this.radButtonsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label addModifyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label invLabel;
        private System.Windows.Forms.RadioButton inHouse;
        private System.Windows.Forms.RadioButton outsourced;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label compIdLabel;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox invText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.TextBox compIdText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox radButtonsBox;
    }
}