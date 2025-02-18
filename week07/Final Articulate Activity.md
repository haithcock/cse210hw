1. Abstraction
    1.1 Briefly define the principle.
        -   Abstraction simplifies complex
            systems because it models 
            classes based on essential 
            properties like its attributes 
            and hides unecessary details from 
            other classes.


    1.2 How did you use that principle in one of your programs.
        -   
                    public class JournalEntry
            {
                private static List<string> _prompts = new List<string>
                {
                    "Are you happy today?",
                    "Did you make someone smile today?",
                    "Did you eat enough food?",
                    "Did you drink enough water?",
                    "Did you get enough sleep?"
                };

                public static string CreateNewEntry()
                {
                    Random random = new Random();
                    string selectedPrompt = _prompts[random.Next(_prompts.Count)];
                    Console.WriteLine(selectedPrompt);

                    string userResponse = Console.ReadLine();
                    return $"\n>{DateTime.Now}\nPrompt: {selectedPrompt}\nResponse: {userResponse}\n";
                }
            }
            ======================================================
            In the Code Example  the JournalEntryClass abstracts the process of presenting a random prompt for journal entries while CreateNewEntry hides this complexity and only presents the user with a simple interface


    1.3 How did using that principle help that program become more flexible for future changes?
        - Because I made _prompts into a private list
        it can easily add or remove additional prompts
        without altering the main logic of the program.

2. Encapsulation
    2.1 Briefly define the principle.
        -   This principle bundles code 
            (Like attributes, methods or functions)
            that works together in one class 
            and not letting other parts of a 
            program interfere with it. 
            This is done by utalizing 
            a getter to let someone read 
            a value but not change it,
            or use a setter to check
            if a new value is valid 
            before allowing it.
    
    
    2.2 How did you use that principle in one of your programs.
        -   In the wk07 ExerciseTracking assignment
        we used private variables to store data. 
        Specifically _date and _lengthInMinutes
        for the purpose of keeping data or info 
        seperate from the rest of the program.
    
    
    2.3 How did using that principle help that program become more flexible for future changes?
        -   By keeping data and information private
        we ensured that the data can't be accidentally 
        changed or modified. Additionally it makes 
        adding new activities to the program easier as well.



3. Inheritance
    3.1 Briefly define the principle.
        - Inheritance is where a class 
        has default attributes it
         gained from a parent class. 
        This is done by having a child 
        class extend or inherit from the
        parent class using the ":" symbol.


    3.2 How did you use that principle in one of your programs.
        - I used it in the most recent wk07 ExerciseTracking
        assignment by having a base activity cclass
        that child classes inherit attributes from. 


    3.3 How did using that principle help that program become more flexible for future changes?
        -Inhetirance let me reuse the shared
        attributes and methods from the activity
        class for all child/derived classes.




4. Polymorphism
    4.1 Briefly define the principle.
        - Polymorphism allows methods to do different
         things based on the object it is acting upon. 
         In C# and in our class it is achieved through 
         method overriding and interfaces, enabling 
        a single method to have multiple implementations. 
        This allows for more flexible and maintainable code 
        by enabling objects to be treated as instances of
         their parent class rather than their actual class.
    
    
    4.2 How did you use that principle in one of your programs.
        - In the week07 assignment I used polymorphism by
        using the base activity class for every activity class
        and then used overriding methods. Each activity object 
        I called my GetSummary method.
    
    
    4.3 How did using that principle help that program become more flexible for future changes?
        - Polymorphism allowed that all activity objects
        to be treated as such but were still able to act
        or behave differently from each other. This way the
        design allows for extension but not for modification. 