using Godot;

[GlobalClass]
public partial class PlayerShootInput: ShootInput
{
	public override bool ShootKey() {
		return Input.IsActionPressed("Shoot");
	}	
}