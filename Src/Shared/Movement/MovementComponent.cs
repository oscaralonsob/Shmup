using Godot;

public partial class MovementComponent : Node
{
	[Export]
	private CharacterBody2D CharacterBody2D { set; get; }
	[Export]
	private MovementInput MovementInput { set; get; }
	[Export]
	private DirectionInput DirectionInput { set; get; }
	
	//TODO: resource
	[Export]
	float Speed = 100;

	public override void _PhysicsProcess(double delta) {
		Movement(delta);
		Direction();
	}

	private void Movement(double delta) {
		Vector2 input = MovementInput.MovementVector(CharacterBody2D);
		CharacterBody2D.MoveAndCollide(input * Speed * (float) delta);
	}

	private void Direction() {
		Vector2 vector = DirectionInput.DirectionVector(CharacterBody2D);
		CharacterBody2D.LookAt(vector);
	}
}
