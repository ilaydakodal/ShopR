namespace WindowsFormsApp3
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdmnID = new System.Windows.Forms.TextBox();
            this.txtAdmnPass = new System.Windows.Forms.TextBox();
            this.btnAdmnLog = new System.Windows.Forms.Button();
            this.btnAdmnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN LOGIN";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER ID:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtAdmnID
            // 
            this.txtAdmnID.Location = new System.Drawing.Point(273, 265);
            this.txtAdmnID.Name = "txtAdmnID";
            this.txtAdmnID.Size = new System.Drawing.Size(235, 31);
            this.txtAdmnID.TabIndex = 3;
            // 
            // txtAdmnPass
            // 
            this.txtAdmnPass.Location = new System.Drawing.Point(273, 378);
            this.txtAdmnPass.Name = "txtAdmnPass";
            this.txtAdmnPass.Size = new System.Drawing.Size(235, 31);
            this.txtAdmnPass.TabIndex = 4;
            // 
            // btnAdmnLog
            // 
            this.btnAdmnLog.Location = new System.Drawing.Point(429, 501);
            this.btnAdmnLog.Name = "btnAdmnLog";
            this.btnAdmnLog.Size = new System.Drawing.Size(151, 63);
            this.btnAdmnLog.TabIndex = 5;
            this.btnAdmnLog.Text = "LOGIN";
            this.btnAdmnLog.UseVisualStyleBackColor = true;
            this.btnAdmnLog.Click += new System.EventHandler(this.BtnAdmnLog_Click);
            // 
            // btnAdmnBack
            // 
            this.btnAdmnBack.Location = new System.Drawing.Point(184, 502);
            this.btnAdmnBack.Name = "btnAdmnBack";
            this.btnAdmnBack.Size = new System.Drawing.Size(152, 62);
            this.btnAdmnBack.TabIndex = 6;
            this.btnAdmnBack.Text = "BACK";
            this.btnAdmnBack.UseVisualStyleBackColor = true;
            this.btnAdmnBack.Click += new System.EventHandler(this.BtnAdmnBack_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(750, 648);
            this.Controls.Add(this.btnAdmnBack);
            this.Controls.Add(this.btnAdmnLog);
            this.Controls.Add(this.txtAdmnPass);
            this.Controls.Add(this.txtAdmnID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdmnID;
        private System.Windows.Forms.TextBox txtAdmnPass;
        private System.Windows.Forms.Button btnAdmnLog;
        private System.Windows.Forms.Button btnAdmnBack;
    }
}