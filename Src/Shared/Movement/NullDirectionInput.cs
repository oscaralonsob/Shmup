using Godot;

[GlobalClass]
public partial class NullDirectionInput: DirectionInput
{
	public override Vector2 DirectionVector(CharacterBody2D character) {
		return character.GlobalPosition + Vector2.Right.Rotated(character.GlobalRotation);
	}	
}