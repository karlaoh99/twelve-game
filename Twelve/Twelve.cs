using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_Twelve;
using System.Media;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Twelve
{
    [Serializable]
    public partial class
        frm_Twelve : Form
    {              
        static int totalFilas = 5;
        static int totalColumnas = 4;        
        static int clicks = 1;
        static int fila1;
        static int columna1;
        static bool agresivo;
        int[] Best = new int[2];
       
        ClassTwelve juego;
        SoundPlayer[] Sonidos = new SoundPlayer[3];        

        public frm_Twelve()
        {
            InitializeComponent();
            Sonidos[0] = new SoundPlayer(Application.StartupPath + @"\Sonidos\Modo normal.wav");
            Sonidos[1] = new SoundPlayer(Application.StartupPath + @"\Sonidos\Modo agresivo.wav");
            Sonidos[2] = new SoundPlayer(Application.StartupPath + @"\Sonidos\Pop.wav");
            if(File.Exists("Best.hit")) CargarBest();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Botones Menú Principal
        private void btn_ModoNormal_Click(object sender, EventArgs e)
        {
            Sonidos[2].Play();
            agresivo = false;
            if (File.Exists("SalvaModoNormal.hit"))
            {
                DialogResult result = MessageBox.Show("¿Desea continuar la partida guardada?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) Continuar();
                else Comenzar();                
            }  
            else Comenzar();
            if (sonidoToolStripMenuItem.Checked) Sonidos[0].PlayLooping();
        }
        private void btn_ModoAgresivo_Click(object sender, EventArgs e)
        {
            Sonidos[2].Play();
            agresivo = true;            
            if (File.Exists("SalvaModoAgresivo.hit"))
            {
                DialogResult result = MessageBox.Show("¿Desea continuar la partida guardada?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) Continuar();
                else Comenzar();                
            }
            else Comenzar();
            progressBar1.Show();
            if (sonidoToolStripMenuItem.Checked) Sonidos[1].PlayLooping();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Sonidos[2].Play();
            Application.Exit();
        }       
        #endregion

        #region Barra de Menú
        private void juegoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comenzar();
        }
        private void guardarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!agresivo) juego.GuardarModoNormal(juego);
            else juego.GuardarModoAgresivo(juego);
        }
        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbox_Personalizar.Hide();
            progressBar1.Hide();
            pbx_Tablero.Hide();

            lbl_Puntuacion.Hide();
            lbl_Puntuacion1.Hide();
            lbl_Best1.Hide();
            lbl_Best.Hide();

            gbx_MenuPrincipal.Show();

            juegoNuevoToolStripMenuItem.Enabled = false;
            cambiarTableroToolStripMenuItem.Enabled = false;
            guardarPartidaToolStripMenuItem.Enabled = false;
            Sonidos[0].Stop();
            Sonidos[1].Stop();
        }       
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Karla Olivera Hernández. Grupo: C113.", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cambiarTableroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point location = new Point(36, 228);
            gbox_Personalizar.Location = location;
            Size size = new Size(286, 159);
            gbox_Personalizar.Size = size;
            gbox_Personalizar.Show();
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            totalFilas = Convert.ToInt32(nud_Filas.Value);
            totalColumnas = Convert.ToInt32(nud_Columnas.Value);
            gbox_Personalizar.Hide();
            Comenzar();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gbox_Personalizar.Hide();
        }
        private void sonidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sonidoToolStripMenuItem.Checked)
            {
                Sonidos[0].Stop();
                Sonidos[1].Stop();
                sonidoToolStripMenuItem.Checked = false;
            }
            else
            {
                sonidoToolStripMenuItem.Checked = true;
                if (agresivo) Sonidos[1].PlayLooping();
                else Sonidos[0].PlayLooping();
            }
        }
        #endregion

        private void Comenzar()
        {
            fila1 = -1;
            columna1 = -1;
            clicks = 1;

            gbx_MenuPrincipal.Hide();

            juego = new ClassTwelve(totalFilas, totalColumnas, agresivo);

            lbl_Puntuacion.Show();
            lbl_Puntuacion1.Show();
            lbl_Best.Show();
            lbl_Best1.Show();
            lbl_Puntuacion.Text = $"{juego.Puntuación}";

            pbx_Tablero.Refresh();
            pbx_Tablero.Show();            

            juegoNuevoToolStripMenuItem.Enabled = true;
            cambiarTableroToolStripMenuItem.Enabled = true;
            guardarPartidaToolStripMenuItem.Enabled = true;
            if (agresivo)
            {
                progressBar1.Value = 0;
                lbl_Best.Text = $"{Best[1]}";
            }
            else lbl_Best.Text = $"{Best[0]}";
        }
        private void Continuar()
        {
            Comenzar();
            if (!agresivo)
            {
                juego = juego.CargarModoNormal();
                lbl_Best.Text = $"{Best[0]}";
            }
            else
            {
                juego = juego.CargarModoAgresivo();
                lbl_Best.Text = $"{Best[1]}";
                progressBar1.Value = juego.ContadorAgresivo;
            }
            totalFilas = juego.TotalFilas;
            totalColumnas = juego.TotalColumnas;
            pbx_Tablero.Refresh();
            lbl_Puntuacion.Text = $"{juego.Puntuación}";
        }     
        private void pbx_Tablero_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafico = e.Graphics;
            Pen pincel = new Pen(Color.FromArgb(3, 223, 255), 4);
            float anchoCasilla = (float)pbx_Tablero.Width / totalColumnas;
            float largoCasilla = (float)pbx_Tablero.Height / totalFilas;
            float tamañoString = Math.Min(anchoCasilla, largoCasilla) / (float)2;
            Color[] colores = { Color.FromArgb(255, 128, 128), Color.FromArgb(0, 255, 64), Color.FromArgb(255, 128, 64), Color.FromArgb(255, 255, 60), Color.FromArgb(255, 15, 15), Color.FromArgb(146, 36, 255), Color.FromArgb(0, 128, 255), Color.FromArgb(183, 183, 183), Color.FromArgb(255, 128, 255), Color.FromArgb(0, 164, 82), Color.FromArgb(128, 128, 0), Color.FromArgb(0, 0, 255) };

            for (int i = 0; i <= totalColumnas; i++)
                grafico.DrawLine(pincel, i * anchoCasilla, 0, i * anchoCasilla, pbx_Tablero.Height);
            for (int k = 0; k <= totalFilas; k++)
                grafico.DrawLine(pincel, 0, k * largoCasilla, pbx_Tablero.Width, k * largoCasilla);

            for (int i = 0; i < totalFilas; i++)
                for (int j = 0; j < totalColumnas; j++)
                {
                    if (juego.Matriz[i, j] != 0)
                    {
                        SolidBrush brocha1 = new SolidBrush(colores[(juego.Matriz[i, j] - 1) % colores.Length]);
                        SolidBrush brocha2 = new SolidBrush(Color.FromArgb(3, 223, 255));
                        RectangleF rectangulo = new RectangleF((float)j * anchoCasilla + 2, (float)i * largoCasilla + 2, anchoCasilla - 4, largoCasilla - 4);
                        if (clicks == 1 && fila1 == i && columna1 == j)
                            grafico.FillRectangle(brocha2, rectangulo);                                
                        else
                            grafico.FillRectangle(brocha1, rectangulo);                       
                        StringFormat numeros = new StringFormat();
                        numeros.Alignment = StringAlignment.Center;
                        numeros.LineAlignment = StringAlignment.Center;
                        grafico.DrawString($"{juego.Matriz[i, j]}", new Font("", tamañoString), Brushes.Black, rectangulo, numeros);                        
                    }
                }
        }
        private void pbx_Tablero_MouseClick(object sender, MouseEventArgs e)
        {
            int f = e.Y * totalFilas / pbx_Tablero.Height;
            int c = e.X * totalColumnas / pbx_Tablero.Width;

            if (clicks == 1 && juego.Matriz[f, c] != 0)
            {
                fila1 = f;
                columna1 = c;
                pbx_Tablero.Refresh();
                clicks = 2;
            }
            else if (clicks == 2 && (f != fila1 || c != columna1))
            {
                juego.Jugar(fila1, columna1, f, c);
                pbx_Tablero.Refresh();
                clicks = 1;
                lbl_Puntuacion.Text = $"{juego.Puntuación}";
                if (agresivo)
                {
                    if (juego.Puntuación > Best[1])
                    {
                        Best[1] = juego.Puntuación;
                        lbl_Best.Text = $"{Best[1]}";
                        GuardarBest();
                    }
                    progressBar1.Value = juego.ContadorAgresivo;
                }
                else if (juego.Puntuación > Best[0])
                {
                    Best[0] = juego.Puntuación;
                    lbl_Best.Text = $"{Best[0]}";
                    GuardarBest();
                }
                if (juego.JuegoPerdido())
                {
                    if (!agresivo && juego.Puntuación == Best[0]) MessageBox.Show($"Felicidades!!! Has alcanzado un nuevo record de: {juego.Puntuación} puntos.");
                    else if (agresivo && juego.Puntuación == Best[1]) MessageBox.Show($"Felicidades!!! Has alcanzado un nuevo record de: {juego.Puntuación} puntos.");
                    else MessageBox.Show("Has Perdido !!! !!!");
                }
            }
            else if (clicks == 2 && f == fila1 && c == columna1)
            {
                pbx_Tablero.Refresh();
                clicks = 1;
            }
        }        
       
        public void GuardarBest()
        {
            BinaryFormatter format = new BinaryFormatter();

            FileStream best = new FileStream("Best.hit", FileMode.OpenOrCreate);
            format.Serialize(best, Best);
            best.Close();
        }
        public void CargarBest()
        {
            BinaryFormatter format = new BinaryFormatter();

            if (File.Exists("Best.hit"))
            {
                FileStream best = new FileStream("Best.hit", FileMode.Open);
                Best = (int[])format.Deserialize(best);
                best.Close();
            }                
        }        
    }
}
