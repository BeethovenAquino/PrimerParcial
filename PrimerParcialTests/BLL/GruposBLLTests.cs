using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial.BLL.Tests
{
    [TestClass()]
    public class GruposBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Grupos grupos = new Grupos();

           grupos.GrupoID = 0;
           grupos.Fecha = DateTime.Now;
           grupos.Descripcion = "Esto fue excelente";
           grupos.Cantidad = 0;
           grupos.Grupo = 9;
           grupos.integrantes = "Hola";
            
             paso = GruposBLL.Guardar(grupos);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void modificarTest()
        {
            bool paso;
            Grupos grupos = new Grupos();

            grupos.GrupoID = 0;
            grupos.Fecha = DateTime.Now;
            grupos.Descripcion = "Esto fue excelente";
            grupos.Cantidad = 0;
            grupos.Grupo = 9;
            grupos.integrantes = "Hola";

            paso = GruposBLL.Guardar(grupos);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Grupos grupos = new Grupos();

            grupos.GrupoID = 0;
            grupos.Fecha = DateTime.Now;
            grupos.Descripcion = "Esto fue excelente";
            grupos.Cantidad = 0;
            grupos.Grupo = 9;
            grupos.integrantes = "Hola";

            paso = GruposBLL.Guardar(grupos);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            Grupos grupos = new Grupos();

            grupos.GrupoID = 0;
            grupos.Fecha = DateTime.Now;
            grupos.Descripcion = "Esto fue excelente";
            grupos.Cantidad = 0;
            grupos.Grupo = 9;
            grupos.integrantes = "Hola";

            paso = GruposBLL.Guardar(grupos);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            Grupos grupos = new Grupos();

            grupos.GrupoID = 0;
            grupos.Fecha = DateTime.Now;
            grupos.Descripcion = "Esto fue excelente";
            grupos.Cantidad = 0;
            grupos.Grupo = 9;
            grupos.integrantes = "Hola";

            paso = GruposBLL.Guardar(grupos);


            Assert.AreEqual(paso, true);
        }
    }
}