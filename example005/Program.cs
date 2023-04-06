Console.WriteLine("Hello,имя пользователя");
string user = Console.ReadLine();
if (user.ToLower() == "маша")
{
    Console.WriteLine("привет Маха!");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(user);



}