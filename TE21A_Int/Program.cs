
// string number = "44" + "76";

// Console.WriteLine(number);

// string name = "Micke";

// bool s = 6 > 3;

// if (s)
// {
//   Console.WriteLine("YES");
// }

int potionHealing = 10;
int curseDamage = 10;

int hp = 50 + 50;

hp = hp + potionHealing;

hp += potionHealing;

hp++;
hp--;

hp -= curseDamage;

Console.WriteLine(hp);


if (hp > 0)
{
  Console.WriteLine("Jag lever!");
}

Console.ReadLine();
