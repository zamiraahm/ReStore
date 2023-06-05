    using API.DTOs;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class BasketExtensions
    {
        public static BasketDto MapBasketToDto(this Basket basket)
        {
            if (basket == null)
    {
        return null; 
    }

              return new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                Items = basket.Items.Select(item => new BasketItemDto
                {
                    ProductId = item.ProductId,
                    Name = item.Product?.Name,
                    Price = (long)(item.Product?.Price ?? 0),
                    PictureUrl = item.Product?.PictureUrl,
                    Genre = item.Product?.Genre,
                    Author = item.Product?.Author,
                    Quantity = item.Quantity
                }).ToList()
            };
        }

        public static IQueryable<Basket> RetrieveBasketWithItems(this IQueryable<Basket> query, string buyerId)
        {
            return query.Include( i => i.Items)
            .ThenInclude(p => p.Product).Where(b=>b.BuyerId == buyerId);
                 
        }
    }
}