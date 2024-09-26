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
                    1
                )
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.DisplayQuestion(questions[0]);
            Console.ReadKey();  
        }
    }
}
