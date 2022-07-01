﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODEB_HOMEWORK_SECONDWEEK.Abstract;

namespace TODEB_HOMEWORK_SECONDWEEK.Concrete
{
    //class için herhangi bir erişim belirteci kullanmadım çünkü belirteç kullanılmazsa zaten default olarak internal erişim belirteci ile oluşur. Başka bir proje/katman bulunmadığından, public işaretlemeye gerek yoktur.
    class Principal :Employee
    {
        internal override void GetInfoAbout()
        { 
            //Propertyler base classtan geldiği için propertyleri belirtirken base kelimesi ile sınıfın türetildiği soyut sınıfı belirtiriz. 
            Console.WriteLine(base.NameSurname + '\n' + base.Birthday.ToShortDateString() + '\n'+ "School Principal" + '\n');// '\n' karakteri, bir sonraki yazılanları bir satır aşağı kaydırmak için kullanılır. 
                    
        }
    }
}
