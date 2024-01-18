using DelegatesAndEvents;

Player player = new Player();
Party party = new Party();


//subscribe
player.AchievmentUnlocked += OnAchievementUnlocked;
player.AchievmentUnlocked += party.Cheering;

await player.AddPoints(30);
await player.AddPoints(40);
await player.AddPoints(35);

//Unsubscribe
player.AchievmentUnlocked -= OnAchievementUnlocked;
player.AchievmentUnlocked -= party.Cheering;

static void OnAchievementUnlocked(int points)
{
    Console.WriteLine($"Congratulations, achievement unlocked for earning {points} points!");
}