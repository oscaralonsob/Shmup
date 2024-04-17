using System;
using System.Collections.Generic;
using Godot;
using Godot.Collections;

public partial class WinManager : Node
{
	private List<Node> Enemies { get; set; }
	[Export]
	private EventBus EventBus { get; set; }

	public override void _Ready() {
		Enemies = new List<Node>();
		foreach (Node enemy in GetTree().GetNodesInGroup("Enemy")) {
			Enemies.Add(enemy);
		}
	}	

	public override void _Process(double delta)
	{
		if (Enemies == null) {
			return;
		}

		int enemiesAlive = 0;
		foreach (Node Enemy in Enemies) {
			if (IsInstanceValid(Enemy)) {
				enemiesAlive++;
			}
		}

		if (enemiesAlive == 0) {
			Enemies = null;
			EventBus.EmitSignal(EventBus.SignalName.EnemiesKilled);
		}
	}
}
