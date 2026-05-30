using CadParcial2Krba;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2Krba
{
    public class ProgamaCln
    {
        public static int crear(Progama progama)
        {
            using (var context = new Parcial2KrbaEntities())
            {
                context.Progama.Add(progama);
                context.SaveChanges();
                return progama.id;
            }
        }

        public static int modificar(Progama progama)
        {
            using (var context = new Parcial2KrbaEntities())
            {
                var existente = context.Progama.Find(progama.id);
                if (existente != null)
                {
                    existente.idCanal = progama.idCanal;
                    existente.idCategoriaPrograma = progama.idCategoriaPrograma;
                    existente.titulo = progama.titulo;
                    existente.descripcion = progama.descripcion;
                    existente.duracion = progama.duracion;
                    existente.productor = progama.productor;
                    existente.fechaEstreno = progama.fechaEstreno;
                    existente.usuarioRegistro = progama.usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new Parcial2KrbaEntities())
            {
                var existente = context.Progama.Find(id);
                if (existente != null)
                {
                    existente.estado = -1;
                    existente.usuarioRegistro = usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static Progama obtenerUno(int id)
        {
            using (var context = new Parcial2KrbaEntities())
            {
                return context.Progama.Find(id);
            }
        }

        public static List<ProgamaListado> listarPa(string parametro)
        {
            using (var context = new Parcial2KrbaEntities())
            {
                string filtro = (parametro ?? string.Empty).Trim();
                var consulta = context.Progama.Where(x => x.estado == 1);

                if (!string.IsNullOrEmpty(filtro))
                {
                    consulta = consulta.Where(x =>
                        (x.titulo + x.Canal.nombre + x.CategoriaPrograma.nombre + x.productor).Contains(filtro));
                }

                return consulta
                    .OrderBy(x => x.titulo)
                    .Select(x => new ProgamaListado
                    {
                        id = x.id,
                        idCanal = x.idCanal,
                        idCategoriaPrograma = x.idCategoriaPrograma,
                        canal = x.Canal.nombre,
                        categoria = x.CategoriaPrograma.nombre,
                        titulo = x.titulo,
                        descripcion = x.descripcion,
                        duracion = x.duracion,
                        productor = x.productor,
                        fechaEstreno = x.fechaEstreno,
                        usuarioRegistro = x.usuarioRegistro,
                        fechaRegistro = x.fechaRegistro,
                        estado = x.estado
                    })
                    .ToList();
            }
        }
    }

    public class ProgamaListado
    {
        public int id { get; set; }
        public int idCanal { get; set; }
        public int idCategoriaPrograma { get; set; }
        public string canal { get; set; }
        public string categoria { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int duracion { get; set; }
        public string productor { get; set; }
        public System.DateTime fechaEstreno { get; set; }
        public string usuarioRegistro { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public short estado { get; set; }
    }
}
