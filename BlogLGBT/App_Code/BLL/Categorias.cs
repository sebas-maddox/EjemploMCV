using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Categorias
/// </summary>
namespace BLL
{
    public class Categorias
{
    public Categorias()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static long InsertCategoria(CategoriasInfo info)
    {
        Categoria Categoria = new Categoria();

        Categoria.IdCategoria = info.IdCategoria;
        Categoria.Nombre = info.Nombre;





        DataClassesDataContext dc = new DataClassesDataContext();
        dc.Categoria.InsertOnSubmit(Categoria);
        dc.SubmitChanges();
        return Categoria.IdCategoria;
    }

}


public class CategoriasInfo
{
    //public long IDItem {get;set}

    public long IdCategoria { get; set; }
    public string Nombre { get; set; }



}
}