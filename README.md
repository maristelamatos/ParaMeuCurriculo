# ParaMeuCurriculo
## jogo contador 
Etapa 1: 
Importação da Biblioteca
Aqui, estamos importando o namespace System, que contém classes fundamentais, incluindo a classe Console e Random
Etapa 2:
Criação da Classe e Método Principal
Classe: Definimos uma classe chamada Program, que é a estrutura básica de um programa em C#.
Método Main: O Main é o ponto de entrada do programa, onde a execução começa
Etapa 3: 
Solicitação de Entrada do Usuário
Saída: Usamos Console.WriteLine para pedir ao usuário quantos jogos ele deseja gerar.
Entrada: Console.ReadLine() captura a entrada do usuário como uma string, e int.Parse converte essa string em um inteiro, armazenando na variável jogadas.
Etapa 4: 
Solicitação do Número de Dezenas
O processo se repete para solicitar quantas dezenas (números) o usuário deseja em cada jogo.
Etapa 5: 
Criação do Objeto Random
Criamos uma instância da classe Random para gerar números aleatórios. Essa instância será usada para garantir que os números sejam gerados corretamente.
Etapa 6: 
Loop para Gerar os Jogos
Este loop for é responsável por iterar de 1 até o número de jogos que o usuário especificou.
Etapa 7:
Loop para Gerar as Dezenas
Dentro do primeiro loop, temos um segundo loop que vai de 1 até o número de dezenas que o usuário deseja. Este loop gera os números aleatórios.
Etapa 8:
Geração de Números Aleatórios
Aqui, geramos um número aleatório entre 1 e 60 (o 61 é exclusivo). Este número representa uma dezena no jogo.
Etapa 9: 
Formatação da Saída
Utilizamos um if para verificar se o número gerado é o último da sequência. Se for, imprimimos o número sem o traço. Para os números intermediários, adicionamos um traço para separá-los.
Etapa 10: 
Nova Linha para Cada Jogo
Após imprimir todas as dezenas de um jogo, chamamos Console.WriteLine() para pular para a próxima linha, separando os jogos visualmente.