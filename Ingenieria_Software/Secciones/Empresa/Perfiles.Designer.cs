
namespace Ingenieria_Software.Secciones.Empresa
{
    partial class Perfiles
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_experiencia = new System.Windows.Forms.Label();
            this.comboBox_puesto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_descripcion = new System.Windows.Forms.RichTextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_idiomas = new System.Windows.Forms.Label();
            this.checkedListBox_idiomas = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_escolaridad = new System.Windows.Forms.ComboBox();
            this.textBox_idExperiencia = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.container.SuspendLayout();
            this.LayoutPrincipal.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.container, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button_agregar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_eliminar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_actualizar, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(643, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(154, 444);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button_agregar
            // 
            this.button_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_agregar.Location = new System.Drawing.Point(0, 0);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(154, 148);
            this.button_agregar.TabIndex = 1;
            this.button_agregar.Text = "Insertar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.Button_agregar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_eliminar.Location = new System.Drawing.Point(0, 148);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(154, 148);
            this.button_eliminar.TabIndex = 2;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.Button_eliminar_Click);
            // 
            // button_actualizar
            // 
            this.button_actualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_actualizar.Location = new System.Drawing.Point(0, 296);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(154, 148);
            this.button_actualizar.TabIndex = 3;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.Button_actualizar_Click);
            // 
            // container
            // 
            this.container.ColumnCount = 1;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.container.Controls.Add(this.LayoutPrincipal, 0, 0);
            this.container.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(3, 3);
            this.container.Name = "container";
            this.container.RowCount = 2;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.container.Size = new System.Drawing.Size(634, 444);
            this.container.TabIndex = 3;
            // 
            // LayoutPrincipal
            // 
            this.LayoutPrincipal.ColumnCount = 4;
            this.LayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.LayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.LayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LayoutPrincipal.Controls.Add(this.label1, 1, 3);
            this.LayoutPrincipal.Controls.Add(this.lbl_experiencia, 2, 3);
            this.LayoutPrincipal.Controls.Add(this.comboBox_puesto, 1, 4);
            this.LayoutPrincipal.Controls.Add(this.label2, 1, 0);
            this.LayoutPrincipal.Controls.Add(this.lbl_tipo, 2, 1);
            this.LayoutPrincipal.Controls.Add(this.comboBox_tipo, 2, 2);
            this.LayoutPrincipal.Controls.Add(this.textBox_id, 1, 2);
            this.LayoutPrincipal.Controls.Add(this.label4, 1, 1);
            this.LayoutPrincipal.Controls.Add(this.richTextBox_descripcion, 1, 8);
            this.LayoutPrincipal.Controls.Add(this.lbl_descripcion, 1, 7);
            this.LayoutPrincipal.Controls.Add(this.lbl_idiomas, 2, 5);
            this.LayoutPrincipal.Controls.Add(this.checkedListBox_idiomas, 2, 6);
            this.LayoutPrincipal.Controls.Add(this.label5, 1, 5);
            this.LayoutPrincipal.Controls.Add(this.comboBox_escolaridad, 1, 6);
            this.LayoutPrincipal.Controls.Add(this.textBox_idExperiencia, 2, 4);
            this.LayoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPrincipal.Location = new System.Drawing.Point(3, 3);
            this.LayoutPrincipal.Name = "LayoutPrincipal";
            this.LayoutPrincipal.RowCount = 9;
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11014F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11125F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11125F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11125F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11125F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11125F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11125F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11125F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.LayoutPrincipal.Size = new System.Drawing.Size(628, 304);
            this.LayoutPrincipal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(34, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puesto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_experiencia
            // 
            this.lbl_experiencia.AutoSize = true;
            this.lbl_experiencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_experiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_experiencia.Location = new System.Drawing.Point(316, 99);
            this.lbl_experiencia.Name = "lbl_experiencia";
            this.lbl_experiencia.Size = new System.Drawing.Size(276, 33);
            this.lbl_experiencia.TabIndex = 3;
            this.lbl_experiencia.Text = "ID Experiencia";
            this.lbl_experiencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_puesto
            // 
            this.comboBox_puesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_puesto.FormattingEnabled = true;
            this.comboBox_puesto.Location = new System.Drawing.Point(34, 135);
            this.comboBox_puesto.Name = "comboBox_puesto";
            this.comboBox_puesto.Size = new System.Drawing.Size(276, 21);
            this.comboBox_puesto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(34, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Perfiles Empresa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_tipo.Location = new System.Drawing.Point(316, 33);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(276, 33);
            this.lbl_tipo.TabIndex = 0;
            this.lbl_tipo.Text = "Tipo";
            this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Location = new System.Drawing.Point(316, 69);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(276, 21);
            this.comboBox_tipo.TabIndex = 9;
            // 
            // textBox_id
            // 
            this.textBox_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_id.Location = new System.Drawing.Point(34, 69);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(276, 20);
            this.textBox_id.TabIndex = 11;
            this.textBox_id.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(34, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox_descripcion
            // 
            this.richTextBox_descripcion.Location = new System.Drawing.Point(34, 267);
            this.richTextBox_descripcion.Name = "richTextBox_descripcion";
            this.richTextBox_descripcion.Size = new System.Drawing.Size(276, 34);
            this.richTextBox_descripcion.TabIndex = 7;
            this.richTextBox_descripcion.Text = "";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_descripcion.Location = new System.Drawing.Point(34, 231);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(276, 33);
            this.lbl_descripcion.TabIndex = 1;
            this.lbl_descripcion.Text = "Descripcion";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_idiomas
            // 
            this.lbl_idiomas.AutoSize = true;
            this.lbl_idiomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_idiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_idiomas.Location = new System.Drawing.Point(316, 165);
            this.lbl_idiomas.Name = "lbl_idiomas";
            this.lbl_idiomas.Size = new System.Drawing.Size(276, 33);
            this.lbl_idiomas.TabIndex = 2;
            this.lbl_idiomas.Text = "Idiomas";
            this.lbl_idiomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox_idiomas
            // 
            this.checkedListBox_idiomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_idiomas.FormattingEnabled = true;
            this.checkedListBox_idiomas.Location = new System.Drawing.Point(316, 201);
            this.checkedListBox_idiomas.Name = "checkedListBox_idiomas";
            this.checkedListBox_idiomas.Size = new System.Drawing.Size(276, 27);
            this.checkedListBox_idiomas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(34, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Escolaridad";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_escolaridad
            // 
            this.comboBox_escolaridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_escolaridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_escolaridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_escolaridad.FormattingEnabled = true;
            this.comboBox_escolaridad.Items.AddRange(new object[] {
            "Educación preescolar",
            "Educación Primaria",
            "Educación secundaria",
            "Educación media superior",
            "Educación superior"});
            this.comboBox_escolaridad.Location = new System.Drawing.Point(34, 201);
            this.comboBox_escolaridad.Name = "comboBox_escolaridad";
            this.comboBox_escolaridad.Size = new System.Drawing.Size(276, 21);
            this.comboBox_escolaridad.TabIndex = 14;
            // 
            // textBox_idExperiencia
            // 
            this.textBox_idExperiencia.Location = new System.Drawing.Point(316, 135);
            this.textBox_idExperiencia.Name = "textBox_idExperiencia";
            this.textBox_idExperiencia.Size = new System.Drawing.Size(276, 20);
            this.textBox_idExperiencia.TabIndex = 15;
            this.textBox_idExperiencia.Text = " ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 313);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(628, 128);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(622, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Perfiles Disponibles";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(622, 80);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.Click += new System.EventHandler(this.ListView1_Click);
            // 
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Perfiles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Perfiles";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.LayoutPrincipal.ResumeLayout(false);
            this.LayoutPrincipal.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.TableLayoutPanel container;
        private System.Windows.Forms.TableLayoutPanel LayoutPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_experiencia;
        private System.Windows.Forms.ComboBox comboBox_puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_idiomas;
        private System.Windows.Forms.CheckedListBox checkedListBox_idiomas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_escolaridad;
        private System.Windows.Forms.TextBox textBox_idExperiencia;
    }
}