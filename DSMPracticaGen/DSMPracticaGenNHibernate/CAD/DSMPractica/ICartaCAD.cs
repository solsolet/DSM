
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface ICartaCAD
{
CartaEN ReadOIDDefault (int id
                        );

void ModifyDefault (CartaEN carta);

System.Collections.Generic.IList<CartaEN> ReadAllDefault (int first, int size);



int New_ (CartaEN carta);

void Modify (CartaEN carta);


void Destroy (int id
              );


CartaEN ReadOID (int id
                 );


System.Collections.Generic.IList<CartaEN> ReadAll (int first, int size);
}
}
