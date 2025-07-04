﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class Venta
{
    public int VentaID { get; set; }

    public DateTime Fecha { get; set; }

    public int? ClienteID { get; set; }

    public int? PuntoID { get; set; }

    public decimal? Total { get; set; }

    public virtual Cliente Cliente { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual PuntoDeVenta Punto { get; set; }
}