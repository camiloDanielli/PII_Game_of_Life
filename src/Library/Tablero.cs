public class Tablero{

    public void ImprimirTablero(bool[,] b){}


        int width 
        int height 
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            b = Logica.ApplyRules(b);
            Thread.Sleep(300);
}

}
