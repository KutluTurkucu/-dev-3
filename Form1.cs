using System;

using System.Windows.Forms;

namespace Ödev_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      void temizle()//hatalar için kullancağım bazı alanlardaki verileri temizlemek için
        {
            textBox1.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }
       public static int faktoriyel(int sayi)//Faktoriyeli recursivi olarak bulan paremetre alan geriye değer dödürene metod
        {
            if (sayi <= 1)
            {
                return 1;
            }
            else
            {
                return sayi*faktoriyel(sayi - 1);
            }
        }
        void asal(int sayi)//asal sayıyı bulacak geriye değer döndürmeyen paremetreli metod
        {
           
            int sayac = 0;
            for(int i = 2; i <= sayi/2; i++)//2'ye bölme sebebim bölmenin tanımından geliyor
            {
                if (sayi % i==0) {
                sayac++;
                    break;//bir tane bile varsa direkt çıkacak böylece zaman kaybetmeyecek
                }
            }
            if(sayac!=0||sayi == 1 || sayi == 0)// 1 ile 0'ı ayrıyetten belirtmek zorunda kaldım
            {
                label7.Text ="Asal Değil";
            }
            else
            {
                label7.Text = "Asal";
            }
            

        }
        void sıralama(int sayi)// sıralamak için  geriye değer döndürmeyen paremetreli metod
        {
            label8.Text = "";
            for(int i = 1; i < sayi; i++)
            {
                label8.Text +=  i+"-" ;//ekleyerek label'i yazacak en sonda da '-' olacak onun çözümünü iki satır aşağıda
            }
            label8.Text += sayi;//sayının en sonunda '-' işareti geliyordu o sorunu bu şekil çözebildim substring denedim ama olmadı


        }
        private void button1_Click(object sender, EventArgs e)
        {
            int girdi;
            try
            {

                girdi = int.Parse(textBox1.Text);//kullanıcadan değer aldık
               //Bulmak istediğimiz mat işlemleri için kullanıcan aldığımız değerleri metodlara gönderiyoruz
                if (girdi >= 0)// asal sayı ve faktoriyel negatif sayılarda olmadığı için negatif sayılarda işlem yapamayız
                {
                    label6.Text = faktoriyel(girdi).ToString();
                    asal(girdi);
                    sıralama(girdi);
                }
                else
                {
                    MessageBox.Show("Girilen sayı negatif olamaz");
                    temizle();
                }
            }
            catch (FormatException)//Eğer sayı yerine karekter girerse bu hatayı verecek bu yüzden bir sıkıntı yaşamayacağız
            {
                MessageBox.Show("Lütfen Alana Sayısal Değer giriniz");
                temizle();
            }

            textBox1.Focus();//Devamlı maouse kullanmamak için direkt textbox!a odaklayacak
        }
    }
}
