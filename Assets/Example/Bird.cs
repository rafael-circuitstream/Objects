using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bird : Animal, ILayEggs
{
    public override void Move()
    {

    }

    public Bird()
    {

    }

    public Bird(string newName) : base(newName)
    {
        name = newName;
    }

    public override void Eat()
    {

    }

    public abstract void LayEggs();
}

public class Eagle : Bird, IFly
{
    public override void Move()
    {
        base.Move();
        Fly();
    }

    public void Fly()
    {
        Debug.Log("Flapping my wings");
    }

    public override void LayEggs()
    {
        throw new System.NotImplementedException();
    }
}

public class Penguin : Bird
{

    public override void LayEggs()
    {
       
    }

    public override void Move()
    {
        base.Move();
    }
}

public class Chicken : Bird
{
    public override void LayEggs()
    {
        
    }

    public override void Move()
    {
        base.Move();
    }
}

