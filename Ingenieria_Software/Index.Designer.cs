
namespace Ingenieria_Software
{
    partial class Index
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
            this.buttonTestBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTestBD
            // 
            this.buttonTestBD.Location = new System.Drawing.Point(255, 135);
            this.buttonTestBD.Name = "buttonTestBD";
            this.buttonTestBD.Size = new System.Drawing.Size(259, 165);
            this.buttonTestBD.TabIndex = 0;
            this.buttonTestBD.Text = "PROBAR BASE DE DATOS";
            this.buttonTestBD.UseVisualStyleBackColor = true;
            this.buttonTestBD.Click += new System.EventHandler(this.ButtonTestBD_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTestBD);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTestBD;
    }
}