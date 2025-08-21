// DESAFIO 1 - Cifra de Substituição (Lógica)

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite uma frase:");
//         string frase = Console.ReadLine();

//         string fraseCifrada = Cifrar(frase);
//         Console.WriteLine($"Texto cifrado: {fraseCifrada}");
//     }

//     static string Cifrar(string texto)
//     {
//         
//         var resultado = new System.Text.StringBuilder();

//         foreach (char c in texto)
//         {
//             switch (char.ToUpper(c))
//             {
//                 case 'A': resultado.Append('@'); break;
//                 case 'E': resultado.Append('#'); break;
//                 case 'I': resultado.Append('!'); break;
//                 case 'O': resultado.Append('$'); break;
//                 case 'U': resultado.Append('%'); break;
//                 default: resultado.Append(c); break;
//             }
//         }

//         return resultado.ToString();
//     }
// }


// Desafio 2 - Sistema de Animais (POO + Lógica)

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         var animais = new List<Animal> { new Leao(), new Macaco(), new Elefante() };

//         Console.WriteLine("Escolha os animais que deseja visitar (Leao, Macaco, Elefante), separados por vírgula:");
//         string escolha = Console.ReadLine();
//         string[] escolhidos = escolha.Split(',');

//         foreach (string nome in escolhidos)
//         {
//             Animal animal = animais.Find(a => a.Nome.Equals(nome.Trim(), StringComparison.OrdinalIgnoreCase));
//             if (animal != null)
//             {
//                 Console.WriteLine($"{animal.Nome}: {animal.EmitirSom()}");
//             }
//             else
//             {
//                 Console.WriteLine($"{nome.Trim()} não encontrado.");
//             }
//         }
//     }
// }

// // Classe base
// abstract class Animal
// {
//     public abstract string Nome { get; }
//     public abstract string EmitirSom();
// }

// // Subclasses
// class Leao : Animal
// {
//     public override string Nome => "Leao";
//     public override string EmitirSom() => "Rooooar!";
// }

// class Macaco : Animal
// {
//     public override string Nome => "Macaco";
//     public override string EmitirSom() => "Uh uh ah ah!";
// }

// class Elefante : Animal
// {
//     public override string Nome => "Elefante";
//     public override string EmitirSom() => "Paaah!";
// }


// Desafio 3 - Agenda de Contatos (POO + Lógica)

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var agenda = new Agenda();
        
        while (true)
        {
            Console.WriteLine("\n1- Adicionar contato\n2- Listar contatos\n3- Buscar por nome\n4- Remover contato\n5- Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: "); string nome = Console.ReadLine();
                    Console.Write("Telefone: "); string telefone = Console.ReadLine();
                    Console.Write("Email: "); string email = Console.ReadLine();
                    agenda.AdicionarContato(new Contato(nome, telefone, email));
                    break;
                case "2":
                    agenda.ListarContatos();
                    break;
                case "3":
                    Console.Write("Nome para buscar: "); string buscar = Console.ReadLine();
                    agenda.BuscarContato(buscar);
                    break;
                case "4":
                    Console.Write("Nome do contato para remover: "); string remover = Console.ReadLine();
                    agenda.RemoverContato(remover);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }
}

class Agenda
{
    private List<Contato> contatos = new List<Contato>();

    public void AdicionarContato(Contato contato)
    {
        contatos.Add(contato);
        Console.WriteLine("Contato adicionado!");
    }

    public void ListarContatos()
    {
        if (!contatos.Any())
        {
            Console.WriteLine("Nenhum contato cadastrado.");
            return;
        }

        foreach (var c in contatos)
        {
            Console.WriteLine($"Nome: {c.Nome}, Telefone: {c.Telefone}, Email: {c.Email}");
        }
    }

    public void BuscarContato(string nome)
    {
        var encontrados = contatos.Where(c => c.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();
        if (encontrados.Count == 0)
        {
            Console.WriteLine("Contato não encontrado.");
            return;
        }

        foreach (var c in encontrados)
        {
            Console.WriteLine($"Nome: {c.Nome}, Telefone: {c.Telefone}, Email: {c.Email}");
        }
    }

    public void RemoverContato(string nome)
    {
        var contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (contato != null)
        {
            contatos.Remove(contato);
            Console.WriteLine("Contato removido!");
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }
}
