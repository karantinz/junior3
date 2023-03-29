Console.WriteLine("Как вас зовут?");
string name = Console.ReadLine();

Console.WriteLine("Ваш возраст?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Знак зодиака?");
string zodiac = Console.ReadLine();

Console.WriteLine("Место работы?");
string work = Console.ReadLine();

Console.WriteLine($"Вас зовут {name}, ваш возраст {age}, вы {zodiac} по знаку зодиака и вы работаете на {work}");