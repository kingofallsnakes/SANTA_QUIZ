# Santa Quiz

Santa Quiz is an interactive console-based quiz application built with C#. It includes user authentication (login and signup), a randomized quiz panel, and scoring based on user performance. The application is designed to be fun and educational, rewarding users with "Santa gifts" based on their scores.

---

## Features

- **User Authentication**: 
  - Login with existing credentials.
  - Signup to create a new account.
- **Quiz Panel**: 
  - Select the number of questions to attempt.
  - Randomized questions for each quiz session.
  - Immediate feedback for each question (correct or wrong).
- **Scoring System**: 
  - Calculates the score and percentage.
  - Rewards users with virtual "Santa gifts" based on performance.
- **Questions**: A diverse set of questions on various topics like technology, general knowledge, and programming.

---

## How It Works

1. **Start the Application**:
   - Run the program, and you’ll be welcomed with a choice to login or signup.
2. **Login or Signup**:
   - Existing users can log in with their credentials.
   - New users can create an account by signing up.
3. **Quiz Panel**:
   - Enter the number of questions you want to attempt.
   - Answer each question by selecting options (A/B/C/D).
4. **Results**:
   - View your score, percentage, and personalized feedback.
   - Receive virtual "Santa gifts" based on your score.

---

## Installation and Setup

### Prerequisites
- **.NET Core SDK** installed on your system.
- A text file named `user_data.txt` in the same directory as the executable for storing user credentials.

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/kingofallsnakes/Santa_Quiz.git
   cd Santa_Quiz
   ```
2. Open the project in your preferred IDE (e.g., Visual Studio or Visual Studio Code).
3. Build and run the project:
   ```bash
   dotnet build
   dotnet run
   ```

---

## File Structure

- **Program.cs**: Contains the main logic for the application, including user authentication, quiz logic, and scoring.
- **Questions.cs**: Stores the list of quiz questions and their options.

---

## Usage

### Example Interaction
1. **Welcome Message**:
   ```
   Welcome to the Santa Quiz!
   1. Login
   2. Signup
   Enter your choice (1/2):
   ```
2. **Login**:
   ```
   Enter Username: user1
   Enter Password: pass123
   ```
3. **Quiz**:
   ```
   Welcome to Santa Quiz Panel, user1!
   Enter the number of questions you want to attempt: 3
   Question 1: What does CPU stand for?
   A. Central Processing Unit
   B. Control Processing Unit
   C. Computer Processing Unit
   D. Core Processing Unit
   Your Answer (A/B/C/D): A
   Correct!
   ```

---

## Future Enhancements

- Add a GUI for better user interaction.
- Store user data securely using a database.
- Add categories for questions.
- Include a leaderboard to track top scorers.

---

## Contributors

- **Cobra** - [kingofallsnakes](https://github.com/kingofallsnakes)

---

## Feedback

Feel free to provide feedback or suggest features via [Issues](https://github.com/kingofallsnakes/Santa_Quiz/issues).

Happy Quizzing! 🎅
