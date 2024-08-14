// int x = 10;
// double pi =  3.1415;
// char letra = 'A';   
// bool isTrue = true;
// string texto =  "5";



// double outroValor;
// //conversao implicita
// outroValor = x; 
// //conversao explicita
// int valorInteiro = (int) pi;

// //conversao explicita com a classe Convert
// //int y =Convert.ToInt32(texto);                              

// //operadores
// //+,-,/,,==
// int numero;
// Console.WriteLine("Digite um numero");
// numero= Convert.ToInt32( Console.ReadLine());
// Console.WriteLine(numero);
// //Interpolaçao de strings
//Console.WriteLine($"O dobro do que o usuario digitou é: {numero * 2}");

double numero;
double numero2;

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

double soma = numero + numero2;
double sub = numero - numero2;
double multi = numero * numero2;
double div = numero / numero2;

Console.WriteLine("A soma dos valores informados é igual a " + soma);
Console.WriteLine($"A divisão do {numero} e {numero2} é igual a  {div}");
Console.WriteLine("A multiplicação entre {0} e {1} é igual a {2}", numero, numero2, multi);
Console.WriteLine("A divisão dos valores informados é igual a " + div);