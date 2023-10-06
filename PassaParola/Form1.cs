using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        //cevap1
                        if (textBox1.Text == "akdeniz")
                        {
                            btnA.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        //cevap 2
                        if (textBox1.Text == "bursa")
                        {
                            btnB.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            btnC.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "deri")
                        {
                            btnD.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "engel")
                        {
                            btnE.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fransa")
                        {
                            btnF.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            btnG.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "h")
                        {
                            btnH.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ırmak")
                        {
                            btnI.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "inci")
                        {
                            btnni.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnni.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            btnJ.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kış")
                        {
                            btnK.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            btnL.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "maaş")
                        {
                            btnM.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "nane")
                        {
                            btnN.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "osmanlı")
                        {
                            btnO.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            btnP.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ray")
                        {
                            btnR.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "savaş")
                        {
                            btnS.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "trabzon")
                        {
                            btnT.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "uğur böceği")
                        {
                            btnU.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "vapur")
                        {
                            btnV.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yenidünya")
                        {
                            btnY.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zebani")
                        {
                            btnZ.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            yanlis++;
                            lblyanlis.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            linkLabel1.ActiveLinkColor = Color.Silver;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();


            if (soruno == 1)
            {
                btnA.BackColor = Color.Yellow;
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
            }

            if (soruno == 2)
            {
                btnB.BackColor = Color.Yellow;
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
            }

            if (soruno == 3)
            {
                btnC.BackColor = Color.Yellow;
                richTextBox1.Text = "Müslümanların kutsal günü?";
            }

            if (soruno == 4)
            {
                btnD.BackColor = Color.Yellow;
                richTextBox1.Text = "İnsanın Vücudu ne ile kaplıdır ?";
            }

            if (soruno == 5)
            {
                btnE.BackColor = Color.Yellow;
                richTextBox1.Text = "Bazen göremediğimiz ama yinede takıldığımız şeyler bütünü";
            }

            if (soruno == 6)
            {
                btnF.BackColor = Color.Yellow;
                richTextBox1.Text = "Romantiklerin Ülkesi?";
            }

            if (soruno == 7)
            {
                btnG.BackColor = Color.Yellow;
                richTextBox1.Text = "Dünyanın doğal ısı ve ışık kaynağı";
            }

            if (soruno == 8)
            {
                btnH.BackColor = Color.Yellow;
                richTextBox1.Text = "Hidrojen atomunun kimyasal sembolü nedir?";
                // H
            }

            if (soruno == 9)
            {
                btnI.BackColor = Color.Yellow;
                richTextBox1.Text = "Genellikle bir denize dökülen, genişliği, uzunluğu ve taşıdığı su oylumu yönünden en büyük akarsu.?";
                //ırmak
            }

            if (soruno == 10)
            {
                btnni.BackColor = Color.Yellow;
                richTextBox1.Text = "Jack Sparrow adıyla bilinen korsan filmlerinin bir tanesinin adında kullanılan bir maden türü";
                // inci
            }

            if (soruno == 11)
            {
                btnJ.BackColor = Color.Yellow;
                richTextBox1.Text = "156 kimin numarasıdır ";
            }

            if (soruno == 12)
            {
                btnK.BackColor = Color.Yellow;
                richTextBox1.Text = "Game Of Throneste sıkça duyduğumuz Winter is Coming sözünün kelimelerinden bir tanesinin türkçe karşılığı";
            }

            if (soruno == 13)
            {
                btnL.BackColor = Color.Yellow;
                richTextBox1.Text = "Zambakgiller familyasından Tulipa cinsini oluşturan güzel çiçekleri ile süs bitkisi olarak yetiştirilen, soğanlı, çok yıllık otsu bitki türlerinin ortak adı.";
            }

            if (soruno == 14)
            {
                btnM.BackColor = Color.Yellow;
                richTextBox1.Text = "Köleleri ödüllendirmek için günümüzde adlandırılan kavram";
            }

            if (soruno == 15)
            {
                btnN.BackColor = Color.Yellow;
                richTextBox1.Text = "ballıbabagiller familyasının Mentha cinsini oluşturan bütün Dünya'da görülebilen 25-30 türün ortak adı. Genellikle temmuz ve ağustos ayları arasında açarlar ve bu bitki uçucu yağ bakımından zengindir";
            }

            if (soruno == 16)
            {
                btnO.BackColor = Color.Yellow;
                richTextBox1.Text = ".... torunuyuz derler";
            }

            if (soruno == 17)
            {
                btnP.BackColor = Color.Yellow;
                richTextBox1.Text = "Sapı olan ve genellikle yuvarlak şekillerde pişirilen bir sebze türü";
            }

            if (soruno == 18)
            {
                btnR.BackColor = Color.Yellow;
                richTextBox1.Text = "Trenlerin üzerinde gittiği yol";
            }

            if (soruno == 19)
            {
                btnS.BackColor = Color.Yellow;
                richTextBox1.Text = "Kazananın olmayacağı iki tarafında sadece kaybedeceği bir çıkar";
            }

            if (soruno == 20)
            {
                btnT.BackColor = Color.Yellow;
                richTextBox1.Text = "Burunları uzun olan insanların genellikle yaşadığı şehir";
            }

            if (soruno == 21)
            {
                btnU.BackColor = Color.Yellow;
                richTextBox1.Text = "Böcek türlerinden olan bu böceğe ve annesine şarkı yazdığımız varlık";
            }

            if (soruno == 22)
            {
                btnV.BackColor = Color.Yellow;
                richTextBox1.Text = "Denizlerin üzerinde seyehat etmemizi kolaylaştırır ";
            }

            if (soruno == 23)
            {
                btnY.BackColor = Color.Yellow;
                richTextBox1.Text = "Turunca renkli bol ve devasa çekirdekleri olan leziz mi leziz yaz meyvesi";
            }

            if (soruno == 24)
            {
                btnZ.BackColor = Color.Yellow;
                richTextBox1.Text = "Cehennemde görevli varlık";
            }



        }
    }
}
