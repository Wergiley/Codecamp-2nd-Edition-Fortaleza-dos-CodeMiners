#include <stdio.h>

int main() {
    int minutos, cogumelos;

    // Lendo a quantidade de minutos disponíveis para a colheita
    scanf("%d", &minutos);

    // Calculando a quantidade de cogumelos colhidos
    cogumelos = minutos / 3;

    // Imprimindo a quantidade de cogumelos colhidos
    printf("%d\n", cogumelos);

    return 0;
}

/*
Descrição
Com as máquinas trabalhando e as picaretas cansadas, os CodeMiners precisam colher cogumelos para aumentar o seu estoque. Após desvendar os nomes das divindades no desafio anterior, os CodeMiners foram abençoados e a colheita de cogumelos tornou-se mais abundante. Com isso, eles agora conseguem colher 1 cogumelo a cada 3 minutos. Crie um programa em C que preveja quantos cogumelos serão colhidos em um determinado período de tempo.

Entrada
Um número inteiro representando a quantidade de minutos disponíveis para a colheita.

Saída
Um número inteiro representando a quantidade de cogumelos colhidos.
*/