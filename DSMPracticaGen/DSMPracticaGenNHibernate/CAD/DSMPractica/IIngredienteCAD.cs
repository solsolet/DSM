
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IIngredienteCAD
{
IngredienteEN ReadOIDDefault (string nombre
                              );

void ModifyDefault (IngredienteEN ingrediente);

System.Collections.Generic.IList<IngredienteEN> ReadAllDefault (int first, int size);



string New_ (IngredienteEN ingrediente);

void Modify (IngredienteEN ingrediente);


void Destroy (string nombre
              );


IngredienteEN ReadOID (string nombre
                       );


System.Collections.Generic.IList<IngredienteEN> ReadAll (int first, int size);


System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> FiltrarComida (int ? p_tIng);
}
}
