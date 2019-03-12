/****************************************************************************************
 * Program veriler.txt dosyasına X,Y ve Z katarları icin rastgele sayi atiyor ve her katar farklı renk oluyor.
 * Textbox dan girilen degerler ile "Fark=sqrt((Xi-Xyeni)^2+(Yi-Yyeni)^2)" formulune gore her satırın fark 
 * degeri hesaplanıyor ve bu fark degerleri richtextbox da küçükten büyüğe sıralanıyor.
 *********************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosyaOkumaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try//try cath ile oluşabilecek hataları yakalıyoruz
            {
                StreamReader dosya = File.OpenText("veriler.txt");//veriler txt dosyaysını okuyor
                dosya.Close();//dosyayı kapatıyor eğer kapatmazsak "şuan işlem yapıldığından dosya kullanılamıyor"gibi bir hata ile karşılaşabiliriz
            }
            catch (Exception)//dosyayı okumadığı takdirde buraya giriyor ve yeni bir dosya yaratıyor
            {
                StreamWriter dosya = File.CreateText("veriler.txt"); //StreamWriter sınıfı ile metin dosyalarına karakter türünde değer girişi yapılmaktadır.
                dosya.Close();
            }
        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            #region dosyaya ekleme
            StreamReader sr = new StreamReader("veriler.txt"); //"veriler.txt" dosyasındaki verileri okuyor
            string metini = sr.ReadLine();  //okuduğunu metini adlı string diziye atıyor
            if (metini == null)//dosyada 5 satır istediği için eğer içinde değer yoksa yaz diyoruz
            {
                sr.Close();//eğer dosyayı kapatmazsak çslışsn doya zerinde işlem yapamazsın gibi bir hatayla karşılaşıyoruz
                StreamWriter Dosya = File.AppendText("veriler.txt");//AppendText var olan dosyaya ekleme yapar.
                Random rastgele = new Random(); //rastgele sayı oluşturup rastgele değişkenine atıyoruz
                int[] sayıX = new int[5]; //integer bir dizi oluşturduk
                for (int i = 0; i < 5; i++)//dosyada 5 satır istediği için 5 tane X değeri olan bir dizi yaptık
                {
                    sayıX[i] = rastgele.Next(500, 999);
                }
                int[] sayıY = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    sayıY[i] = rastgele.Next(500, 999);
                }
                int[] sayıZ = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    sayıZ[i] = rastgele.Next(1, 3);
                }

                for (int i = 0; i < 5; i++) //5 satır alt alta ekleme yapıyor dosyaya
                {
                    Dosya.WriteLine("X:" + sayıX[i] + ";" + "Y:" + sayıY[i] + ";" + "Z:" + sayıZ[i] + ";");
                }
                Dosya.Close(); //dosyayı kapatıyoruz
            }
            #endregion
            string X = "";
            string Y = "";
            string Z = "";
            int kelime = 0; //kelime sayısı arttıkça buda artıcak
            richTextBox1.Clear();  //richtextbox içini temizler
            StreamReader SR = new StreamReader("veriler.txt"); //"veriler.txt" dosyasındaki verileri okuyor
            string metin = SR.ReadLine();  //okuduğunu metin adlı string diziye atıyor
            int indis = 0;
            int satır = 1;  // satır sayısı arttıkça buda artıcak
            while (metin != null)  //metin dizisinin içi boş değilse bu işlemleri yapmalı
            {
                #region metin dizisini farklı dizilere atama
                for (int i = 0; i < metin.Length; i++)
                {
                    if (metin[i] != ':' && metin[i] != ';' && kelime == 1)//kelime 1 den başlıyor çünkü ilk karakter X
                    {
                        X += metin[i];//metin dizisinin X katarına denk gelen kısmını X dizisine atıyor hangisinin X olduğunu ":" ve";" sayesinde anlıyor
                    }
                    if (metin[i] == ':' || metin[i] == ';')
                    {
                        kelime++;
                    }
                    if (kelime == 2)
                    {
                        break;// işlemimizi tamamlayınca döngüden çıksın döngü boşuna devam etmesin
                    }
                } //X
                kelime = 0;//çünkü aynı metini baştan okucak ve fazladan kelime eklemeiş oluruz sıfırlamazsak
                for (int i = 0; i < metin.Length; i++)
                {
                    if (metin[i] != ':' && metin[i] != ';' && kelime == 3)
                    {
                        Y += metin[i];//Y katarını Y dizisine atıyor
                    }
                    if (metin[i] == ':' || metin[i] == ';')
                    {
                        kelime++;
                    }
                    if (kelime == 4)
                    {
                        break;
                    }
                }  //Y
                kelime = 0;
                for (int i = 0; i < metin.Length; i++)
                {
                    if (metin[i] != ':' && metin[i] != ';' && kelime == 5)
                    {
                        Z += metin[i];//Z  katarını Z dizisine atıyor
                    }
                    if (metin[i] == ':' || metin[i] == ';')
                    {
                        kelime++;
                    }
                    if (kelime == 6)
                    {
                        break;
                    }
                }  //Z
                kelime = 0;
                #endregion// metini bu şekilde farklı dizilere atamamızın nedeni richtextbox'a istediğimiz şekilde yazdırabilmek


                #region richtextbox'a yazdırma
                if (satır <= 5)//ödevde satır sayısının 5 olması gerekiyor dediği için 5 tanesini yazdırıyor
                {
                    if (true)// her türlü bu döngüye girsin çünkü satır sayısını artırmamız gerek
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (i == 0)
                            {
                                richTextBox1.SelectionColor = Color.Green;//seçili bölgeyi yeşil yap yani X'i
                                richTextBox1.SelectedText = X;//X dizisini richtextbox'a yazdırıyor 
                            }
                            if (i == 2)
                            {
                                richTextBox1.SelectionColor = Color.Blue;
                                richTextBox1.SelectedText = " " + Y;//boşluk bırakıyor ve Y dizisini richtextbox'a yazdırıyor 
                            }
                            if (i == 4)
                            {
                                richTextBox1.SelectionColor = Color.Red;
                                richTextBox1.SelectedText = " " + Z;//boşluk bırakıyor ve Z dizisini richtextbox'a yazdırıyor 
                            }

                        }



                        indis++;
                        satır++; //ilk satırı yazdırma işlemi bittikten sonra satır satırımızı bir artırıyor
                    }
                }

                #endregion




                metin = SR.ReadLine(); // metnimizi tekrar  atıyor
                X = "";//X dizimizin içini boşaltmış oluyoruz
                Y = "";//Y dizimizin içini boşaltmış oluyoruz
                Z = "";//Z dizimizin içini boşaltmış oluyoruz
                richTextBox1.SelectedText = "\n";//richtextbox ta bir alt satıra geçiyor
                kelime = 0;
            }
            SR.Close();//dosyamızı kapatıyor
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            #region hata ayıklama
            #region X
            try
            {
                if (Convert.ToInt32(textBoxX.Text) < 500 || Convert.ToInt32(textBoxX.Text) > 999)
                {
                    MessageBox.Show("X değeri 500-1000 arasinda olmali");
                    textBoxX.Text = "";
                    textBoxX.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBoxX.Text = "";
                textBoxX.Focus();
            }
            #endregion
            #region Y
            try
            {
                if (Convert.ToInt32(textBoxY.Text) < 1000 || Convert.ToInt32(textBoxY.Text) > 1499)
                {
                    MessageBox.Show("Y değeri 1000-1500 arasinda olmali");
                    textBoxX.Text = "";
                    textBoxX.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBoxY.Text = "";
                textBoxY.Focus();
            }
            #endregion
            #endregion
            #region veri tipleri

            #region ilk satırın dizi tanımlaması
            string X = " ";
            string Y = " ";
            #endregion
            #region 2. satırın dizi tanımlaması
            string X2 = " ";
            string Y2 = " ";
            #endregion
            #region 3. satırın dizi tanımlaması
            string X3 = " ";
            string Y3 = " ";
            #endregion
            #region 4. satırın dizi tanımlaması
            string X4 = " ";
            string Y4 = " ";
            #endregion
            #region 5. satırın dizi tanımlaması
            string X5 = " ";
            string Y5 = " ";
            #endregion

            string Z = " ";
            int kelime = 0;

            #endregion
            String line;
            String linee;
            try
            {
                StreamReader sr = new StreamReader("veriler.txt");//"veriler.txt" dosyasındaki verileri okuyor
                line = sr.ReadLine(); //okuduğunu line adlı string diziye atıyor

                while (line != null)
                {
                    #region ilk satırı diziye atıyor 
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 1)
                        {
                            X += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 2)
                        {
                            break;
                        }
                    } //X

                    kelime = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 3)
                        {
                            Y += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 4)
                        {
                            break;
                        }
                    }  //Y

                    kelime = 0;
                    #endregion
                    line = sr.ReadLine(); // bir sonraki(2.) satıra geçiyor ve orayı okuyor
                    #region 2.satırı diziye atıyor
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 1)
                        {
                            X2 += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 2)
                        {
                            break;
                        }
                    } //X2
                    kelime = 0;


                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 3)
                        {
                            Y2 += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 4)
                        {
                            break;
                        }
                    }  //Y2

                    kelime = 0;
                    #endregion
                    line = sr.ReadLine();//bir sonraki(3.) satıra geçiyor ve orayı okuyor
                    #region 3.satırı diziye atıyor
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 1)
                        {
                            X3 += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 2)
                        {
                            break;
                        }
                    } //X3

                    kelime = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 3)
                        {
                            Y3 += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 4)
                        {
                            break;
                        }
                    }  //Y3

                    kelime = 0;
                    #endregion
                    line = sr.ReadLine();//bir sonraki(4.)satıra geçiyor ve orayı okuyor
                    #region 4.satırı diziye atıyor

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 1)
                        {
                            X4 += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 2)
                        {
                            break;
                        }
                    } //X4

                    kelime = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 3)
                        {
                            Y4 += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 4)
                        {
                            break;
                        }
                    }  //Y4

                    kelime = 0;
                    #endregion
                    line = sr.ReadLine();//bir sonraki(5.)satıra geçiyor ve orayı okuyor
                    #region 5.satırı diziye atıyor

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 1)
                        {
                            X5 += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 2)
                        {
                            break;
                        }
                    } //X5
                    kelime = 0;

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ':' && line[i] != ';' && kelime == 3)
                        {
                            Y5 += line[i];
                        }
                        if (line[i] == ':' || line[i] == ';')
                        {
                            kelime++;
                        }
                        if (kelime == 4)
                        {
                            break;
                        }
                    }  //Y5

                    kelime = 0;
                    #endregion

                    #region Z değerleri
                    int satır = 1;
                    for (int j = 0; j < 5; j++)
                    {
                        StreamReader sır = new StreamReader("veriler.txt");//"veriler.txt" dosyasındaki verileri okuyor
                        linee = sır.ReadLine(); //okuduğunu linee adlı string diziye atıyor
                        if (satır <= 5)
                        {
                            #region ilk satırı diziye atıyor 

                            for (int i = 0; i < line.Length; i++)
                            {
                                if (line[i] != ':' && line[i] != ';' && kelime == 5)
                                {
                                    Z += line[i];
                                }
                                if (line[i] == ':' || line[i] == ';')
                                {
                                    kelime++;
                                }
                                if (kelime == 6)
                                {
                                    break;
                                }
                            }  //Z
                            kelime = 0;
                            line = sır.ReadLine(); // bir sonraki(2.) satıra geçiyor ve orayı okuyor
                            #endregion
                            satır++;

                        }
                    }
                    #endregion
                    // bütün satırlardaki Z değerini bir diziye atadım çünkü tekrar eden Z değerini bulurken daha rahat buluruz

                    double sayıX = double.Parse(textBoxX.Text);//yeni girdiğimiz X katarını sayıX'e atıyor
                    double sayıY = double.Parse(textBoxY.Text);// yeni girdiğimiz Y katarını sayıY'e atıyor
                    #region ilk satırdaki fark değeri
                    double X_1 = double.Parse(X);
                    double Y_1 = double.Parse(Y);
                    double sonuc = X_1 - sayıX;//2. satırdaki X'ten textboxtaki X'i çıkarıyor
                    double sonucc = Y_1 - sayıY;//2. satırdaki Y'den textboxtaki Y'i çıkarıyor
                    double fark = Math.Sqrt((sonuc * sonuc) + (sonucc * sonucc));
                    #endregion

                    #region 2. satırdaki fark değeri
                    double X_2 = double.Parse(X2);
                    double Y_2 = double.Parse(Y2);
                    double sonuc2 = X_2 - sayıX;//2. satırdaki X'ten textboxtaki X'i çıkarıyor
                    double sonucc2 = Y_2 - sayıY;//2. satırdaki Y'den textboxtaki Y'i çıkarıyor
                    double fark2 = Math.Sqrt((sonuc2 * sonuc2) + (sonucc2 * sonucc2));
                    #endregion

                    #region 3.satırdaki fark değeri
                    double X_3 = double.Parse(X3);
                    double Y_3 = double.Parse(Y3);
                    double sonuc3 = X_3 - sayıX;//3. satırdaki X'ten textboxtaki X'i çıkarıyor
                    double sonucc3 = Y_3 - sayıY;//3. satırdaki Y'den textboxtaki Y'i çıkarıyor
                    double fark3 = Math.Sqrt((sonuc3 * sonuc3) + (sonucc3 * sonucc3));

                    #endregion

                    #region 4.satırdaki ark değeri
                    double X_4 = double.Parse(X4);
                    double Y_4 = double.Parse(Y4);
                    double sonuc4 = X_4 - sayıX;//4. satırdaki X'ten textboxtaki X'i çıkarıyor
                    double sonucc4 = Y_4 - sayıY;//4. Y'den textboxtaki Y'i çıkarıyor
                    double fark4 = Math.Sqrt((sonuc4 * sonuc4) + (sonucc4 * sonucc4));
                    #endregion

                    #region 5.satırdaki fark değeri
                    double X_5 = double.Parse(X5);
                    double Y_5 = double.Parse(Y5);
                    double sonuc5 = X_5 - sayıX;//5. satırdaki X'ten textboxtaki X'i çıkarıyor
                    double sonucc5 = Y_5 - sayıY;//5. Y'den textboxtaki Y'i çıkarıyor
                    double fark5 = Math.Sqrt((sonuc5 * sonuc5) + (sonucc5 * sonucc5));
                    #endregion

                    #region sırala dizisine fark değerlerini atıyoruz
                    double[] sırala = new double[5];

                    sırala[0] = fark;
                    sırala[1] = fark2;
                    sırala[2] = fark3;
                    sırala[3] = fark4;
                    sırala[4] = fark5;
                    #endregion
                    #region sıralama
                    double gecici;
                    double[] ZDegerleri = new double[5];
                    for (int i = 0; i < sırala.Length - 1; i++)//diziyi küçükten büyüğe atıyoruz
                    {
                        for (int j = i; j < sırala.Length; j++)
                        {
                            if (sırala[i] > sırala[j])
                            {
                                gecici = sırala[j];
                                sırala[j] = sırala[i];
                                sırala[i] = gecici;
                                switch (i)
                                {
                                    case 0:
                                        ZDegerleri[4] = Z[i];
                                        break;
                                    case 1:
                                        ZDegerleri[3] = Z[i];
                                        break;
                                    case 2:
                                        ZDegerleri[2] = Z[i];
                                        break;
                                    case 4:
                                        ZDegerleri[1] = Z[i];
                                        break;
                                    case 5:
                                        ZDegerleri[0] = Z[i];
                                        break;
                                }
                            }
                        }

                    }
                    for (int i = 0; i < sırala.Length; i++)
                    {
                        richTextBoxsırala.SelectedText = sırala[i] + "\n";
                    }
                    #endregion

                }

            }
            catch (Exception)
            {
                //MessageBox.Show("Dikkat! hata");
            }

        }
    }
}
