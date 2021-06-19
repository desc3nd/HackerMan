
namespace HackerMan
{
    partial class FormSurpriseAttack
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
            this.labelSurpriseAttack = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSurpriseAttack
            // 
            this.labelSurpriseAttack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSurpriseAttack.Location = new System.Drawing.Point(7, 22);
            this.labelSurpriseAttack.Name = "labelSurpriseAttack";
            this.labelSurpriseAttack.Size = new System.Drawing.Size(392, 91);
            this.labelSurpriseAttack.TabIndex = 1;
            this.labelSurpriseAttack.Text = "UPSS! You have been attacked by unexpected guest- 150 money";
            this.labelSurpriseAttack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(152, 116);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(103, 36);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormSurpriseAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 181);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelSurpriseAttack);
            this.Name = "FormSurpriseAttack";
            this.Text = "FormSurpriseAttack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSurpriseAttack;
        private System.Windows.Forms.Button buttonOk;
    }
}