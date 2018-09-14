using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Noticias
/// </summary>

namespace BLL
{
    public class Noticias
    {
         public Noticias()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
        public static long InsertNoticia(NoticiasInfo info)
        {
            Noticia Noticia = new Noticia();

            Noticia.IdNot = info.IdNot;
            Noticia.Titulo = info.Titulo;
            Noticia.Cuerpo = info.Cuerpo;
            Noticia.LoginID = info.LoginID;
            Noticia.IdCategoria = info.IdCategoria;
            Noticia.FechaPublicacion = DateTime.Now;




            DataClassesDataContext dc = new DataClassesDataContext();
            dc.Noticia.InsertOnSubmit(Noticia);
            dc.SubmitChanges();
            return Noticia.IdNot;
        }

    }

   
    public class NoticiasInfo
    {
        //public long IDItem {get;set}

        public long IdNot { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public long LoginID { get; set; }
        public long IdCategoria { get; set; }
        public DateTime FechaPublicacion { get; set; }
        

    }

}