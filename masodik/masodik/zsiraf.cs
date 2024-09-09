using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik
{
    internal class Class3
    {
        public string Name;
        public string Phone;
        public string Age;
        public int go;







        public Class3()
        {


        }

        public void setName(string nev)
        {
            this.Name = nev;
        }



        public string getName()
        {
            return this.Name;
        }
        public void setPhone(string telo) 
        {
            this.Phone = telo;
        }
        public string getPhone()
        {
            return this.Phone;
        }
        public void setAge(string kor)
        {
            this.Age = kor;
        }
        public string getAge()
        {
            return this.Age;
        }

        public void Go(string g) 
        {
            this.go = this.go + int.Parse(g);

        }

        public int getAllDistance()
        {
            return go;
        }









    }
}
