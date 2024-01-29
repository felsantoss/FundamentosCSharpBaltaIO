# [Curso Fundamentos do C# - Balta IO](https://balta.io/cursos/fundamentos-csharp)

## O que é uma linguagem de programação? 
### É a forma que nós desenvolvedores escrevemos instruções para o computador executar alguma tarefa. O computador não entende as linguagens de programação, ele entende somente código binário (0 1) por isso existe os compiladores e interpretadores. 

## Compiladores
### Eles executam a compilação do nosso código escrito em linguagem de alto nível para a linguagem que o computador consegue executar que são os códigos binários (0 1). O código ele é compilado gerando um arquivo de execução. 

## Vantagens

    - Tempo de compilação
    - Detecção mais rápida de erros
    - Apenas um arquivo final 


## Intepretadores
### O processo de interpretação transformará o código em linguagem de máquina, sendo assim possível sua execução. Esse processo irá ocorrer aos poucos, pois o interpretador irá realizar a conversão analisando linha por linha, e não o programa inteiro, diferentemente do que ocorre com o compilador.

## Vantagens

    - Correções mais fácil
    - Mais simples de serem distribuidas

## Sobre o C#
### É uma linguagem tipada, compilada e gerenciada. 

## Linguagem Gerenciada
### Significa que sua excução depende de um gerenciador, conhecido como Runtime. Em C# o Runtime de CLR (Commom Language Runtime), é responsável por gerenciar memória, segurança, entre outros recursos, com isso não é necessário se preocupar com alocação de memória entre outras coisas.

## IL - Intermediate Language
### Para não ser necessário criar um gerenciador para cada linguagem mantida pela Microsoft, os códigos das linguagens C#, F#, VB.Net etc, são compilados por seus respectivos compiladores e antes de serem convertidos para linguagem de máquina (código binário) eles geram um código intermediário, chamado de IL (Intermediate Language) e depois disso que ele é compilado para a linguagem de máquina.
### O processo de conversão do IL (Intermediate Languagem) para binário é conhecido como JIT (Just In Time).

## Frameworks
### Framework é um conjunto de biblioteca que usamos como base para construir nossas aplicações.

## .NET Standard
### O .NET Standard não é um Framework ele é apenas um contrato, chamado também de Surface API, o .NET Standard garante que todo o código escrito funcionará tanto no .NET Framework quanto no .NET Core. 

## LTS (Long Term Support)
### LTS ou Long Term Support, em português Suporte de Longa Data são as versões do framework recomendado pela Microsoft para que seja utilizado em produção. 

## Namespace
### Enquanto as pastas são as divisões físicas no disco, o namespace são as divisões lógicas, assim não podemos ter dois arquivos com o mesmo nome nas pastas. O ideal é ter apenas um namespace e uma classe por arquivo. 

## Using
### Ao utilizarmos a palavra reservada ***using*** conseguimos fazer as importações das bibliotecas necessárias que nosso programa irá utilizar. 

## Object
### Tipo genérico que recebe qualquer valor, exemplo: 

```
    object idade = 26; // Será do tipo object
    object nome = "Felipe"; // Será do tipo object
```

