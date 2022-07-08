using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ClassLibrary_Twelve
{  
    [Serializable]  
    public class ClassTwelve
    {
        #region Propiedades
        public int TotalFilas { get; private set; }
        public int TotalColumnas { get; private set; }
        public int[,] Matriz { get; set; }
        public int Puntuación { get; set; }
        public int ContadorAgresivo { get; private set; }
        public bool Agresivo { get; private set; }
        #endregion

        #region MiConstructor
        public ClassTwelve(int totalFilas, int totalColumnas, bool agresivo)
        {
            this.TotalFilas = totalFilas;
            this.TotalColumnas = totalColumnas;
            this.Matriz = new int[totalFilas, totalColumnas];
            this.Puntuación = 0;
            GenerarCasilla((totalFilas + totalColumnas) / 3);            
            if (agresivo)
            {
                this.ContadorAgresivo = 0;
                this.Agresivo = true;
            }                         
        }
        #endregion

        #region Métodos        
        private void GenerarCasilla(int cantidad)
        {
            Random generar = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                while (true)
                {
                    int fila = generar.Next(0, TotalFilas);
                    int columna = generar.Next(0, TotalColumnas);
                    if (Matriz[fila, columna] == 0)
                    {
                        Matriz[fila, columna] = generar.Next(1, 4);
                        break;
                    }
                }
            }            
        }
        public bool PosicionValida(int fila, int columna)
        {
            return ((fila < TotalFilas) && (fila >= 0) && (columna < TotalColumnas) && (columna >= 0));
        }
        private bool[,] MascaraBool()
        {
            bool[,] tablero = new bool[TotalFilas, TotalColumnas];
            for (int i = 0; i < TotalFilas; i++)
            {
                for (int j = 0; j < TotalColumnas; j++)
                {
                    if (Matriz[i, j] == 0)
                        tablero[i, j] = true;
                }
            }
            return tablero;
        }       
        private bool ExisteCamino(bool[,] tablero, int f1, int c1, int f2, int c2)
        {
            int[] df = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, 1, -1 };
                        
            int[,] caminos = new int[TotalFilas, TotalColumnas];

            caminos[f1, c1] = 1;
            tablero[f1, c1] = true;
            tablero[f2, c2] = true;
            bool cambio = true;

            while (cambio)
            {
                cambio = false;
                for (int i = 0; i < TotalFilas; i++)
                {
                    for (int j = 0; j < TotalColumnas; j++)
                    {
                        if (caminos[i, j] == 0) continue;
                        if (!tablero[i, j]) continue;

                        for (int k = 0; k < df.Length; k++)
                        {
                            if (f2 == i + df[k] && c2 == j + dc[k]) return true;
                            if (PosicionValida(i + df[k], j + dc[k]) && (caminos[i + df[k], j + dc[k]] == 0) && (tablero[i + df[k], j + dc[k]]))
                            {
                                caminos[i + df[k], j + dc[k]] = caminos[i, j] + 1;                                
                                cambio = true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        private void Mezclar() 
        {
            Random generar = new Random();
            for (int i = 0; i < TotalFilas; i++)
                for (int j = 0; j < TotalColumnas; j++)
                {                    
                    int fila = generar.Next(0, TotalFilas);
                    int columna = generar.Next(0, TotalColumnas);
                    int temp = Matriz[fila, columna];
                    Matriz[fila, columna] = Matriz[i, j];
                    Matriz[i, j] = temp;
                }
        }  
        public void Jugar(int f1, int c1, int f2, int c2)
        {
            if (Matriz[f1, c1] == Matriz[f2, c2])
            {
                if (ExisteCamino(MascaraBool(), f1, c1, f2, c2))
                {
                    Matriz[f2, c2] += 1;
                    Matriz[f1, c1] = 0;
                    Puntuación += Matriz[f2, c2];
                    GenerarCasilla(1);
                    
                    if (Agresivo)
                    {
                        ContadorAgresivo++;
                        if (ContadorAgresivo == 15)
                        {
                            ContadorAgresivo = 0;
                            Mezclar();
                        }
                    }
                }                    
            }               
            else if (Matriz[f2, c2] == 0)
            {
                if (ExisteCamino(MascaraBool(), f1, c1, f2, c2))
                {
                    Matriz[f2, c2] = Matriz[f1, c1];
                    Matriz[f1, c1] = 0;
                    if (Agresivo)
                    {
                        ContadorAgresivo++;
                        if (ContadorAgresivo == 15)
                        {
                            Mezclar();
                            ContadorAgresivo = 0;
                        }
                    }
                    GenerarCasilla(1);
                    //Para saber si se puede generar una segunda casilla
                    for (int i = 0; i < TotalFilas; i++)
                    {
                        bool romper = false;
                        for (int j = 0; j < TotalColumnas; j++)
                        {
                            if (Matriz[i, j] == 0)
                            {
                                GenerarCasilla(1);
                                romper = true;
                                break;
                            }
                        }
                        if (romper) break;
                    }
                }                              
            }            
        }
        public bool JuegoPerdido()
        {
            for (int i = 0; i < TotalFilas; i++)
            {
                for (int j = 0; j < TotalColumnas; j++)
                {
                    if (Matriz[i, j] == 0) return false;
                    else
                    {
                        int[] df = { 1, -1, 0, 0 };
                        int[] dc = { 0, 0, 1, -1 };
                        for (int k = 0; k < df.Length; k++)
                        {
                            if (PosicionValida(i + df[k], j + dc[k]))
                                if (Matriz[i, j] == Matriz[i + df[k], j + dc[k]]) return false;
                        }
                    }
                }
            }
            return true;
        }
        #endregion

        #region Guardar y Cargar Partida
        public void GuardarModoNormal(ClassTwelve clase)
        {
            IFormatter salva = new BinaryFormatter();
            Stream archivo = new FileStream("SalvaModoNormal.hit", FileMode.Create, FileAccess.Write);
            salva.Serialize(archivo, clase);
            archivo.Close();
        }
        public ClassTwelve CargarModoNormal()
        {
            ClassTwelve clase = null;
            IFormatter salva = new BinaryFormatter();
            if(File.Exists("SalvaModoNormal.hit"))
            {
                Stream archivo = new FileStream("SalvaModoNormal.hit", FileMode.Open, FileAccess.Read);
                clase = (ClassTwelve)salva.Deserialize(archivo);
                archivo.Close();
            }
            return clase;
        }
        public void GuardarModoAgresivo(ClassTwelve clase)
        {
            IFormatter salva = new BinaryFormatter();
            Stream archivo = new FileStream("SalvaModoAgresivo.hit", FileMode.Create, FileAccess.Write);
            salva.Serialize(archivo, clase);
            archivo.Close();
        }
        public ClassTwelve CargarModoAgresivo()
        {
            ClassTwelve clase = null;
            IFormatter salva = new BinaryFormatter();
            if (File.Exists("SalvaModoAgresivo.hit"))
            {
                Stream archivo = new FileStream("SalvaModoAgresivo.hit", FileMode.Open, FileAccess.Read);
                clase = (ClassTwelve)salva.Deserialize(archivo);
                archivo.Close();
            }
            return clase;
        }
        #endregion
    }
}
