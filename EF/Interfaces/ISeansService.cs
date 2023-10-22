using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.Interfaces
{
    interface ISeansService
    {
        public void CreateSeans(int hallId, int sessionId, int ticketPrice);
    }
}
