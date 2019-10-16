/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import static java.lang.Double.parseDouble;
import java.util.Scanner;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
/**
 *
 * @author mabc6
 */
public class Metodo_Iterativo extends JFrame{
    
    private JLabel lblC;
    private JLabel lblError;
    private JLabel lblDecimal;
    private JTextField txtC;
    private JTextField txtError;
    private JComboBox cbxDecimal;
    private JButton btnCalcular;

    public Metodo_Iterativo() {
        setVisible(true);
        setLayout(new GridLayout(4, 2, 10, 10));
        setLocation(500, 500);
        setTitle("MÃ©todo Iterativo");
        lblC = new JLabel("Numero de la raiz :");
        lblError = new JLabel("Error");
        lblDecimal = new JLabel("Decimales");
        txtC = new JTextField();
        txtError = new JTextField();
        cbxDecimal = new JComboBox();
        cbxDecimal.addItem("0");
        cbxDecimal.addItem("1");
        cbxDecimal.addItem("2");
        cbxDecimal.addItem("3");
        cbxDecimal.addItem("4");
        cbxDecimal.addItem("5");
        cbxDecimal.addItem("6");
        cbxDecimal.addItem("7");
        cbxDecimal.addItem("8");
        cbxDecimal.addItem("9");
        btnCalcular = new JButton("Calcular");

        add(lblC);
        add(txtC);
        add(lblError);
        add(txtError);
        add(lblDecimal);
        add(cbxDecimal);
        add(btnCalcular);
        Calcular ref = new Calcular();
        btnCalcular.addActionListener(new ActionListener() {

            @Override
            public void actionPerformed(ActionEvent e) {
                if (txtC.getText().equals("")) {
                    JOptionPane.showMessageDialog(null, "Este campo de la raiz esta vacio ");
                } else if (txtError.getText().equals("")) {
                    JOptionPane.showMessageDialog(null, "El campo del error esta vacio");
                } else {

                    String rene = txtC.getText();
                    String esba = txtError.getText();
                    String godoyEsGay = (String) cbxDecimal.getSelectedItem();
                    double barrera = Double.parseDouble(rene);
                    double hernandez = Double.parseDouble(esba);
                    double torres = Double.parseDouble(godoyEsGay);

                    if (barrera < 0) {
                        JOptionPane.showMessageDialog(null, "El radicando no puede ser menor a 0");
                    } else {
                        ref.calcular(barrera, hernandez, torres);
                    }
                }

            }
        });

        pack();
    }

    public static void main(String[] args) {
        Metodo_Iterativo mi = new Metodo_Iterativo();
//        mi.cargar();
//        mi.calcular();

    }

}
