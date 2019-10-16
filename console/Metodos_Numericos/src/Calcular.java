/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author mabc6
 */
public class Calcular {
    private double c;
    private double x = 0;
    private double n = 0;//numero que se va elevar al cuadrado
    private double raiz = 0;
    private double error = 0;
    private double decimal = 0;
    private double iteracion = 0;
    private double porcentaje = 0;
    private double aproximacion = 0;
    private double parteentera = 0, parteentera1 = 0;
    private double a = 0;
    
    public void calcular(double c, double error, double decimal){
        this.c = c;
        this.error = error;
        this.decimal = decimal;
        
        while (aproximacion <= this.c) {
            aproximacion = (double) Math.pow(n, 2);

            if (aproximacion > this.c) {
                n--;

                aproximacion = (double) Math.pow(n, 2);
                break;
            } else {
                n++;

            }
        }
        a = n;

        if (aproximacion == this.c) {
            raiz = (float) Math.sqrt(this.c);

            System.out.println("********RESULTADO******");
            System.out.println("La raiz es : " + raiz);

        } else {

//                 
            do {

                x = (double) 0.5 * (a + this.c / a);

                porcentaje = (x - a) / x * 100;
                if (porcentaje < 0) {
                    porcentaje = porcentaje * -1;
                }
                parteentera = (double) Math.floor(porcentaje);
                porcentaje = (double) ((porcentaje - parteentera) * Math.pow(10, this.decimal));
                porcentaje = Math.round(porcentaje);
                porcentaje = (double) ((porcentaje / Math.pow(10, this.decimal)) + parteentera);
                parteentera1 = (double) Math.floor(x);
                x = (double) ((x - parteentera1) * Math.pow(10, this.decimal));
                x = Math.round(x);
                x = (double) ((x / Math.pow(10, this.decimal)) + parteentera1);

                a = x;
                iteracion++;

                System.out.println("********RESULTADOS******");
                System.out.println("El numero cuyo cuadrado se aproxima al numero es : " + n);
                System.out.println("La aproximacion " + iteracion + " es : " + x);
                System.out.println("El error es de : " + porcentaje + "%");

            } while (porcentaje > this.error);

        }
    }
        
    public static void main(String[] args) {
        Metodo_Iterativo mi = new Metodo_Iterativo();
       mi.cargar();
       mi.Calcular();

   }
        
    }
