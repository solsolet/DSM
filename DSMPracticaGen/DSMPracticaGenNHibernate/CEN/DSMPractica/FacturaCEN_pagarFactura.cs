
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Factura_pagarFactura) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class FacturaCEN
{
public void PagarFactura (int p_oid, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN ped)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Factura_pagarFactura) ENABLED START*/

        FacturaEN fact = _IFacturaCAD.ReadOIDDefault (p_oid);

        if (fact.EsPagada) throw new ModelException ("Ya esta pagada");

        if (ped.Estado == Enumerated.DSMPractica.EstadoPedidoEnum.confirmado) {
                fact.EsPagada = true;
                _IFacturaCAD.ModifyDefault (fact);
        }

        /*PROTECTED REGION END*/
}
}
}
