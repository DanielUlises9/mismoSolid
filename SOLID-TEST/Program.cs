
using System;
using System.Collections.Generic;
using System.Collections;

namespace SOLID_TEST
{
    class Program
    {
         BirthOfLife birthOfLife;
         RedTeam redTeam;
         IList MyList;
         static Human function;
        static void Main(string[] args)
        {
            interesting<BlueTeam>();
        }

        public static void interesting<T>()
            where T: Human, new()
        {
            function = new T();
        }


    }
}
