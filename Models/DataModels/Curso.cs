using System.ComponentModel.DataAnnotations;

/*
Crea una clase llamada Curso que debe tener:

Nombre (máximo

Descripción Corta (máximo 280 caracteres)

Descripción larga

Público Objetivo

Objetivos

Requisitos

Nivel (solo puede ser Básico, Intermedio o Avanzado para ello usa un enumerado)
*/
namespace holaMundo.Models.DataModels
{

    public class Curso : BaseEntity
    {

        [Required, StringLength(50)]
        public string nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string descripcionCorta { get; set; } = string.Empty;
        public string descripcionLarga { get; set; } = string.Empty;
        public string publicoObjetivo { get; set; } = string.Empty;
        public string objetivos { get; set; } = string.Empty;
        public string requisitos { get; set; } = string.Empty;
        public enum Season
        {
            Basic, intermediate, advanced
        }
    }

}