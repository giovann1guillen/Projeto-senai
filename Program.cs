using Projeto_senai.Model;

ExemploSenaiContext context = new ExemploSenaiContext();
while (true)
{
    Console.WriteLine("o que deseja fazer? 1 - Logar ou 2 - registrar ou 3 - sair");
    string num = Console.Readline();
    if (num == "1")
    {
        Console.WriteLine("digite o seu nome: ");
        string nome = Console.ReadLine();

        Usuario expectedUser = null;
        foreach(Usuario usuario in db.usuario)
        {
            if(usuario.Nome == nome)
            {
                expectedUser = usuario;
            }
            if(expectedUser== null)
            {
                Console.WriteLine("Não existe usuario com esse nome");
                Console.ReadKey(true);
                Console.Clear();
            }
        } 
       
    }
    else if (num == "2")
    {
        Usuario usuario = new Usuario();

        Console.WriteLine("digite o seu nome: ");
        usuario.Nome = Console.ReadLine();
        
        Console.WriteLine("digite a sua senha: ");
        usuario.Senha = Console.ReadLine();

    }
    else if (num == "3")
    {
       break;
    }
   else
    {
        Console.Clear();
        Console.WriteLine("Operação invalida");
    }
}