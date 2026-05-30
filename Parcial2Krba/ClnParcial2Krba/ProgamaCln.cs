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

        public static List<paProgamaListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2KrbaEntities())
            {
                return context.paProgamaListar((parametro ?? string.Empty).Trim()).ToList();
            }
        }
    }
}