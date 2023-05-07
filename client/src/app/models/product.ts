export interface Product {
    id:number;
    name: string;
    description: string;
    price:number;
    pictureUrl: string;
    genre?: string;
    author: string;
    quantityInStock?:number;
}