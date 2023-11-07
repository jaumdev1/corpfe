using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data.Questions
{
   public class QuestaoEscolhaMultipla : Questao
{
    public List<string> Opcoes { get; set; }
    TipoQuestao TipoQuestao {get; set;}
    public QuestaoEscolhaMultipla(int id, string textoQuestao, List<string> opcoes)
        : base(id, textoQuestao)
    {
        TipoQuestao = TipoQuestao.EscolhaMultipla;
        Opcoes = opcoes;
    }

    public override void Exibir()
    {
     
    }
}
}