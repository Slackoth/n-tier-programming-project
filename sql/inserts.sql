insert into users(first_name,last_name,email,user_psswd,user_role) 
values('Luis','Perla','admin1@empresa.com','admin1', 1);
insert into users(first_name,last_name,email,user_psswd,user_role) 
values('Rene','Meléndez','admin2@empresa.com','admin2', 1);
insert into users(first_name,last_name,email,user_psswd,user_role) 
values('Manuel','Palacios','docente1@empresa.com','docente1', 0);
insert into users(first_name,last_name,email,user_psswd,user_role) 
values('Lisa','Padilla','docente2@empresa.com','docente2', 0);
insert into users(first_name,last_name,email,user_psswd,user_role) 
values('Melanie','Sanchez','docente3@empresa.com','docente3', 0);
insert into users(first_name,last_name,email,user_psswd,user_role) 
values('Diana','Castillos','docente4@empresa.com','docente4', 0);
insert into users(first_name,last_name,email,user_psswd,user_role) 
values('Henry','Reyes','docente5@empresa.com','docente5', 0);

insert into authors(first_name,last_name) values('John','Tolkien');
insert into authors(first_name,last_name) values('Patrick','Rothfuss');
insert into authors(first_name,last_name) values('Scott','Lynch');
insert into authors(first_name,last_name) values('Brandon','Sanderson');
insert into authors(first_name,last_name) values('Ursula','Le Guin');
insert into authors(first_name,last_name) values('George','Martin');
insert into authors(first_name,last_name) values('Robin','Hobb');
insert into authors(first_name,last_name) values('Nora','Jemisin');
insert into authors(first_name,last_name) values('Robert','Jordan');
insert into authors(first_name,last_name) values('Leigh','Bardugo');

insert into editorials(editorial_name) values('Minotauro');
insert into editorials(editorial_name) values('Acantilado');
insert into editorials(editorial_name) values('Aguilar');
insert into editorials(editorial_name) values('Alba');
insert into editorials(editorial_name) values('Akal');
insert into editorials(editorial_name) values('Alfaguara');
insert into editorials(editorial_name) values('Alianza');
insert into editorials(editorial_name) values('Almadía');
insert into editorials(editorial_name) values('Anagrama');
insert into editorials(editorial_name) values('Ariel');

insert into country(country_name) values('Inglaterra');
insert into country(country_name) values('Estados Unidos');

insert into languages(language_name) values('Español');
insert into languages(language_name) values('Inglés');

insert into subjects(subject_name) values('Aventura');
insert into subjects(subject_name) values('Fantasía');
insert into subjects(subject_name) values('Alta Fantasía');
insert into subjects(subject_name) values('Fantasía Heroíca');
insert into subjects(subject_name) values('Fantasía Épica');

insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('The Lord of the Rings',3,'978-0-261-10263-7',5,9250,'Nivel 1, estanteria T',
'La novela narra el viaje del protagonista principal, Frodo Bolsón, hobbit de la Comarca, para destruir el Anillo Único',
1,1,2,1);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('El camino de los reyes',3,'978-0-7653-2635-5',1,1007,'Nivel 2, estanteria B',
'El camino de los reyes es una novela de fantasía épica escrita por el autor estadounidense Brandon Sanderson',
2,2,1,2);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('Las mentiras de Locke Lemora',4,'0-553-80467-7',3,499,'Nivel 3, estanteria S',
'La vida de un huérfano suele ser dura y breve en Camorr, una ciudad de canales, palacios y templos, construida sobre las ruinas de una raza desaparecida',
3,2,2,3);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('El nombre del viento',4,'978-0-7564-0407-9',3,662,'Nivel 1, estanteria P',
'Es una novela de fantasía épica, perteneciente a la serie Crónica del Asesino de Reyes, escrita por Patrick Rothfuss',
4,2,1,4);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('Un mago de Terramar',5,'978-0-0407-9',3,205,'Nivel 2, estanteria U',
'Una novela del género de fantasía, publicada en 1968 y escrita por Ursula K. Le Guin. Ganadora de diversos premios, entre ellos el Premio Nébula y el Premio Hugo',
5,2,2,5);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('Juego de tronos',5,'0-553-10354-7',10,694,'Nivel 3, estanteria G',
'Es una novela de fantasía escrita por el autor estadounidense George R. R. Martin en 1996 y ganadora del premio Locus a la mejor novela de fantasía en 1997',
6,2,1,1);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('Aprendiz de asesino',3,'0-00-224606-6',6,400,'Nivel 1, estanteria M',
'Nadie confía en él... pero el futuro del reino está en sus manos.',
7,2,1,2);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('La quinta estación',10,'978-0-356-50819-1',2,512,'Nivel 1, estanteria N',
'Es una novela de ficción especulativa escrita por la autora estadounidense N. K. Jemisin y publicada en agosto de 2015',
8,2,2,3);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('El ojo del mundo',7,'978-0-356-50819-1',7,782,'Nivel 2, estanteria R',
'Es una novela de fantasía del escritor estadounidense Robert Jordan y el primer libro de la serie La rueda del tiempo',
9,2,1,4);
insert into books(title, quantity, isbn, no_edition, no_pages, ubication, bookdescription, editorial_id, countries_id, 
languages_id, subject_id) 
values('Seis cuervos',8,'978-1522609735',8,465,'Nivel 3, estanteria L',
'La historia sigue a un grupo de ladrones y se desarrolla principalmente en la ciudad de Ketterdam',
10,1,2,5);

