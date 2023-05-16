#include <stdio.h>

int main() {
    int capacidadeAtual, aumentoPercentual;
    float novaCapacidade;

    // Lendo os valores de capacidade atual e aumento percentual
    scanf("%d %d", &capacidadeAtual, &aumentoPercentual);

    // Calculando a nova capacidade total em teraflops
    novaCapacidade = capacidadeAtual * (1 + (aumentoPercentual / 100.0));

    // Imprimindo a nova capacidade total
    printf("%.0f\n", novaCapacidade);

    return 0;
}

