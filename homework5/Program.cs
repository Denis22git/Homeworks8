//Заполните спирально массив

class Program
{
    static void Main(string[] args)
    {
        int[,] msv = new int[5, 9];
        int i = msv.GetLength(0) / 2;
        int j = msv.GetLength(1) / 2;
        int value = 9;
        int step = 0;
        int side = 0;
        msv[i, j] = value++;
        while (i <= msv.GetLength(0) || j <= msv.GetLength(1))
        {
            int temp;
            switch (side)
            {
                case 0:
                    step++;
                    temp = j;
                    for (int t = 0; t < step; t++)
                        try { msv[i, j--] = value++; }
                        catch { value--; }
                    side = 1;
                    break;
                case 1:
                    temp = i;
                    for (int t = 0; t < step; t++)
                        try { msv[i++, j] = value++; }
                        catch { value--; }
                    side = 2;
                    break;
                case 2:
                    step++;
                    temp = j;
                    for (int t = 0; t < step; t++)
                        try { msv[i, j++] = value++; }
                        catch { value--; }
                    side = 3;
                    break;
                case 3:
                    temp = i;
                    for (int t = 0; t < step; t++)
                        try { msv[i--, j] = value++; }
                        catch { value--; }
                    side = 0;
                    break;
            }
        }
        for (int k = 0; k < msv.GetLength(0); k++)
        {
            for (int l = 0; l < msv.GetLength(1); l++)
            {
                Console.Write("{0}  ", msv[k, l]);
            }
            Console.WriteLine();
        }
    }
}