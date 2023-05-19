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

export interface ProductParams{
    orderBy: string;
    searchTerm?: string;
    genres: string[];
    authors: string[];
    pageNumber:number;
    pageSize:number;
}