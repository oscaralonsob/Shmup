using Godot;
//TODO: create node and pass the event bus as parameter/resource
public partial class LoseManager : Node
{
	private CharacterBody2D Player { get; set; }

	public override void _Ready() {
		if (null == Player) {
			Player = GetTree().GetFirstNodeInGroup("Player") as CharacterBody2D;
		}
	}	

	public override void _Process(double delta)
	{
		if (null == Player) {
			return;
		}

		if (!IsInstanceValid(Player)) {
			Player = null;
			EventBus.Instance.EmitSignal(EventBus.SignalName.PlayerKilled);
		}
	}
}
