using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Consulta
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Grupos, bool>> filtro = x => true;
            int id;
            if (CriteriotextBox.Text == string.Empty && FiltrocomboBox.SelectedIndex != 3)
            {
                MessageBox.Show("Digite el criterio", "Debe introducir el criterio",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            switch (FiltrocomboBox.SelectedIndex)
            {
                case 1://GrupoID
                    id = Convert.ToInt32(CriteriotextBox.Text);

                    filtro = x => x.GrupoID == id && (x.Fecha.Day >= DesdedateTimePicker.Value.Day) && (x.Fecha.Month >= DesdedateTimePicker.Value.Month) && (x.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (x.Fecha.Day <= HastadateTimePicker.Value.Day) && (x.Fecha.Month <= HastadateTimePicker.Value.Month) && (x.Fecha.Year <= HastadateTimePicker.Value.Year);

                    break;

                case 2://Fecha
                    filtro = x => x.Fecha.Equals(CriteriotextBox.Text) && (x.Fecha.Day >= DesdedateTimePicker.Value.Day) && (x.Fecha.Month >= DesdedateTimePicker.Value.Month) && (x.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (x.Fecha.Day <= HastadateTimePicker.Value.Day) && (x.Fecha.Month <= HastadateTimePicker.Value.Month) && (x.Fecha.Year <= HastadateTimePicker.Value.Year);

                    break;


                case 3://Descripcion
                    filtro = x => x.Descripcion.Equals(CriteriotextBox.Text) && (x.Fecha.Day >= DesdedateTimePicker.Value.Day) && (x.Fecha.Month >= DesdedateTimePicker.Value.Month) && (x.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (x.Fecha.Day <= HastadateTimePicker.Value.Day) && (x.Fecha.Month <= HastadateTimePicker.Value.Month) && (x.Fecha.Year <= HastadateTimePicker.Value.Year);

                    break;
                case 6://Todo
                    ConsultadataGridView.DataSource = BLL.GruposBLL.GetList(filtro);
                    break;
            }
            ConsultadataGridView.DataSource = BLL.GruposBLL.GetList(filtro);


        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 6)
            {
                CriteriotextBox.Enabled = false;
            }
            else
                CriteriotextBox.Enabled = true;



        }
    }
 }

        