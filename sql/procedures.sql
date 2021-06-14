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

create or alter procedure list_all_teachers
as
select users_id, first_name, last_name, email from users where user_role = 0
go

create or alter procedure search_teachers_by_name
@value varchar(255)
as
select users_id, first_name, last_name, email 
from users where user_role = 0 and (first_name like '%' + @value + '%'
or last_name like '%' + @value + '%')
go

create or alter procedure list_teacher_loans
@id int
as
select l.loan_id, b.title, l.loan_date, l.loan_devolution
from loans l inner join copies c
on l.copies_id = c.copies_id inner join users u
on l.users_id = u.users_id inner join books b
on c.books_id = b.book_id
where u.users_id = @id and l.returned = 0;
go

create or alter procedure search_teacher_loans
@id int, @date date
as
select l.loan_id, b.title, l.loan_date, l.loan_devolution
from loans l inner join copies c
on l.copies_id = c.copies_id inner join users u
on l.users_id = u.users_id inner join books b
on c.books_id = b.book_id
where u.users_id = @id and l.returned = 0 and l.loan_devolution = @date;
go

create or alter procedure is_book_loanable
@id int, @loanable bit output
as
declare @available int;
declare @loaned int;
declare @total int;

select @available = COUNT(c.copies_id)
from books b inner join copies c
on b.book_id = c.books_id 
where b.book_id = @id and c.copie_state = 1;

select @loaned = COUNT(c.copies_id)
from books b inner join copies c
on b.book_id = c.books_id left join loans l
on c.copies_id = l.copies_id
where b.book_id = @id and c.copie_state = 1 and l.returned = 0;

set @total = @available - @loaned;

if(ABS(@total) > 1)
begin;
set @loanable = 1;
end;
else
begin;
set @loanable = 0;
end;
go

create or alter procedure get_loanable_books
@id int
as
select c.copies_id
from books b inner join copies c
on b.book_id = c.books_id left join loans l
on c.copies_id = l.copies_id
where b.book_id = @id and c.copie_state = 1 and (l.returned is null or l.returned = 1);
go

create or alter procedure teacher_has_loaned_book
@bookId int, @teacherId int
as
select c.copies_id
from books b inner join copies c
on b.book_id = c.books_id inner join loans l
on c.copies_id = l.copies_id inner join users u
on l.users_id = u.users_id
where b.book_id = @bookId and u.users_id = @teacherId and l.returned = 0 ;
go

create or alter procedure insert_loan
@loanDate date, @returnDate date, @copyId int, @teacherId int
as
insert into loans(loan_date, loan_devolution, returned, copies_id, users_id) 
values(@loanDate, @returnDate,0,@copyId, @teacherId);
go


--CRUD BOOKS
create or alter procedure list_all_books
	as 
	select* from dbo.books;
	go

create or alter procedure insert_book
	@title varchar(250),@quantity int, @isbn varchar(18), @no_edition int, @no_pages int, @ubication varchar(50), @bookdesc varchar(350), @editorial_id int, @countries_id int,@languages_id int,@subject_id int 
	as 
	insert into books(title, quantity, isbn, no_edition, no_pages,ubication,bookdescription, editorial_id, countries_id, languages_id, subject_id) 
	values(@title, @quantity, @isbn, @no_edition, @no_pages, @ubication, @bookdesc, @editorial_id, @countries_id, @languages_id, @subject_id)
	go


exec insert_book @title='hola', @quantity=2,@isbn='356-643-132',@no_edition=2,@no_pages=3,@ubication='more', @bookdesc='es un libro',@editorial_id=2, @countries_id=2,@languages_id=2, @subject_id= 2;

	select * from copies


	

create or alter procedure list_authors
as
select a.authors_id as id,concat(a.first_name,' ',a.last_name) as names from authors a
go



create or alter procedure list_editorials
as
select e.editorial_id as id, e.editorial_name as names from editorials e
go

create or alter procedure list_languages
as 
select l.language_id as id, l.language_name as names from languages l
go

create or alter procedure list_subjects
as
select s.subjects_id as id, s.subject_name as names from subjects s
go

exec list_subjects

create or alter procedure list_countries
as
select c.country_id as id, c.country_name as names from country c
go

create or alter procedure delete_book
@id_book int
as
delete from authors_books where books_id=@id_book
delete from copies where books_id=@id_book
delete from books where book_id=@id_book 
go

select * from copies

create or alter procedure book_getid
@title varchar(150)
as
select book_id as id from books where title= @title
go


create or alter procedure insert_authorsxbooks
@bookid int, @authorsid int
as
insert into authors_books(books_id, authors_id) values(@bookid, @authorsid);


create or alter procedure insert_copies
@bookid int
as 
insert into copies(books_id,copie_state) values(@bookid, 0)
go



create or alter procedure searchbook_update
@value varchar(150)
as
select b.book_id, b.title, b.isbn, b.no_edition,b.no_pages,b.quantity, b.ubication, b.bookdescription, b.editorial_id, b.countries_id, b.languages_id, b.subject_id, ab.authors_id from books b left join authors_books ab on ab.books_id= b.book_id where b.title=@value
go

exec searchbook_update @value='nel'

select*from books


create or alter procedure update_book


@id int, @title varchar(250),@quantity int, @isbn varchar(18), @no_edition int, @no_pages int, @ubication varchar(50), @bookdesc varchar(350), @editorial_id int, @countries_id int,@languages_id int,@subject_id int,@authorsid int
as
update books  
set title=@title, quantity=@quantity, isbn=@isbn, no_edition=@no_edition, no_pages=@no_pages, ubication=@ubication, bookdescription=@bookdesc, editorial_id=@editorial_id,countries_id=@countries_id, languages_id=@languages_id,subject_id=@subject_id
where book_id=@id

update authors_books
set authors_id= @authorsid
where books_id=@id



