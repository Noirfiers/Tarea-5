using System;
using System.Collections.Generic;

namespace Tarea_5_laboratorio_Grupo_4
{
    public class IDS
    {
        private int _cantidad;
        public string IdVenta { get; }
        public string IdCliente { get; set; }
        public string IdVideojuego { get; set; }
        public decimal Total { get; private set; }
        public DateTime FechaVenta { get; }
        public string MetodoPago { get; set; }
        public int Cantidad
        {
            get => _cantidad;
            set => _cantidad = value > 0 ? value
                : throw new ArgumentOutOfRangeException(nameof(Cantidad), "La cantidad debe ser positiva");
        }
        public IDS(string idVenta, string idCliente, string idVideojuego, int cantidad)
        {
            IdVenta      = idVenta;
            IdCliente    = idCliente;
            IdVideojuego = idVideojuego;
            Cantidad     = cantidad;
            FechaVenta   = DateTime.Now;
        }
        public void CalcularTotal(decimal precioUnitario) => Total = precioUnitario * Cantidad;
        public bool ValidarMetodoPago()
        {
            var validMethods = new HashSet<string> { "EFECTIVO", "TARJETA" };
            return MetodoPago != null && validMethods.Contains(MetodoPago.ToUpper());
        }
        public override string ToString() => $"Venta #{IdVenta} | Total: {Total:C}";
    }
}
