
namespace HackerMan
{
    partial class FormGameWin
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
            this.labelGameWin = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGameWin
            // 
            this.labelGameWin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGameWin.Location = new System.Drawing.Point(11, 18);
            this.labelGameWin.Name = "labelGameWin";
            this.labelGameWin.Size = new System.Drawing.Size(392, 107);
            this.labelGameWin.TabIndex = 0;
            this.labelGameWin.Text = "Congratulation! You won! your time score will be saved in a file called \"time\".";
            this.labelGameWin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(156, 117);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(103, 36);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormGameWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 181);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelGameWin);
            this.Name = "FormGameWin";
            this.Text = "GameWin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGameWin;
        private System.Windows.Forms.Button buttonOk;
    }
}