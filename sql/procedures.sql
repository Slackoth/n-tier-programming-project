create or alter procedure sign_in_user
@email varchar(50), @password varchar(50)
as
select users_id, first_name, last_name, email, user_role
from users where email = @email and user_psswd = @password
go;

create or alter procedure list_all_books
as
select b.book_id, b.title, CONCAT(a.first_name, ' ', a.last_name) as 'author' ,  e.editorial_name,
c.country_name, l.language_name, s.subject_name, b.ubication
from books b inner join editorials e
on b.editorial_id = e.editorial_id inner join country c
on b.countries_id = c.country_id inner join languages l
on b.languages_id = l.language_id inner join subjects s
on b.subject_id = s.subjects_id inner join authors_books ab
on b.book_id = ab.books_id inner join authors a
on a.authors_id = ab.authors_id
order by b.book_id asc
go;

create or alter procedure search_books_by_title
@value varchar(255)
as
select b.book_id, b.title, CONCAT(a.first_name, ' ', a.last_name) as 'author' ,  e.editorial_name,
c.country_name, l.language_name, s.subject_name, b.ubication
from books b inner join editorials e
on b.editorial_id = e.editorial_id inner join country c
on b.countries_id = c.country_id inner join languages l
on b.languages_id = l.language_id inner join subjects s
on b.subject_id = s.subjects_id inner join authors_books ab
on b.book_id = ab.books_id inner join authors a
on a.authors_id = ab.authors_id
where b.title like '%' + @value + '%'
order by b.title asc
go;

create or alter procedure search_books_by_author
@value varchar(255)
as
select b.book_id, b.title, CONCAT(a.first_name, ' ', a.last_name) as 'author' ,  e.editorial_name,
c.country_name, l.language_name, s.subject_name, b.ubication
from books b inner join editorials e
on b.editorial_id = e.editorial_id inner join country c
on b.countries_id = c.country_id inner join languages l
on b.languages_id = l.language_id inner join subjects s
on b.subject_id = s.subjects_id inner join authors_books ab
on b.book_id = ab.books_id inner join authors a
on a.authors_id = ab.authors_id
where a.first_name like '%' + @value + '%' or a.last_name like '%' + @value + '%'
order by a.first_name asc
go;

create or alter procedure search_books_by_editorial
@value varchar(255)
as
select b.book_id, b.title, CONCAT(a.first_name, ' ', a.last_name) as 'author' ,  e.editorial_name,
c.country_name, l.language_name, s.subject_name, b.ubication
from books b inner join editorials e
on b.editorial_id = e.editorial_id inner join country c
on b.countries_id = c.country_id inner join languages l
on b.languages_id = l.language_id inner join subjects s
on b.subject_id = s.subjects_id inner join authors_books ab
on b.book_id = ab.books_id inner join authors a
on a.authors_id = ab.authors_id
where e.editorial_name like '%' + @value + '%'
order by e.editorial_name asc
go;

create or alter procedure search_books_by_country
@value varchar(255)
as
select b.book_id, b.title, CONCAT(a.first_name, ' ', a.last_name) as 'author' ,  e.editorial_name,
c.country_name, l.language_name, s.subject_name, b.ubication
from books b inner join editorials e
on b.editorial_id = e.editorial_id inner join country c
on b.countries_id = c.country_id inner join languages l
on b.languages_id = l.language_id inner join subjects s
on b.subject_id = s.subjects_id inner join authors_books ab
on b.book_id = ab.books_id inner join authors a
on a.authors_id = ab.authors_id
where c.country_name like '%' + @value + '%'
order by c.country_name asc
go;

create or alter procedure search_books_by_language
@value varchar(255)
as
select b.book_id, b.title, CONCAT(a.first_name, ' ', a.last_name) as 'author' ,  e.editorial_name,
c.country_name, l.language_name, s.subject_name, b.ubication
from books b inner join editorials e
on b.editorial_id = e.editorial_id inner join country c
on b.countries_id = c.country_id inner join languages l
on b.languages_id = l.language_id inner join subjects s
on b.subject_id = s.subjects_id inner join authors_books ab
on b.book_id = ab.books_id inner join authors a
on a.authors_id = ab.authors_id
where l.language_name like '%' + @value  + '%'
order by l.language_name asc
go;

create or alter procedure search_books_by_subject
@value varchar(255)
as
select b.book_id, b.title, CONCAT(a.first_name, ' ', a.last_name) as 'name' ,  e.editorial_name,
c.country_name, l.language_name, s.subject_name, b.ubication
from books b inner join editorials e
on b.editorial_id = e.editorial_id inner join country c
on b.countries_id = c.country_id inner join languages l
on b.languages_id = l.language_id inner join subjects s
on b.subject_id = s.subjects_id inner join authors_books ab
on b.book_id = ab.books_id inner join authors a
on a.authors_id = ab.authors_id
where s.subject_name like '%' + @value + '%'
order by s.subject_name asc
go;