using System.IO;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace lista_funcional2
{

    //se perder o front end me avisa E SE VOCE tentar apertar no mesmo lugar da erro e tem muitos numeros depois da virgula na distancia da linha mas nao acho que isso é pedido
    //no projeto
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //vairiaveis globais
        int Click = 0, esp = 2;
        int[] Mouse_Cord = [4];
        //point é do e do MouseEventArgs pega cordenada do mouse direto pelo e.Location so que vem com os X e Y junto usa cord.X/Y para pegaro respequitivo
        Point cord, cord2;

        public Pen estilo_linha(float[] estilo, Color cor, int esp)
        {
            Pen caneta = new Pen(cor, esp);
            caneta.DashPattern = estilo;
            return caneta;

        }

        public Color cor(int r, int g, int b)
        {
            Color cor = new Color();
            cor = Color.FromArgb(r, g, b);
            return cor;
        }

        public void desenhar(PaintEventArgs e, Pen caneta, int x1, int y1, int x2, int y2)
        {
            e.Graphics.DrawLine(caneta, x1, y1, x2, y2);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            float[] dash = [7];

            if (comboBox1.Text == "Nenhuma" || comboBox1.Text == "Linha Sólida")
            {
                dash = [1]; ;
            }
            if (comboBox1.Text == "Linha Tracejada")
            {
                dash = [5, 1];
            }
            if (comboBox1.Text == "Linha Traço ponto")
            {
                dash = [5, 2, 1, 2];
            }
            if (comboBox1.Text == "Linha Traço dois pontos")
            {
                dash = [5, 2, 1, 2, 1, 2];
            }
            if (comboBox1.Text == "Linha Pontilhada")
            {
                dash = [2, 2];
            }
            Pen caneta = estilo_linha(dash, cor(0, 0, 0), esp);
            if (comboBox1.Text == "Retângulo")
            {
                //provalmente de como otimizar os if é esse quadro mas seila vai que na tem
                desenhar(e, caneta, cord.X, cord.Y, cord.X, cord.Y + int.Parse(textBox2.Text));
                desenhar(e, caneta, cord.X, cord.Y + int.Parse(textBox2.Text), cord.X + int.Parse(textBox1.Text), cord.Y + int.Parse(textBox2.Text));
                desenhar(e, caneta, cord.X + int.Parse(textBox1.Text), cord.Y + int.Parse(textBox2.Text), cord.X + int.Parse(textBox1.Text), cord.Y);
                desenhar(e, caneta, cord.X, cord.Y, cord.X + int.Parse(textBox1.Text), cord.Y);
            }
            else
            {
                desenhar(e, caneta, cord.X, cord.Y, cord2.X, cord2.Y);
            }

            // pra redesenhar o paint ativa no  this.Refresh(); logo abaixo
            this.Update();

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Click++;
            if (Click == 2)
            {
                cord2 = e.Location;
                //click - 2 pra pode entra no if denovo
                Click = Click - 2;
                int x0 = cord.X, y0 = cord.Y, x1 = cord2.X, y1 = cord2.Y;
                float comp = (x1 - x0) + (y1 - y0);
                if (comp < 0)
                {
                    comp = comp * -1;
                }
                label1.Text = "f(x) = " + (y1 - y0) / (x1 - x0) + "x + " + (y1 - ((y1 - y0) / (x1 - x0) * x1)) + "  Comprimento = " + (Math.Pow(comp, 0.5));
                this.Refresh();
            }
            else
            {
                //primeiro click
                cord = e.Location;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            //pra almentar a expessura e os numero no numpad
            // se voce esta se peguntando como esse private void existe tem que clickar no painei(como exemplo) e ir no raio dele onde fica suas propiedades a sim da pra suas ações
            // e como ele integare com outras(como contar click mesmo clikando nele

            if (e.KeyCode == Keys.NumPad8 && esp < 6)
            {
                esp++;
            }
            else if (e.KeyCode == Keys.NumPad2 && esp > 1)
            {
                esp--;
            }
        }
    }
}
