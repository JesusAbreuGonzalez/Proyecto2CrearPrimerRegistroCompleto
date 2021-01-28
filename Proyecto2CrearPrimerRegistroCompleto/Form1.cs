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
        public static bool Existe(string descripcion)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.Descripcion == descripcion);
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

        //Sobrecarga para poder usar el metodo Existe con un parametro integer
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

        //El metodo eliminar lo utilizaremos en el evento del boton eliminar, para borrar entidades
        public static bool Eliminar(int id, string descripcion)
        {
            bool interruptor = false;
            Contexto contexto = new Contexto();

            try
            {
                var rol = contexto.Roles.Find(id);
                
                if(rol != null)
                {
                    if(descripcion == rol.Descripcion)
                    {
                        contexto.Roles.Remove(rol);//Se elimina la entidad
                        interruptor = contexto.SaveChanges() > 0;
                    }
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

        public static Roles Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Roles rol;

            try
            {
                rol = contexto.Roles.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return rol;
        }


        //Objetos graficos
        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Roles rol = new Roles();
            DateTime fecha = FechaCreacionDateTime.Value;

            if (RolIdTextBox.Text == "" || DescripcionTextBox.Text == "")
            {
                errorProvider1.SetError(RolIdTextBox, "Campo obligatorio");
                errorProvider1.SetError(DescripcionTextBox, "Campo obligatorio");
            }

            else
            {
                //Verificamos que no exista un id igual, en caso de que exista, no se permite que se almacene
                if (Existe(DescripcionTextBox.Text.ToLower()))
                {
                    if(Existe(Convert.ToInt32(RolIdTextBox.Text)))
                    {
                        Eliminar(Convert.ToInt32(RolIdTextBox.Text), DescripcionTextBox.Text);
                        rol.RolId = Convert.ToInt32(RolIdTextBox.Text);
                        rol.FechaCreacion = fecha;
                        rol.Descripcion = DescripcionTextBox.Text.ToLower();
                        contexto.Roles.Add(rol);
                        contexto.SaveChanges();
                        contexto.Dispose();
                        errorProvider1.Clear();
                        MessageBox.Show("El rol fue modificado con exito a la base de datos");

                    }
                    else
                    {
                        MessageBox.Show("Este rol ya se encuentra en la base de datos");
                        errorProvider1.SetError(DescripcionTextBox, "Rol existente");
                    }
                    
                }
                else
                {
                    rol.RolId = Convert.ToInt32(RolIdTextBox.Text);
                    rol.FechaCreacion = fecha;
                    rol.Descripcion = DescripcionTextBox.Text.ToLower();
                    contexto.Roles.Add(rol);
                    contexto.SaveChanges();
                    contexto.Dispose();
                    errorProvider1.Clear();
                    MessageBox.Show("El rol fue agregado con exito a la base de datos");
                }

            }

            RolIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
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

            if (Existe(DescripcionTextBox.Text.ToLower()))
            {
                if(Existe(Convert.ToInt32(RolIdTextBox.Text)))
                {
                    Eliminar(Convert.ToInt32(RolIdTextBox.Text), DescripcionTextBox.Text);
                    MessageBox.Show("Este Id ya no existe en la base de datos");
                }
                else
                {
                    MessageBox.Show("Este Id no existe en la base de datos");
                }
                
            }
            else
                MessageBox.Show("Este rol no existe en la base de datos");

            RolIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RolIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RolIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void FechaCreacionDateTime_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            Roles rol = new Roles();
            VentanaBuscar ventana = new VentanaBuscar();
      
            //Igualamos cada objeto grafico de la 2da ventana al valor que queremos que tome
            rol = Buscar(Convert.ToInt32(RolIdTextBox.Text));
            ventana.DescripcionTextBox.Text = rol.Descripcion;
            ventana.RolIdTextBox.Text = Convert.ToString(rol.RolId);
            ventana.fechaCreacionDateTime.Value = rol.FechaCreacion;
            ventana.Show();

        }
    }
}
