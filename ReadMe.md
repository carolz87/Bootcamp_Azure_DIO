# Micro serviço Servless

Este repositório contém um exercício do bootcamp AZ-204 da DIO. O objetivo deste projeto é validar números de CPF utilizando uma aplicação desenvolvida em C#. A aplicação foi projetada para ser um micro serviço serverless, permitindo a validação de CPFs de forma eficiente e escalável. O projeto inclui a implementação das regras de validação do CPF brasileiro e demonstra como fazer o deploy da aplicação na nuvem utilizando o Azure.


## Tecnologias Utilizadas

- **C#**: Linguagem de programação utilizada para desenvolver a aplicação de validação de CPF.
- **Azure Functions**: Serviço de computação serverless da Microsoft Azure utilizado para hospedar a aplicação.
- **Azure App Service**: Serviço de hospedagem utilizado para fazer o deploy da aplicação na nuvem.
- **Azure CLI**: Ferramenta de linha de comando utilizada para gerenciar os recursos do Azure.


## Como Executar a Aplicação Localmente

Para executar a aplicação localmente, siga os passos abaixo:

1. Clone o repositório para a sua máquina local.
2. Navegue até o diretório do projeto.
3. Execute o comando `func start` para iniciar a aplicação.

```bash
git clone <URL_DO_REPOSITORIO>
cd <DIRETORIO_DO_PROJETO>
func start
```

Certifique-se de substituir `<URL_DO_REPOSITORIO>` e `<DIRETORIO_DO_PROJETO>` pelos valores corretos.
### Validação de request
Em sua ferramenta de teste de API de preferência solicite um `Post`com a url disponibilizada no terminal em `Functions` e inclua no `Body` o CPF a ser validado

```json
{
    cpf:"<CPF_PARA_VALIDACAO>"
}
```

Certifique-se de substituir `<CPF_PARA_VALIDACAO>` pelo CPF em questão
.

## Descrição

A aplicação recebe um número de CPF pelo `Body` do request e verifica se ele é válido de acordo com as regras de validação do CPF brasileiro.


## Deploy na Nuvem

Para fazer o deploy da aplicação na nuvem, siga os comandos abaixo:

```bash
func azure functionapp publish NomeDaFunction
```

Certifique-se de substituir `NomeDaFunction` pelo nome da função criada na Azure CLoud