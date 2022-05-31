public class MetodoEliminaçãoDeGauss
{
    public static float multiplicador(float [, ] matriz, int l, int etapa)
    {
        float pivo = matriz[etapa - 1, etapa - 1];
        float mult = matriz[l, etapa - 1] / pivo;
        return mult;
    }

    public static float [,] eliminacaoGauss(float[,] matriz, int quantLinhasMatriz, int quantColunasMatriz, int etapa)
    {   
        float[,] novaMatriz = new float[quantLinhasMatriz, quantColunasMatriz];
        for (int i = 0; i < quantLinhasMatriz; i++)
        {
            float mult = 0;
            if (i != 0 && i < quantLinhasMatriz)
            {
                mult = multiplicador(matriz, i, etapa);
            }
            for (int j = 0; j < quantColunasMatriz; j++)
            {
                novaMatriz[i, j] = matriz[i, j];
                if (i >= etapa)
                {   
                    matriz[i, j] = matriz[i, j] - mult * matriz[etapa - 1, j];
                }
            }
        }
        return matriz;
    }

    public static float [] somatorio (float [,] matriz, int quantLinhasMatriz, int quantColunasMatriz) {

        float [] resultadoSomatorio = new float [quantLinhasMatriz];
        
        int n, j = 0, linhas = quantLinhasMatriz, colunas  = quantColunasMatriz, aux = quantLinhasMatriz - 1;
        for (int i = 0; i < quantLinhasMatriz; i++)
        {   
            float resultadoAux = 0;
            n = i;
            if (i == 0) {
                resultadoSomatorio[linhas - 1] = (matriz[linhas  -1, colunas - 1]) / matriz[linhas - 1, linhas - 1];
            } else {
                while (n > 0)
                {
                    resultadoAux = matriz[aux - 1, colunas  -1] - matriz[aux - 1, linhas  -1];
                    n--;
                    linhas--;
                    //resolver problema com a soma, fazer com que matriz[0, 0] - matriz 0, 3 na ultima etapa
                }
                aux--;
                resultadoSomatorio[aux] = resultadoAux / matriz[i, i];
            }
        }

        // x3 = matriz[2, 3] / matriz[2, 2];
        // x2 = (matriz[1, 3] - matriz[1, 2] * x3) / matriz[1, 1];
        // x1 = (matriz[0, 3] - matriz[0, 1] * x2 - matriz[0, 2] * x3) / matriz[0, 0];

        // resultadoSomatorio[linhas - 1] = matriz[linha  -1] - matriz[coluna - 1]

        return resultadoSomatorio;
    }

    public static void Main()
    {

        float[,] matriz = { { 6, 2, -1, 7 }, { 2, 4, 1, 7 }, { 3, 2, 8, 13 } };
        int quantLinhasMatriz = matriz.GetLength(0);
        int quantColunasMatriz = matriz.GetLength(1);
        //float[,] novaMatriz = new float[quantLinhasMatriz, quantColunasMatriz];

        for (int i = 1; i < quantLinhasMatriz; i++)
        {
            matriz = eliminacaoGauss(matriz, quantLinhasMatriz, quantColunasMatriz, i);
        }

        float [] resultado = new float [quantLinhasMatriz];
        resultado = somatorio(matriz, quantLinhasMatriz, quantColunasMatriz);

        foreach (float x in resultado)
        {
            Console.WriteLine(x);
        }

        //Calcular x1, x2, x3

        //matriz[0, 0]x1      + matriz[0, 1]x2 + matriz[0, 2]x3 = matriz[0, 3]
        //                      matriz[1, 1]x2 + matriz[1, 2]x3 = matriz[1, 3]
        //                                       matriz[2, 2]x3 = matriz[2, 3]

        // float x1, x2, x3;

        // x3 = matriz[2, 3] / matriz[2, 2];
        // x2 = (matriz[1, 3] - matriz[1, 2] * x3) / matriz[1, 1];
        // x1 = (matriz[0, 3] - matriz[0, 1] * x2 - matriz[0, 2] * x3) / matriz[0, 0];

        for (int i = 0; i < quantLinhasMatriz; i++)
        {
            for (int j = 0; j < quantColunasMatriz; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.Write("\n");
        }
        
        // Console.WriteLine(Math.Round(x1, 3));
        // Console.WriteLine(Math.Round(x2, 3));
        // Console.WriteLine(Math.Round(x3, 3));
    }
}