﻿namespace WebApi8_Projeto.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorModel Autor{ get; set; }
    }
}
