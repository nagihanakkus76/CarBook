﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.BlogDtos
{
    public class GetBlogByIdDto
    {
        public int BlogId { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
