int[] numeros = [1, 2, 3, 4, 5];
Span<string> span = ["asdasd", "sadasdasd", "asdasdas"];
ReadOnlySpan<string> readOnlySpan = ["asdasd", "sadasdasd", "asdasdas"];

List<int> lista1 = [1, 2, 3];
List<int> lista2 = [4, 5, 6];
List<int> listaCombinada = [.. lista1, .. lista2];


// VALOR PADRÃO LAMBDA
var incrementarValor = (int origem, int incremento = 2) => origem + incremento;