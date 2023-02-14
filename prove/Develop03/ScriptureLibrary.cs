using System;

class ScriptureLibrary
{
    public List<Scripture> scripList = new List<Scripture>();
    
    public void CreateScripture()
    {
        Reference reference;
        string scriptureStr;
        Console.Write("How many verses are in the reference? ");
        int vrseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter a book: ");
        string book = Console.ReadLine();

        Console.Write("Please enter a chapter: ");
        int chapter = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter a start verse: ");
        int startVerse = Convert.ToInt32(Console.ReadLine());
        
        if (vrseNum > 1)
        {
            Console.Write("Please enter a end verse: ");
            int endVerse = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a scripture: ");
            scriptureStr = Console.ReadLine();
            reference = new Reference(book, chapter, startVerse, endVerse);
        }

        else
        {
            Console.Write("Please enter a scripture: ");
            scriptureStr = Console.ReadLine();
            reference = new Reference(book, chapter, startVerse);
        }
        
        Console.WriteLine("\nThe scriptures in the list are shown below.");
        Console.WriteLine();

        Scripture scripture = new Scripture(reference, scriptureStr);
        scripList.Add(scripture);
    }

    public void BuildScripture()
    {
        Console.WriteLine("Three scriptures are shown below.");
        Console.WriteLine();

        Reference ref1 = new Reference("1 Nephi", 3, 7);
        Scripture scrip1 = new Scripture(ref1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        scripList.Add(scrip1);

        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scrip2 = new Scripture(ref2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        scripList.Add(scrip2);

        Reference ref3 = new Reference("Alma", 37, 35, 36);
        Scripture scrip3 = new Scripture(ref3, "O, remember, my son, and learn bwisdom in thy youth; yea, learn in thy youth to keep the commandments of God. Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, and whithersoever thou goest let it be in the Lord; yea, let all thy thoughts be directed unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever.");
        scripList.Add(scrip3);
    }
}