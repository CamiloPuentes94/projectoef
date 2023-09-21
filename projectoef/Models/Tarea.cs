using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectoef.Models
{
    public class Tarea
    {
        [Key]
        public Guid TareaId { get; set; }
        
        [ForeignKey("CtaegoriaID")] // con este atributo se crea la llave foranea
        // propiedad para enlazar el modelo categoria
        public Guid CategoriaId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        
        public Prioridad PrioridadTarea { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Categoria Categoria { get; set; }

        [NotMapped] // con este atributo omita esta propiedad al crear la base de datos
        public string Resumen {  get; set; }

    }

    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }
}
