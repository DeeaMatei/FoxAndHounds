
namespace FoxAndHounds
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVsComputer = new System.Windows.Forms.Button();
            this.btnPvpLocal = new System.Windows.Forms.Button();
            this.btnPvpLan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fox && Hounds";
            // 
            // btnVsComputer
            // 
            this.btnVsComputer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsComputer.Location = new System.Drawing.Point(432, 208);
            this.btnVsComputer.Name = "btnVsComputer";
            this.btnVsComputer.Size = new System.Drawing.Size(188, 64);
            this.btnVsComputer.TabIndex = 1;
            this.btnVsComputer.Text = "VS Computer";
            this.btnVsComputer.UseVisualStyleBackColor = true;
            this.btnVsComputer.Click += new System.EventHandler(this.btnVsComputer_Click);
            // 
            // btnPvpLocal
            // 
            this.btnPvpLocal.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvpLocal.Location = new System.Drawing.Point(432, 310);
            this.btnPvpLocal.Name = "btnPvpLocal";
            this.btnPvpLocal.Size = new System.Drawing.Size(188, 64);
            this.btnPvpLocal.TabIndex = 2;
            this.btnPvpLocal.Text = "PvP Local";
            this.btnPvpLocal.UseVisualStyleBackColor = true;
            this.btnPvpLocal.Click += new System.EventHandler(this.btnPvpLocal_Click);
            // 
            // btnPvpLan
            // 
            this.btnPvpLan.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvpLan.Location = new System.Drawing.Point(432, 410);
            this.btnPvpLan.Name = "btnPvpLan";
            this.btnPvpLan.Size = new System.Drawing.Size(188, 64);
            this.btnPvpLan.TabIndex = 3;
            this.btnPvpLan.Text = "PvP LAN";
            this.btnPvpLan.UseVisualStyleBackColor = true;
            this.btnPvpLan.Click += new System.EventHandler(this.btnPvpLan_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(842, 580);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(390, 534);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(280, 42);
            this.btnInstructions.TabIndex = 5;
            this.btnInstructions.Text = "How to play";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPvpLan);
            this.Controls.Add(this.btnPvpLocal);
            this.Controls.Add(this.btnVsComputer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 13, 10, 13);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Fox && Hounds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVsComputer;
        private System.Windows.Forms.Button btnPvpLocal;
        private System.Windows.Forms.Button btnPvpLan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInstructions;
    }
}

