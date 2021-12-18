using System;
					
public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        int v = 0;
        int c = 0;
        int cnt = s.Length;

        for (int i = 0; i < cnt; i++)
        {
            string sil = Convert.ToString(s[i]);
            if ("aeiouyYAEIOU".Contains(sil))
            {
                v++;
            }
            else if (("qQwWrRtTpPsSdDfFgGhHkKlLzZxXcCvVbBnNmM".Contains(sil)))
            {
                c++;
            }
        }
        Console.WriteLine("Vowels: "+v);
        Console.WriteLine("Consonants: "+c);
    }
}