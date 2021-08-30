using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace practica1.Models
{
    [Table("t_producto")]
    public class Matriculas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("categoria")]
        public string Categoria { get; set; }
        [Column("precio")]
        public string Precio {get; set;}
        [Column("descuento")]
        public string Descuento {get; set; }     

    }
}