insert into authors_books(books_id,authors_id) values(1,1);
insert into authors_books(books_id,authors_id) values(2,2);
insert into authors_books(books_id,authors_id) values(3,3);
insert into authors_books(books_id,authors_id) values(4,4);
insert into authors_books(books_id,authors_id) values(5,5);
insert into authors_books(books_id,authors_id) values(6,6);
insert into authors_books(books_id,authors_id) values(7,7);
insert into authors_books(books_id,authors_id) values(8,8);
insert into authors_books(books_id,authors_id) values(9,9);
insert into authors_books(books_id,authors_id) values(10,10);

--Book 1
insert into copies(books_id,copie_state) values(1,1);
insert into copies(books_id,copie_state) values(1,1);
insert into copies(books_id,copie_state) values(1,1);
--Book 2
insert into copies(books_id,copie_state) values(2,1);
insert into copies(books_id,copie_state) values(2,1);
insert into copies(books_id,copie_state) values(2,1);
--Book 3
insert into copies(books_id,copie_state) values(3,1);
insert into copies(books_id,copie_state) values(3,1);
insert into copies(books_id,copie_state) values(3,1);
insert into copies(books_id,copie_state) values(3,1);
--Book 4
insert into copies(books_id,copie_state) values(4,1);
insert into copies(books_id,copie_state) values(4,1);
insert into copies(books_id,copie_state) values(4,1);
insert into copies(books_id,copie_state) values(4,1);
--Book 5
insert into copies(books_id,copie_state) values(5,1);
insert into copies(books_id,copie_state) values(5,1);
insert into copies(books_id,copie_state) values(5,1);
insert into copies(books_id,copie_state) values(5,1);
insert into copies(books_id,copie_state) values(5,1);
--Book 6
insert into copies(books_id,copie_state) values(6,1);
insert into copies(books_id,copie_state) values(6,1);
insert into copies(books_id,copie_state) values(6,1);
insert into copies(books_id,copie_state) values(6,1);
insert into copies(books_id,copie_state) values(6,1);
--Book 7
insert into copies(books_id,copie_state) values(7,1);
insert into copies(books_id,copie_state) values(7,1);
insert into copies(books_id,copie_state) values(7,1);
--Book 8 
insert into copies(books_id,copie_state) values(8,1);
insert into copies(books_id,copie_state) values(8,1);
insert into copies(books_id,copie_state) values(8,1);
insert into copies(books_id,copie_state) values(8,1);
insert into copies(books_id,copie_state) values(8,1);
insert into copies(books_id,copie_state) values(8,1);
insert into copies(books_id,copie_state) values(8,0);
insert into copies(books_id,copie_state) values(8,0);
insert into copies(books_id,copie_state) values(8,0);
insert into copies(books_id,copie_state) values(8,0);
--Book 9
insert into copies(books_id,copie_state) values(9,1);
insert into copies(books_id,copie_state) values(9,1);
insert into copies(books_id,copie_state) values(9,1);
insert into copies(books_id,copie_state) values(9,1);
insert into copies(books_id,copie_state) values(9,0);
insert into copies(books_id,copie_state) values(9,0);
insert into copies(books_id,copie_state) values(9,0);
--Book 10
insert into copies(books_id,copie_state) values(10,1);
insert into copies(books_id,copie_state) values(10,1);
insert into copies(books_id,copie_state) values(10,1);
insert into copies(books_id,copie_state) values(10,1);
insert into copies(books_id,copie_state) values(10,0);
insert into copies(books_id,copie_state) values(10,0);
insert into copies(books_id,copie_state) values(10,0);
insert into copies(books_id,copie_state) values(10,0);