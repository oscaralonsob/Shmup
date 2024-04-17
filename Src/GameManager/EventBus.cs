using Godot;

[GlobalClass]
public partial class EventBus : Resource
{
	[Signal]
	public delegate void PlayerKilledEventHandler();
	[Signal]
	public delegate void EnemiesKilledEventHandler();

	public EventBus() {
		PlayerKilled += PlayerKilledHandler;
		EnemiesKilled += EnemiesKilledHandler;
	}

	private void PlayerKilledHandler() {
		GD.Print("Player killed");
	}	

	private void EnemiesKilledHandler() {
		GD.Print("Enemies killed");
	}	
}
