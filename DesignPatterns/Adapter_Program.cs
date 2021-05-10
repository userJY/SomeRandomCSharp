using System;

namespace DesignPatternsInC_
{   

    //This will be the interface of the adapter
    public interface IMachine
    {
        public void essentialmethodA();
        public void essentialmethodB();
    }
    
    //The old class that needs to be 'plugged' into the adapter
    public class OutdatedMachine
    {
        public void doSomething1() => Console.WriteLine("Did first thing");   
        public void doSomething2() => Console.WriteLine("Did second thing");
        public void doSomething3() => Console.WriteLine("Not working");
        
    }

    //The adapter
    public class MachineAdapter : IMachine 
    {
        OutdatedMachine _MachineToAdapt; 
        //Take the old machine
        //Basically placing a covering over the old machine
        public MachineAdapter(OutdatedMachine MachineToAdapt)
        {
            _MachineToAdapt = MachineToAdapt;
        }
        //implement the necessary methods
        public void essentialmethodA() => _MachineToAdapt.doSomething1();
        public void essentialmethodB() => _MachineToAdapt.doSomething2();
    }
    //
    class Program
    {
        static void Main(string[] args)
        {
            OutdatedMachine OldThing = new OutdatedMachine();
            IMachine NewThing = new MachineAdapter(OldThing);
            NewThing.essentialmethodA();
            NewThing.essentialmethodB();
        }
    }
}
