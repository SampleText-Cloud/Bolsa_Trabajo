
namespace Ingenieria_Software.Secciones
{
    partial class AdministracionDeReclutador
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
            this.layout_principal = new System.Windows.Forms.TableLayoutPanel();
            this.layout_botones = new System.Windows.Forms.TableLayoutPanel();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.layout_datos = new System.Windows.Forms.TableLayoutPanel();
            this.layout_principal.SuspendLayout();
            this.layout_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_principal
            // 
            this.layout_principal.ColumnCount = 2;
            this.layout_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.layout_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_principal.Controls.Add(this.layout_botones, 1, 0);
            this.layout_principal.Controls.Add(this.layout_datos, 0, 0);
            this.layout_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_principal.Location = new System.Drawing.Point(0, 0);
            this.layout_principal.Name = "layout_principal";
            this.layout_principal.RowCount = 1;
            this.layout_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_principal.Size = new System.Drawing.Size(799, 387);
            this.layout_principal.TabIndex = 0;
            // 
            // layout_botones
            // 
            this.layout_botones.ColumnCount = 1;
            this.layout_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_botones.Controls.Add(this.button_actualizar, 0, 2);
            this.layout_botones.Controls.Add(this.button_eliminar, 0, 1);
            this.layout_botones.Controls.Add(this.button_agregar, 0, 0);
            this.layout_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_botones.Location = new System.Drawing.Point(602, 3);
            this.layout_botones.Name = "layout_botones";
            this.layout_botones.RowCount = 3;
            this.layout_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_botones.Size = new System.Drawing.Size(194, 381);
            this.layout_botones.TabIndex = 0;
            // 
            // button_agregar
            // 
            this.button_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_agregar.Location = new System.Drawing.Point(0, 0);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(194, 126);
            this.button_agregar.TabIndex = 0;
            this.button_agregar.Text = "Insertar";
            this.button_agregar.UseVisualStyleBackColor = true;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_eliminar.Location = new System.Drawing.Point(0, 126);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(194, 126);
            this.button_eliminar.TabIndex = 1;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            // 
            // button_actualizar
            // 
            this.button_actualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_actualizar.Location = new System.Drawing.Point(0, 252);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(194, 129);
            this.button_actualizar.TabIndex = 2;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            // 
            // layout_datos
            // 
            this.layout_datos.ColumnCount = 2;
            this.layout_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_datos.Location = new System.Drawing.Point(3, 3);
            this.layout_datos.Name = "layout_datos";
            this.layout_datos.RowCount = 12;
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.layout_datos.Size = new System.Drawing.Size(593, 381);
            this.layout_datos.TabIndex = 1;
            // 
            // AdministracionDeReclutador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout_principal);
            this.Name = "AdministracionDeReclutador";
            this.Size = new System.Drawing.Size(799, 387);
            this.layout_principal.ResumeLayout(false);
            this.layout_botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_principal;
        private System.Windows.Forms.TableLayoutPanel layout_botones;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.TableLayoutPanel layout_datos;
    }
}
