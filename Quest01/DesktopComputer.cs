using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class DesktopComputer : Computer
    {
        readonly TechnicalService tech = new TechnicalService();
        public TypeOfShell TypeOfShell { get; set; }
        public BodyMaterial BodyMaterial { get; set; }
        public override string GetInfo()
        {
            return $"Модель: {Model}. Видеокарта: {VideoCard}. Оперативная память: {RAM} гб. Процессор: {CPU} Тип корпуса: {tech.CheckType(TypeOfShell)}. Материал корпуса: {tech.CheckMaterial(BodyMaterial)}";
        }
    }
}
