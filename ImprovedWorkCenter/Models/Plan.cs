using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImprovedWorkCenter.Models
{
    public class Plan
    {
        [Key]
        public int PlanId { get; set; }

        [ForeignKey(nameof(Socio))]
        [Required(ErrorMessage = "Debe seleccionar un Socio.")]
        public int SocioId { get; set; }

        [Display(Name = "Nombre de Socio")]
        public string NombreSocio { get; set; }

        [Required(ErrorMessage = "El Precio del plan es obligatorio")]
        [Range(1, 100000, ErrorMessage = "El Precio debe estar entre {1} y {2} pesos.")]
        public double Precio { get; set; }

        [EnumDataType(typeof(TipoPlan))]
        [Required(ErrorMessage = "El tipo de plan es obligatorio.")]
        [Display(Name = "Tipo de Plan")]
        public TipoPlan TipoPlan { get; set; }

        /*

        public Plan(double precio)
        {
            this.setPrecio(precio);
        }

        public void setPrecio(double precio)
        {
            if (precio > 0)
            {
                this.Precio = precio;
            } else
            {
                this.Precio = 0;
            }
        }

        public string print()
        {
            return "Precio: " + this.Precio + ".";

        }

        */
    }
}
