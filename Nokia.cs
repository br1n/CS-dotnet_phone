using System;
namespace phone
{
    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            string returnRing = $"...{this.ringTone}...";
            return returnRing;

        }
        public string Unlock() 
        {
            string returnUnlock = $"Your {this.versionNumber} unlocked with passcode.";
            return returnUnlock;
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine("########################");
            Console.WriteLine($"Phone Model: {this.versionNumber}");
            Console.WriteLine($"Battery Life: {this.batteryPercentage}");
            Console.WriteLine($"Carrier: {this.carrier}");
            Console.WriteLine($"Ring Tone: {this.ringTone}");
            Console.WriteLine("########################");
        }
    }
}