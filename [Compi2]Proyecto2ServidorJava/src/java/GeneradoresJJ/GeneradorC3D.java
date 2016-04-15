/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package GeneradoresJJ;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
/**
 *
 * @author Administrador
 */
public class GeneradorC3D {
    
    public static void main(String[] args) {
        
        try{
            Runtime runtime = Runtime.getRuntime();
            String[] cmd = new String[4];
            cmd[0] = "cmd.exe" ;
            cmd[1] = "/C";
            cmd[2] = "javacc";
            cmd[3] =  "C:\\Users\\Administrador\\Documents\\Compiladores2\\Laboratorio\\[Compi2]Proyecto2_201114421\\[Compi2]Proyecto2ServidorJava\\src\\java\\AnalizadorC3D\\GramaticaC3D.jj";
                /*
                    para poder ejecutar esta clase es necesario setear JavaCC a las varibles de entorno del sistema 
                    de tal forma que el simbolo del sistema (la terminal) reconozca el comando javacc o jjtree
                */
            
            Process proc = runtime.exec(cmd);
            InputStream is = proc.getInputStream();
            InputStreamReader isr = new InputStreamReader(is);
            BufferedReader br = new BufferedReader(isr);

            String line;
            while ((line = br.readLine()) != null) {
                System.out.println(line);
            }
        }catch(IOException e){
            System.out.print(e.toString());
        }
        
    }
    
}
