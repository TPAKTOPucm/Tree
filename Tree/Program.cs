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
            Result goldenRing = new Result("��������� �� �������� ������");
            Result rusGK = new Result("��������� ����������� ������");
            Result krasnodKray = new Result("������������� ����");
            Result germany = new Result("��������� � ��������");
            Result everest = new Result("������� �� �������");
            Result mald = new Result("����� �� ���������");
            IEvaluable isSummer = new Node
            {
                Question = "�� ������ ��������� �����?",
                Negative = goldenRing,
                Posivive = krasnodKray
            };
            IEvaluable isWinter = new Node
            {
                Question = "�� ������ ��������� �����?",
                Negative = isSummer,
                Posivive = rusGK
            };
            IEvaluable isCold = new Node
            {
                Question = "������ �� �� �����?",
                Posivive = everest,
                Negative = germany
            };
            IEvaluable isHot = new Node
            {
                Question = "������ �� �� ����?",
                Negative = isCold,
                Posivive = mald
            };
            IEvaluable inRussia = new Node
            {
                Question = "������ �� �� ��������� � ������?",
                Negative = isHot,
                Posivive = isWinter
            };
            IEvaluable budget = new Node
            {
                Question = "������ ������ ���������?",
                Negative = inRussia,
                Posivive = isWinter
            };
            return budget;
        }
    }
}