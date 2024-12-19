using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26{
public class CreatureManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Kangaroo kangaroo= new Kangaroo();
        Duck duck= new Duck();

        List<Creature> creatureList= new List<Creature>(){kangaroo,duck};

        List<IRunnable> runnableList=new List<IRunnable>(){kangaroo,duck};
        
        List<IJumpable> jumpableList=new List<IJumpable>(){kangaroo};

        List<ISwimmable> swimmableList=new List<ISwimmable>(){duck};

        foreach(Creature creature in creatureList){
            creature.Speak();
        }

        foreach(IRunnable runnable in runnableList){
            runnable.Run();
        }

        foreach(ISwimmable swimmable in swimmableList){
           swimmable.Swim();
        }

        foreach(IJumpable jumpable in jumpableList){
            jumpable.Jump();
        }
        
    }

}
}