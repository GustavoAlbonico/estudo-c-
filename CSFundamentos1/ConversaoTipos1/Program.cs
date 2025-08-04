System.Console.WriteLine("COnversao de tipos");


//conversao implcita
int varInt = 100;
double varDouble = varInt;

System.Console.WriteLine(varDouble);
int numeroInt = 12321;
long numeroLong = numeroInt;
long numeroFloat = numeroInt;
long numeroDouble = numeroInt;
long numeroDecimal = numeroInt;

System.Console.WriteLine(numeroInt);
System.Console.WriteLine(numeroLong);
System.Console.WriteLine(numeroFloat);
System.Console.WriteLine(numeroDouble);
System.Console.WriteLine(numeroDecimal);

//coversao explicita 

double varDouble1 = 12.456;
int varInt1 = (int)varDouble1;

System.Console.WriteLine(varInt1);