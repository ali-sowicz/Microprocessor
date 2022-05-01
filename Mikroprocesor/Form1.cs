using System;
using System.Collections;
using System.Windows.Forms;

namespace Mikroprocesor
{
    public partial class Form1 : Form
    {

        private static int[] rejestrA = new int[16];
        private static int[] rejestrB = new int[16];
        private static int[] rejestrC = new int[16];
        private static int[] rejestrD = new int[16];
        private static int[] rejestrN = new int[16];
        string finalny;
        string Ax;
        string Bx;
        string Cx;
        string Dx;
        string Nx;
        int increment;
       

        public Form1()
        {
            InitializeComponent();

            
        }
        private void rejA()
        {
            if (checkBox2.Checked) rejestrA[0] = 0; else rejestrA[0] = 1;
            if (checkBox3.Checked) rejestrA[1] = 0; else rejestrA[1] = 1;
            if (checkBox7.Checked) rejestrA[2] = 0; else rejestrA[2] = 1;
            if (checkBox5.Checked) rejestrA[3] = 0; else rejestrA[3] = 1;
            if (checkBox15.Checked) rejestrA[4] = 0; else rejestrA[4] = 1;
            if (checkBox13.Checked) rejestrA[5] = 0; else rejestrA[5] = 1;
            if (checkBox11.Checked) rejestrA[6] = 0; else rejestrA[6] = 1;
            if (checkBox9.Checked) rejestrA[7] = 0; else rejestrA[7] = 1;
            if (checkBox23.Checked) rejestrA[8] = 0; else rejestrA[8] = 1;
            if (checkBox21.Checked) rejestrA[9] = 0; else rejestrA[9] = 1;
            if (checkBox19.Checked) rejestrA[10] = 0; else rejestrA[10] = 1;
            if (checkBox17.Checked) rejestrA[11] = 0; else rejestrA[11] = 1;
            if (checkBox31.Checked) rejestrA[12] = 0; else rejestrA[12] = 1;
            if (checkBox29.Checked) rejestrA[13] = 0; else rejestrA[13] = 1;
            if (checkBox27.Checked) rejestrA[14] = 0; else rejestrA[14] = 1;
            if (checkBox25.Checked) rejestrA[15] = 0; else rejestrA[15] = 1;

        }
        private void rejB()
        {
            if (checkBox63.Checked) rejestrB[0] = 0; else rejestrB[0] = 1;
            if (checkBox61.Checked) rejestrB[1] = 0; else rejestrB[1] = 1;
            if (checkBox59.Checked) rejestrB[2] = 0; else rejestrB[2] = 1;
            if (checkBox57.Checked) rejestrB[3] = 0; else rejestrB[3] = 1;
            if (checkBox55.Checked) rejestrB[4] = 0; else rejestrB[4] = 1;
            if (checkBox53.Checked) rejestrB[5] = 0; else rejestrB[5] = 1;
            if (checkBox51.Checked) rejestrB[6] = 0; else rejestrB[6] = 1;
            if (checkBox49.Checked) rejestrB[7] = 0; else rejestrB[7] = 1;
            if (checkBox47.Checked) rejestrB[8] = 0; else rejestrB[8] = 1;
            if (checkBox45.Checked) rejestrB[9] = 0; else rejestrB[9] = 1;
            if (checkBox43.Checked) rejestrB[10] = 0; else rejestrB[10] = 1;
            if (checkBox41.Checked) rejestrB[11] = 0; else rejestrB[11] = 1;
            if (checkBox39.Checked) rejestrB[12] = 0; else rejestrB[12] = 1;
            if (checkBox37.Checked) rejestrB[13] = 0; else rejestrB[13] = 1;
            if (checkBox35.Checked) rejestrB[14] = 0; else rejestrB[14] = 1;
            if (checkBox33.Checked) rejestrB[15] = 0; else rejestrB[15] = 1;

        }

