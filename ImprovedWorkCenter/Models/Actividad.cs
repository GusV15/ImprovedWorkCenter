using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImprovedWorkCenter.Models
{
    public class Actividad
    {
        [Key]
        public int ActividadId { get; set; }

        [EnumDataType(typeof(Actividad))]
        [Required(ErrorMessage = "El campo Tipo es obligatorio")]
        public TipoActividad Tipo { get; set; }
        [Required(ErrorMessage = "El campo HorarioInicio es obligatorio")]
        [Range(0, 24, ErrorMessage = "El horario debe ser entre las {1} y {2} horas.")]
        [Display(Name = "Horario Inicio")]
        public int HorarioInicio { get; set; }
        [Required(ErrorMessage = "El campo HorarioFinal es obligatorio")]
        [Range(0, 24, ErrorMessage = "El horario debe ser entre las {1} y {2} horas.")]
        [Display(Name = "Horario Final")]
        public int HorarioFinal { get; set; }


        /*
       public Actividad(int horarioInicio, int horarioFinal, TipoActividad tipo)
        {
            this.setHorarioInicio(horarioInicio);
            this.setHorarioFinal(horarioFinal);
            this.Tipo = tipo;
        }

        public TipoActividad getTipo()
        {
            return this.Tipo;
        }
        public int getHorarioInicio()
        {
            return this.HorarioInicio;
        }
        public int getHorarioFinal()
        {
            return this.HorarioFinal;
        }
        public void setHorarioInicio(int horario)
        {
            if (horario > 0 && horario < 24)
            {
                this.HorarioInicio = horario;
            }
        }
        public void setHorarioFinal(int horario)
        {
            if (horario > 0 && horario < 24)
            {
                this.HorarioFinal = horario;
            }
        }

        public string print()
        {
            return "Tipo de Actividad: " + this.Tipo + ". Horario de inicio: " + this.HorarioInicio + ". Horario de finalizacion: " + this.HorarioFinal + ".";
           
        }


        */
    }
}
