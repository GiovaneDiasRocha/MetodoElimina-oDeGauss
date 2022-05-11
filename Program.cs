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
            mult = i != 0 ? multiplicador(i, etapa) : mult = 0;
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
        float [,] matrizTeste = {{3, 2, 4, 1},{1, 1, 2, 2},{4, 3, -2, 3}};

        eliminacaoGauss(matrizTeste);
    }
}