using Projeto-Senai.Model;

Usuario usuario = new Usuario()
usuario.Nome = "Rogerinho";
usuario.senha = "senha1234";

ExemploSenaiContext context = new ExemploSenaiContext;
context.add(usuario);
context.savechanges();