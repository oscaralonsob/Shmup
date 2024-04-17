using Godot;

public partial class LoseManager : Node
{
	private CharacterBody2D Player { get; set; }
	[Export]
	private EventBus EventBus { get; set; }

	public override void _Ready() {
		Player = GetTree().GetFirstNodeInGroup("Player") as CharacterBody2D;
	}	

	public override void _Process(double delta)
	{
		if (null == Player) {
			return;
		}

		if (!IsInstanceValid(Player)) {
			Player = null;
			EventBus.EmitSignal(EventBus.SignalName.PlayerKilled);
		}
	}
}
