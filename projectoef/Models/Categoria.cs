using System.ComponentModel.DataAnnotations;

namespace projectoef.Models
{
    // Modelo de categorias
    public class Categoria
    {
        [Key] // se indica atributo para que sea la primary key de la tabla
        public Guid CategoriaId { get; set; }

        [Required] // con este atributo se indica que la propiedad es requerida en la tabla
        [MaxLength(150)] // se indica que solo va a tener un maximo de 150
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
