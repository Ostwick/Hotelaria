# Sistema de Hospedagem em Hotel

Este projeto é um **Sistema de Hospedagem em Hotel**, desenvolvido em C# com base nos conceitos de Programação Orientada a Objetos (POO). Ele permite a criação de reservas de hotel, onde hóspedes são cadastrados e alocados em suítes, e o valor total da reserva é calculado, incluindo um desconto de 10% para reservas acima de 10 dias.

## Funcionalidades

- **Cadastro de Hóspedes**: Registra uma lista de hóspedes para uma reserva.
- **Cadastro de Suíte**: Define o tipo, a capacidade e o valor da diária de uma suíte.
- **Cálculo de Valor da Reserva**: Calcula o valor total da reserva, considerando a quantidade de dias e aplicando um desconto de 10% se a reserva for para mais de 10 dias.

## Estrutura do Projeto

O sistema é composto pelas seguintes classes:

- **Pessoa**: Representa o hóspede, com nome e idade.
- **Suite**: Representa a suíte do hotel, com tipo, capacidade e valor da diária.
- **Reserva**: Relaciona uma lista de hóspedes com uma suíte e calcula o valor total da reserva com base nos dias reservados e na capacidade da suíte.

## Pré-requisitos

Antes de executar o projeto, certifique-se de ter instalado:

- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)
- Um editor de texto ou IDE como [Visual Studio Code](https://code.visualstudio.com/)
