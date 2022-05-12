public class MetodoEliminaçãoDeGauss
{
    public static float[,] matriz()
    {
        float[,] matrizTeste = { { 3, 2, 4, 1 }, { 1, 1, 2, 2 }, { 4, 3, -2, 3 } };
        return matrizTeste;
    }

    public static float multiplicador(int l, int etapa)
    {
        float pivo = matriz()[etapa - 1, etapa - 1];
        float mult = matriz()[l, etapa - 1] / pivo;
        return mult;
    }

    public static float [,] eliminacaoGauss(float[,] matriz, int quantLinhasMatriz, int quantColunasMatriz, int etapa = 1)
    {
        float[,] novaMatriz = new float[quantLinhasMatriz, quantColunasMatriz];
        for (int i = 0; i < quantLinhasMatriz; i++)
        {
            float mult = 0;
            if (i != 0 && i < quantLinhasMatriz)
            {
                mult = multiplicador(i, etapa);
            }
            for (int j = 0; j < quantColunasMatriz; j++)
            {
                novaMatriz[i, j] = matriz[i, j];
                if (i >= etapa)
                {
                    novaMatriz[i, j] = matriz[i, j] - mult * matriz[etapa - 1, j];
                }
            }
        }
        etapa++;//Ao invés de fazer método recursivo, tentar fazer a etapa ser passada na chamada do método
        if (etapa < quantLinhasMatriz)
        {   
            
            eliminacaoGauss(novaMatriz, quantLinhasMatriz, quantColunasMatriz, etapa);
        } else {
            return novaMatriz;
        }
        return novaMatriz;
    }

    public static void Main()
    {

        float[,] matriz = { { 3, 2, 4, 1 }, { 1, 1, 2, 2 }, { 4, 3, -2, 3 } };
        int quantLinhasMatriz = matriz.GetLength(0);
        int quantColunasMatriz = matriz.GetLength(1);
        float[,] novaMatriz = new float[quantLinhasMatriz, quantColunasMatriz];
        novaMatriz = eliminacaoGauss(matriz, quantLinhasMatriz, quantColunasMatriz);
        

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(novaMatriz[i, j] + " ");
            }
            Console.Write("\n");
        }

    }
}