using System;
using System.Windows.Forms;

namespace WFA_ArrayMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ARRAY SINIFI (CLASS)
        // Su ana dek gormus oldugumuz ilkel diziler, bize uzerinde cok fazla islem yapma olanagi saglamamaktadir. Eger dizinizi yeniden boyutlandirmak, temizlemek, siralamak, tersine cevirmek gibi temel islemler yapmak istiyorsaniz, Array sınıfı size yardimci olacaktir...


        string[] ornekDizi = {
            "İstanbul",   // 0
            "Ankara",     // 1
            "İzmir",      // 2
            "Bursa",      // 3
            "Eskişehir",  // 4
            "Konya",      // 5
            "Trabzon",    // 6
            "Sivas",      // 7
            "Eskişehir"   // 8
        };


        #region Clear
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // .Clear() => Dizi içerisinden bir(den fazla) eleman silmek için kullanılır.
            System.Array.Clear(ornekDizi, 0, 3);
            Array.Clear(ornekDizi, 0, ornekDizi.Length); // Dizinin tüm elemanlarını temizler

            // 1. Parametre : Hangi dizi ?
            // 2. Parametre : Kaçıncı Index değerinden başlayacağım ?
            // 3. Parametre : Kaç eleman sileceğim ? 
        }

        #endregion

        #region Copy
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            string[] kopyaDizi = new string[5];
            Array.Copy(ornekDizi, kopyaDizi, 5);

            // 1. ve 2. Overload (aralarındaki fark, 1. overload int , 2. overload long tipinde sayısal değer ister)
            // 1. Parametre : Kaynak dizi (verilerin alınacağı dizi)
            // 2. Parametre : Hedef dizi  (verilerin kopyalanacağı dizi)
            // 3. Parametre : Kopyalanacak eleman sayısı (0. index değerinden başlayarak verilen sayı kadar kopyalar)

            string[] copyArray = new string[5];
            Array.Copy(ornekDizi, 4, copyArray, 2, 2);

            // 3. ve 4. OverLoad

            // 1. Parametre : Kaynak dizi (veriler hangi diziden gelecek ?)
            // 2. Parametre : Kaynak dizinin, hangi index değerinden eleman kopyalama işlemine başlanacak ? 
            // 3. Parametre : Hedef dizi, veriler hangi diziye kopyalanacak ? 
            // 4. Parametre : Hedef dizinin, hangi index değerinden kopyala işlemine başlanacak ?
            // 5. Parametre : Kaynak diziden kaç eleman, hedef diziye kopyalanacak

        }
        #endregion

        #region IndexOf
        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // IndexOf() => dizi içerisinde eğer aradığınız eleman var ise size o elemanın index değerini, yok ise -1 değerini teslim eder. 
            // dizi içerisinde eğer eleman birden fazla ise, bulduğu ilk elemanın index değerini teslim eder. NOT : Okuma işlemin soldan sağa doğru gerçekleştirir.

            int index = Array.IndexOf(ornekDizi, "Eskişehir");

            //MessageBox.Show("Aradığınız Nesnenin Dizi İçerisindeki Index Numarası : " + index);
            //MessageBox.Show(string.Format("Aradığınız Nesnenin Dizi İçerisindeki Index Numarası : {0}", index));
            MessageBox.Show($"Aradığınız Nesnenin Dizi İçerisindeki Index Numarası : {index}");

            // 1. Parametre : Kaynak Dizi
            // 2. Parametre : Aranalıcak olan eleman (dizinin veri tipi ne ise, 2. parametrede o veri tipinde değer veriniz!)

            index = Array.IndexOf(ornekDizi, "Eskişehir", 5);
            MessageBox.Show($"Aradığınız Nesnenin Dizi İçerisindeki Index Numarası : {index}");

            // 1. Parametre : Kaynak Dizi
            // 2. Parametre : Aranalıcak olan eleman (dizinin veri tipi ne ise, 2. parametrede o veri tipinde değer veriniz!)
            // 3. Parametre : Arama işlemine kaynak dizinin kaçıncı index değerinden başlayacak ?

            index = Array.IndexOf(ornekDizi, "Eskişehir", 5, 3);
            MessageBox.Show($"Aradığınız Nesnenin Dizi İçerisindeki Index Numarası : {index}");

            // 1. Parametre : Kaynak Dizi
            // 2. Parametre : Aranalıcak olan eleman (dizinin veri tipi ne ise, 2. parametrede o veri tipinde değer veriniz!)
            // 3. Parametre : Arama işlemine kaynak dizinin kaçıncı index değerinden başlayacak ?
            // 4. Parametre : Toplamda dizi içerisinde kaç eleman içerisinde arama yapılacak ?

        }
        #endregion

        #region LastIndexOf
        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // LastIndexOf() => dizi içerisinde eğer aradığınız eleman var ise size o elemanın index değerini, yok ise -1 değerini teslim eder. 
            // dizi içerisinde eğer eleman birden fazla ise, bulduğu son elemanın index değerini teslim eder.  

            int index = Array.LastIndexOf(ornekDizi, "Eskişehir");
            MessageBox.Show($"Aradığınız Nesnenin Dizi İçerisindeki Index Numarası : {index}");

            // dizi içerisinde parametrede(textbox) verdiğiniz eleman birden fazla geçip geçmediğini kullanıcıya gösteriniz!

            if (Array.IndexOf(ornekDizi, txtGelenDeger.Text) == Array.LastIndexOf(ornekDizi, txtGelenDeger.Text))
            {
                MessageBox.Show("Dizi içerisinde aradığınız eleman bir adet içerimektedir");
            }
            else
            {
                MessageBox.Show("Dizi içerisinde aradığınız eleman birden fazla içermektedir.");
            }


            // dizi içerisinde parametrede verilen elemanın, kaç adet olduğunu kullanıcıya mb içerisinde gösteriniz :)


            string deger = txtGelenDeger.Text;
            int counter = 0;

            for (int i = 0; i < ornekDizi.Length; i++)
            {
                if (ornekDizi[i] == deger)
                {
                    counter++;
                }
            }
            MessageBox.Show($"Dizi içerisinde aradığınız eleman {counter} adet içerimektedir");



            string[] sehirler = {
            "İstanbul",   // 0
            "Ankara",     // 1
            "İzmir",      // 2
            "Bursa",      // 3
            "Eskişehir",  // 4
            "Konya",      // 5
            "Trabzon",    // 6
            "Sivas",      // 7
            "Eskişehir",  // 8
            "İstanbul",   // 9
            "Ankara",     // 10
            "İzmir",      // 11
            "Bursa",      // 12
            "Eskişehir",  // 13
            "Konya",      // 14
            "Trabzon",    // 15
            "Sivas",      // 16
            "Eskişehir"   // 17
        };


            int _index = 0;
            counter = 0;
            while (_index != sehirler.Length - 1)
            {
                if (_index != 0 && _index != -1) { _index++; }

                _index = Array.IndexOf(sehirler, deger, _index);
                if (_index != -1)
                {
                    counter++;
                }
            }
            MessageBox.Show($"Dizi içerisinde aradığınız eleman {counter} adet içerimektedir");

        }
        #endregion

        private void btnResize_Click(object sender, EventArgs e)
        {
            //Array.Resize() => dizinin yeniden boyutlandırmak için kullanırız!

            Array.Resize(ref ornekDizi, 100);
            Array.Resize<string>(ref ornekDizi, 100);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Array.Sort() => dizi içerisinde yer alan elemanları A'dan Z'ye - 0'dan 9'a sıralama işlemi yapar.

            Array.Sort(ornekDizi);
            // Sort(Array array, IComparer comparer);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {

            //Array.Reverse() => Diziyi herhangi bir sıralama yapmadan, tesrine çevirir.
            Array.Sort(ornekDizi);
            Array.Reverse(ornekDizi);

            MessageBox.Show(string.Join(" - ",ornekDizi));
        }
    }
}
