/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
	var library = (function() {
		var books = [];
		var categories = [];

		function listBooks(book) {
			if (arguments.length > 0) {
				if (typeof book.category !== 'undefined') {
					if (typeof categories[book.category] !== 'undefined') {
						return categories[book.category].books;
					} else {
						return [];
					}
				}
				if (typeof book.author !== 'undefined') {
					var booksList = [],
						i,
						len;
					for (i = 0, len = books.length; i < len; i += 1) {
						if (books[i].author === book.author) {
							booksList.push(books[i]);
						}
					}

					return booksList;
				}
			}

			return books;
		}

		function bookAlreadyAdded(name, type) {
			var i,
				len;

			for (i = 0, len = books.length; i < len; i += 1) {
				if (books[i][type] === name) {
					return true;
				}
			}

			return false;
		}

		function addCategory(name) {
			categories[name] = {
				books: [],
				ID: categories.length + 1
			};
		}

		function validateAuthor(author) {
			if (author.trim() === '') {
				throw new Error('Author cannot be empty');
			}
		}

		function validateISBN(isbn) {
			if (isbn.length !== 10 && isbn.length !== 13) {
				throw new Error('ISBN must contain 10 or 13 digits');
			}

			if (!/^[0-9]+$/.test(isbn.toString())) {
				throw new Error('ISBN must contain only digits');
			}
		}

		function validateBookAndCategoryName(name) {
			if (name.length < 2 || name.length > 100) {
				throw new Error('Name must be between 2 and 100 symbols');
			}
		}

		function checkBookParameters(book, argumentsLength) {
			if (Object.keys(book).length !== argumentsLength) {
				throw new Error();
			}
			for (var parameter in book) {
				if (typeof book[parameter] === 'undefined') {
					throw new Error(parameter + 'cannot be undefined');
				}
			}
		}

		function addBook(book) {
			book.ID = books.length + 1;

			checkBookParameters(book, 5);

			if (bookAlreadyAdded(book.title, 'title')) {
				throw new Error('Book with the same title already exists');
			}

			if (bookAlreadyAdded(book.isbn, 'isbn')) {
				throw new Error('Book with the same isbn already exists');
			}

			if (categories.indexOf(book.category) < 0) {
				addCategory(book.category);
			}

			validateAuthor(book.author);
			validateISBN(book.isbn);
			validateBookAndCategoryName(book.title);
			validateBookAndCategoryName(book.category);

			categories[book.category].books.push(book);
			books.push(book);
			return book;
		}

		function listCategories(category) {
			var categoriesNames = [];

			Array.prototype.push.apply(categoriesNames, Object.keys(categories))

			return categoriesNames;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	}());
	return library;
}
module.exports = solve;