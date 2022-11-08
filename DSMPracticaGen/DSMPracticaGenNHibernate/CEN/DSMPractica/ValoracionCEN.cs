

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
 *      Definition of the class ValoracionCEN
 *
 */
public partial class ValoracionCEN
{
private IValoracionCAD _IValoracionCAD;

public ValoracionCEN()
{
        this._IValoracionCAD = new ValoracionCAD ();
}

public ValoracionCEN(IValoracionCAD _IValoracionCAD)
{
        this._IValoracionCAD = _IValoracionCAD;
}

public IValoracionCAD get_IValoracionCAD ()
{
        return this._IValoracionCAD;
}

public int New_ (int p_puntuacion, string p_descripcion, string p_usuario, int p_pedido)
{
        ValoracionEN valoracionEN = null;
        int oid;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Puntuacion = p_puntuacion;

        valoracionEN.Descripcion = p_descripcion;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids puntuacion
                valoracionEN.Usuario = new DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN ();
                valoracionEN.Usuario.Email = p_usuario;
        }


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids puntuacion
                valoracionEN.Pedido = new DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN ();
                valoracionEN.Pedido.Id = p_pedido;
        }

        //Call to ValoracionCAD

        oid = _IValoracionCAD.New_ (valoracionEN);
        return oid;
}

public void Modify (int p_Valoracion_OID, string p_descripcion)
{
        ValoracionEN valoracionEN = null;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Puntuacion = p_Valoracion_OID;
        valoracionEN.Descripcion = p_descripcion;
        //Call to ValoracionCAD

        _IValoracionCAD.Modify (valoracionEN);
}

public void Destroy (int puntuacion
                     )
{
        _IValoracionCAD.Destroy (puntuacion);
}

public ValoracionEN ReadOID (int puntuacion
                             )
{
        ValoracionEN valoracionEN = null;

        valoracionEN = _IValoracionCAD.ReadOID (puntuacion);
        return valoracionEN;
}

public System.Collections.Generic.IList<ValoracionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> list = null;

        list = _IValoracionCAD.ReadAll (first, size);
        return list;
}
}
}