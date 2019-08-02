using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ArrayMethods
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            //Icerigine sizin karar vereceginiz bir sayisal dizi olusturun ve bu dizinin en kucuk - en buyuk elemanını MessageBox'la gosterin..

            int[] dizi = { 53, 765, 2165, 8, 321, 65, 851, 876, 98, 34276, 453 };
            int buyuk = 0;
            int kucuk = 0;
            Array.Sort(dizi);
            kucuk = dizi[0];
            buyuk = dizi[dizi.Length - 1]; 
            MessageBox.Show($"Dizinin en küçük elemanı : {kucuk}\nDizinin en büyük elemanı : {buyuk}");
        }

        string[] kayitlar = new string[0];

        private void btnElemanEkle_Click(object sender, EventArgs e)
        {
            //Textbox'tan girilen veri "kayitlar" adli diziye eklesin. Her yeni kayıtta dizinin boyutu bir arttırılsın... Eleman ekledikten hemen sonra ise asagidaki formatta kayit listbox'ta gosterilsin..
            //FORMAT => Eleman - ElemaninIndexi
            //FORMAT => ElemaninIndexi - Eleman

            string veri = txtGirisAlani.Text;
            Array.Resize(ref kayitlar, kayitlar.Length + 1);
            kayitlar[kayitlar.Length - 1] = veri;

            lstKayitliElemanlar.Items.Add($"{kayitlar.Length - 1} - {kayitlar[kayitlar.Length - 1]}");
        }
    }
}
