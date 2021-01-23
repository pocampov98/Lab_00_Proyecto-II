using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuebleriaCostaRica.Models
{
    public class Inventario
    {
        private static Dictionary<string, Mueble> listaInventario = new Dictionary<string, Mueble>();

        public static void Agregar(Mueble mueble)
        {
            listaInventario.Add(mueble.Codigo, mueble);
        }

        public static void Actualizar(Mueble mueble)
        {
            listaInventario[mueble.Codigo] = mueble;
        }

        public static bool Eliminar(Mueble mueble)
        {
            return listaInventario.Remove(mueble.Codigo);
        }

        public static Mueble ListarPorId(string codigo)
        {
            return listaInventario[codigo];
        }

        public static Dictionary<string, Mueble> Listar()
        {
            return listaInventario;
        }
    }
}