using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFormApp
{
    public partial class BtnReadFile : Form
    {

        public int counter { get; set; } = 0;

        public BtnReadFile()
        {
            InitializeComponent();
        }


        private void BtnCounter_Click(object sender, EventArgs e)
        {
            textBoxCounter.Text = counter++.ToString();
        }

        private async void BtnReadVall_Click(object sender, EventArgs e)
        {

            //string data = ReadFile();
            string data = String.Empty;
            Task<string> okuma= ReadFileAsync();

            richTextBox2.Text = await new HttpClient().GetStringAsync("https://www.google.com");

            //artık okumadan gelecek data bana gelsin bekliyorum
            data = await okuma;

            richTextBox1.Text = data;
        }


        private string ReadFile()
        {
            string data = string.Empty;
            using (StreamReader s = new StreamReader("dosya.txt"))
            {

                Thread.Sleep(5000);
                data = s.ReadToEnd();
            }
            return data;
        }


        //Task only -> void 
        //Task<Type> -> return
        private async Task<string> ReadFileAsync()
        {
            string data = string.Empty;


            using (StreamReader s = new StreamReader("dosya.txt"))
            {
                Task<string> mytask  = s.ReadToEndAsync();
                //-----
                //Herhangi bi işlem yapılabilir bu arada
                //Söz (Taahüt) await ile son bulur
                //-----
                await Task.Delay(5000);
                data = await mytask;
                return data;
            }

        }

        private Task<string> ReadFileAsync2()
        {

            StreamReader s = new StreamReader("dosya.txt");
            
                return s.ReadToEndAsync();
            
        }

    }
}
