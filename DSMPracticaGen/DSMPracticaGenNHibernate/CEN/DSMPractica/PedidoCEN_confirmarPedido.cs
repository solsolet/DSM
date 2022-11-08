
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Pedido_confirmarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class PedidoCEN
{
public void ConfirmarPedido (int p_oid)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Pedido_confirmarPedido) ENABLED START*/

        PedidoEN car = _IPedidoCAD.DameporOID (p_oid);

        car.Estado = Enumerated.DSMPractica.EstadoPedidoEnum.confirmado;

        _IEstadoCAD.Modify (car);

        throw new NotImplementedException ("Method ConfirmarPedido() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
