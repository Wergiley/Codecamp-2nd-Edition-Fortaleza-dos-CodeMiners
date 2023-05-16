#include <stdio.h>

void insertionSort(int arr[], int n) {
    int i, chave, j;
    for (i = 1; i < n; i++) {
        chave = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] > chave) {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = chave;
    }
}

int main() {
    int n;
    scanf("%d", &n);

    int reliquias[n];
    for (int i = 0; i < n; i++) {
        scanf("%d", &reliquias[i]);
    }

    insertionSort(reliquias, n);

    for (int i = 0; i < n; i++) {
        printf("%d ", reliquias[i]);
    }
    printf("\n");

    return 0;
}
/*
Descrição
Na Fortaleza dos CodeMiners, o processo de mineração de dados, eventualmente, coleta relíquias místicas que possuem poderes incríveis. Essas relíquias são numeradas de acordo com sua raridade e os estudiosos desejam organizá-las em ordem crescente para facilitar a pesquisa e o estudo. Sua missão é criar um algoritmo em C que implemente o Insertion Sort¹ para ordenar as relíquias. Com esse algoritmo, os estudiosos poderão manter suas relíquias organizadas e acessíveis, permitindo um estudo mais eficiente das propriedades místicas.

¹ Um passo à frente do Bubble Sort, o Insertion Sort é outro algoritmo simples de entender e implementar. Ele funciona construindo uma sublista ordenada, inserindo elementos um a um em suas posições corretas. Apesar de ainda não ser o mais eficiente, é uma evolução natural no aprendizado após o Bubble Sort. Saiba mais aqui.

Entrada
1ª Linha: Número inteiro N (1 <= N <= 1000), representando a quantidade de relíquias.
2ª Linha: Lista com N números inteiros NÃO ORDENADOS e separados por espaços, representando a raridade de cada relíquia.
Saída
Imprima a lista de relíquias em ORDEM CRESCENTE, com cada número separado por um espaço.
*/