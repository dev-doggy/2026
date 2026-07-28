const string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIjKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-<>?[]{};:.,";

Console.WriteLine("ПРОСТОЙ ГЕНЕРАТОР ПАРОЛЕЙ");
int count = 12;
string password = PassworldTools.Generate(count,alphabet);
Console.WriteLine($"Сгенерированный пароль:{password}");

Console.WriteLine("Нажмите ENTER для выхода");
Console.ReadLine();

public class PassworldTools
{ ///<summary>
  ///Генерирует случайный пароль.
  ///</summary>
  ///<param name="count">Желаемое количество  символов в пароле.</param>
  ///<returns> Возвращает готовую строку с паролем.</returns>
    public static string Generate(int count, string alphabet)
    {

        char[] chars = new char[count];
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(0, alphabet.Length);

            chars[i] = alphabet[index];
        }

        return new string(chars);
    }
}

