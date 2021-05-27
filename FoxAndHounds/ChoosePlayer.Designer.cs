
namespace FoxAndHounds
{
    partial class ChoosePlayer
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
            this.foxBtn = new System.Windows.Forms.Button();
            this.houndsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foxBtn
            // 
            this.foxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxBtn.Location = new System.Drawing.Point(32, 53);
            this.foxBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foxBtn.Name = "foxBtn";
            this.foxBtn.Size = new System.Drawing.Size(129, 59);
            this.foxBtn.TabIndex = 0;
            this.foxBtn.Text = "Fox";
            this.foxBtn.UseVisualStyleBackColor = true;
            this.foxBtn.Click += new System.EventHandler(this.foxBtn_Click);
            // 
            // houndsBtn
            // 
            this.houndsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houndsBtn.Location = new System.Drawing.Point(215, 53);
            this.houndsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.houndsBtn.Name = "houndsBtn";
            this.houndsBtn.Size = new System.Drawing.Size(129, 59);
            this.houndsBtn.TabIndex = 1;
            this.houndsBtn.Text = "Hounds";
            this.houndsBtn.UseVisualStyleBackColor = true;
            this.houndsBtn.Click += new System.EventHandler(this.houndsBtn_Click);
            // 
            // ChoosePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 176);
            this.Controls.Add(this.houndsBtn);
            this.Controls.Add(this.foxBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChoosePlayer";
            this.Text = "ChoosePlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button foxBtn;
        private System.Windows.Forms.Button houndsBtn;
    }
}