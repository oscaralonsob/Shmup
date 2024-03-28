using Godot;

public partial class PlayerBulletMovementComponent : Node
{
	[Export]
	private CharacterBody2D CharacterBody2D { set; get; }
	private Vector2 Direction { set; get; }
	private float Speed { set; get; }

	public override void _Ready() {
		Direction = Vector2.Up;//TODO: provisional
		Speed = 100;//TODO: provisional
	}

	public override void _PhysicsProcess(double delta) {
		CharacterBody2D.MoveAndCollide(Direction * Speed * (float) delta);
	}
}
