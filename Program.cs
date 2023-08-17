
Console.Clear();

//declarando as variaveis de texto
string tex1 = "" , tex2 = "" , tex4 = "";
//declarando as variaveis inteiras 
int numcar = 0 , num = 0  ;
//declarando uma fala em string 
string p1 = @"Bom dia e para deixar claro sempre é bom dia, então vamos começar 
seja bem-vindo a esse projeto você vai poder digitar uma frase e ela será criptografada agora vamos começar.
Aperte qualquer botão"; 
//TINGE AS LETRAS DE AMARELO
Console.ForegroundColor = ConsoleColor.Yellow;

//formando um laço para digitar letra por letra 
for (int i = 0; i < p1.Length; i++)
  {
    Console.Write(p1.ElementAt(i));
    Thread.Sleep(60);

  }
//aperte qualquer botão para continuar 
Console.ReadKey();
//declarando uma fala em string 
string p2 = "Digite o texto que deseja Criptografar:";
//mais uma vez criando um laço para digitar letra por letra 
for (int i = 0; i < p2.Length; i++)
  {
    Console.Write(p2.ElementAt(i));
    Thread.Sleep(60);
   }
//RESETA A COR
Console.ResetColor();
//TINGE AS LETRAS DE VERDE
Console.ForegroundColor = ConsoleColor.Green;

//variavel para quardar a informação digitada
tex1 = Console.ReadLine()!;
//RESETA A COR
Console.ResetColor();
//TINGE AS LETRAS DE AMARELO
Console.ForegroundColor = ConsoleColor.Yellow;
//mais uma fala 
string p3 = "Digite sua chave:";
//mais um laço para digitar cada letra    
for (int i = 0; i < p3.Length; i++)
  {
    Console.Write(p3.ElementAt(i));
    Thread.Sleep(60);
  }

//quardando a informação digitada
int chave = Convert.ToInt16( Console.ReadLine());
//RESETA A COR
Console.ResetColor();

//mudando uma variavel int para cada caracter em string 
numcar = tex1.Length;
//TINGE AS LETRAS DE AMARELO
Console.ForegroundColor = ConsoleColor.Yellow;

//mais um laço mas dessa vez é para adicionar mais um toda vez que o numcar for menor que i 
//mas não para a string toda mas sim para cada caracter da string 
for (int i = 0; i < numcar; i++)
{
    num = Convert.ToInt16(tex1[i]) - chave;
    tex2 += Convert.ToChar(num);
}

//declarando mais uma string 
string p4 = $"[YUOSANO]:{tex2} \n";

//mais um laço para digitar letra por letra 
for (int i = 0; i < p4.Length; i++)
{
    Console.Write(p4.ElementAt(i));
    Thread.Sleep(60);

}
//declarando mais uma string 
string p5 = $"Então talvez você não esteja desconfiado que isso poder ser apenas palavras aleatorias então vamos ver se realmente isso '{tex1}' é isso \n {tex2}, aperte qualquer botão. \n";

//declarando mais uma string 
for (int i = 0; i < p5.Length; i++)
  {
    Console.Write(p5.ElementAt(i));
    Thread.Sleep(60);
  }
  //aperte qualquer botão 
  Console.ReadKey();
//declarando mais uma strincg
string p6 = $"[YUSANO]:digite seu texto criptografado: \n";

//mais um laço para digitar letra por letra 
for (int i = 0; i < p6.Length; i++)
{
  Console.Write(p6.ElementAt(i));
  Thread.Sleep(60);
}
//RESETA A COR
  Console.ResetColor();
//TINGE AS LETRAS DE VERDE
Console.ForegroundColor = ConsoleColor.Green;

//declarando mais uma variavel string 
string tex3 = Console.ReadLine()!.ToUpper();
//RESETA A COR
Console.ResetColor();
//TINGE AS LETRAS DE AMARELO
Console.ForegroundColor = ConsoleColor.Yellow;
//mais um laço para digitar letra por letra 
for (int i = 0; i < numcar; i++)
{
    num = Convert.ToInt16(tex3[i]) + chave  ;
    tex4 += Convert.ToChar(num);
}
//declarando mais uma variavel string 
string p7 = $"[YUSANO]:{tex3} é {tex4} \n";
//mais um laço para digitar letra por letra 
for (int i = 0; i < p7.Length; i++)
{
    Console.Write(p7.ElementAt(i));
    Thread.Sleep(60);
}
//declarando mais uma variavel string
string p8 = "[YUSANO]:Eu acho que fiz o que tinha que fazer agora quero dormir então aperte qualquer botão para finalizar até :] \n";
 //mais um laço para digitar letra por letra        
for (int i = 0; i < p8.Length; i++)
{
    Console.Write(p8.ElementAt(i));
    Thread.Sleep(60);
}
//RESETA A COR
Console.ResetColor();
//variavel para quardar a informação digitada
Console.ReadKey();



