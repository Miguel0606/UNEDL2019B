
public class Main {
    public static void main (String [] args){
        Hijo Mike = new Hijo("Verdes","Lacio","Caf�","Blanco", (float) 2.30,"Ya qu�","Ya qu�");
        Mike.Mostrar(); 
        
        System.out.println("\n Herencia de padres");
        Mike.Caracter();
        Mike.GestoBoca();
        Mike.Risa();
        
        System.out.println("\n Herencia de otras personas\n");
        System.out.println("Amigos: ");
        Mike.Amigos();
        System.out.println("\nMaestros: ");
        Mike.Maestros();
        System.out.println("\nJefes: ");
        Mike.Jefes();
        
    }
}
