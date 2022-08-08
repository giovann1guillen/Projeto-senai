using Projeto_senai.Model;
using System.Collections.Generic;

List<string> listNome = new List<string>();
List<string> listsobrenome = new List<string>();
List<string> listobjetos = new List<string>();
List<string> listadjestivos = new List<string>();
List<string> listcaracteres = new List<string>();

listNome.Add("Giovanni");
listNome.Add("Gabriel");
listNome.Add("Ian");
listNome.Add("Mikael");
listNome.Add("Igor");
listNome.Add("Rafael");
listNome.Add("Ricardo");
listNome.Add("Amanda");
listNome.Add("Maria");
listNome.Add("Victor");
listNome.Add("João");

listsobrenome.Add("Guillen");
listsobrenome.Add("Nogueira");
listsobrenome.Add("Silva");
listsobrenome.Add("Souza");
listsobrenome.Add("Machado");
listsobrenome.Add("Amaral");
listsobrenome.Add("Eiki");
listsobrenome.Add("Beraldo");
listsobrenome.Add("Lada");
listsobrenome.Add("Werner");
listsobrenome.Add("Andre");

listobjetos.Add("Caneta");
listobjetos.Add("Garrafa");
listobjetos.Add("Mesa");
listobjetos.Add("Computador");
listobjetos.Add("Lapis");
listobjetos.Add("Caderno");
listobjetos.Add("Cadeira");
listobjetos.Add("Papel");
listobjetos.Add("Teclado");
listobjetos.Add("Televisão");
listobjetos.Add("Monitor");

listcaracteres.Add("a");
listcaracteres.Add("b");
listcaracteres.Add("c");
listcaracteres.Add("d");
listcaracteres.Add("e");
listcaracteres.Add("f");
listcaracteres.Add("g");
listcaracteres.Add("h");
listcaracteres.Add("i");
listcaracteres.Add("j");
listcaracteres.Add("k");
listcaracteres.Add("l");
listcaracteres.Add("m");
listcaracteres.Add("n");
listcaracteres.Add("o");
listcaracteres.Add("p");
listcaracteres.Add("q");
listcaracteres.Add("r");
listcaracteres.Add("s");
listcaracteres.Add("t");
listcaracteres.Add("u");
listcaracteres.Add("v");
listcaracteres.Add("w");
listcaracteres.Add("x");
listcaracteres.Add("y");
listcaracteres.Add("z");
listcaracteres.Add("1");
listcaracteres.Add("2");
listcaracteres.Add("3");
listcaracteres.Add("4");
listcaracteres.Add("5");
listcaracteres.Add("6");
listcaracteres.Add("7");
listcaracteres.Add("8");
listcaracteres.Add("9");
listcaracteres.Add("0");
listcaracteres.Add("=");
listcaracteres.Add("{");
listcaracteres.Add("}");
listcaracteres.Add("[");
listcaracteres.Add("]");
listcaracteres.Add("?");
listcaracteres.Add("<");
listcaracteres.Add(">");
listcaracteres.Add("'");
listcaracteres.Add("!");
listcaracteres.Add("@");
listcaracteres.Add("#");
listcaracteres.Add("$");
listcaracteres.Add("%");
listcaracteres.Add("&");
listcaracteres.Add("*");
listcaracteres.Add("(");
listcaracteres.Add(")");
listcaracteres.Add("/");
listcaracteres.Add(".");
listcaracteres.Add(",");

listadjestivos.Add("Bonito");
listadjestivos.Add("Feio");
listadjestivos.Add("Inteligente");
listadjestivos.Add("Burro");
listadjestivos.Add("Arrogante");
listadjestivos.Add("Simpatico");
listadjestivos.Add("Alto");
listadjestivos.Add("Baixo");
listadjestivos.Add("Timido");
listadjestivos.Add("Corajoso");
listadjestivos.Add("Bondoso");

Random rnd = new Random();

string senhacaracter = "";

int listNomeindex = rnd.Next(listNome.Count);
int listsobrenomeindex = rnd.Next(listsobrenome.Count);
int listobjetosindex = rnd.Next(listobjetos.Count);
int listadjestivosindex = rnd.Next(listadjestivos.Count);

for(var i = 0; i<10; i++)
{
    senhacaracter += listcaracteres[rnd.Next(0, listcaracteres.Count)];
}


Console.WriteLine(listNome[listNomeindex] + " " + listsobrenome[listsobrenomeindex]);
Console.WriteLine(listobjetos[listobjetosindex] + " são " + listadjestivos[listadjestivosindex]);
Console.WriteLine(senhacaracter);