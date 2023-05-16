#include <stdio.h>

int main() {
  int consumo1, consumo2, consumo3;
  float media;

  // Lendo os valores de consumo das três máquinas
  scanf("%d %d %d", &consumo1, &consumo2, &consumo3);

  // Calculando a média de consumo
  media = (consumo1 + consumo2 + consumo3) / 3.0;

  // Imprimindo a média com duas casas decimais
  printf("%.2f\n", media);

  return 0;
}
