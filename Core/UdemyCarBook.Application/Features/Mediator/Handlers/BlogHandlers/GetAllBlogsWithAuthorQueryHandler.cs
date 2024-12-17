using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler :IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

	public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
	{
		_repository = repository;
	}

		public async Task<List<GetAllBlogWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetAllBlogsWithAuthors();
			return values.Select(x => new GetAllBlogWithAuthorQueryResult
			{
				BlogId = x.BlogId,
				AuthorId = x.AuthorId,
				CategoryId = x.CategoryId,
				CoverImageUrl = x.CoverImageUrl,
				Title = x.Title,
				CreatedDate = x.CreatedDate,
				AuthorName = x.Author.Name,
				Description = x.Description,
				AuthorDescription = x.Author.Description,
				AuthorImageUrl = x.Author.ImageUrl,
			}).ToList();
		}
	}
}
