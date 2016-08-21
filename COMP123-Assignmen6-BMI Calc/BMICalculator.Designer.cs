namespace COMP123_Assignmen6_BMI_Calc
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.myHeightLabel = new System.Windows.Forms.Label();
            this.myWeightLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bmiCalculatorLabel = new System.Windows.Forms.Label();
            this.BMIresultTextBox = new System.Windows.Forms.TextBox();
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateBmiButton = new System.Windows.Forms.Button();
            this.resetCalcButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.myHeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.myWeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.imperialRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metricRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.calculateBmiButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.resetCalcButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // myHeightLabel
            // 
            this.myHeightLabel.AutoSize = true;
            this.myHeightLabel.Location = new System.Drawing.Point(3, 68);
            this.myHeightLabel.Name = "myHeightLabel";
            this.myHeightLabel.Size = new System.Drawing.Size(136, 31);
            this.myHeightLabel.TabIndex = 0;
            this.myHeightLabel.Text = "My Height";
            // 
            // myWeightLabel
            // 
            this.myWeightLabel.AutoSize = true;
            this.myWeightLabel.Location = new System.Drawing.Point(3, 136);
            this.myWeightLabel.Name = "myWeightLabel";
            this.myWeightLabel.Size = new System.Drawing.Size(141, 31);
            this.myWeightLabel.TabIndex = 1;
            this.myWeightLabel.Text = "My Weight";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.bmiCalculatorLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(304, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bmiCalculatorLabel
            // 
            this.bmiCalculatorLabel.AutoSize = true;
            this.bmiCalculatorLabel.Location = new System.Drawing.Point(3, 0);
            this.bmiCalculatorLabel.Name = "bmiCalculatorLabel";
            this.bmiCalculatorLabel.Size = new System.Drawing.Size(192, 31);
            this.bmiCalculatorLabel.TabIndex = 0;
            this.bmiCalculatorLabel.Text = "BMI Calculator";
            // 
            // BMIresultTextBox
            // 
            this.BMIresultTextBox.Location = new System.Drawing.Point(1, 374);
            this.BMIresultTextBox.Name = "BMIresultTextBox";
            this.BMIresultTextBox.ReadOnly = true;
            this.BMIresultTextBox.Size = new System.Drawing.Size(304, 38);
            this.BMIresultTextBox.TabIndex = 2;
            // 
            // imperialRadioButton
            // 
            this.imperialRadioButton.AutoSize = true;
            this.imperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.imperialRadioButton.Name = "imperialRadioButton";
            this.imperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.imperialRadioButton.TabIndex = 2;
            this.imperialRadioButton.TabStop = true;
            this.imperialRadioButton.Text = "Imperial";
            this.imperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Location = new System.Drawing.Point(155, 3);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.metricRadioButton.TabIndex = 3;
            this.metricRadioButton.TabStop = true;
            this.metricRadioButton.Text = "Metric";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateBmiButton
            // 
            this.calculateBmiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.calculateBmiButton.Location = new System.Drawing.Point(3, 207);
            this.calculateBmiButton.Name = "calculateBmiButton";
            this.calculateBmiButton.Size = new System.Drawing.Size(146, 65);
            this.calculateBmiButton.TabIndex = 4;
            this.calculateBmiButton.Text = "Calculate BMI";
            this.calculateBmiButton.UseVisualStyleBackColor = true;
            // 
            // resetCalcButton
            // 
            this.resetCalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.resetCalcButton.Location = new System.Drawing.Point(155, 207);
            this.resetCalcButton.Name = "resetCalcButton";
            this.resetCalcButton.Size = new System.Drawing.Size(146, 65);
            this.resetCalcButton.TabIndex = 5;
            this.resetCalcButton.Text = "Reset";
            this.resetCalcButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 38);
            this.textBox3.TabIndex = 7;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMIresultTextBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label myHeightLabel;
        private System.Windows.Forms.Label myWeightLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label bmiCalculatorLabel;
        private System.Windows.Forms.TextBox BMIresultTextBox;
        private System.Windows.Forms.RadioButton imperialRadioButton;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.Button calculateBmiButton;
        private System.Windows.Forms.Button resetCalcButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

