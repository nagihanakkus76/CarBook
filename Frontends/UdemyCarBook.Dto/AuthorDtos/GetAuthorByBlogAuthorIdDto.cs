﻿namespace UdemyCarBook.Dto.AuthorDtos
{
    public class GetAuthorByBlogAuthorIdDto
    {
        public int BlogId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }   
        public string AuthorImageUrl { get; set; }
        public int AuthorId { get; set; }
    }
}
