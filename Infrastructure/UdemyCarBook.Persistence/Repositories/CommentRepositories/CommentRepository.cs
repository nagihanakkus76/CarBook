﻿using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
           _context.Comments.Add(entity);
           _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
           return _context.Comments.Select(x => new Comment
           {
               Id = x.Id,
               BlogId = x.BlogId,
               CreatedDate = x.CreatedDate,
               Description = x.Description,
               Name = x.Name
           }).ToList();
        }

        public Comment GetById(int id)
        {
           return _context.Comments.Find(id);
        }

        public void Remove(int id)
        {
           var value = _context.Comments.Find(id);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

        public void Update(Comment entity)
        {
           _context.Comments.Update(entity);
            _context.SaveChanges();
        }
    }
}
