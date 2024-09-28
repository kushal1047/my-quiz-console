namespace MyQuizConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[] 
            { 
                new Question
                (
                    "What is the capital of Nepal?",
                    new string[] {"Kathmandu", "Berlin", "London", "Paris"},
                    0
                ),
                new Question
                (
                    "What is 5*12?",
                    new string[] {"50", "90", "60", "88"},
                    2
                ),
                new Question
                (
                    "Where was Gautam Buddha Born?",
                    new string[] {"India", "China", "Nepal", "Cambodia"},
                    2
                ),
                new Question
                (
                    "Whats the capital of Australia?",
                    new string[] {"Canberra", "Brisbane", "Sydney", "Perth"},
                    0
                ),
                new Question
                (
                    "Where was Emperor Genghis Khan from?",
                    new string[] {"China", "USSR", "Kazakhstan", "Mongolia"},
                    3
                )
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadKey();  
        }
    }
}
