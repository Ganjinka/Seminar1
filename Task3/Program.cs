Console.WriteLine("Vvedite chislo");
int numberN = Convert.ToInt32(Console.ReadLine());
int ostatok = numberN % 2; 
if (ostatok == 0) {
    Console.WriteLine("Da");
} else {
    Console.WriteLine("Net");
}
