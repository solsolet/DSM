
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Ofertas_aplicarDescuento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class OfertasCEN
{
public void AplicarDescuento (int p_oid)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Ofertas_aplicarDescuento) ENABLED START*/

        OfertaEN sale = _IOfertaCAD.DameporOID (p_oid);

        sale.Precio = sale.Precio - sale.Descuento;
        _IOfertaCAD.Modify (sale);

        throw new NotImplementedException ("Method AplicarDescuento() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
