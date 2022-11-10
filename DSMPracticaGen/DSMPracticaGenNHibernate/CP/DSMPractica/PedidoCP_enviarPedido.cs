
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.CAD.DSMPractica;
using DSMPracticaGenNHibernate.CEN.DSMPractica;



/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CP.DSMPractica_Pedido_enviarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CP.DSMPractica
{
public partial class PedidoCP : BasicCP
{
public string EnviarPedido (int p_oid, Nullable<DateTime> p_fecha)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CP.DSMPractica_Pedido_enviarPedido) ENABLED START*/

        PedidoCEN pedidoCEN = null; //borrable?
        ProductoCEN productoCEN = null;

        string resultado = null; //segun como haya ido la transaccion

        try
        {
                SessionInitializeTransaction ();
                PedidoCAD pedidoCAD = new PedidoCAD (session);
                ProductoCAD productoCAD = new ProductoCAD (session);

                PedidoEN pedido = pedidoCAD.ReadOID (p_oid);

                foreach (LinPedEN l in pedido.Linped) {
                        ProductoEN producto = l.Producto;
                        productoCEN = new ProductoCEN (productoCAD);
                        //productoCEN.ModificarIngredientes(producto.Nombre); //implementarlo
                }
                pedido.Fecha = p_fecha;
                pedido.Estado = Enumerated.DSMPractica.EstadoPedidoEnum.enviado;
                pedidoCAD.Modify (pedido);
                resultado = "bien";
                SessionCommit ();
        }
        catch (Exception ex)
        {
                resultado = "mal";
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                System.Console.WriteLine ("La custom transaction EnviarPedido ha ido " + resultado);
                SessionClose ();
        }
        return resultado;

        /*PROTECTED REGION END*/
}
}
}
