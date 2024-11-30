## Gerenciador de Contatos

Este é um simples programa de linha de comando, desenvolvido em **C#**, que permite gerenciar uma lista de contatos.
O programa oferece funcionalidades para **adicionar**, **remover**, **buscar** e **listar contatos**, utilizando um **Dictionary** para armazená-los de forma eficiente.

### Funcionalidades

- **Adicionar Contato**: Permite adicionar um novo contato com nome, número de telefone e e-mail.
- **Remover Contato**: Permite remover um contato existente, informando seu nome.
- **Buscar Contato**: Permite buscar um contato pelo nome, exibindo as informações armazenadas.
- **Listar Todos os Contatos**: Exibe todos os contatos cadastrados no sistema.

## Estrutura de Dados

Os contatos são armazenados em um Dictionary no qual a chave é o nome do contato e o valor é um objeto da classe Contato.
A classe Contato contém as propriedades: Nome, Telefone e Email.

```sh
{
    "Benício": {
        "Nome": "Benício",
        "Telefone": "123456789",
        "Email": "benicio@email.com"
    }
}
```

## Exemplo de Interação

1. Adicionar contato

```sh
Digite o nome: Benício
Digite o número de telefone: 82987514902
Digite o e-mail: beniciobrandao@hotmail.com
Contato adicionado com sucesso.
```

2. Buscar contato

```sh
Digite o nome do contato que deseja buscar: Benício
Benício
Telefone: 82987514902
E-mail: beniciobrandao@hotmail.com
```
## Contribuição

Se você deseja contribuir para este projeto, siga os passos abaixo:

- Faça um fork deste repositório.
- Crie uma nova branch (git checkout -b minha-contribuicao).
- Realize as alterações e faça commit (git commit -am 'Adiciona minha contribuição').
- Envie as alterações para o seu fork (git push origin minha-contribuicao).
- Crie um Pull Request.
