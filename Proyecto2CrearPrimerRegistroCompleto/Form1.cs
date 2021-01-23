using Proyecto2CrearPrimerRegistroCompleto.DAL;
using Proyecto2CrearPrimerRegistroCompleto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2CrearPrimerRegistroCompleto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Creamos la funcion "Existe" para usarla en el guardar y verificar si el id ya existe
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.RolId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        //Este metodo se utiliza en el evento del boton editar, para modificar las entidades en las que concuerde el id que buscamos
        public static bool Modificar(Roles rol)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                //Marcar la entidad como modificada para que el contexto sepa como proceder
                contexto.Entry(rol).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
      
        //El metodo eliminar lo utilizaremos en el evento del boton eliminar, para borrar entidades
        public static bool Eliminar(int id)
        {
            bool interruptor = false;
            Contexto contexto = new Contexto();

            try
            {
                var rol = contexto.Roles.Find(id);

                if(rol != null)
                {
                    contexto.Roles.Remove(rol);//Se elimina la entidad
                    interruptor = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return interruptor;
        }


        //Objetos graficos
        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Roles rol = new Roles();

            //Verificamos que no exista un id igual, en caso de que exista, no se permite que se almacene
            if (!Existe(Convert.ToInt32(RolIdTextBox.Text)))
            {
                rol.RolId = Convert.ToInt32(RolIdTextBox.Text);
                rol.FechaCreacion = Convert.ToDateTime(FechaCreacionMaskedTextBox.Text);
                rol.Descripcion = DescripcionTextBox.Text;
                contexto.Roles.Add(rol);
                contexto.SaveChanges();
                dataGridView1.DataSource = contexto.Roles.ToList();
                contexto.Dispose();
            }
            else
                MessageBox.Show("Este Id ya existe en la base de datos");
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Roles rol = new Roles();

            if (Existe(Convert.ToInt32(RolIdTextBox.Text)))
            {
                rol.RolId = Convert.ToInt32(RolIdTextBox.Text);
                rol.FechaCreacion = Convert.ToDateTime(FechaCreacionMaskedTextBox.Text);
                rol.Descripcion = DescripcionTextBox.Text;
                Modificar(rol);
                contexto.SaveChanges();
                dataGridView1.DataSource = contexto.Roles.ToList();
                contexto.Dispose();
            }
            else
                MessageBox.Show("Este Id no existe en la base de datos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FechaCreacionMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            if (Existe(Convert.ToInt32(RolIdTextBox.Text)))
            {
                Contexto contexto = new Contexto();
                Eliminar(Convert.ToInt32(RolIdTextBox.Text));
                dataGridView1.DataSource = contexto.Roles.ToList();
            }
            else
                MessageBox.Show("Este Id no existe en la base de datos");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
