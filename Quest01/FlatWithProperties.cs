using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class FlatWithProperties
    {
        private int id;
        private int number;
        private int area;
        private string fullName;
        private Type type;
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                fullName = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                id = value;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                number = value;
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                area = value;
            }
        }
        public Type Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                type = value;
            }
        }
    }
}
