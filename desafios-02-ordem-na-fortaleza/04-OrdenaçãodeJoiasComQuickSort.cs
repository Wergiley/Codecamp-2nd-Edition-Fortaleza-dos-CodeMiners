#include <stdio.h>

void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

int partition(int arr[], int low, int high) {
    int pivot = arr[high];
    int i = low - 1;

    for (int j = low; j <= high - 1; j++) {
        if (arr[j] < pivot) {
            i++;
            swap(&arr[i], &arr[j]);
        }
    }

    swap(&arr[i + 1], &arr[high]);
    return i + 1;
}

void quickSort(int arr[], int low, int high) {
    if (low < high) {
        int pi = partition(arr, low, high);

        quickSort(arr, low, pi - 1);
        quickSort(arr, pi + 1, high);
    }
}

int main() {
    int n;
    scanf("%d", &n);

    int joias[n];
    for (int i = 0; i < n; i++) {
        scanf("%d", &joias[i]);
    }

    quickSort(joias, 0, n - 1);

    for (int i = 0; i < n; i++) {
        printf("%d ", joias[i]);
    }
    printf("\n");

    return 0;
}
/*
Descrição
Na Fortaleza dos CodeMiners, há uma câmara secreta onde são guardadas joias preciosas utilizadas em rituais e cerimônias. As joias são numeradas com base em seu valor, e os guardiões desejam organizá-las em ordem crescente para facilitar a localização das joias necessárias para cada ocasião. Sua missão é criar um algoritmo em C que implemente o Quick Sort¹ para ordenar as joias. Com esse algoritmo, os guardiões poderão manter as joias organizadas de maneira eficiente e garantir que os rituais e cerimônias ocorram sem problemas.

¹ É um algoritmo de ordenação eficiente que utiliza a técnica de divisão e conquista. O Quick Sort seleciona um elemento chamado pivô e particiona a lista de forma que todos os elementos menores que o pivô fiquem à esquerda e os maiores à direita. O processo é repetido recursivamente nas sublistas geradas. A introdução do Quick Sort nesta etapa ajuda a entender o conceito de recursão e a importância da escolha do pivô. Saiba mais aqui.

Entrada
1ª Linha: Número inteiro N (1 <= N <= 100), representando a quantidade de joias.
2ª Linha: Lista com N números inteiros NÃO ORDENADOS e separados por espaços, representando o valor de cada joia.
Saída
Imprima a lista de joias em ORDEM CRESCENTE, com cada número separado por um espaço.
*/