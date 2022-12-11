Console.WriteLine("Vvedite pervoe chislo:");
int firstN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite vtoroe chislo:");
int secondN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite trete chislo:");
int thirdN = Convert.ToInt32(Console.ReadLine());
int bolsheeChislo = firstN;
if (firstN > secondN) {
    bolsheeChislo = firstN;
} else if (firstN == secondN) {
    bolsheeChislo = firstN;
} else if (firstN < secondN) {
    bolsheeChislo = secondN;
}
if (bolsheeChislo > thirdN) {
 bolsheeChislo = firstN; 
} else if (bolsheeChislo < thirdN) {
    bolsheeChislo = thirdN;
}
Console.WriteLine("Samoe bolshoe chislo: " + bolsheeChislo);




