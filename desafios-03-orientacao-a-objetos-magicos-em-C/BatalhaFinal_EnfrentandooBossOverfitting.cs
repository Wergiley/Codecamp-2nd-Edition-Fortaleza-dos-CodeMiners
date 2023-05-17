#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

class FortalezaCodeMiner {
public:
  FortalezaCodeMiner(const vector<int>& equipamentos) : equipamentos_(equipamentos) {}

  bool possui_equipamento(int equipamento) {
    return std::binary_search(equipamentos_.begin(), equipamentos_.end(), equipamento);
  }

private:
  vector<int> equipamentos_;
};

class Overfitting {
public:
  Overfitting(const vector<int>& pontos_fracos) : pontos_fracos_(pontos_fracos) {}

  const vector<int>& pontos_fracos() const {
    return pontos_fracos_;
  }

private:
  vector<int> pontos_fracos_;
};

int main() {
  vector<int> pontos_fracos_chefao;
  vector<int> equipamentos_fortaleza;

  int n;

  // Lê os pontos fracos do Chefão Overfitting.
  cin >> n;
  for (int i = 0; i < n; i++) {
    int ponto_fraco;
    cin >> ponto_fraco;
    pontos_fracos_chefao.push_back(ponto_fraco);
  }

  // Lê os equipamentos da Fortaleza dos CodeMiners.
  cin >> n;
  for (int i = 0; i < n; i++) {
    int equipamento;
    cin >> equipamento;
    equipamentos_fortaleza.push_back(equipamento);
  }

  // Ordena a lista de equipamentos
  sort(equipamentos_fortaleza.begin(), equipamentos_fortaleza.end());

  // Cria objetos dos tipos Overfitting e FortalezaCodeMiner
  Overfitting chefao(pontos_fracos_chefao);
  FortalezaCodeMiner fortaleza(equipamentos_fortaleza);

  // Verifica se todos os pontos fracos do Chefão possuem equipamentos na Fortaleza
  bool vitoria = true;
  for (int ponto_fraco : chefao.pontos_fracos()) {
    if (!fortaleza.possui_equipamento(ponto_fraco)) {
      vitoria = false;
      break;
    }
  }

  // Imprimir resultado da batalha
  cout << (vitoria ? "Vencemos!" : "Perdemos!") << endl;

  return 0;
}

/*
Descrição
Após uma noite de gala no lançamento do livro de Hella na CodeMiners I/O, os trabalhos de mineração de dados voltaram a todo vapor. Com novas técnicas e boas práticas exploradas na conferência, a eficiência na mineração aumentou consideravelmente. Foi então que, finalmente, os CodeMiners localizaram a lendária masmorra do temido Boss Overfitting.

Overfitting é um Boss astuto, conhecido por sua capacidade de se adaptar excessivamente às estratégias de seus adversários, tornando-se imprevisível e difícil de ser derrotado. Os CodeMiners, durante séculos de mineração de dados, documentaram suas descobertas e identificaram as fraquezas do Boss Overfitting. Essas informações são valiosas, pois indicam quais equipamentos devem ser usados pelos CodeMiners para derrotá-lo.

O desafio consiste em criar um programa em C++ que utilize Orientação a Objetos e algoritmos de busca (busca linear, binária ou outros mais eficientes) para determinar se os CodeMiners têm em seu arsenal os equipamentos necessários para derrotar o Boss Overfitting. Para isso, teremos em nosso template de código as classes FortalezaCodeMiner e Boss com atributos relacionados às nossas entradas, além do método possui_equipamento preparado para implementação de seu algoritmo de busca escolhido.

Entrada
O programa receberá duas linhas:

A primeira contendo os pontos fracos do Boss (inteiros separados por espaços);
A segunda com os equipamentos disponíveis no Arsenal dos CodeMiners (inteiros separados por espaços).
Saída
O objetivo é verificar se a lista de equipamentos possui TODOS os itens necessários para eliminar os pontos fracos do Boss. Se sim, o programa deve imprimir "Vencemos!". Caso contrário, deve imprimir "Perdemos!".

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Se possivel poderia explica essa linha:

[std::binary_search(equipamentos_.begin(), equipamentos_.end(), equipamento);]

Muito interessante um detalhe que existe nessa pequena chamada de método.

Essa linha de código está usando a função std::binary_search da biblioteca padrão do C++. Essa função é usada para pesquisar um elemento em uma sequência ordenada. Vou explicar cada parte da chamada do método:

std::binary_search: é o nome da função que será chamada. Ela está definida no namespace std, que é o namespace padrão da biblioteca padrão do C++.

equipamentos_.begin(): equipamentos_ é um contêiner (como um vetor, uma lista ou um conjunto) que contém os elementos a serem pesquisados. O begin() é um método que retorna um iterador apontando para o primeiro elemento da sequência.

equipamentos_.end(): end() é um método que retorna um iterador apontando para o elemento seguinte ao último elemento da sequência.

equipamento: é o elemento que está sendo procurado na sequência. É importante notar que a sequência deve estar ordenada para que std::binary_search funcione corretamente.

A função std::binary_search retorna um valor booleano. Se o elemento equipamento for encontrado na sequência equipamentos_, o valor retornado será true. Caso contrário, será retornado false.

Uma característica interessante dessa chamada de método é que ela utiliza a busca binária para realizar a pesquisa. A busca binária é um algoritmo eficiente para encontrar um elemento em uma sequência ordenada. Ele divide repetidamente a sequência ao meio e compara o elemento desejado com o elemento central. Dessa forma, é possível descartar metade da sequência em cada iteração, o que reduz o tempo de busca em comparação com a busca linear.


-------------------------------------------------------------------------------------------------------------------------------------------
*/