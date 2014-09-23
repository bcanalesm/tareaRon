//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurante.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        public Pedido()
        {
            this.Detalle_Pago = new HashSet<Detalle_Pago>();
            this.Detalle_Pedido = new HashSet<Detalle_Pedido>();
        }
    
        public int IdPedido { get; set; }
        public Nullable<int> IdMesa { get; set; }
        public string Fecha { get; set; }
    
        public virtual ICollection<Detalle_Pago> Detalle_Pago { get; set; }
        public virtual ICollection<Detalle_Pedido> Detalle_Pedido { get; set; }
        public virtual Mesa Mesa { get; set; }
    }
}