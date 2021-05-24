
namespace FoxAndHounds
{
    partial class ConnectScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectScreen));
            this.textIp = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textIp
            // 
            this.textIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIp.Location = new System.Drawing.Point(285, 102);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(220, 44);
            this.textIp.TabIndex = 0;
            this.textIp.Text = "127.0.0.1";
            // 
            // textPort
            // 
            this.textPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPort.Location = new System.Drawing.Point(285, 206);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(220, 44);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "13000";
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIp.Location = new System.Drawing.Point(48, 111);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(182, 37);
            this.labelIp.TabIndex = 2;
            this.labelIp.Text = "IP Address:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(158, 209);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(85, 37);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(206, 325);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(176, 75);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ConnectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 454);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button btnConnect;
    }
}