//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MenuCoffe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_factura
    {
        public int idDetalle_venta { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int idCliente { get; set; }
        public decimal precio { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
