#create database escola;
#use escola;
CREATE TABLE Cadastro (
ID_Cadastro INT PRIMARY KEY,
Nome VARCHAR(255),
Sobrenome VARCHAR(255),
Email VARCHAR(255),
Telefone VARCHAR(20),
Data_Nascimento DATE
-- Adicione mais campos conforme necessário
);
INSERT INTO Cadastro VALUES
(1, "João", "Silva", "joao@email.com", "123-456-7890", "1990-01-15"),
(2, "Maria", "Oliveira", "maria@email.com", "987-654-3210", "1985-05-20"),
(3, "Carlos", "Santos", "carlos@email.com", "111-222-3333", "1980-08-10"),
(41, "Fernanda", "Ribeiro", "fernanda@email.com", "333-444-5555", "1993-04-12"),
(42, "Ricardo", "Almeida", "ricardo@email.com", "666-777-8888", "1988-09-22"),
(43, "Amanda", "Pereira", "amanda@email.com", "222-333-4444", "1997-12-05"),
(44, "Daniel", "Mendes", "daniel@email.com", "999-888-7777", "1983-06-17"),
(45, "Juliana", "Cunha", "juliana@email.com", "555-444-3333", "1991-02-28"),
(46, "Rafael", "Lopes", "rafael@email.com", "777-666-5555", "1986-10-14"),
(47, "Gabriela", "Rodrigues", "gabriela@email.com", "444-555-6666", "1990-07-08"),
(48, "Lucas", "Costa", "lucas@email.com", "888-999-0000", "1984-03-31"),
(49, "Isabel", "Ferreira", "isabel@email.com", "111-222-3333", "1996-11-24"),
(50, "Victor", "Santos", "victor@email.com", "666-777-8888", "1989-08-16"),
(51, "Carolina", "Lima", "carolina@email.com", "333-444-5555", "1992-04-18"),
(52, "Eduardo", "Oliveira", "eduardo@email.com", "999-888-7777", "1987-01-27"),
(53, "Patricia", "Silva", "patricia@email.com", "555-444-3333", "1994-09-10"),
(54, "Hugo", "Cunha", "hugo@email.com", "777-666-5555", "1985-06-23"),
(55, "Beatriz", "Ribeiro", "beatriz@email.com", "444-555-6666", "1998-02-15"),
(56, "Marcelo", "Mendes", "marcelo@email.com", "888-999-0000", "1982-12-07"),
(57, "Tatiane", "Pereira", "tatiane@email.com", "111-222-3333", "1995-10-30"),
(58, "Luiz", "Lopes", "luiz@email.com", "666-777-8888", "1980-07-22"),
(59, "Cristina", "Rodrigues", "cristina@email.com", "333-444-5555", "1993-05-03"),
(60, "Paulo", "Costa", "paulo@email.com", "999-888-7777", "1986-01-16"),
(61, "Fernando", "Ferreira", "fernando@email.com", "555-444-3333", "1991-09-29"),
(62, "Simone", "Santos", "simone@email.com", "777-666-5555", "1988-04-11"),
(63, "Roberto", "Lima", "roberto@email.com", "444-555-6666", "1994-12-24"),
(64, "Celia", "Oliveira", "celia@email.com", "888-999-0000", "1983-10-07"),
(65, "Marcos", "Silva", "marcos@email.com", "111-222-3333", "1996-07-20"),
(66, "Leticia", "Cunha", "leticia@email.com", "666-777-8888", "1989-05-02"),
(67, "Gustavo", "Rodrigues", "gustavo@email.com", "333-444-5555", "1984-02-14"),
(68, "Camila", "Costa", "camila@email.com", "999-888-7777", "1990-10-27"),
(69, "Felipe", "Ferreira", "felipe@email.com", "555-444-3333", "1985-08-09"),
(70, "Tania", "Santos", "tania@email.com", "777-666-5555", "1992-03-22");

#1
select * from cadastro;
#2
select nome,email from cadastro limit 5;
#3
update cadastro set telefone = "113-456" where ID_cadastro = 3;
#4
delete from cadastro where ID_cadastro = 6;
#5
insert into cadastro values ("7","miguel","luiz","ml@gmail.com","777","8007-0238");
#6
select * from cadastro where nome like  "A%";
#7
select * from cadastro where datadenacimento > "1990-01-01";
#8
update cadastro set sobrenome = "pereira" where nome like "Ana";
#9
delete from cadastro where telefone = "555-444-333";
#10
select  nome,email from cadastro where email like  "%email.com";
#11
select nome,sobrenome,telefone from cadastro where Telefone is not null;
#12
update cadastro set Data_Nascimento = "1985-05-01" where sobrenome like "silva";
#13
delete from cadastro where Data_Nascimento < "1980-01-01"; 
#14
select nome,Data_Nascimento from cadastro where curdate() - Data_Nascimento > 30;
#15
select * from cadastro order by nome DESC;
#16
update cadastro set email = "novo@gmail.com" where telefone = "987-654-3210";
#17
delete from cadastro where nome = "Maria";
#18
select nome,telefone from cadastro where telefone not like "555%";
#19
select * from cadastro where nome or sobrenome like "%a%";
#20
update cadastro set sobrenome = "Oliveira" where sobrenome like "Silva"; 
#21
delete from cadastro where email is null;
#22
select length(nome) , nome from cadastro;
#23
select * from cadastro where telefone like "%8888";
#24
update cadastro set telefone = "111-111-1111" where email like "%gmail%";
#25(pular se q falo isso so)
#delete from cadastro where email like email;
#26
select * from cadastro where nome like "joão" or sobrenome like "oliveira";
#27
select nome,email from cadastro where email is null;
#28
update cadastro set sobrenome = "ferreira" where nome like "carlos";
#29
delete from cadastro where email not like "%@%";
#30
select nome,sobrenome,telefone from cadastro where telefone like "777%";