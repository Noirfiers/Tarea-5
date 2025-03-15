using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tarea_5_laboratorio_Grupo_4
{
    public class Cliente
    {
        public string Id { get; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; }
        public List<string> HistorialCompras { get; } = new List<string>();

        public Cliente(string id, string nombre, string email)
        {
            Id             = id;
            Nombre         = nombre;
            FechaRegistro  = DateTime.Now;
        }
        public void AgregarCompra(string juego) => HistorialCompras.Add(juego);
    }

}

