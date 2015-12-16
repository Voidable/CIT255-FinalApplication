namespace FinalApplication
{
    partial class MainMenuForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.txbRating = new System.Windows.Forms.TextBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.chbPS = new System.Windows.Forms.CheckBox();
            this.chbXB = new System.Windows.Forms.CheckBox();
            this.chbPC = new System.Windows.Forms.CheckBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.txbSold = new System.Windows.Forms.TextBox();
            this.txbRelease = new System.Windows.Forms.TextBox();
            this.txbPub = new System.Windows.Forms.TextBox();
            this.txbDev = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblSold = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lbxMain = new System.Windows.Forms.ListBox();
            this.lblList = new System.Windows.Forms.Label();
            this.btnToggleEdit = new System.Windows.Forms.Button();
            this.btnSubmitEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmitRecord = new System.Windows.Forms.Button();
            this.grbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(558, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.txbRating);
            this.grbDetails.Controls.Add(this.lblPlatform);
            this.grbDetails.Controls.Add(this.chbPS);
            this.grbDetails.Controls.Add(this.chbXB);
            this.grbDetails.Controls.Add(this.chbPC);
            this.grbDetails.Controls.Add(this.cmbRating);
            this.grbDetails.Controls.Add(this.txbSold);
            this.grbDetails.Controls.Add(this.txbRelease);
            this.grbDetails.Controls.Add(this.txbPub);
            this.grbDetails.Controls.Add(this.txbDev);
            this.grbDetails.Controls.Add(this.txbName);
            this.grbDetails.Controls.Add(this.lblSold);
            this.grbDetails.Controls.Add(this.lblRelease);
            this.grbDetails.Controls.Add(this.lblRating);
            this.grbDetails.Controls.Add(this.lblPub);
            this.grbDetails.Controls.Add(this.lblDev);
            this.grbDetails.Controls.Add(this.lblName);
            this.grbDetails.Controls.Add(this.label1);
            this.grbDetails.Controls.Add(this.txbID);
            this.grbDetails.Location = new System.Drawing.Point(12, 12);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(537, 135);
            this.grbDetails.TabIndex = 6;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Record Details";
            // 
            // txbRating
            // 
            this.txbRating.Location = new System.Drawing.Point(85, 101);
            this.txbRating.Name = "txbRating";
            this.txbRating.ReadOnly = true;
            this.txbRating.Size = new System.Drawing.Size(71, 20);
            this.txbRating.TabIndex = 21;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(421, 48);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(68, 13);
            this.lblPlatform.TabIndex = 20;
            this.lblPlatform.Text = "Available on:";
            // 
            // chbPS
            // 
            this.chbPS.AutoSize = true;
            this.chbPS.Location = new System.Drawing.Point(444, 110);
            this.chbPS.Name = "chbPS";
            this.chbPS.Size = new System.Drawing.Size(79, 17);
            this.chbPS.TabIndex = 19;
            this.chbPS.Text = "PlayStation";
            this.chbPS.UseVisualStyleBackColor = true;
            // 
            // chbXB
            // 
            this.chbXB.AutoSize = true;
            this.chbXB.Location = new System.Drawing.Point(444, 87);
            this.chbXB.Name = "chbXB";
            this.chbXB.Size = new System.Drawing.Size(55, 17);
            this.chbXB.TabIndex = 18;
            this.chbXB.Text = "XBOX";
            this.chbXB.UseVisualStyleBackColor = true;
            // 
            // chbPC
            // 
            this.chbPC.AutoSize = true;
            this.chbPC.Location = new System.Drawing.Point(444, 64);
            this.chbPC.Name = "chbPC";
            this.chbPC.Size = new System.Drawing.Size(40, 17);
            this.chbPC.TabIndex = 17;
            this.chbPC.Text = "PC";
            this.chbPC.UseVisualStyleBackColor = true;
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(85, 101);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(71, 21);
            this.cmbRating.TabIndex = 13;
            this.cmbRating.Visible = false;
            // 
            // txbSold
            // 
            this.txbSold.Location = new System.Drawing.Point(315, 75);
            this.txbSold.Name = "txbSold";
            this.txbSold.ReadOnly = true;
            this.txbSold.Size = new System.Drawing.Size(60, 20);
            this.txbSold.TabIndex = 12;
            // 
            // txbRelease
            // 
            this.txbRelease.Location = new System.Drawing.Point(315, 45);
            this.txbRelease.Name = "txbRelease";
            this.txbRelease.ReadOnly = true;
            this.txbRelease.Size = new System.Drawing.Size(100, 20);
            this.txbRelease.TabIndex = 11;
            // 
            // txbPub
            // 
            this.txbPub.Location = new System.Drawing.Point(69, 75);
            this.txbPub.Name = "txbPub";
            this.txbPub.ReadOnly = true;
            this.txbPub.Size = new System.Drawing.Size(152, 20);
            this.txbPub.TabIndex = 10;
            // 
            // txbDev
            // 
            this.txbDev.Location = new System.Drawing.Point(71, 48);
            this.txbDev.Name = "txbDev";
            this.txbDev.ReadOnly = true;
            this.txbDev.Size = new System.Drawing.Size(150, 20);
            this.txbDev.TabIndex = 9;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(123, 16);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(400, 20);
            this.txbName.TabIndex = 8;
            this.txbName.Text = "No game selected";
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Location = new System.Drawing.Point(234, 78);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(58, 13);
            this.lblSold.TabIndex = 7;
            this.lblSold.Text = "Units Sold:";
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Location = new System.Drawing.Point(234, 48);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(75, 13);
            this.lblRelease.TabIndex = 6;
            this.lblRelease.Text = "Release Date:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(6, 104);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(73, 13);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "ESRB Rating:";
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Location = new System.Drawing.Point(6, 78);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(53, 13);
            this.lblPub.TabIndex = 4;
            this.lblPub.Text = "Publisher:";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(6, 48);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(59, 13);
            this.lblDev.TabIndex = 3;
            this.lblDev.Text = "Developer:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(79, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(33, 16);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(30, 20);
            this.txbID.TabIndex = 0;
            // 
            // lbxMain
            // 
            this.lbxMain.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMain.FormattingEnabled = true;
            this.lbxMain.ItemHeight = 11;
            this.lbxMain.Location = new System.Drawing.Point(12, 171);
            this.lbxMain.Name = "lbxMain";
            this.lbxMain.Size = new System.Drawing.Size(537, 268);
            this.lbxMain.TabIndex = 7;
            this.lbxMain.SelectedIndexChanged += new System.EventHandler(this.lbxMain_SelectedIndexChanged);
            this.lbxMain.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbxMain_Format);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(12, 155);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(71, 13);
            this.lblList.TabIndex = 8;
            this.lblList.Text = "List of Games";
            // 
            // btnToggleEdit
            // 
            this.btnToggleEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleEdit.Location = new System.Drawing.Point(558, 12);
            this.btnToggleEdit.Name = "btnToggleEdit";
            this.btnToggleEdit.Size = new System.Drawing.Size(100, 50);
            this.btnToggleEdit.TabIndex = 9;
            this.btnToggleEdit.Text = "Enable Editing";
            this.btnToggleEdit.UseVisualStyleBackColor = true;
            this.btnToggleEdit.Click += new System.EventHandler(this.btnToggleEdit_Click);
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitEdit.Enabled = false;
            this.btnSubmitEdit.Location = new System.Drawing.Point(558, 66);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmitEdit.TabIndex = 10;
            this.btnSubmitEdit.Text = "Submit Edits";
            this.btnSubmitEdit.UseVisualStyleBackColor = true;
            this.btnSubmitEdit.Click += new System.EventHandler(this.btnSubmitEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(558, 118);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 50);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(558, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmitRecord
            // 
            this.btnSubmitRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitRecord.Enabled = false;
            this.btnSubmitRecord.Location = new System.Drawing.Point(558, 171);
            this.btnSubmitRecord.Name = "btnSubmitRecord";
            this.btnSubmitRecord.Size = new System.Drawing.Size(100, 50);
            this.btnSubmitRecord.TabIndex = 13;
            this.btnSubmitRecord.Text = "Submit Record";
            this.btnSubmitRecord.UseVisualStyleBackColor = true;
            this.btnSubmitRecord.Click += new System.EventHandler(this.btnSubmitRecord_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 454);
            this.Controls.Add(this.btnSubmitRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSubmitEdit);
            this.Controls.Add(this.btnToggleEdit);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lbxMain);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.btnExit);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MainMenuForm";
            this.Text = "Game Record Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSold;
        private System.Windows.Forms.TextBox txbRelease;
        private System.Windows.Forms.TextBox txbPub;
        private System.Windows.Forms.TextBox txbDev;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ListBox lbxMain;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.CheckBox chbPS;
        private System.Windows.Forms.CheckBox chbXB;
        private System.Windows.Forms.CheckBox chbPC;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnToggleEdit;
        private System.Windows.Forms.TextBox txbRating;
        private System.Windows.Forms.Button btnSubmitEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmitRecord;
    }
}