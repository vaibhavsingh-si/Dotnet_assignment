using System;
using System.Collections.Generic;
using System.Linq;

namespace SportzClubManagement
{
    class Athlete
    {
        public int AthleteId { get; private set; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string Sport { get; }
        public DateTime RegistrationDate { get; }

        private static int nextAthleteId = 1;

        public Athlete(string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            AthleteId = nextAthleteId++;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sport = sport;
            RegistrationDate = registrationDate;
        }
    }

    class Event
    {
        public int EventId { get; private set; }
        public string EventName { get; }
        public string EventType { get; }
        public DateTime EventDate { get; }

        private static int nextEventId = 1;

        public Event(string eventName, string eventType, DateTime eventDate)
        {
            EventId = nextEventId++;
            EventName = eventName;
            EventType = eventType;
            EventDate = eventDate;
        }
    }

    class SportzClub
    {
        private List<Athlete> athletes;
        private List<Event> events;

        public SportzClub()
        {
            athletes = new List<Athlete>();
            events = new List<Event>();
        }

        public void RegisterAthlete(Athlete athlete)
        {
            athletes.Add(athlete);
        }

        public Athlete GetAthlete(int athleteId)
        {
            return athletes.FirstOrDefault(a => a.AthleteId == athleteId);
        }

        public void CreateEvent(Event newEvent)
        {
            events.Add(newEvent);
        }

        public Event GetEvent(int eventId)
        {
            return events.FirstOrDefault(e => e.EventId == eventId);
        }

        // Other methods for performance tracking and data analysis can be added here
    }

    class Program
    {
        static void Main(string[] args)
        {
            SportzClub club = new SportzClub();

            Athlete athlete1 = new Athlete("John", "Doe", 25, "Basketball", new DateTime(2023, 1, 15));
            Athlete athlete2 = new Athlete("Jane", "Smith", 30, "Soccer", new DateTime(2023, 2, 10));
            club.RegisterAthlete(athlete1);
            club.RegisterAthlete(athlete2);

            Event event1 = new Event("Basketball Tournament", "Tournament", new DateTime(2023, 3, 20));
            Event event2 = new Event("Soccer Practice", "Practice", new DateTime(2023, 3, 25));
            club.CreateEvent(event1);
            club.CreateEvent(event2);

            Athlete retrievedAthlete = club.GetAthlete(1);
            Event retrievedEvent = club.GetEvent(1);

            if (retrievedAthlete != null)
            {
                Console.WriteLine($"Athlete: {retrievedAthlete.FirstName} {retrievedAthlete.LastName}");
            }
            else
            {
                Console.WriteLine("Athlete not found.");
            }

            if (retrievedEvent != null)
            {
                Console.WriteLine($"Event: {retrievedEvent.EventName}");
            }
            else
            {
                Console.WriteLine("Event not found.");
            }
        }
    }
}
