

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public int New_ (string p_direccion, long p_tarjeta, string p_nombre, string p_apellidos, int p_telefono, int p_puntos, String p_pass, string p_email)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Direccion = p_direccion;

        usuarioEN.Tarjeta = p_tarjeta;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.Puntos = p_puntos;

        usuarioEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        usuarioEN.Email = p_email;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (int p_Usuario_OID, string p_direccion, long p_tarjeta, string p_nombre, string p_apellidos, int p_telefono, int p_puntos, String p_pass, string p_email)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Id = p_Usuario_OID;
        usuarioEN.Direccion = p_direccion;
        usuarioEN.Tarjeta = p_tarjeta;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.Puntos = p_puntos;
        usuarioEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        usuarioEN.Email = p_email;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (int id
                     )
{
        _IUsuarioCAD.Destroy (id);
}

public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ReadOID (id);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ReadAll (first, size);
        return list;
}
public string Login (int p_Usuario_OID, string p_pass)
{
        string result = null;
        UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (p_Usuario_OID);

        if (en != null && en.Pass.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en.Id);

        return result;
}




private string Encode (int id)
{
        var payload = new Dictionary<string, object>(){
                { "id", id }
        };
        string token = Jose.JWT.Encode (payload, Utils.Util.getKey (), Jose.JwsAlgorithm.HS256);

        return token;
}

public string GetToken (int id)
{
        UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (id);
        string token = Encode (en.Id);

        return token;
}
public int CheckToken (string token)
{
        int result = -1;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                int id = (int)ObtenerID (decodedToken);

                UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (id);

                if (en != null && ((long)en.Id).Equals (ObtenerID (decodedToken))
                    ) {
                        result = id;
                }
                else throw new ModelException ("El token es incorrecto");
        } catch (Exception e)
        {
                throw new ModelException ("El token es incorrecto");
        }

        return result;
}


public long ObtenerID (string decodedToken)
{
        try
        {
                Dictionary<string, object> results = JsonConvert.DeserializeObject<Dictionary<string, object> >(decodedToken);
                long id = (long)results ["id"];
                return id;
        }
        catch
        {
                throw new Exception ("El token enviado no es correcto");
        }
}
}
}
