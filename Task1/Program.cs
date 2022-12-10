Console.WriteLine("Vvedite pervoe chislo:");
int firstN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite vtoroe chislo:");
int secondN = Convert.ToInt32(Console.ReadLine());
if (firstN > secondN) {
    Console.WriteLine(firstN + " > " + secondN);
} else if (firstN == secondN) {
    Console.WriteLine(firstN + " = " + secondN);
} else {
    Console.WriteLine(secondN + " > " + firstN);
}
