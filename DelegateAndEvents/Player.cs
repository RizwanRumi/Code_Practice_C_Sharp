namespace DelegateAndEvents
{
    internal class Player
    {
        public int Points { get; set; }

        public event Action? AchievementUnlocked;

        public async Task AddPoints(int points)
        {
            Points += points;
            Console.WriteLine($"Player earned {points}. Total points: {Points}");
            await Task.Delay( 1000 );

            if ( Points > 100 ) 
            {
                AchievementUnlocked?.Invoke();                
            }
        }
    }
}
