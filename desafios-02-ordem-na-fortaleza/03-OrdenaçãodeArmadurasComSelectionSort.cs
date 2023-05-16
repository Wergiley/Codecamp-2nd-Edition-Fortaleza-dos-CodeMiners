#include <stdio.h>

void selectionSort(int arr[], int n) {
    int i, j, maxIndex, temp;
    for (i = 0; i < n - 1; i++) {
        maxIndex = i;
        for (j = i + 1; j < n; j++) {
            if (arr[j] > arr[maxIndex]) {
                maxIndex = j;
            }
        }
        temp = arr[i];
        arr[i] = arr[maxIndex];
        arr[maxIndex] = temp;
    }
}

int main() {
    int n;
    scanf("%d", &n);

    int armaduras[n];
    for (int i = 0; i < n; i++) {
        scanf("%d", &armaduras[i]);
    }

    selectionSort(armaduras, n);

    for (int i = 0; i < n; i++) {
        printf("%d ", armaduras[i]);
    }
    printf("\n");

    return 0;
}
/*
Descrição
Os guerreiros da Fortaleza dos CodeMiners precisam manter suas armaduras em ordem, para facilitar a escolha do equipamento certo antes das batalhas. As armaduras são numeradas de acordo com seu nível de proteção, e os guerreiros desejam organizá-las em ordem decrescente. Sua missão é criar um algoritmo em C que implemente o Selection Sort¹ para ordenar as armaduras. Com esse algoritmo, os guerreiros poderão encontrar a armadura mais adequada rapidamente, o que pode ser crucial em uma situação de combate.

¹Este algoritmo é um pouco mais avançado que os anteriores. Ele divide a lista em duas partes: a parte ordenada e a parte não ordenada. A cada iteração, o algoritmo seleciona o menor (ou maior) elemento da parte não ordenada e o move para o final da parte ordenada. Isso ajuda a entender melhor a divisão do trabalho em algoritmos de ordenação. Saiba mais aqui.

Entrada
1ª Linha: Número inteiro N (1 <= N <= 1000), representando a quantidade de armaduras.
2ª Linha: Lista com N números inteiros NÃO ORDENADOS e separados por espaços, representando o nível de proteção de cada armadura.
Saída
Imprima a lista de armaduras em ORDEM DECRESCENTE, com cada número separado por um espaço.
*/