﻿namespace VentasApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
