namespace MathExpressionCalculator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // labelA
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(12, 15);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a:";

            // txtA
            this.txtA.Location = new System.Drawing.Point(35, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "4,29";

            // labelB
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(12, 41);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b:";

            // txtB
            this.txtB.Location = new System.Drawing.Point(35, 38);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "7,91";

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(12, 64);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 90);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Результат:";

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(12, 106);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(123, 20);
            this.txtResult.TabIndex = 6;

            // errorProvider
            this.errorProvider.ContainerControl = this;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 140);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.labelA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Вычисление выражения";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}