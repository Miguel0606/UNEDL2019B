
public class Padres {
    private String colorOjos;
    private String tipoCabello;
    private String colorCabello;
    private String colorPiel;
    private float altura;
    
    public Padres(String colorOjos, String tipoCabello, String colorCabello, String colorPiel, float altura){
        this.colorOjos = colorOjos;
        this.tipoCabello = tipoCabello;
        this.colorCabello = colorCabello;
        this.colorPiel = colorPiel;
        this.altura = altura;
        
    }

    public String getColorOjos() {
        return colorOjos;
    }

    public String getTipoCabello() {
        return tipoCabello;
    }

    public String getColorCabello() {
        return colorCabello;
    }

    public String getColorPiel() {
        return colorPiel;
    }

    public float getAltura() {
        return altura;
    }
    
    protected void Caracter(){
        System.out.println("Caracter tranquilo");
    }
    
    protected void Risa(){
        System.out.println("Nunca Reir");
    }
    
    protected void GestoBoca(){
        System.out.println("La para cuando está feliz");
    }
}
