
import java.util.Scanner;

public class Matriz_diagonal {
    
    public static void main(String[] args) {
        
        Scanner teclado = new Scanner(System.in);
        int tamano = 0;
        int diagonal1=0;
        int diagonal2=0;
        int restaabs=0;
        int num1=0; 
        tamano = teclado.nextInt();       
        
        int[][] matriz = new int[tamano][tamano];

        for (int i = 0; i < tamano; i++) {
            for (int j = 0; j < tamano; j++) {
                matriz[i][j] = teclado.nextInt();
            }
        }
        for (int i = 0; i < tamano; i++) {
            for (int j = 0; j < tamano; j++) {
            }
        }
            for (int i = 0; i < tamano; i++) {
                for (int j = 0; j < tamano; j++) {
                    if (i == j) {
                        diagonal1 = diagonal1 + matriz[i][j];
                      
                    }
                }
            }
        for (int i = 0; i < tamano; i++) {
            for (int j = 0; j < tamano; j++) {
                if(i+j == tamano-1){
                    diagonal2 += matriz[i][j];
                }
            }
        }
        restaabs = diagonal2 - diagonal1;
        restaabs = Math.abs(restaabs);
        System.out.println(restaabs);
        
            }
        }