        private void rejC()
        {
            if (checkBox95.Checked) rejestrC[0] = 0; else rejestrC[0] = 1;
            if (checkBox93.Checked) rejestrC[1] = 0; else rejestrC[1] = 1;
            if (checkBox91.Checked) rejestrC[2] = 0; else rejestrC[2] = 1;
            if (checkBox89.Checked) rejestrC[3] = 0; else rejestrC[3] = 1;
            if (checkBox87.Checked) rejestrC[4] = 0; else rejestrC[4] = 1;
            if (checkBox85.Checked) rejestrC[5] = 0; else rejestrC[5] = 1;
            if (checkBox83.Checked) rejestrC[6] = 0; else rejestrC[6] = 1;
            if (checkBox81.Checked) rejestrC[7] = 0; else rejestrC[7] = 1;
            if (checkBox79.Checked) rejestrC[8] = 0; else rejestrC[8] = 1;
            if (checkBox77.Checked) rejestrC[9] = 0; else rejestrC[9] = 1;
            if (checkBox75.Checked) rejestrC[10] = 0; else rejestrC[10] = 1;
            if (checkBox73.Checked) rejestrC[11] = 0; else rejestrC[11] = 1;
            if (checkBox71.Checked) rejestrC[12] = 0; else rejestrC[12] = 1;
            if (checkBox69.Checked) rejestrC[13] = 0; else rejestrC[13] = 1;
            if (checkBox67.Checked) rejestrC[14] = 0; else rejestrC[14] = 1;
            if (checkBox65.Checked) rejestrC[15] = 0; else rejestrC[15] = 1;

        }
        private void rejD()
        {
            if (checkBox127.Checked) rejestrD[0] = 0; else rejestrD[0] = 1;
            if (checkBox125.Checked) rejestrD[1] = 0; else rejestrD[1] = 1;
            if (checkBox123.Checked) rejestrD[2] = 0; else rejestrD[2] = 1;
            if (checkBox121.Checked) rejestrD[3] = 0; else rejestrD[3] = 1;
            if (checkBox119.Checked) rejestrD[4] = 0; else rejestrD[4] = 1;
            if (checkBox117.Checked) rejestrD[5] = 0; else rejestrD[5] = 1;
            if (checkBox115.Checked) rejestrD[6] = 0; else rejestrD[6] = 1;
            if (checkBox113.Checked) rejestrD[7] = 0; else rejestrD[7] = 1;
            if (checkBox111.Checked) rejestrD[8] = 0; else rejestrD[8] = 1;
            if (checkBox109.Checked) rejestrD[9] = 0; else rejestrD[9] = 1;
            if (checkBox107.Checked) rejestrD[10] = 0; else rejestrD[10] = 1;
            if (checkBox105.Checked) rejestrD[11] = 0; else rejestrD[11] = 1;
            if (checkBox103.Checked) rejestrD[12] = 0; else rejestrD[12] = 1;
            if (checkBox101.Checked) rejestrD[13] = 0; else rejestrD[13] = 1;
            if (checkBox99.Checked) rejestrD[14] = 0; else rejestrD[14] = 1;
            if (checkBox97.Checked) rejestrD[15] = 0; else rejestrD[15] = 1;

        }
        private void rejN()
        {
            if (checkBox159.Checked) rejestrN[0] = 0; else rejestrN[0] = 1;
            if (checkBox157.Checked) rejestrN[1] = 0; else rejestrN[1] = 1;
            if (checkBox155.Checked) rejestrN[2] = 0; else rejestrN[2] = 1;
            if (checkBox153.Checked) rejestrN[3] = 0; else rejestrN[3] = 1;
            if (checkBox151.Checked) rejestrN[4] = 0; else rejestrN[4] = 1;
            if (checkBox149.Checked) rejestrN[5] = 0; else rejestrN[5] = 1;
            if (checkBox147.Checked) rejestrN[6] = 0; else rejestrN[6] = 1;
            if (checkBox145.Checked) rejestrN[7] = 0; else rejestrN[7] = 1;
            if (checkBox143.Checked) rejestrN[8] = 0; else rejestrN[8] = 1;
            if (checkBox141.Checked) rejestrN[9] = 0; else rejestrN[9] = 1;
            if (checkBox139.Checked) rejestrN[10] = 0; else rejestrN[10] = 1;
            if (checkBox137.Checked) rejestrN[11] = 0; else rejestrN[11] = 1;
            if (checkBox135.Checked) rejestrN[12] = 0; else rejestrN[12] = 1;
            if (checkBox133.Checked) rejestrN[13] = 0; else rejestrN[13] = 1;
            if (checkBox131.Checked) rejestrN[14] = 0; else rejestrN[14] = 1;
            if (checkBox129.Checked) rejestrN[15] = 0; else rejestrN[15] = 1;

        }

