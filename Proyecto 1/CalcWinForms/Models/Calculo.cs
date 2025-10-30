using System;

namespace CalcWinForms.Models
{
    public class Calculo
    {
        public int Id { get; set; }
        public string Expresion { get; set; } = string.Empty;
        public string Resultado { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
    }
}