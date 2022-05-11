public class MetodoEliminaçãoDeGauss {
    public static float [,] matriz () {
        float [,] matrizTeste = {{3, 2, 4, 1},{1, 1, 2, 2},{4, 3, -2, 3}};
        return matrizTeste;
    }

    public static float multiplicador(int l, int etapa) {
        float pivo = matriz()[etapa - 1, etapa - 1];
        float mult = matriz()[l, etapa-1]/pivo;
        return mult; 
    }

    public static void eliminacaoGauss (float [,] matriz) {
        int etapa = 1;
        for (int i=0; i < matriz.GetLength(0); i++) {
            float mult = 0;
            mult = i != 0 && etapa < matriz.GetLength(1) ? multiplicador(i, etapa) : mult = 0;
                for (int j=0; j < matriz.GetLength(1); j++) {
                    float valorLi = 0;
                    if (i != 0) {
                        valorLi = matriz[i, j] - mult * matriz[etapa - 1, j];
                        Console.Write(valorLi + " ");
                    }
                }
                Console.Write("\n");
            }
            etapa ++; //é passado como método na chamada da função multiplicador()
    }

    public static void Main () {
        
        float [,] matriz = {{3, 2, 4, 1},{1, 1, 2, 2},{4, 3, -2, 3}};
        int quantLinhasMatriz = matriz.GetLength(0);
        int quantColunasMatriz = matriz.GetLength(1);
        float [,] novaMatriz = new float[quantLinhasMatriz, quantColunasMatriz];
        
        int etapa = 1;
        //while (etapa < quantLinhasMatriz) {
            for (int i=0; i < quantLinhasMatriz; i++) {
            float mult = 0;
            if (i != 0 && i < quantLinhasMatriz)
            {
                mult = multiplicador(i, etapa);
            }
            //mult = i != 0 && i < quantLinhasMatriz ? multiplicador(i, etapa) : mult = 0;
                for (int j=0; j < quantColunasMatriz; j++) {
                    novaMatriz[i, j] = matriz[i, j];
                    if (i != 0) {
                        novaMatriz[i, j] = matriz[i, j] - mult * matriz[etapa - 1, j];
                    }
                }
            }
            etapa ++;
        //}
        
            //Console.WriteLine(quantLinhasMatriz);
            //Console.WriteLine(quantColunasMatriz);

            for (int i=0; i < matriz.GetLength(0); i++) {
                for (int j=0; j < matriz.GetLength(1); j++) {
                    Console.Write(novaMatriz[i, j] + " ");
                }
                Console.Write("\n");
            }
        
    }
}