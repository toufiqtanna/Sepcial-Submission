﻿namespace Special_Submission
{
    partial class Aeroplane
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tBPlaneName = new System.Windows.Forms.TextBox();
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.tBPanleID = new System.Windows.Forms.TextBox();
            this.lblPlaneID = new System.Windows.Forms.Label();
            this.LblFlightNumber = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tBFlightNumber = new System.Windows.Forms.TextBox();
            this.tBSource = new System.Windows.Forms.TextBox();
            this.tBDestination = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tBPlaneName
            // 
            this.tBPlaneName.Enabled = false;
            this.tBPlaneName.Location = new System.Drawing.Point(117, 63);
            this.tBPlaneName.Name = "tBPlaneName";
            this.tBPlaneName.Size = new System.Drawing.Size(191, 20);
            this.tBPlaneName.TabIndex = 11;
            // 
            // lblPlaneName
            // 
            this.lblPlaneName.AutoSize = true;
            this.lblPlaneName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneName.Location = new System.Drawing.Point(12, 63);
            this.lblPlaneName.Name = "lblPlaneName";
            this.lblPlaneName.Size = new System.Drawing.Size(81, 17);
            this.lblPlaneName.TabIndex = 10;
            this.lblPlaneName.Text = "Plane Name:";
            // 
            // tBPanleID
            // 
            this.tBPanleID.Location = new System.Drawing.Point(117, 34);
            this.tBPanleID.Name = "tBPanleID";
            this.tBPanleID.Size = new System.Drawing.Size(191, 20);
            this.tBPanleID.TabIndex = 9;
            // 
            // lblPlaneID
            // 
            this.lblPlaneID.AutoSize = true;
            this.lblPlaneID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneID.Location = new System.Drawing.Point(35, 34);
            this.lblPlaneID.Name = "lblPlaneID";
            this.lblPlaneID.Size = new System.Drawing.Size(58, 17);
            this.lblPlaneID.TabIndex = 8;
            this.lblPlaneID.Text = "Plane ID:";
            // 
            // LblFlightNumber
            // 
            this.LblFlightNumber.AutoSize = true;
            this.LblFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlightNumber.Location = new System.Drawing.Point(-1, 100);
            this.LblFlightNumber.Name = "LblFlightNumber";
            this.LblFlightNumber.Size = new System.Drawing.Size(94, 16);
            this.LblFlightNumber.TabIndex = 14;
            this.LblFlightNumber.Text = "Flight Number:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(36, 133);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(51, 17);
            this.lblSource.TabIndex = 15;
            this.lblSource.Text = "Source:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(17, 171);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(76, 17);
            this.lblDestination.TabIndex = 16;
            this.lblDestination.Text = "Destination:";
            // 
            // tBFlightNumber
            // 
            this.tBFlightNumber.Enabled = false;
            this.tBFlightNumber.Location = new System.Drawing.Point(117, 100);
            this.tBFlightNumber.Name = "tBFlightNumber";
            this.tBFlightNumber.Size = new System.Drawing.Size(191, 20);
            this.tBFlightNumber.TabIndex = 17;
            // 
            // tBSource
            // 
            this.tBSource.Enabled = false;
            this.tBSource.Location = new System.Drawing.Point(117, 133);
            this.tBSource.Name = "tBSource";
            this.tBSource.Size = new System.Drawing.Size(191, 20);
            this.tBSource.TabIndex = 18;
            // 
            // tBDestination
            // 
            this.tBDestination.Enabled = false;
            this.tBDestination.Location = new System.Drawing.Point(117, 171);
            this.tBDestination.Name = "tBDestination";
            this.tBDestination.Size = new System.Drawing.Size(191, 20);
            this.tBDestination.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(129, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 41);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(233, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 41);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 368);
            this.dataGridView1.TabIndex = 22;
            // 
            // Aeroplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tBDestination);
            this.Controls.Add(this.tBSource);
            this.Controls.Add(this.tBFlightNumber);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.LblFlightNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tBPlaneName);
            this.Controls.Add(this.lblPlaneName);
            this.Controls.Add(this.tBPanleID);
            this.Controls.Add(this.lblPlaneID);
            this.Name = "Aeroplane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeroplane CRUD Operation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tBPlaneName;
        private System.Windows.Forms.Label lblPlaneName;
        private System.Windows.Forms.TextBox tBPanleID;
        private System.Windows.Forms.Label lblPlaneID;
        private System.Windows.Forms.Label LblFlightNumber;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox tBFlightNumber;
        private System.Windows.Forms.TextBox tBSource;
        private System.Windows.Forms.TextBox tBDestination;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
