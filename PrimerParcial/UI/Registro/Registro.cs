using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Registro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

       public bool validar(int Negar)
        {
            bool paso = false;
            if (Negar == 1 && grupoIDNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(grupoIDNumericUpDown, "Ingrese un ID");
                paso = true;
            }
            if (Negar == 2 && descripcionTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Ingrese una Descripcion");
                paso = true;
            }
            if (Negar == 3 && cantidadNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(cantidadNumericUpDown, "Ingrese la cantidad");
                paso = true;
            }
            if (Negar == 2 && grupoIDNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(grupoNumericUpDown, "Ingrese El grupo");
                paso = true;
            }
            if (Negar == 2 && integrantesTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(integrantesTextBox, "Ingrese los integrantes");
                paso = true;
            }
            return paso;
        

        }

        private Grupos LlenaClase() {
            Grupos grupos = new Grupos();
            grupos.GrupoID = Convert.ToInt32(grupoIDNumericUpDown.Value);
            grupos.Fecha = fechaDateTimePicker.Value;
            grupos.Descripcion = descripcionTextBox.Text;
            grupos.Cantidad = Convert.ToInt32(cantidadNumericUpDown.Value);

            return grupos;

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            grupoIDNumericUpDown.Value = 0;
            descripcionTextBox.Clear();
            cantidadNumericUpDown.Value = 0;
            grupoNumericUpDown.Value = 0;
            integrantesTextBox.Clear();
            errorProvider1.Clear();

            
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            if (validar(3)) {
                MessageBox.Show("llene los campos", "Llene", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Grupos grupos = LlenaClase();
                bool paso = false;


                if (grupoIDNumericUpDown.Value == 0)
                {
                    paso = BLL.GruposBLL.Guardar(grupos);
                }
                else
                {
                    BLL.GruposBLL.modificar(LlenaClase());
                }
                if (paso) {

                    MessageBox.Show("Guardado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grupoIDNumericUpDown.Value = 0;
                    descripcionTextBox.Clear();
                    cantidadNumericUpDown.Value = 0;
                    grupoNumericUpDown.Value = 0;
                    integrantesTextBox.Clear();
                    errorProvider1.Clear();
                }

                else
                {
                    MessageBox.Show("No se ha Guardado", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }

           
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("El tipo ID esta vacio", "Llene ese campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else {

                int id = Convert.ToInt32(grupoIDNumericUpDown.Value);
                if (BLL.GruposBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grupoIDNumericUpDown.Value = 0;
                    fechaDateTimePicker.Value = DateTime.Now;
                    descripcionTextBox.Clear();
                    cantidadNumericUpDown.Value = 0;
                    grupoNumericUpDown.Value = 0;
                    integrantesTextBox.Clear();
                    errorProvider1.Clear();
                }
                else {
                    MessageBox.Show("No Eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           

            int id = Convert.ToInt32(grupoIDNumericUpDown.Value);
            Grupos grupos = BLL.GruposBLL.Buscar(id);

            if (grupos!= null)
            {
                grupoIDNumericUpDown.Value = grupos.GrupoID;
                fechaDateTimePicker.Value = grupos.Fecha;
                descripcionTextBox.Text = grupos.Descripcion;
               cantidadNumericUpDown.Value = grupos.Cantidad;
                grupoNumericUpDown.Value = grupos.Grupo;
                integrantesTextBox.Text = grupos.integrantes;

            }
            else
                MessageBox.Show("No se encontro!", "Intente buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
