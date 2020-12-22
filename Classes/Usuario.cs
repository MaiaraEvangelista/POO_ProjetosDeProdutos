using System;

namespace POO_Projeto_de_Produtos21.Classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public Usuario(){
           // Console.WriteLine("Instanciamos a porra");
           Cadastrar();
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;
        }

        public void Cadastrar(){
            Nome = "Maiara";
            Email = "maia@mai.com";
            Senha = "87374847238";
            //2020-12-21T14:43:08
            DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(){
            Nome= "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("");
        }

    }
}