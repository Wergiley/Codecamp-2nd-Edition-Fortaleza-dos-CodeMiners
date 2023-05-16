#include <stdio.h>

int main() {
    int temperatura;

    // Lendo a temperatura atual
    scanf("%d", &temperatura);

    // Verificando a classificação da temperatura
    if (temperatura < 18) {
        printf("Baixa\n");
    } else if (temperatura > 24) {
        printf("Alta\n");
    } else {
        printf("Ideal\n");
    }

    return 0;
}

/*
Descrição
Com o estoque de cogumelos nas alturas, os CodeMiners estão produzindo sua famosa cerveja artesanal e agora precisam monitorar sua temperatura constantemente. A temperatura é um fator crítico para garantir a qualidade da cerveja, e um desvio dos valores ideais pode afetar negativamente seu sabor e aroma. Para solucionar esse problema, será criado um programa em C que será embarcado na cervejeira e fornecerá leituras em tempo real da temperatura, permitindo que os CodeMiners monitorem a cerveja durante todo o processo de produção.

Entrada
Um número inteiro representando a temperatura atual.

Saída
Uma string: "Ideal" se a temperatura estiver no intervalo ideal, "Baixa" se estiver abaixo de 18 graus e "Alta" se estiver acima de 24 graus.
*/