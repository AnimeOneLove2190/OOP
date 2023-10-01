using System;
using System.Collections.Generic;
using System.Text;
using Quest01.Services;

namespace Quest01.Computers
{
    class Laptop : Computer
    {
        readonly TechnicalService technicalService = new TechnicalService();
        public BodyMaterial BodyMaterial { get; set; }
        public bool Webcam { get; set; }
        public int BatteryCapacity { get; set; }
        public override string GetInfo()
        {
            return $"Модель: {Model}. Видеокарта: {VideoCard}. Оперативная память: {RAM} гб. Процессор: {CPU}. Материал корпуса: {technicalService.CheckMaterial(BodyMaterial)}. Наличие веб-камеры {technicalService.CheckWebcam(Webcam)}. Емокость батареи: {BatteryCapacity}";
        }
    }
}
