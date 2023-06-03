using System;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

//Introdução
//Bob é um adolescente indiferente . Ele gosta de pensar que é muito legal. E ele definitivamente não fica animado com as coisas. Isso não seria legal.

//Quando as pessoas falam com ele, suas respostas são bastante limitadas.

//Instruções
//Sua tarefa é determinar o que Bob responderá a alguém quando lhe disserem algo ou lhe fizerem uma pergunta.

//Bob só responde a uma das cinco coisas:

//-> "Claro." Esta é a resposta dele se você fizer uma pergunta, como "Como vai você?" A convenção usada para perguntas é que elas terminam com um ponto de interrogação.
//-> "Uau, relaxa!" Esta é a resposta dele se você GRITAR COM ELE. A convenção usada para gritar é TODAS AS LETRAS MAIÚSCULAS.
//-> "Calma, eu sei o que estou fazendo!" Isso é o que ele diz se você gritar uma pergunta para ele.
//-> "Bem, seja assim!" É assim que ele responde ao silêncio. A convenção usada para silêncio é nada, ou várias combinações de caracteres de espaço em branco.
//"Qualquer que seja." Isso é o que ele responde a qualquer outra coisa.
//como depurar

public static class Bob
{
    public static string Response(string statement)
    {
        string pattern = "[0^9]";
        Regex reg = new Regex(pattern);

        statement = reg.Replace(statement, "");

        //Silencio
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";

        //Gritar com bob
        if (statement.ToUpper() == statement)
        {
            //Grito com pergunta
            if (statement[statement.Length - 1] == '?')
                return "Calm down, I know what I'm doing!";
            return "Whoa, chill out!";
        }

        //Pergunta
        if (statement[statement.Length - 1] == '?')
            return "Sure.";

        return "Whatever.";
    }
}