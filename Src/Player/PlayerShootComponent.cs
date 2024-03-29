using Godot;

public partial class PlayerShootComponent : Node2D
{
	[Export]
	private PackedScene BulletScene { set; get; }
	[Export]
	private Timer Timer { set; get; }
	private bool InCd { set; get; } = false;

	public override void _Process(double delta) {
		if (!InCd) {
			Shoot();
		}
	}

	private void Shoot() {
		//TODO: resource
		int CdTime = 5;

		if (Input.IsActionPressed("Shoot")) {
			CharacterBody2D playerBulletMovementComponent = BulletScene.Instantiate<CharacterBody2D>();
			GetTree().Root.AddChild(playerBulletMovementComponent);
			playerBulletMovementComponent.Position = GlobalPosition;
			playerBulletMovementComponent.GlobalRotation = GlobalRotation;

			InCd = true;
			Timer.Start(CdTime);
		}
	}

	private void TimeOut() {
		InCd = false;
	}
}
