using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*******************************************************************************************
 **                              SAKARYA ÜNİVERSİTESİ
 **                    BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                      BİLİŞİM SİSTEMLERİ MÜHENDSİLİĞİ BÖLÜMÜ
 **                        NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                              2019/2020 BAHAR DÖNEMİ
 **                      
 **                       ÖDEV NUMARASI: 1
 **                       ÖĞRENCİ ADI: DERYA NUR ERASLAN
 **                       ÖĞRENCİ NUMARASI: B181200040
 **                       DERSİN ALINDIĞI GRUP: NDP/1.SINIFLARLA
 *******************************************************************************************/

namespace Ndp.Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int saglikkont = 0;
        int saglikkontucret = 0;
        int tahlil = 0;
        int tahlilucret = 0;
        int asi = 0;              //Değişkenler global olarak tanımlanır
        int asiucret = 0;
        int tuy = 0;
        int tuyfiyat = 0;
        int oneri = 0;
        int onerifiyat = 0;
        int tasma = 0;
        int tasmafiyat = 0;

        private void button6_Click(object sender, EventArgs e)
        {
            asi++;    //Her aşı yaptırdığında aşı sayısını bir bir arttır
            asiucret = asiucret + 90; //Her aşı yaptırdığında ücreti +90 arttır
            textBox6.Text = asi.ToString(); //Aşı sayısını textboxa yazdır
            textBox5.Text = asiucret.ToString(); //Aşı ücretini textboxa yazdır

            if (asi == 6) //Sürekli aşı yaptırılması uygun olmayacağından aşı sayısı 6 ise
            {
                button6.Enabled = false; //Daha fazla aşı butonuna basama

            }
            if (asi > 0) //Aşı yapma butonuna 0'dan fazla basıldıysa 
            {
                button5.Enabled = true; //Butonu true döndür ve butona basabil
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            asi--; //Aşı yaptırmadıysa aşı sayısını bir eksilt
            asiucret = asiucret - 90; //Aşı yaptırmadığında her yaptırmadığı kadar -90 kadar fiyat düş
            textBox6.Text = asi.ToString(); //Aşı yaptırmama sayısını textboxa yazdır
            textBox5.Text = asiucret.ToString(); //Aşı yaptırmadığı kadar ücreti textboxtan düş
            if (asi == 0) //Aşı yaptırmadığı sayı 0'sa
            {
                button5.Enabled = false; //Butona basama

            }
            if (asi < 6) //Aşı yaptırmadığı sayı 6'dan küçükse 
            {
                button6.Enabled = true; //Butona basabilsin
            }
        }
                                                                  // Aynı şekilde diğer durumlar içinde yapılır
        private void button4_Click(object sender, EventArgs e)
        {
            tahlil++;
            tahlilucret = tahlilucret + 50;
            textBox3.Text = tahlil.ToString();
            textBox4.Text = tahlilucret.ToString();

            if (tahlil == 10)
            {
                button3.Enabled = false;
            }
            if (tahlil > 0)
            {
                button4.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tahlil--;
            tahlilucret = tahlilucret - 50;
            textBox3.Text = tahlil.ToString();
            textBox4.Text = tahlilucret.ToString();
            if (tahlil == 0)
            {
                button4.Enabled = false;
            }
            if (tahlil < 10)
            {
                button3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saglikkont++;
            saglikkontucret = saglikkontucret + 35;
            textBox1.Text = saglikkont.ToString();
            textBox2.Text = saglikkontucret.ToString();

            if (saglikkont == 10)
            {
                button1.Enabled = false;

            }
            if (saglikkont > 0)
            {
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saglikkont--;
            saglikkontucret = saglikkontucret - 35;
            textBox1.Text = saglikkont.ToString();
            textBox2.Text = saglikkontucret.ToString();
            if (saglikkont == 0)
            {
                button2.Enabled = false;

            }
            if (saglikkont < 10)
            {
                button1.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tuy++;
            tuyfiyat = tuyfiyat + 40;
            textBox7.Text = tuy.ToString();
            textBox8.Text = tuyfiyat.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tuy--;
            tuyfiyat = tuyfiyat - 40;
            textBox7.Text = tuy.ToString();
            textBox8.Text = tuyfiyat.ToString() + "TL";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            oneri++;
            onerifiyat = onerifiyat + 20;
            textBox9.Text = oneri.ToString();
            textBox10.Text = onerifiyat.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            oneri--;
            onerifiyat = onerifiyat - 20;
            textBox9.Text = oneri.ToString();
            textBox10.Text = onerifiyat.ToString() + "TL";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tasma++;
            tasmafiyat = tasmafiyat + 50;
            textBox11.Text = tasma.ToString();
            textBox12.Text = tasmafiyat.ToString() + "TL";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tasma--;
            tasmafiyat = tasmafiyat - 50;
            textBox11.Text = tasma.ToString() + "TL";
            textBox12.Text = tasmafiyat.ToString() + "TL";
        }

        private void button13_Click(object sender, EventArgs e)
        { 
            int toplamislem, toplamucret; //Ana yapılan işlemlerin ve ücretlerin hesaplanması için değişkenler tanımlanır
            toplamislem = saglikkont + tahlil + asi; //Toplam yapılan işlem sayısını bulmak için işlemler toplatılır
            label9.Text = toplamislem.ToString(); //İşlemler labela yazdırılır,stringe çevrilir

            toplamucret = saglikkontucret + tahlilucret + asiucret; //Yapılan işlemlerin toplam ücreti hesaplatılır
            textBox13.Text = toplamucret.ToString() + "TL"; //Bulunan ücret textboxa yazdırılır
        }

        private void button14_Click(object sender, EventArgs e)
        {                                         //Aynı işlem extradan yapılan uygulamalar içinde uygulanır
            int toplamekislem, toplamfiyat;
            toplamekislem = tuy + oneri + tasma;
            label12.Text = toplamekislem.ToString();

            toplamfiyat = tuyfiyat + onerifiyat + tasmafiyat;
            textBox14.Text = toplamfiyat.ToString() + "TL";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int geneltoplam; //Hem ana yaptırılan hemde extradan istenilen işlemlerin total fiyatını bulmak için değişken tanımlanır 
            geneltoplam = saglikkontucret + tahlilucret + asiucret + tuyfiyat + onerifiyat + tasmafiyat; //Fiyatlar toplanır
            textBox15.Text = geneltoplam.ToString() + "TL"; //Total fiyat textboxa yazdırılır
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "PET-SHOP FİYATLANDIRMA SİSTEMİ"; //Sistemin başlığı yazdırılır
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int genelislem;
            genelislem = asi + tahlil + saglikkont + tuy + oneri + tasma;
            label18.Text = genelislem.ToString();
        }
    }
}

