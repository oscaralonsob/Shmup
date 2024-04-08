using Godot;

[GlobalClass]
public partial class AlwaysShootInput: ShootInput
{
	public override bool ShootKey() {
		return true;
	}	
}