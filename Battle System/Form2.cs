using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_System
{
    public partial class FormItem : Form
    {
        public FormItem()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Input list item di combo box

            ItemList.Items.Add("Rawon");
            ItemList.Items.Add("Nasi Goreng");
            ItemList.Items.Add("Mi Goreng");
            ItemList.Items.Add("Rendang");

           
          

        }

        //MENG-INPUT JUMLAH ITEM
        public static int Rawon = 4;
        public static int NasiGoreng = 4;
        public static int MiGoreng = 4;
        public static int Rendang = 4;






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            tombol1.Enabled = true;
            tombol2.Enabled = true;
            tombol3.Enabled = true;
            tombol4.Enabled = true;

            // CODE PENGATURAN BUTTON UNTUK MENENTUKAN JUMLAH ITEM, JIKA ITEM SUDAH DI ANGKA 0 , MAKA BUTTON SEMUA MATI

            if (ItemList.Text == "Rawon")
            {
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;
                }
          
                labelNamaMakanan.Text = "Rawon";

            }
            else if (ItemList.Text == "Nasi Goreng")
            {
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
                labelNamaMakanan.Text = "Nasi Goreng";
            }
            else if (ItemList.Text == "Mi Goreng")
            {
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
                labelNamaMakanan.Text = "Mi Goreng";
            }
            else if (ItemList.Text == "Rendang")
            {
                if (Rendang < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
                labelNamaMakanan.Text = "Rendang";
            }
            
            // MENGELUARKAN JUMLAH ITEM DI LABEL 2

            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                labelJumlah.Text = "Amount : " + Rawon;
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {
                labelJumlah.Text = "Amount : " + NasiGoreng;
            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                labelJumlah.Text = "Amount : " + MiGoreng;
            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                labelJumlah.Text = "Amount : " + Rendang;
            }

            //CODE MENGUBAH GAMBAR YANG ADA DI PICTURE BOX AGAR SESUAI DENGAN ITEM YANG DIPILIH

            if (ItemList.Text == "Rawon")
            {
                pictureItem.Image = Properties.Resources.RAWON;
            }
            else if (ItemList.Text == "Nasi Goreng")
            {
                pictureItem.Image = Properties.Resources.Nasi_Goreng;
            }
            else if (ItemList.Text == "Mi Goreng")
            {
                pictureItem.Image = Properties.Resources.Mi_Goreng;
            }
            else if (ItemList.Text == "Rendang")
            {
                pictureItem.Image = Properties.Resources.Rendang;
            }

            //Code Menambahkan Deskripsi makanan

            if (ItemList.Text == "Rawon")
            {
                DeskripsiMakanan.Text = " ";
            }
            else if (ItemList.Text == "Nasi Goreng")
            {
                DeskripsiMakanan.Text = " ";
            }
            else if (ItemList.Text == "Mi Goreng")
            {
                DeskripsiMakanan.Text = " ";
            }
            else if (ItemList.Text == "Rendang")
            {
                DeskripsiMakanan.Text = " ";
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CODE YANG DIMANA AGAR JUMLAH ITEM LIST JIKA DIPENCET TOMBOL BUTTON BISA MENGURANG

            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                Rawon--;
                labelJumlah.Text = "Amount : " + Rawon;
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {

                NasiGoreng--;
                labelJumlah.Text = "Amount : " + NasiGoreng;
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                MiGoreng--;
                labelJumlah.Text = "Amount : " + MiGoreng;
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
               
            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                Rendang--;
                labelJumlah.Text = "Amount : " + Rendang;
                if (Rendang< 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            
        }

        private void tombol2_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                Rawon--;
                labelJumlah.Text = "Amount : " + Rawon;
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {

                NasiGoreng--;
                labelJumlah.Text = "Amount : " + NasiGoreng;
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                MiGoreng--;
                labelJumlah.Text = "Amount : " + MiGoreng;
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                Rendang--;
                labelJumlah.Text = "Amount : " + Rendang;
                if (Rendang < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }

        }

        private void tombol3_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                Rawon--;
                labelJumlah.Text = "Amount : " + Rawon;
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {

               NasiGoreng--;
                labelJumlah.Text = "Amount : " + NasiGoreng;
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                MiGoreng--;
                labelJumlah.Text = "Amount : " + MiGoreng;
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                Rendang--;
                labelJumlah.Text = "Amount : " + Rendang;
                if (Rendang < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }

        }

        private void tombol4_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                Rawon--;
                labelJumlah.Text = "Amount : " + Rawon;
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {

                NasiGoreng--;
                labelJumlah.Text = "Amount : " + NasiGoreng;
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                MiGoreng--;
                labelJumlah.Text = "Amount : " + MiGoreng;
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                Rendang--;
                labelJumlah.Text = "Amount : " + Rendang;
                if (Rendang < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }

        }
    }
    }

