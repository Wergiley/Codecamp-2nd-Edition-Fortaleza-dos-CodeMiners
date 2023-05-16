#include <stdio.h>
#include <string.h>

void inverterTexto(char* texto) {
    int tamanho = strlen(texto);
    int i, j;

    for (i = 0, j = tamanho - 1; i < j; i++, j--) {
        // Troca as letras de posição
        char temp = texto[i];
        texto[i] = texto[j];
        texto[j] = temp;
    }
}

int main() {
    char texto[101];

    // Lendo o texto com a palavra misteriosa
    scanf("%s", texto);

    // Invertendo o texto
    inverterTexto(texto);

    // Imprimindo o texto invertido
    printf("%s\n", texto);

    return 0;
}

/*
Descrição
Com o avanço inédito às profundezas da Grande Montanha, 
os CodeMiners encontraram um pergaminho antigo com códigos secretos em um local
que exala uma energia divina. Eles precisam decifrar o código, 
que consiste em um conjunto simples de palavras. Escreva um programa em C
 que inverta a ordem das letras para revelar as palavras secretas.

Entrada
Um texto com uma palavra misteriosa (com no máximo 100 caracteres) sem espaços.

Saída
O texto invertido.
*/