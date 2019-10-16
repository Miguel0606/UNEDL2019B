import java.util.Scanner;

/**
 *
 * @author mabc6
 */
public class Test {
        
    public static void main(String[] args) {
    
            Habitacion hab = new Habitacion();
            Tapiz tapiz = new Tapiz();
            Calculadora calc = new Calculadora();
            
            Scanner t = new Scanner(System.in);
                        
            System.out.println("Ingrese el ancho: ");
            hab.setAncho(t.nextInt());
		
            System.out.println("Ingrese el largo: ");
            hab.setLargo(t.nextInt());
		
            System.out.println("Ingrese el costo por metro cuadrado: ");
            tapiz.setCosto(t.nextInt());
            
            hab.setArea(hab.getAncho()*hab.getLargo());
            
            calc.setCostot(hab.getArea()*tapiz.getCosto());
    
            System.out.println("Total=" + calc.getCostot());
            
            System.out.println(hab.getArea());
            System.out.println(tapiz.getCosto());
    }
}
