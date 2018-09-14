using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Eventos
/// </summary>
namespace BLL
{
    public class Eventos
{
    public Eventos()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static long InsertEvento(EventosInfo info)
    {
        Evento Evento = new Evento();

        Evento.IdEvento = info.IdEvento;
        Evento.Nombre = info.Nombre;
        Evento.Fecha = info.Fecha;
        Evento.Lugar = info.Lugar;





        DataClassesDataContext dc = new DataClassesDataContext();
        dc.Evento.InsertOnSubmit(Evento);
        dc.SubmitChanges();
        return Evento.IdEvento;
    }

}


public class EventosInfo
{
    //public long IDItem {get;set}

    public long IdEvento { get; set; }
    public string Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public string Lugar { get; set; }


}
}