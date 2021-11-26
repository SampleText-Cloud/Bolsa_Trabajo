
namespace Ingenieria_Software.Reportes
{
    partial class Reportes
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
            this.button_R1 = new System.Windows.Forms.Button();
            this.button_R2 = new System.Windows.Forms.Button();
            this.button_R3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.button_R1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_R2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_R3, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // button_R1
            // 
            this.button_R1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_R1.Location = new System.Drawing.Point(43, 152);
            this.button_R1.Name = "button_R1";
            this.button_R1.Size = new System.Drawing.Size(234, 144);
            this.button_R1.TabIndex = 0;
            this.button_R1.Text = "REPORTE DE\r\nCANDIDATOS";
            this.button_R1.UseVisualStyleBackColor = true;
            this.button_R1.Click += new System.EventHandler(this.Button_R1_Click);
            // 
            // button_R2
            // 
            this.button_R2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_R2.Location = new System.Drawing.Point(283, 152);
            this.button_R2.Name = "button_R2";
            this.button_R2.Size = new System.Drawing.Size(234, 144);
            this.button_R2.TabIndex = 1;
            this.button_R2.Text = "REPORTE DE\r\nEMPLEADOS ACTIVOS";
            this.button_R2.UseVisualStyleBackColor = true;
            this.button_R2.Click += new System.EventHandler(this.Button_R2_Click);
            // 
            // button_R3
            // 
            this.button_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_R3.Location = new System.Drawing.Point(523, 152);
            this.button_R3.Name = "button_R3";
            this.button_R3.Size = new System.Drawing.Size(234, 144);
            this.button_R3.TabIndex = 2;
            this.button_R3.Text = "REPORTE DE\r\nARCHIVO MUERTO";
            this.button_R3.UseVisualStyleBackColor = true;
            this.button_R3.Click += new System.EventHandler(this.Button_R3_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_R1;
        private System.Windows.Forms.Button button_R2;
        private System.Windows.Forms.Button button_R3;
    }
}