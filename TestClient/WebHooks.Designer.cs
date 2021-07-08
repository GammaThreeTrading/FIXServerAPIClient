
using IO.Swagger.Model;

namespace FormTestClient
{
    partial class WebHooks
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
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.txtBoxEventName = new System.Windows.Forms.TextBox();
            this.btnUpdateWH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(61, 81);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(426, 31);
            this.txtBoxUrl.TabIndex = 0;
            // 
            // txtBoxEventName
            // 
            this.txtBoxEventName.Location = new System.Drawing.Point(532, 81);
            this.txtBoxEventName.Name = "txtBoxEventName";
            this.txtBoxEventName.ReadOnly = true;
            this.txtBoxEventName.Size = new System.Drawing.Size(150, 31);
            this.txtBoxEventName.TabIndex = 1;
            this.txtBoxEventName.Text = WebHoookEvent.OrderStateChanged.ToString();
            // 
            // btnUpdateWH
            // 
            this.btnUpdateWH.Location = new System.Drawing.Point(61, 320);
            this.btnUpdateWH.Name = "btnUpdateWH";
            this.btnUpdateWH.Size = new System.Drawing.Size(112, 34);
            this.btnUpdateWH.TabIndex = 2;
            this.btnUpdateWH.Text = "Update";
            this.btnUpdateWH.UseVisualStyleBackColor = true;
            this.btnUpdateWH.Click += new System.EventHandler(this.btnUpdateWH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Webhook Callback Address (this app)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Webhook Type";
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Location = new System.Drawing.Point(61, 119);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(133, 34);
            this.btnSetDefault.TabIndex = 5;
            this.btnSetDefault.Text = "(Set Default)";
            this.btnSetDefault.UseVisualStyleBackColor = true;
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // WebHooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetDefault);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateWH);
            this.Controls.Add(this.txtBoxEventName);
            this.Controls.Add(this.txtBoxUrl);
            this.Name = "WebHooks";
            this.Text = "WebHooks";
            this.Load += new System.EventHandler(this.WebHooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.TextBox txtBoxEventName;
        private System.Windows.Forms.Button btnUpdateWH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetDefault;
    }
}