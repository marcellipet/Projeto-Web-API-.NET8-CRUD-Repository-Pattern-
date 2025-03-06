using WebApi8_Projeto.Models;

namespace WebApi8_Projeto.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }
    }
}
