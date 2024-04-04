using Godot;

[GlobalClass]
public partial class PlayerFollowDirectionInput : DirectionInput
{
	private CharacterBody2D Player { get; set; }

	public override Vector2 DirectionVector(CharacterBody2D character) {
		if (null == Player) {
			Player = character.GetTree().GetFirstNodeInGroup("Player") as CharacterBody2D;
		}

		return Player.Position;
	}	
}
