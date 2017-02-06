namespace WCFCalcWinClient
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
            this.textBoxOperandLeft = new System.Windows.Forms.TextBox();
            this.textBoxOperandRight = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxOperandLeft
            // 
            this.textBoxOperandLeft.Location = new System.Drawing.Point(12, 8);
            this.textBoxOperandLeft.Name = "textBoxOperandLeft";
            this.textBoxOperandLeft.Size = new System.Drawing.Size(110, 20);
            this.textBoxOperandLeft.TabIndex = 0;
            // 
            // textBoxOperandRight
            // 
            this.textBoxOperandRight.Location = new System.Drawing.Point(168, 9);
            this.textBoxOperandRight.Name = "textBoxOperandRight";
            this.textBoxOperandRight.Size = new System.Drawing.Size(110, 20);
            this.textBoxOperandRight.TabIndex = 1;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%",
            "^"});
            this.comboBoxOperator.Location = new System.Drawing.Point(128, 8);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(34, 21);
            this.comboBoxOperator.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(12, 35);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(360, 16);
            this.labelResult.TabIndex = 4;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 157);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.textBoxOperandRight);
            this.Controls.Add(this.textBoxOperandLeft);
            this.Name = "Form1";
            this.Text = "WCFCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOperandLeft;
        private System.Windows.Forms.TextBox textBoxOperandRight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResult;
    }
}

