
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Producto_getIngredientes) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class ProductoCEN
{
public System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> GetIngredientes (int p_oid, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> listIng)
{
            /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Producto_getIngredientes) ENABLED START*/

            // Write here your custom code...
            ProductoEN prodEN = _IProductoCAD.ReadOIDDefault(p_oid);

            IngredienteCAD ingCAD = new IngredienteCAD();
            IngredienteEN ingEN = ingCAD.ReadOIDDefault(p_oid);


            throw new NotImplementedException ("Method GetIngredientes() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
