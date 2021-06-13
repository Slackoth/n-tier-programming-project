create table  users(
	users_id int primary key identity,
	first_name varchar(150) not null, 
	last_name varchar(150) not null,
	email varchar(50) not null, 
	user_psswd varchar(50) not null,
	user_role bit 
);

create table subjects(
	subjects_id int primary key identity,
	subject_name varchar(150),
);

create table editorials(
	editorial_id int primary key identity,
	editorial_name varchar(150),
);

create table country(
	country_id int primary key identity,
	country_name varchar(150),
);

create table languages(
	language_id int primary key identity,
	language_name varchar(150),
);

create table authors(
	authors_id int primary key identity,
	first_name varchar(150),
	last_name varchar(150)
);

create table books(
	book_id int primary key identity, 
	title varchar(150),
	quantity int, 
	isbn varchar(18),
	no_edition int, 
	no_pages int, 
	ubication varchar(50),
	bookdescription varchar(350),
	editorial_id int, 
	countries_id int, 
	languages_id int, 
	subject_id int 

	--references
	foreign key (editorial_id) references editorials(editorial_id),
	foreign key (countries_id) references country(country_id),
	foreign key (languages_id) references languages(language_id),
	foreign key (subject_id) references subjects(subjects_id)
);

create table authors_books(
	books_id int, 
	authors_id int, 

	foreign key (books_id) references books(book_id),
	foreign key (authors_id) references authors(authors_id)
);

create table copies(
	copies_id int primary key identity,
	books_id int,
	copie_state bit,
	
	--references
	foreign key (books_id) references books(book_id),
);

create  table loans(
	loan_id int primary key identity,
	loan_date date,
	loan_devolution date,
	returned bit,
	copies_id int, 
	users_id int, 

	--references
	foreign key (copies_id) references copies(copies_id),
	foreign key (users_id) references users(users_id)
);

