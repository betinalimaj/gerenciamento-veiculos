# Sistema de Gerenciamento de Veículos

Sistema desenvolvido em **C# (Windows Forms)** com **PostgreSQL**, permitindo o gerenciamento de marcas e veículos por meio das operações de CRUD.

## Funcionalidades

### Marcas
- Cadastrar marca;
- Listar marcas;
- Alterar marca;
- Excluir marca.

### Veículos
- Cadastrar veículo;
- Listar veículos;
- Alterar veículo;
- Excluir veículo.

## Validações

- Não permite cadastrar marcas com o mesmo nome;
- Não permite cadastrar veículos com a mesma placa;
- Validação de campos obrigatórios;
- Não permite excluir marcas vinculadas a veículos.

## Testes Unitários

O projeto possui dois testes unitários para validar regras de negócio, incluindo:

- Impedir exclusão de marca vinculada a um veículo;
- Impedir cadastro de veículo com placa já existente.

## Tecnologias

- C#
- .NET 10
- Windows Forms
- PostgreSQL
- Npgsql
- MSTest
- Visual Studio

## Estrutura do Projeto

```
GerenciamentoVeiculos
├── Main
├── Repository
├── Service
└── UI
script.sql
GerenciamentoVeiculos.Tests
```

## Como executar

1. Clone o repositório.
2. Crie um banco de dados PostgreSQL.
3. Execute o arquivo `script.sql`.
4. Configure a conexão com o banco no arquivo `Conexao.cs`.
5. Abra a solução no Visual Studio.
6. Execute o projeto.


## Autor

Betina Lima