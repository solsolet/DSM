
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Pedido_verCliente) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class PedidoCEN
{
public void VerCliente (int p_oid)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Pedido_verCliente) ENABLED START*/

        // Write here your custom code...
        PedidoEN car = _IPedidoCAD.DameporOID (p_oid);

        Console.WriteLine ("Cliente: " + car.Cliente);
        throw new NotImplementedException ("Method VerCliente() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
