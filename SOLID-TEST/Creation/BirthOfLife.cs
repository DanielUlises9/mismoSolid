using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SOLID_TEST
{
    class BirthOfLife
    {
        private IList MyList;

        public BirthOfLife()
        {
            MyList = null;
        }

        public IList CreateArmy(Type myType)
        {
            return MyList = CreateList(myType);
        }

        private static IList CreateList(Type myType)
        {
            Type genericListType = typeof(List<>).MakeGenericType(myType);
            return (IList)Activator.CreateInstance(genericListType);
        }

    }
}
