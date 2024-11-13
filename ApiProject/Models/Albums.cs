namespace ApiProject.Models
{
    public class Albums
    {

        public  int Id { get; set; }
        public int? Number { get; set; } // Book number
        public string? Title { get; set; } // Title of the book in selected language
        public string? OriginalTitle { get; set; } // Original book title in English
        public string? ReleaseDate { get; set; } // Release date of the book
        public string? Description { get; set; } // Summary of the book
        public int? Pages { get; set; } // Original number of pages in the book
        public string? Cover { get; set; }

    }
}
