
namespace Proyecto2CrearPrimerRegistroCompleto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.RolIdLabel = new System.Windows.Forms.Label();
            this.FechaCreacionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RolIdTextBox = new System.Windows.Forms.TextBox();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.buscarBoton = new System.Windows.Forms.Button();
            this.FechaCreacionDateTime = new System.Windows.Forms.DateTimePicker();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBoton.Image")));
            this.EliminarBoton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarBoton.Location = new System.Drawing.Point(366, 255);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(93, 61);
            this.EliminarBoton.TabIndex = 2;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // RolIdLabel
            // 
            this.RolIdLabel.AutoSize = true;
            this.RolIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RolIdLabel.Location = new System.Drawing.Point(44, 43);
            this.RolIdLabel.Name = "RolIdLabel";
            this.RolIdLabel.Size = new System.Drawing.Size(68, 28);
            this.RolIdLabel.TabIndex = 3;
            this.RolIdLabel.Text = "Rol ID:";
            // 
            // FechaCreacionLabel
            // 
            this.FechaCreacionLabel.AutoSize = true;
            this.FechaCreacionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaCreacionLabel.Location = new System.Drawing.Point(44, 176);
            this.FechaCreacionLabel.Name = "FechaCreacionLabel";
            this.FechaCreacionLabel.Size = new System.Drawing.Size(171, 28);
            this.FechaCreacionLabel.TabIndex = 4;
            this.FechaCreacionLabel.Text = "Fecha de creación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RolIdTextBox
            // 
            this.RolIdTextBox.Location = new System.Drawing.Point(219, 47);
            this.RolIdTextBox.Name = "RolIdTextBox";
            this.RolIdTextBox.Size = new System.Drawing.Size(163, 27);
            this.RolIdTextBox.TabIndex = 6;
            this.RolIdTextBox.TextChanged += new System.EventHandler(this.RolIdTextBox_TextChanged);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBoton.Image")));
            this.GuardarBoton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarBoton.Location = new System.Drawing.Point(42, 255);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(93, 61);
            this.GuardarBoton.TabIndex = 10;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // buscarBoton
            // 
            this.buscarBoton.Image = ((System.Drawing.Image)(resources.GetObject("buscarBoton.Image")));
            this.buscarBoton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buscarBoton.Location = new System.Drawing.Point(210, 255);
            this.buscarBoton.Name = "buscarBoton";
            this.buscarBoton.Size = new System.Drawing.Size(93, 61);
            this.buscarBoton.TabIndex = 11;
            this.buscarBoton.Text = "Buscar";
            this.buscarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscarBoton.UseVisualStyleBackColor = true;
            this.buscarBoton.Click += new System.EventHandler(this.buscarBoton_Click);
            // 
            // FechaCreacionDateTime
            // 
            this.FechaCreacionDateTime.Location = new System.Drawing.Point(219, 178);
            this.FechaCreacionDateTime.Name = "FechaCreacionDateTime";
            this.FechaCreacionDateTime.Size = new System.Drawing.Size(261, 27);
            this.FechaCreacionDateTime.TabIndex = 12;
            this.FechaCreacionDateTime.ValueChanged += new System.EventHandler(this.FechaCreacionDateTime_ValueChanged_1);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(219, 114);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(163, 28);
            this.DescripcionTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(571, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(369, 279);
            this.dataGridView1.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 393);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FechaCreacionDateTime);
            this.Controls.Add(this.buscarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.RolIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaCreacionLabel);
            this.Controls.Add(this.RolIdLabel);
            this.Controls.Add(this.EliminarBoton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Label RolIdLabel;
        private System.Windows.Forms.Label FechaCreacionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RolIdTextBox;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button buscarBoton;
        private System.Windows.Forms.DateTimePicker FechaCreacionDateTime;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

