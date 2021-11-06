
namespace Ingenieria_Software.Mensajes.Tipos
{
    partial class Conversion
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_no = new System.Windows.Forms.Button();
            this.button_si = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_cancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_cancel
            // 
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_cancel.Location = new System.Drawing.Point(0, 382);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(800, 68);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "CANCELAR";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_no, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_si, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 315);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 67);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_no
            // 
            this.button_no.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_no.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_no.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_no.Location = new System.Drawing.Point(400, 0);
            this.button_no.Margin = new System.Windows.Forms.Padding(0);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(400, 67);
            this.button_no.TabIndex = 1;
            this.button_no.Text = "ARCHIVO MUERTO";
            this.button_no.UseVisualStyleBackColor = true;
            this.button_no.Click += new System.EventHandler(this.Button_no_Click);
            // 
            // button_si
            // 
            this.button_si.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_si.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_si.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_si.Location = new System.Drawing.Point(0, 0);
            this.button_si.Margin = new System.Windows.Forms.Padding(0);
            this.button_si.Name = "button_si";
            this.button_si.Size = new System.Drawing.Size(400, 67);
            this.button_si.TabIndex = 0;
            this.button_si.Text = "TRABAJADOR";
            this.button_si.UseVisualStyleBackColor = true;
            this.button_si.Click += new System.EventHandler(this.Button_si_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 315);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONAR CONVERSION DEL REGISTRO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conversion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Conversion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.Button button_si;
        private System.Windows.Forms.Label label1;
    }
}