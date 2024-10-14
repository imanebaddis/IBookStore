using Domain.entities;

namespace Infrastructure.Repositories
{
    /// <summary>
    /// Interface for book repository, defining the basic operations for managing books.
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Adds a new book to the repository.
        /// </summary>
        /// <param name="book">The book to be added.</param>
        void Add(Book book);

        /// <summary>
        /// Updates an existing book in the repository.
        /// </summary>
        /// <param name="book">The book with updated details.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        bool Update(Book book);

        /// <summary>
        /// Deletes a book from the repository by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the book to delete.</param>
        /// <returns>True if the deletion was successful; otherwise, false.</returns>
        bool Delete(int id);

        /// <summary>
        /// Gets a book from the repository by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <returns>The book with the specified ID, or null if not found.</returns>
        Book GetById(int id);

        /// <summary>
        /// Retrieves all books from the repository.
        /// </summary>
        /// <returns>A list of all books in the repository.</returns>
        IEnumerable<Book> GetAll();
    }
}