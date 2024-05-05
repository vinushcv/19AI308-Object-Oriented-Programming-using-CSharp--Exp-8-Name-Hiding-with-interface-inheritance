# 19AI308-Object-Oriented-Programming-using-CSharp--Exp-8-Name-Hiding-with-interface-inheritance
# AIM:
To implement name hiding with interface inheritance. Aim is to create an interface IMario with a method Ability(). 
Implement this interface in a class Mario and override the Ability() method also to create another class SuperMario that inherits from Mario 
and hides the Ability() method using the new keyword.
# ALGORITHM:
## Step 1:
Create interface IMario with method Ability for Mario classes.

## Step 2:
Mario class implements IMario, defines virtual Ability method.

## Step 3:
SuperMario extends Mario, overrides Ability method with new.

## Step 4:
Instantiate SuperMario and Mario, call Ability on each.

## Step 5:
SuperMario's Ability prints "This is inside SuperMario", Mario's prints "This is inside Mario".

# PROGRAM:
Name: Vinush.CV

Reg no: 212222230176


```c#
using System;

// Define the IMario interface
public interface IMario
{
    void Ability();
}

// Implement the IMario interface in the Mario class
public class Mario : IMario
{
    public virtual void Ability()
    {
        Console.WriteLine("Mario's Ability:Normal Dancing");
    }
}

// SuperMario class that inherits from Mario and hides the Ability() method
public class SuperMario : Mario
{
    public new void Ability()
    {
        Console.WriteLine("Mario's Ability:Super Dancing");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMario mario=new Mario();
        SuperMario superMario=new SuperMario();
        mario.Ability();
        superMario.Ability();
    }
}


```


# OUTPUT:

/![image](https://github.com/vinushcv/19AI308-Object-Oriented-Programming-using-CSharp--Exp-8-Name-Hiding-with-interface-inheritance/assets/113975318/d161344f-e103-4f09-8a7d-ce2ee2e7a67b)


# RESULT:
Thus, the program has been executed successfully.

