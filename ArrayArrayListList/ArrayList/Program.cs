using System.Collections;

ArrayList lista;
lista = new ArrayList();

ArrayList lista1 = new ArrayList();
var lista2 = new ArrayList();
ArrayList lista3 = new();

ArrayList lista4 = new ArrayList(5); //capacity 5
var lista5 = new ArrayList(5);//capacity 5
ArrayList lista6 = new(5);//capacity 5

ArrayList lista7 = new();

lista7.Add("Paulo");
lista7.Add(4.5);
lista7.Add(5);
lista7.Add(true);
lista7.Add(null);
lista7.Add(" ");

var lista8 = new ArrayList() { "Paulo", 4.5, 5, true, null, " " };

lista8.Add("Carlos");//adiciona ao final
lista8.Insert(2, "José");//adiciona na posição informada


var lista9 = new ArrayList() { "Maria", 5, true, null };

int[] array1 = { 1, 2, 3 };

lista9.AddRange(array1); //adicionando coleção vai ficar ["Maria", 5, true, 1 , 2, 3]
lista9.InsertRange(2, array1);

lista9.Remove(null);//'objeto'
lista9.RemoveAt(2); //indice
lista9.RemoveRange(2, 2); //inicio|quantidade 

var lista10 = new ArrayList() { "Maria", 5, true, null, 4.5, DateTime.Now };

var res1 = lista10.Contains("Maria");//verifica se possui o elelemto na lista
bool res2 = lista10.Contains(5);

var lista11 = new ArrayList() { "Maria", "Roberto", "Ana Luiza", "Pitagoras", "Carlos" };

lista11.Sort();//ordena o arraylist
lista11.Clear();//limpa o arraylist
Console.WriteLine(lista11.Count); //verifica o tamnho do arraylist

//recomendado usar list atualmente e nao arraylist pelo desempenho não ser tão eficiente