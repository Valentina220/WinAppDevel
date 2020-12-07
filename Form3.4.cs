using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Course124.Exercise3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string FirstName
        {
            get { return validatingClass1.Text; }
            set { validatingClass1.Text = value; }
        }
        public string LastName
        {
            get { return validatingClass2.Text; }
            set { validatingClass2.Text = value; }
        }
        public string PhoneNumber
        {
            get { return validatingClass3.Text; }
            set { validatingClass3.Text = value; }
        }

        public override string ToString()
        {            
            return "\n Имя: " + FirstName + "\n фамилия: " + LastName +
            "\n Телефон: " + PhoneNumber ;        
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            var someList = new List<string>();      
            someList.Add(FirstName);
            someList.Add(LastName);
            someList.Add(PhoneNumber);
            
            StringBuilder sb = new StringBuilder();
            foreach (var item in someList)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();           

        }
    }
}
