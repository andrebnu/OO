using System;


namespace ConsoleApp1
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2;

        //média
        public double media()
        {
            return (nota1 + nota2) / 2;
        }
        //situação

        public string situacao(double media)
        {
            return media >= 7 ? "Aprovado" : "Reprovado";

        }
        //mensagem

        public void mensagem()
        {
            double obterMedia = media();
            string obterSituacao = situacao(obterMedia);
            Console.WriteLine(nome  +"está" + obterSituacao + "com Média" + obterMedia,"<br>");


        }


    }
}
