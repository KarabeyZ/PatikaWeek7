using PratikLinqJoin;

// Liste oluşturuldu elemanlar eklendi
List<Author> authors = new List<Author>()
{
    new Author()
    {
        AuthorId = 1, Name = "Frank Herbert"
    },
    new Author()
    {
        AuthorId = 2, Name = "J. K. Rowling"
    },
    new Author()
    {
        AuthorId = 3, Name = "J. R. R. Tolkien"
    },
};
// kitap listesi oluşturuldu elemanlar eklendi
List<Book> books = new List<Book>()
{
    new Book()
    {
        BookId = 1, AuthorId = 1, Title = "Dune"
    },
    new Book()
    {
        BookId = 2, AuthorId = 1, Title = "Dune Mesihi"
    },
    new Book()
    {
        BookId = 3, AuthorId = 2, Title = "Harry Potter"
    },
    new Book()
    {
        BookId = 4, AuthorId = 3, Title = "Lord Of The Rings"
    },

};

//iki farklı yöntemle yapıldı

//var authorBook = books.Join(authors,
//                              book => book.AuthorId,
//                              author => author.AuthorId,
//                              (book,author) =>new
//                              {
//                                  AuthorName = author.Name,
//                                  BookTitle = book.Title
//                              });


//foreach (var authorwithbooks in authorBook)
//{
//    Console.WriteLine($"Kitap: {authorwithbooks.BookTitle} Yazar: {authorwithbooks.AuthorName}");
//}

//tablo birleştirme 
var authorBook = from book in books
                 join author in authors on book.AuthorId equals author.AuthorId
                 select new
                 {
                     AuthorName = author.Name,
                     BookTitle = book.Title
                 };
//ekrana yazdırma 
foreach (var authorwithbooks in authorBook)
{
    Console.WriteLine($"Kitap: {authorwithbooks.BookTitle} Yazar: {authorwithbooks.AuthorName}");
}