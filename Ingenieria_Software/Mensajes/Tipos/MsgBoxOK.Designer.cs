
namespace Ingenieria_Software.Mensajes.Tipos
{
    partial class MsgBoxOK
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
            this.layout_main = new System.Windows.Forms.TableLayoutPanel();
            this.button_ok = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.layout_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_main
            // 
            this.layout_main.ColumnCount = 1;
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_main.Controls.Add(this.button_ok, 0, 1);
            this.layout_main.Controls.Add(this.msg, 0, 0);
            this.layout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_main.Location = new System.Drawing.Point(0, 0);
            this.layout_main.Margin = new System.Windows.Forms.Padding(0);
            this.layout_main.Name = "layout_main";
            this.layout_main.RowCount = 2;
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.layout_main.Size = new System.Drawing.Size(800, 450);
            this.layout_main.TabIndex = 0;
            // 
            // button_ok
            // 
            this.button_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ok.Location = new System.Drawing.Point(3, 291);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(794, 156);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Aceptar";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msg.Location = new System.Drawing.Point(0, 0);
            this.msg.Margin = new System.Windows.Forms.Padding(0);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(800, 288);
            this.msg.TabIndex = 1;
            this.msg.Text = "Error";
            this.msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layout_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.layout_main.ResumeLayout(false);
            this.layout_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_main;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label msg;
    }
}