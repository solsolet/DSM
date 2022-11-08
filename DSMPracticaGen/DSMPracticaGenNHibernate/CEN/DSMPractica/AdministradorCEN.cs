

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
 *      Definition of the class AdministradorCEN
 *
 */
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public string New_ (string p_nombre, String p_pass)
{
        AdministradorEN administradorEN = null;
        string oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Nombre = p_nombre;

        administradorEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.New_ (administradorEN);
        return oid;
}

public void Modify (string p_Administrador_OID)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Nombre = p_Administrador_OID;
        //Call to AdministradorCAD

        _IAdministradorCAD.Modify (administradorEN);
}

public void Destroy (string nombre
                     )
{
        _IAdministradorCAD.Destroy (nombre);
}

public AdministradorEN ReadOID (string nombre
                                )
{
        AdministradorEN administradorEN = null;

        administradorEN = _IAdministradorCAD.ReadOID (nombre);
        return administradorEN;
}

public System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministradorEN> list = null;

        list = _IAdministradorCAD.ReadAll (first, size);
        return list;
}
public string Login (string p_Administrador_OID, string p_pass)
{
        string result = null;
        AdministradorEN en = _IAdministradorCAD.ReadOIDDefault (p_Administrador_OID);

        if (en != null && en.Pass.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en.Nombre);

        return result;
}




private string Encode (string nombre)
{
        var payload = new Dictionary<string, object>(){
                { "nombre", nombre }
        };
        string token = Jose.JWT.Encode (payload, Utils.Util.getKey (), Jose.JwsAlgorithm.HS256);

        return token;
}

public string GetToken (string nombre)
{
        AdministradorEN en = _IAdministradorCAD.ReadOIDDefault (nombre);
        string token = Encode (en.Nombre);

        return token;
}
public string CheckToken (string token)
{
        string result = null;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                string id = (string)ObtenerNOMBRE (decodedToken);

                AdministradorEN en = _IAdministradorCAD.ReadOIDDefault (id);

                if (en != null && ((string)en.Nombre).Equals (ObtenerNOMBRE (decodedToken))
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


public string ObtenerNOMBRE (string decodedToken)
{
        try
        {
                Dictionary<string, object> results = JsonConvert.DeserializeObject<Dictionary<string, object> >(decodedToken);
                string nombre = (string)results ["nombre"];
                return nombre;
        }
        catch
        {
                throw new Exception ("El token enviado no es correcto");
        }
}
}
}
