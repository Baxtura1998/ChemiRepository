--Bazis Sheqmna--
create database Meshvide_Davaleba
use Meshvide_Davaleba

--Teacher-is Cxrilis Sheqmna Arsebobis Kontrolit--
if object_id('Teacher','u')
is not null
drop table Teacher
go
create table Teacher
(
TeacherId int primary key not null,
TeacherName nvarchar(50) ,
TeacherLastName nvarchar(50) ,
TeacherGender nvarchar(50),
Subjects nvarchar(50),
)

--Pupil-is Cxrilis Sheqmna Arsebobis Kontrolit--
if object_id('Pupil','u')
is not null
drop table Pupil
go 
create table Pupil
(
PupilId int primary key,
PupilName nvarchar(50) ,
PupilLastName nvarchar(50) ,
PupilGender nvarchar(50),
Grade nvarchar(50) not null
)

--Relaciis Damateba
if object_id('Relation','u')
is not null
drop table Relation
go
create table Relation
(
RelationId int primary key not null,
TeacherId int not null,
PupilId int not null,
foreign key(TeacherId) references Teacher(TeacherId) ,
foreign key(PupilId) references Pupil(PupilId),
)

insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('1','Nikoloz','Bakhtadze','Mamrobiti','Daprogrameba')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('2','Elene','Lolashvili','Mdedrobiti','Matematika')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('3','Salome','Chkadua','Mdedrobiti','Qartuli')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('4','Tinatin','Gogshelidze','Mdedrobiti','Inglisuri')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('5','Mikheil','Amilaxvari','Mamrobiti','Rusuli')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('6','Guram','Amisulashvili','Mamrobiti','Biologia')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('7','Tiniko','Gulua','Mdedrobiti','Qimia')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('8','Davit','Samxaradze','Mamrobiti','Xelovneba')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('9','Zurab','Gigineishvili','Mamrobiti','Istoria')
insert into Teacher(TeacherId,TeacherName,TeacherLastName,TeacherGender,Subjects) values ('10','Mariam','Bendeliani','Mdedrobiti','Fizika')


insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('1','Giorgi','Ochiauri','Mamrobiti','5')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('2','Kaxa','Onashvili','Mamrobiti','7')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('3','Giorgi','Qvemoklidze','Mamrobiti','3')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('4','Mariam','Xelashvili','Mdedrobiti','12')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('5','Viqtoria','Arabidze','Mdedrobiti','10')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('6','Salome','Beqauri','Mdedrobiti','8')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('7','Ana','Arabuli','Mdedrobiti','6')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('8','Nikoloz','Sarjveladze','Mamrobiti','9')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('9','Tamar','Orjonikidze','Mdedrobiti','5')
insert into Pupil(PupilId,PupilName,PupilLastName,PupilGender,Grade) values ('10','Giorgi','Bakhtadze','Mamrobiti','11')




select Pupil.PupilId,Pupil.PupilName,Pupil.PupilLastName,Pupil.Grade,Teacher.TeacherId,Teacher.TeacherName,Teacher.TeacherLastName,Teacher.Subjects
from Pupil 
left join Teacher
on Pupil.PupilId=Teacher.TeacherId
left join Relation on Teacher.TeacherId=Relation.RelationId where Pupil.PupilName='Giorgi'