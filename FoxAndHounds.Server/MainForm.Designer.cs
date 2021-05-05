
namespace FoxAndHounds.Server
{
    partial class MainForm
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
            this.labelIp = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.textLogs = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelServerOn = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStatusColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIp.Location = new System.Drawing.Point(12, 31);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(229, 25);
            this.labelIp.TabIndex = 0;
            this.labelIp.Text = "IP: XXX.XXX.XXX.XXX";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(362, 28);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(85, 31);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "13000";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(299, 31);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(57, 25);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Port:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(533, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textLogs
            // 
            this.textLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogs.Location = new System.Drawing.Point(12, 80);
            this.textLogs.Name = "textLogs";
            this.textLogs.ReadOnly = true;
            this.textLogs.Size = new System.Drawing.Size(680, 352);
            this.textLogs.TabIndex = 4;
            this.textLogs.Text = "---------------------------------------------------------- Server logs ----------" +
    "------------------------------------------------";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelServerOn,
            this.labelStatusColor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelServerOn
            // 
            this.labelServerOn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerOn.Name = "labelServerOn";
            this.labelServerOn.Size = new System.Drawing.Size(130, 21);
            this.labelServerOn.Text = "Server is stopped";
            // 
            // labelStatusColor
            // 
            this.labelStatusColor.AutoSize = false;
            this.labelStatusColor.BackColor = System.Drawing.Color.Red;
            this.labelStatusColor.Name = "labelStatusColor";
            this.labelStatusColor.Size = new System.Drawing.Size(20, 21);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textLogs);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox textLogs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelServerOn;
        private System.Windows.Forms.ToolStripStatusLabel labelStatusColor;
    }
}

