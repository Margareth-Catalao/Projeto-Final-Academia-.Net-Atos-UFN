create database Biblioteca_db;



create login usuarioBiblioteca with password='andrade2021';
create user usuarioBiblioteca from login usuarioBiblioteca;

exec sp_addrolemember 'DB_DATAREADER', 'usuarioBiblioteca';
exec sp_addrolemember 'DB_DATAWRITER', 'usuarioBiblioteca';

select *
from Livros

select *
from Leitores

select *
from Emprestimos

