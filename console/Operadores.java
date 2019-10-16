
import java.util.Scanner;

/**
 *
 * @author mabc6
 */ 
public class Operadores {
    
        public static void main(String[] args) {
		
		Scanner t = new Scanner(System.in);
		
		int tipo=0,operador=0,num1=0,num2=0;

		System.out.println("Dame el número 1: ");
		num1=t.nextInt();
		
		System.out.println("Dame el número 2: ");
		num2=t.nextInt();
		
		System.out.println("1.- operadores aritméticos \n2.- Operadores relacioneles \n3.- Operadores lógicos");
		tipo=t.nextInt();
		
		switch(tipo) {
		
		case 1:System.out.println("1- + \n2- - \n3- * \n4- /");
				operador=t.nextInt();
				switch(operador) {
				
				case 1: System.out.println("La suma es: "+(num1+num2));
				break;
				case 2: System.out.println("La resta es: "+(num1-num2));
				break;
				case 3: System.out.println("La multiplicación es: "+(num1*num2));
				break;
				case 4: System.out.println("La división es: "+(num1/num2));
				break;
				
				}
				
		case 2:System.out.println("1- < \n2- > \n3- == \n4- != \n5.- <= \n6.- >=");
				operador=t.nextInt();
				switch(operador) {
				
				case 1: System.out.println(num1+ "es menor que "+num2);
				break;
				case 2: System.out.println(num1+ "es mayor que "+num2);
				break;
				case 3: System.out.println(num1+ "es igual que "+num2);
				break;
				case 4: System.out.println(num1+ "es menor que o igual a "+num2);
				break;
				case 5: System.out.println(num1+ "es mayor que o igual a "+num2);
				break;
				
				}
		
		case 3:System.out.println("1- && \n2- || \n3- !");
				operador=t.nextInt();
				switch(operador) {
				
				case 1: System.out.println(num1+ " Y "+num2);
				break;
				case 2: System.out.println(num1+ " O "+num2);
				break;
				case 3: System.out.println(num1+ " NO "+num2);
				break;
				
				}
		
		}
        }
}
