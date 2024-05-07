string[] str1 = { "1234", "asdf", "-9=" };
string[] str2 = new string[str1.Length];

void SelectionOfWords(string[] str1, string[] str2)
{
    int cnt = 0;
    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i].Length <= 3)
        {
            str2[cnt] = str1[i];
            cnt++;
        }
    }
}

void ShowArr(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        System.Console.WriteLine($"{str[i]}");
    }

}
SelectionOfWords(str1, str2);
ShowArr(str2);