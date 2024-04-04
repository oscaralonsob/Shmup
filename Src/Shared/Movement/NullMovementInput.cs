using Godot;

[GlobalClass]
public partial class NullMovementInput: MovementInput
{
	public override Vector2 MovementVector(CharacterBody2D character) {
		return Vector2.Zero;
	}	
}