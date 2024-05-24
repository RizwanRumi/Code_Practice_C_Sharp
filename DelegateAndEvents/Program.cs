using DelegateAndEvents;

Player player = new Player();

player.AchievementUnlocked += OnAchievementUnlocked;

await player.AddPoints(30);
await player.AddPoints(50);
await player.AddPoints(70);

static void OnAchievementUnlocked()
{
    Console.WriteLine($"Congratulations from program.cs! Achievement unlocked for earning points");
}