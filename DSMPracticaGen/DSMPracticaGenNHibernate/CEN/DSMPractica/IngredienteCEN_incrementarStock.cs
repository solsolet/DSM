
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Ingrediente_incrementarStock) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class IngredienteCEN
{
public void IncrementarStock (string p_oid, int p_cantidad)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Ingrediente_incrementarStock) ENABLED START*/

        IngredienteEN ing = _IIngredienteCAD.ReadOIDDefault (p_oid);

        ing.Stock += p_cantidad;
        _IIngredienteCAD.ModifyDefault (ing);

        /*PROTECTED REGION END*/
}
}
}
