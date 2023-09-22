using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class TechnicalService
    {
        public string CheckWebcam(bool webcam)
        {
            if (webcam)
            {
                return "да";
            }
            else
            {
                return "нет";
            }
        }
        public string CheckType(TypeOfShell type)
        {
            if (type == TypeOfShell.Vertical)
            {
                return "вертикальный";
            }
            if (type == TypeOfShell.Horizontal)
            {
                return "горизонтальный";
            }
            return "квантовая суперпозиция";
        }
        public string CheckMaterial(BodyMaterial material)
        {
            if (material == BodyMaterial.Plastic)
            {
                return "пластик";
            }
            if (material == BodyMaterial.Metal)
            {
                return "металл";
            }
            if (material == BodyMaterial.Wood)
            {
                return "дерево";
            }
            return "антивещество";
        }
    }
}
