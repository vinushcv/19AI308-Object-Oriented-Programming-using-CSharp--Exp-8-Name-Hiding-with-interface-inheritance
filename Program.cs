using System;

// Define the IMario interface
public interface IMario
{
 
}

// Implement the IMario interface in the Mario class
public class Mario : IMario
{
    public virtual void Ability()
    {
  
    }
}

// SuperMario class that inherits from Mario and hides the Ability() method
public class SuperMario : Mario
{
    public new void Ability()
    {
    
    }
}

class Program
{
    static void Main(string[] args)
    {
       

       
    }
}

