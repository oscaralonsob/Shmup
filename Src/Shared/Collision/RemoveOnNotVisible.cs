using Godot;
using System;

public partial class RemoveOnNotVisible : Node
{
	[Export]
	private CharacterBody2D CharacterBody2D { set; get; }
	
	private void VisibilityChanged() {
		CharacterBody2D.QueueFree();
		GD.Print("Bullet deleted");
	}
}
