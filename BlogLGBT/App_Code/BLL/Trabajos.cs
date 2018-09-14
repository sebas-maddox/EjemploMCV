using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Trabajo
/// </summary>
namespace BLL
{
    public class Trabajos
{
    public Trabajos()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static long InsertTrabajo(TrabajosInfo info)
    {
        Trabajo Trabajo = new Trabajo();

        Trabajo.IdTrabajo = info.IdTrabajo;
        Trabajo.LoginID = info.LoginID;
        Trabajo.Titulo = info.Titulo;
        Trabajo.Lugar = info.Lugar;
        Trabajo.Descripcion = info.Descripcion;
        Trabajo.FechaPublicacion = DateTime.Now;
        Trabajo.Tipo = info.Tipo;




        DataClassesDataContext dc = new DataClassesDataContext();
        dc.Trabajo.InsertOnSubmit(Trabajo);
        dc.SubmitChanges();
        return Trabajo.IdTrabajo;
    }

}


public class TrabajosInfo
{
    //public long IDItem {get;set}

    public long IdTrabajo { get; set; }
    public string LoginID { get; set; }
    public string Titulo { get; set; }
    public string Lugar { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public string Tipo { get; set; }


}
}