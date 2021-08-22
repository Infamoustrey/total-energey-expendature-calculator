
namespace TDEE_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BodyWeightInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ActivityLevelInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TDEEResult = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(1448, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "TDEE - Total Daily Energy Expenditure Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 193);
            this.label2.MaximumSize = new System.Drawing.Size(1200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1192, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "BODY WEIGHT(lbs) x ACTIVITY LEVEL x 10 = TDEE";
            // 
            // BodyWeightInput
            // 
            this.BodyWeightInput.Location = new System.Drawing.Point(176, 430);
            this.BodyWeightInput.Name = "BodyWeightInput";
            this.BodyWeightInput.Size = new System.Drawing.Size(200, 31);
            this.BodyWeightInput.TabIndex = 3;
            this.BodyWeightInput.TextChanged += new System.EventHandler(this.BodyWeightInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "BODY WEIGHT (lbs)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActivityLevelInput
            // 
            this.ActivityLevelInput.Location = new System.Drawing.Point(466, 430);
            this.ActivityLevelInput.Name = "ActivityLevelInput";
            this.ActivityLevelInput.Size = new System.Drawing.Size(100, 31);
            this.ActivityLevelInput.TabIndex = 5;
            this.ActivityLevelInput.TextChanged += new System.EventHandler(this.ActivityLevelInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "ACTIVITY LEVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 693);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(859, 225);
            this.label6.TabIndex = 7;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 638);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "Activity Level Guide";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "X 10 =";
            // 
            // TDEEResult
            // 
            this.TDEEResult.AutoSize = true;
            this.TDEEResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDEEResult.Location = new System.Drawing.Point(718, 421);
            this.TDEEResult.Name = "TDEEResult";
            this.TDEEResult.Size = new System.Drawing.Size(565, 37);
            this.TDEEResult.TabIndex = 11;
            this.TDEEResult.Text = "(Enter Values to get a TDEE Estimate)";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(595, 514);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 25);
            this.ErrorMessageLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 949);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.TDEEResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ActivityLevelInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BodyWeightInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TDEE Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BodyWeightInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ActivityLevelInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TDEEResult;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}

