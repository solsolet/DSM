
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
        OfertasCAD ofertasCAD = new OfertasCAD ();
        OfertasEN sale = ofertasCAD.ReadOID (p_oid);

        Console.WriteLine ("Puntos: " + sale.Puntos);



        /*PROTECTED REGION END*/
}
}
}
