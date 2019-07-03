/*
���������� ������� 2 �� ��������:
�������� �������� �� ����������� �������� � ������ �������,
��������� ����������������� ���������
*/
using System;

class Program
{
    // TODO: ���������� ����� �������� static bool Validate(string str),
    // ��� ������ ������� ������ �� �������� ���������� ��������
    // � ��������

    // ��������� ������� �����
    // ������ ������� �������� �� ������������ �������
    public static string[] ValidatedSplit(string str, char ch)
    {
        string[] output = null;
        output = str.Split(new char[] { ch }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string s in output)
        {
            //if (!Validate(s)) return null;
        }
        return output;
    } // end of ValidatdSplit(string, char)
      // ������� ������ �� ������� ��������
    public static string Shorten(string str)
    {
        // TODO: ������ ��������� �������
        char[] alph = { 'a', 'e', 'i', 'o', 'u', 'y' };
        int ind = str.IndexOfAny(alph);
        return str.Substring(0, ind + 1);
    } // end of Shorten(string)
      // ����� �������� ������������ ��� ��������� (� ��� ����� ����)
    public static string Abbrevation(string str)
    {
        string output = String.Empty;
        if (str != String.Empty)
        {
            string[] tmp = str.Split(' ');
            foreach (string s in tmp)
            {
                string shortenS = Shorten(s);
                FirstUpcase(ref shortenS);
                output += shortenS;
            }
        }
        return output;
    } // end of Abbrevation(string)
      // ����� �������������� ������� ������� � ����������
    public static void FirstUpcase(ref string str)
    {
        // TODO: ����� ����� ������ ����� ���� �� ��������� � ������� ��������
        char[] chars = str.ToCharArray();
        str = str[0].ToString().ToUpper() + str.Substring(1);
    } // end of FirstUpcase(ref string)

    static void Main(string[] args)
    {
        do
        {
            String str = "Let it be; All you need is love; Dizzy Miss Lizzy";
            string[] strings = ValidatedSplit(str, ';');
            foreach (string strs in strings)
                Console.WriteLine(strs);
            string[][] group = new string[strings.Length][];
            for (int i = 0; i < group.Length; i++)
            {
                group[i] = ValidatedSplit(strings[i], ' ');
                for (int j = 0; j < group[i].Length; j++)
                {
                    group[i][j] = Shorten(group[i][j]);
                    group[i][j] = Abbrevation(group[i][j]);
                }
            }
            foreach (string[] ad in group)
            {
                foreach (string asf in ad)
                    Console.Write(asf);
                Console.Write("\n");
            }
            Console.WriteLine("��� ����������� ������� ����� �������.");
            Console.WriteLine("��� ������ �� ��������� ������� Escape.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}

