namespace MileageCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startingMileageBox = new System.Windows.Forms.NumericUpDown();
            this.endingMileageBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.calculationAmount = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startingMileageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMileageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Mileage";
            // 
            // startingMileageBox
            // 
            this.startingMileageBox.Location = new System.Drawing.Point(145, 33);
            this.startingMileageBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startingMileageBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startingMileageBox.Name = "startingMileageBox";
            this.startingMileageBox.Size = new System.Drawing.Size(120, 22);
            this.startingMileageBox.TabIndex = 2;
            this.startingMileageBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endingMileageBox
            // 
            this.endingMileageBox.Location = new System.Drawing.Point(145, 68);
            this.endingMileageBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endingMileageBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endingMileageBox.Name = "endingMileageBox";
            this.endingMileageBox.Size = new System.Drawing.Size(120, 22);
            this.endingMileageBox.TabIndex = 3;
            this.endingMileageBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Owed";
            // 
            // calculationAmount
            // 
            this.calculationAmount.AutoSize = true;
            this.calculationAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationAmount.Location = new System.Drawing.Point(144, 110);
            this.calculationAmount.Name = "calculationAmount";
            this.calculationAmount.Size = new System.Drawing.Size(86, 25);
            this.calculationAmount.TabIndex = 5;
            this.calculationAmount.Text = "Amount";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(145, 159);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 34);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 220);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.calculationAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endingMileageBox);
            this.Controls.Add(this.startingMileageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.startingMileageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMileageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startingMileageBox;
        private System.Windows.Forms.NumericUpDown endingMileageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label calculationAmount;
        private System.Windows.Forms.Button calculateButton;
    }
}

