
namespace HackerMan
{
    partial class FormLotteryWon
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
            this.labelLotteryWon = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLotteryWon
            // 
            this.labelLotteryWon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLotteryWon.Location = new System.Drawing.Point(38, 31);
            this.labelLotteryWon.Name = "labelLotteryWon";
            this.labelLotteryWon.Size = new System.Drawing.Size(354, 94);
            this.labelLotteryWon.TabIndex = 0;
            this.labelLotteryWon.Text = "Congratulations! You won on a lottery! You earn 150 money!";
            this.labelLotteryWon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(138, 125);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(154, 36);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormLotteryWon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 181);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelLotteryWon);
            this.Name = "FormLotteryWon";
            this.Text = "LotteryWon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLotteryWon;
        private System.Windows.Forms.Button buttonOk;
    }
}