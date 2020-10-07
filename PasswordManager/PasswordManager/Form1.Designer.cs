namespace PasswordManager
{
    partial class Form1
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
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnInitTable = new System.Windows.Forms.Button();
            this.btnSelectRes1 = new System.Windows.Forms.Button();
            this.database1DataSet = new PasswordManager.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new PasswordManager.Database1DataSet1();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new PasswordManager.Database1DataSet();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectPass = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtSelectWebsite = new System.Windows.Forms.TextBox();
            this.btnSelectCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            this.gbInsert.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(56, 35);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.ReadOnly = true;
            this.txtConfirm.Size = new System.Drawing.Size(279, 22);
            this.txtConfirm.TabIndex = 0;
            this.txtConfirm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnInitTable
            // 
            this.btnInitTable.Location = new System.Drawing.Point(361, 29);
            this.btnInitTable.Name = "btnInitTable";
            this.btnInitTable.Size = new System.Drawing.Size(117, 35);
            this.btnInitTable.TabIndex = 1;
            this.btnInitTable.Text = "Initialise DB";
            this.btnInitTable.UseVisualStyleBackColor = true;
            this.btnInitTable.Click += new System.EventHandler(this.btnInitTable_Click);
            // 
            // btnSelectRes1
            // 
            this.btnSelectRes1.Location = new System.Drawing.Point(494, 29);
            this.btnSelectRes1.Name = "btnSelectRes1";
            this.btnSelectRes1.Size = new System.Drawing.Size(117, 35);
            this.btnSelectRes1.TabIndex = 2;
            this.btnSelectRes1.Text = "Query";
            this.btnSelectRes1.UseVisualStyleBackColor = true;
            this.btnSelectRes1.Click += new System.EventHandler(this.btnSelectRes1_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(6, 34);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(128, 22);
            this.txtURL.TabIndex = 3;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(151, 34);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(146, 22);
            this.txtPasswd.TabIndex = 4;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(3, 91);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(36, 17);
            this.lblURL.TabIndex = 5;
            this.lblURL.Text = "URL";
            this.lblURL.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(148, 91);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(69, 17);
            this.lblPasswd.TabIndex = 6;
            this.lblPasswd.Text = "Password";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(328, 33);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Submit Values";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.txtURL);
            this.gbInsert.Controls.Add(this.lblURL);
            this.gbInsert.Controls.Add(this.lblPasswd);
            this.gbInsert.Controls.Add(this.btnInsert);
            this.gbInsert.Controls.Add(this.txtPasswd);
            this.gbInsert.Location = new System.Drawing.Point(56, 78);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(422, 177);
            this.gbInsert.TabIndex = 8;
            this.gbInsert.TabStop = false;
            this.gbInsert.Text = "Insert Values";
            this.gbInsert.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.btnSelectCopy);
            this.gbSelect.Controls.Add(this.label1);
            this.gbSelect.Controls.Add(this.txtSelectPass);
            this.gbSelect.Controls.Add(this.btnSelect);
            this.gbSelect.Controls.Add(this.lblSelect);
            this.gbSelect.Controls.Add(this.txtSelectWebsite);
            this.gbSelect.Location = new System.Drawing.Point(507, 89);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(391, 166);
            this.gbSelect.TabIndex = 9;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Get Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtSelectPass
            // 
            this.txtSelectPass.Location = new System.Drawing.Point(193, 48);
            this.txtSelectPass.Name = "txtSelectPass";
            this.txtSelectPass.PasswordChar = '*';
            this.txtSelectPass.Size = new System.Drawing.Size(157, 22);
            this.txtSelectPass.TabIndex = 3;
            this.txtSelectPass.TextChanged += new System.EventHandler(this.textSelectPass_TextChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(32, 103);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Submit";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(43, 28);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(100, 17);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Website Name";
            // 
            // txtSelectWebsite
            // 
            this.txtSelectWebsite.Location = new System.Drawing.Point(32, 48);
            this.txtSelectWebsite.Name = "txtSelectWebsite";
            this.txtSelectWebsite.Size = new System.Drawing.Size(135, 22);
            this.txtSelectWebsite.TabIndex = 0;
            this.txtSelectWebsite.TextChanged += new System.EventHandler(this.txtSelect_TextChanged);
            // 
            // btnSelectCopy
            // 
            this.btnSelectCopy.Location = new System.Drawing.Point(193, 103);
            this.btnSelectCopy.Name = "btnSelectCopy";
            this.btnSelectCopy.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCopy.TabIndex = 5;
            this.btnSelectCopy.Text = "Copy";
            this.btnSelectCopy.UseVisualStyleBackColor = true;
            this.btnSelectCopy.Click += new System.EventHandler(this.btnSelectCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 499);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbInsert);
            this.Controls.Add(this.btnSelectRes1);
            this.Controls.Add(this.btnInitTable);
            this.Controls.Add(this.txtConfirm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            this.gbInsert.ResumeLayout(false);
            this.gbInsert.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnInitTable;
        private System.Windows.Forms.Button btnSelectRes1;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private Database1DataSet1 database1DataSet1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtSelectWebsite;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectPass;
        private System.Windows.Forms.Button btnSelectCopy;
    }
}

