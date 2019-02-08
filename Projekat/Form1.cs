using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Form1 : Form
    {
        Motor m1 = new Motor();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            radioButton16.Enabled = false;
            radioButton24.Enabled = false;
            radioButton23.Enabled = false;
            radioButton22.Enabled = false;
            radioButton19.Enabled = false;
            radioButton18.Enabled = false;
            radioButton17.Enabled = false;
            radioButton40.Enabled = false;
            radioButton39.Enabled = false;
            radioButton38.Enabled = false;
            radioButton37.Enabled = false;
            radioButton36.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            radioButton9.Enabled = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.Enabled = false;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            radioButton14.Enabled = false;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            radioButton15.Enabled = false;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            radioButton16.Enabled = false;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            radioButton24.Enabled = false;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            radioButton23.Enabled = false;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            radioButton22.Enabled = false;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            radioButton19.Enabled = false;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            radioButton18.Enabled = false;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            radioButton17.Enabled = false;
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            radioButton40.Enabled = false;
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            radioButton39.Enabled = false;
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            radioButton38.Enabled = false;
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            radioButton37.Enabled = false;
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            radioButton36.Enabled = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                radioButton11.Enabled = true;
                radioButton12.Enabled = true;
                m1.VrstaGoriva = radioButton7.Text;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            m1.TipMotora = radioButton13.Text;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton8.Checked == true)
            {
                radioButton11.Enabled = false;
                radioButton12.Enabled = false;
                m1.VrstaGoriva = radioButton8.Text;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            m1.TipMotora = radioButton11.Text;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            m1.TipMotora = radioButton12.Text;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton25.Checked == true)
            {
                radioButton21.Enabled = false;
                m1.VrstaGoriva = radioButton25.Text;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            m1.TipMotora = radioButton21.Text;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton26.Checked == true)
            {
                radioButton21.Enabled = true;
                m1.VrstaGoriva = radioButton26.Text;
            }
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton42.Checked == true)
            {
                radioButton34.Enabled = false;
                radioButton33.Enabled = false;
                radioButton35.Enabled = true;
                m1.VrstaGoriva = radioButton42.Text;
            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            m1.TipMotora = radioButton34.Text;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            m1.TipMotora = radioButton33.Text;
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton41.Checked == true)
            {
                radioButton34.Enabled = true;
                radioButton33.Enabled = true;
                radioButton35.Enabled = false;
                m1.VrstaGoriva = radioButton41.Text;
            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            m1.TipMotora = radioButton35.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boja kola je: " + m1.BojaKola + " | " + "Vrsta goriva je: " + m1.VrstaGoriva + " | " + "Tip motora je: " + m1.TipMotora + " | " + "Kubikaža je: " + m1.NMKubikaza() + " | " + "Tip menjača je: " + m1.NMMenjac() + " | " + "Aerodinamika je: " + m1.NCPerformanse(1) + " | " + "Maksimalna brzina je: " + m1.NMPerformanse(2) + "km/h | " + "Emisije CO2 su: " + m1.NMPotrosnjaGorivaIEmisije(1) + " | " + "Gradska vožnja je: " + m1.NMPotrosnjaGorivaIEmisije(2) + " | " + "Vangradska vožnja je: " + m1.NMPotrosnjaGorivaIEmisije(3) + " | " + "Mešovita vožnja je: " + m1.NMPotrosnjaGorivaIEmisije(4));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Od vrste goriva i tipa motora zavisi kubikaža, tip menjača, performanse, potrošnja goriva i emisije.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Od vrste goriva i tipa motora zavisi kubikaža, tip menjača, performanse, potrošnja goriva i emisije.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Od vrste goriva i tipa motora zavisi kubikaža, tip menjača, performanse, potrošnja goriva i emisije.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boja kola je: " + m1.BojaKola + " | " + "Vrsta goriva je: " + m1.VrstaGoriva + " | " + "Tip motora je: " + m1.TipMotora + " | " + "Kubikaža je: " + m1.NCKubikaza() + " | " + "Tip menjača je: " + m1.NCMenjac() + " | " + "Aerodinamika je: " + m1.NCPerformanse(1) + " | " + "Maksimalna brzina je: " + m1.NCPerformanse(2) + "km/h | " + "Emisije CO2 su: " + m1.NCPotrosnjaGorivaIEmisije(1) + " | " + "Gradska vožnja je: " + m1.NCPotrosnjaGorivaIEmisije(2) + " | " + "Vangradska vožnja je: " + m1.NCPotrosnjaGorivaIEmisije(3) + " | " + "Mešovita vožnja je: " + m1.NCPotrosnjaGorivaIEmisije(4));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton4.Text;
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = Bela1.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton5.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boja kola je: " + m1.BojaKola + " | " + "Vrsta goriva je: " + m1.VrstaGoriva + " | " + "Tip motora je: " + m1.TipMotora + " | " + "Kubikaža je: " + m1.CKubikaza() + " | " + "Tip menjača je: " + m1.CMenjac() + " | " + "Maksimalna brzina je: " + m1.CPerformanse() + "km/h | " + "Emisije CO2 su: " + m1.CPotrosnjaGorivaIEmisije(1) + " | " + "Gradska vožnja je: " + m1.CPotrosnjaGorivaIEmisije(2) + " | " + "Vangradska vožnja je: " + m1.CPotrosnjaGorivaIEmisije(3) + " | " + "Mešovita vožnja je: " + m1.CPotrosnjaGorivaIEmisije(4));
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton32.Text;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton31.Text;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton30.Text;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton29.Text;
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton28.Text;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton27.Text;
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton50.Text;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            m1.TipMotora = radioButton20.Text;
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton48.Text;
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton47.Text;
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton46.Text;
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton45.Text;
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton44.Text;
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton43.Text;
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            m1.BojaKola = radioButton51.Text;
        }
    }
}
