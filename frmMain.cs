using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_la_Vida
{
    public partial class frmMain : Form
    {
        int numeroCelulas = 30;
        int tamañoCelula = 20;
        System.Drawing.Graphics g;
        bool[,] celula =  new bool[30, 30];

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inicializar todas las celulas como muertas x_x
            for (int x = 0; x < numeroCelulas; x++)
            {
                for (int y = 0; y < numeroCelulas; y++)
                {
                    celula[x, y] = false;
                }
            }
        }

        private void nuevaGeneracion()
        {
            bool[,] celulaNueva = new bool[numeroCelulas, numeroCelulas];
            int numVecinos;
            for (int x = 0; x < numeroCelulas; x++)
            {
                for (int y = 0; y < numeroCelulas; y++)
                {
                    celulaNueva[x, y] = celula[x, y];
                    numVecinos = contarVecinos(x, y);
                    if (numVecinos < 2 || numVecinos > 3) //muere
                    {
                        celulaNueva[x, y] = false;
                    }
                    if (celulaNueva[x, y] == false && numVecinos == 3) //nace
                    {
                        celulaNueva[x, y] = true;
                    }
                    if (celulaNueva[x, y] == true && (numVecinos == 2 || numVecinos == 3)) //sobrevive
                    {
                        celulaNueva[x, y] = true;
                    }
                }
            }
            celula = celulaNueva;
            pintarCelulas();
        }

        private int contarVecinos(int x, int y)
        {
            int vecinos = 0;
            for (int i = x - 1; i <= x + 1; i++) //desde la columna actual menos uno, hasta la columna actual mas uno
            {
                for (int j = y - 1; j <= y + 1; j++) //desde la fila actual menos uno, hasta la fila actual mas uno
                {
                    if (!(x == i && y == j) && i >= 0 && j >= 0 && i < numeroCelulas && j < numeroCelulas) //para evitar contarn a la celula actual, y no salirnos de los bordes
                    {
                        if (celula[i, j] == true)
                        {
                            vecinos++; //sumamos los vecinos
                        }
                    }
                }
            }
            return vecinos;
        }

        private void pintarCelulas()
        {
            g = this.CreateGraphics();
            for (int x = 0; x < numeroCelulas; x++)
            {
                for (int y = 0; y < numeroCelulas; y++)
                {
                    if (celula[x, y]) //si la celula esta viva...
                    {
                        //dibujamos un cuadro
                        Rectangle rect =
                                new Rectangle((tamañoCelula * x),
                                              (tamañoCelula * y),
                                              tamañoCelula,
                                              tamañoCelula);
                        g.FillRectangle(Brushes.SlateGray, rect);
                    }
                    else
                    {
                        //borramos el cuadro
                        Rectangle rect =
                                new Rectangle((tamañoCelula * x),
                                              (tamañoCelula * y),
                                              tamañoCelula,
                                              tamañoCelula);
                        g.FillRectangle(Brushes.White, rect);
                    }
                }
            }
            frmMain_Paint(null, null); //redibujamos las lineas del grid
            g.Dispose();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            //pintamos las lineas del grid
            for (int i = 0; i < numeroCelulas; i++)
            {
                //vertical
                g.DrawLine(Pens.SlateGray, i * tamañoCelula, 0, i * tamañoCelula, numeroCelulas * tamañoCelula);
                //horizontal
                g.DrawLine(Pens.SlateGray, 0, i * tamañoCelula, numeroCelulas * tamañoCelula, i * tamañoCelula);
            }
            //ultima linea
            g.DrawLine(Pens.SlateGray, numeroCelulas * tamañoCelula, 0, numeroCelulas * tamañoCelula, numeroCelulas * tamañoCelula);
            g.Dispose();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            //iniciamos el timer para crear nuevas generaciones de celulas
            tmrLoop.Enabled = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
            //detenemos el timer, esto permite q insertemos nuevas celulas manualmente
            tmrLoop.Enabled = false;
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            g = this.CreateGraphics();
            int celulaX = 0;
            int celulaY = 0;
            //verificar q no hagan clic fuera del grid
            if (e.Location.X > 0 & e.Location.X < 600 & e.Location.Y > 0 & e.Location.Y < 635)
            {
                //obtener la ubicacion de la celula
                celulaX = Convert.ToInt32(Math.Truncate(Convert.ToDouble(e.Location.X) / tamañoCelula));
                celulaY = Convert.ToInt32(Math.Truncate(Convert.ToDouble(e.Location.Y) / tamañoCelula));
                //marcar la celula como viva
                celula[celulaX, celulaY] = true;
                //dibujamos un cuadro
                Rectangle rect =
                        new Rectangle((tamañoCelula * celulaX),
                                      (tamañoCelula * celulaY),
                                      tamañoCelula,
                                      tamañoCelula);
                g.FillRectangle(Brushes.SlateGray, rect);
                g.Dispose();
            }
        }

        private void tmrLoop_Tick(object sender, EventArgs e)
        {
            nuevaGeneracion();
        }
    }
}
