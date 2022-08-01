using Projeto_Senai.Model;

ExemploSenaiContext context = new ExemploSenaiContext();
foreach (var usuario in context.Usuarios)
{
    Console.WriteLine(usuario.Nome);
}

while (True)
(
    Console.WriteLine("o que deseja fazer? 1 - Logar" +  
    "2 - registrar" + "3 - sair");
    string num = Console.Readline();
    if (num == "1")
    (
        Console.Clear();
    )
    else if (num == "2")
    (
        Console.Clear();
    )
    else if (num == "3")
    (
       break;
    )
    else
    (
        Console.Clear();
        Console.WriteLine("Operação invalida");
    )
)