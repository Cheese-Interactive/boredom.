using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[CreateAssetMenu(menuName = "Tasks/Cleanup")]
public class Cleanup : Task {

    public override void OnTaskComplete() {

        Debug.Log("Cleanup Finished");

    }
}
