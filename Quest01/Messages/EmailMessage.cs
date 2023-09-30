using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01.Messages
{
    class EmailMessage : Message
    {
        public string SenderEmail { get; set; }
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public int NumberOfAttachedFiles { get; set; }
        public override string Send()
        {
            return $"Электронное сообщение №{Id} отправлено. Отправитель: {SenderEmail}. Получатель: {RecipientEmail}. Тема письма: {Subject}. Количество прикрепленных файлов: {NumberOfAttachedFiles}";
        }
    }
}
