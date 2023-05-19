using API.Entities;

namespace API.Extensions
{
    public static class ProductExtensions
    {
        public static IQueryable<Product>Sort(this IQueryable<Product> query, string orderBy)
        {
            if(string.IsNullOrWhiteSpace(orderBy)) return query.OrderBy(p => p.Name);
             query = orderBy switch
            {
                "price" => query.OrderBy(p => p.Price),
                "priceDesc" => query.OrderByDescending(p => p.Price),
                _=>query.OrderBy(p => p.Name)
            };
            return query;
        }
        public static IQueryable<Product> Search(this IQueryable<Product> query, string searchTerm)
        {
            if(string.IsNullOrEmpty(searchTerm)) return query;
            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
            return query.Where(p=>p.Name.ToLower().Contains(lowerCaseSearchTerm));
        }
        public static IQueryable<Product>Filter(this IQueryable<Product> query, string authors, string genres)
        {
            var authorList=new List<string>();
            var genreList= new List<string>();

            if(!string.IsNullOrEmpty(authors))
            authorList.AddRange(authors.ToLower().Split(".").ToList());

            if(!string.IsNullOrEmpty(genres))
            genreList.AddRange(genres.ToLower().Split(".").ToList());

            query = query.Where(p=>authorList.Count==0 || authorList.Contains(p.Author.ToLower()));
            query = query.Where(p=>genreList.Count==0 || genreList.Contains(p.Genre.ToLower()));

            return query;
            
        }
    }
}