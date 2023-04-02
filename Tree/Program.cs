namespace Tree
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(generateTree()));
        }
        static IEvaluable generateTree()
        {
            Result goldenRing = new Result("Экскурсия по Золотому кольцу");
            Result rusGK = new Result("Ближайший горнолыжный курорт");
            Result krasnodKray = new Result("Краснодарский край");
            Result germany = new Result("Экскурсия в Германию");
            Result everest = new Result("Поездка на Эверест");
            Result mald = new Result("Отдых на Мальдивах");
            IEvaluable isSummer = new Node
            {
                Question = "Вы хотите отдохнуть летом?",
                Negative = goldenRing,
                Posivive = krasnodKray
            };
            IEvaluable isWinter = new Node
            {
                Question = "Вы хотите отдохнуть зимой?",
                Negative = isSummer,
                Posivive = rusGK
            };
            IEvaluable isCold = new Node
            {
                Question = "Любите ли Вы холод?",
                Posivive = everest,
                Negative = germany
            };
            IEvaluable isHot = new Node
            {
                Question = "Любите ли Вы жару?",
                Negative = isCold,
                Posivive = mald
            };
            IEvaluable inRussia = new Node
            {
                Question = "Хотите ли Вы отдохнуть в России?",
                Negative = isHot,
                Posivive = isWinter
            };
            IEvaluable budget = new Node
            {
                Question = "Бюджет сильно ограничен?",
                Negative = inRussia,
                Posivive = isWinter
            };
            return budget;
        }
    }
}