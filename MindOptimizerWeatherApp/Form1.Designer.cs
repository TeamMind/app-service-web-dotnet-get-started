namespace MindOptimizerWeatherApp
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
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblRain = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.picboxIcon = new System.Windows.Forms.PictureBox();
            this.lblConditionResp = new System.Windows.Forms.Label();
            this.lblDetResp = new System.Windows.Forms.Label();
            this.lblRainResp = new System.Windows.Forms.Label();
            this.lblWindResp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTempResp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(41, 88);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(85, 28);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City: ";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(112, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(157, 20);
            this.txtCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(299, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblCondition
            // 
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.White;
            this.lblCondition.Location = new System.Drawing.Point(41, 197);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(133, 28);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "Condition:";
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(41, 252);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(105, 28);
            this.lblDetails.TabIndex = 4;
            this.lblDetails.Text = "Details:";
            // 
            // lblRain
            // 
            this.lblRain.BackColor = System.Drawing.Color.Transparent;
            this.lblRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRain.ForeColor = System.Drawing.Color.White;
            this.lblRain.Location = new System.Drawing.Point(41, 306);
            this.lblRain.Name = "lblRain";
            this.lblRain.Size = new System.Drawing.Size(105, 28);
            this.lblRain.TabIndex = 5;
            this.lblRain.Text = "Rainfall: ";
            // 
            // lblWind
            // 
            this.lblWind.BackColor = System.Drawing.Color.Transparent;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.ForeColor = System.Drawing.Color.White;
            this.lblWind.Location = new System.Drawing.Point(41, 365);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(105, 28);
            this.lblWind.TabIndex = 6;
            this.lblWind.Text = "Wind:";
            // 
            // picboxIcon
            // 
            this.picboxIcon.BackColor = System.Drawing.Color.Transparent;
            this.picboxIcon.Location = new System.Drawing.Point(46, 132);
            this.picboxIcon.Name = "picboxIcon";
            this.picboxIcon.Size = new System.Drawing.Size(100, 50);
            this.picboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxIcon.TabIndex = 7;
            this.picboxIcon.TabStop = false;
            // 
            // lblConditionResp
            // 
            this.lblConditionResp.BackColor = System.Drawing.Color.Transparent;
            this.lblConditionResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditionResp.ForeColor = System.Drawing.Color.White;
            this.lblConditionResp.Location = new System.Drawing.Point(180, 197);
            this.lblConditionResp.Name = "lblConditionResp";
            this.lblConditionResp.Size = new System.Drawing.Size(175, 28);
            this.lblConditionResp.TabIndex = 8;
            // 
            // lblDetResp
            // 
            this.lblDetResp.BackColor = System.Drawing.Color.Transparent;
            this.lblDetResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetResp.ForeColor = System.Drawing.Color.White;
            this.lblDetResp.Location = new System.Drawing.Point(180, 252);
            this.lblDetResp.Name = "lblDetResp";
            this.lblDetResp.Size = new System.Drawing.Size(175, 28);
            this.lblDetResp.TabIndex = 9;
            // 
            // lblRainResp
            // 
            this.lblRainResp.BackColor = System.Drawing.Color.Transparent;
            this.lblRainResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRainResp.ForeColor = System.Drawing.Color.White;
            this.lblRainResp.Location = new System.Drawing.Point(180, 306);
            this.lblRainResp.Name = "lblRainResp";
            this.lblRainResp.Size = new System.Drawing.Size(335, 28);
            this.lblRainResp.TabIndex = 10;
            // 
            // lblWindResp
            // 
            this.lblWindResp.BackColor = System.Drawing.Color.Transparent;
            this.lblWindResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindResp.ForeColor = System.Drawing.Color.White;
            this.lblWindResp.Location = new System.Drawing.Point(180, 365);
            this.lblWindResp.Name = "lblWindResp";
            this.lblWindResp.Size = new System.Drawing.Size(175, 28);
            this.lblWindResp.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(477, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Temp:";
            // 
            // lblTempResp
            // 
            this.lblTempResp.BackColor = System.Drawing.Color.Transparent;
            this.lblTempResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempResp.ForeColor = System.Drawing.Color.White;
            this.lblTempResp.Location = new System.Drawing.Point(575, 197);
            this.lblTempResp.Name = "lblTempResp";
            this.lblTempResp.Size = new System.Drawing.Size(175, 28);
            this.lblTempResp.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(234, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "CIC Weather Event Verification API";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTempResp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWindResp);
            this.Controls.Add(this.lblRainResp);
            this.Controls.Add(this.lblDetResp);
            this.Controls.Add(this.lblConditionResp);
            this.Controls.Add(this.picboxIcon);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblRain);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblRain;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.PictureBox picboxIcon;
        private System.Windows.Forms.Label lblConditionResp;
        private System.Windows.Forms.Label lblDetResp;
        private System.Windows.Forms.Label lblRainResp;
        private System.Windows.Forms.Label lblWindResp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTempResp;
        private System.Windows.Forms.Label label2;
    }
}

