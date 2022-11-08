
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Ofertas_verDetalledeOferta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class OfertasCEN
{
public void VerDetalledeOferta (int p_oid)
{
            /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Ofertas_verDetalledeOferta) ENABLED START*/
            OfertaEN sale = _IOfertaCAD.DameporOID(p_oid);
            Console.WriteLine("Precio: " + sale.Precio);
            Console.WriteLine("Descuento: " + sale.Descuento);
            Console.WriteLine("Puntos: " + sale.Puntos);

            throw new NotImplementedException ("Method VerDetalledeOferta() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
