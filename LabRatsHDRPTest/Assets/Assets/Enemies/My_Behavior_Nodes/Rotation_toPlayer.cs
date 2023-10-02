using UnityEngine;

using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus
using Pada1.BBCore.Framework; // BasePrimitiveAction

[Action("MyActions/Rotation_toPlayer")]
[Help("Makes the Gameobject Rotate towards the other Gameobject")]
public class Rotation_toPlayer : BasePrimitiveAction
{
    // Define the input parameter "shootPoint".
    [InParam("enemy")]
    public GameObject enemy;

    [InParam("targetPosition")]
    public GameObject targetPosition;


    // public override void OnStart()
    // {
    //    enemy = GameObject.Find("Mutant");
    // }
    // Main class method, invoked by the execution engine.
    public override TaskStatus OnUpdate()
    {

        //Debug.Log("me" + enemy);
        //Debug.Log("ziel" + targetPosition);
        enemy.transform.LookAt(targetPosition.transform);
        // The action is completed. We must inform the execution engine.
        return TaskStatus.COMPLETED;

    } // OnUpdate

} // class Rotation_toPlayer