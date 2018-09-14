using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Usuarios
/// </summary>
namespace BLL
{
    public class Usuarios
{
    public Usuarios()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static string InsertUsuario(UsuariosInfo info)
    {
        Usuario Usuario = new Usuario();

        Usuario.LoginID = info.LoginID;
        Usuario.Contra = info.Contra;
        Usuario.Nombre = info.Nombre;
        Usuario.Email = info.Email;
        Usuario.Tipo = info.Tipo;
        Usuario.Administrador = info.Administrador;




        DataClassesDataContext dc = new DataClassesDataContext();
        dc.Usuario.InsertOnSubmit(Usuario);
        dc.SubmitChanges();
        return Usuario.LoginID;
    }

}


public class UsuariosInfo
{
    //public long IDItem {get;set}

    public string LoginID { get; set; }
    public string Contra { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Tipo { get; set; }
    public bool Administrador { get; set; }


}
}