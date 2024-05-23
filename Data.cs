using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloxStreet_Trainer
{
    internal class Data
    {
        public static string failed = "Unfortunately, you have failed this training session. You are welcome to attend another session.";

        public static List<string> three_green_lines = new List<string>
        {
            "Greetings, everyone! Thank you for attending this training session. My name is {username}, and it is my pleasure to be your trainer.",
            "While working at the cafe, you are responsible for taking the customer's order and ensuring its prompt fulfillment.",
            "Congratulations, you have all passed the Cafe Test! Please sign out of your cafe registers by clicking the exit button."
        };

        public static List<string> introduction_script = new List<string>
        {
            "Greetings, everyone! Thank you for attending this training session. My name is {username}, and it is my pleasure to be your trainer.",
            "In case you need to go AFK for any reason, be sure to inform me. Failure to do so will result in a removal from the server.",
            "Please be aware that you are allowed to go AFK for a maximum of two minutes. You may not go AFK for a duration exceeding this time.",
            "During this training session, you are permitted to go AFK up to two times.",
            "In the event that I disconnect from the server, please wait for me to rejoin. Refrain from moving to a different station or wandering around.",
            "Please indicate you are ready to proceed by jumping. At this time, I will not answer any questions."
        };

        public static List<string> cafe_test_script = new List<string>
        {
            "We will now begin with the Cafe Test.",
            "When a customer approaches your cafe register at the store, it is essential to greet them with a polite and friendly greeting.",
            "Here is an example of a greeting: “Hello! Welcome to BloxStreet Corporation! I'm {username}, and I'm here to assist you. How may I help you today?”",
            "Make sure to include the term \"BloxStreet\" in your greeting.",
            "While working at the cafe, you are responsible for taking the customer's order and ensuring its prompt fulfillment.",
            "Feel free to utilize the !notepad command to record the customer's order.",
            "I will now demonstrate how to prepare some common orders: a coffee and a slushie. Please pay close attention and refrain from attempting to make the drinks yourselves.",
            "To prepare a coffee, begin by clicking on the white mug. Once you have equipped the mug, proceed to dispense the type of coffee that the guest ordered.",
            "To create a slushie, begin by clicking on the cold cup. Once you have the cold cup equipped, proceed to dispense the type of slushie that the guest ordered.",
            "To log into a cafe register, simply scan your BloxStreet Staff Card on the screen. You may scan your card at this time.",
            "After signing in, proceed to scan any items the customer has requested. Once all items have been scanned, click on \"Finish Transaction\" to complete the order.",
            "Afterward, kindly prompt the customer to scan their BloxStreet Cash Card on the payment screen. Once the payment is made, wish the guest an enjoyable rest of their day.",
            "We will begin this test shortly. You must utilize comprehensible grammar, and I will assess your understandability.",
            "Please be aware that I can only repeat the order twice. If you give me an incorrect item, you will fail this training automatically.",
            "I will now approach each of you individually. When I do, make sure to greet me with your greeting.",
            "Greetings! May I please have a Cherry Slushie and a Regular Coffee?"
        };

        public static List<string> register_test_script = new List<string>
        {
            "Congratulations, you have all passed the Cafe Test! Please sign out of your cafe registers by clicking the exit button.",
            "Follow me so we can start the Register Test. When at the register, form a line facing the register from the cashier point.",
            "When a customer approaches your cash register, similar to the cafe, it is essential to greet them with a polite and friendly greeting.",
            "When a customer requests to proceed with checkout, click on the \"Start Sale\" button on the register.",
            "After selecting the customer's username, proceed to click on the \"Finalize Sale\" button.",
            "Based on the guest's preference, click either \"Robux Payment\" or \"Card Payment\" to proceed with the payment process.",
            "After that, proceed to click on the \"Finalize Sale\" button.",
            "Afterward, kindly prompt the customer to scan their BloxStreet Cash Card on the payment screen. Once the payment is made, wish the guest an enjoyable rest of their day.",
            "Are all of you prepared to start the test? If you are, please jump to indicate your readiness.",
            "Hi, may I please check out my items?"
        };

        public static List<string> passing_lrs_script = new List<string>
        {
            "Congratulations, you have all passed the Register Test! You have each completed both tests.",
            "If you are currently a Senior Team Member, you will be promoted to Department Supervisor. In order to be promoted as a Department Supervisor, you must attend and be recognized at a shift.",
            "Shifts are hosted daily at the store. The entire schedule can be found in the store’s staff room.",
            "If you encounter any trollers at the store, it is necessary to inform an available Store Director+.",
            "For any further inquiries, please make sure to join our communications server using the code 'bloxstreet'.",
            "Please follow me to the purple ranking line so you can be ranked. Congratulations on passing!"
        };
    }
}
