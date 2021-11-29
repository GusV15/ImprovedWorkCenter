using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ImprovedWorkCenter.Models
{
    public class Socio
    {
        [Key]
        public int SocioId { get; set; }

        /*[Required]
        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }*/
        [RegularExpression("[a-zA-Z ]*", ErrorMessage = "El campo Nombre NO admite números y NO debe superar los 50 caractéres.")]
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El máximo permitido para el campo Nombre es de {0}")]
        public string Nombre { get; set; }

        [RegularExpression("[a-zA-Z ]*", ErrorMessage = "El campo Apellido NO admite números y NO debe superar los 50 caractéres.")]
        [Required(ErrorMessage = "El campo Apellido es obligatorio."), MinLength(1), MaxLength(50)]
        public string Apellido { get; set; }

        [Range(16, 120, ErrorMessage = "La Edad debe ser de {1} a {2} años.")]
        [Required(ErrorMessage = "El campo Edad es obligatorio.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El campo Domicilio es obligatorio y NO debe superar los 50 caractéres."), MaxLength(50)]
        public string Domicilio { get; set; }

        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "El campo Email debe tener el formato xxxxx@xxx.xxx.")]
        [Required(ErrorMessage = "El campo Email es obligatorio")]
        [Display(Name = "Email")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio debe tener de 8 a 20 caractéres."), MinLength(8), MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contrasenia { get; set; }

        [Display(Name = "Es Deudor")]
        public Boolean EsDeudor { get; set; }

        [Required(ErrorMessage = "El campo FechaInscripcion es obligatorio")]
        [Display(Name = "Fecha Inscripción")]
        public string FechaInscripcion { get; set; }

        [Required(ErrorMessage = "El campo MetodoDePago es obligatorio")]
        [Display(Name = "Método de Pago")]
        [EnumDataType(typeof(MetodoDePago))]
        public MetodoDePago MetodoDePago { get; set; }

        /*
        public Socio(string nombre, string apellido, int edad, string domicilio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Domicilio = domicilio;
        }



        */
    }
}