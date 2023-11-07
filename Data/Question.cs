using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
   public abstract class Questao : IQuestion
{
    public int Id { get; set; }
    public string TextoQuestao { get; set; }


    public Questao(int id, string textoQuestao)
    {
        Id = id;
        TextoQuestao = textoQuestao;
    }

    public abstract void Exibir();
}
}