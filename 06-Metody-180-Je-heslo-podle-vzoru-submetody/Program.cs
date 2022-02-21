using System;

namespace _06_Metody_180_Je_heslo_podle_vzoru_submetody
{
    //Don't 
    //Repeat
    //Yourself
    class Program
    {
        static void Main(string[] args)
        {
            string[] hesla = { "heslo", "ncc-1701", "Ncc-1701", "a1b2C3" };
            for (int i = 0; i < hesla.Length; i++)
            {
                Console.WriteLine("Heslo {0} {1} platné", hesla[i], ValidujHeslo(hesla[i]) ? "je" : "není");
            }
        }
        static bool ValidujHeslo(string password)
        {
            if (Delka(password) && Upper(password) && Lower(password) && IsNumber(password))
            {
                return true;
            }
            else return false;
        }
        static bool Delka(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }
            else return false;
        }
        static bool Upper(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    return true;
                }
            }
            return false;
        }
        static bool Lower(string password)
        {
 
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsNumber(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
