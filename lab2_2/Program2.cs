namespace pr2_2
{
    internal class Program2
    {
        static void Main()
        {
            Player player = new Player(100);

            UIHealthBar ui = new UIHealthBar();
            SoundSystem sound = new SoundSystem();
            AchievementSystem achievements = new AchievementSystem();
            GameLogger logger = new GameLogger();

            ui.Subscribe(player);
            sound.Subscribe(player);
            achievements.Subscribe(player);
            logger.Subscribe(player);

            player.TakeDamage(20);
            player.TakeDamage(30);
            player.TakeDamage(40);
            player.TakeDamage(20);
        }
    }
}
