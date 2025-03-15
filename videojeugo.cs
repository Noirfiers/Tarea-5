using System;

namespace Tarea_5_laboratorio_Grupo_4
{
    public class Videojuego
    {
        private decimal _precio;
        private int _stock;
        public string Id { get; }
        public string Titulo { get; set; }

        public decimal Precio
        {
            get => _precio;
            set => _precio = value >= 0 ? value
                : throw new ArgumentOutOfRangeException(nameof(Precio), "El precio no puede ser negativo");
        }
        public int Stock
        {
            get => _stock;
            set => _stock = value >= 0 ? value
                : throw new ArgumentOutOfRangeException(nameof(Stock), "El stock no puede ser negativo");
        }
        public Videojuego(string id, string titulo, decimal precio, int stock)
        {
            Id      = id;
            Titulo  = titulo;
            Precio  = precio;
            Stock   = stock;
        }
        public void AplicarDescuento(decimal porcentaje)
        {
            if (porcentaje < 0 || porcentaje > 100)
                throw new ArgumentException("Descuento inválido");
            Precio *= (1 - porcentaje / 100);
        }
        public void ActualizarStock(int cantidad) => Stock += cantidad;
        public override string ToString() => $"{Titulo} | Precio: {Precio:C} | Stock: {Stock}";
    }

}