        private void ADD(string a, string b, Label k)
        {
            int outputA = Convert.ToInt32(a,2);
            int outputB = Convert.ToInt32(b, 2);
            int sum = outputA + outputB;
            string binary = Convert.ToString(sum, 2);
            dopelnij(binary);
            k.Text = finalny;
            b = finalny;
        }
        private void SUB(string a, string b, Label k)
        {
            int outputA = Convert.ToInt32(a, 2);
            int outputB = Convert.ToInt32(b, 2);
            int sum = outputA - outputB;
            string binary = Convert.ToString(sum, 2);
            dopelnij(binary);
            k.Text = finalny;
            b = finalny;
        }
        private void MOV(string a, string b, Label k)
        {
            string str = b.Replace(b, a);
            k.Text = str;
            b = str;
        }
        private void dopelnij(string c)
        {
            if (c.Length < 16)
            {
                int zero = 16 - c.Length;
                int[] z = new int[zero];
                foreach (int i in z) z[i] = 0;
                string dodZera = string.Join("", z);
                finalny = dodZera + c;
            }
        }
        private void krok(int k)
        {
            Label w = null;
            string pol1 = null;
            string pol2 = null;
            string zawartosc = labelOp.Text;

            Ax = labelA.Text;
            Bx = labelB.Text;
            Cx = labelC.Text;
            Dx = labelD.Text;

            var label = new ArrayList(zawartosc.Split(';'));
            string str = label[k].ToString();
            string[] polecenia = str.Split(' ');

            if (polecenia.Length == 3)
            {
                if (polecenia[0].Contains("Ax")) pol1 = Ax;
                else if (polecenia[0].Contains("Bx")) pol1 = Bx;
                else if (polecenia[0].Contains("Cx")) pol1 = Cx;
                else if (polecenia[0].Contains("Dx")) pol1 = Dx;

                if (polecenia[2].Equals("Ax"))
                {
                    pol2 = Ax;
                    w = labelA;
                }
                else if (polecenia[2].Equals("Bx"))
                {
                    pol2 = Bx;
                    w = labelB;
                }
                else if (polecenia[2].Equals("Cx"))
                {
                    pol2 = Cx;
                    w = labelC;
                }
                else if (polecenia[2].Equals("Dx"))
                {
                    pol2 = Dx;
                    w = labelD;
                }

                if (polecenia[1].Equals("ADD")) ADD(pol1, pol2, w);
                if (polecenia[1].Equals("SUB")) SUB(pol1, pol2, w);
                if (polecenia[1].Equals("MOV")) MOV(pol1, pol2, w);

            }

        }

        private void buttonLoad1(object sender, EventArgs e)
        {
            rejA();
            Ax = string.Join("", rejestrA);
            labelA.Text = Ax;
        }

        private void buttonLoad2(object sender, EventArgs e)
        {
            rejB();
            Bx = string.Join("", rejestrB);
            labelB.Text = Bx;
        }

        private void buttonLoad3(object sender, EventArgs e)
        {
            rejC();
            Cx = string.Join("", rejestrC);
            labelC.Text = Cx;

        }

        private void buttonLoad4(object sender, EventArgs e)
        {
            rejD();
            Dx = string.Join("", rejestrD);
            labelD.Text = Dx;
        }

        private void buttonLoad5(object sender, EventArgs e)
        {
            rejN();
            Nx = string.Join("", rejestrN);
            labelN.Text = Nx;
        }

