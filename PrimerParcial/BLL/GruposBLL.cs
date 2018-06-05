using PrimerParcial.DAL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PrimerParcial.BLL
{
    public class GruposBLL
    {
        public static bool Guardar(Grupos grupos) {
            bool paso = false;
            Contexto contexto = new Contexto();

            try {
                if (contexto.Grupo.Add(grupos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;

                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool modificar(Grupos grupos) {
            bool paso = false;
            Contexto contexto = new Contexto();


            try
            {
                contexto.Entry(grupos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;

                }
                contexto.Dispose();
            }
            catch (Exception)
            { throw; }
            return paso;
        }
        public static bool Eliminar(int id) {

            bool paso = false;
            Contexto contexto = new Contexto();
            Grupos grupos = contexto.Grupo.Find(id);

            try
            {
                if (grupos != null)
                {
                    contexto.Entry(grupos).State = EntityState.Deleted;
                }
                if (contexto.SaveChanges() > 0)
                {
                    contexto.Dispose();
                    paso = true;

                }
                
            }
            catch (Exception)
            { throw; }
            return paso;
        }


        public static Grupos Buscar(int id) {
            Contexto contexto = new Contexto();
            Grupos grupos = new Grupos();

            contexto.Grupo.Find(id);
            contexto.Dispose();

            return grupos;

            
         
        }

        public static List<Grupos> GetList(Expression<Func> Grupos, bool>>expression){
            List<Grupos> grupos = new List<Grupos>();
            Contexto contexto = new Contexto();
            try
            {
                grupos = contexto.Grupo.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) {
                throw;
            }
            return grupos;
        }

    }
       
}


