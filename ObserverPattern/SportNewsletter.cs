using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    // Konkretes Subjekt
    public class SportNewsletter : NewsletterSubject
    {
        private Newsletter currentNewsletter;

        public SportNewsletter(Newsletter newsletter)
        {
            this.currentNewsletter = newsletter;
        }

        public Newsletter GetNewsletter()
        {
            return currentNewsletter;
        }

        public void SetNewsletter(Newsletter newNewsletter)
        {
            currentNewsletter = newNewsletter;
            Console.WriteLine("Es ist ein neuer Newsletter erschienen");
            SendNewsletter(currentNewsletter);
        }
    }
}
