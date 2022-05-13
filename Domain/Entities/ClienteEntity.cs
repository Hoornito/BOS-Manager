using Microsoft.EntityFrameworkCore;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ClienteEntity
    {
        public ClienteEntity(EntityState state = EntityState.Unchanged)
        {
            State = state;
        }

        public ClienteEntity(string nombre, string dni, string dirección, string teléfono, string mailContacto) : this()
        {
            Nombre = nombre;
            DNI = dni;
            Dirección = dirección;
            Teléfono = teléfono;
            MailContacto = mailContacto;
        }

        public ClienteEntity(int id_Cliente, string nombre, string dni, string dirección, string teléfono, string mailContacto) : this(nombre, dni, dirección, teléfono, mailContacto)
        {
            Id_Cliente = id_Cliente;
        }

        [Browsable(false)] //Atributo que no se muestra como propiedad en objetos de ventanas...
        public int Id_Cliente { get; set; }

        [Required(ErrorMessage = "Dirección es requerido.")]
        public string Dirección { get; set; }

        public string DNI { get; set; }

        public bool Active { get; set; }

        [Required(ErrorMessage = "Mail de contacto es requerido.")]
        public string MailContacto { get; set; }

        [Required(ErrorMessage = "Nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Teléfono es requerido.")]
        public string Teléfono { get; set; }

        [Browsable(false)]
        public EntityState State { get; set; }
    }
}
