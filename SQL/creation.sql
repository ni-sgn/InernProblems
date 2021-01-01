CREATE DATABASE School;
use School;

CREATE TABLE Teacher
(
teacher_id int unsigned not null AUTO_INCREMENT,
first_name varchar(255) not null,
last_name varchar(255) not null,
sex varchar(255) not null,
subject varchar(255) not null,
primary key(teacher_id)
);


CREATE TABLE Pupil
(
pupil_id int unsigned not null AUTO_INCREMENT,
first_name varchar(255) not null,
last_name varchar(255) not null,
sex varchar(255) not null,
grade smallint not null,
primary key(pupil_id)
);

CREATE TABLE Teaching
(
teaching_pupil_id int not null,
teaching_teacher_id int not null,
foreign key(teaching_pupil_id) references Pupil(pupil_id) ON DELETE CASCADE ON UPDATE CASCADE,
foreign key(teaching_teacher_id) references Teacher(teacher_id) ON DELETE CASCADE ON UPDATE CASCADE,
primary key(teaching_teacher_id, teaching_pupil_id)
);

INSERT INTO Teacher(first_name, last_name, sex, subject) values("Bertrand", "Russell", "male", "Logic");

INSERT INTO Pupil(first_name, last_name, sex, grade) values("Giorgi", "Smith", "male", 8);

INSERT INTO Teaching(teaching_pupil_id, teaching_teacher_id) values(1,1)


