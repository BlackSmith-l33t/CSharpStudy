using System;

// event_예제01
namespace event_exercise
{
    class Sender
    {
        public event EventHandler EventHandler;
        public event EventHandler<string> EventStringHandler;

        public void DoPrintEvent()
        {
            EventHandler?.Invoke(this, EventArgs.Empty);
        }

        public void DoStringEvent(string str)
        {
            EventStringHandler?.Invoke(this, str);
        }

    }

    class Receiver
    {
        public void ReceiveEvent(object sender, EventArgs e)
        {
            Console.WriteLine("이벤트를 보낸 객체는 {0} 입니다.", sender.GetType().Name);
            Console.WriteLine("이벤트를 받았다!");
        }

        public void ReceiveStringEvent(object sender, string str)
        {
            Console.WriteLine("이벤트를 보낸 객체는 {0} 입니다.", sender.GetType().Name);
            Console.WriteLine("{0} 은 {1} 글자입니다.", str, str.Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sender sender = new Sender();
            Receiver receiver = new Receiver();

            sender.EventHandler += receiver.ReceiveEvent;
            sender.EventStringHandler += receiver.ReceiveStringEvent;

            sender.DoPrintEvent();
            sender.DoStringEvent("Hello C#!");

        }
    }
}
