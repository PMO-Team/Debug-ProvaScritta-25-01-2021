using System;

namespace ProvaScrittaPMO_25_01_2021
{
    public class Notifier
    {

        private static Notifier instance;

        public static Notifier GetInstance()
        {
            instance = new Notifier();
            return instance;
        }

        private Notifier() { }


        public void FireEvent()
        {
            wrongInput(this, null);
        }

        public event EventHandler wrongInput;

        
    }
}