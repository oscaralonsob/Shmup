using Godot;

public partial class PlayerBulletMovementComponent : Node
{
	[Export]
	private CharacterBody2D CharacterBody2D { set; get; }
	private Vector2 Direction { set; get; }
	private float Speed { set; get; }

	public override void _Ready() {
		Speed = 300;//TODO: resource
	}

	public override void _PhysicsProcess(double delta) {
		Direction = Vector2.Right.Rotated(CharacterBody2D.GlobalRotation);
		CharacterBody2D.MoveAndCollide(Direction * Speed * (float) delta);
	}
	//TODO: collision to ignore player
}
