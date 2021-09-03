
namespace Ingenieria_Software.Mensajes
{
    partial class MsgBoxOK
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.layout_main = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.layout_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_main
            // 
            this.layout_main.ColumnCount = 1;
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_main.Controls.Add(this.label1, 0, 0);
            this.layout_main.Controls.Add(this.button_ok, 0, 1);
            this.layout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_main.Location = new System.Drawing.Point(0, 0);
            this.layout_main.Margin = new System.Windows.Forms.Padding(0);
            this.layout_main.Name = "layout_main";
            this.layout_main.RowCount = 2;
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.layout_main.Size = new System.Drawing.Size(667, 399);
            this.layout_main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(3, 275);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "button1";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // MsgBoxOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout_main);
            this.Name = "MsgBoxOK";
            this.Size = new System.Drawing.Size(667, 399);
            this.layout_main.ResumeLayout(false);
            this.layout_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ok;
    }
}
