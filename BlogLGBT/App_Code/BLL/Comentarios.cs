using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Comentarios
/// </summary>
namespace BLL
{
    public class Comentarios
{
    public Comentarios()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static long InsertCoemntario(ComentariosInfo info)
    {
        Comentario Comentario = new Comentario();

        Comentario.IdComentario = info.IdComentario;
        Comentario.Texto = info.Texto;
        Comentario.LoginID = info.LoginID;
        Comentario.IdNot = info.IdNot;
        Comentario.Estado = info.Estado;
        Comentario.FechaCreacion = DateTime.Now;




        DataClassesDataContext dc = new DataClassesDataContext();
        dc.Comentario.InsertOnSubmit(Comentario);
        dc.SubmitChanges();
        return Comentario.IdComentario;
    }

}


public class ComentariosInfo
{
    //public long IDItem {get;set}

    public long IdComentario { get; set; }
    public string Texto { get; set; }
    public string LoginID { get; set; }
    public long IdNot { get; set; }
    public bool Estado { get; set; }
    public DateTime FechaCreacion { get; set; }

}
}