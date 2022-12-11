Console.WriteLine("Vvedite chislo");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Chetnie chisla do " + numberN);
for (int i = 1; i <= numberN; i++) {
 if ((i % 2) == 0) {
  Console.WriteLine(i);  
 }
}


