Console.WriteLine("Kirjuta numnber:");
//int nr = Int32.Parse(Console.ReadLine());
int userNum = Convert.ToInt32(Console.ReadLine());

//int c= (nr%2);
int c = userNum % 2;
if (c == 0)
{    Console.WriteLine("Paarisarv");}
else if (c != 0)
{    Console.WriteLine("Paaritu arv");}