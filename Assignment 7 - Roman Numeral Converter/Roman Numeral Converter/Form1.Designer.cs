namespace Roman_Numeral_Converter
{
    partial class romanNumeralConverter
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
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.numberOutputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(136, 12);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(126, 20);
            this.inputNumber.TabIndex = 0;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(12, 15);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(118, 13);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "Enter a number 1 to 10:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(187, 38);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 76);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(118, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "The Roman Numeral is:";
            // 
            // numberOutputLabel
            // 
            this.numberOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOutputLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOutputLabel.Location = new System.Drawing.Point(15, 89);
            this.numberOutputLabel.Name = "numberOutputLabel";
            this.numberOutputLabel.Size = new System.Drawing.Size(247, 80);
            this.numberOutputLabel.TabIndex = 4;
            this.numberOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(187, 173);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // romanNumeralConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 208);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.numberOutputLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.inputNumber);
            this.Name = "romanNumeralConverter";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label numberOutputLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

