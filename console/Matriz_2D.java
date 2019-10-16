
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Matriz_2D {

    /**
     * @param args the command line arguments
     */
      // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        int fila = arr.length;    
        int columna = arr.length;
        int suma=0; 
        int sumaTotal = Integer.MIN_VALUE;
        
        for(int i=0; i<fila-2 ;i++){
            for (int j=0; j<columna-2 ;j++){
                
                suma=arr[i][j] + arr[i][j+1] + arr[i][j+2]+
                               arr[i+1][j+1] + 
                     arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];  
                sumaTotal=Math.max(sumaTotal, suma);
            }
            
        } 
        return sumaTotal;
    }
    

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(("C:\\Users\\mabc6\\matriz2D-DS.txt")));

        int[][] arr = new int[6][6];

        for (int i = 0; i < 6; i++) {
            String[] arrRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < 6; j++) {
                int arrItem = Integer.parseInt(arrRowItems[j]);
                arr[i][j] = arrItem;
            }
        }

        int result = hourglassSum(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}