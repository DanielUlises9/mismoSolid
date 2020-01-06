using SOLID_TEST.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_TEST
{
    abstract class Human : ILivingThings , IAtacks
    {
        /// <summary>
        /// It provides the method health for humans
        /// </summary>
        /// <returns></returns>
        public abstract int Health { get; }
        /// <summary>
        /// It provides the method damage for Humans
        /// </summary>
        /// <returns></returns>
        public abstract int Punch { get; }
        /// <summary>
        /// It provides the method alive for humans
        /// </summary>
        public abstract bool IsAlive { get; }

    }
}
