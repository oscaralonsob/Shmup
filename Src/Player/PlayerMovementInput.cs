using Godot;

[GlobalClass]
public partial class PlayerMovementInput: MovementInput
{
	public override Vector2 MovementVector(CharacterBody2D character) {
		Vector2 InputDirection = Vector2.Zero;
		
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

		return InputDirection;
	}
}
