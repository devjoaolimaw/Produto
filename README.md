# Produto

Este código em C# apresenta uma aplicação simples que utiliza structs, enums e classes para representar produtos e seus tipos. Aqui está um resumo/documentação do código:

### Namespaces e Classes

- **namespace structs**: Agrupa o código relacionado à definição de estruturas e enums.
  
- **class Program**: Contém o método `Main`, que é o ponto de entrada do programa. Dentro deste método, são criados exemplos de produtos e exibidas algumas informações sobre eles.

### Enumeração

- **enum EProductType**: Define os tipos de produtos possíveis. Neste caso, são dois tipos: `Product` e `Service`, representados por valores inteiros 1 e 2, respectivamente.

### Struct

- **struct Product**: Define uma estrutura `Product` que representa um produto. Ela possui os seguintes campos:
  
  - `Id`: Identificador único do produto.
  - `Name`: Nome do produto.
  - `Price`: Preço do produto.
  - `Type`: Tipo do produto, que é uma enumeração do tipo `EProductType`.
  
  Além disso, a struct possui um construtor que inicializa os campos `Id`, `Name`, `Price` e `Type` ao instanciar um novo produto.

### Método

- **PriceInDolar(double dolar)**: Um método dentro da struct `Product` que calcula o preço do produto em dólar com base na taxa de câmbio fornecida como argumento.

### Main Method

- No método `Main`, são criadas instâncias de produtos (`mouse` e `manutencaoEletrica`) com valores específicos para seus campos.
  
- O campo `Id` do produto `mouse` é modificado após a criação da instância.
  
- Em seguida, são exibidas informações sobre o produto `mouse`, incluindo seu `Id`, `Name`, `Price`, `Type` e o valor inteiro correspondente ao seu tipo.

Este código demonstra o uso de structs, enums e classes em C# para representar produtos e suas propriedades, bem como a interação básica com esses objetos.
