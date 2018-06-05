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
            Grupos grupos = new Grupos();
            Expression<Func<Grupos, bool>> filtro = x => true;

            int id, c, g;
          
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.GrupoID == id
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 1://Descripcion
                    filtro = x => x.Descripcion.Equals(CriteriotextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 2://Cantidad
                    c = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.Cantidad==c
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 3://grupos
                    g = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.Grupo==g
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 4://integrantes
                    filtro = x => x.integrantes.Equals(CriteriotextBox.Text)
                  && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
            }

            ConsultadataGridView.DataSource = BLL.GruposBLL.GetList(filtro);
        }
    }
}
        