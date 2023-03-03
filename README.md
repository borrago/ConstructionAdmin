# Para Criar uma Migration
É necessário estar no diretório que contenha o Contexto do EF Core da aplicação .

`cd .\ConstructionAdmin\`

Em seguida execute o comando para gerar a nova migration apontando para o projeto de startup, esse projeto deve ter obrigatoriamente o pacote Microsoft.EntityFrameworkCore.Design instalado.

Mesmo sendo uma má pratica utilizá-lo, haja visto que é uma necessidade inerente a utilização da estratégia do Database Tenant Provider ©. :).

`dotnet ef migrations add [Nome da sua migration]`

Se atente para o nome da sua migration, ela será imutável e irá perdurar por toda a vida do projeto :p, o EF Core irá criar um prefixo com a data atual, portanto não é necessário inserir no nome da migration nenhuma informação referente a data que você está criando-a.

# Para Atualizar a Base de Dados
Ainda no diretório que se encontra o Context da aplicação, execute o comando:

`dotnet ef database update`

* Atenção, em ambiente de desenvolvimento esse script irá executar as migrations para a base relacionada ao tenant de referencia, localizado no appSettings.Development.json sob a chave ReferenceTenantId.

# Para Visualizar o SQL da Migration
Ainda no diretório que se encontra o Context da aplicação, execute o comando:

`dotnet ef migrations script`
