namespace Welding_engeneer_system
{
    partial class FilePathStorage
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
            this.tFilePath = new System.Windows.Forms.TextBox();
            this.bFilePath = new System.Windows.Forms.Button();
            this.lWeldersRotation = new System.Windows.Forms.Label();
            this.cbTableName = new System.Windows.Forms.ComboBox();
            this.lvTables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bToMemory = new System.Windows.Forms.Button();
            this.bSaveTablePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tFilePath
            // 
            this.tFilePath.Location = new System.Drawing.Point(175, 25);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.Size = new System.Drawing.Size(476, 20);
            this.tFilePath.TabIndex = 0;
            // 
            // bFilePath
            // 
            this.bFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(148)))), ((int)(((byte)(69)))));
            this.bFilePath.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bFilePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bFilePath.Location = new System.Drawing.Point(657, 25);
            this.bFilePath.Name = "bFilePath";
            this.bFilePath.Size = new System.Drawing.Size(56, 21);
            this.bFilePath.TabIndex = 1;
            this.bFilePath.Text = "***";
            this.bFilePath.UseVisualStyleBackColor = false;
            this.bFilePath.Click += new System.EventHandler(this.bFilePath_Click);
            // 
            // lWeldersRotation
            // 
            this.lWeldersRotation.AutoSize = true;
            this.lWeldersRotation.Location = new System.Drawing.Point(15, 8);
            this.lWeldersRotation.Name = "lWeldersRotation";
            this.lWeldersRotation.Size = new System.Drawing.Size(89, 13);
            this.lWeldersRotation.TabIndex = 2;
            this.lWeldersRotation.Text = "Welders Rotation";
            // 
            // cbTableName
            // 
            this.cbTableName.FormattingEnabled = true;
            this.cbTableName.Items.AddRange(new object[] {
            "Welders Rotation",
            "FM-401-06",
            "Welding Book Workshop",
            "Welding Book Erection",
            "Welding Book Flare",
            "Unofficial rejects"});
            this.cbTableName.Location = new System.Drawing.Point(18, 25);
            this.cbTableName.Name = "cbTableName";
            this.cbTableName.Size = new System.Drawing.Size(151, 21);
            this.cbTableName.TabIndex = 3;
            // 
            // lvTables
            // 
            this.lvTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTables.HideSelection = false;
            this.lvTables.Location = new System.Drawing.Point(12, 92);
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(701, 359);
            this.lvTables.TabIndex = 4;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            this.lvTables.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Table name";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 543;
            // 
            // bToMemory
            // 
            this.bToMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(114)))));
            this.bToMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bToMemory.Location = new System.Drawing.Point(306, 51);
            this.bToMemory.Name = "bToMemory";
            this.bToMemory.Size = new System.Drawing.Size(57, 35);
            this.bToMemory.TabIndex = 5;
            this.bToMemory.Text = "V";
            this.bToMemory.UseVisualStyleBackColor = false;
            this.bToMemory.Click += new System.EventHandler(this.bToMemory_Click);
            // 
            // bSaveTablePath
            // 
            this.bSaveTablePath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSaveTablePath.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bSaveTablePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveTablePath.Location = new System.Drawing.Point(389, 51);
            this.bSaveTablePath.Name = "bSaveTablePath";
            this.bSaveTablePath.Size = new System.Drawing.Size(261, 34);
            this.bSaveTablePath.TabIndex = 6;
            this.bSaveTablePath.Text = "Сохранить изменения";
            this.bSaveTablePath.UseVisualStyleBackColor = false;
            this.bSaveTablePath.Click += new System.EventHandler(this.bSaveTablePath_Click);
            // 
            // FilePathStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 463);
            this.Controls.Add(this.bSaveTablePath);
            this.Controls.Add(this.bToMemory);
            this.Controls.Add(this.lvTables);
            this.Controls.Add(this.cbTableName);
            this.Controls.Add(this.lWeldersRotation);
            this.Controls.Add(this.bFilePath);
            this.Controls.Add(this.tFilePath);
            this.MaximizeBox = false;
            this.Name = "FilePathStorage";
            this.Text = "FilePathStorage";
            this.Load += new System.EventHandler(this.FilePathStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tFilePath;
        private System.Windows.Forms.Button bFilePath;
        private System.Windows.Forms.Label lWeldersRotation;
        private System.Windows.Forms.ComboBox cbTableName;
        private System.Windows.Forms.ListView lvTables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button bToMemory;
        private System.Windows.Forms.Button bSaveTablePath;
    }
}