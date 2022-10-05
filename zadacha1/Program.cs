//Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("enter number:");
int num = int.Parse(Console.ReadLine());
// and &&
if ((num %7==0) && (num %23==0))
    Console.WriteLine("cratno 3 and 7");
else
      Console.WriteLine("ne kratno 3 and 7");
//Console.WriteLine (n %7==0 && n%23==0 ? "cratno" : "nekratno"); тернарный оператор

//if (coll % 7 == 0)
//{
//if (coll % 23 == 0)
//{
//posicia = "Chislo kratno";
//}
//if (coll % 23 == 0)
//{
//posicia = "Chislo kratno";
//}
//else { posicia = "Chislo ne kratno"; }
//}
//else { posicia = "Chislo ne kratno"; };