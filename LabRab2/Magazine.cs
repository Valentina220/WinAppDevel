using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblWorm
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String Magtitle;       // название
        private int year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume, int number, String Magtitle, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.Magtitle = Magtitle;
            this.year = year;
        }


       public override void Return()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

      

      public void Subs()
      {
            IfSubs = true;
      }


       public override string ToString()
       {
           if (IfSubs)
           return "\nЖурнал:\n Название: " + Magtitle + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
           else
               return "\nЖурнал:\n Название: " + Magtitle + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
       }
    }
}
