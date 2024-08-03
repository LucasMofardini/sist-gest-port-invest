# Gestão de Portfólio de Investimentos

Este projeto é uma aplicação de gestão de portfólio de investimentos desenvolvida usando .NET e C#. A arquitetura é baseada em microsserviços, e a aplicação segue o Domain-Driven Design (DDD) para a modelagem do domínio.
O armazenamento de dados é feito utilizando MYSQL.

## Funcionalidades

A arquitetura do projeto é composta pelas seguintes funcionalidades:

1. **Serviço de Produtos Financeiros**: Gerencia os produtos financeiros disponíveis para investimento.
2. **Serviço de Investimentos**: Gerencia os investimentos realizados pelos clientes.
3. **Serviço de Clientes**: Gerencia os dados dos clientes.
4. **Serviço de Funcionários**: Gerencia os dados dos funcionários responsáveis pelos investimentos.

### Tecnologias Utilizadas

- **.NET 8**: Framework para o desenvolvimento da aplicação.
- **C# 8**: Linguagem de programação utilizada.
- **Domain-Driven Design (DDD)**: Abordagem para modelagem de domínio.
- **MySQL**: Banco de dados relacional para armazenamento de dados.
- **Swagger**: Para documentação da API e testes.

## Pré Requisito
1. Instalar MYSQL Workbench
2. 
## Configuração

1. **Clone o Repositório**

   ```bash
   git clone https://github.com/seu-usuario/gestao-portifolio-investimentos.git
   cd gestao-portifolio-investimentos

3. Abrir o MYSQL e rodar o Script -> docs/script_create.sql
4. Configurar o InvestmentManagementSystem.API para IIS Express e startar o projeto
5. Collection do Postam docs/InvestmentManagementSystem.API.postman_collection
