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
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateBmiButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.myHeightTextBox = new System.Windows.Forms.TextBox();
            this.myWeightTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bmiCalculatorLabel = new System.Windows.Forms.Label();
            this.BMIValueTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BMIScaleTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.myHeightTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.myWeightTextBox, 1, 2);
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
            // imperialRadioButton
            // 
            this.imperialRadioButton.AutoSize = true;
            this.imperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.imperialRadioButton.Name = "imperialRadioButton";
            this.imperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.imperialRadioButton.TabIndex = 1;
            this.imperialRadioButton.Text = "Imperial";
            this.imperialRadioButton.UseVisualStyleBackColor = true;
            this.imperialRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Location = new System.Drawing.Point(155, 3);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.metricRadioButton.TabIndex = 2;
            this.metricRadioButton.Text = "Metric";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            this.metricRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // calculateBmiButton
            // 
            this.calculateBmiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.calculateBmiButton.Location = new System.Drawing.Point(3, 207);
            this.calculateBmiButton.Name = "calculateBmiButton";
            this.calculateBmiButton.Size = new System.Drawing.Size(146, 65);
            this.calculateBmiButton.TabIndex = 5;
            this.calculateBmiButton.Text = "Calculate BMI";
            this.calculateBmiButton.UseVisualStyleBackColor = true;
            this.calculateBmiButton.Click += new System.EventHandler(this.BMIButton_Click);

            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.resetButton.Location = new System.Drawing.Point(155, 207);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(146, 65);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);

            // 
            // myHeightTextBox
            // 
            this.myHeightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myHeightTextBox.Location = new System.Drawing.Point(155, 71);
            this.myHeightTextBox.Name = "myHeightTextBox";
            this.myHeightTextBox.Size = new System.Drawing.Size(146, 38);
            this.myHeightTextBox.TabIndex = 3;
            this.myHeightTextBox.TextChanged += new System.EventHandler(this.myHeightTextBox_TextChanged);
            // 
            // myWeightTextBox
            // 
            this.myWeightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myWeightTextBox.Location = new System.Drawing.Point(155, 139);
            this.myWeightTextBox.Name = "myWeightTextBox";
            this.myWeightTextBox.Size = new System.Drawing.Size(146, 38);
            this.myWeightTextBox.TabIndex = 4;
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
            // BMIValueTextBox
            // 
            this.BMIValueTextBox.Enabled = false;
            this.BMIValueTextBox.Location = new System.Drawing.Point(-2, 354);
            this.BMIValueTextBox.Name = "BMIValueTextBox";
            this.BMIValueTextBox.ReadOnly = true;
            this.BMIValueTextBox.Size = new System.Drawing.Size(304, 38);
            this.BMIValueTextBox.TabIndex = 7;
            this.BMIValueTextBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.BMIScaleTextBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 398);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(301, 44);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // BMIScaleTextBox
            // 
            this.BMIScaleTextBox.Location = new System.Drawing.Point(3, 3);
            this.BMIScaleTextBox.Multiline = true;
            this.BMIScaleTextBox.Name = "BMIScaleTextBox";
            this.BMIScaleTextBox.ReadOnly = true;
            this.BMIScaleTextBox.Size = new System.Drawing.Size(295, 38);
            this.BMIScaleTextBox.TabIndex = 8;
            this.BMIScaleTextBox.TabStop = false;
            this.BMIScaleTextBox.TextChanged += new System.EventHandler(this.BMIScaleTextBox_TextChanged);

            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.BMIValueTextBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label myHeightLabel;
        private System.Windows.Forms.Label myWeightLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label bmiCalculatorLabel;
        private System.Windows.Forms.TextBox BMIValueTextBox;
        private System.Windows.Forms.RadioButton imperialRadioButton;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.Button calculateBmiButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox myHeightTextBox;
        private System.Windows.Forms.TextBox myWeightTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox BMIScaleTextBox;
    }
}

