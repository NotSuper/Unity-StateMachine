using UnityEngine;

public abstract class StateMachine : MonoBehaviour {

	protected MachineState currentState;

	protected void updateState() => currentState?.update();

	public void changeState(MachineState state) {
		if(state == currentState) { return; }
		currentState?.exit();
		currentState = state;
		if(currentState) {
			currentState.init();
		}
	}

}
