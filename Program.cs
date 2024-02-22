/*Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
impar
 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
 Google :even and odd number*/


Console.WriteLine("Introduce un numar: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Numarul este par.");
}

else
{
    Console.WriteLine("Nuarul este impar. ");
}
Console.ReadLine();