        private void buttonExOrder(object sender, EventArgs e)
        { 
            Label w = null;
            string rej1 = null;
            string rej2 = null;
            Ax = labelA.Text;
            Bx = labelB.Text;
            Cx = labelC.Text;
            Dx = labelD.Text;
            switch (comboBox2.SelectedIndex)
            {
                case 0: 
                    rej1 = Ax;
                    break;
                case 1:
                    rej1 = Bx;
                    break;
                case 2:
                    rej1 = Cx;
                    break;
                case 3:
                    rej1 = Dx;
                    break;
            }

            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    rej2 = Ax;
                    w = labelA;
                    break;
                case 1:
                    rej2 = Bx;
                    w = labelB;
                    break;
                case 2:
                    rej2 = Cx;
                    w = labelC;
                    break;
                case 3:
                    rej2 = Dx;
                    w = labelD;
                    break;
            }

            string rozkaz = (string)comboBox1.SelectedItem;
            if (rozkaz.Equals("ADD")) ADD(rej1, rej2,w);
            if (rozkaz.Equals("SUB")) SUB(rej1, rej2,w);
            if (rozkaz.Equals("MOV")) MOV(rej1, rej2,w);          
        }

        private void buttonSaveInORDERS(object sender, EventArgs e)
        {
            string operacje = (string)comboBox2.SelectedItem + " " + (string)comboBox1.SelectedItem + " " + (string)comboBox3.SelectedItem;
            labelOp.Text += operacje + ";" + "\r\n" ;
        }

        private void buttonExecuteAllOrders(object sender, EventArgs e)
        {
            Label w = null;
            string pol1 = null;
            string pol2 = null;
    
            Ax = labelA.Text;
            Bx = labelB.Text;
            Cx = labelC.Text;
            Dx = labelD.Text;
            string zawartosc = labelOp.Text;
            string[] label = zawartosc.Split(';');
            foreach(string i in label)
            {
                Ax = labelA.Text;
                Bx = labelB.Text;
                Cx = labelC.Text;
                Dx = labelD.Text;

                string[] polecenia = i.Split(' ');
                
                if (polecenia.Length == 3)
                {
                    if (polecenia[0].Equals("Ax")) pol1 = Ax;
                    else if (polecenia[0].Equals("Bx")) pol1 = Bx;
                    else if (polecenia[0].Equals("Cx")) pol1 = Cx;
                    else if (polecenia[0].Equals("Dx")) pol1 = Dx;

                    if (polecenia[2].Equals("Ax"))
                    {
                        pol2 = Ax;
                        w = labelA;
                    }
                    else if (polecenia[2].Equals("Bx"))
                    {
                        pol2 = Bx;
                        w = labelB;
                    }
                    else if (polecenia[2].Equals("Cx"))
                    {
                        pol2 = Cx;
                        w = labelC;
                    }
                    else if (polecenia[2].Equals("Dx"))
                    {
                        pol2 = Dx;
                        w = labelD;
                    }

                    if (polecenia[1].Equals("ADD")) ADD(pol1, pol2, w);
                    if (polecenia[1].Equals("SUB")) SUB(pol1, pol2, w);
                    if (polecenia[1].Equals("MOV")) MOV(pol1, pol2, w);
                    Console.WriteLine("pol1 = " + pol1 + "  pol2 = " + pol2);

                }
            }
        }
        private void buttonStepByStep(object sender, EventArgs e)
        {
            labelNrRozkazu.Text = increment.ToString();
            krok(increment);
            increment = increment + 1;
        }

        
        private void buttonSaveInFile(object sender, EventArgs e)
        {
            string zawartosc = labelOp.Text;
            System.IO.File.WriteAllText(@"C:\Users\alicj\source\repos\Mikroprocesor\zawProgramu.txt", zawartosc);
        }

        private void buttonLoadOrders(object sender, EventArgs e)
        {
            string zawartosc = System.IO.File.ReadAllText(@"C:\Users\alicj\source\repos\Mikroprocesor\zawProgramu.txt");
            labelOp.Text = zawartosc;
            
        }

        private void buttonCLR(object sender, EventArgs e)
        {
            labelOp.Text = "";
        }

     
    }
}
