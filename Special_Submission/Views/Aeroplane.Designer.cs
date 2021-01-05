namespace Special_Submission
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
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.tBPlaneID = new System.Windows.Forms.TextBox();
            this.lblPlaneID = new System.Windows.Forms.Label();
            this.LblFlightNumber = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tBPlaneName = new System.Windows.Forms.TextBox();
            this.tBFlightNumber = new System.Windows.Forms.TextBox();
            this.tBSource = new System.Windows.Forms.TextBox();
            this.tBDestination = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBSearch2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(129, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // tBPlaneID
            // 
            this.tBPlaneID.Location = new System.Drawing.Point(117, 34);
            this.tBPlaneID.Name = "tBPlaneID";
            this.tBPlaneID.Size = new System.Drawing.Size(191, 20);
            this.tBPlaneID.TabIndex = 9;
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1007, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 41);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1128, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 41);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tBPlaneName
            // 
            this.tBPlaneName.Location = new System.Drawing.Point(117, 63);
            this.tBPlaneName.Name = "tBPlaneName";
            this.tBPlaneName.Size = new System.Drawing.Size(191, 20);
            this.tBPlaneName.TabIndex = 23;
            // 
            // tBFlightNumber
            // 
            this.tBFlightNumber.Location = new System.Drawing.Point(117, 93);
            this.tBFlightNumber.Name = "tBFlightNumber";
            this.tBFlightNumber.Size = new System.Drawing.Size(191, 20);
            this.tBFlightNumber.TabIndex = 24;
            // 
            // tBSource
            // 
            this.tBSource.Location = new System.Drawing.Point(117, 130);
            this.tBSource.Name = "tBSource";
            this.tBSource.Size = new System.Drawing.Size(191, 20);
            this.tBSource.TabIndex = 25;
            // 
            // tBDestination
            // 
            this.tBDestination.Location = new System.Drawing.Point(117, 168);
            this.tBDestination.Name = "tBDestination";
            this.tBDestination.Size = new System.Drawing.Size(191, 20);
            this.tBDestination.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 390);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(480, 22);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(339, 20);
            this.tBSearch.TabIndex = 29;
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(398, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 17);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(825, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(185, 38);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tBSearch2
            // 
            this.tBSearch2.Location = new System.Drawing.Point(1062, 119);
            this.tBSearch2.Name = "tBSearch2";
            this.tBSearch2.Size = new System.Drawing.Size(165, 20);
            this.tBSearch2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(964, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Plane Name:";
            // 
            // Aeroplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBSearch2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tBDestination);
            this.Controls.Add(this.tBSource);
            this.Controls.Add(this.tBFlightNumber);
            this.Controls.Add(this.tBPlaneName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.LblFlightNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPlaneName);
            this.Controls.Add(this.tBPlaneID);
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
        private System.Windows.Forms.Label lblPlaneName;
        private System.Windows.Forms.TextBox tBPlaneID;
        private System.Windows.Forms.Label lblPlaneID;
        private System.Windows.Forms.Label LblFlightNumber;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tBPlaneName;
        private System.Windows.Forms.TextBox tBFlightNumber;
        private System.Windows.Forms.TextBox tBSource;
        private System.Windows.Forms.TextBox tBDestination;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tBSearch2;
        private System.Windows.Forms.Label label1;
    }
}

