using CadParcial2Krba;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2Krba
{
    public class CategoriaProgramaCln
    {
        public static List<CategoriaPrograma> listar()
        {
            using (var context = new Parcial2KrbaEntities())
            {
                return context.CategoriaPrograma
                    .Where(x => x.estado == 1)
                    .OrderBy(x => x.nombre)
                    .ToList();
            }
        }
    }
}
