using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cyrillic;
            string roman="";
            Dictionary<char, string> translit =
            new Dictionary<char, string>();            

            translit.Add('А', "A");
            translit.Add('Б', "B");
            translit.Add('В', "V");
            translit.Add('Г', "G");
            translit.Add('Д', "D");
            translit.Add('Е', "E");
            translit.Add('Ё', "Yo");
            translit.Add('Ж', "Zh");
            translit.Add('З', "Z");
            translit.Add('И', "I");
            translit.Add('Й', "J");
            translit.Add('К', "K");
            translit.Add('Л', "L");
            translit.Add('М', "M");
            translit.Add('Н', "N");
            translit.Add('О', "O");
            translit.Add('П', "P");
            translit.Add('Р', "R");
            translit.Add('С', "S");
            translit.Add('Т', "T");
            translit.Add('У', "U");
            translit.Add('Ф', "F");
            translit.Add('Х', "H");
            translit.Add('Ц', "C");
            translit.Add('Ч', "Ch");
            translit.Add('Ш', "Sh");
            translit.Add('Щ', "Shh");
            translit.Add('Ъ', "#");
            translit.Add('Ы', "Y");
            translit.Add('Ь', "\'");
            translit.Add('Э', "Je");
            translit.Add('Ю', "Ju");
            translit.Add('Я', "Ja");

            Console.WriteLine("Введите текст на кириллице: ");
            cyrillic = Console.ReadLine();
            Console.WriteLine("\nТранслит: ");

            foreach (char letter in cyrillic)
            {
                if (translit.ContainsKey(Char.ToUpper(letter)))
                {
                    if(Char.IsLower(letter))
                        roman += translit[Char.ToUpper(letter)].ToLower();
                    else
                        roman += translit[Char.ToUpper(letter)];
                }
                else
                    roman += letter;                
            }
            Console.WriteLine(roman);


            Console.ReadKey();
        }
    }
}

//ОК
