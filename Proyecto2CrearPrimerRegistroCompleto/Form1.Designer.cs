
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.RolIdLabel = new System.Windows.Forms.Label();
            this.FechaCreacionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RolIdTextBox = new System.Windows.Forms.TextBox();
            this.FechaCreacionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.EditarBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBoton.Image")));
            this.EliminarBoton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarBoton.Location = new System.Drawing.Point(551, 326);
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
            this.RolIdLabel.Location = new System.Drawing.Point(44, 27);
            this.RolIdLabel.Name = "RolIdLabel";
            this.RolIdLabel.Size = new System.Drawing.Size(68, 28);
            this.RolIdLabel.TabIndex = 3;
            this.RolIdLabel.Text = "Rol ID:";
            // 
            // FechaCreacionLabel
            // 
            this.FechaCreacionLabel.AutoSize = true;
            this.FechaCreacionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaCreacionLabel.Location = new System.Drawing.Point(393, 27);
            this.FechaCreacionLabel.Name = "FechaCreacionLabel";
            this.FechaCreacionLabel.Size = new System.Drawing.Size(171, 28);
            this.FechaCreacionLabel.TabIndex = 4;
            this.FechaCreacionLabel.Text = "Fecha de creación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción:";
            // 
            // RolIdTextBox
            // 
            this.RolIdTextBox.Location = new System.Drawing.Point(118, 31);
            this.RolIdTextBox.Name = "RolIdTextBox";
            this.RolIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.RolIdTextBox.TabIndex = 6;
            // 
            // FechaCreacionMaskedTextBox
            // 
            this.FechaCreacionMaskedTextBox.Location = new System.Drawing.Point(570, 31);
            this.FechaCreacionMaskedTextBox.Mask = "00/00/0000";
            this.FechaCreacionMaskedTextBox.Name = "FechaCreacionMaskedTextBox";
            this.FechaCreacionMaskedTextBox.Size = new System.Drawing.Size(97, 27);
            this.FechaCreacionMaskedTextBox.TabIndex = 7;
            this.FechaCreacionMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.FechaCreacionMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.FechaCreacionMaskedTextBox_MaskInputRejected);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(166, 95);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(500, 193);
            this.DescripcionTextBox.TabIndex = 8;
            // 
            // EditarBoton
            // 
            this.EditarBoton.AllowDrop = true;
            this.EditarBoton.Image = ((System.Drawing.Image)(resources.GetObject("EditarBoton.Image")));
            this.EditarBoton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditarBoton.Location = new System.Drawing.Point(364, 326);
            this.EditarBoton.Name = "EditarBoton";
            this.EditarBoton.Size = new System.Drawing.Size(93, 62);
            this.EditarBoton.TabIndex = 9;
            this.EditarBoton.Text = "Editar";
            this.EditarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditarBoton.UseVisualStyleBackColor = true;
            this.EditarBoton.Click += new System.EventHandler(this.EditarBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBoton.Image")));
            this.GuardarBoton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarBoton.Location = new System.Drawing.Point(166, 327);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(93, 61);
            this.GuardarBoton.TabIndex = 10;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(723, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(533, 357);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.EditarBoton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.FechaCreacionMaskedTextBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Label RolIdLabel;
        private System.Windows.Forms.Label FechaCreacionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RolIdTextBox;
        private System.Windows.Forms.MaskedTextBox FechaCreacionMaskedTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Button EditarBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

