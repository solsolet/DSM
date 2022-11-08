

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
 *      Definition of the class Usuario_NRCEN
 *
 */
public partial class Usuario_NRCEN
{
private IUsuario_NRCAD _IUsuario_NRCAD;

public Usuario_NRCEN()
{
        this._IUsuario_NRCAD = new Usuario_NRCAD ();
}

public Usuario_NRCEN(IUsuario_NRCAD _IUsuario_NRCAD)
{
        this._IUsuario_NRCAD = _IUsuario_NRCAD;
}

public IUsuario_NRCAD get_IUsuario_NRCAD ()
{
        return this._IUsuario_NRCAD;
}

public string New_ (string p_email, string p_direccion, int p_tarjeta)
{
        Usuario_NREN usuario_NREN = null;
        string oid;

        //Initialized Usuario_NREN
        usuario_NREN = new Usuario_NREN ();
        usuario_NREN.Email = p_email;

        usuario_NREN.Direccion = p_direccion;

        usuario_NREN.Tarjeta = p_tarjeta;

        //Call to Usuario_NRCAD

        oid = _IUsuario_NRCAD.New_ (usuario_NREN);
        return oid;
}

public void Modify (string p_Usuario_NR_OID, string p_direccion, int p_tarjeta)
{
        Usuario_NREN usuario_NREN = null;

        //Initialized Usuario_NREN
        usuario_NREN = new Usuario_NREN ();
        usuario_NREN.Email = p_Usuario_NR_OID;
        usuario_NREN.Direccion = p_direccion;
        usuario_NREN.Tarjeta = p_tarjeta;
        //Call to Usuario_NRCAD

        _IUsuario_NRCAD.Modify (usuario_NREN);
}

public void Destroy (string email
                     )
{
        _IUsuario_NRCAD.Destroy (email);
}

public Usuario_NREN ReadOID (string email
                             )
{
        Usuario_NREN usuario_NREN = null;

        usuario_NREN = _IUsuario_NRCAD.ReadOID (email);
        return usuario_NREN;
}

public System.Collections.Generic.IList<Usuario_NREN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<Usuario_NREN> list = null;

        list = _IUsuario_NRCAD.ReadAll (first, size);
        return list;
}
}
}
