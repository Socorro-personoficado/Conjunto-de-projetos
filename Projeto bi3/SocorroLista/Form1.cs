namespace SocorroLista
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        /*public void DesenhaPoligono(PaintEventArgs e, int[] x, int[] y, Pen corlinha) //SolidBrush cor, Pen corlinha)
        {
            e.Graphics.DrawLine(corlinha, x[0], y[0], x[0], y[1]);
            e.Graphics.DrawLine(corlinha, x[0], y[0], x[1], y[0]);
            e.Graphics.DrawLine(corlinha, x[1], y[1], x[0], y[1]);
            e.Graphics.DrawLine(corlinha, x[1], y[1], x[1], y[0]);
        }*/

        public void DesenhaPoligonoHex(PaintEventArgs e, Point[] pontos, Brush preenchimentoHex)
        {
            e.Graphics.FillPolygon(preenchimentoHex, pontos);
            //e.Graphics.FillEllipse(preenchimentoHex, 100, 20, 200, 100);
        }

        public void DesenhaPoligonoHexS(PaintEventArgs e, Point[] pontos, SolidBrush preenchimentoHexS)
        {
            e.Graphics.FillPolygon(preenchimentoHexS, pontos);
        }

        public void DesenhaLinha(PaintEventArgs e, int x, int y, int x2, int y2, Pen corlinha)
        {
            e.Graphics.DrawLine(corlinha, x, y, x2, y2);
        }

        public TextureBrush Hashura(String texto) // SolidBrush cor, Pen corlinha)
        {
            Bitmap bitmap = new Bitmap("C:/Users/Usuario1/Desktop/Textura2.jpg");
            TextureBrush tBrush = new TextureBrush(bitmap);
            return tBrush;
        }

        public Pen estilo_linha(float[] estilo, Color cor, int espessura)
        {
            Pen caneta = new Pen(cor, espessura);
            caneta.DashPattern = estilo;
            return caneta;
        }

        public Color cor(int R, int G, int B)
        {
            Color cor = new Color();
            cor = Color.FromArgb(R, G, B);
            return cor;
        }

        public int esp()
        {
            int esp = 3;
            return esp;
        }

        public float[] dash()
        {
            float[] estilo;
            estilo = new float[] { 1 };
            return estilo;
        }

        int anguloRotacao = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int tx = trackBar1.Value;
            int ty = trackBar2.Value;
            //int tr = trackBar3.Value;

            int te = trackBar4.Value;
            


            /*
            int raio = 200;
            int x1 = (int)(200 + raio * Math.Sin(tr * 3.14 / 180));
            int y1 = (int)(50 + raio * Math.Cos(tr * 3.14 / 180));
            int x2 = (int)(400 + raio * Math.Sin(tr * 3.14 / 180));
            int y2 = (int)(250 + raio * Math.Cos(tr * 3.14 / 180));

            Pen caneta = estilo_linha(dash(), cor(), esp());
            int[] vetx = { tx + x1, tx + x2 * te };
            int[] vety = { ty + y1, ty + y2 * te };
            SolidBrush fundo = new SolidBrush(cor());

            desenhaPoligono(e, vetx, vety, fundo, caneta);*/

            Pen caneta = estilo_linha(dash(), cor(0, 0, 0), esp());
            int centroX = 40 + tx;
            int centroY = 35 + ty;
            int raio = 200;
            int[] x = new int[6];
            int[] y = new int[6];


            Point[] pontos = new Point[6];
            // Calcula os vértices do hexágono com rotação
            for (int i = 0; i < 6; i++)
            {
                double anguloBase = -Math.PI / 2 + Math.PI / 3 * i;
                double anguloTotal = anguloBase + (Math.PI / 180) * anguloRotacao;

                x[i] = centroX + (int)(raio * Math.Cos(anguloTotal));
                y[i] = centroY + (int)(raio * Math.Sin(anguloTotal));
                Point point1 = new Point(x[i] * te, y[i] * te);
                pontos[i] = point1;
            }

            Brush preenchimentoHex;
            String texto = "Textura.jpg";
            if (textBox4.Text == "")
            {
                preenchimentoHex = Hashura(texto);
                DesenhaPoligonoHex(e, pontos, preenchimentoHex);

            }
            else
            {
                SolidBrush preenchimentoHexS = new SolidBrush(cor(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
                DesenhaPoligonoHexS(e, pontos, preenchimentoHexS);
            }

            //SolidBrush preenchimentoHexS = new SolidBrush(cor(255, 0, 0));
            //DesenhaPoligonoHex(e, pontos, preenchimentoHexS);






            // Triângulo com vértices 0, 2, 4
            //triangulo grande
            int[] xTri = { x[0], x[2], x[4] };
            int[] yTri = { y[0], y[2], y[4] };
            /*DesenhaLinha(e, xTri[0], yTri[0], xTri[1], yTri[1], caneta);
            DesenhaLinha(e, xTri[1], yTri[1], xTri[2], yTri[2], caneta);
            DesenhaLinha(e, xTri[2], yTri[2], xTri[0], yTri[0], caneta);*/


            // Triângulo invertido
            int[] xInv = new int[3];
            int[] yInv = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int j = (i + 1) % 3;
                xInv[i] = (xTri[i] + xTri[j]) / 2;
                yInv[i] = (yTri[i] + yTri[j]) / 2;
            }

           /* DesenhaLinha(e, xInv[0], yInv[0], xInv[1], yInv[1], caneta);
            DesenhaLinha(e, xInv[1], yInv[1], xInv[2], yInv[2], caneta);
            DesenhaLinha(e, xInv[2], yInv[2], xInv[0], yInv[0], caneta);*/

            

            int[] verticesDestino = { 1, 3, 5 };
            //retas das pontas do triangulo do meio para o externo
            /*for (int i = 0; i < 3; i++)
            {
                DesenhaLinha(e, xInv[i], yInv[i], x[verticesDestino[i]], y[verticesDestino[i]], caneta);
            }*/


            //Bordas
            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    DesenhaLinha(e, xInv[i] * te, yInv[i] * te, x[verticesDestino[i]] * te, y[verticesDestino[i]] * te, caneta);//retas das pontas do triangulo do meio para o externo
                    DesenhaLinha(e, xTri[i]*te, yTri[i] * te, xTri[i-2] * te, yTri[i - 2] * te, caneta); //triangulo grande
                    DesenhaLinha(e, xInv[i] * te, yInv[i] * te, xInv[i - 2] * te, yInv[i - 2] * te, caneta);// Triângulo invertido
                    DesenhaLinha(e, x[verticesDestino[i]] * te, y[verticesDestino[i]] * te, xTri[i - 2] * te, yTri[i - 2] * te, caneta);//Bordas
                    DesenhaLinha(e, x[verticesDestino[i]] * te, y[verticesDestino[i]] * te, xTri[i] * te, yTri[i] * te, caneta);//Bordas
                }
                else
                {
                    DesenhaLinha(e, xInv[i] * te, yInv[i] * te, x[verticesDestino[i]]* te, y[verticesDestino[i]] * te, caneta);
                    DesenhaLinha(e, xTri[i] * te, yTri[i] * te, xTri[i + 1] * te, yTri[i + 1] * te, caneta); //triangulo grande
                    DesenhaLinha(e, xInv[i] * te, yInv[i] * te, xInv[i + 1] * te, yInv[i+1] * te, caneta);// Triângulo invertido
                    DesenhaLinha(e, x[verticesDestino[i]] * te, y[verticesDestino[i]] * te, xTri[i + 1] * te, yTri[i + 1] * te, caneta);//Bordas
                    DesenhaLinha(e, x[verticesDestino[i]] * te, y[verticesDestino[i]] * te, xTri[i] * te, yTri[i] * te, caneta);//Bordas
                }
            }


            // Desenha o número "1" com linhas, rotacionado manualmente
            double anguloRad = (Math.PI / 180) * anguloRotacao;

            // Coordenadas locais (relativas ao centro) do "1"
            Point[] segmentos = new Point[]
            {
                new Point(0, -30), new Point(0, 30),     // Linha vertical do "1"
                new Point(-5, -25), new Point(0, -30),   // Base superior inclinada
                new Point(-5, -25), new Point(-5, -20),  // Reforço lateral (opcional)
            };

            // Rotaciona e desenha cada par de pontos
            for (int i = 0; i < segmentos.Length; i += 2)
            {
                // Primeiro ponto
                int x1 = segmentos[i].X;
                int y1 = segmentos[i].Y;
                int xr1 = (int)(x1 * Math.Cos(anguloRad) - y1 * Math.Sin(anguloRad)) + centroX;
                int yr1 = (int)(x1 * Math.Sin(anguloRad) + y1 * Math.Cos(anguloRad)) + centroY;

                // Segundo ponto
                int x2 = segmentos[i + 1].X;
                int y2 = segmentos[i + 1].Y;
                int xr2 = (int)(x2 * Math.Cos(anguloRad) - y2 * Math.Sin(anguloRad)) + centroX;
                int yr2 = (int)(x2 * Math.Sin(anguloRad) + y2 * Math.Cos(anguloRad)) + centroY;

                // Desenha a linha que representa parte do "1"
                DesenhaLinha(e, xr1 * te, yr1 * te, xr2 * te, yr2 * te, caneta);
            }



            /*
            for (int i = 0; i < 1; i++)
            {
                double anguloBase = -Math.PI / 2 + Math.PI / 3 * i;
                double anguloTotal = anguloBase + (Math.PI / 180) * anguloRotacao;

                x[i] = ((xInv[0] + xInv[1] + xInv[2]) / 3) + (int)(raio * Math.Cos(anguloTotal));
                y[i] = ((yInv[0] + yInv[1] + yInv[2]) / 3) + (int)(raio * Math.Sin(anguloTotal));
                //Point point1 = new Point(x[i], y[i]);
                //pontos[i] = point1;
            }


            DesenhaLinha(e, ((xInv[0] + xInv[1] + xInv[2]) / 3), ((yInv[0] + yInv[1] + yInv[2]) / 3), x[0] - 30, y[0] -30, caneta);*/
        }
        /*
        private void trackBarRotacao_Scroll(object sender, EventArgs e)
        {
            // Arredonda o valor para o múltiplo de 90 mais próximo
            int valor = ((int)Math.Round(trackBar3.Value / 90.0)) * 90;

            // Corrige se precisar
            if (valor != trackBar3.Value)
                trackBar3.Value = valor;

            anguloRotacao = valor;
            this.Invalidate();
        }*/

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            // Arredonda o valor para o múltiplo de 90 mais próximo
            int valor = ((int)Math.Round(trackBar3.Value / 90.0)) * 90;

            // Corrige se precisar
            if (valor != trackBar3.Value)
                trackBar3.Value = valor;

            anguloRotacao = valor;
            panel1.Invalidate();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

    }
}
