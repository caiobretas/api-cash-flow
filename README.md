# API de Exemplo com ASP.NET Core

Esta é uma API desenvolvida utilizando ASP.NET Core, destinada a demonstrar a implementação de práticas modernas de desenvolvimento de software, incluindo o tratamento de exceções com filtros customizados, validações robustas com FluentValidation e a construção de testes unitários para garantir a qualidade do código.

## Recursos da API

- **Tratamento de Exceções**: Utilizamos filtros personalizados para capturar e tratar exceções de forma centralizada, garantindo que a resposta ao cliente seja sempre adequada e informativa.

- **Validação de Dados**: Integração com FluentValidation para assegurar que todos os dados recebidos pelas nossas endpoints atendam aos critérios especificados, promovendo uma API mais robusta e confiável.

- **Testes Unitários**: Cobertura de testes unitários para garantir que nossa lógica de negócios esteja correta e estável ao longo de atualizações e refatorações.

## Tecnologias Utilizadas

- ASP.NET Core 8.0
- FluentValidation 10.0
- xUnit para testes unitários
- Moq para mockar dependências em testes

## Como Iniciar

Para rodar esta API localmente, siga os passos abaixo:

### Pré-requisitos

- .NET 8.0 SDK

### Instalação

1. Clone o repositório:
   ```
   git clone https://github.com/caiobretas/api-cashflow
   ```
2. Navegue até a pasta do projeto:
   ```
   cd api-cash-flow
   ```
3. Restaure os pacotes NuGet:
   ```
   dotnet restore
   ```
4. Inicie a aplicação:
   ```
   dotnet run
   ```
