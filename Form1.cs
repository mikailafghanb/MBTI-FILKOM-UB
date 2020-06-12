using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP_MBTI
{
    public partial class Tes_MBTI : Form
    {
        public Tes_MBTI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void label45_Click(object sender, EventArgs e)
        {

        }

        public double sumIntrovert()
        {
            //textBox6.Text = Convert.ToString(sumDetik() / 60);
            //(2B + 5A + 7A + 10B + 11B + 15B + 20B + 28A + 29B + 31B + 35A + 38B + 45A + 52A + 60A)/15
            int x1 = Convert.ToInt32(textBox2.Text); //
            int x2 = Convert.ToInt32(textBox71.Text); //
            int x3 = Convert.ToInt32(textBox69.Text); //
            int x4 = Convert.ToInt32(textBox10.Text); //
            int x5 = Convert.ToInt32(textBox11.Text); //
            int x6 = Convert.ToInt32(textBox15.Text); //
            int x7 = Convert.ToInt32(textBox20.Text); //
            int x8 = Convert.ToInt32(textBox28.Text); //
            int x9 = Convert.ToInt32(textBox29.Text); //
            int x10 = Convert.ToInt32(textBox60.Text); //
            int x11 = Convert.ToInt32(textBox101.Text); //
            int x12 = Convert.ToInt32(textBox53.Text); //
            int x13 = Convert.ToInt32(textBox91.Text); //
            int x14 = Convert.ToInt32(textBox114.Text); //
            int x15 = Convert.ToInt32(textBox106.Text); //
            int sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15;
            return sum;
        }

        public double sumEkstrovert()
        {
            //textBox6.Text = Convert.ToString(sumDetik() / 60);
            //(2A + 5B + 7B+ 10A + 11A + 15A + 20A + 28B + 29A + 31A + 35B + 38A + 45B + 52B + 60B)/15
            int x1 = Convert.ToInt32(textBox74.Text);
            int x2 = Convert.ToInt32(textBox5.Text);
            int x3 = Convert.ToInt32(textBox7.Text);
            int x4 = Convert.ToInt32(textBox66.Text);
            int x5 = Convert.ToInt32(textBox5.Text);
            int x6 = Convert.ToInt32(textBox61.Text);
            int x7 = Convert.ToInt32(textBox86.Text);
            int x8 = Convert.ToInt32(textBox78.Text);
            int x9 = Convert.ToInt32(textBox77.Text);
            int x10 = Convert.ToInt32(textBox105.Text);
            int x11 = Convert.ToInt32(textBox56.Text);
            int x12 = Convert.ToInt32(textBox98.Text);
            int x13 = Convert.ToInt32(textBox46.Text);
            int x14 = Convert.ToInt32(textBox37.Text);
            int x15 = Convert.ToInt32(textBox45.Text);
            int sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15;
            return sum;
        }

        public double sumSensing()
        {
            //textBox6.Text = Convert.ToString(sumDetik() / 60);
            //(6B + 8A + 13A + 16A + 18B + 22B + 25A + 27A + 34A + 36A + 41A + 43A + 46A +  51A + 53A)/15
            int x1 = Convert.ToInt32(textBox6.Text);
            int x2 = Convert.ToInt32(textBox68.Text);
            int x3 = Convert.ToInt32(textBox63.Text);
            int x4 = Convert.ToInt32(textBox90.Text);
            int x5 = Convert.ToInt32(textBox18.Text);
            int x6 = Convert.ToInt32(textBox22.Text);
            int x7 = Convert.ToInt32(textBox81.Text);
            int x8 = Convert.ToInt32(textBox79.Text);
            int x9 = Convert.ToInt32(textBox102.Text);
            int x10 = Convert.ToInt32(textBox100.Text);
            int x11 = Convert.ToInt32(textBox95.Text);
            int x12 = Convert.ToInt32(textBox93.Text);
            int x13 = Convert.ToInt32(textBox120.Text);
            int x14 = Convert.ToInt32(textBox115.Text);
            int x15 = Convert.ToInt32(textBox113.Text);
            int sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15;
            return sum;
        }

        public double sumIntuition()
        {
            //textBox6.Text = Convert.ToString(sumDetik() / 60);
            //(6A + 8B + 13B + 16B + 18A + 22A + 25B + 27B + 34B + 36B + 41B + 43B + 46B +51B	+ 53B)/15
            int x1 = Convert.ToInt32(textBox70.Text);
            int x2 = Convert.ToInt32(textBox8.Text);
            int x3 = Convert.ToInt32(textBox13.Text);
            int x4 = Convert.ToInt32(textBox16.Text);
            int x5 = Convert.ToInt32(textBox88.Text);
            int x6 = Convert.ToInt32(textBox84.Text);
            int x7 = Convert.ToInt32(textBox25.Text);
            int x8 = Convert.ToInt32(textBox27.Text);
            int x9 = Convert.ToInt32(textBox57.Text);
            int x10 = Convert.ToInt32(textBox55.Text);
            int x11 = Convert.ToInt32(textBox50.Text);
            int x12 = Convert.ToInt32(textBox48.Text);
            int x13 = Convert.ToInt32(textBox31.Text);
            int x14 = Convert.ToInt32(textBox36.Text);
            int x15 = Convert.ToInt32(textBox38.Text);
            int sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15;
            return sum;
        }

        public double sumThinking()
        {
            //textBox6.Text = Convert.ToString(sumDetik() / 60);
            //(4A + 9B + 41A + 17A + 23A + 30A + 32B + 37A + 39B + 42A + 48A + 49B + 55A + 57A + 58A)/15
            int x1 = Convert.ToInt32(textBox72.Text);
            int x2 = Convert.ToInt32(textBox9.Text);
            int x3 = Convert.ToInt32(textBox95.Text);
            int x4 = Convert.ToInt32(textBox89.Text);
            int x5 = Convert.ToInt32(textBox83.Text);
            int x6 = Convert.ToInt32(textBox76.Text);
            int x7 = Convert.ToInt32(textBox104.Text);
            int x8 = Convert.ToInt32(textBox99.Text);
            int x9 = Convert.ToInt32(textBox97.Text);
            int x10 = Convert.ToInt32(textBox94.Text);
            int x11 = Convert.ToInt32(textBox118.Text);
            int x12 = Convert.ToInt32(textBox34.Text);
            int x13 = Convert.ToInt32(textBox111.Text);
            int x14 = Convert.ToInt32(textBox109.Text);
            int x15 = Convert.ToInt32(textBox108.Text);
            int sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15;
            return sum;
        }

        public double sumFeeling()
        {
            //textBox6.Text = Convert.ToString(sumDetik() / 60);
            //(4B + 9A + 41B + 17B + 23B + 30B + 32A + 37B + 39A + 42B + 48B + 49A + 55B + 57B + 58B)/ 15
            int x1 = Convert.ToInt32(textBox4.Text);
            int x2 = Convert.ToInt32(textBox67.Text);
            int x3 = Convert.ToInt32(textBox50.Text);
            int x4 = Convert.ToInt32(textBox17.Text);
            int x5 = Convert.ToInt32(textBox23.Text);
            int x6 = Convert.ToInt32(textBox30.Text);
            int x7 = Convert.ToInt32(textBox59.Text);
            int x8 = Convert.ToInt32(textBox54.Text);
            int x9 = Convert.ToInt32(textBox52.Text);
            int x10 = Convert.ToInt32(textBox49.Text);
            int x11 = Convert.ToInt32(textBox33.Text);
            int x12 = Convert.ToInt32(textBox117.Text);
            int x13 = Convert.ToInt32(textBox40.Text);
            int x14 = Convert.ToInt32(textBox42.Text);
            int x15 = Convert.ToInt32(textBox43.Text);
            int sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15;
            return sum;
        }

        public double sumJudging()
        {
            //textBox6.Text = Convert.ToString(sumDetik() / 60);
            //( 1B + 3A + 12B + 19A + 21B + 24A + 26B + 33B + 40B + 44B + 47A + 50B + 54A + 56A + 59B)/15
            int x1 = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int x3 = Convert.ToInt32(textBox12.Text);
            int x4 = Convert.ToInt32(textBox87.Text);
            int x5 = Convert.ToInt32(textBox21.Text);
            int x6 = Convert.ToInt32(textBox82.Text);
            int x7 = Convert.ToInt32(textBox26.Text);
            int x8 = Convert.ToInt32(textBox58.Text);
            int x9 = Convert.ToInt32(textBox51.Text);
            int x10 = Convert.ToInt32(textBox47.Text);
            int x11 = Convert.ToInt32(textBox119.Text);
            int x12 = Convert.ToInt32(textBox35.Text);
            int x13 = Convert.ToInt32(textBox112.Text);
            int x14 = Convert.ToInt32(textBox110.Text);
            int x15 = Convert.ToInt32(textBox44.Text);
            int sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15;
            return sum;
        }

        public double sumPerceiving()
        {
            //textBox6.Text = Convert.ToString(sumDetik() / 60);
            //(1A + 3B + 12A + 19B + 21A + 24B + 26A + 33A + 40A + 44A + 47B + 50A + 54B + 56B + 59A)/15
            int x1 = Convert.ToInt32(textBox75.Text);
            int x2 = Convert.ToInt32(textBox73.Text);
            int x3 = Convert.ToInt32(textBox64.Text);
            int x4 = Convert.ToInt32(textBox19.Text);
            int x5 = Convert.ToInt32(textBox85.Text);
            int x6 = Convert.ToInt32(textBox24.Text);
            int x7 = Convert.ToInt32(textBox80.Text);
            int x8 = Convert.ToInt32(textBox103.Text);
            int x9 = Convert.ToInt32(textBox96.Text);
            int x10 = Convert.ToInt32(textBox92.Text);
            int x11 = Convert.ToInt32(textBox32.Text);
            int x12 = Convert.ToInt32(textBox116.Text);
            int x13 = Convert.ToInt32(textBox39.Text);
            int x14 = Convert.ToInt32(textBox41.Text);
            int x15 = Convert.ToInt32(textBox107.Text);
            int sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15;
            return sum;
        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {
            textBox121.Text = Convert.ToString(sumIntrovert() / 15);
        }

        private void textBox122_TextChanged(object sender, EventArgs e)
        {
            textBox122.Text = Convert.ToString(sumEkstrovert() / 15);
        }

        private void textBox123_TextChanged(object sender, EventArgs e)
        {
            textBox123.Text = Convert.ToString(sumSensing() / 15);
        }

        private void textBox124_TextChanged(object sender, EventArgs e)
        {
            textBox124.Text = Convert.ToString(sumIntuition() / 15);
        }

        private void textBox125_TextChanged(object sender, EventArgs e)
        {
            textBox125.Text = Convert.ToString(sumThinking() / 15);
        }

        private void textBox126_TextChanged(object sender, EventArgs e)
        {
            textBox126.Text = Convert.ToString(sumFeeling() / 15);
        }

        private void textBox127_TextChanged(object sender, EventArgs e)
        {
            textBox127.Text = Convert.ToString(sumJudging() / 15);
        }

        private void textBox128_TextChanged(object sender, EventArgs e)
        {
            textBox128.Text = Convert.ToString(sumPerceiving() / 15);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cari nilai difat dasar
            textBox121.Text = Convert.ToString(sumIntrovert() / 15);
            textBox122.Text = Convert.ToString(sumEkstrovert() / 15);
            textBox123.Text = Convert.ToString(sumSensing() / 15);
            textBox124.Text = Convert.ToString(sumIntuition() / 15);
            textBox125.Text = Convert.ToString(sumThinking() / 15);
            textBox126.Text = Convert.ToString(sumFeeling() / 15);
            textBox127.Text = Convert.ToString(sumJudging() / 15);
            textBox128.Text = Convert.ToString(sumPerceiving() / 15);

            ////cari nilai kepribadian
            //int a = Convert.ToInt32(textBox121.Text);
            //int b = Convert.ToInt32(textBox122.Text);
            //int c = Convert.ToInt32(textBox123.Text);
            //int d = Convert.ToInt32(textBox124.Text);
            //int ek = Convert.ToInt32(textBox125.Text);
            //int f = Convert.ToInt32(textBox126.Text);
            //int g = Convert.ToInt32(textBox127.Text);
            //int h = Convert.ToInt32(textBox128.Text);

            double a = sumIntrovert() / 15;
            double b = sumEkstrovert() / 15;
            double c = sumSensing() / 15;
            double d = sumIntuition() / 15;
            double ek = sumThinking() / 15;
            double f = sumFeeling() / 15;
            double g = sumJudging() / 15;
            double h = sumPerceiving() / 15;

            String nilai_pribadi = textBox129.Text;

            //ke 1
            if ((a > b) ^ (c < d) ^ (ek < f) ^ (g > h))
            {
                textBox129.Text = "ENFJ";
                nilai_pribadi = "ENFJ";                
            }
            else if ((a > b) ^ (c < d) ^ (ek < f) ^ (g < h))
            {
                textBox129.Text = "ENFP";
                nilai_pribadi = "ENFP";
            }
            else if ((a > b) ^ (c < d) ^ (ek > f) ^ (g > h))
            {
                textBox129.Text = "ENTJ";
                nilai_pribadi = "ENTJ";
            }
            else if ((a > b) ^ (c < d) ^ (ek > f) ^ (g < h))
            {
                textBox129.Text = "ENTP";
                nilai_pribadi = "ENTP";
            }

            //ke 2
            else if ((a > b) ^ (c > d) ^ (ek < f) ^ (g > h))
            {
                textBox129.Text = "ESFJ";
                nilai_pribadi = "ESFJ";
            }
            else if ((a > b) ^ (c > d) ^ (ek < f) ^ (g < h))
            {
                textBox129.Text = "ESFP";
                nilai_pribadi = "ESFP";
            }
            else if ((a > b) ^ (c > d) ^ (ek > f) ^ (g > h))
            {
                textBox129.Text = "ESTJ";
                nilai_pribadi = "ESTJ";
            }
            else if ((a > b) ^ (c > d) ^ (ek > f) ^ (g < h))
            {
                textBox129.Text = "ESTP";
                nilai_pribadi = "ESTP";
            }

            //ke 3
            else if ((a < b) ^ (c < d) ^ (ek < f) ^ (g > h))
            {
                textBox129.Text = "INFJ";
                nilai_pribadi = "INFJ";
            }
            else if ((a < b) ^ (c < d) ^ (ek < f) ^ (g < h))
            {
                textBox129.Text = "INFP";
                nilai_pribadi = "INFP";
            }
            else if ((a < b) ^ (c < d) ^ (ek > f) ^ (g > h))
            {
                textBox129.Text = "INTJ";
                nilai_pribadi = "INTJ";
            }
            else if ((a < b) ^ (c < d) ^ (ek > f) ^ (g < h))
            {
                textBox129.Text = "INTP";
                nilai_pribadi = "INTP";
            }

            //ke 4
            else if ((a < b) ^ (c > d) ^ (ek < f) ^ (g > h))
            {
                textBox129.Text = "ISFJ";
                nilai_pribadi = "ISFJ";
            }
            else if ((a < b) ^ (c > d) ^ (ek < f) ^ (g < h))
            {
                textBox129.Text = "ISFP";
                nilai_pribadi = "ISFP";
            }
            else if ((a < b) ^ (c > d) ^ (ek > f) ^ (g > h))
            {
                textBox129.Text = "ISTJ";
                nilai_pribadi = "ISTJ";
            }
            else if ((a < b) ^ (c > d) ^ (ek > f) ^ (g < h))
            {
                textBox129.Text = "ISTP";
                nilai_pribadi = "ISTP";
            }

            //cari ciri kepribadian dan pekerjaan yang cocok
            if (nilai_pribadi == "ENFJ")
            {
                richTextBox2.Text = "Profesi : IT consultant, dosen, project leader";
            }
            else if (nilai_pribadi == "ENFP")
            {
                richTextBox2.Text = "sistem analis, dosen";
            }
            else if (nilai_pribadi == "ENTJ")
            {
                richTextBox2.Text = "director, project leader, dba";
            }
            else if (nilai_pribadi == "ENTP")
            {
                richTextBox2.Text = "developer, director, programmer, it consultant, product management";
            }
            else if (nilai_pribadi == "ESFJ")
            {
                richTextBox2.Text = "programmer, sistem maintenance, dba, dosen";
            }
            else if (nilai_pribadi == "ESFP")
            {
                richTextBox2.Text = "sistem analisis, product management";
            }
            else if (nilai_pribadi == "ESTJ")
            {
                richTextBox2.Text = "manajer, sistem analis, dosen";
            }
            else if (nilai_pribadi == "ESTP")
            {
                richTextBox2.Text = "technical support, bussiness it";
            }
            else if (nilai_pribadi == "INFJ")
            {
                richTextBox2.Text = "IT konsultan, dba, dosen";
            }
            else if (nilai_pribadi == "INFP")
            {
                richTextBox2.Text = "IT konsultan, dosen";
            }
            else if (nilai_pribadi == "INTJ")
            {
                richTextBox2.Text = "developer, sistem analis, programmer, dosen";
            }
            else if (nilai_pribadi == "INTP")
            {
                richTextBox2.Text = "director, programmer";
            }
            else if (nilai_pribadi == "ISFJ")
            {
                richTextBox2.Text = "sistem analis, dba, IT konsultan";
            }
            else if (nilai_pribadi == "ISFP")
            {
                richTextBox2.Text = "IT konsultan, dosen, programmer";
            }
            else if (nilai_pribadi == "ISTJ")
            {
                richTextBox2.Text = "directory, programmer";
            }
            else if (nilai_pribadi == "ISTP")
            {
                richTextBox2.Text = "sistem analis, programmer, IT bussiness";
            }
        }
    }
}