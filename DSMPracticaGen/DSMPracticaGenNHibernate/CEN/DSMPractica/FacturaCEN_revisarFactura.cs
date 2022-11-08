
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Factura_revisarFactura) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class FacturaCEN
{
public void RevisarFactura (int p_oid)
{
            /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Factura_revisarFactura) ENABLED START*/

            FacturaEN fact = _IFacturaCAD.DameporOID(p_oid);

            if (fact.EsRevisada) throw new ModelException("Ya esta revisada");

            fact.EsRevisada = true;

            _IFacturaCAD.Modify(fact);

            throw new NotImplementedException ("Method RevisarFactura() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
