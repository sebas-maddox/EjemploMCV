using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Mensajes
/// </summary>
namespace BLL
{
    public class Mensajes
{
    public Mensajes()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static long InsertMensaje(MensajesInfo info)
    {
        Mensaje Mensaje = new Mensaje();

        Mensaje.IdMensaje = info.IdMensaje;
        Mensaje.IdUsuarioEnv = info.IdUsuarioEnv;
        Mensaje.IdUsuarioRec = info.IdUsuarioRec;
        Mensaje.Texto = info.Texto;





        DataClassesDataContext dc = new DataClassesDataContext();
        dc.Mensaje.InsertOnSubmit(Mensaje);
        dc.SubmitChanges();
        return Mensaje.IdMensaje;
    }

}


public class MensajesInfo
{
    //public long IDItem {get;set}

    public long IdMensaje { get; set; }
    public string IdUsuarioEnv { get; set; }
    public string IdUsuarioRec { get; set; }
    public string Texto { get; set; }


}
}