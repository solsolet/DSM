
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (int id
                           );

void ModifyDefault (ProductoEN producto);

System.Collections.Generic.IList<ProductoEN> ReadAllDefault (int first, int size);



int New_ (ProductoEN producto);

void Modify (ProductoEN producto);


void Destroy (int id
              );


ProductoEN ReadOID (int id
                    );


System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size);



System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> FiltrarCategoria (int ? p_categoria);


System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> FiltrarPrecio (float ? precio);


void AsignarCarta (int p_Producto_OID, System.Collections.Generic.IList<int> p_carta_OIDs);
}
}
