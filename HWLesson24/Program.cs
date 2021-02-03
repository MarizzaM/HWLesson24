using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson24
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary hp = new MyLibrary();

            Book b1 = new Book("Harry Potter and the Philosopher's Stone",
               "Harry Potter has never played a sport while flying on a broomstick. " +
               "He's never worn a Cloak of Invisibility, befriended a half-giant, or helped hatch a dragon. " +
               "All Harry knows is a miserable life with the Dursleys, his horrible aunt and uncle, " +
               "and their abominable son, Dudley. Harry's room is a tiny Cupboard Under the Stairs," +
               " he hasn't had a birthday party in ten years, and his birthday present is his uncle's old socks.",
               "J.K Rowling", "Fantasy");
            Book b2 = new Book("Harry Potter and the Chamber of Secrets",
               "Ever since Harry Potter had come home for the summer, " +
               "the Dursleys had been so mean and hideous that all Harry wanted was to get back " +
               "to the Hogwarts School of Witchcraft and Wizardry. But just as he is packing his bags, " +
               "Harry receives a warning from a strange impish creature who says that if Harry returns to Hogwarts, disaster will strike.",
                "J.K Rowling", "Fantasy");
            Book b3 = new Book("Harry Potter and the Prisoner of Azkaban",
               "Harry Potter is lucky to reach the age of thirteen, since he has already survived the murderous attacks " +
               "of the feared Dark Lord on more than one occasion. But his hopes for a quiet term concentrating on " +
               "Quidditch are dashed when a maniacal mass-murderer escapes from Azkaban, " +
               "pursued by the soul-sucking Dementors who guard the prison.",
                "J.K Rowling", "Fantasy");
            Book b4 = new Book("Harry Potter and the Goblet of Fire",
               "Harry Potter is in his fourth year at Hogwarts. Harry wants to get away from the pernicious Dursleys and " +
               "go to the Quidditch World Cup with Hermione, Ron, and the Weasleys. He wants to find out about " +
               "the mysterious event to take place at Hogwarts this year, an event involving two other rival schools of magic, " +
               "and a competition that hasn't happened for hundreds of years. He wants to be a normal, fourteen-year-old wizard. " +
               "But unfortunately for Harry Potter, " +
               "he's not normal - not even by Wizarding standards. And in his case, different can be deadly..",
                "J.K Rowling", "Fantasy");
            Book b5 = new Book("Harry Potter and the Order of the Phoenix",
               "Harry is in his fifth year at Hogwarts School as the adventures continue. " +
               "There is a door at the end of a silent corridor. And it's haunting Harry Potter's dreams. " +
               "Why else would he be waking in the middle of the night, screaming in terror? Harry has a lot on his mind for this, " +
               "his fifth year at Hogwarts: a Defence Against the Dark Arts teacher with a personality like poisoned honey; " +
               "a big surprise on the Gryffindor Quidditch team; and the looming terror of the Ordinary Wizarding Level exams.",
                "J.K Rowling", "Fantasy");
            Book b6 = new Book("Harry Potter and the Half-Blood Prince",
               "It is Harry Potter 's sixth year at Hogwarts School of Witchcraft and Wizardry. As Voldemort's sinister forces amass and " +
               "a spirit of gloom and fear sweeps the land, it becomes more and more clear to Harry " +
               "that he will soon have to confront his destiny. But is he up to the challenges ahead of him?",
                "J.K Rowling", "Fantasy");
            Book b7 = new Book("Harry Potter and the Deathly Hallows",
               "Harry is waiting in Privet Drive. The Order of the Phoenix is coming to escort him safely away without Voldemort " +
               "and his supporters knowing - if they can. But what will Harry do then? " +
               "How can he fulfil the momentous and seemingly impossible task that Professor Dumbledore has left him?",
                "J.K Rowling", "Fantasy");

            hp.AddBook(b1);
            hp.AddBook(b2);
            hp.AddBook(b3);
            hp.AddBook(b4);
            hp.AddBook(b5);
            hp.AddBook(b6);
            hp.AddBook(b7);

            Console.WriteLine(hp);

        }
    }
}
