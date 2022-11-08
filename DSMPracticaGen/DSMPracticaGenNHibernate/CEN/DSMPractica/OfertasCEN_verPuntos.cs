
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Ofertas_verPuntos) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class OfertasCEN
{
public void VerPuntos (int p_oid)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Ofertas_verPuntos) ENABLED START*/

        OfertaEN sale = _IOfertaCAD.DameporOID (p_oid);

        Console.WriteLine ("Puntos: " + sale.Puntos);

        throw new NotImplementedException ("Method VerPuntos() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
