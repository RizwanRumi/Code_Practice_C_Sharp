using DelegateAndEvents;

Player player = new Player();
var party = new Party();

// event subscribe
player.AchievementUnlocked += OnAchievementUnlocked;
player.AchievementUnlocked += party.Cheering; ;

await player.AddPoints(30);
await player.AddPoints(50);
await player.AddPoints(70);

// event unsubscribe
player.AchievementUnlocked -= OnAchievementUnlocked;
player.AchievementUnlocked -= party.Cheering; ;

static void OnAchievementUnlocked(int points)
{
    Console.WriteLine($"Congratulations! Achievement unlocked for earning {points} points");
}