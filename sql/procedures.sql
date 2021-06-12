create or alter procedure sign_in_user
@email varchar(50), @password varchar(50)
as
select users_id, first_name, last_name, email, user_role
from users where email = @email and user_psswd = @password
GO