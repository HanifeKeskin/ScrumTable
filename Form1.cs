using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YazilimYapimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.rtxtStory1.AllowDrop = true;
            this.rtxtStory1.DragEnter += RtxtStory1_DragEnter;
            this.rtxtStory1.DragDrop += RtxtStory1_DragDrop;
            rtxtStory1.EnableAutoDragDrop = true;
        }

        private void RtxtStory1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Rtf))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void RtxtStory1_DragDrop(object sender, DragEventArgs e)
        {
            int i;
            String s;

            i = rtxtStory1.SelectionStart;
            s = rtxtStory1.Text.Substring(i);
           rtxtStory1.Text = rtxtStory1.Text.Substring(0, i);
           rtxtStory1.Text = rtxtStory1.Text +
           e.Data.GetData(DataFormats.Text).ToString();
           rtxtStory1.Text = rtxtStory1.Text + s;
        }

        Story story = new Story();
        Task task = new Task();
        User user = new User();

        private void btnGoster_Click(object sender, EventArgs e)
        {
            rtxtStory1.Text = "Story1" + story.StoryAd + "\nİçerik1" + story.StoryIcerik + "\n";
            rtxtStory2.Text = "Story2" + story.StoryAd + "\nİçerik2" + story.StoryIcerik + "\n";
            rtxtStory3.Text = "Story3" + story.StoryAd + "\nİçerik3" + story.StoryIcerik + "\n";
            StreamWriter dosya1 = new StreamWriter("c:\\Deneme1.txt");
            dosya1.WriteLine("Task Adı:Ad1" + task.TaskAdi);
            dosya1.WriteLine("İçerik:İçerik1" + task.TaskIcerik);
            dosya1.WriteLine("Kisi:Kisi1" + user.Kisi);
            dosya1.Close();
            StreamReader s1 = new StreamReader("c:\\Deneme1.txt");
            string satir1 = s1.ReadLine();
            while (satir1 != null)
            {
                rtxtTask1.Text = rtxtTask1.Text + "\n" + satir1;
                satir1 = s1.ReadLine();
            }


            StreamWriter dosya2 = new StreamWriter("c:\\Deneme2.txt");
            dosya2.WriteLine("Task Adı:Ad2" + task.TaskAdi);
            dosya2.WriteLine("İçerik:İçerik2" + task.TaskIcerik);
            dosya2.WriteLine("Kisi:Kisi2" + user.Kisi);
            dosya2.Close();
            StreamReader s2 = new StreamReader("c:\\Deneme2.txt");
            string satir2 = s2.ReadLine();
            while (satir2 != null)
            {
               rtxtTask2.Text = rtxtTask2.Text + "\n" + satir2;
                satir2 = s2.ReadLine();
            }

            StreamWriter dosya3 = new StreamWriter("c:\\Deneme3.txt");
            dosya3.WriteLine("Task Adı:Ad3" + task.TaskAdi);
            dosya3.WriteLine("İçerik:İçerik3" + task.TaskIcerik);
            dosya3.WriteLine("Kisi:Kisi3" + user.Kisi);
            dosya3.Close();
            StreamReader s3 = new StreamReader("c:\\Deneme3.txt");
            string satir3 = s3.ReadLine();
            while (satir3 != null)
            {
                rtxtTask3.Text =rtxtTask3.Text + "\n" + satir3;
                satir3 = s3.ReadLine();
            }

            StreamWriter dosya4 = new StreamWriter("c:\\Deneme4.txt");
            dosya4.WriteLine("Task Adı:Ad4" + task.TaskAdi);
            dosya4.WriteLine("İçerik:İçerik4" + task.TaskIcerik);
            dosya4.WriteLine("Kisi:Kisi4" + user.Kisi);
            dosya4.Close();
            StreamReader s4 = new StreamReader("c:\\Deneme4.txt");
            string satir4 = s4.ReadLine();
            while (satir4 != null)
            {
                rtxtTask4.Text = rtxtTask4.Text + "\n" + satir4;
                satir4 = s4.ReadLine();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
