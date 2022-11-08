
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_LinPed_calcularPrecio) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class LinPedCEN
{
public float CalcularPrecio (int p_oid)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_LinPed_calcularPrecio) ENABLED START*/

        LinPedEN ped = _ILinPedCAD.ReadOIDDefault (p_oid);

        ped.Importe = ped.Importe * ped.Cantidad;

        _ILinPedCAD.Modify (ped);

        return ped.Importe;

        /*PROTECTED REGION END*/
}
}
}
