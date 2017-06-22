using System;
using System.Linq;
using System.Web.UI.WebControls.WebParts;
using LegacyProject.DataLayer;

namespace LegacyProject.BookSigning
{
    public class Appearance
    {
        private readonly string _venue;
        private readonly DateTime _startDateTime;
        private readonly DateTime _endDateTime;
        private readonly Author _appearingAuthor;
        private const int EventDuration = 3;
        public Appearance(string venue, DateTime appearanceDateTime, Author author)
        {
            _venue = venue;
            _startDateTime = appearanceDateTime;
            _endDateTime = appearanceDateTime.AddHours(EventDuration);

            if (author == null || !author.IsActive )
            {
                _appearingAuthor = AuthorRepository.GetInstance().Authors.First(a => a.IsActive);
            }

            _appearingAuthor = author;
        }

        public string Venue
        {
            get { return _venue; }
        }

        public DateTime StartDateTime
        {
            get { return _startDateTime; }
        }

        public DateTime EndDateTime
        {
            get { return _endDateTime; }
        }

        public Author AppearingAuthor
        {
            get { return _appearingAuthor; }
        }
    }
}