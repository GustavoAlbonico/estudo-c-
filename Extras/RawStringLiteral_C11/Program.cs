var literal1 = """ asdasdasd "teste literal" """;
System.Console.WriteLine(literal1);

var nome = "Gustavo";
var pais = "Brasil";

var literal2 = $$"""
                {
                    "nome": "{{nome}}"   
                    "pais": "{{pais}}"   
                }
               """;


var literal3 = $""" Ola meu nome é {nome} """;