using Godot;
using System;

public partial class RemoveOnHitComponent : Area2D
{
	[Export]
	private CharacterBody2D CharacterBody2D { set; get; }

	private void CollisionHappened(Area2D area) {
		CharacterBody2D.QueueFree();
		GD.Print("Object deleted");
	}
}
