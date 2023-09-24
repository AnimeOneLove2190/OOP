using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class Letter : Message
    {
        public string SenderFullName { get; set; }
        public string RecipientFullName { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientPostcode { get; set; }
        public override string Send()
        {
            return $"Письмо {Id} отправлено. Отправитель: {SenderFullName}, {SenderAddress}. Получатель: {RecipientFullName}, {RecipientAddress}, {RecipientPostcode}";
        }
    }
}
