Desafios Técnicos – C#

Este projeto contém a resolução de 3 desafios de programação em C#, desenvolvidos como parte de um exercício de lógica, orientação a objetos e boas práticas de programação. Cada desafio foca em conceitos diferentes, como manipulação de strings, herança, polimorfismo e gerenciamento de dados em memória.

Tecnologias Utilizadas

Linguagem: C#

Plataforma: .NET (Console Application)

Conceitos Aplicados:

Lógica de programação

Orientação a objetos (POO)

Herança e polimorfismo

Manipulação de strings e listas

Boas práticas (SOLID, organização de código, reutilização de métodos)

Desafio 1 – Cifra do Estagiário (Lógica)

Objetivo:
Criar um programa que substitui vogais por símbolos específicos, criptografando a frase digitada pelo usuário.

Funcionalidades:

Substituição de vogais:

A → @

E → #

I → !

O → $

U → %

Entrada: frase digitada pelo usuário

Saída: frase criptografada

Exemplo de execução:

Digite uma frase:
> O ESTAGIARIO VAI CONSEGUIR
Texto cifrado: $ #ST@G!@R!$ V@! C$NS#G!!R


Boas práticas aplicadas:

Uso de StringBuilder para manipulação eficiente de strings

Tratamento de maiúsculas e minúsculas com char.ToUpper()

Desafio 2 – Zoológico Virtual (Herança + Polimorfismo)

Objetivo:
Criar um sistema simples de zoológico, onde o usuário escolhe animais para visitar e o programa imprime o som que cada animal emite.

Funcionalidades:

Classe base abstrata Animal com propriedades Nome e método EmitirSom()

Subclasses: Leao, Macaco e Elefante, sobrescrevendo o método EmitirSom()

Escolha de animais pelo usuário

Impressão do som de cada animal escolhido

Exemplo de execução:

Escolha os animais que deseja visitar (Leao, Macaco, Elefante), separados por vírgula:
> Leao, Macaco
Leao: Rooooar!
Macaco: Uh uh ah ah!


Boas práticas aplicadas:

Uso de abstract class e override para polimorfismo

Separação da lógica de apresentação e definição das classes

Desafio 3 – Agenda de Contatos (POO + Lógica)

Objetivo:
Criar um sistema de gerenciamento de contatos em memória, permitindo adicionar, listar, buscar e remover contatos.

Funcionalidades:

Classe Contato com propriedades Nome, Telefone e Email

Classe Agenda que gerencia uma lista de contatos

Menu interativo com opções:

Adicionar contato

Listar contatos

Buscar contato por nome

Remover contato

Sair

Exemplo de execução:

Escolha uma opção: 1
Nome: Giancarlo
Telefone: 123456789
Email: g@example.com
Contato adicionado!


Boas práticas aplicadas:

Separação de responsabilidades entre Contato e Agenda

Uso de List<T> e LINQ para buscas e remoções eficientes

Feedback claro ao usuário e tratamento de entradas

Como Executar

Clone o repositório:

git clone <URL_DO_REPOSITORIO>


Abra o projeto no Visual Studio ou outro IDE compatível com C# e .NET.

Compile e execute cada aplicação de console correspondente a cada desafio, utilizando o comando:

* donet run

Conclusão

Este projeto demonstra habilidades em lógica de programação, orientação a objetos, herança e polimorfismo, além de boas práticas em C#. É uma excelente base para desenvolvimento de sistemas simples e aprendizado de conceitos de POO aplicados em C#.
