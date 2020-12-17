using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Course124.Exercise4._2.EditPerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public RetrieveVirtualItemEventHandler listView1_RetrieveVirtualItem { get; private set; }

        //public object personsListView { get; private set; }

        //List<personsListView>
        //List<EditPersonForm> personsListView = new List<EditPersonForm>();

        List<Person> pers = new List<Person>();
        private void button1_Click(object sender, EventArgs e)  //ДОБАВИТЬ
        {

            Person p = new Person();
            ///EditPersonForm editForm = new EditPersonForm();    
            /// if (editForm.ShowDialog() != DialogResult.OK)
            ///   return;
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            //ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            // newItem.SubItems.Add(editForm.LastName);
            //  newItem.SubItems.Add(editForm.Age.ToString());
            listView1.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(personsListView_RetrieveVirtualItem);
            pers.Add(p);
            listView1.VirtualListSize = pers.Count;
            listView1.Invalidate();

            //Person p = new Person();
            //EditPersonForm editForm = new EditPersonForm(p);
            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;
            //pers.Add(p);
            //listView1.VirtualListSize = pers.Count;
            //listView1.Invalidate();

            //ListViewItem newItem = listView1.Items.Add(editForm.FirstName);
            //newItem.SubItems.Add(editForm.LastName);
            //newItem.SubItems.Add(editForm.Age.ToString());          
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e) //РЕДАКТИРОВАТЬ
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            Person p = pers[listView1.SelectedIndices[0]];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listView1.Invalidate();
            }

            //if (listView1.SelectedItems.Count == 0)
            //    return;
            //ListViewItem item = listView1.SelectedItems[0];
            //EditPersonForm editForm = new EditPersonForm();
            //editForm.FirstName = item.Text;
            //editForm.LastName = item.SubItems[1].Text;
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;
            //item.Text = editForm.FirstName;
            //item.SubItems[1].Text = editForm.LastName;
            //item.SubItems[2].Text = editForm.Age.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
