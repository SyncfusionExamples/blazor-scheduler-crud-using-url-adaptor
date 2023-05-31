namespace Url_Adaptor.Models
{
    public static class DataSource
    {
        private static IList<Event>? _eventsData { get; set; }

        public static IList<Event> GetEvents()
        {
            if (_eventsData != null)
            {
                return _eventsData;
            }

            _eventsData = new List<Event>();

            Event related = new Event
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(2022, 12, 5, 9, 30, 0),
                EndTime = new DateTime(2022, 12, 5, 11, 0, 0),
                OwnerId = 1
            };
            _eventsData.Add(related);

            Event events = new Event
            {
                Id = 2,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(2022, 12, 6, 12, 0, 0),
                EndTime = new DateTime(2022, 12, 6, 14, 0, 0),
                OwnerId = 2
            };
            _eventsData.Add(events);

            events = new Event
            {
                Id = 3,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(2022, 12, 7, 9, 30, 0),
                EndTime = new DateTime(2022, 12, 7, 11, 0, 0),
                OwnerId = 3
            };
            _eventsData.Add(events);

            events = new Event
            {
                Id = 4,
                Subject = "Meteor Showers in 2018",
                Location = "Space Centre USA",
                StartTime = new DateTime(2022, 12, 8, 13, 0, 0),
                EndTime = new DateTime(2022, 12, 8, 14, 30, 0),
                OwnerId = 1
            };
            _eventsData.Add(events);

            events = new Event
            {
                Id = 5,
                Subject = "Milky Way as Melting pot",
                Location = "Space Centre USA",
                StartTime = new DateTime(2022, 12, 9, 12, 0, 0),
                EndTime = new DateTime(2022, 12, 9, 14, 0, 0),
                OwnerId = 2
            };
            _eventsData.Add(events);

            events = new Event
            {
                Id = 6,
                Subject = "Mysteries of Bermuda Triangle",
                Location = "Bermuda",
                StartTime = new DateTime(2022, 12, 9, 9, 30, 0),
                EndTime = new DateTime(2022, 12, 9, 11, 0, 0),
                OwnerId = 3
            };
            _eventsData.Add(events);

            events = new Event
            {
                Id = 7,
                Subject = "Glaciers and Snowflakes",
                Location = "Himalayas",
                StartTime = new DateTime(2022, 12, 10, 11, 0, 0),
                EndTime = new DateTime(2022, 12, 10, 12, 30, 0),
                OwnerId = 1
            };
            _eventsData.Add(events);

            events = new Event
            {
                Id = 8,
                Subject = "Life on Mars",
                Location = "Space Centre USA",
                StartTime = new DateTime(2022, 12, 11, 9, 0, 0),
                EndTime = new DateTime(2022, 12, 11, 10, 0, 0),
                OwnerId = 2
            };
            _eventsData.Add(events);

            events = new Event
            {
                Id = 9,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(2022, 12, 13, 11, 0, 0),
                EndTime = new DateTime(2022, 12, 13, 13, 0, 0),
                OwnerId = 3
            };
            _eventsData.Add(events);

            return _eventsData;
        }
    }
}
