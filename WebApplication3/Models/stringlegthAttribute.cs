using System;

namespace WebApplication3.Models
{
    internal class stringlegthAttribute : Attribute
    {
        private int v;

        public stringlegthAttribute(int v)
        {
            this.v = v;
        }
    }
}