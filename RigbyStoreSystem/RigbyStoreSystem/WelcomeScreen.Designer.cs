namespace RigbyStoreSystem
{
    partial class WelcomeScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnModifySale = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Rigby Store System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the following options";
            // 
            // btnAddSale
            // 
            this.btnAddSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSale.Location = new System.Drawing.Point(55, 111);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(304, 50);
            this.btnAddSale.TabIndex = 0;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnModifySale
            // 
            this.btnModifySale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModifySale.Location = new System.Drawing.Point(54, 167);
            this.btnModifySale.Name = "btnModifySale";
            this.btnModifySale.Size = new System.Drawing.Size(304, 50);
            this.btnModifySale.TabIndex = 1;
            this.btnModifySale.Text = "Modify Sale";
            this.btnModifySale.UseVisualStyleBackColor = true;
            this.btnModifySale.Click += new System.EventHandler(this.btnModifySale_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReporting.Location = new System.Drawing.Point(54, 223);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(304, 50);
            this.btnReporting.TabIndex = 2;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 320);
            this.Controls.Add(this.btnReporting);
            this.Controls.Add(this.btnModifySale);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Screen";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnModifySale;
        private System.Windows.Forms.Button btnReporting;
    }
}

