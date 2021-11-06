
namespace Ingenieria_Software.Mensajes.Tipos
{
    partial class MsgBoxYesOrNo
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
            this.layout_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.button_yes = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.layout_main.SuspendLayout();
            this.layout_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_main
            // 
            this.layout_main.BackColor = System.Drawing.Color.White;
            this.layout_main.ColumnCount = 1;
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_main.Controls.Add(this.layout_buttons, 0, 1);
            this.layout_main.Controls.Add(this.msg, 0, 0);
            this.layout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_main.Location = new System.Drawing.Point(0, 0);
            this.layout_main.Name = "layout_main";
            this.layout_main.RowCount = 2;
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.33333F));
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.66667F));
            this.layout_main.Size = new System.Drawing.Size(923, 450);
            this.layout_main.TabIndex = 0;
            // 
            // layout_buttons
            // 
            this.layout_buttons.ColumnCount = 2;
            this.layout_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_buttons.Controls.Add(this.button_yes, 0, 0);
            this.layout_buttons.Controls.Add(this.button_no, 1, 0);
            this.layout_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_buttons.Location = new System.Drawing.Point(0, 275);
            this.layout_buttons.Margin = new System.Windows.Forms.Padding(0);
            this.layout_buttons.Name = "layout_buttons";
            this.layout_buttons.RowCount = 1;
            this.layout_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_buttons.Size = new System.Drawing.Size(923, 175);
            this.layout_buttons.TabIndex = 0;
            // 
            // button_yes
            // 
            this.button_yes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_yes.Location = new System.Drawing.Point(0, 0);
            this.button_yes.Margin = new System.Windows.Forms.Padding(0);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(461, 175);
            this.button_yes.TabIndex = 0;
            this.button_yes.Text = "Aceptar";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.Button_yes_Click);
            // 
            // button_no
            // 
            this.button_no.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_no.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_no.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_no.Location = new System.Drawing.Point(461, 0);
            this.button_no.Margin = new System.Windows.Forms.Padding(0);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(462, 175);
            this.button_no.TabIndex = 1;
            this.button_no.Text = "Cancelar";
            this.button_no.UseVisualStyleBackColor = true;
            this.button_no.Click += new System.EventHandler(this.Button_no_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.msg.Location = new System.Drawing.Point(0, 0);
            this.msg.Margin = new System.Windows.Forms.Padding(0);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(923, 275);
            this.msg.TabIndex = 1;
            this.msg.Text = "Elegir opcion";
            this.msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MsgBoxYesOrNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.layout_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBoxYesOrNo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MsgBoxYesOrNo";
            this.layout_main.ResumeLayout(false);
            this.layout_main.PerformLayout();
            this.layout_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_main;
        private System.Windows.Forms.TableLayoutPanel layout_buttons;
        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.Label msg;
    }
}