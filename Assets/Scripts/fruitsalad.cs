using UnityEngine;
using System.Collections;

public class fruitsalad : MonoBehaviour
{
    void Start () 
    {
        //Notice here how the variable "myFruit" is of type
        //Fruit but is being assigned a reference to an Apple. This
        //works because of Polymorphism. Since an Apple is a Fruit,
        //this works just fine. While the Apple reference is stored
        //in a Fruit variable, it can only be used like a Fruit
        Fruit myFruit = new apple();

        myFruit.SayHello();
        myFruit.Chop();

        //This is called downcasting. The variable "myFruit" which is 
        //of type Fruit, actually contains a reference to an Apple. Therefore,
        //it can safely be turned back into an Apple variable. This allows
        //it to be used like an Apple, where before it could only be used
        //like a Fruit.
        apple myApple = (apple)myFruit;

        myApple.SayHello();
        myApple.Chop();    
    }
}
