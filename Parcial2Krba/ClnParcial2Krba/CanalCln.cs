using CadParcial2Krba;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2Krba
{
    public class CanalCln
    {
        public static List<Canal> listar()
        {
            using (var context = new Parcial2KrbaEntities())
            {
                return context.Canal
                    .Where(x => x.estado == 1)
                    .OrderBy(x => x.nombre)
                    .ToList();
            }
        }
    }
}