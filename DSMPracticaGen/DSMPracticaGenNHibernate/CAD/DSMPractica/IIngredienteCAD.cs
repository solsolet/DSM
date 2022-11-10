
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IIngredienteCAD
{
IngredienteEN ReadOIDDefault (int id
                              );

void ModifyDefault (IngredienteEN ingrediente);

System.Collections.Generic.IList<IngredienteEN> ReadAllDefault (int first, int size);



int New_ (IngredienteEN ingrediente);

void Modify (IngredienteEN ingrediente);


void Destroy (int id
              );


IngredienteEN ReadOID (int id
                       );


System.Collections.Generic.IList<IngredienteEN> ReadAll (int first, int size);


System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> FiltrarComida (int ? p_tComida);
}
}
