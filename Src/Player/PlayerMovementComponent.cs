using Godot;

public partial class PlayerMovementComponent : Node
{
	[Export]
	private CharacterBody2D CharacterBody2D { set; get; }

	public override void _PhysicsProcess(double delta) {
		Movement(delta);
		Direction(delta);
	}

	private void Movement(double delta) {
		Vector2 InputDirection = Vector2.Zero;
		float Speed = 100;
		
		if (Input.IsActionPressed("MoveRight")) {
			InputDirection += Vector2.Right;
		} 
		if (Input.IsActionPressed("MoveLeft")) {
			InputDirection += Vector2.Left;
		}
		if (Input.IsActionPressed("MoveDown")) {
			InputDirection += Vector2.Down;
		}
		if (Input.IsActionPressed("MoveUp")) {
			InputDirection += Vector2.Up;
		}

		CharacterBody2D.MoveAndCollide(InputDirection * Speed * (float) delta);
	}

	private void Direction(double delta) {
		Vector2 mousePosition = GetViewport().GetMousePosition();
		if (mousePosition != CharacterBody2D.Position) {
			CharacterBody2D.LookAt(GetViewport().GetMousePosition());
		}
	}
}
