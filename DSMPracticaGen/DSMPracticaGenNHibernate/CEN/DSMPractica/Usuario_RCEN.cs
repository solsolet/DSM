

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMPracticaGenNHibernate.Exceptions;

using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.CAD.DSMPractica;


namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
/*
 *      Definition of the class Usuario_RCEN
 *
 */
public partial class Usuario_RCEN
{
private IUsuario_RCAD _IUsuario_RCAD;

public Usuario_RCEN()
{
        this._IUsuario_RCAD = new Usuario_RCAD ();
}

public Usuario_RCEN(IUsuario_RCAD _IUsuario_RCAD)
{
        this._IUsuario_RCAD = _IUsuario_RCAD;
}

public IUsuario_RCAD get_IUsuario_RCAD ()
{
        return this._IUsuario_RCAD;
}

public string New_ (string p_email, string p_direccion, int p_tarjeta, string p_nombre, string p_apellidos, String p_psw, int p_telefono)
{
        Usuario_REN usuario_REN = null;
        string oid;

        //Initialized Usuario_REN
        usuario_REN = new Usuario_REN ();
        usuario_REN.Email = p_email;

        usuario_REN.Direccion = p_direccion;

        usuario_REN.Tarjeta = p_tarjeta;

        usuario_REN.Nombre = p_nombre;

        usuario_REN.Apellidos = p_apellidos;

        usuario_REN.Psw = Utils.Util.GetEncondeMD5 (p_psw);

        usuario_REN.Telefono = p_telefono;

        //Call to Usuario_RCAD

        oid = _IUsuario_RCAD.New_ (usuario_REN);
        return oid;
}

public void Modify (string p_Usuario_R_OID, string p_direccion, int p_tarjeta, string p_nombre, string p_apellidos, String p_psw, int p_telefono)
{
        Usuario_REN usuario_REN = null;

        //Initialized Usuario_REN
        usuario_REN = new Usuario_REN ();
        usuario_REN.Email = p_Usuario_R_OID;
        usuario_REN.Direccion = p_direccion;
        usuario_REN.Tarjeta = p_tarjeta;
        usuario_REN.Nombre = p_nombre;
        usuario_REN.Apellidos = p_apellidos;
        usuario_REN.Psw = Utils.Util.GetEncondeMD5 (p_psw);
        usuario_REN.Telefono = p_telefono;
        //Call to Usuario_RCAD

        _IUsuario_RCAD.Modify (usuario_REN);
}

public void Destroy (string email
                     )
{
        _IUsuario_RCAD.Destroy (email);
}

public Usuario_REN ReadOID (string email
                            )
{
        Usuario_REN usuario_REN = null;

        usuario_REN = _IUsuario_RCAD.ReadOID (email);
        return usuario_REN;
}

public System.Collections.Generic.IList<Usuario_REN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<Usuario_REN> list = null;

        list = _IUsuario_RCAD.ReadAll (first, size);
        return list;
}
}
}
