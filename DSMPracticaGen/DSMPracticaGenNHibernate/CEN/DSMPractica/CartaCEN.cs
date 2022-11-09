

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMPracticaGenNHibernate.Exceptions;

using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.CAD.DSMPractica;


namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
/*
 *      Definition of the class CartaCEN
 *
 */
public partial class CartaCEN
{
private ICartaCAD _ICartaCAD;

public CartaCEN()
{
        this._ICartaCAD = new CartaCAD ();
}

public CartaCEN(ICartaCAD _ICartaCAD)
{
        this._ICartaCAD = _ICartaCAD;
}

public ICartaCAD get_ICartaCAD ()
{
        return this._ICartaCAD;
}

public int New_ (DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum p_tipo, string p_linkterminos, string p_linkcarta)
{
        CartaEN cartaEN = null;
        int oid;

        //Initialized CartaEN
        cartaEN = new CartaEN ();
        cartaEN.Tipo = p_tipo;

        cartaEN.Linkterminos = p_linkterminos;

        cartaEN.Linkcarta = p_linkcarta;

        //Call to CartaCAD

        oid = _ICartaCAD.New_ (cartaEN);
        return oid;
}

public void Modify (int p_Carta_OID, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum p_tipo, string p_linkterminos, string p_linkcarta)
{
        CartaEN cartaEN = null;

        //Initialized CartaEN
        cartaEN = new CartaEN ();
        cartaEN.Id = p_Carta_OID;
        cartaEN.Tipo = p_tipo;
        cartaEN.Linkterminos = p_linkterminos;
        cartaEN.Linkcarta = p_linkcarta;
        //Call to CartaCAD

        _ICartaCAD.Modify (cartaEN);
}

public void Destroy (int id
                     )
{
        _ICartaCAD.Destroy (id);
}

public CartaEN ReadOID (int id
                        )
{
        CartaEN cartaEN = null;

        cartaEN = _ICartaCAD.ReadOID (id);
        return cartaEN;
}

public System.Collections.Generic.IList<CartaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CartaEN> list = null;

        list = _ICartaCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> FiltrarCarta (int ? p_tCarta)
{
        return _ICartaCAD.FiltrarCarta (p_tCarta);
}
}
}
