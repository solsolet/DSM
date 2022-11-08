
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_LinPed_verContenidoPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class LinPedCEN
{
public void VerContenidoPedido (int p_oid, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_LinPed_verContenidoPedido) ENABLED START*/

        // Write here your custom code...
        PedidoEN ped = _IPedidoCAD.DameporOID (pedido);

        Console.WriteLine ("id: " + ped.id);
        throw new NotImplementedException ("Method VerContenidoPedido() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
