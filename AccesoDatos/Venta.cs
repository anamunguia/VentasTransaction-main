﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Venta
    {
        public int Id { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public int CLienteId { get; set; }
        public decimal Total { get; set; }
        public List<VentaDetalle> Conceptos { get; set; } = new List<VentaDetalle>();
    }
}
