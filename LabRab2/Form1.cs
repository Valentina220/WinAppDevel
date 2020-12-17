using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }

        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public int PeriodUse // Cрок использования
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }


        //   ЖУРНАЛ
        public string Magtitle // Название
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public string volume // Том
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        public int number // Номер
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }

        public int year // Дата выпуска
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }

        public int MagInvNumber // 
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public bool IfSubs// подписка
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        //public bool MagReturnTime // Возвращение в срок
        //{
        //    get { return checkBox5.Checked; }
        //    set { checkBox5.Checked = value; }
        //}

        //if (radioButton1.Checked == true)
        //this.but.Text = "First";
        //else if (radioButton2.Checked == true)
        //this.but.Text = "Second";

        
        List<Item> its = new List<Item>();

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 1;
            Year = 2020;
            Existence = ReturnTime = false;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(volume, number, Magtitle, year, MagInvNumber, IfSubs);
            if (IfSubs)
            m.Subs();
            //m.PriceBook(PeriodUse);
            its.Add(m);
            volume = Magtitle = "";
            number = 1;
            InvNumber = 100001;
            year = 2020;
            IfSubs = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        
        //private void tabPage1_Click(object sender, EventArgs e)
        //{

        //    List<Item> its = new List<Item>();

        //    private void button1_Click(object sender, EventArgs e)
        //    {
        //        Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
        //        if (ReturnTime)
        //            b.ReturnSrok();
        //        b.PriceBook(PeriodUse);
        //        its.Add(b);
        //        Author = Title = PublishHouse = "";
        //        Page = InvNumber = PeriodUse = 1;
        //        Year = 2020;
        //        Existence = ReturnTime = false;

        //    }

        //    private void button2_Click(object sender, EventArgs e)
        //    {
        //        if (SortInvNumber)
        //            its.Sort();
        //        StringBuilder sb = new StringBuilder();
        //        foreach (Item item in its)
        //        {
        //            sb.Append("\n" + item.ToString());
        //        }
        //        richTextBox1.Text = sb.ToString();
        //    }

        //}


        //MessageBox.Show("Ваша подписка оформлена", "Подписка");


        //private void button4_Click(object sender, EventArgs e)
        //{
        //    Form2 f = new Form2();
        //}

        //private void button4_Click_1(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Ваша подписка оформлена", "Подписка");
        //    //radioButton1.Checked = true;
        //}


        //private void checkBox4_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (Button4.Checked == true) ;
        //}
    }
}
