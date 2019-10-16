
//import java.util.ArrayList;
import java.util.Scanner;

public class examen_diagnostico {
    
    public static void main(String[] args) {        
        Scanner t = new Scanner(System.in);
        
        int [][] matriz = {{1,3,5,7},{4,7,9,7},{2,6,8,0},{2,4,5,2}};
//        ArrayList<Integer> num = new ArrayList<Integer>();
        int y=0;
        
        for(int a=0;a<2;a++){
            for(int x=0;x<4;x++){
                System.out.print(matriz[x][y]);
//                num.add(matriz[x][y]);
                if(x==3){
                    y++;
                }
            }
            for(int x=3;x>=0;x--){
                System.out.print(matriz[x][y]);
//                num.add(matriz[x][y]);
                if(x==0){
                    y++;
                }
            }
        }
//        System.out.println(num);   
    }   
}
