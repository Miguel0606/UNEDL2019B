import java.util.Scanner;

public class Palindromo_ {

	public static void main(String[] args) {

Scanner t = new Scanner(System.in);
		
		String pal;
		int a=0,b=0,d=0;
		
		System.out.println("Ingrese la palabra: ");
		pal=t.nextLine();
		
		pal=pal.toLowerCase();
		
        pal=pal.replace("�", "a");
        pal=pal.replace("�", "e");
        pal=pal.replace("�", "i");
        pal=pal.replace("�", "o");
        pal=pal.replace("�", "u");
        pal=pal.replace(" ", "");
        pal=pal.replace(".", "");
        pal=pal.replace(",", "");
                
        a=pal.length()-1;
        
        for(int c=(pal.length()/2)-1;c>=0;c--) {
        	if(pal.charAt(b)==pal.charAt(a)) {
        		d++;
        	}
        	b++;
        	a--;
        }
        if(d==pal.length()/2) {
        	System.out.println("Es pal�ndromo");
        }else {
        	System.out.println("No es pal�ndromo");
        }
		
	}

}
