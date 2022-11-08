
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IUsuario_RCAD
{
Usuario_REN ReadOIDDefault (string email
                            );

void ModifyDefault (Usuario_REN usuario_R);

System.Collections.Generic.IList<Usuario_REN> ReadAllDefault (int first, int size);



string New_ (Usuario_REN usuario_R);

void Modify (Usuario_REN usuario_R);


void Destroy (string email
              );


Usuario_REN ReadOID (string email
                     );


System.Collections.Generic.IList<Usuario_REN> ReadAll (int first, int size);
}
}
