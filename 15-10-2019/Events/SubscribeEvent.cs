using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // Define a class to hold event info
    public class CustomEventArgs : EventArgs
    {
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public CustomEventArgs(string s)
        {
            message = s;
        }
      
    }

    //Declaring an event
    class Publisher
    { 
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;
        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Did something"));
        }   
       protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;
            if (handler != null)
            {
                e.Message += $" at {DateTime.Now}";
                handler(this, e);
            }
        }
    }

    //Class that subscribes to an event
    class Subscriber
    {
        private string id;
        public Subscriber(string ID, Publisher pub)
        {
            id = ID;
            // Subscribe to the event 
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        // Define what actions to take when the event is raised.
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);
        }
    }
    class SubscribeEvent
        {
            static void Main(string[] args)
            {
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber("sub1", pub);
            Subscriber sub2 = new Subscriber("sub2", pub);

            pub.DoSomething();

            Console.WriteLine("Press Enter to close this window.");
            Console.ReadLine();
        }
        }
    }

