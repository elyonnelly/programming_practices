using System;

namespace Library
{
    // 1) класс с данными о событии "Кольцо найдено"
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s) { Message = s; }
        // Будем передавать только строку
        public String Message { get; set; }
    }
}
