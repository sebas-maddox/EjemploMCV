using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Asociaciones
/// </summary>
namespace BLL
{
    public class Asociaciones
{
    public Asociaciones()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static long InsertAsociacion(AsociacionesInfo info)
    {
        Asociacion Asociacion = new Asociacion();

        Asociacion.IdAsociacion = info.IdAsociacion;
        Asociacion.Nombre = info.Nombre;
        Asociacion.Ubicacion = info.Ubicacion;
        Asociacion.Lider = info.Lider;
        Asociacion.Telefono = info.Telefono;
        Asociacion.Correo = info.Correo;




        DataClassesDataContext dc = new DataClassesDataContext();
        dc.Asociacion.InsertOnSubmit(Asociacion);
        dc.SubmitChanges();
        return Asociacion.IdAsociacion;
    }

}


public class AsociacionesInfo
{
    //public long IDItem {get;set}

    public long IdAsociacion { get; set; }
    public string Nombre { get; set; }
    public string Ubicacion { get; set; }
    public string Lider { get; set; }
    public long Telefono { get; set; }
    public string Correo { get; set; }


}
}