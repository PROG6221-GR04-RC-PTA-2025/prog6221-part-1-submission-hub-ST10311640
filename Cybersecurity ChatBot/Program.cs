using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity_ChatBot
{
    internal class Program
    {
        static void PlayVoiceGreeting()
        {
            string filePath = @"C:\\Users\\RC_Student_lab\\source\\repos\\Cybersecurity ChatBot\\bin\\greetings.wav";

            try
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\\Users\\RC_Student_lab\\source\\repos\\Cybersecurity ChatBot\\bin\\greetings.wav"))
                {
                    player.Load();
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error playing voice greeting: " + ex.Message);
                Console.ResetColor();
            }
        }

       


static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
          
                     ███████   ███████╗  
                     ██╔══██╗  ██╔════╝  
                     ██║  ██║  ██║       
                     ██████╔╝  █████╗    
                     ██╔══██╗  ██╔══╝    
                     ██║  ██║  ██║       
                     ███████   ███████  
  
        ██████╗  ██╗   ██╗  ███████   ███████╗  ███████
       ██╔════   ██║   ██║  ██╔══██╗  ██╔════╝  ██╔══██╗
       ██║       ╚██╗ ██╔╝  ██║  ██║  ██║       ██║  ██║
       ██║        ╚████╔╝   ██████╔╝  █████╗    ██████╔╝ 
       ██║          ██║     ██╔══██╗  ██╔══╝    ██╔══██╗
       ╚██████╗     ██║     ██║  ██║  ██║       ██║  ██║
        ╚═════╝     ╚═╝     ███████   ███████   ╚═╝  ╚═╝ 
                                   
          █████╗  ██╗    ██╗  █████╗  ███████  ██████╗  
         ██╔══██╗ ██║    ██║ ██╔══██╗ ██╔══██╗ ██╔═══╝  
         ██║  ██║ ██║    ██║ ██║  ██║ ██║  ██║ ██║      
         ███████║ ██║ █╗ ██║ ███████║ ██████╔╝ █████╗   
         ██╔══██║ ██║███╗██║ ██╔══██║ ██╔══██╗ ██╔══╝   
         ██║  ██║ ╚███╔███╔╝ ██║  ██║ ██║  ██║ ██║      
         ╚═╝  ╚═╝  ╚══╝╚══╝  ╚═╝  ╚═╝ ╚═╝  ╚═╝ ███████     
                 !! Protect Yourself Online !!
            ");
            Console.ResetColor();
        }

        static void ChatbotInteraction()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYou can ask me cybersecurity-related questions.");
            Console.WriteLine("Try asking: \"How are you?\", \"What's your purpose?\", \"What is phishing?\"");
            Console.WriteLine("Type 'Exit' or 'Quit' to leave the chat.");
            Console.ResetColor();

            while (true)
            {
                Console.Write("\nYou: ");
                string userQuestion = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(userQuestion))
                {
                    Console.WriteLine("Chatbot: Please enter a valid question.");
                    continue;
                }

                if (userQuestion == "exit" || userQuestion == "quit")
                {
                    Console.WriteLine("Chatbot: Goodbye! Stay safe online.");
                    break;
                }

                string response = GetChatbotResponse(userQuestion);
                Console.WriteLine($"Chatbot: {response}");
            }
        }

        static string GetChatbotResponse(string question)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            switch (question)
            {
                case "how are you?":
                    return "I'm just a bot, but I'm here to help you stay safe online!";

                case "what's your purpose?":
                    return "I'm a cybersecurity awareness bot, designed to educate you on online safety and digital security.";

                case "what is phishing?":
                    return "Phishing is a cyberattack where scammers impersonate trusted sources to steal your personal information, such as passwords or banking details.\n\n"
                         + "Common Types of Phishing Attacks:\n"
                         + "1. Email Phishing - Fake emails pretending to be from banks, social media sites, or online services.\n"
                         + "2. Spear Phishing - A targeted attack using personal details to sound convincing.\n"
                         + "3. Smishing (SMS Phishing) - Fake text messages urging you to click a malicious link.\n"
                         + "4. Vishing (Voice Phishing) - Scammers call you pretending to be tech support or a bank.\n\n"
                         + "How to Stay Safe:\n"
                         + "* Don't click on suspicious links in emails or messages.\n"
                         + "* Verify the sender’s email address carefully.\n"
                         + "* If unsure, contact the company directly through official channels.\n"
                         + "* Never enter personal details into an unsecured website (look for HTTPS).\n\n"
                         + "Example: You get an email from 'PayPal' saying, 'Your account is locked! Click here to unlock it.' Always go to PayPal's official site instead of clicking links.";

                case "what is password safety?":
                    return "Password safety means using strong, unique passwords for each account and enabling two-factor authentication (2FA) where possible.\n\n"
                         + "Best Practices for Strong Passwords\n"
                         + "* Use at least *12-16 characters*, including uppercase, lowercase, numbers, and symbols.\n"
                         + "* Avoid common passwords like '123456' or 'password'.\n"
                         + "* Use a passphrase instead of a simple password (e.g., 'Blue$Monkey_Jumps42!').\n"
                         + "* Enable 2FA for extra protection (e.g., SMS codes or authentication apps).\n"
                         + "* Use a password manager to store and generate secure passwords.\n\n"
                         + "Example: Instead of 'John1987', use something like 'J0hn#87@Safe!'. A password manager can help create and remember complex passwords.";

                case "what is safe browsing?":
                    return "Safe browsing involves being cautious while visiting websites, clicking links, and downloading files to avoid malware and scams.\n\n"
                         + "How to Browse Safely:\n"
                         + "* Check for HTTPS - Always use secure websites (the URL should start with 'https://').\n"
                         + "* Avoid clicking unknown links - Hover over links before clicking to check if they match the expected URL.\n"
                         + "* Use a trusted web browser - Modern browsers like Chrome, Firefox, or Edge have built-in security features.\n"
                         + "* Enable browser security settings - Activate safe browsing features in your browser settings.\n"
                         + "* Don't auto-save passwords in browsers - Use a password manager instead.\n"
                         + "* Be cautious of pop-ups - Don't enter personal details in pop-ups that appear randomly.\n\n"
                         + "Example: If you receive a link claiming you won a prize, hover over it before clicking. If it doesn’t match the official website, it's likely a scam.";

                default:
                    return "I'm not sure about that. Could you ask another cybersecurity-related question?";
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            // Play voice greeting
            PlayVoiceGreeting();

            // Display ASCII logo
            DisplayAsciiArt();

            // Greet user and get their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Hello! What's your name? ");
            string userName = Console.ReadLine();

            while (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Please enter a valid name.");
                Console.Write("What's your name? ");
                userName = Console.ReadLine();
            }

            Console.WriteLine($"Nice to meet you, {userName}!");
            Console.ResetColor();

            // Provide chatbot interaction
            ChatbotInteraction();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
