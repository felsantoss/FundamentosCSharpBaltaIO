# Linguagens e Compiladores

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

# Sobre o C#
### É uma linguagem tipada, compilada e gerenciada. 

## Linguagem Gerenciada
### Significa que sua excução depende de um gerenciador, conhecido como Runtime. Em C# o Runtime de CLR (Commom Language Runtime), é responsável por gerenciar memória, segurança, entre outros recursos, com isso não é necessário se preocupar com alocação de memória entre outras coisas.

## IL - Intermediate Language
### Para não ser necessário criar um gerenciador para cada linguagem mantida pela Microsoft, os códigos das linguagens C#, F#, VB.Net etc, são compilados por seus respectivos compiladores e antes de serem convertidos para linguagem de máquina (código binário) eles geram um código intermediário, chamado de IL (Intermediate Language) e depois disso que ele é compilado para a linguagem de máquina.
### O processo de conversão do IL (Intermediate Languagem) para binário é conhecido como JIT (Just In Time).