
import java.util.Scanner;

/**
 *
 * @author mabc6
 */
public class Metodo_iterativo_raiz {

    public static void main(String[] args) {
        
        Scanner t = new Scanner(System.in);
        
        int num=0,decimales=0,x=0,iteracion=0;
        float perror=0,error=0,aprox=1,aprox2=0,porcentaje=0,medio= (float) 0.5;
        
        System.out.println("Número para obtener la raíz: ");
        num=t.nextInt();
        
        System.out.println("Porcentaje de error: ");
        perror=t.nextFloat();
        
        System.out.println("Número de decimales: ");
        decimales=t.nextInt();
        
        for(x=0;x>-1;x++){
            if(aprox*aprox<num){
                aprox++;               
            }
            if(aprox*aprox>num){
                aprox--;
                break;
            }
        }
        
        iteracion=1;
        System.out.println("Aproximacion "+iteracion+"= "+aprox);
        iteracion++;
        
        do{
            aprox2=num/aprox;
            aprox2=aprox2+aprox;
            aprox2=aprox2*medio;
            System.out.println("Aproximacion "+iteracion+"= "+aprox2);
            error=aprox2-aprox;
            error=error/aprox2;
            error=error*100;
            System.out.println("El porcentaje de error es: "+error);
            aprox=aprox2;
            aprox2=0;
            iteracion++;
        }while(iteracion<5);
        
    }
    
}
