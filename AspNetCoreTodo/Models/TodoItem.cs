using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    //Clase  que define los datos necesarios para almacenar cada tarea en la BD
    public class TodoItem
    {
        //GUID = Global Unique Identificator
        //Son cadenas de letras y numeros largas aleatorias
        public Guid Id {get; set;}

        //Propiedad False predeterminado
        //Cambia a True cuando el usuario presiona una casilla de verificacion
        public bool IsDone {get; set;}

        //Nombre de la tarea pendiente
        [Required]
        public string Title {get; set;}

        //Fecha y Hora, el simbolo ? hace que pueda ser nullable (opcional)
        public DateTimeOffset? DueAt {get; set;}

        //Las propiedades {get; set;} indica que son de lectura y escritura
    }

}