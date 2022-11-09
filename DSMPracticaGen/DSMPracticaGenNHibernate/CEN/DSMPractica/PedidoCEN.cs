

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
 *      Definition of the class PedidoCEN
 *
 */
public partial class PedidoCEN
{
private IPedidoCAD _IPedidoCAD;

public PedidoCEN()
{
        this._IPedidoCAD = new PedidoCAD ();
}

public PedidoCEN(IPedidoCAD _IPedidoCAD)
{
        this._IPedidoCAD = _IPedidoCAD;
}

public IPedidoCAD get_IPedidoCAD ()
{
        return this._IPedidoCAD;
}

public int New_ (string p_direntrega, Nullable<DateTime> p_horamaxima, string p_cliente, float p_precio, string p_usuario, DSMPracticaGenNHibernate.Enumerated.DSMPractica.EstadoPedidoEnum p_estado, Nullable<DateTime> p_fecha, System.Collections.Generic.IList<int> p_notificacion)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Direntrega = p_direntrega;

        pedidoEN.Horamaxima = p_horamaxima;

        pedidoEN.Cliente = p_cliente;

        pedidoEN.Precio = p_precio;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                pedidoEN.Usuario = new DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN ();
                pedidoEN.Usuario.Email = p_usuario;
        }

        pedidoEN.Estado = p_estado;

        pedidoEN.Fecha = p_fecha;


        pedidoEN.Notificacion = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN>();
        if (p_notificacion != null) {
                foreach (int item in p_notificacion) {
                        DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN en = new DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN ();
                        en.Id = item;
                        pedidoEN.Notificacion.Add (en);
                }
        }

        else{
                pedidoEN.Notificacion = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN>();
        }

        //Call to PedidoCAD

        oid = _IPedidoCAD.New_ (pedidoEN);
        return oid;
}

public void Modify (int p_Pedido_OID, string p_direntrega, Nullable<DateTime> p_horamaxima, string p_cliente, float p_precio, DSMPracticaGenNHibernate.Enumerated.DSMPractica.EstadoPedidoEnum p_estado, Nullable<DateTime> p_fecha)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.Direntrega = p_direntrega;
        pedidoEN.Horamaxima = p_horamaxima;
        pedidoEN.Cliente = p_cliente;
        pedidoEN.Precio = p_precio;
        pedidoEN.Estado = p_estado;
        pedidoEN.Fecha = p_fecha;
        //Call to PedidoCAD

        _IPedidoCAD.Modify (pedidoEN);
}

public void Destroy (int id
                     )
{
        _IPedidoCAD.Destroy (id);
}

public PedidoEN ReadOID (int id
                         )
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoCAD.ReadOID (id);
        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> list = null;

        list = _IPedidoCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> PedidoporProducto (DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN p_nomProducto)
{
        return _IPedidoCAD.PedidoporProducto (p_nomProducto);
}
}
}
