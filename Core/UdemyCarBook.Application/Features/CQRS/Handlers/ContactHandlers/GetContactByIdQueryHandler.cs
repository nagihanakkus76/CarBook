﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Queries.ContactQueries;
using UdemyCarBook.Application.Features.CQRS.Results.ContactResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repositroy)
        {
            _repository = repositroy;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                ContactID = value.ContactID,
                Name = value.Name,
                Email = value.Email,
                SendDate = value.SendDate,
                Subject = value.Subject,
                Message = value.Message,
            };
        }
    }
}
