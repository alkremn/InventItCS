using Model;

namespace Invent_it
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new Model.RoundPanel();
            this.deleteProdButton = new System.Windows.Forms.Button();
            this.prodDataView = new System.Windows.Forms.DataGridView();
            this.ModifyProdButton = new System.Windows.Forms.Button();
            this.addProdButton = new System.Windows.Forms.Button();
            this.groupBox1 = new Model.RoundPanel();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partsDataView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory MS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.deleteProdButton);
            this.groupBox2.Controls.Add(this.prodDataView);
            this.groupBox2.Controls.Add(this.ModifyProdButton);
            this.groupBox2.Controls.Add(this.addProdButton);
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
            // 
            // prodDataView
            // 
            this.prodDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataView.Location = new System.Drawing.Point(6, 38);
            this.prodDataView.Name = "prodDataView";
            this.prodDataView.Size = new System.Drawing.Size(563, 249);
            this.prodDataView.TabIndex = 0;
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
            this.ModifyProdButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // addProdButton
            // 
            this.addProdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addProdButton.Location = new System.Drawing.Point(297, 307);
            this.addProdButton.Name = "addProdButton";
            this.addProdButton.Size = new System.Drawing.Size(75, 32);
            this.addProdButton.TabIndex = 2;
            this.addProdButton.Text = "Add";
            this.addProdButton.UseVisualStyleBackColor = true;        
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.deletePartButton);
            this.groupBox1.Controls.Add(this.modifyPartButton);
            this.groupBox1.Controls.Add(this.addPartButton);
            this.groupBox1.Controls.Add(this.partsDataView);
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
            this.modifyPartButton.Click += new System.EventHandler(this.modifyButton_Click);
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
            this.addPartButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // partsDataView
            // 
            this.partsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataView.Location = new System.Drawing.Point(6, 38);
            this.partsDataView.Name = "partsDataView";
            this.partsDataView.Size = new System.Drawing.Size(563, 249);
            this.partsDataView.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximumSize = new System.Drawing.Size(1211, 677);
            this.MinimumSize = new System.Drawing.Size(1211, 677);
            this.Name = "MainWindow";
            this.Text = "Inventory Management System";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundPanel groupBox1;
        private RoundPanel groupBox2;
        private System.Windows.Forms.DataGridView prodDataView;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.DataGridView partsDataView;
        private System.Windows.Forms.Button deleteProdButton;
        private System.Windows.Forms.Button ModifyProdButton;
        private System.Windows.Forms.Button addProdButton;
    }
}

