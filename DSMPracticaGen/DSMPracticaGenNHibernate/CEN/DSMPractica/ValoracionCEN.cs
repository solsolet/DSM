

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

public int New_ (int p_puntuacion, string p_descripcion, int p_pedido, int p_usuario_0)
{
        ValoracionEN valoracionEN = null;
        int oid;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Puntuacion = p_puntuacion;

        valoracionEN.Descripcion = p_descripcion;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                valoracionEN.Pedido = new DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN ();
                valoracionEN.Pedido.Id = p_pedido;
        }


        if (p_usuario_0 != -1) {
                // El argumento p_usuario_0 -> Property usuario_0 es oid = false
                // Lista de oids id
                valoracionEN.Usuario_0 = new DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN ();
                valoracionEN.Usuario_0.Id = p_usuario_0;
        }

        //Call to ValoracionCAD

        oid = _IValoracionCAD.New_ (valoracionEN);
        return oid;
}

public void Modify (int p_Valoracion_OID, int p_puntuacion, string p_descripcion)
{
        ValoracionEN valoracionEN = null;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Id = p_Valoracion_OID;
        valoracionEN.Puntuacion = p_puntuacion;
        valoracionEN.Descripcion = p_descripcion;
        //Call to ValoracionCAD

        _IValoracionCAD.Modify (valoracionEN);
}

public void Destroy (int id
                     )
{
        _IValoracionCAD.Destroy (id);
}

public ValoracionEN ReadOID (int id
                             )
{
        ValoracionEN valoracionEN = null;

        valoracionEN = _IValoracionCAD.ReadOID (id);
        return valoracionEN;
}

public System.Collections.Generic.IList<ValoracionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> list = null;

        list = _IValoracionCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> FiltrarPuntuación ()
{
        return _IValoracionCAD.FiltrarPuntuación ();
}
}
}
