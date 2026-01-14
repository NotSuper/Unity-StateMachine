using UnityEngine;

public abstract class MachineState : MonoBehaviour {
	public virtual void init() {}
	public virtual void update() {}
	public virtual void exit() {}
}