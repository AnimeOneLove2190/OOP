using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class FlatWithAccessorMethods
    {
        private int id;
        private int number;
        private int area;
        private string fullName;
        private Type type;
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            if (id <= 0)
            {
                return;
            }
            this.id = id;
        }
        public int GetNumber()
        {
            return number;
        }
        public void SetNumber(int number)
        {
            if (number <= 0)
            {
                return;
            }
            this.number = number;
        }
        public int GetArea()
        {
            return area;
        }
        public void SetArea(int area)
        {
            if (area <= 0)
            {
                return;
            }
            this.area = area;
        }
        public string GetFullName()
        {
            return fullName;
        }
        public void SetFullName(string fio)
        {
            if (string.IsNullOrEmpty(fio) || string.IsNullOrWhiteSpace(fio))
            {
                return;
            }
            this.fullName = fio;
        }
        public Type GetType1()
        {
            return type;
        }
        public void SetType(Type type)
        {
            if (type <= 0)
            {
                return;
            }
            this.type = type;
        }
    }
}
