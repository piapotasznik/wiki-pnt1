﻿using Newtonsoft.Json;
using System.Linq;
using System.Text.Json;

namespace tp_grupal.Models
{
    public static class Repositorio
    {
        // TODO: Cambiar por DB
        private static SortedList<string, Articulo> articulos = new SortedList<string, Articulo>();

        public static Articulo Get (string id) { 
            return articulos[id];
        }

        public static List<Articulo> GetAll ()
        {
            List<Articulo> list = new List<Articulo>();
            foreach (string id in articulos.Keys)
            {
                list.Add(articulos[id]);
            }
            return list;
        }

        public static List<Articulo> GetCategoria (string categoria)
        {
            List<Articulo> list = new List<Articulo>();
            foreach (string id in articulos.Keys)
            {
                Articulo articulo = articulos[id];
                if (articulo.categoria == categoria)
                {
                    list.Add(articulo);
                }
            }
            return list;
        }

        public static List<Articulo> Buscar (string query)
        {
            List<Articulo> list = new List<Articulo>();
            foreach (string id in articulos.Keys)
            {
                Articulo articulo = articulos[id];
                if (
                    articulo.titulo.Contains(query) ||
                    articulo.categoria.Contains(query)
                ) {
                    list.Add(articulo);
                } 
            }
            return list;
        }

        public static void Eliminar (string id)
        {
            articulos.Remove(id);
        }
    }
}
