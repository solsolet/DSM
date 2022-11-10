
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMPracticaGenNHibernate.Exceptions;
using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.CAD.DSMPractica;


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Pedido_entregarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class PedidoCEN
{
public void EntregarPedido (int p_oid)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Pedido_entregarPedido) ENABLED START*/

        // Write here your custom code...
        PedidoCAD pedidoCAD = new PedidoCAD ();
        PedidoEN car = pedidoCAD.ReadOID (p_oid);

        car.Estado = Enumerated.DSMPractica.EstadoPedidoEnum.entregado;

        pedidoCAD.Modify (car);

        /*PROTECTED REGION END*/
}
}
}
