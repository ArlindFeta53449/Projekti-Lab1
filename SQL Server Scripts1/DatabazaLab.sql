create database DatabazaLab;

use DatabazaLab;

create table Studenti(
Id int primary key,
Emaili nvarchar(100),
Nr_Letenjoftimit int,
Emri nvarchar (50),
Emri_Prindit nvarchar(50),
Mbiemri nvarchar(50),
Gjinia nvarchar(15) check(Gjinia in ('Mashkull', 'Femer')),
Ditelindja date,
Vendlindja nvarchar (50)
);

create table Profesori(
Id int primary key,
Emaili nvarchar(100),
Nr_Letenjoftimit int,
Emri nvarchar (50),
Emri_Prindit nvarchar(50),
Mbiemri nvarchar(50),
Gjinia nvarchar(15) check(Gjinia in ('Mashkull', 'Femer')),
Ditelindja date,
Vendlindja nvarchar (50)
);

create table Lenda(
Id_Lendes int primary key,
Emri_Lendes nvarchar(50),
Statusi nvarchar(50) check(Statusi in ('Obligative','Zgjedhore'))
);
create table Njoftimi(
Id_Njoftimit int primary key,
Pershkrimi_Njoftimit nvarchar(250),
Data_njoftimit date
);
insert into Studenti values(1,'arlindfeta@gmail.com',1,'Arlind','Azem','Feta','Mashkull','1/1/2002','Podujeve');