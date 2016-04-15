/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package AnalizadorPHP;
import java.util.LinkedList;
/**
 *
 * @author Administrador
 */
public class NodoPHP {
    
    private int id;
    private String etiqueta;
    private Object valor = "";
    private int linea, columna = 0;
    private LinkedList<NodoPHP> hijos;
    
    public NodoPHP(String etiqueta, int id){
        this.etiqueta = etiqueta;
        this.id = id;
        hijos = new LinkedList<NodoPHP>();
    }
    
    public NodoPHP(String etiqueta, Object valor, int id){
        this.etiqueta = etiqueta;
        this.id = id;
        this.valor = valor;
        hijos = new LinkedList<NodoPHP>();
    }
    
    public void establecerValor(Object valor){
        this.valor = valor;
    }
        
    public void establecerLinea(int linea){
        this.linea = linea;
    }
    
    public void establecerColumna(int columna){
        this.columna = columna;
    }
    
    public void agregarHijo(NodoPHP hijo){
        this.hijos.add(hijo);
    }
    
    public int obtenerId(){
        return this.id;
    }
    
    public String obtenerEtiqueta(){
        return this.etiqueta;
    }
        
    public Object obtenerValor(){
        return this.valor;
    }
    public int obtenerLinea(){
        return this.linea;
    }
    
    public int obtenerColumna(){
        return this.columna;
    }

}
