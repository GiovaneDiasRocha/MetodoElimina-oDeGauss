public class MetodoEliminaçãoDeGauss {
    public static int [,] matriz () {
        int [,] matrizTeste = {{2,1,4},{2,1,3}};
        return matrizTeste;
    }

    public static int multiplicador(int l) {
        int pivo = 0;
            int multiplicador = 0;
        for (int i=0; i <= matriz().GetLength(0); i++) {
                for (int j=0; j <= matriz().GetLength(0); j++) {
                    pivo = matriz()[l,l];
                    return multiplicador = matriz()[i,j]/pivo;
                }
            }
        return multiplicador;
    }

    public static void atualizarMatriz(int [,] matriz, int valorAtualiazado, int posI, int posJ) {

        
    }

    public static void eliminacaoGauss () {
        int pivo = 0;
        int valorLi = 0;
        for (int i=1; i <= matriz().GetLength(0); i++) {
                for (int j=1; j <= matriz().GetLength(1); j++) {
                    if (i == 1) {
                        break;
                    }
                    pivo = matriz()[i,i];
                    valorLi = multiplicador(i - 1);
                }
            }
    }

    public static void Main () {
        Console.WriteLine(eliminacaoGauss());
    }
}