## Exercício 1

Enunciado:

Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
 
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

Output:
2025
3025
9801

## Exercício 2

Enunciado:

Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo.

Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.


Inputs: 
7

Output:
O número 7 é um número primo

### Números Perfeitos de 1 a 1000 ###
6
28
496

## Exercício 3

Enunciado:

Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

Input:

Array 1 - [1,2,3,4,5]
Array 2 - [2,3,4,6,7]

Output:

Itens em comum:
2
3
4

Itens diferentes:
6
7

## Exercício 4

Enunciado:

Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

Input:
(Col, Lin)
(1,1) -> 1
(1,2) -> 2
(1,3) -> 3
(1,4) -> 4
(1,5) -> 5
(2,1) -> 5
(2,2) -> 4
(2,3) -> 3
(2,4) -> 2
(2,5) -> 1
(3,1) -> 2
(3,2) -> 2
(3,3) -> 2
(3,4) -> 2
(3,5) -> 2

Matriz = [
	1 2 3 4 5
	5 4 3 2 1
	2 2 2 2 2
]

Output:

Exibindo soma de todas as colunas da matriz:
A soma de valores da linha 1 é 8:
A soma de valores da linha 2 é 8:
A soma de valores da linha 3 é 8:
A soma de valores da linha 4 é 8:
A soma de valores da linha 5 é 8:

Exibindo soma de todas as colunas da matriz:
A soma de valores da coluna 1 é 15:
A soma de valores da coluna 2 é 15:
A soma de valores da coluna 3 é 10:


# Exercício 5

Enunciado:

Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

Input:
6

Output:
A fatorial de 6 é: 720

# Exercício 6

Enunciado:
Faça um programa que chame uma função capaz de calcular x elevado a y, sendo x e y inteiros.
Utilize passagem de parâmetros por referência.

Input:
x = 6
y = 5

7776
