using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            File.WriteAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste_json.txt", "");
        }
        // Evento
        int Magreza = 0;
        int Saúdavel = 0;
        int Sobrepeso = 0;
        int OBG_I = 0;
        int OBG_II = 0;
        int OBG_III = 0;
        int id = 0;

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //File.AppendAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste_json.txt", "[" + Environment.NewLine);
        //}
        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //File.AppendAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste_json.txt", Environment.NewLine + "]");
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            string[] alllines = textBox3.Text.Split('\n');

            float peso = float.Parse(alllines[0]);
            float altura = float.Parse(alllines[1]);
            string nome = alllines[2];

            double IMC = peso / (altura * altura);

            string classs = "";

            if (IMC < 18.5)
            {
                Magreza++;
                classs = "Magreza";
            }
            if (IMC >= 18.5 && IMC <= 24.9)
            {
                Saúdavel++;
                classs = "Saudavel";
            }
            if (IMC >= 25 && IMC <= 29.9)
            {
                Sobrepeso++;
                classs = "Sobrepeso";
            }
            if (IMC >= 30 && IMC <= 34.9)
            {
                OBG_I++;
                classs = "OBG_I";
            }
            if (IMC >= 35 && IMC <= 39.9)
            {
                OBG_II++;
                classs = "OBG_II";
            }
            if (IMC >= 40)
            {
                OBG_III++;
                classs = "OBG_III";
            }
            id++;

            string text = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n<meta charset=\"UTF-8\">\r\n<title>Document</title>\r\n<script src='https://cdn.plot.ly/plotly-2.27.0.min.js'></script>\r\n</head>\r\n<body>\r\n<center><div id='myDiv' style=\"width: 500px; height:500px;\">Pesquisa de Indice\r\nde Massa Corporal</div></center>\r\n<script>\r\nvar data = [{\r\ntype: 'scatterpolar',\r\nr: [" + Magreza + ", " + Saúdavel + ", " + Sobrepeso + ", " + OBG_I + ", " + OBG_II + ", " + OBG_III + "],\r\ntheta: ['Magreza','Saúdavel','Sobrepeso', 'OBG-I', 'OBG-II', 'OBG-III'],\r\nfill: 'toself'\r\n}]\r\nlayout = {\r\npolar: {\r\nradialaxis: {\r\nvisible: true,\r\nrange: [0, 50]\r\n}\r\n},\r\nshowlegend: false\r\n}\r\nPlotly.newPlot(\"myDiv\", data, layout)\r\n</script>\r\n</body>\r\n</html>";
            string json = "\r\n{\r\n\'Id\': " + id + ",\r\n\'Nome\': \'" + nome + "\',\r\n\'Peso (Kg)\': " + peso + ",\r\n\'Altura (m)\': " + altura + ",\r\n\'IMC\': " + IMC + ",\r\n\'Classificação\': \'" + classs + "\'\r\n},";

            //\r\n{\r\n\'Id\': 2,\r\n\'Nome\': \'Maria Santos\',\r\n\'Peso (Kg)\': 85,\r\n\'Altura (m)\': 1.68,\r\n\'IMC\': 30.12,\r\n\'Classificação\': \'Obesidade Grau I\'\r\n},\r\n{\r\n\'Id\': 3,\r\n\'Nome\': \'Carlos Pereira\',\r\n\'Peso (Kg)\': 60,\r\n\'Altura (m)\': 1.6,\r\n\'IMC\': 23.44,\r\n\'Classificação\': \'Peso Normal\'\r\n\r\n}\r\n]";
            File.WriteAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste.html", text);
            //File.WriteAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste_json.txt", json);
            File.AppendAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste_json.txt", json + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chaves_ns = 0;
            bool vai = false;
            int id = int.Parse(textBox1.Text);

            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste_json.txt");

            foreach (string linhas in lines)
            {
                //textBox5.AppendText(linhas + Environment.NewLine);
                if (linhas == "{" || linhas == "},")
                {
                    if (linhas == "{")
                        chaves_ns = chaves_ns + 1;

                    //textBox5.AppendText(linhas + Environment.NewLine);
                    if (chaves_ns == id)
                        vai = true;

                    if (linhas == "}," && vai == true)
                        break;
                }
                else
                {
                    if (vai == true)
                        textBox5.AppendText(linhas + Environment.NewLine);
                    //File.AppendAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\consulta.txt", linhas + Environment.NewLine);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mucho_texto = textBox6.Text;
            //string replacionaitor = textBox2.Text;

            string replacionaitor = textBox4.Text;
            string replacionaitor_alvo = textBox7.Text;

            mucho_texto = mucho_texto.Replace(replacionaitor, replacionaitor_alvo);
            File.WriteAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste_json.txt", mucho_texto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mucho_texto = textBox6.Text;
            //string replacionaitor = textBox2.Text;

            string replacionaitor = textBox4.Text;
            //string replacionaitor_alvo = textBox7.Text;

            mucho_texto = mucho_texto.Replace(replacionaitor, "");
            File.WriteAllText(@"C:\Users\X7 Informática\Desktop\Nova pasta\teste_json.txt", mucho_texto);
        }
    }
}