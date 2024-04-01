using Godot;

[GlobalClass]
public partial class BulletMovementInput: MovementInput
{
	public override Vector2 MovementVector(CharacterBody2D characterBody2D) {
		return Vector2.Right.Rotated(characterBody2D.GlobalRotation);
	}
}
