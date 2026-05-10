using System;
using System.Collections.Generic;
using Newtonsoft.Json; // Si esto sale en rojo, hay que instalar el paquete NuGet
using System.IO;

namespace ecommercetp1
{
    public static class RepositorioCentral
    {
        // La lista donde se guardan las tiendas en memoria
        public static List<Tienda> TodasLasTiendas = new List<Tienda>();

        // Método para guardar en el archivo JSON
        public static void GuardarDatos()
        {
            try
            {
                string json = JsonConvert.SerializeObject(TodasLasTiendas, Formatting.Indented);
                File.WriteAllText("tiendas.json", json);
            }
            catch (Exception ex)
            {
                // Solo para avisar si algo falla con el archivo
                System.Windows.Forms.MessageBox.Show("Error al guardar JSON: " + ex.Message);
            }
        }

        // Método para cargar desde el archivo JSON
        public static void CargarDatos()
        {
            if (File.Exists("tiendas.json"))
            {
                string json = File.ReadAllText("tiendas.json");
                TodasLasTiendas = JsonConvert.DeserializeObject<List<Tienda>>(json) ?? new List<Tienda>();
            }
        }
    }
}