﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Ксюша")
{
  Console.WriteLine("Ура, это же Ксюша!");  
}
else
{
   Console.Write("Привет,  "); 
   Console.WriteLine(username);
}