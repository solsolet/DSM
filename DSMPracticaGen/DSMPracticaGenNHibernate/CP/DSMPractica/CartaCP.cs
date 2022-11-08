
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using DSMPracticaGenNHibernate.Exceptions;
using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.CAD.DSMPractica;
using DSMPracticaGenNHibernate.CEN.DSMPractica;



namespace DSMPracticaGenNHibernate.CP.DSMPractica
{
public partial class CartaCP : BasicCP
{
public CartaCP() : base ()
{
}

public CartaCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
