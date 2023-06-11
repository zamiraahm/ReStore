using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pas$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com",   
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin , new[] {"Member", "Admin"});
            }


            if(context.Products.Any()) return;

            var products = new List<Product>
            {
             	new Product
                {
                    Name = "Percy Jackson and The Olympians-The Lightning Thief",
                    Description =
                        "Twelve-year-old Percy Jackson is on the most dangerous quest of his life. With the help of a satyr and a daughter of Athena, Percy must journey across the United States to catch a thief who has stolen the original weapon of mass destruction — Zeus’ master bolt. Along the way, he must face a host of mythological enemies determined to stop him. Most of all, he must come to terms with a father he has never known, and an Oracle that has warned him of betrayal by a friend.",
                    Price = 200,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Author = "Rick Riordan",
                    Genre = "Fantasy",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Godather",
                    Description = "The Godfather is a crime novel by American author Mario Puzo. Originally published in 1969 by G. P. Putnam's Sons, the novel details the story of a fictional Mafia family in New York City (and Long Island), headed by Vito Corleone, the Godfather.",
                    Price = 150,
                    PictureUrl = "/images/products/sb-ang2.png",
                    Author = "Mario Puzo",
                    Genre = " Crime novel",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Harry Potter and the Philosopher's Stone",
                    Description =
                        "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry.",
                    Price = 180,
                    PictureUrl = "/images/products/sb-core1.png",
                    Author = "J.K. Rowling",
                    Genre = "Fantasy",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "To Kill a Mockingbird",
                    Description =
                        "To Kill a Mockingbird is a novel by the American author Harper Lee. It was published in 1960 and was instantly successful. In the United States, it is widely read in high schools and middle schools. To Kill a Mockingbird has become a classic of modern American literature; a year after its release, it won the Pulitzer Prize.",
                    Price = 300,
                    PictureUrl = "/images/products/sb-core2.png",
                    Author = "	Harper Lee",
                    Genre = "Southern Gothic-Bildungsroman",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The C Programming Language",
                    Description =
                        "The C Programming Language (sometimes termed K&R, after its authors' initials) is a computer programming book written by Brian Kernighan and Dennis Ritchie, the latter of whom originally designed and implemented the language, as well as co-designed the Unix operating system with which development of the language was closely intertwined. The book was central to the development and popularization of the C programming language and is still widely read and used today.",
                    Price = 250,
                    PictureUrl = "/images/products/sb-react1.png",
                    Author = "Brian Kernighan-Dennis Ritchie",
                    Genre = "Programming Language",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Introduction to Git and Github",
                    Description =
                        "A beginner friendly guide to using git and working with Github.com. This book is for the absolute beginner and provides a gentle introduction to git and Github. Get a jump start using git on your projects, and learn how to push those projects to Github.com",
                    Price = 120,
                    PictureUrl = "/images/products/sb-ts1.png",
                    Author = "Launch School",
                    Genre = "Study",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Shady Hollow- A Murder Mystery",
                    Description =
                        "The first book in the Shady Hollow series, in which we are introduced to the village of Shady Hollow, a place where woodland creatures live together in harmony--until a curmudgeonly toad turns up dead and the local reporter has to solve the case.",
                    Price = 100,
                    PictureUrl = "/images/products/hat-core1.png",
                    Author = "Juneau Black",
                    Genre = "Fantasy-Mystery",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Harry Potter and the Deathly Hallows",
                    Description =
                        "Harry Potter and the Deathly Hallows is a fantasy novel written by British author J. K. Rowling and the seventh and final novel in the Harry Potter series. It was released on 21 July 2007 in the United Kingdom by Bloomsbury Publishing, in the United States by Scholastic, and in Canada by Raincoast Books.",
                    Price = 200,
                    PictureUrl = "/images/products/hat-react1.png",
                    Author = "J. K. Rowling",
                    Genre = "Fantasy",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Harry Potter and the Chamber of Secrets",
                    Description =
                        "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the Chamber of Secrets has been opened and that the heir of Slytherin would kill all pupils who do not come from all-magical families",
                    Price = 150,
                    PictureUrl = "/images/products/hat-react2.png",
                    Author = "J. K. Rowling",
                    Genre = "Fantasy",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Harry Potter and the Chamber of Secrets",
                    Description =
                        "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the Chamber of Secrets has been opened and that the heir of Slytherin would kill all pupils who do not come from all-magical families.",
                    Price = 180,
                    PictureUrl = "/images/products/glove-code1.png",
                    Author = "J. K. Rowling",
                    Genre = "Fantasy",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "A Brief History of Time",
                    Description =
                        "A Brief History of Time: From the Big Bang to Black Holes is a book on theoretical cosmology by English physicist Stephen Hawking. It was first published in 1988. Hawking wrote the book for readers who had no prior knowledge of physics.",
                    Price = 150,
                    PictureUrl = "/images/products/glove-code2.png",
                    Author = "Stephen Hawking",
                    Genre = "Cosmology",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brief Answers to the Big Questions",
                    Description =
                        "Brief Answers to the Big Questions is a popular science book written by physicist Stephen Hawking, and published by Hodder & Stoughton (hardcover) and Bantam Books (paperback) on 16 October 2018. The book examines some of the universe's greatest mysteries, and promotes the view that science is very important in helping to solve problems on planet Earth.",
                    Price = 160,
                    PictureUrl = "/images/products/glove-react1.png",
                    Author = "Stephen Hawking",
                    Genre = "Nonfiction, Science",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dune",
                    Description =
                        "Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune saga. In 2003, it was described as the world's best-selling science fiction novel.",
                    Price = 140,
                    PictureUrl = "/images/products/glove-react2.png",
                    Author = "Frank Herbert",
                    Genre = "Science fiction",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Avengers",
                    Description =
                        "The Avengers is the name of several comic book titles featuring the team the Avengers and published by Marvel Comics, beginning with the original The Avengers comic book series which debuted in 1963.",
                    Price = 250,
                    PictureUrl = "/images/products/boot-redis1.png",
                    Author = "Marvel Comics",
                    Genre = "Superhero",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Amazing Spider-Man",
                    Description =
                        "Swing into action with your favorite friendly neighborhood super hero, Spider-Man! Learn all about his super-powers, friends, and arch-nemeses in this bright and bold board book, with art from the classic comics by John Romita, Sr. Bright colors and three special gatefolds make for a fun-filled read perfect for the youngest kids and long-time Marvel fans alike.",
                    Price = 120,
                    PictureUrl = "/images/products/boot-core2.png",
                    Author = "Marvel Comics",
                    Genre = "Superhero",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dark Poems",
                    Description =
                        "A collection for love dark poems.",
                    Price = 190,
                    PictureUrl = "/images/products/boot-core1.png",
                    Author = "Unknown",
                    Genre = "Poems",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Last Episodes",
                    Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy",
                    Price = 150,
                    PictureUrl = "/images/products/boot-ang2.png",
                    Author = "Raja Shah",
                    Genre = "Manga",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dark Mystery",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 180,
                    PictureUrl = "/images/products/boot-ang1.png",
                    Author = "The wolfy",
                    Genre = "Mystery-Crime",
                    QuantityInStock = 100
                },
            } ;

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}