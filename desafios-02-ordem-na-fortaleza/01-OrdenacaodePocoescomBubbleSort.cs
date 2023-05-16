#include <stdio.h>

void bubbleSort(int arr[], int n) {
    int i, j;
    for (i = 0; i < n - 1; i++) {
        for (j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                // Troca os elementos de posição
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

int main() {
    int n;
    scanf("%d", &n);

    int frascos[n];
    for (int i = 0; i < n; i++) {
        scanf("%d", &frascos[i]);
    }

    bubbleSort(frascos, n);

    for (int i = 0; i < n; i++) {
        printf("%d ", frascos[i]);
    }
    printf("\n");

    return 0;
}

/*
Desafio
Na Fortaleza dos CodeMiners, há uma área especializada em alquimia, onde os aprendizes criam poções mágicas (extraídas dos óleos essenciais dos cogumelos da Grande Montanha) para aprimorar suas habilidades. As poções são armazenadas em frascos numerados e os aprendizes precisam organizá-las em ordem crescente de acordo com a numeração. Sua missão é criar um algoritmo em C que implemente o Bubble Sort¹ para ordenar os frascos de poção. Este algoritmo ajudará os aprendizes a manterem a área de alquimia organizada e eficiente.

¹ É um dos algoritmos de ordenação mais simples e é fácil de entender. Ele compara pares de elementos adjacentes e troca-os se estiverem fora de ordem, repetindo esse processo até que toda a lista esteja ordenada. Apesar de não ser eficiente, é um bom ponto de partida para o estudo de algoritmos de ordenação. Saiba mais aqui.

Entrada
1ª Linha: Número inteiro N (1 <= N <= 1000), representando a quantidade de frascos de poção.
2ª Linha: Lista com N números inteiros NÃO ORDENADOS e separados por espaços, representando a numeração de cada frasco de poção.
Saída
Imprima a lista de frascos de poção em ORDEM CRESCENTE, com cada número separado por um espaço.
*/