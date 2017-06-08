namespace export_sybase
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkColumn = new System.Windows.Forms.CheckBox();
            this.txtTerminator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(154, 35);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(571, 134);
            this.txtSQL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(91, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "指令:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(288, 287);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(182, 58);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "匯出csv";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkColumn
            // 
            this.chkColumn.AutoSize = true;
            this.chkColumn.Checked = true;
            this.chkColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColumn.Location = new System.Drawing.Point(547, 273);
            this.chkColumn.Name = "chkColumn";
            this.chkColumn.Size = new System.Drawing.Size(132, 16);
            this.chkColumn.TabIndex = 3;
            this.chkColumn.Text = "包含第一行欄位名稱";
            this.chkColumn.UseVisualStyleBackColor = true;
            // 
            // txtTerminator
            // 
            this.txtTerminator.Location = new System.Drawing.Point(154, 186);
            this.txtTerminator.MaxLength = 5;
            this.txtTerminator.Name = "txtTerminator";
            this.txtTerminator.Size = new System.Drawing.Size(100, 22);
            this.txtTerminator.TabIndex = 4;
            this.txtTerminator.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(49, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "分隔符號:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(154, 229);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(495, 22);
            this.txtPath.TabIndex = 6;
            this.txtPath.Text = "d:\\export\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(49, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "檔案路徑:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(655, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ex: D:\\export\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTerminator);
            this.Controls.Add(this.chkColumn);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSQL);
            this.Name = "Form1";
            this.Text = "匯出資料";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkColumn;
        private System.Windows.Forms.TextBox txtTerminator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

