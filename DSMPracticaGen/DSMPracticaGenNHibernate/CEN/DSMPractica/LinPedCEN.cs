

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
 *      Definition of the class LinPedCEN
 *
 */
public partial class LinPedCEN
{
private ILinPedCAD _ILinPedCAD;

public LinPedCEN()
{
        this._ILinPedCAD = new LinPedCAD ();
}

public LinPedCEN(ILinPedCAD _ILinPedCAD)
{
        this._ILinPedCAD = _ILinPedCAD;
}

public ILinPedCAD get_ILinPedCAD ()
{
        return this._ILinPedCAD;
}

public int New_ (int p_producto, int p_pedido, int p_cantidad, float p_importe)
{
        LinPedEN linPedEN = null;
        int oid;

        //Initialized LinPedEN
        linPedEN = new LinPedEN ();

        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids linea
                linPedEN.Producto = new DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN ();
                linPedEN.Producto.Id = p_producto;
        }


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids linea
                linPedEN.Pedido = new DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN ();
                linPedEN.Pedido.Id = p_pedido;
        }

        linPedEN.Cantidad = p_cantidad;

        linPedEN.Importe = p_importe;

        //Call to LinPedCAD

        oid = _ILinPedCAD.New_ (linPedEN);
        return oid;
}

public void Modify (int p_LinPed_OID, int p_cantidad, float p_importe)
{
        LinPedEN linPedEN = null;

        //Initialized LinPedEN
        linPedEN = new LinPedEN ();
        linPedEN.Linea = p_LinPed_OID;
        linPedEN.Cantidad = p_cantidad;
        linPedEN.Importe = p_importe;
        //Call to LinPedCAD

        _ILinPedCAD.Modify (linPedEN);
}

public void Destroy (int linea
                     )
{
        _ILinPedCAD.Destroy (linea);
}

public LinPedEN ReadOID (int linea
                         )
{
        LinPedEN linPedEN = null;

        linPedEN = _ILinPedCAD.ReadOID (linea);
        return linPedEN;
}

public System.Collections.Generic.IList<LinPedEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LinPedEN> list = null;

        list = _ILinPedCAD.ReadAll (first, size);
        return list;
}
}
}
