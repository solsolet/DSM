
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


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_Producto_getCategoria) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class ProductoCEN
{
public DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoCategoriaEnum GetCategoria (string p_oid)
{
        /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_Producto_getCategoria) ENABLED START*/

        ProductoEN prod = _IProductoCAD.ReadOIDDefault (p_oid);

        return prod.Categoria;

        /*PROTECTED REGION END*/
}
}
}
