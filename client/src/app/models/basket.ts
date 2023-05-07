export interface BasketItem {
    productId: number;
    name: string;
    price: number;
    pictureUrl: string;
    author: string;
    genre: string;
    quantity: number;
  }
export interface Basket {
    id: number;
    buyerId: string;
    items: BasketItem[];
  }