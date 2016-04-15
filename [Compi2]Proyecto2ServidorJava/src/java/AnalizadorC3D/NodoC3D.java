/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package AnalizadorC3D;
import java.util.LinkedList;
/**
 *
 * @author Administrador
 */
public class NodoC3D {

    private int id;
    private String etiqueta;
    private Object valor = "";
    private int linea, columna = 0;
    private LinkedList<NodoC3D> hijos;
    
    public NodoC3D(String etiqueta, int id){
        this.etiqueta = etiqueta;
        this.id = id;
        hijos = new LinkedList<NodoC3D>();
    }
    
    public NodoC3D(String etiqueta, Object valor, int id){
        this.etiqueta = etiqueta;
        this.id = id;
        this.valor = valor;
        hijos = new LinkedList<NodoC3D>();
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
    
    public void agregarHijo(NodoC3D hijo){
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
