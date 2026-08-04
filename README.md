# Estudos de C# e .NET

Repositório de exercícios didáticos sobre os fundamentos da linguagem C# e da
plataforma .NET. O conteúdo não forma uma única aplicação: cada pasta de aula é
um exemplo independente, criado para experimentar um conceito específico.

## Visão geral

O repositório possui duas trilhas principais:

| Trilha | Conteúdo | Formato |
| --- | --- | --- |
| [`roch`](roch/) | Fundamentos, entrada e saída, controle de fluxo, coleções, arquivos e introdução à orientação a objetos | Projetos de console SDK-style direcionados ao .NET 10 |
| [`cfb`](cfb/) | Fundamentos, orientação a objetos, tratamento de exceções e coleções | Arquivos C# avulsos; a aula 60 é um projeto Windows Forms para .NET Framework 4.7.2 |

Não há solução global, biblioteca compartilhada, banco de dados, API, testes
automatizados ou dependências NuGet. Os exemplos usam apenas recursos da
biblioteca padrão do .NET.

## Pré-requisitos

### Trilha `roch`

- SDK do .NET 10;
- terminal, Visual Studio, Visual Studio Code ou Rider.

Confira a instalação com:

```bash
dotnet --version
```

### Trilha `cfb`

As aulas 01 a 59 são arquivos avulsos, sem `.csproj`. Elas podem ser copiadas
para um projeto de console ou compiladas com um compilador C# compatível. A aula
60 requer Windows e uma instalação do Visual Studio com suporte ao .NET
Framework 4.7.2 e Windows Forms.

## Como executar

Cada projeto da trilha `roch` deve ser executado separadamente a partir da raiz
do repositório. Exemplo:

```bash
dotnet run --project roch/Aula10/Aula10.csproj
```

Para trabalhar com um arquivo da trilha `cfb` usando o SDK atual, crie um
projeto temporário e substitua o `Program.cs` pelo conteúdo da aula desejada:

```bash
dotnet new console -n AulaCfb
cp cfb/aula24/aula24.cs AulaCfb/Program.cs
dotnet run --project AulaCfb/AulaCfb.csproj
```

