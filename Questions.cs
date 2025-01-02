using System.Collections.Generic;

public class Question
{
    public string QuestionText { get; set; }
    public string[] Options { get; set; }
    public string CorrectAnswer { get; set; }
}

public static class Questions
{
    public static List<Question> GetQuestions()
    {
        return new List<Question>
        {
            new Question 
            { 
                QuestionText = "What does CPU stand for?", 
                Options = new[] {
                     "Central Processing Unit", "Control Processing Unit", "Computer Processing Unit", "Core Processing Unit" },
                      CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which programming language is primarily used for web development?", 
                Options = new[] {
                     "Python", "JavaScript", "C#", "Java" }, 
                     CorrectAnswer = "B" },
            new Question 
            { 
                QuestionText = "What is the full form of RAM?", 
                Options = new[] { 
                    "Random Access Memory", "Read-Only Memory", "Rapid Access Memory", "Rotational Access Memory" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which technology is used to make telephone calls over the internet?", 
                Options = new[] {
                     "VoIP", "WiFi", "NFC", "Bluetooth" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What does HTML stand for?",
                Options = new[] {
                     "Hyper Text Markup Language", "Hyper Text Manipulation Language", "Hyper Tool Markup Language", "Hyper Text Multiple Language" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the function of DNS?", 
                Options = new[] { 
                    "Translate domain names to IP addresses", "Encrypt data", "Store files", "Provide wireless access" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the name of the first electronic general-purpose computer?", 
                Options = new[] { 
                    "ENIAC", "UNIVAC", "IBM 360", "MARK I" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which device is used to connect networks?", 
                Options = new[] { 
                    "Router", "Switch", "Hub", "Modem" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the primary function of a firewall?", 
                Options = new[] { 
                    "Block unauthorized access", "Optimize software", "Store data", "Improve graphics" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the process of finding and fixing errors in software called?", 
                Options = new[] {
                     "Debugging", "Compiling", "Executing", "Testing" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the largest unit of digital storage?", 
                Options = new[] {
                     "Terabyte", "Petabyte", "Exabyte", "Zettabyte" }, 
                     CorrectAnswer = "D" },
            new Question 
            { 
                QuestionText = "What does IoT stand for?", 
                Options = new[] { 
                    "Internet of Things", "Integration of Technology", "Internet of Technology", "Interconnection of Things" },
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which protocol is used to send emails?", 
                Options = new[] { 
                    "SMTP", "HTTP", "FTP", "DNS" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which of these is not a programming language?", 
                Options = new[] {
                     "Python", "Ruby", "Pascal", "Photoshop" }, 
                     CorrectAnswer = "D" },
            new Question 
            { 
                QuestionText = "What is the full form of HTTP?", 
                Options = new[] { 
                    "Hypertext Transfer Protocol", "Hyperlink Transfer Protocol", "High-speed Transfer Protocol", "Hypertext Transmission Protocol" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which one is a relational database?", 
                Options = new[] {
                     "MySQL", "MongoDB", "Cassandra", "Redis" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which is a version control system?", 
                Options = new[] {
                     "Git", "Docker", "Nginx", "TensorFlow" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the smallest unit of data in a computer?", 
                Options = new[] {
                     "Bit", "Byte", "Nibble", "Kilobyte" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which company developed Java?", 
                Options = new[] {
                     "Sun Microsystems", "Microsoft", "IBM", "Oracle" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the main feature of Object-Oriented Programming?", 
                Options = new[] {
                     "Encapsulation", "High Performance", "Ease of Use", "Dynamic Typing" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What does GUI stand for?", 
                Options = new[] {
                     "Graphical User Interface", "Global User Interface", "Graphical Universal Interface", "General User Interface" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which is not an operating system?", 
                Options = new[] {
                     "Linux", "Windows", "Oracle", "MacOS" }, 
                     CorrectAnswer = "C" },
            new Question 
            { 
                QuestionText = "Which programming language is known as a backend language?", 
                Options = new[] {
                     "PHP", "CSS", "HTML", "JavaScript" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which device is used for input?", 
                Options = new[] { 
                    "Keyboard", "Printer", "Monitor", "Speaker" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the full form of URL?", 
                Options = new[] { 
                    "Uniform Resource Locator", "Universal Resource Locator", "Universal Record Locator", "Uniform Retrieval Locator" }, 
                    CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the base of the binary system?", 
                Options = new[] {
                     "2", "8", "10", "16" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "What is the shortcut key for paste in Windows?", 
                Options = new[] {
                     "Ctrl + P", "Ctrl + V", "Ctrl + X", "Ctrl + Z" }, 
                     CorrectAnswer = "B" },
            new Question 
            { 
                QuestionText = "Which programming language is used for data science?", 
                Options = new[] {
                     "Python", "C++", "Ruby", "PHP" }, 
                     CorrectAnswer = "A" },
            new Question 
            { 
                QuestionText = "Which is not a cloud service provider?", 
            Options = new[] {
                 "AWS", "Google Cloud", "Azure", "Linux" }, 
                 CorrectAnswer = "D" },
        };
    }
}
