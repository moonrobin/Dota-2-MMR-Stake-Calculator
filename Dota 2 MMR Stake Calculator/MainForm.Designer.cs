namespace Dota_2_MMR_Stake_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AllyLabel = new System.Windows.Forms.Label();
            this.EnemyLabel = new System.Windows.Forms.Label();
            this.MMRGainLabel = new System.Windows.Forms.Label();
            this.MMRLossLabel = new System.Windows.Forms.Label();
            this.AllyTextBox = new System.Windows.Forms.TextBox();
            this.EnemyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AllyLabel
            // 
            this.AllyLabel.AutoSize = true;
            this.AllyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllyLabel.Location = new System.Drawing.Point(12, 9);
            this.AllyLabel.Name = "AllyLabel";
            this.AllyLabel.Size = new System.Drawing.Size(59, 15);
            this.AllyLabel.TabIndex = 0;
            this.AllyLabel.Text = "Ally MMR";
            // 
            // EnemyLabel
            // 
            this.EnemyLabel.AutoSize = true;
            this.EnemyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyLabel.Location = new System.Drawing.Point(12, 38);
            this.EnemyLabel.Name = "EnemyLabel";
            this.EnemyLabel.Size = new System.Drawing.Size(75, 15);
            this.EnemyLabel.TabIndex = 1;
            this.EnemyLabel.Text = "Enemy MMR";
            // 
            // MMRGainLabel
            // 
            this.MMRGainLabel.AutoSize = true;
            this.MMRGainLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMRGainLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.MMRGainLabel.Location = new System.Drawing.Point(180, 19);
            this.MMRGainLabel.Name = "MMRGainLabel";
            this.MMRGainLabel.Size = new System.Drawing.Size(38, 20);
            this.MMRGainLabel.TabIndex = 3;
            this.MMRGainLabel.Text = "+25";
            this.MMRGainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MMRLossLabel
            // 
            this.MMRLossLabel.AutoSize = true;
            this.MMRLossLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMRLossLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.MMRLossLabel.Location = new System.Drawing.Point(224, 19);
            this.MMRLossLabel.Name = "MMRLossLabel";
            this.MMRLossLabel.Size = new System.Drawing.Size(33, 20);
            this.MMRLossLabel.TabIndex = 4;
            this.MMRLossLabel.Text = "-25";
            this.MMRLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AllyTextBox
            // 
            this.AllyTextBox.Location = new System.Drawing.Point(95, 7);
            this.AllyTextBox.Name = "AllyTextBox";
            this.AllyTextBox.Size = new System.Drawing.Size(66, 20);
            this.AllyTextBox.TabIndex = 5;
            this.AllyTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EnemyTextBox
            // 
            this.EnemyTextBox.Location = new System.Drawing.Point(95, 33);
            this.EnemyTextBox.Name = "EnemyTextBox";
            this.EnemyTextBox.Size = new System.Drawing.Size(66, 20);
            this.EnemyTextBox.TabIndex = 6;
            this.EnemyTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "/";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 61);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EnemyTextBox);
            this.Controls.Add(this.AllyTextBox);
            this.Controls.Add(this.MMRLossLabel);
            this.Controls.Add(this.MMRGainLabel);
            this.Controls.Add(this.EnemyLabel);
            this.Controls.Add(this.AllyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "DOTA 2 MMR Stake Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllyLabel;
        private System.Windows.Forms.Label EnemyLabel;
        private System.Windows.Forms.Label MMRGainLabel;
        private System.Windows.Forms.Label MMRLossLabel;
        private System.Windows.Forms.TextBox AllyTextBox;
        private System.Windows.Forms.TextBox EnemyTextBox;
        private System.Windows.Forms.Label label6;
    }
}

