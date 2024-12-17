using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repositroy)
        {
            _repository = repositroy;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            values.CarID = command.CarID;
            values.BrandID = command.BrandID;
            values.Fuel = command.Fuel;
            values.Km = command.Km;
            values.Seat = command.Seat;
            values.BigImageUrl = command.BigImageUrl;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Transmission = command.Transmission; 
            values.Luggage = command.Luggage;
            values.Model  = command.Model;
            await _repository.UpdateAsync(values);
        }
    }
}
