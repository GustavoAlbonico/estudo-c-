Console.WriteLine("COnversao de tipos");


//conversao implcita
int varInt = 100;
double varDouble = varInt;

Console.WriteLine(varDouble);
int numeroInt = 12321;
long numeroLong = numeroInt;
long numeroFloat = numeroInt;
long numeroDouble = numeroInt;
long numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

//coversao explicita 

double varDouble1 = 12.456;
int varInt1 = (int)varDouble1;

Console.WriteLine(varInt1);

//---------------//
int valorInt2 = 123;
double valorDouble2 = 12.45;
decimal valorDecimal2 = 12.8548m;

string s1 = valorInt2.ToString();
string s2 = valorDouble2.ToString();
string s3 = valorDecimal2.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

//------  Convert class ---------// 
//quando houver erro vai dispara uma exception

int valorInt3 = 123;
double valorDouble3 = 12.45;
decimal valorDecimal3 = 12.8548m;


Console.WriteLine(Convert.ToString(valorInt3));
Console.WriteLine(Convert.ToDouble(valorInt3));
Console.WriteLine(Convert.ToString(valorDouble3));
Console.WriteLine(Convert.ToInt32(valorDecimal3));
