using System;
using System.Collections.Generic;
using System.Text;
using Quest01.Services;

namespace Quest01.Computers
{
    class Monoblock : Computer
    {
        readonly TechnicalService technicalService = new TechnicalService();
        public BodyMaterial BodyMaterial { get; set; }
        public double ScreenDiagonal { get; set; }
        public bool Webcam { get; set; }
        public override string GetInfo()
        {
            return $"Модель: {Model}. Видеокарта: {VideoCard}. Оперативная память: {RAM} гб. Процессор: {CPU}. Материал корпуса: {technicalService.CheckMaterial(BodyMaterial)}. Диагональ экрана: {ScreenDiagonal}. Наличие веб-камеры {technicalService.CheckWebcam(Webcam)}";
        }
    }
}
