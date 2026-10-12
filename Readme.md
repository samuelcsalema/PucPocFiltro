# PucPocFiltro

Projeto desenvolvido em ASP.NET Core com foco em uma aplicação de mentoria, conectando mentores e mentorados por meio de áreas de conhecimento, tecnologias, agendamentos e avaliações.

## Sobre o projeto

O **PucPocFiltro** é um projeto acadêmico desenvolvido como prova de conceito (POC), com uma estrutura voltada ao gerenciamento de informações relacionadas a mentorias.

A aplicação utiliza o padrão MVC e o Entity Framework Core para organizar a aplicação e realizar a comunicação com um banco de dados SQL Server.

## Tecnologias utilizadas

* **C#** — linguagem de programação.
* **.NET 10** — plataforma de desenvolvimento.
* **ASP.NET Core MVC** — estrutura da aplicação web.
* **Razor Pages** — suporte à renderização de páginas.
* **Entity Framework Core 10** — mapeamento objeto-relacional (ORM).
* **SQL Server / LocalDB** — armazenamento de dados.
* **HTML, CSS e JavaScript** — tecnologias para interfaces web.

## Funcionalidades e entidades

A estrutura de dados contempla:

* **Usuários e níveis de acesso:** organização dos perfis de usuário, incluindo administradores, mentores e mentorados.
* **Mentores e mentorados:** informações específicas de cada perfil.
* **Áreas de conhecimento:** categorização das especialidades dos mentores.
* **Tecnologias:** associação de conhecimentos técnicos aos mentores.
* **Disponibilidades e durações:** informações relacionadas aos horários e à duração das sessões.
* **Mentorias:** registros de encontros, com data, horário, descrição, link e status.
* **Avaliações:** estruturas para avaliar mentores, mentorias e materiais de apoio.
* **Materiais de apoio e anotações:** entidades destinadas a complementar a experiência de aprendizado.

O projeto também possui dados iniciais definidos no modelo do Entity Framework Core para facilitar o desenvolvimento e os testes.

## Pré-requisitos

Antes de executar o projeto, certifique-se de possuir:

* [ .NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
* [Visual Studio](https://visualstudio.microsoft.com/) com a carga de trabalho **ASP.NET e desenvolvimento Web** ou um editor compatível com .NET.
* SQL Server ou SQL Server LocalDB.
* Ferramentas do Entity Framework Core para gerenciamento de migrations.

## Como executar o projeto

### 1. Clonar o repositório

```bash
git clone https://github.com/samuelcsalema/PucPocFiltro.git
```

### 2. Acessar a pasta do projeto

```bash
cd PucPocFiltro/PucPocVS
```

### 3. Restaurar as dependências

```bash
dotnet restore
```

### 4. Configurar a conexão com o banco de dados

A conexão padrão está definida no arquivo `appsettings.json`, utilizando o SQL Server LocalDB:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PucPocVS;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

Se necessário, ajuste a string de conexão para corresponder à configuração do seu ambiente.

### 5. Criar ou atualizar o banco de dados

No terminal, execute:

```bash
dotnet ef database update
```

Caso o comando `dotnet ef` não esteja disponível, instale a ferramenta de linha de comando:

```bash
dotnet tool install --global dotnet-ef
```

Se as migrations ainda não existirem, será necessário criá-las antes de atualizar o banco:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

**Atenção:** crie uma migration inicial somente se o projeto ainda não possuir migrations aplicáveis. Em um banco existente, confira o histórico de migrations antes de realizar alterações.

### 6. Executar a aplicação

```bash
dotnet run
```

Acesse no navegador o endereço local informado no terminal após a inicialização da aplicação.

## Estrutura do projeto

```text
PucPocFiltro/
├── PucPocVS/
│   ├── Controllers/
│   ├── Models/
│   │   └── AppDbContext.cs
│   ├── Views/
│   ├── wwwroot/
│   ├── appsettings.json
│   ├── Program.cs
│   └── PucPocVS.csproj
├── PucPocVS.slnx
└── README.md
```

*Estrutura ilustrativa dos principais diretórios e arquivos da aplicação.*

## Banco de dados

O contexto `AppDbContext` centraliza o mapeamento das entidades e o relacionamento entre os dados.

As alterações estruturais do banco são gerenciadas por meio das migrations do Entity Framework Core. Os dados iniciais definidos no modelo podem ser aplicados durante a atualização do banco de dados.

## Objetivo acadêmico

O projeto serve como ambiente de desenvolvimento e experimentação de recursos de aplicações web com .NET, persistência de dados relacionais e organização de informações relacionadas à mentoria.

## Autor

**Samuel C. Salema**

* GitHub: [@samuelcsalema](https://github.com/samuelcsalema)
* Repositório: [PucPocFiltro](https://github.com/samuelcsalema/PucPocFiltro)
