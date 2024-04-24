using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal
{
    protected string name;
    protected int health;


    public abstract void Move();

    public abstract void Eat();

    public Animal()
    {

    }
    public Animal(string animalName)
    {
        name = animalName;
    }
}




