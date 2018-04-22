using System;
using System.Collections;
using System.Collections.Generic;

namespace NotacionBigO.DS
{
    public class LogReader : List<LogLine> {
    
    private int counter = 0;
    private int sizeLogLines;
    
    private int sizeUniqueIps;
    
    private List<LogLine> allIps;

    //private List<string> uniqueIps;
    private HashSet<string> uniqueIps;

    public LogReader(int sizeLogLines, int sizeUniqueIps) {
        this.sizeLogLines = sizeLogLines;
        this.sizeUniqueIps = sizeUniqueIps;

        //this.uniqueIps = new List<string>();
        this.uniqueIps = new HashSet<string>();

        this.allIps = this.LlenarListaGeneral();
        // La complejidad del método de búsqueda CONTAINS de un List es lineal O(N)
        // La complejidad del método de búsqueda CONTAINS de un HashSet es constante O(1)
        // Un HashSet no permite duplicados pero no asegura el orden de los elementos
        // Un List permite duplicados pero sí asegura el orden de los elementos
    }
    
    public int readAllLogs() {
        int sizeLogLines = 0;
        foreach (LogLine line in this.allIps) {
            String ip = line.getIP();
            sizeLogLines++;
        }
        return sizeLogLines;
        //return this.sizeLogLines;
    }
    
    public int getSizeUniqueIps() {
        // complejidad cuadratica porque tiene un FOR y una busqueda CONTAINS
        // el problema esta en la busqueda usando CONTAINS en uniqueIps que es tipo List<string>

        foreach (LogLine logLine in this.allIps) {
            String ip = logLine.getIP();
            if (!this.uniqueIps.Contains(ip)) {
                this.uniqueIps.Add(ip);
            }
        }
        return this.uniqueIps.Count;
    }

    public bool hasNext() {
        return (this.counter < this.sizeLogLines);
    }
    public List<LogLine> LlenarListaGeneral() {
        List<LogLine> temp = new List<LogLine>();
        while (this.hasNext()) {
            this.counter++;
            LogLine ll = new LogLine(this.counter % this.sizeUniqueIps);
            temp.Add(ll);
        }
        return temp;
    }
}
}