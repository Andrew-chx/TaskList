//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskList
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tareas
    {
        public int ID { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> categoriaId { get; set; }
        public Nullable<int> usuarioId { get; set; }
        public Nullable<int> estadoId { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaVencimiento { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        public virtual Estados Estados { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
