/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author mabc6
 */
import java.util.Scanner;

public class Trillizos {
    
    public static void main(String[] args) {
        
        Scanner teclado = new Scanner(System.in);

        int x1, y1, z1, x2, y2, z2, A=0, B=0;

        x1 = teclado.nextInt();
        y1 = teclado.nextInt();
        z1 = teclado.nextInt();
        x2 = teclado.nextInt();
        y2 = teclado.nextInt();
        z2 = teclado.nextInt();

        if (x1 < x2) {
            B++;
        } else if (x1 > x2) {
            A++;
        }

        if (y1 < y2) {
            B++;
        } else if (y1 > y2) {
            A++;
        }
        if (z1 < z2) {
            B++;
        } else if (z1 > z2) {
            A++;
        }
        System.out.println(A + " " +B);
        
    }
    
}
