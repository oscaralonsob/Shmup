using Godot;

[GlobalClass]
public partial class PlayerDirectionInput: DirectionInput
{
	public override Vector2 DirectionVector(CharacterBody2D character) {
		Vector2 mousePosition = character.GetViewport().GetMousePosition();
		if (mousePosition != character.Position) {
			return mousePosition;
		}
		return Vector2.Right.Rotated(character.GlobalRotation);
	}
		
}