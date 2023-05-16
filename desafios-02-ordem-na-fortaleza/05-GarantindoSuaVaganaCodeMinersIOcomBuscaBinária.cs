#include <stdio.h>
#include <stdbool.h>


void trocar(int *a, int *b) {
  int temp = *a;
  *a = *b;
  *b = temp;
}


bool estaOrdenado(int array[], int quantidade) {
  for (int i = 1; i < quantidade; i++) {
    if (array[i - 1] > array[i]) {
      return false;
    }
  }
  return true;
}


void bogoSort(int array[], int quantidade) {
  while (!estaOrdenado(array, quantidade)) {
    for (int i = 0; i < quantidade; i++) {
      int j = i + rand() % (quantidade - i);
      trocar(&array[i], &array[j]);
    }
  }
}


int buscaBinaria(int array[], int quantidade, int valor) {
  int esquerda = 0;
  int direita = quantidade - 1;
  while (esquerda <= direita) {
    int meio = (esquerda + direita) / 2;
    if (array[meio] == valor) {
      return meio;
    } else if (array[meio] < valor) {
      esquerda = meio + 1;
    } else {
      direita = meio - 1;
    }
  }
  return -1;
}


int main() {
  // Lê os nossos dados de entrada:
  int quantidade;
  scanf("%d", &quantidade);
  int conteudos[quantidade];
  for (int i = 0; i < quantidade; i++) {
    scanf("%d", &conteudos[i]);
  }


  // Ordena os conteúdos usando Bogo Sort
  bogoSort(conteudos, quantidade);


  bool encontrou = buscaBinaria(conteudos, quantidade, 777) != -1;


  if (encontrou) {
    printf("S\n");
  } else {
    printf("N\n");
  }


  return 0;
}

/* 
Descrição
Em meio aos corredores da Fortaleza dos CodeMiners, você encontra uma magnífica biblioteca repleta de livros, pergaminhos e discos de Mithril, todos meticulosamente organizados. Esta biblioteca é gerida por Hella, uma CodeMiner conhecida por sua sagacidade, paixão e habilidades literárias. Você a encontra trabalhando em seu novo livro, "O Senhor dos Dados: O Retorno do Array", que precisa ser finalizado até o fim do dia para ser lançado na "CodeMiners I/O". Neste evento, jovens talentos serão treinados em mineração de dados no majestoso salão nobre da Fortaleza.

Percebendo a preocupação da escritora com o tempo, você se oferece para ajudá-la. Hella, então, propõe um acordo: se você desenvolver uma solução capaz de identificar a presença de conteúdos do tipo 777 (projetos práticos sobre a temática do seu novo livro) nas estantes da biblioteca, ela lhe concederá uma cadeira de honra na "CodeMiners I/O". Sua missão é criar um algoritmo em C que implemente, preferencialmente, uma Busca Binária¹ para verificar se uma determinada estante possui um conteúdo do tipo 777. Com isso, você ajudará Hella a encontrar de forma eficiente as localizações dos materiais complementares para o lançamento do livro, além de garantir sua cadeira de honra no evento.

¹ Busca Binária é um algoritmo eficiente para encontrar um elemento em uma lista ordenada. Ele divide a lista ao meio e compara o elemento do meio com o valor desejado. Dependendo da comparação, ele descarta metade da lista e repete o processo até encontrar o elemento desejado ou reduzir a lista a zero. Isso ensina a importância da otimização de algoritmos de busca e como a ordenação pode ser útil nesse contexto. Saiba mais aqui.

Entrada
1ª Linha: Número inteiro N (1 <= N <= 1000), representando a quantidade de conteúdos na estante da biblioteca.

2ª Linha: Lista com N números inteiros NÃO ORDENADOS e separados por espaços, representando os tipos de cada conteúdo de uma estante da biblioteca. Entretanto, prevendo a necessidade de ordenação dos conteúdos para uma Busca Binária efetiva, Hella já aplicou um de seus algoritmos de ordenação no código base deste desafio.

Saída
Se o conteúdo do tipo 777 for encontrado na lista, imprima "S" (sem as aspas). Caso contrário, imprima "N" (sem as aspas).

-------------------------------------------------------------------------------------------------------------------------------------------
Código a ser estudado, pois retorna erro de lógica.
#include <stdio.h>

int binarySearch(int arr[], int left, int right, int target) {
    while (left <= right) {
        int mid = left + (right - left) / 2;

        if (arr[mid] == target) {
            return 1; // Conteúdo do tipo 777 encontrado
        }

        if (arr[mid] < target) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }

    return 0; // Conteúdo do tipo 777 não encontrado
}

int main() {
    int n;
    scanf("%d", &n);

    int estante[n];
    for (int i = 0; i < n; i++) {
        scanf("%d", &estante[i]);
    }

    int target = 777;
    int found = binarySearch(estante, 0, n - 1, target);

    if (found) {
        printf("S\n");
    } else {
        printf("N\n");
    }

    return 0;
}

*/