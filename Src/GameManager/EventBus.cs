using Godot;
//TODO: create resource so we do not need singleton

public partial class EventBus : Node
{
	public static EventBus Instance { get; private set; }

	[Signal]
	public delegate void PlayerKilledEventHandler();

	public override void _Ready() {
		if (null == Instance) {
      Instance = this;
    }

		PlayerKilled += PlayerKilledHandler;
	}

	private void PlayerKilledHandler() {
		GD.Print("Player killed");
	}	
}
