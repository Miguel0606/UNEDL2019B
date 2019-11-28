
public class Hijo extends Padres{
    private String HombrosAnchos;
    private String ManosGrandes;
    
    public Hijo(String colorOjos, String tipoCabello, String colorCabello, String colorPiel, float altura, String hombrosanchos, String manosgrandes){
        super(colorOjos,tipoCabello,colorCabello,colorPiel,altura);
        
        this.HombrosAnchos = hombrosanchos;
        this.ManosGrandes = manosgrandes;
    }
    
    public void Mostrar(){
        System.out.println("Lo que me heredaron los padres");
        System.out.println("Color de ojos: "+getColorOjos()+
                           "\nTipo de cabello: "+getTipoCabello()+
                           "\nColor de cabello: "+getColorCabello()+
                           "\nColor de piel: "+getColorPiel()+
                           "\nAltura: "+getAltura());
        
        System.out.println("\nMis propios atributos");
        System.out.println("Hombros anchos: "+HombrosAnchos+
                           "\nManos grandes: "+ManosGrandes);
        
    }
    
    public void Amigos(){
        System.out.println("A trabajar duro por lo que se quiere");
    }
    
    public void Maestros(){
        System.out.println("A ser amable");
    }
    
    public void Jefes(){
        System.out.println("A ser atrevido");
    }
    
}