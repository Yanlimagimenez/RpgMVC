using RpgMVC.Models.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace RpgMVC.Models
{
    public class PersonagemViewModel
    {
         public int Id { get; set; }
         public int Disputa { get; set; }
         public int Vitorias { get; set; }
         public int Derrotas { get; set; }
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe{ get; set; }

       // public byte[] FotoPersonagem { get; set; }

        //[JsonIgnore]

       // public Usuario Usuario { get; set; }

       // [JsonIgnore]//System.Text.Json.Serialization;

        //public Arma Arma { get; set; }
        
       
       // public List<PersonagemHabilidade> PersonagemHabilidades { get; set; } //Adicionar sempre  -->using System.Collections.Generic;
    }
}