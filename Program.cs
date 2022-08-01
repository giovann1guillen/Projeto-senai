using Projeto_senai.Model;

Usuario usuario = new Usuario();
usuario.Nome = "Rogerinho";
usuario.Senha = "senha1234";

ExemploSenaiContext context = new ExemploSenaiContext();
context.Add(usuario);
context.SaveChanges();