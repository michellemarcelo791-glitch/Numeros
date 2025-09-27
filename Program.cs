//Literais inteiros
Console.WriteLine("--- Operações com Inteiros");
int intn1 = 2;
int intn2 = 7;
int intSoma = intn1 + intn2;
int intsubtracao = intn2 - intn1;
int intmultiplicacao = intn2 * intn1;
int intdivisao = intn1 / intn2;
Console.WriteLine($"Soma: {intn1} + {intn2} = {intSoma}");
Console.WriteLine($"Soma: {intn1} - {intn2} = {intsubtracao}");
Console.WriteLine($"Soma: {intn1} * {intn2} = {intmultiplicacao}");
Console.WriteLine($"Soma: {intn1} / {intn2} = {intdivisao}");


//Operações com inteiros: resto da divisão
Console.WriteLine("--- Literais em ponto flutuante");
double a = 1;
double b = +1;
double c = -1;
double d = 0.1;
double e = .1;
double f = 1.0;
double g = 1e0 ;    //1 * 10^0
double h = 1d;
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = {c}");
Console.WriteLine($"d = {d}");
Console.WriteLine($"e = {e}");
Console.WriteLine($"f = {f}");
Console.WriteLine($"g = {g}");
Console.WriteLine($"h = {h}");

//Operações com ponto flutuante
Console.WriteLine("--- Operações com ponto flutuante: double");
double doubleX = 2;
double doubleY = 8;
double doubleSoma = doubleX + doubleY;
double doubleSub = doubleX - doubleY;
double doubleMult = doubleX * doubleY;
double doubleDivisao = doubleX / doubleY;
Console.WriteLine($"Soma: {doubleX} + {doubleY} = {doubleSoma}");
Console.WriteLine($"Soma: {doubleX} - {doubleY} = {doubleSub}");
Console.WriteLine($"Soma: {doubleX} * {doubleY} = {doubleMult}");
Console.WriteLine($"Soma: {doubleX} / {doubleY} = {doubleDivisao}");

//Operações com ponto flutuante:decimal
Console.WriteLine("--- Operações com ponto flutuante: decimal");
decimal decimalX = 2;
decimal decimalY = 6;
decimal decimalSoma = decimalX + decimalY;
decimal decimalSub = decimalY - decimalX;
decimal decimalMult = decimalX * decimalY;
decimal decimalDivisao = decimalY / decimalX;
Console.WriteLine($"Soma: {decimalX} + {decimalY} = {decimalSoma}");
Console.WriteLine($"Soma: {decimalY} - {decimalX} = {decimalSub}");
Console.WriteLine($"Soma: {decimalY} * {decimalX} = {decimalMult}");
Console.WriteLine($"Soma: {decimalX} / {decimalY} = {decimalDivisao}");

//Formatação de números em ponto flutuante
Console.WriteLine("--- Formatação de números em pontos flutuantes");
Console.WriteLine($"Double = {doubleDivisao} | Decimal = {decimalDivisao} -- sem formatação");
Console.WriteLine($"Double = {doubleDivisao:N} | Decimal = {decimalDivisao:N} -- formato Número");
