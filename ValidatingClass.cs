using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITMO.Course124.Exercise3._4
{
    public class ValidatingClass : System.Windows.Forms.TextBox
    {
             
        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)  
        {
            if (Text == "")
            {
                e.Cancel = true;
                System.Windows.Forms.MessageBox.Show("Вы не заполнили поле");  
            }
            //else if (nText = double.Parse(nText))
            //{ 
            //    //try
            //    //{
            //    //    double.Parse(nText);
            //    //    e.Cancel = false;
            //    //}
            //    //catch
            //    //{
            //    //    e.Cancel = true;
            //    //    System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Поле ТЕЛЕФОН не может содержать буквы");
            //    //    //nText = "Поле PIN не может содержать буквы";
            //    //}
            //}
        }     
  
    }
}
