
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IValoracionCAD
{
ValoracionEN ReadOIDDefault (int puntuacion
                             );

void ModifyDefault (ValoracionEN valoracion);

System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size);



int New_ (ValoracionEN valoracion);

void Modify (ValoracionEN valoracion);


void Destroy (int puntuacion
              );


ValoracionEN ReadOID (int puntuacion
                      );


System.Collections.Generic.IList<ValoracionEN> ReadAll (int first, int size);
}
}
