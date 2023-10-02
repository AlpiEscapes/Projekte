using UnityEngine;

using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus
using Pada1.BBCore.Framework; // BasePrimitiveAction

[Action("MyActions/PlayAnimationController")]
[Help("Plays Animation via Controller")]
public class PlayAnimationController : BasePrimitiveAction
{
    // Define the input parameter "shootPoint".

    [InParam("enemy")]
    public GameObject enemy;

    [InParam("animationName")]
    public string name;


    // public override void OnStart()
    // {
    //    enemy = GameObject.Find("Mutant");
    // }
    // Main class method, invoked by the execution engine.
    public override TaskStatus OnUpdate()
    {

        enemy.GetComponent<Animator>().Play(name);
        
        // The action is completed. We must inform the execution engine.
        return TaskStatus.COMPLETED;

    } // OnUpdate

} // class Rotation_toPlayer