Alguns exemplos aguardam dados pelo terminal. Outros representam erros de
compilação de propósito ou ainda estão incompletos; consulte [Estado atual e
limitações](#estado-atual-e-limitações) antes de executá-los.

## Organização da trilha `roch`

| Aula | Tema principal |
| --- | --- |
| `Aula0`, `Aula01`, `DotnetVsCode` | Primeiro programa e saída no console |
| `Aula02` | Variáveis e tipos primitivos |
| `Aula03` | Constantes e tentativa inválida de reatribuição |
| `Aula04` | Entrada de nome e idade pelo console |
| `Aula05` | Operadores aritméticos em uma calculadora simples |
| `Aula06` | Condicional `if/else` e números pares/ímpares |
| `Aula07` | Operadores de atribuição |
| `Aula08` | Operadores relacionais |
| `Aula09` | Operadores lógicos |
| `Aula10` | Calculadora interativa com `while` e condicionais |
| `Aula11` | `switch` e classificação de desempenho escolar |
| `Aula12` | Laço `while` |
| `Aula13` | Laço `do/while` |
| `Aula14` | Laços `for` aninhados e tabela de multiplicação |
| `Aula15` | Percurso de lista com `foreach` |
| `Aula16` | Arrays: criação, acesso, alteração e tamanho |
| `Aula17` | `List<T>`: adicionar, remover, alterar e limpar |
| `Aula18` | Criação, atualização e leitura de arquivos |
| `Aula19` | Lista de compras interativa com persistência em texto |
| `Aula21` | Declaração de classes e atributos |
| `Aula22` | Instanciação de objetos e listas de objetos |
| `Aula23` | Métodos sem retorno |
| `Aula24` | Métodos com parâmetros e retorno |
| `Aula25` | Separação de responsabilidades em um terminal bancário |
| `Aula26` | Construtor sem parâmetros e valores padrão |
| `Aula27` | Construtor parametrizado |

Não existe uma pasta `roch/Aula20` no estado atual do repositório.

## Organização da trilha `cfb`

Esta trilha progride em blocos:

| Aulas | Conteúdo |
| --- | --- |
| 01–11 | Olá mundo, variáveis, escopo, operadores, formatação, constantes, entrada, deslocamento de bits, enums e conversões |
| 12–16 | Condicionais, `switch` e controle de fluxo com `goto` |
| 17–23 | Arrays, matrizes, `for`, `while`, `do/while`, `foreach` e métodos da classe `Array` |
| 24–27 | Métodos, parâmetros por `ref`, `out` e `params` |
| 28–33 | Classes, objetos, construtores, destrutor, membros estáticos, métodos e encapsulamento |
| 34–43 | Herança, níveis de acesso, construtores em cadeia, métodos virtuais, classes abstratas, `sealed`, propriedades, indexadores e interfaces |
| 44–50 | Estruturas, arrays de estruturas, relação entre objetos, sobrecarga, recursividade, membros estáticos e delegates |
| 52–54 | Exceções, `try/catch/finally`, `throw` e namespaces |
| 55–59 | `Dictionary`, `LinkedList`, `List` e `Queue` |
| 60 | Aplicação gráfica básica com Windows Forms |

A aula 02 está vazia. A aula 51 aparece em
`cfb/aula52/aula51/aula51.cs`, fora do padrão das demais pastas.

## Estrutura e fluxo dos exemplos

Os projetos de console têm um ponto de entrada `Main` ou usam instruções de
nível superior. Em geral, o fluxo é:

```text
Program/Main → leitura opcional do Console → regra demonstrada → saída no Console
```

Nas aulas orientadas a objetos, `Program` cria e coordena classes do mesmo
diretório. Os exemplos mais completos são:

- `roch/Aula19`: mantém uma lista em memória, permite incluir, remover e listar
  itens, e grava o resultado em `shopping_list.txt`;
- `roch/Aula25`: `BankTerminal` cuida do menu e delega saldo, depósito e saque a
  `BankOperations`;
- `cfb/aula60`: inicializa um formulário Windows Forms gerado pelo designer.

## Estado atual e limitações

Este é um repositório de prática, e vários arquivos registram tentativas e erros
didáticos. Portanto, não é esperado que todo o repositório compile como um
produto único.

Pontos relevantes encontrados na análise:

- `roch/Aula03` tenta alterar uma constante e não compila;
- `roch/Aula18` e `roch/Aula19` usam caminhos absolutos do Windows e precisam
  ser adaptadas para a máquina de quem executa;
- o menu de `roch/Aula25` não encerra o laço ao selecionar a opção 4;
- diversos campos não anuláveis da trilha `roch` não são inicializados, o que
  pode gerar avisos com nullable reference types habilitados;
- vários exemplos `cfb` contêm erros de compilação ou execução que fazem parte
  do processo de estudo, entre eles as aulas 19, 31, 34–36, 39–40, 42–43, 46–47
  e 59;
- executáveis `.exe` de algumas aulas `cfb` estão versionados junto aos fontes;
- não existem testes automatizados nem integração contínua.

Nesta análise, a compilação não pôde ser executada porque o comando `dotnet` não
está instalado no ambiente utilizado. As limitações acima foram identificadas
por inspeção estática dos fontes.

## Boas práticas para continuar o projeto

- Criar um `.csproj` para cada aula `cfb` que se deseje manter executável.
- Evitar caminhos absolutos; usar `Path.Combine` e diretórios relativos à
  aplicação.
- Validar entradas com `TryParse` para impedir encerramentos por valores
  inválidos.
- Corrigir ou marcar explicitamente exemplos que devem falhar.
- Adicionar `bin/`, `obj/`, `.vs/` e executáveis gerados ao `.gitignore`.
- Criar uma solução por trilha para facilitar build e navegação.
- Adicionar testes quando os exercícios evoluírem para regras reutilizáveis.

## Convenções para novas aulas

Para manter o repositório consistente:

1. crie uma pasta com numeração sequencial;
2. mantenha apenas um conceito principal por aula;
3. inclua um projeto SDK-style quando a aula precisar ser executável;
4. evite dados e caminhos específicos da máquina local;
5. registre no catálogo acima o objetivo da nova aula.
