# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada **Estacionamento**, conforme o diagrama abaixo:

![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

- **precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.
- **precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.
- **veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

- **AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.
- **RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o cálculo:  

valorTotal = precoInicial + (precoPorHora * horas)

O valor é exibido formatado em moeda brasileira.
- **ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:

1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

---

## Solução
O código inicial estava incompleto, com métodos e `TODOs` a serem implementados. A seguir, o histórico de modificações realizadas:

### Histórico de modificações

**1. Adicionar veículo com validação de placa**  
- O método `AdicionarVeiculo` agora recebe a placa como parâmetro.  
- Antes de adicionar, o programa valida se a placa não está em branco ou nula.  
- Exibe mensagem de confirmação após adicionar o veículo.

**2. Remover veículo com validação e cálculo de valor**  
- Validação de existência do veículo (case-insensitive).  
- Solicitação da quantidade de horas com validação de entrada, evitando erros.  
- Cálculo do valor total:  

valorTotal = precoInicial + (precoPorHora * horas)

- Valor total exibido em moeda brasileira (`R$ xx,xx`).  
- Remove todos os veículos com a mesma placa informada.

**3. Listar veículos**  
- Lista todos os veículos estacionados.  
- Caso não haja veículos, exibe a mensagem "Não há veículos estacionados".

**4. Menu interativo melhorado**  
- Limpa a tela a cada iteração, mantendo a interface limpa.  
- Valida opção inválida, solicitando nova escolha.  
- Permite pressionar Enter para continuar entre operações.  
- Integração completa com os métodos da classe `Estacionamento`.

**5. Tratamento de entradas e valores**  
- Valores monetários exibidos no formato brasileiro (`R$ xx,xx`).  
- Preços e horas possuem validação para impedir erros de conversão.  
- Placas não podem ser vazias.

