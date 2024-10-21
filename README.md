# Jogo da Velha em .NET MAUI

## Descrição do Projeto

O **Jogo da Velha** é um clássico jogo de dois jogadores que é jogado em um tabuleiro 3x3. Cada jogador alterna turnos para marcar seu símbolo ("X" ou "O") em uma das células vazias do tabuleiro. O jogo termina quando um jogador forma uma linha com três símbolos ou quando todas as células são preenchidas, resultando em um empate.

---

## Funcionalidades

| Funcionalidade                     | Descrição                                                                                          |
|------------------------------------|---------------------------------------------------------------------------------------------------|
| **Interface Gráfica**              | Uma interface interativa e atraente com botões que representam as células do tabuleiro.          |
| **Marcação de Jogadas**            | Os jogadores podem marcar suas jogadas alternadamente, com "X" e "O" aparecendo nos botões.      |
| **Verificação de Vitoria**         | O sistema verifica automaticamente se um jogador venceu após cada jogada.                        |
| **Placar**                         | Um placar que acompanha as vitórias de cada jogador e empates durante a sessão de jogo.          |
| **Reinício do Jogo**               | O jogo pode ser reiniciado a qualquer momento, limpando o tabuleiro e reseteando as contagens.    |

---

## Estrutura do Projeto

### Arquivos Principais

| Arquivo                    | Descrição                                                         |
|---------------------------|------------------------------------------------------------------|
| `MainPage.xaml`           | Define a interface do usuário do jogo.                           |
| `MainPage.xaml.cs`        | Contém a lógica do jogo, gerenciando a alternância de turnos e as verificações de vitória. |

### Fluxo de Jogo

1. **Início**: O jogo é iniciado e os botões do tabuleiro são exibidos.
2. **Jogada**: Cada jogador clica em um botão para marcar sua jogada.
3. **Verificação**: Após cada jogada, o sistema verifica se há um vencedor ou um empate.
4. **Resultado**: Se houver um vencedor, uma mensagem é exibida e o placar é atualizado. Caso contrário, o jogo continua até que todas as jogadas sejam feitas.
5. **Reinício**: O jogo pode ser reiniciado a qualquer momento, permitindo uma nova partida.

---

## Interface do Usuário

A interface do jogo é composta por um grid 3x3 que representa o tabuleiro. Cada célula é um botão que pode ser clicado pelos jogadores. Além disso, há botões para exibir o placar e encerrar o jogo.

## Interface do Usuário

A interface do jogo é composta por um grid 3x3 que representa o tabuleiro. Cada célula é um botão que pode ser clicado pelos jogadores. Além disso, há botões para exibir o placar e encerrar o jogo.

### Exemplo de Layout

```plaintext
+---------------------------+
|         JOGO DA VELHA    |
+---------------------------+
|    [ X ]   [ O ]   [ X ]  |
|    [ O ]   [   ]   [ X ]  |
|    [ X ]   [ O ]   [ O ]  |
+---------------------------+
|  [ Placar ]  [ Fim de Jogo ] |
+---------------------------+
```

## Placar

O placar do jogo é atualizado automaticamente, mostrando as seguintes informações:

| Jogador   | Vitórias | Empates |
|-----------|----------|---------|
| Jogador X |    3     |    2    |
| Jogador O |    1     |    2    |

---

## Tecnologias Utilizadas

- **.NET MAUI**: Framework utilizado para o desenvolvimento de aplicativos multiplataforma.
- **C#**: Linguagem de programação utilizada para implementar a lógica do jogo.

---

## Contribuições

Contribuições são bem-vindas! Para colaborar, siga as etapas abaixo:

1. Faça um fork do repositório.
2. Crie uma nova branch (`git checkout -b feature-xyz`).
3. Faça suas alterações e commit (`git commit -m 'Add some feature'`).
4. Envie sua branch (`git push origin feature-xyz`).
5. Abra uma pull request.

---

## Licença

Este projeto está sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
