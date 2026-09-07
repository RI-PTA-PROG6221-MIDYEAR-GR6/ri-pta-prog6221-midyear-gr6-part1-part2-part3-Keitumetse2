[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/SAB2_YS4)

## CyberSecurity Aareness Chatbot

## 1. Project Desciption
The Cybersecurity Awareness Chatbot is a C# console application designed to help users learn about basic cybersecurity.
The chatbot provides simple information about topics such as passwords (What is a password) (how do i make a strong password), phishing, malware, privacy and safe browsing. It also uses the user's name to make the conversation more personal.

## 2. The features of the chatbot :
- The Cybersecurity themed symbol console interface ASCII.
- Voice greeting when the program starts.
- Ask the user how they are, with a random response to it.
- Then asks the user for their name or nickname.   
- Then welcomes the user with a message to cybersecurity chatbot.
- Personalised responses using the users name.
- Cybersecurity questions and answers.
- Multiple responses for different questions.
- Random responses so the chatbot does not always give the same answer.
- It includes the typing effect for chatbot messages.
- Different colours for the bot, user and headings.
- Allows the user to type 'exit' when wants to leave.

## 3. CyberSecurity topics
- Password
- what is a password
- how do i make a strong password
- phishing
- what is a phishing
- Malware
- safe browsing
- privacy
- Anti-virus

## 4. Things used to make this Project
- Visual studio
-  C#
-  System Media (for allowing the wav file to be in the program). 
-  WAV audio file

## 5. Project classes

#### Program class:
- The Program class is the starting point of the project. It displays the ASCII art, starts the voice greeting and then starts the chatbot.

#### Voice Greeting class:
- The VoiceGreeting class plays the WAV voice greeting when the projects starts.
- The code in this class uses PlaySync() instead of Play() so that the chatbot waits for the voice greeting to finish before continuing.
  
#### Introduction:
The Introduction class handles the beginning of the conversation.
- Asks the user how they are.
- Checks keywords in the users answer.
- Provides a suitable positive, negative or normal response.
- Asks the user for their name.
- Stores the users name for personalised responses.

#### Chatbot :
- The Chatbot class controls the main conversation. It displays the cybersecurity topics, receives questions from the user and displays the bots responses.
- It also contains the slow_Typing() method, which creates the typing effect when the chatbot is speaking.

#### Communication:
- The Communication class contains the chatbot's cybersecurity responses.
- It uses a Dictionary to store different response and an existing getRandom_response() method to randomly select a response.

## 6. How to run my program
##### Before you start
- Visual Studio must be installed.
- The full project downloaded or cloned from GitHub.
- Open the project in Visual Studio.
- Open the solution or project file.
- Check that all the .cs files are there.
- Check that the voice greeting file is in the project.
- Run the program by clicking Starts without debugging or press a shortcut Ctrl + f5.
- Then the program should begin with the voice greeting and the ASCII art.
