
//declarando as variaveis de texto
string tex1 = "" , tex2 = "" , tex4 = "";
//declarando as variaveis inteiras 
int numcar = 0 , num = 0  ;
//declarando uma fala em string 
string p1 = @"Bom dia e para deixar claro sempre é bom dia, então vamos começar 
seja bem-vindo a esse projeto você vai poder digitar uma frase e ela será criptografada agora vamos começar.
Aperte qualquer botão"; 
  
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
//variavel para quardar a informação digitada
tex1 = Console.ReadLine()!;

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


//mudando uma variavel int para cada caracter em string 
numcar = tex1.Length;

for (int i = 0; i < numcar; i++)
{
    num = Convert.ToInt16(tex1[i]) - chave;
    tex2 += Convert.ToChar(num);
}

string p4 = $"[YUOSANO]:{tex2} \n";

for (int i = 0; i < p4.Length; i++)
{
    Console.Write(p4.ElementAt(i));
    Thread.Sleep(60);

}

string p5 = $"Então talvez você não esteja desconfiado que isso poder ser apenas palavras aleatorias então vamos ver se realmente isso '{tex1}' é isso {tex2}, aperte qualquer botão. \n";


for (int i = 0; i < p5.Length; i++)
  {
    Console.Write(p5.ElementAt(i));
    Thread.Sleep(60);
  }
  Console.ReadKey();

string p6 = $"[YUSANO]:digite seu texto criptografado: \n";

for (int i = 0; i < p6.Length; i++)
{
  Console.Write(p6.ElementAt(i));
  Thread.Sleep(60);
}
string tex3 = Console.ReadLine()!;

for (int i = 0; i < numcar; i++)
{
    num = Convert.ToInt16(tex3[i]) + chave;
    tex4 += Convert.ToChar(num);
}

string p7 = $"[YUSANO]:{tex3} é {tex4} \n";

for (int i = 0; i < p7.Length; i++)
{
    Console.Write(p7.ElementAt(i));
    Thread.Sleep(60);
}

string p8 = "[YUSANO]:Eu acho que fiz o que tinha que fazer agora quero dormir então aperte qualquer botão para finalizar até :] \n";
        
for (int i = 0; i < p8.Length; i++)
{
    Console.Write(p8.ElementAt(i));
    Thread.Sleep(60);
}

Console.ReadKey();
